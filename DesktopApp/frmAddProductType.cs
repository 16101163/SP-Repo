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
    public partial class frmAddProductType : Form
    {
        public frmAddProductType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to Add this Product Type?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Product details have been added successfully");
            MessageBox.Show("Please fill in all required fields");
        }
    }
}
