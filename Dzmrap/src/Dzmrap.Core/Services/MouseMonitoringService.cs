using Dzmrap.Core.Models;
using Dzmrap.Hooks;
using System;
using System.Windows.Forms;

namespace Dzmrap.Core.Services
{
    /// <summary>
    /// 鼠标录制服务
    /// </summary>
    public class MouseMonitoringService
    {
        /// <summary>
        ///  动作列表
        /// </summary>
        ActionList actionList;

        /// <summary>
        /// 获取动作列表
        /// </summary>
        /// <value>
        /// 动作列表
        /// </value>
        public ActionList ActionList
        {
            get
            {
                return actionList;
            }
        }
        /// <summary>
        /// 开始计算时间
        /// </summary>
        DateTime BeginTime;
        /// <summary>
        /// 获取 the now time span.
        /// </summary>
        /// <value>
        /// The now time span.
        /// </value>
        public string NowTimeSpan
        {
            get
            {
                return DateTime.Now.Subtract(BeginTime).ToString();
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            //HookManager.MouseDoubleClick += HookManager_MouseDoubleClick;
            //HookManager.MouseClick += HookManager_MouseClick;
            HookManager.MouseMove += HookManager_MouseMove;
            HookManager.MouseDown += HookManager_MouseDown;
            HookManager.MouseUp += HookManager_MouseUp;
            HookManager.MouseWheel += HookManager_MouseWheel;
        }

        void HookManager_MouseMove(object sender, MouseEventArgs e)
        {
            actionList.AddMouseAction(NowTimeSpan, MouseActionName.Move, e.X, e.Y);
        }

        /// <summary>
        /// 卸载方法
        /// </summary>
        public void uninit()
        {
            //HookManager.MouseDoubleClick -= HookManager_MouseDoubleClick;
            //HookManager.MouseClick -= HookManager_MouseClick;
            HookManager.MouseDown -= HookManager_MouseDown;
            HookManager.MouseUp -= HookManager_MouseUp;
            HookManager.MouseWheel -= HookManager_MouseWheel;
        }

        /// <summary>
        /// Handles the MouseWheel event of the HookManager control.
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="System.Windows.Forms.MouseEventArgs" /> 事件参数</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void HookManager_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
        }

        /// <summary>
        /// Handles the MouseUp event of the HookManager control.
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="System.Windows.Forms.MouseEventArgs" /> 事件参数</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void HookManager_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.LeftButtonUp, e.X, e.Y);
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.Right:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.RightButtonUp, e.X, e.Y);
                    break;
                case MouseButtons.XButton1:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.LeftButtonUp, e.X, e.Y);
                    break;
                case MouseButtons.XButton2:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.RightButtonUp, e.X, e.Y);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handles the MouseDown event of the HookManager control.
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="System.Windows.Forms.MouseEventArgs" /> 事件参数</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void HookManager_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.LeftButtonDown, e.X, e.Y);
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.Right:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.RightButtonDown, e.X, e.Y);
                    break;
                case MouseButtons.XButton1:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.LeftButtonDown, e.X, e.Y);
                    break;
                case MouseButtons.XButton2:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.RightButtonDown, e.X, e.Y);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handles the MouseClick event of the HookManager control.
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="System.Windows.Forms.MouseEventArgs" /> 事件参数</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void HookManager_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.Click, e.X, e.Y);
                    break;
                case MouseButtons.Middle:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.WheelClick, e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    break;
                case MouseButtons.XButton1:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.Click, e.X, e.Y);
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of the HookManager control.
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e"><see cref="System.Windows.Forms.MouseEventArgs" /> 事件参数</param>
        /// <exception cref="System.NotImplementedException"></exception>
        private void HookManager_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.DoubleClick, e.X, e.Y);
                    break;
                case MouseButtons.Middle:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.WheelClick, e.X, e.Y);
                    break;
                case MouseButtons.Right:
                    break;
                case MouseButtons.XButton1:
                    actionList.AddMouseAction(NowTimeSpan, MouseActionName.DoubleClick, e.X, e.Y);
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 开始记录
        /// </summary>
        public void Run()
        {
            BeginTime = DateTime.Now;
            actionList = new ActionList();
            IsRun = true;
            Init();
        }
        public bool IsRun { get; set; }
        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            if (IsRun)
            {
                uninit();
                IsRun = false;
            }
        }
    }
}