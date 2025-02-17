using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAlarmApp.Models
{
    /// <summary>
    /// 预警设置信息类
    /// </summary>
    public class AlarmInfo
    {
        public string ParaType { get; set; }
        public int AlarmType { get; set; }
        public string AlarmValue { get; set; }
    }
}
