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
    public partial class UCConfirmDelivery : UserControl
    {
        public UCConfirmDelivery()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Upload success");
            MessageBox.Show("Please upload file with .pdf or .doc");

            MessageBox.Show("Are you sure you want to Confirm ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Confirmed succesfully");
            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Please choose a file to upload ");

        }
    }
}
