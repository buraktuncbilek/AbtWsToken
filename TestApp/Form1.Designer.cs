namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTokenType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxExpireType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonInitAndLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGetToken = new System.Windows.Forms.Button();
            this.buttonGetTokenWTS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSecond = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSaveState = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonInitAndLoad);
            this.groupBox1.Controls.Add(this.buttonInit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxExpireType);
            this.groupBox1.Controls.Add(this.comboBoxTokenType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1";
            // 
            // comboBoxTokenType
            // 
            this.comboBoxTokenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTokenType.FormattingEnabled = true;
            this.comboBoxTokenType.Location = new System.Drawing.Point(74, 17);
            this.comboBoxTokenType.Name = "comboBoxTokenType";
            this.comboBoxTokenType.Size = new System.Drawing.Size(228, 21);
            this.comboBoxTokenType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TokenType";
            // 
            // comboBoxExpireType
            // 
            this.comboBoxExpireType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpireType.FormattingEnabled = true;
            this.comboBoxExpireType.Location = new System.Drawing.Point(74, 44);
            this.comboBoxExpireType.Name = "comboBoxExpireType";
            this.comboBoxExpireType.Size = new System.Drawing.Size(228, 21);
            this.comboBoxExpireType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ExpireType";
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(9, 87);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(75, 23);
            this.buttonInit.TabIndex = 2;
            this.buttonInit.Text = "Inıt";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonInitAndLoad
            // 
            this.buttonInitAndLoad.Location = new System.Drawing.Point(233, 87);
            this.buttonInitAndLoad.Name = "buttonInitAndLoad";
            this.buttonInitAndLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonInitAndLoad.TabIndex = 3;
            this.buttonInitAndLoad.Text = "Init&Load";
            this.buttonInitAndLoad.UseMnemonic = false;
            this.buttonInitAndLoad.UseVisualStyleBackColor = true;
            this.buttonInitAndLoad.Click += new System.EventHandler(this.buttonInitAndLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxToken);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.buttonGetTokenWTS);
            this.groupBox2.Controls.Add(this.buttonGetToken);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2";
            // 
            // buttonGetToken
            // 
            this.buttonGetToken.Location = new System.Drawing.Point(9, 19);
            this.buttonGetToken.Name = "buttonGetToken";
            this.buttonGetToken.Size = new System.Drawing.Size(89, 23);
            this.buttonGetToken.TabIndex = 0;
            this.buttonGetToken.Text = "Get Token";
            this.buttonGetToken.UseVisualStyleBackColor = true;
            this.buttonGetToken.Click += new System.EventHandler(this.buttonGetToken_Click);
            // 
            // buttonGetTokenWTS
            // 
            this.buttonGetTokenWTS.Location = new System.Drawing.Point(139, 81);
            this.buttonGetTokenWTS.Name = "buttonGetTokenWTS";
            this.buttonGetTokenWTS.Size = new System.Drawing.Size(169, 23);
            this.buttonGetTokenWTS.TabIndex = 2;
            this.buttonGetTokenWTS.Text = "Get Token With TimeSpan";
            this.buttonGetTokenWTS.UseVisualStyleBackColor = true;
            this.buttonGetTokenWTS.Click += new System.EventHandler(this.buttonGetTokenWTS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDownSecond);
            this.groupBox3.Controls.Add(this.numericUpDownMinute);
            this.groupBox3.Controls.Add(this.numericUpDownHour);
            this.groupBox3.Location = new System.Drawing.Point(139, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 64);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TimeSpan";
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(7, 19);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownHour.TabIndex = 0;
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(67, 19);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownMinute.TabIndex = 1;
            // 
            // numericUpDownSecond
            // 
            this.numericUpDownSecond.Location = new System.Drawing.Point(122, 19);
            this.numericUpDownSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownSecond.Name = "numericUpDownSecond";
            this.numericUpDownSecond.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownSecond.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Minute";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Second";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Token:";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxToken.Location = new System.Drawing.Point(9, 118);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(299, 25);
            this.textBoxToken.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.buttonSaveState);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 117);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 3";
            // 
            // buttonSaveState
            // 
            this.buttonSaveState.Location = new System.Drawing.Point(12, 19);
            this.buttonSaveState.Name = "buttonSaveState";
            this.buttonSaveState.Size = new System.Drawing.Size(147, 23);
            this.buttonSaveState.TabIndex = 0;
            this.buttonSaveState.Text = "Save Current State";
            this.buttonSaveState.UseVisualStyleBackColor = true;
            this.buttonSaveState.Click += new System.EventHandler(this.buttonSaveState_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check is Init";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "End Init";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 402);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecond)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxExpireType;
        private System.Windows.Forms.ComboBox comboBoxTokenType;
        private System.Windows.Forms.Button buttonInitAndLoad;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGetTokenWTS;
        private System.Windows.Forms.Button buttonGetToken;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSecond;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSaveState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

