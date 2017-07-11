﻿using System;
using System.Xml;
using CommunalComputerManager.Controllers.Cryptography;
using Microsoft.Win32;

namespace CommunalComputerManager.Models.Registrys
{
    [Serializable]
    public class RegKey : RegPath
    {
        /// <summary>
        /// 
        /// </summary>
        public RegistryValueKind LpKind { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public object LpValue { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public uint LpSize { get; protected set; }
        /// <summary>
        /// 
        /// </summary>
        public RegKey() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hKey"></param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValueName"></param>
        /// <param name="lpKind"></param>
        /// <param name="lpValue"></param>
        /// <param name="lpSize"></param>
        public RegKey(
            UIntPtr hKey,
            string lpSubKey,
            string lpValueName = "",
            RegistryValueKind lpKind = RegistryValueKind.Unknown,
            object lpValue = null,
            uint lpSize = 0) :
            base(hKey, lpSubKey, lpValueName)
        {
            LpKind = lpKind;
            LpValue = lpValue;
            LpSize = lpSize;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regPath"></param>
        /// <param name="lpKind"></param>
        /// <param name="lpValue"></param>
        /// <param name="lpSize"></param>
        public RegKey(RegPath regPath, RegistryValueKind lpKind = RegistryValueKind.Unknown, object lpValue = null, uint lpSize = 0) :
            base(regPath)
        {
            LpKind = lpKind;
            LpValue = lpValue;
            LpSize = lpSize;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="regKey"></param>
        public RegKey(RegKey regKey) :
            base(regKey.HKey, regKey.LpSubKey, regKey.LpValueName)
        {
            LpKind = regKey.LpKind;
            LpValue = regKey.LpValue;
            LpSize = regKey.LpSize;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="name"></param>
        /// <param name="skey"></param>
        protected new void MidExport(XmlTextWriter writer, string name, string skey = "12345678")
        {
            base.MidExport(writer, name, skey);
            writer.WriteAttributeString("lpkind", CryptStr.Encrypt(LpKind.ToString(), skey));
            writer.WriteAttributeString("lpvalue", CryptStr.Encrypt(LpValue.ToString(), skey));
            writer.WriteAttributeString("lpsize", CryptStr.Encrypt(LpSize.ToString(), skey));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public RegPath GetRegPath()
        {
            return new RegPath(HKey, LpSubKey, LpValueName);
        }
    }
}