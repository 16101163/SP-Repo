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
    public partial class UCMakeSale : UserControl
    {
        public UCMakeSale()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Sale has been successfully Added");
            MessageBox.Show("Sale exceeded R1000");

        }
    }
}
