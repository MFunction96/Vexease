using Microsoft.Win32;
using System;
using System.Xml;
using Vexease.Models.Enums;
using AESCrypt;

namespace Vexease.Models.Registrys
{
    /// <inheritdoc cref="RegPath" />
    /// <summary>
    /// 注册表键信息类。
    /// </summary>
    [Serializable]
    public class RegKey : RegPath
    {
        /// <summary>
        /// 注册表键值类型。
        /// </summary>
        public RegistryValueKind LpKind { get; protected set; }
        /// <summary>
        /// 注册表键值。
        /// </summary>
        public object LpValue { get; protected set; }
        /// <inheritdoc />
        /// <summary>
        /// 注册表键信息类序列化构造函数。
        /// </summary>
        public RegKey() { }
        /// <inheritdoc />
        /// <summary>
        /// 注册表键信息类构造函数。
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
        /// <param name="lpKind">
        /// 注册表键值类型。
        /// </param>
        /// <param name="lpValue">
        /// 注册表键值。
        /// </param>
        public RegKey(
            REG_ROOT_KEY hKey,
            string lpSubKey,
            string lpValueName = "",
            RegistryValueKind lpKind = RegistryValueKind.Unknown,
            object lpValue = null) :
            base(hKey, lpSubKey, lpValueName)
        {
            LpKind = lpKind;
            LpValue = lpValue;
        }
        /// <inheritdoc />
        /// <summary>
        /// 注册表键信息类构造函数。
        /// </summary>
        /// <param name="regPath">
        /// 注册表键路径信息类。
        /// </param>
        /// <param name="lpKind">
        /// 注册表键值类型。
        /// </param>
        /// <param name="lpValue">
        /// 注册表键值。
        /// </param>
        public RegKey(RegPath regPath, RegistryValueKind lpKind = RegistryValueKind.Unknown, object lpValue = null) :
            base(regPath)
        {
            LpKind = lpKind;
            LpValue = lpValue;
        }
        /// <inheritdoc />
        /// <summary>
        /// 注册表键信息类复制构造函数。
        /// </summary>
        /// <param name="regKey">
        /// 注册表键信息类
        /// </param>
        public RegKey(RegKey regKey) :
            base(regKey.HKey, regKey.LpSubKey, regKey.LpValueName)
        {
            LpKind = regKey.LpKind;
            LpValue = regKey.LpValue;
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
        protected new void MidExport(XmlTextWriter writer, string name)
        {
            base.MidExport(writer, name);
            writer.WriteAttributeString("lpkind", AESCrypt.AESCrypt.Encrypt(LpKind.ToString()));
            writer.WriteAttributeString("lpvalue", AESCrypt.AESCrypt.Encrypt(LpValue.ToString()));
        }
        /// <summary>
        /// 获取注册表路径信息。
        /// </summary>
        /// <returns>
        /// 注册表路径信息类。
        /// </returns>
        public RegPath GetRegPath()
        {
            return new RegPath(HKey, LpSubKey, LpValueName);
        }
        /// <summary>
        /// 获取当前对象的深表副本。
        /// </summary>
        /// <returns>
        /// 当前对象的深表副本。
        /// </returns>
        public new object Clone()
        {
            return MemberwiseClone();
        }
        /// <summary>
        /// 注册表路径信息类默认排序规则。
        /// </summary>
        /// <param name="obj">
        /// 待比较的对象。
        /// </param>
        /// <returns>
        /// 大小比较结果。
        /// </returns>
        public new int CompareTo(object obj)
        {
            var regkey = obj as RegKey;
            if (regkey is null) throw new NullReferenceException();
            var flag = base.CompareTo(obj);
            if (flag != 0) return flag;
            if (LpKind < regkey.LpKind) return 1;
            if (LpKind > regkey.LpKind) return -1;
            return string.CompareOrdinal(LpValue.ToString(), regkey.LpValue.ToString());
        }
    }
}
