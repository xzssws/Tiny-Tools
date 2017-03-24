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
    /// ������
    /// </summary>
    public class CMLCONFIG
    {
        /// <summary>
        /// ���л�������
        /// </summary>
        private System.Xml.Serialization.XmlSerializer xmls = new System.Xml.Serialization.XmlSerializer(typeof(List<PathConfig>));
        /// <summary>
        /// �����ļ�����
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
        /// ��������
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
        /// ��Ӳ�����
        /// </summary>
        /// <param name="model">��ӵ�ʵ��</param>
        public void AddSave(PathConfig model)
        {
            EasyFilecg.Add(model);
            Save();
        }
        /// <summary>
        /// ���浽�����ļ�
        /// </summary>
        public void Save()
        {
            try
            {
                if (easyFilecg == null) throw new Exception("���ü�Ϊ��");
                //if (easyFilecg.Count <= 0) throw new Exception("���ü�����������");

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
        /// ��������
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
                        throw new Exception("�������ݴ�������Ϊ��");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public void Reset()
        {
            easyFilecg.Clear();
            Save();
        }
        //�����ʲô��˼����?
        public static void Init()
        {
            CreateXmlConfig.Save();
        }
        /// <summary>
        /// ɾ������
        /// </summary>
        /// <param name="apc"></param>
        public void Delete(PathConfig apc)
        {
            this.EasyFilecg.Remove(apc);
            Save();
        }
        /// <summary>
        /// ���и��¶���
        /// </summary>
        /// <param name="apc">ԭ�ж���</param>
        /// <param name="title">���±���</param>
        /// <param name="filePath">�����ļ�·��</param>
        /// <param name="dirPath">����Ŀ��·��</param>
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
    /// ·��������
    /// </summary>
    [Serializable]
    public class PathConfig
    {
        /// <summary>
        /// �ļ�·��
        /// </summary>
        public string FilePathSource;
        /// <summary>
        /// Ŀ¼·��
        /// </summary>
        public string DirectoryPath;
        /// <summary>
        /// ����
        /// </summary>
        public string Title;
    }

}
