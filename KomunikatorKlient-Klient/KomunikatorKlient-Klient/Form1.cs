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

    public partial class Form1 : Form
    {
        public static EndPoint epLocal, epRemote;
        public static Socket sckt;
        byte[] receivedData;
        public static string receivedMessage;
        public static RSACryptoServiceProvider RSA;
        public static RSAParameters myPublicKey, myPrivateKey, foreignPublicKey;
        public static bool encoding = false;
        public static bool decoding = false;
        public static bool keyGen = true;
        int msgCounter = 0;
        public static int keySize = 1024;
        public Color richTxtColor, frmBackColor, buttonBackColor;
        public string userName = "Ja", buddyName= "Znajomy";
        public int fontSize = 12;
        public static string filePrivateKey;
        public static string filePublicKey;
        public static string fileForeignKey;
        public static int selected = 0, selected2 = 2;
        public static bool f3ChkBox1 = false, f3ChkBox2 = false, f3ChkBox3 = false;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            richTextBox1.BackColor = Color.FromArgb(192, 255, 192);
            sckt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sckt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            button1.Enabled = false;
            button2.Enabled = false;
            richTxtColor = Color.FromArgb(192, 255, 192);
            frmBackColor = Color.FromArgb(0, 192, 0);
            buttonBackColor = Color.FromArgb(128, 255, 128);
            richTextBox1.Font = new Font("Microsoft Sans Serif", 12);
        }

        private void połączToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(this);
            frm2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(this);
            frm5.ShowDialog(this);

            try
            {
                sckt.Bind(epLocal);
                sckt.Connect(epRemote);

                byte[] buffer = new byte[1024];
                sckt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                if (keyGen == true)
                {
                    RSA = new RSACryptoServiceProvider(keySize);
                    myPublicKey = RSA.ExportParameters(false);
                    myPrivateKey = RSA.ExportParameters(true);
                    TextWriter writer = new StreamWriter(".\\myPublicKey.xml");
                    string publicKey = RSA.ToXmlString(false);
                    writer.Write(publicKey);
                    writer.Dispose();
                    TextWriter writer2 = new StreamWriter(".\\myPrivateKey.xml");
                    string privateKey = RSA.ToXmlString(true);
                    writer2.Write(privateKey);
                    writer2.Dispose();

                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                    byte[] msg = new byte[1024];
                    msg = enc.GetBytes(RSA.ToXmlString(false));
                    sckt.Send(msg);
                }

                if (keyGen == false)
                {
                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(filePrivateKey);
                    myPrivateKey = RSA.ExportParameters(true);
                    TextWriter writer = new StreamWriter(".\\myPrivateKey.xml");
                    string privateKey = RSA.ToXmlString(true);
                    writer.Write(privateKey);
                    writer.Close();

                    RSA.FromXmlString(filePublicKey);
                    myPublicKey = RSA.ExportParameters(false);
                    writer = new StreamWriter(".\\myPublicKey.xml");
                    string publicKey = RSA.ToXmlString(false);
                    writer.Write(publicKey);
                    writer.Close();

                    

                    RSA.FromXmlString(fileForeignKey);
                    foreignPublicKey = RSA.ExportParameters(false);
                    writer = new StreamWriter(".\\foreignPublicKey.xml");
                    string publicKeyXML = RSA.ToXmlString(false);
                    writer.Write(publicKeyXML);
                    writer.Close();
                    msgCounter = 2;
                }


                button1.Enabled = true;
                szyfrowanieToolStripMenuItem.Enabled = true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sckt.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    receivedData = (byte[])aResult.AsyncState;
                    receivedData = receivedData.Take(size).ToArray();
                    msgCounter++;

                    if (msgCounter == 1)
                    {
                        try
                        {
                            ASCIIEncoding eEncoding = new ASCIIEncoding();
                            receivedMessage = eEncoding.GetString(receivedData);
                            RSA.FromXmlString(receivedMessage);
                            foreignPublicKey = RSA.ExportParameters(false);
                            TextWriter writer = new StreamWriter(".\\foreignPublicKey.xml");
                            string publicKeyXML = RSA.ToXmlString(false);
                            writer.Write(publicKeyXML);
                            writer.Close();
                            RSA.ImportParameters(myPublicKey);
                            writer = new StreamWriter(".\\myPublicKey2.xml");
                            string publicKeyXML2 = RSA.ToXmlString(false);
                            writer.Write(publicKeyXML2);
                            writer.Close();

                            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                            byte[] msg = new byte[1024];
                            msg = enc.GetBytes(RSA.ToXmlString(false));
                            sckt.Send(msg);

                        }

                        catch (SocketException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }

                    if (msgCounter == 2)
                    {
                        System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                        byte[] msg = new byte[1024];
                        msg = enc.GetBytes("Znajomy dolaczyl do sesji");
                        sckt.Send(msg);
                        msgCounter++;
                        button1.Enabled = true;
                    }

                    if(msgCounter>3)
                    {

                        if (decoding == true)
                        {
                            UnicodeEncoding ByteConverter = new UnicodeEncoding();
                            receivedData = Decrypting(receivedData, myPrivateKey, false);
                            ASCIIEncoding eEncoding = new ASCIIEncoding();
                            receivedMessage = eEncoding.GetString(receivedData);
                            richTextBox1.AppendText(buddyName + ":\n" + receivedMessage);
                            richTextBox1.AppendText("\n");

                        }

                        else
                        {
                            ASCIIEncoding eEncoding = new ASCIIEncoding();
                            receivedMessage = eEncoding.GetString(receivedData);
                            richTextBox1.AppendText(buddyName + ":\n" + receivedMessage);
                            richTextBox1.AppendText("\n");
                        }
                    }

                    byte[] buffer = new byte[1024];
                    sckt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        public byte[] Ecrypting(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    RSA.ImportParameters(RSAKeyInfo);
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {

                MessageBox.Show(Convert.ToString(e) + "\nEncrypt fail");
                return null;
            }
        }

        public byte[] Decrypting(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                MessageBox.Show(e.ToString() + "\nDecrypt Fail");

                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1024];
                msg = enc.GetBytes(richTextBox2.Text);
                if (encoding == true)
                {
                    msg = Ecrypting(msg, foreignPublicKey, false);
                }

                sckt.Send(msg);

                richTextBox1.AppendText(userName + ": \n" + richTextBox2.Text + "\n");
                richTextBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void szyfrowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(this);
            frm3.Show();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void enableButton2()
        {
            button2.Enabled = true;
        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(this);
            frm4.Show();
        }

        public void colorChange()
        {
            richTextBox1.BackColor = richTxtColor;
            richTextBox2.BackColor = richTxtColor;
            BackColor = frmBackColor;
            button1.BackColor = buttonBackColor;
        }
        
        public void fontChange()
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", fontSize);
            richTextBox2.Font = new Font("Microsoft Sans Serif", fontSize);
        }

    }
}