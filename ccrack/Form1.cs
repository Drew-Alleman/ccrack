using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace ccrack {

    public partial class Form1 : Form
    {
        public static Form1 form;
        BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            form = this;
            this.SetStyle(
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint |
            ControlStyles.DoubleBuffer | 
            ControlStyles.OptimizedDoubleBuffer,
            true);
            backgroundWorker1.DoWork += BackgroundWorkerDoWork;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.WorkerSupportsCancellation = true; //Allow for the process to be cancelled
            cancelButton.Enabled = false;
            string[] supportedFormats = { "SHA1", "SHA256", "SHA384", "SHA512", "MD5" };
            foreach (string format  in supportedFormats)
                getEncryptionMethod.Items.Add(format);

        }

        public void writeToOutputBox(string text)
        {

            output.Text += $"{text}\r";
        }

        public void writeToLogBox(string text)
        {

            log.Text += $"{text}\r";
        }


        public void clearTextBox() { 
            output.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            clearTextBox();
            crackButton.Enabled = false;
            cancelButton.Enabled = true;
            var wordlist = (string)wordlistFile.Text;
            int threadCount = int.Parse(setThreadCount.Text);
            List<string> collectedHashes = Utils.Utilities.cleanHashes(hash.Text.Split('\n')).ToList();
            if (hashFile.Text != null)
            {
                List<string> collectedHashesFromFile = Utils.Utilities.StreamReadlines(hashFile.Text);
                collectedHashes.AddRange(collectedHashesFromFile);
            }
            var encryptionMethod = (string)getEncryptionMethod.SelectedItem;
            Encryption.Encryptor.CreateEncryptionThreads(wordlist, encryptionMethod, collectedHashes, threadCount);
        }

        void button1_Click(object sender, EventArgs e) {

            var encryptionMethod = (string)getEncryptionMethod.SelectedItem;
            backgroundWorker1.RunWorkerAsync();
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
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            crackButton.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}