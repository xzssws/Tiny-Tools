using Dzmrap.Core.Models;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dzmrap.Core.Services
{
    /// <summary>
    /// 鼠标按钮
    /// </summary>
    public enum MouseButton
    {
        Left = 0x2,
        Right = 0x8,
        Middle = 0x20
    }

    /// <summary>
    /// 鼠标控制
    /// </summary>
    public static class MouseControlService
    {
        #region Windows API

        [DllImport("user32.dll")]
        private static extern int ShowCursor(bool show);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int flags, int dX, int dY, int buttons, int extraInfo);

        private const int MOUSEEVENTF_MOVE = 0x1;
        private const int MOUSEEVENTF_LEFTDOWN = 0x2;
        private const int MOUSEEVENTF_LEFTUP = 0x4;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x8;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const int MOUSEEVENTF_MIDDLEUP = 0x40;
        private const int MOUSEEVENTF_WHEEL = 0x800;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        #endregion Windows API

        #region 属性

        /// <summary>
        /// 获取或设置鼠标的位置
        /// </summary>
        public static Point Position
        {
            get
            {
                return new Point(Cursor.Position.X, Cursor.Position.Y);
            }
            set
            {
                Cursor.Position = value;
            }
        }

        /// <summary>
        /// 获取或设置鼠标的X坐标
        /// </summary>
        public static int X
        {
            get
            {
                return Cursor.Position.X;
            }
            set
            {
                Cursor.Position = new Point(value, Y);
            }
        }

        /// <summary>
        /// 获取或设置鼠标的Y坐标
        /// </summary>
        public static int Y
        {
            get
            {
                return Cursor.Position.Y;
            }
            set
            {
                Cursor.Position = new Point(X, value);
            }
        }

        #endregion 属性

        #region 模拟方法

        /// <summary>
        /// 模拟鼠标按下
        /// </summary>
        /// <param name="button"></param>
        public static void MouseDown(MouseButton button)
        {
            mouse_event(((int)button), 0, 0, 0, 0);
        }

        /// <summary>
        /// 模拟鼠标按下
        /// </summary>
        /// <param name="button"></param>
        public static void MouseDown(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    MouseDown(MouseButton.Left);
                    break;

                case MouseButtons.Middle:
                    MouseDown(MouseButton.Middle);
                    break;

                case MouseButtons.Right:
                    MouseDown(MouseButton.Right);
                    break;
            }
        }

        /// <summary>
        /// 模拟鼠标抬起
        /// </summary>
        /// <param name="button"></param>
        public static void MouseUp(MouseButton button)
        {
            mouse_event(((int)button) * 2, 0, 0, 0, 0);
        }

        /// <summary>
        /// 模拟鼠标抬起
        /// </summary>
        /// <param name="button"></param>
        public static void MouseUp(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    MouseUp(MouseButton.Left);
                    break;

                case MouseButtons.Middle:
                    MouseUp(MouseButton.Middle);
                    break;

                case MouseButtons.Right:
                    MouseUp(MouseButton.Right);
                    break;
            }
        }

        /// <summary>
        /// 模拟鼠标单击
        /// </summary>
        /// <param name="button"></param>
        public static void Click(MouseButton button)
        {
            MouseDown(button);
            MouseUp(button);
        }

        /// <summary>
        /// 模拟鼠标单击
        /// </summary>
        /// <param name="button"></param>
        public static void Click(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    Click(MouseButton.Left);
                    break;

                case MouseButtons.Middle:
                    Click(MouseButton.Middle);
                    break;

                case MouseButtons.Right:
                    Click(MouseButton.Right);
                    break;
            }
        }

        /// <summary>
        /// 模拟鼠标双击
        /// </summary>
        /// <param name="button"></param>
        public static void DoubleClick(MouseButton button)
        {
            Click(button);
            Click(button);
        }

        /// <summary>
        /// 模拟鼠标双击
        /// </summary>
        /// <param name="button"></param>
        public static void DoubleClick(MouseButtons button)
        {
            switch (button)
            {
                case MouseButtons.Left:
                    DoubleClick(MouseButton.Left);
                    break;

                case MouseButtons.Middle:
                    DoubleClick(MouseButton.Middle);
                    break;

                case MouseButtons.Right:
                    DoubleClick(MouseButton.Right);
                    break;
            }
        }

        /// <summary>
        /// 模拟鼠标滚动
        /// </summary>
        /// <param name="delta">数值 120 向上 -120 向下</param>
        public static void MouseWheel(int delta)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, delta, 0);
        }

        /// <summary>
        /// 显示鼠标
        /// </summary>
        public static void Show()
        {
            ShowCursor(true);
        }

        /// <summary>
        /// 隐藏鼠标
        /// </summary>
        public static void Hide()
        {
            ShowCursor(false);
        }

        #endregion 模拟方法

        public static void ExecuteAction(MouseAction ma)
        {
            switch (ma.Name)
            {
                case MouseActionName.Move:
                    MouseControlService.X = ma.X;
                    MouseControlService.Y = ma.Y;
                    break;

                case MouseActionName.LeftButtonDown:
                    MouseControlService.MouseDown(MouseButtons.Left);
                    break;

                case MouseActionName.LeftButtonUp:
                    MouseControlService.MouseUp(MouseButtons.Left);
                    break;

                case MouseActionName.RightButtonDown:
                    MouseControlService.MouseDown(MouseButtons.Right);
                    break;

                case MouseActionName.RightButtonUp:
                    MouseControlService.MouseUp(MouseButtons.Right);
                    break;

                case MouseActionName.WheelUp:
                    MouseControlService.MouseUp(MouseButtons.Middle);
                    break;

                case MouseActionName.WheelDown:
                    MouseControlService.MouseDown(MouseButtons.Middle);
                    break;

                case MouseActionName.WheelClick:
                    MouseControlService.Click(MouseButtons.Middle);
                    break;

                case MouseActionName.Click:
                    MouseControlService.Click(MouseButtons.Left);
                    break;

                case MouseActionName.DoubleClick:
                    MouseControlService.DoubleClick(MouseButtons.Left);
                    break;

                case MouseActionName.RightClick:
                    MouseControlService.Click(MouseButtons.Right);
                    break;

                case MouseActionName.RightDoubleClick:
                    MouseControlService.DoubleClick(MouseButtons.Right);
                    break;

                default:
                    break;
            }
        }
    }
}