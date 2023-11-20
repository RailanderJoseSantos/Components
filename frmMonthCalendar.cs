using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class frmMonthCalendar : Form
    {
        public frmMonthCalendar()
        {
            InitializeComponent();
        }

        private void btnObterData_Click(object sender, EventArgs e)
        {
            txb1.Text = mcalenCalendarioMes.SelectionStart.ToShortDateString();
            txb2.Text = mcalenCalendarioMes.SelectionEnd.ToShortDateString();
            txb3.Text = mcalenCalendarioMes.TodayDate.ToShortDateString();

        }
    }
}
