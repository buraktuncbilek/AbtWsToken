using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbtWsToken;


namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTokenType.DataSource = Enum.GetValues(typeof(TokenType));
            comboBoxExpireType.DataSource = Enum.GetValues(typeof(ExpireType));
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            TokenType _ttype = (AbtWsToken.TokenType)comboBoxTokenType.SelectedItem;
            ExpireType _extype = (AbtWsToken.ExpireType)comboBoxExpireType.SelectedItem;
            WsToken.Init(_ttype, _extype);
            buttonInit.Enabled = buttonInitAndLoad.Enabled = false;
        }

        private void buttonInitAndLoad_Click(object sender, EventArgs e)
        {
            buttonInit.PerformClick();
            //WsToken.LoadState();
            MessageBox.Show(WsToken.LoadState() ? "Loaded successfully" : "Load failed.");
        }

        private void buttonGetToken_Click(object sender, EventArgs e)
        {
            textBoxToken.Text = WsToken.GetToken();
        }

        private void buttonGetTokenWTS_Click(object sender, EventArgs e)
        {
            textBoxToken.Text = WsToken.GetTokenWithTimeSpan(new TimeSpan((int)numericUpDownHour.Value, (int)numericUpDownMinute.Value, (int)numericUpDownSecond.Value));
        }

        private void buttonSaveState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WsToken.SaveCurrentState() ? "Saved successfully" : "Error on save.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(WsToken.IsInit() ? "Initialized!" : "Not initialized!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WsToken.EndInit();
            MessageBox.Show("EndInit OK!");
            buttonInit.Enabled = buttonInitAndLoad.Enabled = true;
        }
    }
}
