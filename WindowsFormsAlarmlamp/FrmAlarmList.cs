using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlarmlamp
{
    public partial class FrmAlarmList : Form
    {
        public FrmAlarmList()
        {
            InitializeComponent();
        }

        private void dgvAlarmList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAlarmList_Load(object sender, EventArgs e)
        {
            dgvAlarmList.AutoGenerateColumns = false;
            CommonClass.UpdateAlarmLogList += CommonClass_UpdateAlarmLogList;
            UpdageDgvDataSource();

        }

        private void UpdageDgvDataSource()
        {
            dgvAlarmList.DataSource = null;
            if (CommonClass.logList.Count > 0)
                dgvAlarmList.DataSource = CommonClass.logList;
        }

        private void CommonClass_UpdateAlarmLogList()
        {
            dgvAlarmList.Invoke(new Action(() =>
            {
                //刷新列表页----重新绑定一下
                UpdageDgvDataSource();
            }));
        }
    }
}
