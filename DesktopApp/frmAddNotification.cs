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
    public partial class frmAddNotification : Form
    {
        public frmAddNotification()
        {
            InitializeComponent();
        }
         SPEntities db = new SPEntities();
        bool correct = true;
        private void Add_Click(object sender, EventArgs e)
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



                Audit_Log Current_Audit = new Audit_Log();
                Current_Audit.Table_Name = "Notification Template";
                Current_Audit.Users_Id = Globals.Users_Id;
                Current_Audit.Date_Time = DateTime.Now;
                db.Audit_Log.Add(Current_Audit);
                db.SaveChanges();
                int Log_ID = Current_Audit.Audit_Log_Id;

                Audit_Create_Delete Current_Create = new Audit_Create_Delete();
                Current_Create.Audit_Log_Id = Log_ID;
                Current_Create.Created = true;
                Current_Create.PK_Row_Effected = Template_ID;
                Current_Create.Value = Template_Value;
                db.Audit_Create_Delete.Add(Current_Create);
                db.SaveChanges();
                MessageBox.Show("Notification template created successfully");
                this.Close();


            }
        }

        private void frmAddNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
