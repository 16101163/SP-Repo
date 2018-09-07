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
    public partial class frmAuditCreate : Form
    {
        DateTime date3;
        DateTime date4;
        string[] usera;
        public frmAuditCreate(DateTime xdate1, DateTime xdate2, string[] xuser)
        {
            date3 = xdate1;
            date4 = xdate2;
            usera = xuser;
            InitializeComponent();
        }
        SPEntities db = new SPEntities();
        private void frmAuditCreate_Load(object sender, EventArgs e)
        {
            Audit_Create_Cryst_Report cb = new Audit_Create_Cryst_Report();



            cb.SetParameterValue("date1", date3);
            cb.SetParameterValue("date2", date4);
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
