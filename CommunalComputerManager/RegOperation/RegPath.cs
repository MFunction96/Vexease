using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CommunalComputerManager.RegOperation
{
    /// <summary>
    /// 
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
        public UIntPtr HKey { get; protected set; }
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
        public RegPath(UIntPtr hKey, string lpSubKey, string lpValueName = "")
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
        /// <param name="skey"></param>
        protected void MidExport(XmlTextWriter writer, string name, string skey = "12345678")
        {
            writer.WriteStartElement(name, Guid.ToString());
            writer.WriteAttributeString("hkey", CryptStr.Encrypt(HKey.ToString(), skey));
            writer.WriteAttributeString("lpsubkey", CryptStr.Encrypt(LpSubKey, skey));
            writer.WriteAttributeString("lpvaluename", CryptStr.Encrypt(LpValueName, skey));
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
