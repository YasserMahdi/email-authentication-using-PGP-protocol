using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarlJohansen;

namespace Email_Auth.BLL.RSA
{
    class Decryptor
    {
        public static String decrypt(List<BigInt> data, Key privateKey)
        {
            String decryptedData = "";
            foreach (BigInt i in data)
                decryptedData += decrypt(i, privateKey);
            return decryptedData;
        }

        public static String decrypt(BigInt data, Key privateKey)
        {
            BigInt m = BigInt.ModPower(data, privateKey.key, privateKey.n);

            String s = m.ToString();
            int d = Int32.Parse(s);
            String c = "";
            c += (Char)d;

            return c;
        }
    }
}
