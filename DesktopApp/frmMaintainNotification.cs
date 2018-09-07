using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;
using System.Web;

namespace DesktopApp
{
    public partial class frmMaintainNotification : Form
    {
        int tempID;
        public frmMaintainNotification(int x)
        {
            tempID = x;
            InitializeComponent();
        }
        string Desc;
        string iText;
        SPEntities db = new SPEntities();
        private void frmMaintainNotification_Load(object sender, EventArgs e)
        {
            var query = db.Email_Notice_Template.Where(co => co.Template_Id == tempID).FirstOrDefault();

            txtDescription.Text = query.Template_Description;
            txtText.Text = query.Template_Text;

            Desc = query.Template_Description;
            iText = query.Template_Text;
        }
        bool correct = false;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            correct = true;

            if (txtDescription.Text == "")
            {

                MessageBox.Show("Please enter a Template Description");
                correct = false;
            }
            else if (txtText.Text == "")
            {
                MessageBox.Show("Please enter a Template Text");
                correct = false;
            }

            DialogResult dialogResult = MessageBox.Show("Would you like to update this Template?", "Update Template", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                if (correct == true)
                {
                    try
                    {
                        if (correct == true)
                        {
                            var query = db.Email_Notice_Template.Where(co => co.Template_Id == tempID).FirstOrDefault();

                            query.Template_Description = txtDescription.Text;
                            query.Template_Text = txtText.Text;
                            db.SaveChanges();

                            Audit_Log Current_Audit = new Audit_Log();
                            Current_Audit.Table_Name = "Notification Template";
                            Current_Audit.Users_Id = Globals.Users_Id;
                            Current_Audit.Date_Time = DateTime.Now;
                            db.Audit_Log.Add(Current_Audit);
                            db.SaveChanges();
                            int Log_ID = Current_Audit.Audit_Log_Id;

                            if (txtText.Text != iText)
                            {
                                Audit_Update Update_Name1 = new Audit_Update();
                                Update_Name1.PK_Row_Effected = Convert.ToInt32(query.Template_Id);
                                Update_Name1.Field_Effected = "Text";
                                Update_Name1.Before_Value = iText.ToString();
                                Update_Name1.After_Value = txtText.Text.ToString();
                                Update_Name1.Audit_Log_Id = Log_ID;
                                db.Audit_Update.Add(Update_Name1);
                                db.SaveChanges();
                            }
                            if (txtDescription.Text != Desc)
                            {
                                Audit_Update Update_Name2 = new Audit_Update();
                                Update_Name2.PK_Row_Effected = Convert.ToInt32(query.Template_Id);
                                Update_Name2.Field_Effected = "Description";
                                Update_Name2.Before_Value = Desc.ToString();
                                Update_Name2.After_Value = txtDescription.Text.ToString();
                                Update_Name2.Audit_Log_Id = Log_ID;
                                db.Audit_Update.Add(Update_Name2);
                                db.SaveChanges();
                            }

                            MessageBox.Show("Marketing Template Successfully Updated");
                            this.Close();

                        }


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error has occured, and template was not updated successfully" + ex);
                    }
                }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Template?", "Delete Template", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Email_Notice_Template template = new Email_Notice_Template();
                    template = db.Email_Notice_Template.Find(tempID);

                    db.Email_Notice_Template.Remove(template);
                    db.SaveChanges();

                    int Marketing_Template_ID = template.Template_Id;
                    string Marketing_Template_Value = Convert.ToString(template);

                    Audit_Log Current_Audit = new Audit_Log();
                    Current_Audit.Table_Name = "Marketing_Template";
                    Current_Audit.Users_Id = Globals.Users_Id;
                    Current_Audit.Date_Time = DateTime.Now;
                    db.Audit_Log.Add(Current_Audit);
                    db.SaveChanges();
                    int Log_ID = Current_Audit.Audit_Log_Id;

                    Audit_Create_Delete Current_Create = new Audit_Create_Delete();
                    Current_Create.Audit_Log_Id = Log_ID;
                    Current_Create.Created = false;
                    Current_Create.PK_Row_Effected = Marketing_Template_ID;
                    Current_Create.Value = Marketing_Template_Value;
                    db.Audit_Create_Delete.Add(Current_Create);
                    db.SaveChanges();


                    MessageBox.Show("Notification Template Successfully Deleted");
                    this.Close();

                }

                catch (Exception)
                {
                    MessageBox.Show("Error has occured, and template was not deleted successfully");

                }

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
