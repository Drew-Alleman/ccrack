using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccrack {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getEncryptionMethod.Items.Add("SHA1");
            getEncryptionMethod.Items.Add("SHA256");
            getEncryptionMethod.Items.Add("SHA384");
            getEncryptionMethod.Items.Add("SHA512");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private bool islog = false;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            islog = true;
        }
        private void button1_Click(object sender, EventArgs e){
            var wordlist = (string)getWordlistFile.Text;
            var hashes = getHashesToCrack.Text;
            var encryptionMethod = (string)getEncryptionMethod.SelectedItem;
            Utils.Utilities u = new Utils.Utilities();
            var result = u.HandleWordlistLines(wordlist, encryptionMethod, hashes);
            if (result != null)
            {
                output.Text += result;
            }
            else
            {
                output.Text += "Could not crack hash!\r\n";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

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
    }
}
