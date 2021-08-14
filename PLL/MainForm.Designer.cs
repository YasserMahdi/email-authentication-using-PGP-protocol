
namespace Email_Auth.PLL
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnKeuGen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SecritKayTxt = new System.Windows.Forms.TextBox();
            this.HashBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtHash = new System.Windows.Forms.TextBox();
            this.GetSecretKeyBtn = new System.Windows.Forms.Button();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btnkeys = new System.Windows.Forms.Button();
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.rawTextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptedTextBox = new System.Windows.Forms.TextBox();
            this.decryptedTextBox = new System.Windows.Forms.TextBox();
            this.BtnSigning = new System.Windows.Forms.Button();
            this.BtnVerifySigning = new System.Windows.Forms.Button();
            this.TxtSigned = new System.Windows.Forms.TextBox();
            this.SignedTxtDecipher = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 364);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(578, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnKeuGen
            // 
            this.BtnKeuGen.Location = new System.Drawing.Point(46, 22);
            this.BtnKeuGen.Name = "BtnKeuGen";
            this.BtnKeuGen.Size = new System.Drawing.Size(125, 33);
            this.BtnKeuGen.TabIndex = 2;
            this.BtnKeuGen.Text = "Generate PQ";
            this.BtnKeuGen.UseVisualStyleBackColor = true;
            this.BtnKeuGen.Click += new System.EventHandler(this.BtnKeuGen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "HMAC";
            // 
            // SecritKayTxt
            // 
            this.SecritKayTxt.Location = new System.Drawing.Point(62, 486);
            this.SecritKayTxt.Multiline = true;
            this.SecritKayTxt.Name = "SecritKayTxt";
            this.SecritKayTxt.Size = new System.Drawing.Size(539, 76);
            this.SecritKayTxt.TabIndex = 4;
            // 
            // HashBtn
            // 
            this.HashBtn.Location = new System.Drawing.Point(23, 568);
            this.HashBtn.Name = "HashBtn";
            this.HashBtn.Size = new System.Drawing.Size(286, 29);
            this.HashBtn.TabIndex = 5;
            this.HashBtn.Text = "Hash Value";
            this.HashBtn.UseVisualStyleBackColor = true;
            this.HashBtn.Click += new System.EventHandler(this.HashBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtHash);
            this.groupBox1.Controls.Add(this.GetSecretKeyBtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HashBtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.SecritKayTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 603);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash Function";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "hashed value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Orginal Value";
            // 
            // TxtHash
            // 
            this.TxtHash.Location = new System.Drawing.Point(315, 81);
            this.TxtHash.Multiline = true;
            this.TxtHash.Name = "TxtHash";
            this.TxtHash.Size = new System.Drawing.Size(286, 364);
            this.TxtHash.TabIndex = 7;
            // 
            // GetSecretKeyBtn
            // 
            this.GetSecretKeyBtn.Location = new System.Drawing.Point(23, 451);
            this.GetSecretKeyBtn.Name = "GetSecretKeyBtn";
            this.GetSecretKeyBtn.Size = new System.Drawing.Size(286, 29);
            this.GetSecretKeyBtn.TabIndex = 6;
            this.GetSecretKeyBtn.Text = "Get Secret Key";
            this.GetSecretKeyBtn.UseVisualStyleBackColor = true;
            this.GetSecretKeyBtn.Click += new System.EventHandler(this.GetSecretKeyBtn_Click);
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(46, 61);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(125, 27);
            this.pTextBox.TabIndex = 7;
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(46, 94);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(125, 27);
            this.qTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "p";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "q";
            // 
            // Btnkeys
            // 
            this.Btnkeys.Location = new System.Drawing.Point(609, 26);
            this.Btnkeys.Name = "Btnkeys";
            this.Btnkeys.Size = new System.Drawing.Size(125, 91);
            this.Btnkeys.TabIndex = 11;
            this.Btnkeys.Text = "Compute DE";
            this.Btnkeys.UseVisualStyleBackColor = true;
            this.Btnkeys.Click += new System.EventHandler(this.Btnkeys_Click);
            // 
            // eTextBox
            // 
            this.eTextBox.Location = new System.Drawing.Point(478, 61);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(125, 27);
            this.eTextBox.TabIndex = 13;
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(478, 28);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(125, 27);
            this.nTextBox.TabIndex = 12;
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(478, 94);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(125, 27);
            this.dTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "e";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "d";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(729, 636);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(94, 29);
            this.encryptButton.TabIndex = 19;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // rawTextBox
            // 
            this.rawTextBox.Location = new System.Drawing.Point(729, 193);
            this.rawTextBox.Multiline = true;
            this.rawTextBox.Name = "rawTextBox";
            this.rawTextBox.Size = new System.Drawing.Size(657, 64);
            this.rawTextBox.TabIndex = 20;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(829, 636);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(94, 29);
            this.decryptButton.TabIndex = 21;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(729, 263);
            this.encryptedTextBox.Multiline = true;
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.encryptedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptedTextBox.Size = new System.Drawing.Size(657, 61);
            this.encryptedTextBox.TabIndex = 22;
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(729, 330);
            this.decryptedTextBox.Multiline = true;
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.Size = new System.Drawing.Size(657, 64);
            this.decryptedTextBox.TabIndex = 23;
            this.decryptedTextBox.TextChanged += new System.EventHandler(this.decryptedTextBox_TextChanged);
            // 
            // BtnSigning
            // 
            this.BtnSigning.Location = new System.Drawing.Point(929, 636);
            this.BtnSigning.Name = "BtnSigning";
            this.BtnSigning.Size = new System.Drawing.Size(94, 29);
            this.BtnSigning.TabIndex = 24;
            this.BtnSigning.Text = "Signing";
            this.BtnSigning.UseVisualStyleBackColor = true;
            this.BtnSigning.Click += new System.EventHandler(this.BtnSigning_Click);
            // 
            // BtnVerifySigning
            // 
            this.BtnVerifySigning.Location = new System.Drawing.Point(1029, 636);
            this.BtnVerifySigning.Name = "BtnVerifySigning";
            this.BtnVerifySigning.Size = new System.Drawing.Size(126, 29);
            this.BtnVerifySigning.TabIndex = 25;
            this.BtnVerifySigning.Text = "Verify Signing";
            this.BtnVerifySigning.UseVisualStyleBackColor = true;
            this.BtnVerifySigning.Click += new System.EventHandler(this.BtnVerifySigning_Click);
            // 
            // TxtSigned
            // 
            this.TxtSigned.Location = new System.Drawing.Point(729, 447);
            this.TxtSigned.Multiline = true;
            this.TxtSigned.Name = "TxtSigned";
            this.TxtSigned.Size = new System.Drawing.Size(657, 92);
            this.TxtSigned.TabIndex = 26;
            // 
            // SignedTxtDecipher
            // 
            this.SignedTxtDecipher.Location = new System.Drawing.Point(729, 545);
            this.SignedTxtDecipher.Multiline = true;
            this.SignedTxtDecipher.Name = "SignedTxtDecipher";
            this.SignedTxtDecipher.Size = new System.Drawing.Size(657, 85);
            this.SignedTxtDecipher.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnKeuGen);
            this.groupBox2.Controls.Add(this.pTextBox);
            this.groupBox2.Controls.Add(this.qTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Btnkeys);
            this.groupBox2.Controls.Add(this.nTextBox);
            this.groupBox2.Controls.Add(this.eTextBox);
            this.groupBox2.Controls.Add(this.dTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(652, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 151);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithm input";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(652, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Plain Text";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(648, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Encrypted";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(645, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Decrypted";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(671, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Signed";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(652, 548);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "DeSigned";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1162, 635);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 29);
            this.button2.TabIndex = 34;
            this.button2.Text = "Verify hash value";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 709);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SignedTxtDecipher);
            this.Controls.Add(this.TxtSigned);
            this.Controls.Add(this.BtnVerifySigning);
            this.Controls.Add(this.BtnSigning);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.rawTextBox);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnKeuGen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecritKayTxt;
        private System.Windows.Forms.Button HashBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GetSecretKeyBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtHash;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btnkeys;
        private System.Windows.Forms.TextBox eTextBox;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox rawTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox encryptedTextBox;
        private System.Windows.Forms.TextBox decryptedTextBox;
        private System.Windows.Forms.Button BtnSigning;
        private System.Windows.Forms.Button BtnVerifySigning;
        private System.Windows.Forms.TextBox TxtSigned;
        private System.Windows.Forms.TextBox SignedTxtDecipher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
    }
}