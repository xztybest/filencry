using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace filencry
{
    public class RSA2
    {
        public string PublicKey, PrivateKey;
        RSACryptoServiceProvider rsaProvider;
        public void Initial()
        {
            //声明一个RSA算法的实例，由RSACryptoServiceProvider类型的构造函数指定了密钥长度为1024位
            //实例化RSACryptoServiceProvider后，RSACryptoServiceProvider会自动生成密钥信息。
            rsaProvider = new RSACryptoServiceProvider(4096);
            //将RSA算法的公钥导出到字符串PublicKey中，参数为false表示不导出私钥
            PublicKey = rsaProvider.ToXmlString(false);
            //将RSA算法的私钥导出到字符串PrivateKey中，参数为true表示导出私钥
            PrivateKey = rsaProvider.ToXmlString(true);



        }
    }
}
