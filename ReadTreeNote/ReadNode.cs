using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ReadTreeNote
{
    public partial class ReadNode : Form
    {
        public ReadNode()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 要解析的文件路径
        /// </summary>
        public string DocumentFile = Environment.CurrentDirectory + "\\文件目录.txt";

        /// <summary>
        /// 输出文本格式
        /// </summary>
        public string StringFormat = "INSERT INTO OA_SysModels([ModelName],[ParentId],[DisplayOrder],[URL]) VALUES('{0}',{1},{2},'{3}');";

        /// <summary>
        /// 输出Web网站路径
        /// </summary>
        public string WebRoot = @"E:\程序员~\OA目录\";

        /// <summary>
        /// 输出地脚本文件路径
        /// </summary>
        public string outFilePath = "c:\\数据库脚本.sql";

        public void Init()
        {
            List<Model> ls = ReadNodes();
            StringBuilder sb = new StringBuilder();
            ReadLs(ls, ref sb);
            File.WriteAllText(outFilePath, sb.ToString(), Encoding.UTF8);
            CreateFiles(ls, WebRoot);
        }

        /// <summary>
        /// /解析文件 目前只能三层 并返回集合
        /// </summary>
        /// <returns>整体集合</returns>
        public List<Model> ReadNodes()
        {
            //解析文档每行
            string[] FileStrLines = File.ReadAllLines(DocumentFile);

            List<Model> ls = new List<Model>();//总集合
            int i = 0;//根节点层次

            Model[] model = new Model[3];
            Model firstNode = null;//首层节点
            Model SecondNode = null;//二层节点
            Model ThreeNode = null;//三层节点
            List<Model> gz = new List<Model>();//当前根节点的子节点
            int id = 0;//当前节点ID

            foreach (string item in FileStrLines)
            {
                if (!item.Contains("\t"))//最根级节点
                {
                    i++;
                    id++;
                    firstNode = new Model(item.Trim());
                    firstNode.ID = id;
                    firstNode.ParentID = 0;
                    firstNode.OrderId = i;
                    firstNode.URL = "~/" + firstNode.Name.Trim() + ".aspx";
                    ls.Add(firstNode);
                }
                else if (item.Contains("\t") && !item.Contains("\t\t"))//如果是第一级子节点
                {
                    firstNode.OZid++;
                    id++;//子节点增加
                    if (firstNode._Ls == null)//如果当前根节点集合为空
                    {
                        firstNode._Ls = new List<Model>();//创建一个新的集合
                    }
                    SecondNode = new Model(item.Trim());
                    SecondNode.ID = id;//子节点等于当前子节点
                    SecondNode.ParentID = firstNode.ID;//父节点的ID=第一层次节点ID
                    SecondNode.OrderId = firstNode.OZid;//当前节点顺序等于父节点的当前子节点次序
                    SecondNode.URL = "~/" + firstNode.Name + "/" + SecondNode.Name + ".aspx";//URL路径
                    firstNode._Ls.Add(SecondNode);//将文本添加到节点
                }
                else if (item.Contains("\t\t") && !item.Contains("\t\t\t"))//如果是第二级节点
                {
                    id++;
                    if (SecondNode._Ls == null)
                    {
                        SecondNode._Ls = new List<Model>();
                    }
                    ThreeNode = new Model();
                    SecondNode.OZid++;
                    ThreeNode.Name = item.Trim();
                    ThreeNode.ID = id;
                    ThreeNode.ParentID = SecondNode.ID;
                    ThreeNode.OrderId = SecondNode.OZid;
                    ThreeNode.URL = "~/" + firstNode.Name + "/" + SecondNode.Name + "/" + ThreeNode.Name + ".aspx";
                    SecondNode._Ls.Add(ThreeNode);
                }
                else if (item.Contains("\t\t\t"))
                {
                    id++;
                    if (ThreeNode._Ls == null)
                    {
                        ThreeNode._Ls = new List<Model>();
                    }
                    ThreeNode.OZid++;
                    Model pz = new Model();
                    pz.Name = item.Trim();
                    pz.ID = id;
                    pz.ParentID = ThreeNode.ID;
                    pz.OrderId = ThreeNode.OZid;
                    pz.URL = "~/" + firstNode.Name + "/" + SecondNode.Name + "/" + ThreeNode.Name + pz.Name + ".aspx";
                    ThreeNode._Ls.Add(pz);
                }
            }
            return ls;
        }

        //读出集合
        public void ReadLs(List<Model> ls, ref StringBuilder sb)
        {
            foreach (Model item in ls)
            {
                sb.AppendLine(string.Format(StringFormat, item.Name.Trim(), item.ParentID, item.OrderId, item.URL));
                if (item._Ls != null)
                {
                    ReadLs(item._Ls, ref sb);
                }
            }
        }

        private DirectoryInfo dg;

        public void CreateFiles(List<Model> ls, string src)
        {
            string Src = src;//当前所在目录

            foreach (Model item in ls)
            {
                if (item._Ls != null)
                {
                    dg = Directory.CreateDirectory(Src + item.Name.Trim() + "\\");
                    CreateFiles(item._Ls, dg.FullName);
                }
                string[] rs = CreateAspx(item.Name);
                File.WriteAllText(src + item.Name + ".aspx", rs[0], Encoding.UTF8);
                File.WriteAllText(src + item.Name + ".aspx.cs", rs[1], Encoding.UTF8);
            }
        }

        /// <summary>
        /// 创建aspx和aspx.cs文件 代码文件
        /// </summary>
        /// <param name="name">创建aspx的名称</param>
        /// <returns>string数组 0表示aspx文件 1表示aspx.cs文件</returns>
        ///
        public string[] CreateAspx(string name)
        {
            string[] rstring = new string[2];
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<%@ Page Language=\"C#\" AutoEventWireup=\"true\" CodeFile=\"" + name + ".aspx.cs\" Inherits=\"" + name + "\" %>" + Environment.NewLine);
            sb.AppendLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">" + Environment.NewLine);
            sb.AppendLine("<html xmlns=\"http://www.w3.org/1999/xhtml\">" + Environment.NewLine);
            sb.AppendLine("\t<head runat=\"server\">");
            sb.AppendLine("\t\t<title>" + name + "</title>");
            sb.AppendFormat("\t</head>{0}\t<body>{0}\t\t<form id=\"form1\" runat=\"server\">{0}\t\t\t<div>{0}{0}\t\t\t</div>{0}\t\t</form>{0}\t</body>{0}</html>", Environment.NewLine);

            rstring[0] = sb.ToString();

            StringBuilder cs = new StringBuilder();
            cs.AppendLine(@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;");
            cs.AppendLine("public partial class " + name + ":System.Web.UI.Page");
            cs.AppendLine("\t{");
            cs.AppendLine("\t\tprotected void Page_Load(object sender,EventArgs e)");
            cs.AppendLine("\t\t{" + Environment.NewLine + "\t\t}");
            cs.AppendLine("}" + Environment.NewLine);

            rstring[1] = cs.ToString();
            return rstring;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入输出的文本格式", "信息提示");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "脚本|*.sql";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringFormat = textBox1.Text;
                    textBox1.Enabled = false;
                    outFilePath = sfd.FileName;
                    labFileSave.Text = outFilePath;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DocumentFile = ofd.FileName;//设置解析文档路径
                labDocumentSrc.Text = DocumentFile;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                WebRoot = ofd.SelectedPath + "\\";//设置解析文档路径
                labWebSrc.Text = WebRoot;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Code")
            {
                new Code().ShowDialog();
            }
            else
            {
                Init();
                MessageBox.Show("生成成功", "亲：");
            }
        }
    }
}