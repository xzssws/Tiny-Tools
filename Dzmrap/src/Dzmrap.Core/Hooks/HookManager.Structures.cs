using System.Runtime.InteropServices;

namespace Dzmrap.Hooks {

    public static partial class HookManager {
        /// <summary>
        /// 屏幕坐标结构
        /// </summary>
        /// <remarks>
        /// http://msdn.microsoft.com/library/default.asp?url=/library/en-us/gdi/rectangl_0tiq.asp
        /// </remarks>
        [StructLayout(LayoutKind.Sequential)]
        private struct Point {
            /// <summary>
            /// X坐标
            /// </summary>
            public int X;
            /// <summary>
            /// Y坐标
            /// </summary>
            public int Y;
        }

        /// <summary>
        /// 鼠标输入信息结构
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct MouseLLHookStruct {
            /// <summary>
            /// 鼠标屏幕坐标
            /// </summary>
            public Point Point;
            /// <summary>
            /// 
            /// If the message is WM_MOUSEWHEEL, the high-order word of this member is the wheel delta. 
            /// The low-order word is reserved. A positive value indicates that the wheel was rotated forward, 
            /// away from the user; a negative value indicates that the wheel was rotated backward, toward the user. 
            /// One wheel click is defined as WHEEL_DELTA, which is 120. 
            ///If the message is WM_XBUTTONDOWN, WM_XBUTTONUP, WM_XBUTTONDBLCLK, WM_NCXBUTTONDOWN, WM_NCXBUTTONUP,
            /// or WM_NCXBUTTONDBLCLK, the high-order word specifies which X button was pressed or released, 
            /// and the low-order word is reserved. This value can be one or more of the following values. Otherwise, MouseData is not used. 
            ///XBUTTON1
            ///The first X button was pressed or released.
            ///XBUTTON2
            ///The second X button was pressed or released.
            /// </summary>
            public int MouseData;
            /// <summary>
            ///  事件注入标志，根据下面的值来测试鼠标标志  0 非注入 1~15保留
            /// </summary>
            public int Flags;
            /// <summary>
            /// 时间戳
            /// </summary>
            public int Time;
            /// <summary>
            /// 额外信息
            /// </summary>
            public int ExtraInfo;
        }

        /// <summary>
        /// 键盘输入事件
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            /// <summary>
            /// 虚拟键码  1~254
            /// </summary>
            public int VirtualKeyCode;
            /// <summary>
            /// 按键码
            /// </summary>
            public int ScanCode;
            /// <summary>
            /// 扩展键标记，事件注入标志。
            /// </summary>
            public int Flags;
            /// <summary>
            /// 时间戳
            /// </summary>
            public int Time;
            /// <summary>
            /// 额外信息
            /// </summary>
            public int ExtraInfo;
        }
    }
}
