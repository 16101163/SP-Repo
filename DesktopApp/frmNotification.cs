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
    public partial class frmNotification : Form
    {
        string option;

        public frmNotification(string x)
        {
            option = x;
            InitializeComponent();

        }
        SPEntities db = new SPEntities();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNotification f = new frmAddNotification();
            f.ShowDialog();
            dataGridView1.DataSource = db.Email_Notice_Template.ToList();

        }

        private void frmNotification_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var r = db.Email_Notice_Template.ToList();
            groupBox1.Visible = true;

            dataGridView1.DataSource = r.Select(col => new { col.Template_Id, col.Template_Description, col.Template_Text }).ToList();
            dataGridView1.Columns[0].HeaderText = "Template ID";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Template Description";
            dataGridView1.Columns[1].Width = 360;
            dataGridView1.Columns[2].HeaderText = "Template Text";
            dataGridView1.Columns[2].Width = 800;

            if (option == "Search Template")
            {
                // btnSelect.Visible = false;

            }
            dataGridView1.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchDetails.Text == "")
            {

                MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchDetails.Text != "")
            {

                List<Email_Notice_Template> NoticeT = db.Email_Notice_Template.Where(o => o.Template_Description.Contains(txtSearchDetails.Text)).ToList();

                if (NoticeT.Count == 0)
                {


                    MessageBox.Show("Error: No Templates Found");

                }

                else
                {
                    foreach (var a in NoticeT)
                    {
                        dataGridView1.DataSource = NoticeT.Select(col => new { col.Template_Id, col.Template_Description, col.Template_Text }).ToList();
                        dataGridView1.Columns[0].HeaderText = "Template ID";
                        dataGridView1.Columns[0].Width = 100;
                        dataGridView1.Columns[1].HeaderText = "Template Description";
                        dataGridView1.Columns[1].Width = 360;
                        dataGridView1.Columns[2].HeaderText = "Template Text";
                        dataGridView1.Columns[2].Width = 800;

                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtSearchDetails.Text == "")
            {

                MessageBox.Show("Error: No search details entered");

            }
            else if (txtSearchDetails.Text != "")
            {

                List<Email_Notice_Template> NoticeT = db.Email_Notice_Template.Where(o => o.Template_Description.Contains(txtSearchDetails.Text)).ToList();

                if (NoticeT.Count == 0)
                {
                    groupBox1.Visible = true;

                    MessageBox.Show("Error: No Templates Found");

                }

                else
                {
                    foreach (var a in NoticeT)
                    {
                        dataGridView1.DataSource = NoticeT.Select(col => new { col.Template_Id, col.Template_Description, col.Template_Text }).ToList();
                        dataGridView1.Columns[0].HeaderText = "Template ID";
                        dataGridView1.Columns[0].Width = 100;
                        dataGridView1.Columns[1].HeaderText = "Template Description";
                        dataGridView1.Columns[1].Width = 360;
                        dataGridView1.Columns[2].HeaderText = "Template Text";
                        dataGridView1.Columns[2].Width = 800;

                    }
                }
            }
        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (option == "Maintain Template")
            {
                frmMaintainNotification myform = new frmMaintainNotification(val);
                myform.ShowDialog();
                dataGridView1.DataSource = db.Email_Notice_Template.ToList();
                this.Close();

            }

        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (option == "Maintain Template")
            {
                frmPublish myform = new frmPublish(val);
                myform.ShowDialog();
                dataGridView1.DataSource = db.Email_Notice_Template.ToList();
                this.Close();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
