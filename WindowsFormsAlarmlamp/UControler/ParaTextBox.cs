using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlarmlamp.UControler
{
    public partial class ParaTextBox : UserControl
    {
        public ParaTextBox()
        {
            InitializeComponent();
        }

        private string dataVal;
        /// <summary>
        /// 参数值
        /// </summary>
        public string DataVal
        {
            get { return dataVal; }
            set
            {
                dataVal = value;
                lblText.Text = dataVal + " " + unit;
            }
        }

        private string unit;
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                lblText.Text = dataVal + " " + unit;
            }
        }

        private string varName;
        /// <summary>
        /// 参数名
        /// </summary>
        public string VarName
        {
            get { return varName; }
            set
            {
                varName = value;
            }
        }
    }
}
