using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Vexease.Controllers.Cryptography;
using Vexease.Models.Enums;

namespace Vexease.Models.Registrys
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [Serializable]
    public class RegPath : ICloneable
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
    }
}
