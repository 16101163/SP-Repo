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
    public partial class UCAddOrder : UserControl
    {
        
        public UCAddOrder()
        {   
            InitializeComponent();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInvoice f = new frmInvoice();
            f.ShowDialog();


            MessageBox.Show("Please add products to the supplier order");
            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show( "Are you sure you want to place this order?","confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Purchase order has been placed successfully");
            MessageBox.Show("Order Total exceeds client credit limit");
           
        }
    }
}
