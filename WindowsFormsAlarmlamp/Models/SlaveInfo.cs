using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAlarmApp.Models
{
    /// <summary>
    /// 从站信息类
    /// </summary>
    public class SlaveInfo
    {
        public byte SlaveId { get; set; }
        public byte FuntionCode { get; set; }
        public ushort StartAddress { get; set; }
        public ushort Count { get; set; }
    }
}
