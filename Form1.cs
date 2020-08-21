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
using System.Numerics;

namespace filencry
{
    public partial class Form1 : Form
    {
        public  byte[] data;
        private string rsaEncrypted;
        private string original0 = "123456";
        private string rsaDecrypted;

        public Form1()
        {
            InitializeComponent();
        }

        private void AESE_Click(object sender, EventArgs e)
        {
            string txt1 = "123";
            string passwd = "123456";
            byte[] test = funcsum.AESEncry(txt1, passwd);
            MessageBox.Show(System.Text.Encoding.UTF8.GetString(test));
            string plain = "我就是我";//需要加密的内容
            byte[] pl2= System.Text.Encoding.UTF8.GetBytes(plain);//转bit内容
            string pwd = "mmb";//加密密码
            byte[] cipher = AES.AESHelper.Encrypt(pl2, pwd);//加密操作

            byte[] dec = AES.AESHelper.Decrypt(cipher, pwd);//解密操作，转bit内容
            string text = System.Text.Encoding.UTF8.GetString(dec);//转字符串内容，方便查看
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
            string text2 = textBox3.Text;

            rsaEncrypted = RsaHelper.Encrypt(text2, publicKeyXml);

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

            string password = "";
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

        public static BigInteger BytesToBigInteger(byte[] v)
        {
            byte[] r = new byte[v.Length + 1];
            Array.Copy(v.Reverse().ToArray(), 0, r, 0, v.Length);
            return new BigInteger(r);
        }

        public static byte[] BigIntegerToBytes(BigInteger v, int length)
        {
            byte[] r = v.ToByteArray().Reverse().ToArray();
            if (r.Length < length)
            {
                byte[] t = new byte[length];
                Array.Copy(r, 0, t, length - r.Length, r.Length);
                return t;
            }
            return r;

        }

        private void exchatest_Click(object sender, EventArgs e)
        {
            string b64PrimeP = "2bO1ztOmt1hn3Nl0O8Z8+F7KAe+xp5wJXBPuKs5wUypoGO52JGqW5U1003VsEQjXaJdGX3NJBK9Bb5ZD4zucWw==";
            byte[] bytePrimeP = Convert.FromBase64String(b64PrimeP);
            BigInteger p = Util.BytesToBigInteger(bytePrimeP);
            BigInteger g = 2;

            BigInteger a = Util.BytesToBigInteger(System.Text.Encoding.UTF8.GetBytes("ABCDEFGH"));//Alice产生随机数a
            BigInteger b = Util.BytesToBigInteger(System.Text.Encoding.UTF8.GetBytes("IJKLMNOP"));//Bob产生随机数b

            BigInteger A = g ^ a % p; // Alice计算g的a次方 模p
            BigInteger B = g ^ b % p; // Alice计算g的a次方 模p

            BigInteger Alice_Cal = B ^ a % p; //Alice计算的共享密钥
            BigInteger Bob_Cal = A ^ b % p; //Bob计算的共享密钥

            if (Alice_Cal.ToString() == Bob_Cal.ToString())
            {
                MessageBox.Show(Bob_Cal.ToString());
            }
        }

        public void AESEncry2(object sender, EventArgs e,string xx)
        {
            MessageBox.Show("helloworld");
            MessageBox.Show(xx);

        }



    }
}
