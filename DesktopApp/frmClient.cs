using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DesktopApp
{
    public partial class frmClient : Form
    {
        string option;
        public frmClient(string x)
        {
            option = x;
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Error: No search details entered");
                db.Clients.Load();
                this.clientBindingSource.DataSource = db.Clients.Local.ToBindingList();

            }
            else if (txtSearch.Text != "")
            {

                List<Client> Clientsearch = db.Clients.Where(o => o.Client_Name.Contains(txtSearch.Text)).ToList();

                if (Clientsearch.Count == 0)
                {
                    MessageBox.Show("Error: No Client Found");
                }
                else
                {
                    foreach (var a in Clientsearch)
                    {
                        dgvClients.DataSource = Clientsearch.Select(col => new { col.Client_Name, col.Client_VAT_Reg_Number, col.Client_Telephone, col.Client_Fax_Number, col.Physical_Address, col.Client_Email_Address, col.Province_Id, col.City_Id, col.Account_Status_ID, col.Credit_Approval_ID }).ToList();

                        dgvClients.Columns[0].HeaderText = "Client_Name";
                        dgvClients.Columns[0].Width = 100;
                        dgvClients.Columns[1].HeaderText = "Client_VAT_Reg_Number";
                        dgvClients.Columns[1].Width = 100;
                        dgvClients.Columns[2].HeaderText = "Telephone";
                        dgvClients.Columns[2].Width = 100;
                        dgvClients.Columns[3].HeaderText = "Client_Fax_Number";
                        dgvClients.Columns[3].Width = 100;

                        dgvClients.Columns[4].HeaderText = "Physical_Address";
                        dgvClients.Columns[4].Width = 100;
                        dgvClients.Columns[5].HeaderText = "Client_Email_Address";
                        dgvClients.Columns[5].Width = 100;
                        dgvClients.Columns[6].HeaderText = "Province_Id";
                        dgvClients.Columns[6].Width = 100;
                        dgvClients.Columns[7].HeaderText = "City_Id";
                        dgvClients.Columns[7].Width = 100;

                        dgvClients.Columns[8].HeaderText = "Client_Account_Status";
                        dgvClients.Columns[8].Width = 100;
                        dgvClients.Columns[9].HeaderText = "Credit_Approval";
                        dgvClients.Columns[9].Width = 100;


                 

                    }
                }
            }
        }
                
            
            
        

        private void frmClient_Load(object sender, EventArgs e)
        {
            dgvClients.ReadOnly = true;
            dgvClients.MultiSelect = false;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        
            db.Clients.Load();
            this.clientBindingSource.DataSource = db.Clients.Local.ToBindingList();

        }

        private void btnMaintain_Click(object sender, EventArgs e)
        {
          

            int val = Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value);

            if (option == "Maintain Client")
            {
                frmMaintainClients f = new frmMaintainClients(val);
                f.ShowDialog();
                dgvClients.DataSource = db.Clients.ToList();
                this.Close();

            }

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            frmAddClient f = new frmAddClient();
            f.ShowDialog();
            dgvClients.DataSource = db.Clients.ToList();
           

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            db.Clients.Load();
            this.clientBindingSource.DataSource = db.Clients.Local.ToBindingList();

        }
    }
}
