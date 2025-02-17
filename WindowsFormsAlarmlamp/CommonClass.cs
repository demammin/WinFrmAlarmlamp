using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAlarmApp.Models;

namespace WindowsFormsAlarmlamp
{
    public class CommonClass
    {
        public static List<AlarmLogInfo> logList = new List<AlarmLogInfo>();//添加预警记录信息
        public static event Action UpdateAlarmLogList;//更新预警列表
        /// <summary>
        /// 调用更新记录
        /// </summary>
        public static void UpdateDgvAlarmList()
        {
            UpdateAlarmLogList?.Invoke();
        }


    }
}
