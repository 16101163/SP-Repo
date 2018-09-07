using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace DesktopApp
{
    public partial class UCOrderReport : UserControl
    {
        public UCOrderReport()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select o.OrderID, c.clientID, c.ContactName, c.Address, c.PostalCode, c.City, c.Phone, o.OrderDate" +
                                " from orders o inner join customers c on o.CustomerID = c.CustomerID" +
                               $" where o.OrderDate between '{dtFromDate.Value}' and '{dtToDate.Value}'";

                ordersBindingSource.DataSource = db.Query<Orders>(query, commandType: CommandType.Text);

            }
        }

        private void UCOrderReport_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource.Current as Orders;
            if (obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "select d.OrderID, p.ProductName, d.Quantity, d.Discount, d.UnitPrice from [Order Details] d inner join Products p on d.ProductID = p.ProductID" +
                                   $" where d.OrderID = '{obj.OrderID}'";
                    List<OrderDetail> list = db.Query<OrderDetail>(query, commandType: CommandType.Text).ToList();

                    using (frmClientOrders frm = new frmClientOrders(obj,list))
                    {
                        frm.ShowDialog();
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

