using System;
using System.Security.Cryptography;
using System.Text;

namespace CovidConsole.Controller
{
    class Utils
    {
        /*
         * it returns a hashed string
         */
        public static string hashPwd(string pwd)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            Byte[] pwdBytes = Encoding.ASCII.GetBytes(pwd);
            Byte[] encryptedBytes = sha1.ComputeHash(pwdBytes);

            return Convert.ToBase64String(encryptedBytes);
        }
    }
}
