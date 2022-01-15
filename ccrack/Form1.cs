using System;
using System.Data;
using System.Linq;
using static Encryption.Encryptor;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.IO;


namespace ccrack {
    
    
    public partial class Form1 : Form
    {
        public static Form1 form;

        public Form1()
        {
            InitializeComponent();
            form = this;
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
            string[] collectedHashes = en.cleanHashes(hash.Text.Split('\n'));
            var encryptionMethod = (string)getEncryptionMethod.SelectedItem;
            en.encryptLines(wordlist, encryptionMethod, collectedHashes);
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
    }
}