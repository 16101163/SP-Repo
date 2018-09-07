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
    public partial class frmMaintainProductTYpe : Form
    {
        public frmMaintainProductTYpe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Are you sure you want to update the Product type details ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Product type details have been updated successfully");



            MessageBox.Show("Are you sure you want to delete this Product type ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Product type details have been deleted successfully");
            MessageBox.Show("This Product type can not be deleted as it is being used in another transaction");
        }
    }
}
