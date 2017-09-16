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
   
    public partial class Form3 : Form
    {
        int tempKeySize;
        Form opener;
        public Form3(Form1 parentForm)
        {
            InitializeComponent();
            opener = parentForm;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            tempKeySize = Form1.keySize;
            checkBox1.Checked = Form1.f3ChkBox1;
            radioButton1.Checked = Form1.f3ChkBox2;
            radioButton2.Checked = Form1.f3ChkBox3;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton1.Checked = true;
                Form1.f3ChkBox1 = true;
            }
            if (checkBox1.Checked == false)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton1.Checked = true;
                radioButton1.Checked = false;
                Form1.encoding = false;
                Form1.decoding = false;
                Form1.f3ChkBox1 = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                Form1.encoding = true;
                Form1.decoding = true;
                Form1.f3ChkBox2 = true;
                Form1.f3ChkBox3 = false;
            }

            if(radioButton2.Checked == true)
            {
                Form1.encoding = true;
                Form1.decoding = false;
                Form1.f3ChkBox3 = true;
                Form1.f3ChkBox2 = false;
            }

            this.Hide();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       

        
    }
}
