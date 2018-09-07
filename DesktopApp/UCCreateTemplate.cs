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
    public partial class UCCreateTemplate : UserControl
    {
        public UCCreateTemplate()
        {
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        bool correct = true;
        private void button1_Click(object sender, EventArgs e)
        {
            correct = true;

            Email_Notice_Template newTemplate = new Email_Notice_Template();

            if (txtDescription.Text == "")
            {

                MessageBox.Show("Please enter a Template Description");
                correct = false;
            }

            if (txtText.Text == "")
            {

                MessageBox.Show("Please enter Template Text");
                correct = false;
            }
            if (correct == true)
            {
                newTemplate.Template_Description = txtDescription.Text;
                newTemplate.Template_Text = txtText.Text;


                db.Email_Notice_Template.Add(newTemplate);

                db.SaveChanges();

                int Template_ID = newTemplate.Template_Id;
                string Template_Value = Convert.ToString(newTemplate);

                //Audit_Log Current_Audit = new Audit_Log();
                //Current_Audit.Table_Name = "Marketing_Template";
                //Current_Audit.User_ID = Globals.User_ID;
                //Current_Audit.Date_Time = DateTime.Now;
                //db.Audit_Log.Add(Current_Audit);
                //db.SaveChanges();
                //int Log_ID = Current_Audit.Audit_Log_ID;

                //Audit_Create_Delete Current_Create = new Audit_Create_Delete();
                //Current_Create.Audit_Log_ID = Log_ID;
                //Current_Create.Created = true;
                //Current_Create.PK_Row_Effected = Marketing_Template_ID;
                //Current_Create.Value = Marketing_Template_Value;
                //db.Audit_Create_Delete.Add(Current_Create);
                //db.SaveChanges();


                MessageBox.Show("Template Successfully Created");
                


                //MessageBox.Show("Please enter all required fields");
                //MessageBox.Show("Are you sure you want to create this notification template ?", "confirmation", MessageBoxButtons.YesNo);
                //MessageBox.Show("Email notification template has been created successfully");
            }
        }
    }
}
