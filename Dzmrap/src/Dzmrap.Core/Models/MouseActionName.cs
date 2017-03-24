namespace Dzmrap.Core.Models
{
    /// <summary>
    /// 鼠标动作
    /// </summary>
    public enum MouseActionName
    {
        /// <summary>
        /// 移动
        /// </summary>
        Move,

        /// <summary>
        /// 左键按下
        /// </summary>
        LeftButtonDown,

        /// <summary>
        /// 左键弹起
        /// </summary>
        LeftButtonUp,

        /// <summary>
        /// 右键按下
        /// </summary>
        RightButtonDown,

        /// <summary>
        /// 右键弹起
        /// </summary>
        RightButtonUp,

        /// <summary>
        /// 滚轮向前
        /// </summary>
        WheelUp,

        /// <summary>
        /// 滚轮向后
        /// </summary>
        WheelDown,

        /// <summary>
        /// 滚轮单击
        /// </summary>
        WheelClick,

        /// <summary>
        /// 单击
        /// </summary>
        Click,

        /// <summary>
        /// 双击
        /// </summary>
        DoubleClick,
        RightClick,
        RightDoubleClick
    }
}