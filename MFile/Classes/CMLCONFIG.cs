using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.Collections;

namespace MFileSpace
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class CMLCONFIG
    {
        /// <summary>
        /// 序列化操作类
        /// </summary>
        private System.Xml.Serialization.XmlSerializer xmls = new System.Xml.Serialization.XmlSerializer(typeof(List<PathConfig>));
        /// <summary>
        /// 配置文件名称
        /// </summary>
        private static string XMLPATH = Program.XMLPATH;

        private List<PathConfig> easyFilecg = new List<PathConfig>();

        public List<PathConfig> EasyFilecg
        {
            get { return easyFilecg; }
            set { easyFilecg = value; }
        }

        private static CMLCONFIG xc;

        private CMLCONFIG() { }
        /// <summary>
        /// 创建配置
        /// </summary>
        public static CMLCONFIG CreateXmlConfig
        {
            get
            {
                if (!File.Exists(XMLPATH))
                {
                    File.Create(XMLPATH).Close();
                }
                if (xc == null)
                {
                    xc = new CMLCONFIG();
                }
                return xc;
            }
        }
        /// <summary>
        /// 添加并保持
        /// </summary>
        /// <param name="model">添加的实体</param>
        public void AddSave(PathConfig model)
        {
            EasyFilecg.Add(model);
            Save();
        }
        /// <summary>
        /// 保存到配置文件
        /// </summary>
        public void Save()
        {
            try
            {
                if (easyFilecg == null) throw new Exception("配置集为空");
                //if (easyFilecg.Count <= 0) throw new Exception("配置集不存在数据");

                using (FileStream fs = new FileStream(Program.cur + XMLPATH, FileMode.Create))
                {
                    xmls.Serialize(fs, easyFilecg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 加载数据
        /// </summary>
        public void Load()
        {
            try
            {
                using (FileStream fs = File.Open(Program.cur + XMLPATH, FileMode.Open))
                {
                    object obj = xmls.Deserialize(fs);
                    if (obj != null)
                    {
                        this.easyFilecg = obj as List<PathConfig>;
                    }
                    else
                    {
                        throw new Exception("解析数据错误：数据为空");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 重置配置
        /// </summary>
        public void Reset()
        {
            easyFilecg.Clear();
            Save();
        }
        //这个是什么意思来着?
        public static void Init()
        {
            CreateXmlConfig.Save();
        }
        /// <summary>
        /// 删除对象
        /// </summary>
        /// <param name="apc"></param>
        public void Delete(PathConfig apc)
        {
            this.EasyFilecg.Remove(apc);
            Save();
        }
        /// <summary>
        /// 进行更新对象
        /// </summary>
        /// <param name="apc">原有对象</param>
        /// <param name="title">更新标题</param>
        /// <param name="filePath">更新文件路径</param>
        /// <param name="dirPath">更新目标路径</param>
        public void Update(PathConfig apc, string title, string filePath, string dirPath)
        {
            PathConfig tmp = this.EasyFilecg.Find(delegate(PathConfig p)
            {
                if (p.Title == apc.Title && p.DirectoryPath == apc.DirectoryPath && p.FilePathSource == apc.DirectoryPath)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            if (tmp != null)
            {
                tmp.DirectoryPath = dirPath;
                tmp.FilePathSource = filePath;
                tmp.Title = title;
            }
            Save();
        }

    }
    /// <summary>
    /// 路径配置类
    /// </summary>
    [Serializable]
    public class PathConfig
    {
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePathSource;
        /// <summary>
        /// 目录路径
        /// </summary>
        public string DirectoryPath;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title;
    }

}
