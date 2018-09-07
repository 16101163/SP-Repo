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
    public partial class frmAuditUpdate : Form
    {
        DateTime date1;
        DateTime date2;
        string[] usera;
        public frmAuditUpdate(DateTime xdate1, DateTime xdate2, string[] xuser)
        {
            date1 = xdate1;
            date2 = xdate2;
            usera = xuser; 
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        private void frmAuditUpdate_Load(object sender, EventArgs e)
        {
            Audit_Update_Crystal_Rprt cb = new Audit_Update_Crystal_Rprt();

            cb.SetParameterValue("date1", date1);
            cb.SetParameterValue("date2", date2);
            int count = 0;
            int[] usersID = new int[usera.Count()];
            foreach (var a in usera)
            {
                string name = usera[count];
                List<User> myCount = db.Users.Where(o => o.Users_Name == name).ToList();
                var users = db.Users.Where(o => o.Users_Name == name).Select(u => u.Users_Id).FirstOrDefault();
           
                usersID[count] = users;
                count++;


            }


            cb.SetParameterValue("user", usersID.ToArray());

            crystalReportViewer1.ReportSource = cb;
            crystalReportViewer1.Refresh();
        }
    }
}
