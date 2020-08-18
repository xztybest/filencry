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
        private string rsaEncrypted;
        private string original0;
        private string rsaDecrypted;

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

        private void RSAE_Click(object sender, EventArgs e)
        {
            string pubKeyFile = PublicKeyFile();

            if (pubKeyFile == string.Empty)
                return;
            else
            if (pubKeyFile == null)
            {
                MessageBox.Show("未能取得公钥信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string password = "";
            string publicKeyXml = RsaHelper.PublicKeyXmlFromCer(pubKeyFile, password);

            if (publicKeyXml == null)
            {
                MessageBox.Show("未能取得公钥信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            rsaEncrypted = RsaHelper.Encrypt(original0, publicKeyXml);

            if (rsaEncrypted == null)
                MessageBox.Show("RSA加密失败！");
            else
                MessageBox.Show(rsaEncrypted, "RSA加密后的信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        string PublicKeyFile()
        {
            string filePath = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "选择公钥证书";
                openFileDialog.InitialDirectory = "H:\\";
                openFileDialog.Filter = "证书文件(*.cer)|*.cer|所有文件(*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    filePath = openFileDialog.FileName;
                else
                    filePath = string.Empty;
            }

            return filePath;
        }

        private void RSAD_Click(object sender, EventArgs e)
        {
            string priKeyFile = PrivateKeyFile();

            if (priKeyFile == string.Empty)
                return;
            else
            if (priKeyFile == null)
            {
                MessageBox.Show("未能取得私钥信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string password = "123";
            string privateKeyXml = RsaHelper.PrivateKeyXmlFromPKCS12(priKeyFile, password);

            if (privateKeyXml == null)
            {
                MessageBox.Show("未能取得私钥信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            rsaDecrypted = RsaHelper.Decrypt(rsaEncrypted, privateKeyXml);

            if (rsaDecrypted == null)
                MessageBox.Show("RSA解密失败");
            else
                MessageBox.Show(rsaDecrypted, "RSA解密后的信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string PrivateKeyFile()
        {
            string filePath = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "选择私钥文件";
                openFileDialog.InitialDirectory = "H:\\";
                openFileDialog.Filter = "证书文件(*.p12)|*.p12|所有文件(*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    filePath = openFileDialog.FileName;
                else
                    filePath = string.Empty;
            }

            return filePath;
        }
    }
}
