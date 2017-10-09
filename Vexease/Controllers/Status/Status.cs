namespace Vexease.Controllers.Status
{
    /// <summary>
    /// 状态类纯虚基类。
    /// </summary>
    public abstract class Status
    {
        /// <summary>
        /// 状态记录信息。
        /// </summary>
        public bool State { get; protected set; }
        /// <summary>
        /// 状态检查纯虚函数。
        /// </summary>
        /// <returns>
        /// 返回当前开关状态。
        /// </returns>
        public abstract bool CheckStatus();
        /// <summary>
        /// 切换状态。
        /// </summary>
        /// <returns>
        /// 切换状态记录信息。
        /// </returns>
        public virtual bool SwapStatus()
        {
            return State = !State;
        }
    }
}
