using Dzmrap.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace Dzmrap.Core.Models
{
    /// <summary>
    /// 动作列表
    /// </summary>
    [XmlRoot("MAScript")]
    public class ActionList : List<MouseAction>, ICloneable
    {
        /// <summary>
        /// 加载动作列表
        /// </summary>
        public static ActionList Load(string FilePath)
        {
            return Core.Services.SerializerService.XmlDeserializeFromFile<ActionList>(FilePath,Encoding.UTF8);
        }
        /// <summary>
        /// 保存动作列表
        /// </summary>
        /// <param name="FilePath">文件路径</param>
        public void Save(string FilePath)
        {
            Core.Services.SerializerService.XmlSerializeToFile(this, FilePath, Encoding.UTF8);
        }
        /// <summary>
        /// 添加鼠标记录
        /// </summary>
        /// <param name="actionTime">操作时间戳</param>
        /// <param name="name">操作名称</param>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        public void AddMouseAction(string actionTime, MouseActionName name, int x, int y)
        {
            MouseAction ma = new MouseAction();
            ma.ActionTime = actionTime;
            ma.Name = name;
            ma.X = x;
            ma.Y = y;
            this.Add(ma);
        }
        Thread t;
        /// <summary>
        /// 播放脚本
        /// </summary>
        public void Play()
        {
            if (!IsRun)
            {
                IsRun = true;
                t = new Thread(TimeLineRun);
                t.Start();
            }
        }
        /// <summary>
        /// 播放脚本 循环
        /// </summary>
        public void PlayLoop()
        {
            if (!IsRun)
            {
                IsRun = true;
                t = new Thread(TimeLineRunLoop);
                t.Start();
            }
        }
        /// <summary>
        /// 是否正在播放
        /// </summary>
        public bool IsRun { get; set; }
        /// <summary>
        /// 执行脚本动作方法
        /// </summary>
        /// <param name="bl">The bl.</param>
        private void TimeLineRun(object bl)
        {
            for (int i = 0; i < this.Count; i++)
            {
                MouseControlService.ExecuteAction(this[i]);
                if (i + 1 == this.Count) break;
                TimeSpan splitSpan = TimeSpan.Parse(this[i + 1].ActionTime).Subtract(TimeSpan.Parse(this[i].ActionTime));
                Thread.Sleep(splitSpan);
            }
            IsRun = false;
        }
        /// <summary>
        /// 执行脚本动作方法 循环
        /// </summary>
        /// <param name="bl">The bl.</param>
        private void TimeLineRunLoop(object bl)
        {
            while (true)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    MouseControlService.ExecuteAction(this[i]);
                    if (i + 1 == this.Count) break;
                    TimeSpan splitSpan = TimeSpan.Parse(this[i + 1].ActionTime).Subtract(TimeSpan.Parse(this[i].ActionTime));
                    Thread.Sleep(splitSpan);
                }
            }
        }
        /// <summary>
        /// 停止播放脚本
        /// </summary>
        public void Stop()
        {
            if (t!=null)
            {
                t.Abort();
            }
            IsRun = false;
        }

        public object Clone()
        {
            return CloneEx();
        }
        public ActionList CloneEx()
        {
            return (ActionList)this.MemberwiseClone();
        }
    }
}
