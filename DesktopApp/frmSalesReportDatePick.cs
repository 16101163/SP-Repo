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
    public partial class frmSalesReportDatePick : Form
    {
        public frmSalesReportDatePick()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;

            frmSalesReport myForm = new frmSalesReport(date1, date2);
            this.Hide();
            myForm.ShowDialog();
        }
    }
}
