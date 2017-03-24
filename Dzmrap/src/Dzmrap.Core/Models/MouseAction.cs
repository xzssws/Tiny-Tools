using System;
using System.Xml.Serialization;

namespace Dzmrap.Core.Models
{
    /// <summary>
    /// 鼠标动作
    /// </summary>
    public class MouseAction
    {
        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlAttribute("time")]
        public string ActionTime { get; set; }
        /// <summary>
        /// 操作名称
        /// </summary>
        [XmlAttribute("name")]
        public MouseActionName Name { get; set; }

        /// <summary>
        /// X坐标
        /// </summary>
        [XmlAttribute("x")]
        public int X { get; set; }

        /// <summary>
        /// Y坐标
        /// </summary>
        [XmlAttribute("y")]
        public int Y { get; set; }
 
    }
}