using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAlarmApp.Models
{
    /// <summary>
    /// 参数信息类
    /// </summary>
    public class ParaInfo
    {
        public string ParaName { get; set; }
        public byte SlaveId { get; set; }
        public ushort Address { get; set; }
        public string DataType { get; set; }
        public string Note { get; set; }
    }
}
