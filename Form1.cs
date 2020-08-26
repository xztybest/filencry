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
        private string signtxt;

        public Form1()
        {
            InitializeComponent();
        }

        private void AESE_Click(object sender, EventArgs e)
        {
            string plain = "我就是我";//需要加密的内容
            byte[] pl2= System.Text.Encoding.UTF8.GetBytes(plain);//转bit内容
            string pwd = funcsum.AESEnKeyGener();//加密密码
            byte[] cipher = funcsum.AESEncry(plain,pwd);//加密操作

            byte[] dec = funcsum.AESDecry(cipher,pwd);//解密操作，转bit内容
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
            
            string text2 = textBox3.Text;//text2为需要加密的内容
            if(text2==null)
            {
                MessageBox.Show("请输入加密内容！");//加密失败，弹出提示信息
            }

            rsaEncrypted = funcsum.RSAEncry(text2);//RSA加密，返回string类型的加密信息内容

            if (rsaEncrypted == "0")
                MessageBox.Show("RSA加密失败！");//加密失败，弹出提示信息
            else
                MessageBox.Show(rsaEncrypted, "RSA加密后的信息", MessageBoxButtons.OK, MessageBoxIcon.Information);//RSA加密成功，弹出RSA加密后的信息

        }

        

        private void RSAD_Click(object sender, EventArgs e)
        {
           
            rsaDecrypted = funcsum.RSADecry(rsaEncrypted);//解密加密后的RSA信息

            if (rsaDecrypted == "0")
                MessageBox.Show("RSA解密失败");//加密失败，弹出失败提示信息
            else
                MessageBox.Show(rsaDecrypted, "RSA解密后的信息", MessageBoxButtons.OK, MessageBoxIcon.Information);//解密成功，返回解密过后的明文信息
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
            BigInteger g = 3;

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

        public void AESEncry2(object sender, EventArgs e)
        {
            MessageBox.Show("helloworld");
            

        }

        private void timeget_Click(object sender, EventArgs e)
        {
            string timepasswd = funcsum.AESEnKeyGener();
            timebox.Text = timepasswd;
        }

        private void signmenu_Click(object sender, EventArgs e)
        {
            string signdata = sigtxt.Text;
            string signvalue = funcsum.messagesign(signdata);
            MessageBox.Show("信息签名成功");
            signtxt = sigtxt.Text;
            sigtxt.Text = signvalue;
        }

        private void signcheck_Click(object sender, EventArgs e)
        {
            string sigdata = signtxt;
            string signvalue = sigtxt.Text;
            string checkdata = funcsum.messagesigncheck(sigdata,signvalue);
            if(checkdata=="0")
            {
                MessageBox.Show("签名验证失败，信息被人篡改");
            }
            else
            {
                MessageBox.Show("签名验证成功");
            }
        }
    }
}
