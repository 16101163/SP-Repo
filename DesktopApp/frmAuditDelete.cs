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
    public partial class frmAuditDelete : Form
    {
        DateTime date1;
        DateTime date2;
        string[] user;
        public frmAuditDelete(DateTime xdate1, DateTime xdate2, string[] xuser)
        {
            date1 = xdate1;
            date2 = xdate2;
            user = xuser;
            InitializeComponent();
        }
        SPEntities db = new SPEntities();

        private void frmAuditDelete_Load(object sender, EventArgs e)
        {
            Audit_Delete_Crystal_Report cb = new Audit_Delete_Crystal_Report();


            cb.SetParameterValue("date1", date1);
            cb.SetParameterValue("date2", date2);
            int count = 0;
            int[] usersID = new int[user.Count()];
            foreach (var a in user)
            {
                string name = user[count];
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
