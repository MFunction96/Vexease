using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Vexease.Controllers.Cryptography;
using Vexease.Models.Enums;

namespace Vexease.Models.Registrys
{
    /// <inheritdoc cref="IComparable" />
    /// <summary>
    /// </summary>
    [Serializable]
    public class RegPath : ICloneable, IComparable
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid Guid { get; }
        /// <summary>
        /// 
        /// </summary>
        public REG_ROOT_KEY HKey { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public string LpSubKey { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public string LpValueName { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public RegPath()
        {
            Guid = Guid.NewGuid();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="isRef"></param>
        public RegPath(string path, bool isRef = false)
        {
            Guid = Guid.NewGuid();
            if (isRef) path = path.Substring(1, path.Length - 2);
            var index1 = path.IndexOf(@"\", StringComparison.Ordinal);
            var index2 = path.LastIndexOf(@"\", StringComparison.Ordinal);
            var tmp = path.Substring(0, index1);
            if (tmp == @"HKEY_CLASSES_ROOT") HKey = REG_ROOT_KEY.HKEY_CLASSES_ROOT;
            else if (tmp == @"HKEY_CURRENT_USER") HKey = REG_ROOT_KEY.HKEY_CURRENT_CONFIG;
            else if (tmp == @"HKEY_LOCAL_MACHINE") HKey = REG_ROOT_KEY.HKEY_LOCAL_MACHINE;
            else if (tmp == @"HKEY_USERS") HKey = REG_ROOT_KEY.HKEY_USERS;
            else if (tmp == @"HKEY_PERFORMANCE_DATA") HKey = REG_ROOT_KEY.HKEY_PERFORMANCE_DATA;
            else if (tmp == @"HKEY_CURRENT_CONFIG") HKey = REG_ROOT_KEY.HKEY_CURRENT_CONFIG;
            else HKey = REG_ROOT_KEY.HKEY_DYN_DATA;
            LpSubKey = path.Substring(index1 + 1, index2 - index1 - 1);
            LpValueName = path.Substring(index2 + 1, path.Length - index2 - 1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hKey"></param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValueName"></param>
        public RegPath(REG_ROOT_KEY hKey, string lpSubKey, string lpValueName = "")
        {
            Guid = Guid.NewGuid();
            HKey = hKey;
            LpSubKey = lpSubKey;
            LpValueName = lpValueName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regPath"></param>
        public RegPath(RegPath regPath)
        {
            Guid = Guid.NewGuid();
            HKey = regPath.HKey;
            LpSubKey = regPath.LpSubKey;
            LpValueName = regPath.LpValueName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="name"></param>
        protected void MidExport(XmlTextWriter writer, string name)
        {
            writer.WriteStartElement(name, Guid.ToString());
            writer.WriteAttributeString("hkey", AESCrypt.Encrypt(HKey.ToString()));
            writer.WriteAttributeString("lpsubkey", AESCrypt.Encrypt(LpSubKey));
            writer.WriteAttributeString("lpvaluename", AESCrypt.Encrypt(LpValueName));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlFile"></param>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public bool ExportXml(string xmlFile, string sKey = "12345678")
        {
            try
            {
                var writer = new XmlTextWriter(xmlFile, Encoding.GetEncoding("utf-8"))
                {
                    Formatting = Formatting.Indented
                };
                if (!File.Exists(xmlFile))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Registry");
                    MidExport(writer, sKey);
                    writer.WriteEndElement();
                    writer.WriteFullEndElement();
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"错误", e.Message + '\n' + e.StackTrace);
                return false;
            }
            return true;
        }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            var regpath = obj as RegPath;
            if (regpath is null) throw new NullReferenceException();
            if (HKey < regpath.HKey) return 1;
            if (HKey > regpath.HKey) return -1;
            var flag = string.CompareOrdinal(LpSubKey, regpath.LpSubKey);
            return flag != 0 ? flag : string.CompareOrdinal(LpValueName, LpValueName);
        }
    }
}
