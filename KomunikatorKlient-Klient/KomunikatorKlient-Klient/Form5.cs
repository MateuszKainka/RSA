using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.IO;

namespace KomunikatorKlient_Klient
{
    public partial class Form5 : Form
    {
        Form1 opener;
        public Form5(Form1 parentForm)
        {
            InitializeComponent();
            EnableFilesButtons();
            opener = parentForm;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd1 = new OpenFileDialog();
            ofd1.Filter = "Pliki klucza (*.xml)|*.xml";
            ofd1.ShowDialog(this);
            var filename1 = ofd1.FileName;
            textBox1.Text = filename1;
            string s1 = File.ReadAllText(filename1);
            Form1.filePrivateKey = s1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EnableFilesButtons();
        }

        private void EnableFilesButtons()
        {
            if (radioButton1.Checked == true)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                Form1.keyGen = true;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                Form1.keyGen = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ofd2 = new OpenFileDialog();
            ofd2.Filter = "Pliki klucza (*.xml)|*.xml";
            ofd2.ShowDialog(this);
            var filename2 = ofd2.FileName;
            textBox2.Text = filename2;
            string s2 = File.ReadAllText(filename2);
            Form1.filePublicKey = s2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ofd3 = new OpenFileDialog();
            ofd3.Filter = "Pliki klucza (*.xml)|*.xml";
            ofd3.ShowDialog(this);
            var filename3 = ofd3.FileName;
            textBox3.Text = filename3;
            string s3 = File.ReadAllText(filename3);
            Form1.fileForeignKey = s3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
