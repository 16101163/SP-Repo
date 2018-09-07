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
    public partial class UCAddAccessLevel : UserControl
    {
        public UCAddAccessLevel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to add this Access level ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Access Level has been Added successfully");
            MessageBox.Show("Please fill in all required fields");
        }
    }
}
