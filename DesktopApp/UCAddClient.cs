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
using System.Reflection;
using System.Text.RegularExpressions;

namespace DesktopApp
{
    public partial class UCAddClient : UserControl
    {
        public UCAddClient()
        {
            InitializeComponent();
        }
        public SPEntities db = new SPEntities();
        byte[] FileData;
        string FName;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Client NewCllient = new Client();
            Credit_Approval NewCA = new Credit_Approval();
            City newCity = new City();
            Credit_Status crStatus = new Credit_Status();
            Client_Account_Status cAS =new Client_Account_Status();
            Province NewProv = new Province();

            try
            {
                NewCllient.Client_Name = "Thabang";
                NewCllient.Client_VAT_Reg_Number = "123";
                NewCllient.Client_Telephone = "123";
                NewCllient.Client_Fax_Number = "123";
                NewCllient.Client_Email_Address = "Thabang@gmail";
                NewCllient.Physical_Address = "Feast str";

                int Province = 0;
                var Prov = db.Provinces.Where(emp => emp.Province_Name == txtProvince.Text).Select(u => u.Province_Id).FirstOrDefault();
                Province = Prov;
                NewProv.Province_Id = Province;

                int City = 0;
                var Cty = db.Cities.Where(emp => emp.City_Name == txtCity.Text).Select(u => u.City_Id).FirstOrDefault();
                City = Cty;
                newCity.City_Id = City;

                NewCA.Credit_Approval_Amount = 1000;


                int Credit = 0;
                var cstatus = db.Credit_Status.Where(emp => emp.Credit_Status_Description == txtCreditSta.Text).Select(u => u.Credit_Status_ID).FirstOrDefault();
                Credit = cstatus;
                crStatus.Credit_Status_ID = Credit;

                NewCA.Authourised_By = "Thabang";
                NewCA.Date_Of_Commencement =txtDateTimeDateOfCommencement.Value.Date;

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

                MessageBox.Show("Client Has been Added succesfully");

                int Client_Id = NewCllient.Client_ID;
                string Marketing_Value = Convert.ToString(NewCllient);

                Audit_Log Current_Audit3 = new Audit_Log();
                Current_Audit3.Table_Name = "Client";
                Current_Audit3.Users_Id = Globals.Users_Id;
                Current_Audit3.Date_Time = DateTime.Now;
                db.Audit_Log.Add(Current_Audit3);
                db.SaveChanges();
                int Log_ID3 = Current_Audit3.Audit_Log_Id;


                Audit_Create_Delete Current_Create3 = new Audit_Create_Delete();
                Current_Create3.Audit_Log_Id = Log_ID3;
                Current_Create3.Created = true;
                Current_Create3.PK_Row_Effected = Client_Id;
                Current_Create3.Value = Marketing_Value;
                db.Audit_Create_Delete.Add(Current_Create3);
                db.SaveChanges();

                //MessageBox.Show("Are you sure you want to add this client ?", "confirmation", MessageBoxButtons.YesNo);
                //MessageBox.Show("Client details have been added successfully");
                //MessageBox.Show("Client already exists on the system");
                //MessageBox.Show("Please fill in all required fields");
                //MessageBox.Show("Please select a client");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Whoops, Something went wrong. Please try again" + ex);
            }
           


        }

        private void UCAddClient_Load(object sender, EventArgs e)
        {
            using (SPEntities db = new SPEntities())
            {
                provinceBindingSource.DataSource = db.Provinces.ToList();
                cityBindingSource.DataSource = db.Cities.ToList();
                clientAccountStatusBindingSource.DataSource = db.Client_Account_Status.ToList();
                creditStatusBindingSource.DataSource = db.Credit_Status.ToList();
            }
        }
  

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                using (OpenFileDialog Get_PDF = new OpenFileDialog())
                {
                    Get_PDF.InitialDirectory = @"C:\";
                    Get_PDF.RestoreDirectory = true;
                    Get_PDF.Title = "Employee Documents";
                    Get_PDF.Multiselect = false;
                    Get_PDF.CheckFileExists = true;
                    Get_PDF.CheckPathExists = true;
                    Get_PDF.DefaultExt = "pdf";
                    Get_PDF.Filter = "PDF File (*.pdf)|*.pdf";
                    Get_PDF.FilterIndex = 1;
                    if (Get_PDF.ShowDialog() == DialogResult.OK)
                    {

                        FName = Get_PDF.FileName;
                        FileData = File.ReadAllBytes(FName);
                        File.ReadAllBytes(FName);
                       txtFilePath.Text = Get_PDF.FileName;
                        MessageBox.Show("Browse was successful");

                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Whoops, something went wrong, please try again");
            }
           
        }
    }
}
