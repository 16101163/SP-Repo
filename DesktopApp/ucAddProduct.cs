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
    public partial class ucAddProduct : UserControl
    {
        public ucAddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddProductType f = new frmAddProductType();
            f.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMaintainProductTYpe f = new frmMaintainProductTYpe();
            f.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmMaintainProductTYpe f = new frmMaintainProductTYpe();
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAddProductType f = new frmAddProductType();
            f.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to Add this Product ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Product details have been added successfully");
            MessageBox.Show("Please fill in all required fields");
        }
    }
}
