using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class UCEmployeeReport : UserControl
    {
        public UCEmployeeReport()
        {
            InitializeComponent();
        }

        private void UCEmployeeReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OutstandingDelDs.Outstanding_Del' table. You can move, or remove it, as needed.
            this.EmployeeReportTableAdapter.Fill(this.DsEmployeeReport.EmployeeReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
