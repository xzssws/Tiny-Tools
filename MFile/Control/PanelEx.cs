using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.ComponentModel;

namespace MFileSpace
{
    public class PanelEx : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            if (IsLinear)
            {
                System.Drawing.Drawing2D.LinearGradientBrush lcb = new LinearGradientBrush(this.ClientRectangle, ColorUp, ColorDown, mode);
                e.Graphics.FillRectangle(lcb, e.ClipRectangle); 
            }
            base.OnPaint(e);
        }
        private Color colorUp = Color.White;
        [Description("上面的颜色")]
        public Color ColorUp
        {
            get { return colorUp; }
            set { colorUp = value; }
        }
        private Color colorDown = Color.FromArgb(168, 174, 188);
        [Description("下面的颜色")]
        public Color ColorDown
        {
            get { return colorDown; }
            set { colorDown = value; }
        }

        private LinearGradientMode mode;
        [Description("渐变模式")]
        public LinearGradientMode Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        private bool isLinear;
        [Description("是否使用渐变")]
        public bool IsLinear
        {
            get { return isLinear; }
            set { isLinear = value; }
        }

    }
    public class ButtonEx:Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            
            System.Drawing.Drawing2D.LinearGradientBrush lcb = new LinearGradientBrush(this.ClientRectangle, ColorUp, ColorDown, mode);
            e.Graphics.FillRectangle(lcb, e.ClipRectangle);
            base.OnPaint(e);
        }
        private Color colorUp = Color.White;
        /// <summary>
        /// 上面的颜色
        /// </summary>
        public Color ColorUp
        {
            get { return colorUp; }
            set { colorUp = value; }
        }
        private Color colorDown = Color.FromArgb(168, 174, 188);
        [Description("fsfds")]
        public Color ColorDown
        {
            get { return colorDown; }
            set { colorDown = value; }
        }

        private LinearGradientMode mode;

        public LinearGradientMode Mode
        {
            get { return mode; }
            set { mode = value; }
        }
    }
}
