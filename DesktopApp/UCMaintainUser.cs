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
    public partial class UCMaintainUser : UserControl
    {
        public UCMaintainUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Are you sure you want update the User details ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("User details have been updated successfully");


            MessageBox.Show("Are you sure you want to delete this User ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("User details have been deleted successfully");
        }
    }
}
