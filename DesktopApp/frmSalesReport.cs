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
    public partial class frmSalesReport : Form
    {
        DateTime date1;
        DateTime date2;
        public frmSalesReport(DateTime x, DateTime y)
        {
            date1 = x;
            date2 = y;
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        private void frmSalesReport_Load(object sender, EventArgs e)
        {

            //List<Payment> myPay = db.Payments.ToList();
            //int[] userid = new int[myPay.Count()];
            //int count = 0;
            //foreach (var a in myPay)
            //{
            //    userid[count] = a.iBean_User.User_ID;
            //    count++;

            //}
            Rpt_Sales cb = new Rpt_Sales();
            cb.SetParameterValue("Date1", date1.Date);
            cb.SetParameterValue("Date2", date2.Date);
           // cb.SetParameterValue("userID", userid.ToArray());
            crystalReportViewer1.ReportSource = cb;
           
        }
    }
}
