using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbtWsToken
{
    public enum TokenType
    {
        /// <summary>
        /// <para>Örnek/Sample: 00000000000000000000000000000000</para>
        /// </summary>
        NonFormattedGuid = 0,
        /// <summary>
        /// Örnek/Sample: 00000000-0000-0000-0000-000000000000
        /// </summary>
        FormattedGuid = 1,
        /// <summary>
        /// Örnek/Sample: d41d8cd98f00b204e9800998ecf8427e
        /// </summary>
        RandomMD5 = 2,
        /// <summary>
        /// Örnek/Sample: MDBE92J@XAF*PESB4WH7X9
        /// </summary>
        RamdomString22 = 3
    }

    public enum ExpireType
    {
        /// <summary>
        /// <para>[tr] istenilen zaman aralığında.</para>
        /// <para>[en] within the desired time span.</para>
        /// </summary>
        UserSet = 0,
        Auto15min = 15,
        Auto30min = 30,
        Auto1hour = 60,
        Auto6hour = 120,
        Auto12hour = 240,
        Auto1day = 999
    }

    internal class Instance
    {
        public TokenType _WsTokenType { get; set; } = TokenType.FormattedGuid;
        public ExpireType _WsExpType { get; set; } = ExpireType.UserSet;

        public Dictionary<string, DateTime> liste;
    }
    public static class WsToken
    {
        private static Instance _ins;
        public static bool Init()
        {
            if (_ins is null)
            {
                _ins = new Instance();
                _ins.liste = new Dictionary<string, DateTime>();
                return true;
            }
            else
            {
                throw new ApplicationException("[tr] WsToken zaten başlatılmış! [en] WsToken is already initialized!");
                return false;
            }
        }

        public static bool Init(TokenType WsTokenType, ExpireType WsExpireType)
        {
            if (_ins is null)
            {
                _ins = new Instance();
                _ins._WsTokenType = WsTokenType;
                _ins._WsExpType = WsExpireType;

                _ins.liste = new Dictionary<string, DateTime>();
                return true;
            }
            else
            {
                throw new ApplicationException("[tr] WsToken zaten başlatılmış! [en] WsToken is already initialized!");
                return false;
            }
        }

        public static bool LoadState()
        {
            //liste.abt dosyası varsa oku yoksa normal başlat
            /*Dosya yapısı: [ (double)DateTime.ToOADate() ],[ (string)Token ]
             * double ToString tr-TR CultureInfo ile yapılacak.
             * Örnek Yapı
             * [44012,8043171296],[MDBE92J@XAF*PESB4WH7X9]
             * [42989,4765393519],[d41d8cd98f00b204e9800998ecf8427e]
             * [873],[00000000000000000000000000000000]
             * [43831,0423726852],[00000000-0000-0000-0000-000000000000]
             * 
             */
            return Generate.LoadSavedState(ref _ins.liste);
        }

        public static bool SaveCurrentState()
        {
            //liste.abt dosyasına kaydet
            return Generate.SaveCurrentState(_ins.liste);
        }

        public static bool IsInit()
        {
            return !(_ins is null);
        }

        /// <summary>
        /// <para>[tr] TokenType ve ExpireType kullanarak token oluşturur.</para>
        /// <para>[en] Generate token with using TokenType and ExpireType</para>
        /// </summary>
        /// <returns>
        /// <para>[tr] TokenType uygun olarak string tipinde token döner</para>
        /// <para>[en] Returns string token by according TokenType</para>
        /// </returns>
        public static string GetToken()
        {
            if (_ins is null)
                throw new ApplicationException("[tr] Uygulamanın bir örneği başlatılmamış! [en] An instance of application is not started!");

            if (_ins._WsExpType == ExpireType.UserSet)
                throw new ApplicationException("[tr] ExpireType özelliği UserSet değerindeyken bu metot kullanılamaz! [en] This method not use because ExpireType is UserSet!");

            var token = Generate.Token(_ins._WsTokenType);
            var exp = Generate.ExpireDate(_ins._WsExpType);
            _ins.liste.Add(token, exp);
            ClearExpiredTokens();
            return token;
        }

        /// <summary>
        /// <para>[tr] TokenType ve parametre olarak verilen timespan ile token oluşturur.</para>
        /// <para>[en] Generate token with using TokenType and timespan given as parameter.</para>
        /// </summary>
        /// <param name="_expiration">
        /// <para>[tr] Sona erme zamanı [timespan]</para>
        /// <para>[en] Expire time [timespan]</para>
        /// </param>
        /// <returns>
        /// <para>[tr] TokenType uygun olarak string tipinde token döner</para>
        /// <para>[en] Returns string token by according TokenType</para>
        /// </returns>
        public static string GetTokenWithTimeSpan(TimeSpan _expiration)
        {
            if (_ins is null)
                throw new ApplicationException("[tr] Uygulamanın bir örneği başlatılmamış! [en] An instance of application is not started!");

            if (_ins._WsExpType != ExpireType.UserSet)
                throw new ApplicationException("[tr] ExpireType özelliği UserSet değerine eşit değilken bu metot kullanılamaz! [en] This method not use because ExpireType is not equals to UserSet!");

            var token = Generate.Token(_ins._WsTokenType);
            var exp = Generate.ExpireDate(_expiration);
            _ins.liste.Add(token, exp);
            ClearExpiredTokens();
            return token;
        }

        public static bool CheckTokenValidity(string _token)
        {
            ClearExpiredTokensSync();

            if (_ins is null)
                throw new ApplicationException("[tr] Uygulamanın bir örneği başlatılmamış! [en] An instance of application is not started!");

            var find = from x in _ins.liste where x.Key == _token select x.Value;
            if (find is null)
                return false;
            if (find.Count() <= 0)
                return false;
            return (find.ToList()[0] - DateTime.Now).TotalSeconds > 0;

        }

        public static void EndInit() //Dispose 
        {
            if (_ins is null)
                return;

            _ins.liste.Clear();
            _ins.liste = null;
            _ins = null;
            GC.Collect();
        }


        #region ClearExpiredTokens
        internal static void ClearExpiredTokens()
        {
            if (_ins is null)
                return;
            if (_ins.liste is null)
                return;

            var expiredTokens = from token in _ins.liste where token.Value <= DateTime.Now select token;
            if (expiredTokens.Count() > 0)
            {
                expiredTokens.ToList().ForEach(x => _ins.liste.Remove(x.Key));
            }
        }

        internal static async void ClearExpiredTokensSync()
        {
            await Task.Run(() =>
            {
                ClearExpiredTokens();
            });
        }
        #endregion


    }
}
