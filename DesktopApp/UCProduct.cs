﻿using System;
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
    public partial class UCProduct : UserControl
    {
        public UCProduct()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ucAddProduct Addproduct = new ucAddProduct();
            panel4.Controls.Add(Addproduct);
            Addproduct.BringToFront();
            Addproduct.Dock = DockStyle.Fill;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            UCMaintainProduct Maintainproduct = new UCMaintainProduct();
            panel4.Controls.Add(Maintainproduct);
            Maintainproduct.BringToFront();
            Maintainproduct.Dock = DockStyle.Fill;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmAddProductType f = new frmAddProductType();
            f.ShowDialog();
        }
    }
}
