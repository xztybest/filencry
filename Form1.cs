using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filencry
{
    public partial class Form1 : Form
    {
        public  byte[] data;
        public Form1()
        {
            InitializeComponent();
        }

        private void AESE_Click(object sender, EventArgs e)
        {
            string plain = "我就是我";
            byte[] pl2= System.Text.Encoding.UTF8.GetBytes(plain);
            string pwd = "mmb";
            byte[] cipher = AES.AESHelper.Encrypt(pl2, pwd);

            byte[] dec = AES.AESHelper.Decrypt(cipher, pwd);
            string text = System.Text.Encoding.UTF8.GetString(dec);
            data = cipher;
            text1.Text = pwd;
            string entext1 = System.Text.Encoding.UTF8.GetString(cipher);
            textBox2.Text = entext1;
        }

        private void AESD_Click(object sender, EventArgs e)
        {
            byte[] dec = AES.AESHelper.Decrypt(data, text1.Text);
            string text = System.Text.Encoding.UTF8.GetString(dec);
            string NULL = null;
            if (text == NULL)
            {
                MessageBox.Show("没有解密密钥");
            }
            textBox1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] key1 = RSA.GenerateKeys();
            MessageBox.Show(key1[1]);
          
        }
    }
}
