using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlarmlamp.UControler
{
    public partial class UCAlarmControl : UserControl
    {
        System.Timers.Timer timer;
        int colorIndex = 0;
        Rectangle m_rectWorking;




        public UCAlarmControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);//忽略窗口消息
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//绘制到缓冲区
            SetStyle(ControlStyles.UserPaint, true);//由控件自身而不是操作系统绘制
            SetStyle(ControlStyles.ResizeRedraw, true);//调整大小时进行重绘
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);//支持透明背景
            SizeChanged += UCAlarmControl_SizeChanged;
            this.Size = new Size(50, 50);
            timer = new System.Timers.Timer();
            timer.Interval = 200;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
        }

        /// <summary>
        /// 定时切换灯的颜色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                colorIndex++;
                if (colorIndex >= alarmLightColors.Length)
                {
                    colorIndex = 0;

                }
                Invalidate();


            }));
        }


        //动态计算工作区的大小
        private void UCAlarmControl_SizeChanged(object sender, EventArgs e)
        {
            m_rectWorking = new Rectangle(Width / 8, Height / 8, Width - Width / 4, Height - Height / 4);

        }
        private Color[] alarmLightColors = { Color.Red ,Color.Yellow};
        /// <summary>
        /// 灯的颜色数组（如果需要闪烁，至少需要2种活以上颜色才行）
        /// </summary>
        public Color[] AlarmLightColors
        {
            get { return alarmLightColors; }
            set
            {
                if (value == null || value.Length == 0)
                    return;
                alarmLightColors = value;
                Invalidate();
            }
        }
        private Color standColor = Color.Gray;
        [DefaultValue(typeof(Color), "Gray"), Description("灯的底座颜色")]

        ////灯的底座颜色
        public Color StandColor
        {
            get { return standColor; }
            set { standColor = value;
                Invalidate();
            }
        }
        private int twinkleInterval = 0;

        /// <summary>
        /// 闪烁间隔 如果这个值为0 不闪烁
        /// </summary>
        public int TwinkleInterval 
        {
            get { return twinkleInterval; }
            set { if (value < 0) return;
                twinkleInterval = value;
                if (value == 0 || alarmLightColors.Length <= 1)
                { 
                    timer.Enabled = false;
                }
            else
            {
                colorIndex = 0;
            }
            Invalidate();
       }
}
        private bool isOn = false;

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; 
            if(isOn&&twinkleInterval>0)
                { timer.Interval= twinkleInterval;
                    timer.Start();
                }
                else
                {
                    timer.Stop();
                    colorIndex = 0;
                }
            Invalidate ();

                }
        }
        private string varName;
        /// <summary>
        ///报警灯检测的 参数名
        /// </summary>
        public string VarName
        {
            get { return varName; }
            set
            {
                varName = value;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//消除锯齿
            //灯的颜色
            Color c = AlarmLightColors[colorIndex];
            //灯泡部分的路径
            GraphicsPath path = new GraphicsPath();
            //左边竖线  下——上
            path.AddLine(m_rectWorking.Left, m_rectWorking.Bottom - Height / 4 + 2, m_rectWorking.Left, m_rectWorking.Top + m_rectWorking.Width);
            //半圆弧
            path.AddArc(m_rectWorking.Left, m_rectWorking.Top, m_rectWorking.Width, m_rectWorking.Width, 180f, 180f);
            //右边竖线
            path.AddLine(m_rectWorking.Right, m_rectWorking.Top + m_rectWorking.Width, m_rectWorking.Right, m_rectWorking.Bottom - Height / 4 + 2);
            path.CloseAllFigures();//关闭图形，形成一个闭合区域
            //填充灯泡
            g.FillPath(new SolidBrush(c), path);
            //填充底座
            g.FillRectangle(new SolidBrush(standColor), new Rectangle(0, m_rectWorking.Bottom - Height / 4, Width, Height / 4));
        }
      









    }
        }

  
