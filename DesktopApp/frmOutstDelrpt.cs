using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class frmOutstDelrpt : Form
    {
        DateTime date1;
        DateTime date2;
        int[] status;
        int[] ID;
        public frmOutstDelrpt(int[] stat, int[] i, DateTime x, DateTime y)
        {
            status = stat;
            ID = i;
            date1 = x;
            date2 = y;
            InitializeComponent();
        }
    
      
        private void frmOutstDelrpt_Load(object sender, EventArgs e)
        {
            Outstanding_Del_Report cb = new Outstanding_Del_Report();
            cb.SetParameterValue("Status", status.ToArray());
             cb.SetParameterValue("Orderid", ID.ToArray());
            cb.SetParameterValue("date1", date1);
            cb.SetParameterValue("date2", date2);
            crystalReportViewer1.ReportSource = cb;
            crystalReportViewer1.Refresh();
       
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
