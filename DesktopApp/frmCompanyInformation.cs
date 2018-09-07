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
    public partial class frmCompanyInformation : Form
    {
        public frmCompanyInformation()
        {
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        bool correct = true;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            correct = true;

            if (correct == true)
            {
                try
                {
                    var query = db.Company_Information.FirstOrDefault();

                    query.Company_Name = txtCompName.Text;
                    query.Company_Address = txtCompAddress.Text;
                    query.VAT_Percentage = Convert.ToDecimal(txtVatPerc.Text);
                    query.VAT_Number = txtVatNumb.Text;
                    query.Registration_Number = txtRegNumber.Text;
                    query.Email_Address = txtEmailAddr.Text;
                    query.Telephone_Number = txtTelNumber.Text;

                    db.SaveChanges();
                    MessageBox.Show("Company information updated successfully");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occured" + ex);
                }
              

            }


            // MessageBox.Show("Please fill in all required fields");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmCompanyInformation_Load(object sender, EventArgs e)
        {
            txtCompName.Clear();
            txtCompAddress.Clear();
            txtVatNumb.Clear();
            txtVatPerc.Clear();
            txtRegNumber.Clear();
            txtEmailAddr.Clear();
            txtTelNumber.Clear();

            var query = db.Company_Information.FirstOrDefault();

            txtCompName.Text = query.Company_Name;
            txtCompAddress.Text = query.Company_Address;
            txtVatNumb.Text = query.VAT_Number;
            txtVatPerc.Text = Convert.ToString(query.VAT_Percentage);
            txtRegNumber.Text = query.Registration_Number;
            txtEmailAddr.Text = query.Email_Address;
            txtTelNumber.Text = query.Telephone_Number;
           
        }
    }
}
