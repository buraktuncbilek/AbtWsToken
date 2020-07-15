using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AbtWsToken
{
    internal static class Generate
    {
        private static readonly string BackupFileLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wstoken.liste");
        private static System.Globalization.CultureInfo _trCulture = new System.Globalization.CultureInfo("tr-TR");
        internal static string Token(TokenType _tt)
        {
            switch (_tt)
            {
                case TokenType.FormattedGuid: return Guid.NewGuid().ToString("D");
                case TokenType.NonFormattedGuid: return Guid.NewGuid().ToString("N");
                case TokenType.RamdomString22: return RandomString(22);
                case TokenType.RandomMD5: return Calculate_MD5_UTF8(RandomString(40));
                default: return Calculate_MD5_UTF8($"{DateTime.Now:dd.MM.yyyy HH:mm:ss:ff}");
            }
        }


        internal static DateTime ExpireDate(ExpireType _et)
        {
            var simdi = DateTime.Now.AddMilliseconds(888); // Biraz tolerans tanıyalım :) 
            switch (_et)
            {
                case ExpireType.Auto12hour: return simdi.AddHours(12);
                case ExpireType.Auto15min: return simdi.AddMinutes(15);
                case ExpireType.Auto1day: return simdi.AddDays(1);
                case ExpireType.Auto1hour: return simdi.AddHours(1);
                case ExpireType.Auto30min: return simdi.AddMinutes(30);
                case ExpireType.Auto6hour: return simdi.AddHours(6);
                //case ExpireType.UserSet:return simdi.AddMilliseconds(-888);
                default: return simdi.AddMilliseconds(-888);
            }
        }

        internal static DateTime ExpireDate(TimeSpan _ts) //Override => TimeSpan ile
        {
            //return DateTime.Now.AddMilliseconds(888 + _ts.TotalMilliseconds); // biraz zaman ve toplam milisaniyeyi şimdiki zamana ekle [İPTAL] ms ekleme double taşmasına sebep olabilir.
            return DateTime.Now.AddMilliseconds(888).AddSeconds(_ts.TotalSeconds); // milisaniye eklemek double tipinin max değerini aşabilir, saniye olarak ekle.
        }

        public static bool SaveCurrentState(Dictionary<string, DateTime> liste)
        {
            try
            {
                List<string> _lines = new List<string>();
                liste.ToList().ForEach(x => _lines.Add($"[{x.Value.ToOADate().ToString(_trCulture)}],[{x.Key}]"));
                File.AppendAllLines(BackupFileLocation, _lines, Encoding.UTF8);
                return true;
            }
            catch (Exception ex)
            {
                throw ex; // veya ex.Message / ex.InnerException.Message değerlerini döndür.
                return false;
            }
        }

        public static bool LoadSavedState(ref Dictionary<string, DateTime> liste)
        {
            try
            {
                string[] lines = File.ReadAllLines(BackupFileLocation, Encoding.UTF8);
                foreach (var satir in lines)
                {
                    //string token = satir.Split(',')[1].Substring(1).Replace("]", ""); // baştaki [ ve sondaki ] işaretlerini kaldır.
                    //double oaDate = Convert.ToDouble(satir.Split(',')[0].Substring(1).Replace("]", ""), _trCulture);
                    liste.Add(
                        satir.Split(',')[1].Substring(1).Replace("]", ""),
                        DateTime.FromOADate(Convert.ToDouble(satir.Split(',')[0].Substring(1).Replace("]", ""), _trCulture))
                        );
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex; // veya ex.Message / ex.InnerException.Message değerlerini döndür.
                return false;
            }
        }



        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ@123456789*"; //0 O I kaldırıldı @ * eklendi
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string Calculate_MD5_UTF8(string s)
        {
            var md = System.Security.Cryptography.MD5.Create();

            byte[] data = md.ComputeHash(Encoding.UTF8.GetBytes(s));
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
                sb.Append(data[i].ToString("x2"));

            return sb.ToString();
        }

    }
}
