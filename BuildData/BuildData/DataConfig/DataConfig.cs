﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.DataConfig
{
    public class DataConfig
    {
        private Dictionary<string, Flag> flags;
        /// <summary>
        /// 标志集合
        /// </summary>
        public Dictionary<string, Flag> Flags
        {   //K 标志名称 V 标志类型
            get
            {
                if (flags == null) flags = new Dictionary<string, Flag>();
                return flags;
            }
            set { flags = value; }
        }

        private string strFormatter=" ";
        /// <summary>
        /// 字符串
        /// </summary>
        public string StrFormatter
        {
            get { return strFormatter; }
            set { strFormatter = value; }
        }

        private int buildCount;
        /// <summary>
        /// 生成数量
        /// </summary>
        public int BuildCount
        {
            get { return buildCount; }
            set { buildCount = value; }
        }

        private string savePath;
        /// <summary>
        /// 输出路径
        /// </summary>
        public string SavePath
        {
            get { return savePath; }
            set { savePath = value; }
        }

    }
}
