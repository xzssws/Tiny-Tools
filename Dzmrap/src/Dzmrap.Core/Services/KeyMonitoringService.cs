using Dzmrap.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dzmrap.Core.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyMonitoringService
    {
        /// <summary>
        /// 初始化 <see cref="KeyMonitoringService"/>类的新实例。
        /// </summary>
        /// <param name="kas">The kas.</param>
        public KeyMonitoringService(Dictionary<string, Action> kas)
        {
            Actions = kas;
            HookManager.KeyDown += HookManager_KeyDown;
        }

        private string KeyPressContent;

        /// <summary>
        /// 卸载
        /// </summary>
        public void UnInit()
        {
            HookManager.KeyDown -= HookManager_KeyDown;
            Actions = null;
        }

        Dictionary<string, Action> Actions;

        void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    KeyPressContent = "F1";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F10:
                    KeyPressContent = "F10";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F11:
                    KeyPressContent = "F11";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F12:
                    KeyPressContent = "F12";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F2:
                    KeyPressContent = "F2";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F3:
                    KeyPressContent = "F3";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F4:
                    KeyPressContent = "F4";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F5:
                    KeyPressContent = "F5";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F6:
                    KeyPressContent = "F6";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F7:
                    KeyPressContent = "F7";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F8:
                    KeyPressContent = "F8";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                case Keys.F9:
                    KeyPressContent = "F9";
                    if (Actions.Keys.Contains(KeyPressContent))
                    {
                        Actions[KeyPressContent]();
                    }
                    break;
                default:
                    break;
            }



        }
    }
}
