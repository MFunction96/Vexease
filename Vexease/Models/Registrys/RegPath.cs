using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Vexease.Models.Enums;

namespace Vexease.Models.Registrys
{
    /// <inheritdoc cref="IComparable" />
    /// <summary>
    /// 注册表路径信息类。
    /// </summary>
    [Serializable]
    public class RegPath : ICloneable, IComparable
    {
        /// <summary>
        /// 全球唯一标识符。
        /// </summary>
        public Guid Guid { get; }
        /// <summary>
        /// 注册表根键。
        /// </summary>
        public REG_ROOT_KEY HKey { get; protected set; }
        /// <summary>
        /// 注册表子键。
        /// </summary>
        public string LpSubKey { get; protected set; }
        /// <summary>
        /// 注册表键名。
        /// </summary>
        public string LpValueName { get; protected set; }
        /// <summary>
        /// 注册表路径信息类序列化构造函数。
        /// </summary>
        public RegPath()
        {
            Guid = Guid.NewGuid();
        }
        /// <summary>
        /// 注册表路径信息类构造函数。
        /// </summary>
        /// <param name="path">
        /// 注册表路径信息。
        /// </param>
        /// <param name="refMark">
        /// 是否为字符串引用。
        /// </param>
        public RegPath(string path, bool refMark = false)
        {
            Guid = Guid.NewGuid();
            if (refMark) path = path.Substring(1, path.Length - 2);
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
        /// 注册表路径信息类构造函数。
        /// </summary>
        /// <param name="hKey">
        /// 注册表根键。
        /// </param>
        /// <param name="lpSubKey">
        /// 注册表子键。
        /// </param>
        /// <param name="lpValueName">
        /// 注册表键名。
        /// </param>
        public RegPath(REG_ROOT_KEY hKey, string lpSubKey, string lpValueName = "")
        {
            Guid = Guid.NewGuid();
            HKey = hKey;
            LpSubKey = lpSubKey;
            LpValueName = lpValueName;
        }
        /// <summary>
        /// 注册表路径信息类复制构造函数。
        /// </summary>
        /// <param name="regPath">
        /// 注册表路径信息类。
        /// </param>
        public RegPath(RegPath regPath)
        {
            Guid = Guid.NewGuid();
            HKey = regPath.HKey;
            LpSubKey = regPath.LpSubKey;
            LpValueName = regPath.LpValueName;
        }
        /// <summary>
        /// 导出注册表信息中间过程。
        /// </summary>
        /// <param name="writer">
        /// XML写入控制器。
        /// </param>
        /// <param name="name">
        /// XML标记名。
        /// </param>
        protected void MidExport(XmlTextWriter writer, string name)
        {
            writer.WriteStartElement(name, Guid.ToString());
            writer.WriteAttributeString("hkey", AESCrypt.AESCrypt.Encrypt(HKey.ToString()));
            writer.WriteAttributeString("lpsubkey", AESCrypt.AESCrypt.Encrypt(LpSubKey));
            writer.WriteAttributeString("lpvaluename", AESCrypt.AESCrypt.Encrypt(LpValueName));
        }
        /// <summary>
        /// 导出注册表信息到XML。
        /// </summary>
        /// <param name="xmlFile">
        /// XML文件路径。
        /// </param>
        /// <param name="name">
        /// XML标记名。
        /// </param>
        /// <returns>
        /// true为导出成功。
        /// false为导出失败。
        /// </returns>
        public bool ExportXml(string xmlFile, string name)
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
                    MidExport(writer, name);
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
        /// 获取当前对象的深表副本。
        /// </summary>
        /// <returns>
        /// 当前对象的深表副本。
        /// </returns>
        public object Clone()
        {
            return MemberwiseClone();
        }
        /// <inheritdoc />
        /// <summary>
        /// 注册表路径信息类默认排序规则。
        /// </summary>
        /// <param name="obj">
        /// 待比较的对象。
        /// </param>
        /// <returns>
        /// 大小比较结果。
        /// </returns>
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
