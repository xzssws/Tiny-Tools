using System.Runtime.InteropServices;

namespace Dzmrap.Hooks {

    public static partial class HookManager {
        /// <summary>
        /// ��Ļ����ṹ
        /// </summary>
        /// <remarks>
        /// http://msdn.microsoft.com/library/default.asp?url=/library/en-us/gdi/rectangl_0tiq.asp
        /// </remarks>
        [StructLayout(LayoutKind.Sequential)]
        private struct Point {
            /// <summary>
            /// X����
            /// </summary>
            public int X;
            /// <summary>
            /// Y����
            /// </summary>
            public int Y;
        }

        /// <summary>
        /// ���������Ϣ�ṹ
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct MouseLLHookStruct {
            /// <summary>
            /// �����Ļ����
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
            ///  �¼�ע���־�����������ֵ����������־  0 ��ע�� 1~15����
            /// </summary>
            public int Flags;
            /// <summary>
            /// ʱ���
            /// </summary>
            public int Time;
            /// <summary>
            /// ������Ϣ
            /// </summary>
            public int ExtraInfo;
        }

        /// <summary>
        /// ���������¼�
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            /// <summary>
            /// �������  1~254
            /// </summary>
            public int VirtualKeyCode;
            /// <summary>
            /// ������
            /// </summary>
            public int ScanCode;
            /// <summary>
            /// ��չ����ǣ��¼�ע���־��
            /// </summary>
            public int Flags;
            /// <summary>
            /// ʱ���
            /// </summary>
            public int Time;
            /// <summary>
            /// ������Ϣ
            /// </summary>
            public int ExtraInfo;
        }
    }
}
