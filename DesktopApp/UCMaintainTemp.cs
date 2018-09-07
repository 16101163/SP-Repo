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
    public partial class UCMaintainTemp : UserControl
    {
        int tempID;
        public UCMaintainTemp(int x)
        {
            tempID = x;
            InitializeComponent();
        }
        string Desc;
        string iText;
        SmartPac_DatabaseEntities db = new SmartPac_DatabaseEntities();
        private void UCMaintainTemp_Load(object sender, EventArgs e)
        {
            var query = db.Notice_Template.Where(co => co.Template_ID == tempID).FirstOrDefault();

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

            if (txtText.Text == "")
            {

                MessageBox.Show("Please enter a Template Text");
                correct = false;
            }

            DialogResult dialogResult = MessageBox.Show("Would you like to update this Template?", "Update Template", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                try
                {
                    if (correct == true)
                    {

                        var query = db.Notice_Template.Where(co => co.Template_ID == tempID).FirstOrDefault();

                        query.Template_Description = txtDescription.Text;
                        query.Template_Text = txtText.Text;
                        db.SaveChanges();
                        MessageBox.Show("Template Successfully Updated");

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Errot has occured, and template was not updated successfully");
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Template?", "Delete Template", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    Notice_Template template = new Notice_Template();
                    template = db.Notice_Template.Find(tempID);

                    db.Notice_Template.Remove(template);
                    db.SaveChanges();

                    int Marketing_Template_ID = template.Template_ID;
                    string Marketing_Template_Value = Convert.ToString(template);

                    MessageBox.Show("Marketing Template Successfully Deleted");
                    UCSearchTemplate MaintainTemplate = new UCSearchTemplate("Maintain Template");
                    panel1.Controls.Add(MaintainTemplate);
                    MaintainTemplate.BringToFront();
                    MaintainTemplate.Dock = DockStyle.Fill;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error has occured, and template was not deleted successfully");

                }
            }
        }
    }
}


