using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomunikatorKlient_Klient
{
    public partial class Form4 : Form
    {
        Form1 opener;
        
        public Form4(Form1 parentForm)
        {
            InitializeComponent();
            opener = parentForm;
            textBox1.Text = opener.userName;
            textBox2.Text = opener.buddyName;
            comboBox1.SelectedIndex = Form1.selected;
            comboBox2.SelectedIndex = Form1.selected2;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                opener.richTxtColor = Color.FromArgb(192, 255, 192);
                opener.frmBackColor = Color.FromArgb(0, 192, 0);
                opener.buttonBackColor = Color.FromArgb(128, 255, 128);
                Form1.selected = 0;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                opener.richTxtColor = Color.FromArgb(255, 192, 192);
                opener.frmBackColor = Color.FromArgb(192, 0, 0);
                opener.buttonBackColor = Color.FromArgb(255, 128, 128);
                Form1.selected = 1;
            } 
            
            if (comboBox1.SelectedIndex == 2)
            {
                opener.richTxtColor = Color.FromArgb(224, 224, 224);
                opener.frmBackColor = Color.FromArgb(64, 64, 64);
                opener.buttonBackColor = Color.FromArgb(128, 128, 128);
                Form1.selected = 2;
            } 
            
            if (comboBox1.SelectedIndex == 3)
            {
                opener.richTxtColor = Color.FromArgb(192, 192, 255);
                opener.frmBackColor = Color.FromArgb(0, 0, 192);
                opener.buttonBackColor = Color.FromArgb(128, 128, 255);
                Form1.selected = 3;
            }

            if (comboBox1.SelectedIndex == 4)
            {
                opener.richTxtColor = Color.FromArgb(255, 255, 192);
                opener.frmBackColor = Color.FromArgb(255, 255, 0);
                opener.buttonBackColor = Color.FromArgb(255, 255, 128);
                Form1.selected = 4;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            opener.colorChange();
            opener.buddyName = textBox2.Text;
            opener.userName = textBox1.Text;
            opener.fontChange();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                opener.fontSize = 8;
                Form1.selected2 = 0;
            }

            if (comboBox2.SelectedIndex == 1)
            {
                opener.fontSize = 10;
                Form1.selected2 = 1;
            }

            if (comboBox2.SelectedIndex == 2)
            {
                opener.fontSize = 12;
                Form1.selected2 = 2;
            }

            if (comboBox2.SelectedIndex == 3)
            {
                opener.fontSize = 14;
                Form1.selected2 = 3;
            }

            if (comboBox2.SelectedIndex == 4)
            {
                opener.fontSize = 16;
                Form1.selected2 = 4;
            }
        }

    }
}
