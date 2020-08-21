using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filencry
{
    public class funcsum
    {
        public  static byte[] AESEncry(string text1,string passkey)
        {
            
            byte[] message = System.Text.Encoding.UTF8.GetBytes(text1);
            return message;
        }

        public  void AESEncry2()
        {
            MessageBox.Show("helloworld");
        }
    }
}
