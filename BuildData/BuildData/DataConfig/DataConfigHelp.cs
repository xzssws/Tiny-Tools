using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Collections.Generic;
using BuildData.AutoData;

namespace BuildData.DataConfig
{
    /// <summary>
    /// 配置帮助 后期考虑需不需要单例
    /// </summary>
    public class DataConfigHelp
    {
        #region 构造函数

        public DataConfigHelp(DataConfig config)
        {
            this.Config = config;
        }

        public DataConfigHelp()
            : this(new DataConfig())
        {

        }

        public DataConfigHelp(string configPath)
        {
            OpenConfig(configPath);
        }

        #endregion 构造函数

        #region 配置持久化

        /// <summary>
        /// 保存配置文件
        /// </summary>
        public bool SaveConfig()
        {
            try
            {
                using (FileStream fs = new FileStream(Config.SavePath, FileMode.CreateNew))
                {
                    binary.Serialize(fs, Config);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        /// <summary>
        /// 读取配置文件
        /// </summary>
        private void OpenConfig(string OpenPath)
        {
            try
            {
                using (FileStream fs = new FileStream(OpenPath, FileMode.Open))
                {
                    Config = (DataConfig)binary.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion 配置持久化

        #region 字段属性

        /// <summary>
        /// 序列化对象
        /// </summary>
        private BinaryFormatter binary = new BinaryFormatter();

        /// <summary>
        /// 配置文件
        /// </summary>
        private DataConfig Config;

        public DataConfig PublicConfig
        {
            get { return Config; }
        }

        /// <summary>
        /// 生成字符串
        /// </summary>
        private StringBuilder BuildString = null;
        /// <summary>
        /// 默认标志
        /// </summary>
        Dictionary<string, Flag> DefaultFlag = new Dictionary<string, Flag>();

        #endregion 字段属性

        #region 解析生成

        /// <summary>
        /// 生成语句
        /// </summary>
        private string BuildStrings(string str)
        {
            string source = str;
            //转换默认的
            foreach (var item in DataLibrary.DefaultFlag)
            {
                if (source.Contains(item.Key))
                    source = source.Replace(item.Key, AutoDataHelp.GetData(item.Value));
            }

            //转换定义的
            foreach (var item in Config.Flags)
            {
                if (source.Contains(item.Key))
                    source = source.Replace(item.Key, AutoDataHelp.GetData(item.Value,item.Key));
                //CR:item.key 2013年10月14日10:09:06 后加上去的表示自定义数据的Key
            }
            //生成String.Format() 以免反复调用此语句 看看这个和String.Format(那个快);
            return source;
        }

        /// <summary>
        /// 生成输出
        /// </summary>
        private void OutString()
        {
            BuildString = new StringBuilder();
            for (int i = 0; i < Config.BuildCount; i++)
            {
                BuildString.AppendLine(BuildStrings(Config.StrFormatter));
            }
        }
        /// <summary>
        /// 保存输出
        /// </summary>
        /// <returns>保存是否成功</returns>
        public bool SaveOut()
        {
            try
            {
                OutString();
                File.WriteAllText(Config.SavePath, BuildString.ToString(), Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion 解析生成

        //自定义后加 定义标志
        //预览组数据 预览单个数据 预览数量 在每个获取Config的步骤先判断是否为空
    }
}