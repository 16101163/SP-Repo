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
    public partial class UCSalesReport : UserControl
    {
        public UCSalesReport()
        {
            InitializeComponent();

     
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void reportforsales1_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        
        }

        private void UCSalesReport_Load(object sender, EventArgs e)
        {
            this.SalesTableAdapter.Fill(this.SalesReportDs.Sales, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            this.SalesTableAdapter.Fill(this.SalesReportDs.Sales, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
