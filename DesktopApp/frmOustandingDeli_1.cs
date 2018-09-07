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
    public partial class frmOustandingDeli_1 : Form
    {
        public frmOustandingDeli_1()
        {
            InitializeComponent();
        }

        private void frmOustandingDeli_1_Load(object sender, EventArgs e)
        {
           
        }
        SPEntities db = new SPEntities();
        Purchase_Order_Status status = new Purchase_Order_Status();
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            var OrderID = db.Client_Purchase_Order.ToList();
            var delstatID = db.Purchase_Order_Status.ToList();
            int count = 0;
            List<Client_Purchase_Order> cusList = OrderID.ToList();
            List<Purchase_Order_Status> statList = delstatID.ToList();
            int[] ID = new int[cusList.Count()];
            int[] statID = new int[0];
            foreach (var a in cusList)
            {
                ID[count] = cusList[count].Client_Purchase_Id;
                count++;
            }
         
               
                statID = new int[1];
                string StatusName = status.Purchase_Order_Status_Description = "Placed";
                foreach (var a in statID)
                {
                    var id = db.Purchase_Order_Status.Where(o => o.Purchase_Order_Status_Description == StatusName).Select(o => o.Purchase_Order_Status_ID).FirstOrDefault();
                    statID[0] = Convert.ToInt32(id);
                

            }
            DateTime date1 = dateTimePicker1.Value.Date;
            DateTime date2 = dateTimePicker2.Value.Date;

            frmOutstDelrpt myForm = new frmOutstDelrpt(statID, ID, date1.Date, date2.Date);
            myForm.ShowDialog();
        }
    }
}
