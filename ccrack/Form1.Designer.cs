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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.output = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.setThreadCount = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.wordlistFile = new System.Windows.Forms.TextBox();
            this.hash = new System.Windows.Forms.TextBox();
            this.crackButton = new System.Windows.Forms.Button();
            this.getEncryptionMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hashes = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.output);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(281, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // output
            // 
            this.output.AcceptsReturn = true;
            this.output.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.Location = new System.Drawing.Point(6, 19);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(272, 358);
            this.output.TabIndex = 10;
            this.output.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.setThreadCount);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.wordlistFile);
            this.tabPage1.Controls.Add(this.hash);
            this.tabPage1.Controls.Add(this.crackButton);
            this.tabPage1.Controls.Add(this.getEncryptionMethod);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.hashes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Threads";
            // 
            // setThreadCount
            // 
            this.setThreadCount.Location = new System.Drawing.Point(10, 118);
            this.setThreadCount.Name = "setThreadCount";
            this.setThreadCount.Size = new System.Drawing.Size(82, 20);
            this.setThreadCount.TabIndex = 17;
            this.setThreadCount.Text = "5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 329);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hash File (Optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wordlist File";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(142, 355);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(133, 25);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // wordlistFile
            // 
            this.wordlistFile.Location = new System.Drawing.Point(8, 35);
            this.wordlistFile.Name = "wordlistFile";
            this.wordlistFile.Size = new System.Drawing.Size(267, 20);
            this.wordlistFile.TabIndex = 6;
            // 
            // hash
            // 
            this.hash.AcceptsReturn = true;
            this.hash.Location = new System.Drawing.Point(9, 157);
            this.hash.Multiline = true;
            this.hash.Name = "hash";
            this.hash.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hash.Size = new System.Drawing.Size(266, 139);
            this.hash.TabIndex = 4;
            this.hash.TextChanged += new System.EventHandler(this.getHashesToCrack_TextChanged);
            // 
            // crackButton
            // 
            this.crackButton.Location = new System.Drawing.Point(8, 355);
            this.crackButton.Name = "crackButton";
            this.crackButton.Size = new System.Drawing.Size(129, 26);
            this.crackButton.TabIndex = 0;
            this.crackButton.Text = "Crack Hash";
            this.crackButton.UseVisualStyleBackColor = true;
            this.crackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // getEncryptionMethod
            // 
            this.getEncryptionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getEncryptionMethod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.getEncryptionMethod.FormattingEnabled = true;
            this.getEncryptionMethod.Location = new System.Drawing.Point(8, 73);
            this.getEncryptionMethod.Name = "getEncryptionMethod";
            this.getEncryptionMethod.Size = new System.Drawing.Size(267, 21);
            this.getEncryptionMethod.TabIndex = 1;
            this.getEncryptionMethod.SelectedIndexChanged += new System.EventHandler(this.getEncryptionMethod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Encryption Method";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // hashes
            // 
            this.hashes.AutoSize = true;
            this.hashes.Location = new System.Drawing.Point(6, 141);
            this.hashes.Name = "hashes";
            this.hashes.Size = new System.Drawing.Size(86, 13);
            this.hashes.TabIndex = 9;
            this.hashes.Text = "Hashes to Crack";
            this.hashes.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(289, 410);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 417);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ccrack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox wordlistFile;
        private System.Windows.Forms.Button crackButton;
        private System.Windows.Forms.ComboBox getEncryptionMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hashes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox setThreadCount;
        private System.Windows.Forms.TextBox hash;
    }
}

