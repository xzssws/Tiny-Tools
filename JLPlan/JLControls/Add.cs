using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PlanException;
using PlanEntity;

namespace JLControls
{
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
            init();
        }
        /// <summary>
        /// 动画速度
        /// </summary>
        public int ScriptTime { get; set; }
        /// <summary>
        /// 记录原始位置
        /// </summary>
        private int aleft { get; set; }
       /// <summary>
       /// 验证输入是否正确并返回对象
       /// </summary>
       /// <returns>一个新的Plan实例</returns>
        public Plan CreatePlan()
        {
            if (cmbPriority.Text == "")
                throw new planException("优先级不可为空");
            if (int.Parse(cmdH1.Text) >= int.Parse(cmbH2.Text)&&int.Parse(cmbM1.Text)>int.Parse(cmbM2.Text))
                throw new planException("结束时间不得大于起始时间");
            if (txt_Text.Text == "")
                throw new planException("事件内容不可为空");

            return new Plan()
            {
                Priority = cmbPriority.Text,
                TimeSection = cmdH1.Text + ":" + cmbM1.Text + " ~ " + cmbH2.Text + ":" + cmbM2.Text,
                Text = txt_Text.Text
            };
        }
        /// <summary>
        /// 创建Object排序数组 从1开启
        /// </summary>
        /// <param name="count">数组最大值</param>
        /// <returns>返回数组</returns>
        public object[] CreateObject(int count)
        {
            object[] H = new object[count];
            for (int i = 0; i < H.Length; i++)
            {
                if (i<9)
                 H[i] = "0"+(i + 1);    
                else
                H[i] = i + 1;
            }
            return H;
        }
        /// <summary>
        /// 窗体初始化代码
        /// </summary>
        public void init()
        {
            object[] o60 = CreateObject(60);
            object[] o24 = CreateObject(24);
            cmdH1.Items.AddRange(o24);
            cmbH2.Items.AddRange(o24);
            cmbM1.Items.AddRange(o60);
            cmbM2.Items.AddRange(o60);
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public void Go()
        {
            aleft = this.Left;

            Time1.Start();
        }
        //动画
        private void Time1_Tick(object sender, EventArgs e)
        {
            if (this.Left+this.Width>0)
            {
                this.Left -= ScriptTime;
            }
            else
            {
                Time1.Stop();
                Init();
                this.Left = this.Parent.Width;
                Time2.Start();
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            this.cmdH1.SelectedIndex = -1;
            this.cmbH2.SelectedIndex = -1;
            this.cmbM1.SelectedIndex = -1;
            this.cmbM2.SelectedIndex = -1;
            this.txt_Text.Text = "";
            this.cmbPriority.SelectedIndex = -1;
        }

        private void Time2_Tick(object sender, EventArgs e)
        {//有点小问题哦
            if (this.Left>aleft+ScriptTime)
            {
                this.Left -= ScriptTime;
            }
            else if (this.Left>aleft)
            {
                this.Left -= 5;
            }
            else
            {
                Time2.Stop();
            }
        }

    }
}
