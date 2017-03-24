using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PlanEntity;
using PlanException;
using System.IO;

namespace JL计划书
{
    public partial class PlanMain : Form
    {
        public PlanMain()
        {
            InitializeComponent();
            init();
        }

        /// <summary>
        /// 临时计划集合
        /// </summary>
        public List<Plan> tmpPlan { get; set; }

        public object[] CreateObject(int count)
        {
            object[] H = new object[count];
            for (int i = 0; i < H.Length; i++)
            {
                H[i] = i + 1;
            }
            return H;
        }
        /// <summary>
        /// 窗体初始化代码
        /// </summary>
        public void init()
        {
            if (tmpPlan==null)
            {
                tmpPlan = new List<Plan>();
            }
            else
            {
                tmpPlan.Clear();
            }
            this.dgvData.AutoGenerateColumns = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                tmpPlan.Add(add1.CreatePlan());
                this.dgvData.DataSource = null;
                this.dgvData.DataSource = tmpPlan;
                add1.Go();
            }
            catch (planException ex)
            {
                MessageBox.Show(ex.Message,"出错啦！",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "文本文件|*.txt", FileName = DateTime.Today.ToLongDateString()+"_计划书" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DateTime dt = DateTime.Now;//测试时间
                StringBuilder sb = new StringBuilder();
                sb.Append("===================计划书=====================");
                foreach (Plan item in tmpPlan)
                {
                    sb.AppendLine();
                    sb.AppendLine("时间段:"+item.TimeSection);
                    sb.AppendLine("内容:"+item.Text);
                    sb.AppendLine("优先级:" + item.Priority);
                }
                sb.AppendLine("============================================");
                StreamWriter sw = File.CreateText(sfd.FileName);
                sw.Write(sb.ToString());
                sw.Close();
                MessageBox.Show( "耗时：" + DateTime.Now.Subtract(dt).TotalMilliseconds + "毫秒","保存成功!");
                tmpPlan.Clear();
                dgvData.DataSource = null;
            }
        }

    }
}
