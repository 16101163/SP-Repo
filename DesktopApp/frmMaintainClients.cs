using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace DesktopApp
{
    public partial class frmMaintainClients : Form
    {
        int tempID;
        public frmMaintainClients(int x)
        {
            tempID = x;
            InitializeComponent();
        }
        string Desc;
        string iText;
        SPEntities db = new SPEntities();
        byte[] FileData;
        string FName;

        Credit_Approval NewCA = new Credit_Approval();

        private void frmMaintainClients_Load(object sender, EventArgs e)
        {
            using (SPEntities db = new SPEntities())
            {
                provinceBindingSource.DataSource = db.Provinces.ToList();
                cityBindingSource.DataSource = db.Cities.ToList();
                clientAccountStatusBindingSource.DataSource = db.Client_Account_Status.ToList();
                creditStatusBindingSource.DataSource = db.Credit_Status.ToList();
            }

            try
            {
                var query = db.Clients.Where(co => co.Client_ID == tempID).FirstOrDefault();
                var query1 = db.Provinces.Where(co => co.Province_Id == tempID).FirstOrDefault();
                var query2 = db.Cities.Where(co => co.City_Id == tempID).FirstOrDefault();
                var query3 = db.Credit_Approval.Where(co => co.Credit_Approval_ID == tempID).FirstOrDefault();
                var query4 = db.Credit_Status.Where(co => co.Credit_Status_ID == tempID).FirstOrDefault();


                txtName.Text = query.Client_Name;
                txtVatRegNum.Text = query.Client_VAT_Reg_Number;
                txtTelephone.Text = query.Client_Telephone;
                txtFaxNumber.Text = query.Client_Fax_Number;
                txtEmailAdd.Text = query.Client_Email_Address;
                txtPhysicalAdd.Text = query.Physical_Address;

                txtProvince.Text = query1.Province_Name;
                txtCity.Text = query2.City_Name;

                txtAmount.Text = Convert.ToString(query3.Credit_Approval_Amount);
                txtCreditSta.Text = query4.Credit_Status_Description;
                txtApprovedBy.Text = query3.Authourised_By;
                txtDateTimeDateOfCommencement.MinDate = Convert.ToDateTime(NewCA.Date_Of_Commencement);
                txtCreditSta.Text = Convert.ToString(query.Client_Account_Status);
                txtFilePath.Text = Convert.ToString(query3.Credit_Approval_Form);

            }
            catch (Exception )
            {

                MessageBox.Show("Whoops, An Error Occured");
            }
           

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save_Document = new SaveFileDialog())
            {

                save_Document.InitialDirectory = @"C:\";
                save_Document.Title = "Employee Documents";
                save_Document.Filter = "PDF Files (*.pdf)|*.pdf";
                save_Document.DefaultExt = "pdf";
                save_Document.AddExtension = true;

                if (save_Document.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(save_Document.FileName, NewCA.Credit_Approval_Form);
                }

            }
        }
        bool correct = false;
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            correct = true;

            Client NewCllient = new Client();
            Credit_Approval NewCA = new Credit_Approval();
            City newCity = new City();
            Credit_Status crStatus = new Credit_Status();
            Client_Account_Status cAS = new Client_Account_Status();
            Province NewProv = new Province();

            if (txtName.Text == "" || txtVatRegNum.Text == "" || txtTelephone.Text == "" || txtFaxNumber.Text == "" || txtEmailAdd.Text == "" || txtPhysicalAdd.Text == "" || txtApprovedBy.Text == "")
            {
                MessageBox.Show("Please enter all fields!");
                correct = false;
            }


            DialogResult dialogResult = MessageBox.Show("Would you like to update the client Information ?", "Update Template", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                if (correct == true)
                {
                    try
                    {
                        if (correct == true)
                        {
                            NewCllient.Client_Name = txtName.Text;
                            NewCllient.Client_VAT_Reg_Number = txtVatRegNum.Text;
                            NewCllient.Client_Telephone = txtTelephone.Text;
                            NewCllient.Client_Fax_Number = txtFaxNumber.Text;
                            NewCllient.Client_Email_Address = txtEmailAdd.Text;
                            NewCllient.Physical_Address = txtPhysicalAdd.Text;

                            int Province = 0;
                            var Prov = db.Provinces.Where(emp => emp.Province_Name == txtProvince.Text).Select(u => u.Province_Id).FirstOrDefault();
                            Province = Prov;
                            NewProv.Province_Id = Province;

                            int City = 0;
                            var Cty = db.Cities.Where(emp => emp.City_Name == txtCity.Text).Select(u => u.City_Id).FirstOrDefault();
                            City = Cty;
                            newCity.City_Id = City;

                            NewCA.Credit_Approval_Amount = Convert.ToDecimal(txtAmount.Text);


                            int Credit = 0;
                            var cstatus = db.Credit_Status.Where(emp => emp.Credit_Status_Description == txtCreditSta.Text).Select(u => u.Credit_Status_ID).FirstOrDefault();
                            Credit = cstatus;
                            crStatus.Credit_Status_ID = Credit;

                            NewCA.Authourised_By = txtApprovedBy.Text;
                            NewCA.Date_Of_Commencement = txtDateTimeDateOfCommencement.Value.Date;

                            int AccntStat = 0;
                            var atat = db.Client_Account_Status.Where(emp => emp.Account_Status_Description == comboBox5.Text).Select(u => u.Account_Status_ID).FirstOrDefault();

                            AccntStat = atat;

                            cAS.Account_Status_ID = AccntStat;

                            NewCA.Credit_Approval_Form = FileData;

                            //FK relationships
                            NewCllient.Province_Id = NewProv.Province_Id;
                            NewCllient.City_Id = newCity.City_Id;
                            NewCllient.Credit_Approval_ID = NewCA.Credit_Approval_ID;
                            NewCllient.Account_Status_ID = cAS.Account_Status_ID;

                            //Credit status table--not in client
                            NewCA.Credit_Status_ID = crStatus.Credit_Status_ID;





                            //Saving to indv tables
                            db.Clients.Add(NewCllient);
                            int myClient = NewCllient.Client_ID;

                            db.Credit_Approval.Add(NewCA);
                            int myCrApproval = NewCA.Credit_Approval_ID;

                            //  db.Cities.Add(newCity);
                            //==int myCty = newCity.City_Id;


                            // db.Client_Account_Status.Add(cAS);
                            //== int myAccstats = cAS.Account_Status_ID;
                            db.SaveChanges();

                            MessageBox.Show("Client Has been updated succesfully");
                            this.Close();

                        }


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error has occured, and template was not updated successfully" + ex);
                    }
                }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('.') || e.KeyChar.Equals(','))
            {
                e.KeyChar = ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture).NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
