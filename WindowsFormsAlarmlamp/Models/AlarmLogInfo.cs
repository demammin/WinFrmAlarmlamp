using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAlarmApp.Models
{
    /// <summary>
    /// 预警记录信息类
    /// </summary>
    public class AlarmLogInfo
    {
        public int Id { get; set; }
        public DateTime AlarmTime { get; set; }
        public string ParaName { get; set; }
        public int AlarmType { get; set; }
        public string AlarmState { get; set; }
        public int Value { get; set; }
        public string AlarmNote { get; set; }

        public AlarmLogInfo(int id, DateTime alarmTime, string paraName, int alarmType, string alarmState, int value, string alarmNote)
        {
            Id = id;
            AlarmTime = alarmTime;
            ParaName = paraName;
            AlarmType = alarmType;
            AlarmState = alarmState;
            Value = value;
            AlarmNote = alarmNote;
        }
    }
}
