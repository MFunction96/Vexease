﻿using System;
using System.Xml;
using Microsoft.Win32;
using Vexease.Controllers.Cryptography;
using Vexease.Models.Enums;

namespace Vexease.Models.Registrys
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
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public RegKey() { }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="hKey"></param>
        /// <param name="lpSubKey"></param>
        /// <param name="lpValueName"></param>
        /// <param name="lpKind"></param>
        /// <param name="lpValue"></param>
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
        /// </summary>
        /// <param name="regPath"></param>
        /// <param name="lpKind"></param>
        /// <param name="lpValue"></param>
        public RegKey(RegPath regPath, RegistryValueKind lpKind = RegistryValueKind.Unknown, object lpValue = null) :
            base(regPath)
        {
            LpKind = lpKind;
            LpValue = lpValue;
        }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="regKey"></param>
        public RegKey(RegKey regKey) :
            base(regKey.HKey, regKey.LpSubKey, regKey.LpValueName)
        {
            LpKind = regKey.LpKind;
            LpValue = regKey.LpValue;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="name"></param>
        protected new void MidExport(XmlTextWriter writer, string name)
        {
            base.MidExport(writer, name);
            writer.WriteAttributeString("lpkind", AESCrypt.Encrypt(LpKind.ToString()));
            writer.WriteAttributeString("lpvalue", AESCrypt.Encrypt(LpValue.ToString()));
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
