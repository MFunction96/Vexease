using Microsoft.Win32;
using Vexease.Controllers.Crypt;
using Vexease.Controllers.Reg;
using Vexease.Data;
using Vexease.Models.Registrys;

namespace Vexease.Controllers.Account
{
    /// <summary>
    /// 密码控制器。
    /// </summary>
    public static class PwdCtrl
    {
        /// <summary>
        /// 验证密码是否正确。
        /// </summary>
        /// <param name="pwd">
        /// 密码原文。
        /// </param>
        /// <returns>
        /// true为密码有效。
        /// false为密码无效。
        /// </returns>
        public static bool Verify(string pwd)
        {
            return AESCrypt.Encrypt(pwd) == DataContext.Password.LpValue.ToString();
        }
        /// <summary>
        /// 修改密码。
        /// </summary>
        /// <param name="pwd">
        /// 密码原文
        /// </param>
        public static void Modify(string pwd)
        {
            RegCtrl.RegSetValue(new RegKey(DataContext.Password.GetRegPath(), RegistryValueKind.String, AESCrypt.Encrypt(pwd)));
            DataContext.RefrushData();
        }
    }
}
