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
    public partial class UCSearchTemplate : UserControl
    {
        string option;
        public UCSearchTemplate(string x)
        {

            option = x;
            InitializeComponent();
        }
         SmartPac_DatabaseEntities db = new SmartPac_DatabaseEntities();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                if (option == "Maintain Template")
                {
                    label1.Text = "Maintain Template";
                    UCMaintainTemp MaintainTemplate = new UCMaintainTemp(val);
                    panel1.Controls.Add(MaintainTemplate);
                    MaintainTemplate.BringToFront();
                    MaintainTemplate.Dock = DockStyle.Fill;


                }
                else if (option == "Publish Template")
                {
                    label1.Text = "Publish Template";
                    UCNotification.UCPublishNotifTemplate publish = new UCNotification.UCPublishNotifTemplate(val);
                    panel1.Controls.Clear();
                    panel1.Controls.Add(publish);
                    publish.BringToFront();
                    publish.Dock = DockStyle.Fill;
                }
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please specify your marketing template search details first");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {






            //MessageBox.Show("Please fill in all required fields");
            //MessageBox.Show("Are you sure you want to delete this notification template ?", "confirmation", MessageBoxButtons.YesNo);
            //MessageBox.Show("Are you sure you want to update this notification template ?", "confirmation", MessageBoxButtons.YesNo);
            //MessageBox.Show("Notification template has been deleted successfully");
            //MessageBox.Show("Notification template has been updated successfully");

        }



        private void UCMaintainTemplateFields_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var r = db.Notice_Template.ToList();
            groupBox1.Visible = true;

            dataGridView1.DataSource = r.Select(col => new { col.Template_ID, col.Template_Description, col.Template_Text }).ToList();
            dataGridView1.Columns[0].HeaderText = "Template ID";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Template Description";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].HeaderText = "Template Text";
            dataGridView1.Columns[2].Width = 510;

            if (option == "Search Template")
            {
                btnSelect.Visible = false;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

