using System.Windows.Forms;

namespace Dzmrap.Hooks
{
    /// <summary>
    /// 鼠标事件参数（扩展）
    /// </summary>
    public class MouseEventExtArgs : MouseEventArgs
    {
        /// <summary>
        /// 初始化 <see cref="MouseEventExtArgs"/>类的新实例。
        /// </summary>
        /// <param name="buttons">按下的键</param>
        /// <param name="clicks">点击数量</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        /// <param name="delta">滚轮转动轮数</param>
        public MouseEventExtArgs(MouseButtons buttons, int clicks, int x, int y, int delta)
            : base(buttons, clicks, x, y, delta)
        { }

        /// <summary>
        /// 初始化 <see cref="MouseEventExtArgs"/>类的新实例。
        /// </summary>
        /// <param name="e">普通<see cref="MouseEventArgs"/> 事件参数的扩展</param>
        internal MouseEventExtArgs(MouseEventArgs e)
            : base(e.Button, e.Clicks, e.X, e.Y, e.Delta)
        { }

        private bool @handled;

        /// <summary>
        /// 路由控制 true 继续传播 false 不继续传播
        /// </summary>
        public bool Handled
        {
            get { return @handled; }
            set { @handled = value; }
        }
    }
}