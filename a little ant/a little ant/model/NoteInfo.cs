using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_little_ant.model
{
    /// <summary>
    /// 记录信息类
    /// </summary>
    class NoteInfo
    {
        private string title;

        /// <summary>
        /// 获取或设置标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string fullText;

        /// <summary>
        /// 获取或设置全部文本
        /// </summary>
        public string FullText
        {
            get { return fullText; }
            set { fullText = value; }
        }

        private string abbreviatedDescription;

        /// <summary>
        /// 获取或设置缩略描述
        /// </summary>
        public string AbbreviatedDescription
        {
            get { return abbreviatedDescription; }
            set { abbreviatedDescription = value; }
        }
    }
}
