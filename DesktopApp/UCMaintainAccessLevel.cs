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
    public partial class UCMaintainAccessLevel : UserControl
    {
        public UCMaintainAccessLevel()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Are you sure you want to update the Access level details ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Access Level details have been updated successfully");



            MessageBox.Show("Are you sure you want to delete this Access level ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Access level details have been deleted successfully");
            MessageBox.Show("This Access can not be deleted as it is being used in another transaction");
        }
    }
}
