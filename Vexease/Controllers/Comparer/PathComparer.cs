using System;
using System.Collections;
using Vexease.Models.Registrys;

namespace Vexease.Controllers.Comparer
{
    /// <inheritdoc />
    /// <summary>
    /// 按照注册表键信息类值字典序自定义注册表键信息类排序类。
    /// </summary>
    public class PathComparer : IComparer
    {
        /// <inheritdoc />
        /// <summary>
        /// 自定义RegKey类排序规则。
        /// </summary>
        /// <param name="x">
        /// 前RegKey对象。
        /// </param>
        /// <param name="y">
        /// 后RegKey对象。
        /// </param>
        /// <returns>
        /// 排序结果。
        /// </returns>
        public int Compare(object x, object y)
        {
            var regx = x as RegKey;
            var regy = y as RegKey;
            if (regx is null || regy is null) throw new NullReferenceException();
            var valuex = regx.LpValue as string;
            var valuey = regy.LpValue as string;
            if (valuex is null || valuey is null) throw new NullReferenceException();
            return string.Compare(valuex, valuey, StringComparison.Ordinal);
        }
    }
}
