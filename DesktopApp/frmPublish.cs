using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Web;

namespace DesktopApp
{
    public partial class frmPublish : Form
    {
        int val;
        public frmPublish(int x)
        {
            val = x;
            InitializeComponent();
        }

        string textContent = "";
        SPEntities db = new SPEntities();

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (dataGridView2.Rows.Count < 1)
            {
                MessageBox.Show("Please Select Clients");
            }
            else
            {

                int cusID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);

                textContent = "";
                foreach (string a in listBox1.Items)
                {
                    textContent += a;
                }
                foreach (string a in listBox2.Items)
                {
                    textContent += a;
                }

                DialogResult dialogResult = MessageBox.Show("Would you like to Publish marketing material?", "Publish Marketing", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    Int32 selectedCellCount = dataGridView2.GetCellCount(DataGridViewElementStates.Selected);

                    try
                    {
                        foreach (DataGridViewRow row in this.dataGridView2.Rows)
                        {
                            
                                int ID = Convert.ToInt32(row.Cells[dataGridView2.Columns["Client"].Index].Value);

                                var body = db.Email_Notice_Template.Where(co => co.Template_Id == val).FirstOrDefault();
                                var email = db.Clients.Where(co => co.Client_ID == ID).Select(x => x.Client_Email_Address).FirstOrDefault();
                                var cust = db.Clients.Where(co => co.Client_ID == ID).Select(x => x.Client_Name).FirstOrDefault();
                                string contents = textContent;
                                string title = txtSubjectLine.Text;

                                try
                                {
                                    MailMessage mail = new MailMessage();
                                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                                    string custEmail = email.ToString();
                                    //MessageBox.Show(custEmail);

                                    mail.From = new MailAddress("infolopac@gmail.com");
                                    mail.To.Add(custEmail);
                                    mail.Subject = title;
                                    //MessageBox.Show(listBox1.Text);
                                    mail.Body = "Good Day " + cust.ToString() + " " + textContent;


                                    SmtpServer.Port = 587;
                                    SmtpServer.UseDefaultCredentials = false;
                                    SmtpServer.Credentials = new System.Net.NetworkCredential("infolopac@gmail.com", "infolopac1");
                                    SmtpServer.EnableSsl = true;

                                    SmtpServer.Send(mail);
                                    MessageBox.Show("Notification has been sent to Clients");


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Mail has not been sent" + ex.ToString());

                                }
                            //}





                            //for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
                            //{



                            //    int ID = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);



                            //    var body = db.Email_Notice_Template.Where(co => co.Template_Id == val).FirstOrDefault();
                            //    var email = db.Clients.Where(co => co.Client_ID == ID).Select(x => x.Client_Email_Address).FirstOrDefault();
                            //    var cust = db.Clients.Where(co => co.Client_ID == ID).Select(x => x.Client_Name).FirstOrDefault();
                            //    string contents = textContent;
                            //    string title = txtSubjectLine.Text;

                            //    try
                            //    {
                            //        MailMessage mail = new MailMessage();
                            //        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                            //        string custEmail = email.ToString();
                            //        //MessageBox.Show(custEmail);

                            //        mail.From = new MailAddress("infolopac@gmail.com");
                            //        mail.To.Add(custEmail);
                            //        mail.Subject = title;
                            //        //MessageBox.Show(listBox1.Text);
                            //        mail.Body = "Good Day " + cust.ToString() + " " + textContent;


                            //        SmtpServer.Port = 587;
                            //        SmtpServer.UseDefaultCredentials = false;
                            //        SmtpServer.Credentials = new System.Net.NetworkCredential("infolopac@gmail.com", "infolopac1");
                            //        SmtpServer.EnableSsl = true;

                            //        SmtpServer.Send(mail);
                            //        MessageBox.Show("Notification has been sent to Clients");


                            //    }
                            //    catch (Exception ex)
                            //    {
                            //        MessageBox.Show("Mail has not been sent" + ex.ToString());

                            //    }
                            //}



                        }
                    }
                    catch (Exception ex)
                    {


                    }
                }
            }

        }




        private void frmPublish_Load(object sender, EventArgs e)
        {


            dataGridView1.ReadOnly = false;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView2.ReadOnly = false;
            dataGridView2.MultiSelect = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            //var r = db.Clients.ToList();
            //dataGridView1.DataSource = r.Select(col => new { col.Client_ID, col.Client_Name, col.Client_Email_Address }).ToList();
            using (SPEntities db = new SPEntities())
            {
                clientBindingSource1.DataSource = db.Clients.ToList();
            }



            txtFrom.Text = db.Company_Information.Select(co => co.Company_Name).FirstOrDefault();

            var comp = db.Company_Information.FirstOrDefault();

            var quary = db.Email_Notice_Template.Where(co => co.Template_Id == val).FirstOrDefault();


            txtSubjectLine.Text = quary.Template_Description;

            listBox1.Items.Add("");
            listBox1.Items.Add(Environment.NewLine);
            listBox1.Items.Add(Environment.NewLine);
            listBox1.Items.Add(quary.Template_Text);
            listBox1.Items.Add(Environment.NewLine);
            listBox1.Items.Add(Environment.NewLine);

            listBox2.Items.Add("Kind Regards");
            listBox2.Items.Add(Environment.NewLine);
            listBox2.Items.Add(Environment.NewLine);
            listBox2.Items.Add("Lopac Tissues");
            listBox2.Items.Add(Environment.NewLine);
            listBox2.Items.Add("Contact Number: " + comp.Telephone_Number);
            listBox2.Items.Add("Email: " + comp.Email_Address);


        }

        private void btndd_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells["ColSelect"].Value))
                {
                    clientBindingSource2.Add((Client)row.DataBoundItem);
                    clientBindingSource1.RemoveAt(row.Index);

                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView2.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                if (Convert.ToBoolean(row.Cells["ColSright"].Value))
                {
                    clientBindingSource1.Add((Client)row.DataBoundItem);
                    clientBindingSource2.RemoveAt(row.Index);

                }
            }
        }
    }
}

