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
    public partial class UCOutstandingDeliveriesReport : UserControl
    {
        public UCOutstandingDeliveriesReport()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UCOutstandingDeliveriesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OutstandingDelDs.Outstanding_Del' table. You can move, or remove it, as needed.
            //this.Outstanding_DelTableAdapter.Fill(this.OutstandingDelDs.Outstanding_Del);

            this.reportViewer1.RefreshReport();
        }
    }
}
