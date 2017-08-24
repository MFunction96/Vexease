using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;

namespace Vexease.Controllers.Cryptography
{
    /// <summary>
    /// 
    /// </summary>
    public static class CryptStr
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public static string Encrypt(string str, string sKey = "12345678")
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new Exception("不能加密空字符串");
            }
            if (sKey.Length != 8)
            {
                throw new Exception("密码长度必须等于8个字符");
            }
            var des = new DESCryptoServiceProvider();
            var inputByteArray = Encoding.Default.GetBytes(str);
            var tmp = FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5");
            if (tmp == null)
            {
                throw new Exception("加密异常！");
            }
            des.Key = Encoding.ASCII.GetBytes(tmp);
            des.IV = Encoding.ASCII.GetBytes(tmp);
            var ms = new MemoryStream();
            var cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            var ret = new StringBuilder();
            foreach (var b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public static string Decrypt(string str, string sKey = "12345678")
        {
            if (str.Length == 0)
            {
                throw new Exception("不能加密空字符串");
            }
            if (sKey.Length != 8)
            {
                throw new Exception("密码长度必须等于8个字符");
            }
            var des = new DESCryptoServiceProvider();
            var len = str.Length >> 1;
            var inputByteArray = new byte[len - 1];
            for (var x = 0; x < len; x++)
            {
                var i = Convert.ToInt32(str.Substring(x << 1, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            var tmp = FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5");
            if (tmp == null)
            {
                throw new Exception("加密异常！");
            }
            des.Key = Encoding.ASCII.GetBytes(tmp);
            des.IV = Encoding.ASCII.GetBytes(tmp);
            var ms = new MemoryStream();
            var cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }
    }
}