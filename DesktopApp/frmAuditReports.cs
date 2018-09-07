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
    public partial class frmAuditReports : Form
    {
        public frmAuditReports()
        {
            InitializeComponent();
        }
         SPEntities db = new SPEntities();
        private void frmAuditLogReport_Load(object sender, EventArgs e)
        {

            using (SPEntities db = new SPEntities())
            {
                userBindingSource.DataSource = db.Users.ToList();
            }

            List<User> userList = db.Users.ToList();

 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("All");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (listBox1.Items.Count > 0)
            {
                for (i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString() == comboBox1.Text)
                    {

                        listBox1.Items.Clear();
                        i++;
                    }

                    else if (listBox1.Items[i].ToString() != comboBox1.Text)
                    {
                        listBox1.Items.Clear();
                        listBox1.Items.Add(comboBox1.Text);


                    }
                }

            }
            else
            {
                listBox1.Items.Add(comboBox1.Text);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Please Select a User");
            }
            else if (listBox1.Items.Count != 0)
            {
                if (listBox1.Items[0].ToString() == "All")
                {
                    string id = comboBox1.Text;
                    var names = db.Users.ToList();
                    //int user = queryUser.User_ID;
                    List<User> UserList = names.ToList();
                    int count = UserList.Count;
                    int index = 0;
                    string[] useList = new string[count];
                    DateTime date1 = dateTimePicker1.Value;
                    DateTime date2 = dateTimePicker2.Value;
                    foreach (var a in UserList)
                    {

                        useList[index] = UserList[index].Users_Name;

                        index++;
                    }
                    if (cbCreate.Checked)
                    {
                        frmAuditCreate myform = new frmAuditCreate(date1, date2, useList);
                        this.Hide();
                        myform.ShowDialog();
                    }

                    if (cbDelete.Checked)
                    {
                        frmAuditDelete myform = new frmAuditDelete(date1, date2, useList);
                        this.Hide();
                        myform.ShowDialog();
                    }

                    if (cbUpdate.Checked)
                    {
                        frmAuditUpdate myform = new frmAuditUpdate(date1, date2, useList);
                        this.Hide();
                        myform.ShowDialog();
                    }
                   
                }

                else if (listBox1.Items[0].ToString() != "All" && listBox1.Items[0].ToString() != "")
                {
                    string[] useList = new string[listBox1.Items.Count];
                    int i = 0;
                    DateTime date1 = dateTimePicker1.Value;
                    DateTime date2 = dateTimePicker2.Value;
                    foreach (var a in useList)
                    {
                        useList[i] = listBox1.Items[i].ToString();
                        i++;
                    }

                    if (cbCreate.Checked)
                    {
                        frmAuditCreate myform = new frmAuditCreate(date1, date2, useList);
                        this.Hide();
                        myform.ShowDialog();
                    }


                    if (cbDelete.Checked)
                    {
                        frmAuditDelete myform = new frmAuditDelete(date1, date2, useList);
                        this.Hide();
                        myform.ShowDialog();
                    }

                    if (cbUpdate.Checked)
                    {
                        frmAuditUpdate myform = new frmAuditUpdate(date1, date2, useList);
                        this.Hide();
                        myform.ShowDialog();
                    }
                }

            }

        }
    }
}
