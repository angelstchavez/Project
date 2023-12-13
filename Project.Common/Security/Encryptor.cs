using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Project.Common.Security
{
    public class Encryptor
    {
        // Cambia estas claves según tus necesidades
        private static readonly string Key = "UnaClaveSuperSegura123";
        private static readonly string Salt = "UnSaltSuperSeguro456";

        public static string Encrypt(string textToEncrypt)
        {
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Encoding.UTF8.GetBytes(Key);
                rijAlg.IV = Encoding.UTF8.GetBytes(Salt);

                var encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(textToEncrypt);
                        }
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Encoding.UTF8.GetBytes(Key);
                rijAlg.IV = Encoding.UTF8.GetBytes(Salt);

                var decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                using (var msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
