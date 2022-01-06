namespace ccrack
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
            this.isCrackHash = new System.Windows.Forms.Button();
            this.getEncryptionMethod = new System.Windows.Forms.ComboBox();
            this.isLog = new System.Windows.Forms.CheckBox();
            this.getHashesToCrack = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ProgressBar();
            this.getWordlistFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isCrackHash
            // 
            this.isCrackHash.Location = new System.Drawing.Point(12, 209);
            this.isCrackHash.Name = "isCrackHash";
            this.isCrackHash.Size = new System.Drawing.Size(288, 26);
            this.isCrackHash.TabIndex = 0;
            this.isCrackHash.Text = "Crack Hash";
            this.isCrackHash.UseVisualStyleBackColor = true;
            this.isCrackHash.Click += new System.EventHandler(this.button1_Click);
            // 
            // getEncryptionMethod
            // 
            this.getEncryptionMethod.FormattingEnabled = true;
            this.getEncryptionMethod.Location = new System.Drawing.Point(12, 36);
            this.getEncryptionMethod.Name = "getEncryptionMethod";
            this.getEncryptionMethod.Size = new System.Drawing.Size(279, 21);
            this.getEncryptionMethod.TabIndex = 1;
            // 
            // isLog
            // 
            this.isLog.AutoSize = true;
            this.isLog.Location = new System.Drawing.Point(12, 186);
            this.isLog.Name = "isLog";
            this.isLog.Size = new System.Drawing.Size(74, 17);
            this.isLog.TabIndex = 2;
            this.isLog.Text = "Show Log";
            this.isLog.UseVisualStyleBackColor = true;
            this.isLog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // getHashesToCrack
            // 
            this.getHashesToCrack.Location = new System.Drawing.Point(12, 151);
            this.getHashesToCrack.Name = "getHashesToCrack";
            this.getHashesToCrack.Size = new System.Drawing.Size(279, 20);
            this.getHashesToCrack.TabIndex = 4;
            this.getHashesToCrack.TextChanged += new System.EventHandler(this.getHashesToCrack_TextChanged);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(12, 253);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(288, 26);
            this.status.TabIndex = 5;
            this.status.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // getWordlistFile
            // 
            this.getWordlistFile.Location = new System.Drawing.Point(12, 93);
            this.getWordlistFile.Name = "getWordlistFile";
            this.getWordlistFile.Size = new System.Drawing.Size(279, 20);
            this.getWordlistFile.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Encryption Method";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wordlist File";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hash to Crack";
            // 
            // output
            // 
            this.output.AcceptsReturn = true;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Location = new System.Drawing.Point(12, 307);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(288, 69);
            this.output.TabIndex = 10;
            this.output.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 384);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getWordlistFile);
            this.Controls.Add(this.status);
            this.Controls.Add(this.getHashesToCrack);
            this.Controls.Add(this.isLog);
            this.Controls.Add(this.getEncryptionMethod);
            this.Controls.Add(this.isCrackHash);
            this.Name = "Form1";
            this.Text = "ccrack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button isCrackHash;
        private System.Windows.Forms.ComboBox getEncryptionMethod;
        private System.Windows.Forms.CheckBox isLog;
        private System.Windows.Forms.TextBox getHashesToCrack;
        private System.Windows.Forms.ProgressBar status;
        private System.Windows.Forms.TextBox getWordlistFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label4;
    }
}

