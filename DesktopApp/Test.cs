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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OutstandingDelDs.Outstanding_Del' table. You can move, or remove it, as needed.
           // this.Outstanding_DelTableAdapter.Fill(this.OutstandingDelDs.Outstanding_Del);

            this.reportViewer1.RefreshReport();
        }
    }
}
