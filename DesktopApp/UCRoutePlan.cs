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
    public partial class UCRoutePlan : UserControl
    {
        public UCRoutePlan()
        {
            InitializeComponent();
            StringBuilder add = new StringBuilder("http://www.google.com/maps");
            webBrowser1.Navigate(add.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
