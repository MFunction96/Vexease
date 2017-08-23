using System;
using System.Security.Cryptography;
using System.Text;

namespace Vexease.Controllers.Cryptography
{
    public static class AESCrypt
    {

        // 128bit(16byte)IV and Key
        private const string AESIV = @"!QAZ2WSX#EDC4RFV";
        private const string AESKEY = @"5TGB&YHN7UJM(IK<";

        /// <summary>
        /// AES Encryption
        /// <param name="text"></param>
        /// </summary>
        public static string Encrypt(string text)
        {
            // AesCryptoServiceProvider
            var aes = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 128,
                IV = Encoding.UTF8.GetBytes(AESIV),
                Key = Encoding.UTF8.GetBytes(AESKEY),
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };

            // Convert string to byte array
            var src = Encoding.Unicode.GetBytes(text);

            // encryption
            using (var encrypt = aes.CreateEncryptor())
            {
                var dest = encrypt.TransformFinalBlock(src, 0, src.Length);

                // Convert byte array to Base64 strings
                return Convert.ToBase64String(dest);
            }
        }

        /// <summary>
        /// AES decryption
        /// <param name="text"></param>
        /// </summary>
        public static string Decrypt(string text)
        {
            // AesCryptoServiceProvider
            var aes = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 128,
                IV = Encoding.UTF8.GetBytes(AESIV),
                Key = Encoding.UTF8.GetBytes(AESKEY),
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };

            // Convert Base64 strings to byte array
            var src = Convert.FromBase64String(text);

            // decryption
            using (var decrypt = aes.CreateDecryptor())
            {
                var dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                return Encoding.Unicode.GetString(dest);
            }
        }
    }
}
