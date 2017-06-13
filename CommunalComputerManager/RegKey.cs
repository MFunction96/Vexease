using System;
using System.Xml;
using Microsoft.Win32;

namespace CommunalComputerManager
{
    [Serializable]
    public class RegKey : RegPath
    {
        /// <summary>
        /// 
        /// </summary>
        public RegistryValueKind LpValueKind { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public object LpValue { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public RegKey() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regPath"></param>
        /// <param name="lpValueKind"></param>
        /// <param name="lpValue"></param>
        public RegKey(RegPath regPath, RegistryValueKind lpValueKind, object lpValue) :
            base(regPath)
        {
            LpValueKind = lpValueKind;
            LpValue = lpValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regKey"></param>
        public RegKey(RegKey regKey) :
            base(regKey.HKey, regKey.LpSubKey, regKey.LpValueName)
        {
            LpValueKind = regKey.LpValueKind;
            LpValue = regKey.LpValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="skey"></param>
        protected new void MidExport(XmlTextWriter writer, string skey = "12345678")
        {
            writer.WriteStartElement(nameof(RegKey), Guid.ToString());
            writer.WriteAttributeString("hkey", CryptStr.Encrypt(HKey.ToString(), skey));
            writer.WriteAttributeString("lpsubkey", CryptStr.Encrypt(LpSubKey, skey));
            writer.WriteAttributeString("lpvaluename", CryptStr.Encrypt(LpValueName, skey));
            writer.WriteAttributeString("lpvaluekind", CryptStr.Encrypt(LpValueKind.ToString(), skey));
            writer.WriteAttributeString("lpvalue", CryptStr.Encrypt(LpValue.ToString(), skey));
        }
    }
}
