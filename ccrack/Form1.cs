using System;
using System.Windows.Forms;
using System.Drawing;

namespace ccrack {
    
    
    public partial class Form1 : Form
    {
        public static Form1 form;
        private System.Windows.Forms.NotifyIcon notifyIcon1;

        public Form1()
        {
            InitializeComponent();
            form = this;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            cancelButton.Enabled = false;
            getEncryptionMethod.Items.Add("SHA1");
            getEncryptionMethod.Items.Add("SHA256");
            getEncryptionMethod.Items.Add("SHA384");
            getEncryptionMethod.Items.Add("SHA512");
            getEncryptionMethod.Items.Add("MD5");

        }

        public void writeToTextBox(string text)
        {

            output.Text += $"{text}\r";
        }


        public void clearTextBox() { 
            output.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
            clearTextBox();
            crackButton.Enabled = false;
            cancelButton.Enabled = true;
            var en = new Encryption.Encryptor();
            var wordlist = (string)wordlistFile.Text;
            int threadCount = int.Parse(setThreadCount.Text);
            string[] collectedHashes = en.cleanHashes(hash.Text.Split('\n'));
            var encryptionMethod = (string)getEncryptionMethod.SelectedItem;
            en.CreateEncryptionThreads(wordlist, encryptionMethod, collectedHashes, threadCount);
            crackButton.Enabled = true;
        }

        private void getHashesToCrack_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getEncryptionMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            crackButton.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}