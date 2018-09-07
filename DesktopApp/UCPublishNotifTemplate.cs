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


namespace DesktopApp.UCNotification
{
    public partial class UCPublishNotifTemplate : UserControl
    {
        int tempID;
        public UCPublishNotifTemplate(int x)
        {
            tempID = x;
            InitializeComponent();
        }

        string Desc;
        string iText;
        SmartPac_DatabaseEntities db = new SmartPac_DatabaseEntities();
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Please select atleast one client");
            //MessageBox.Show("Are you sure you want to send this notification ?", "confirmation", MessageBoxButtons.YesNo);
            //MessageBox.Show("Email notification has been sent successfully");
            //MessageBox.Show("No internet connection discorvered");

         
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No internet connection discorvered");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UCPublishNotifTemplate_Load(object sender, EventArgs e)
        {
            var query = db.Notice_Template.Where(co => co.Template_ID == tempID).FirstOrDefault();

            txtDescription.Text = query.Template_Description;
            txtText.Text = query.Template_Text;

            Desc = query.Template_Description;
            iText = query.Template_Text;
        }
    }
}
