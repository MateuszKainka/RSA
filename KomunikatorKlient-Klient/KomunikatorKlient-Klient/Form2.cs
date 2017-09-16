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
    public partial class Form2 : Form
    {
        Form1 opener;


        public Form2(Form1 parentForm)
        {

            InitializeComponent();

            opener = parentForm;
            textBox1.Text = GetLocalIP();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Form1.epLocal = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Form1.epRemote = new IPEndPoint(IPAddress.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text));
                opener.enableButton2();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Uzupełnij wszystkie pola prawidłowo.");
            }
            
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
            }

            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
            }
        }

    }
}
