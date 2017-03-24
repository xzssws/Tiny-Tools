using System;
using System.Collections.Generic;
using System.Text;

namespace BuildData.AutoData
{
    /// <summary>
    /// 抽象数据生成类型
    /// </summary>
    public abstract class BaseData
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name;
        /// <summary>
        /// 自动数据
        /// </summary>
        /// <returns>返回的数据</returns>
        public abstract string AutoData();
        /// <summary>
        /// 获取一个随机整数
        /// </summary>
        /// <param name="min">最大值</param>
        /// <param name="max">最小值</param>
        /// <returns>随机数</returns>
        protected int BuildNumbers(int min, int max)
        {
            return rd.Next(min + 1, max);
        }
        private Random rd = new Random();
        /// <summary>
        /// 生成随机输入字符
        /// </summary>
        /// <param name="Text">输入字符</param>
        /// <param name="lenth">长度</param>
        /// <returns>随机字符</returns>
        protected string BuildChars(string Text, int lenth)
        {
            return BuildChars(Text, lenth, lenth);
        }
        /// <summary>
        /// 生成随机长度输入字符
        /// </summary>
        /// <param name="Text">随机字符</param>
        /// <param name="maxLenth">最小长度</param>
        /// <param name="minLength">最大长度</param>
        /// <returns>随机字符</returns>
        protected string BuildChars(string Text, int maxLenth, int minLength)
        {
            int lenth = BuildNumbers(minLength - 1, maxLenth);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lenth; i++)
            {
                int RandNum = BuildNumbers(0, Text.Length);
                sb.Append(Text[RandNum]);
            }
            return sb.ToString();
        }
        /// <summary>
        /// 获得数组中随机值
        /// </summary>
        /// <param name="strs">数组</param>
        /// <returns>随机值</returns>
        protected string BuildStrings(string[] strs)
        {
            return BuildList<string>(strs);
        }
        /// <summary>
        /// 获得数组中随机值
        /// </summary>
        /// <param name="strs">数组</param>
        /// <returns>随机值</returns>
        protected T BuildList<T>(T[] List)
        {
            return List[BuildNumbers(0 - 1, List.Length)];
        }
        /// <summary>
        /// 随机获得一个选择
        /// </summary>
        /// <returns></returns>
        protected bool GetSwitch()
        {
            return BuildNumbers(0, 3)==1?true:false;
        }
    }
}
