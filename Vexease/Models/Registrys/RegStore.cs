using System;
using System.Xml;
using Microsoft.Win32;
using Vexease.Controllers.Cryptography;

namespace Vexease.Models.Registrys
{
    /// <summary>
    /// 
    /// </summary>
    public class RegStore : RegKey
    {
        /// <summary>
        /// 
        /// </summary>
        public bool IsNull { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public RegStore() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hKey"></param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValueName"></param>
        /// <param name="lpKind"></param>
        /// <param name="lpValue"></param>
        /// <param name="isNull"></param>
        public RegStore(
            UIntPtr hKey,
            string lpSubKey,
            string lpValueName = "",
            RegistryValueKind lpKind = RegistryValueKind.Unknown,
            object lpValue = null,
            bool isNull = true) :
            base(hKey, lpSubKey, lpValueName, lpKind, lpValue)
        {
            IsNull = isNull;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regPath"></param>
        /// <param name="lpKind"></param>
        /// <param name="lpValue"></param>
        /// <param name="isNull"></param>
        public RegStore(
            RegPath regPath,
            RegistryValueKind lpKind = RegistryValueKind.Unknown,
            object lpValue = null,
            bool isNull = true) :
            base(regPath, lpKind, lpValue)
        {
            IsNull = isNull;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regKey"></param>
        /// <param name="isNull"></param>
        public RegStore(RegKey regKey, bool isNull = true) :
            base(regKey)
        {
            IsNull = isNull;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regStore"></param>
        public RegStore(RegStore regStore) :
            base(regStore.HKey, regStore.LpSubKey, regStore.LpValueName, regStore.LpKind, regStore.LpValue)
        {
            IsNull = regStore.IsNull;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="name"></param>
        /// <param name="skey"></param>
        protected new void MidExport(XmlTextWriter writer, string name)
        {
            base.MidExport(writer, name);
            writer.WriteAttributeString("isnull", AESCrypt.Encrypt(IsNull.ToString()));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public RegKey GetRegKey()
        {
            return new RegKey(GetRegPath(), LpKind, LpValue);
        }
    }
}
