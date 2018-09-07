using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DesktopApp
{
    public partial class frmMain : Form
    {
        int pw = 200;
        bool hidden;
        public frmMain(bool activate)
        {
            // frmSplashScreen load = new frmSplashScreen();
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(2000);

            InitializeComponent();

            t.Abort();
            menuStrip2.Enabled = activate;
            menuStrip2.Size = new Size(60, 390);
            ordersToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ordersToolStripMenuItem.Size = new Size(50, 50);
            dashboardToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            dashboardToolStripMenuItem.Size = new Size(50, 50);
            saleToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saleToolStripMenuItem.Size = new Size(50, 50);
            clientToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            clientToolStripMenuItem.Size = new Size(50, 50);
            productToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            productToolStripMenuItem.Size = new Size(50, 50);

            reportToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            reportToolStripMenuItem.Size = new Size(50, 50);

            pnlMenu.Width = 60;
            pbxMenu.Location = new Point(12, 0);
            hidden = true;

            MainMenuStrip.Enabled = activate;
            if (menuStrip2.Enabled == true)
            {
                loginToolStripMenuItem.Text = "Logout";
                //ucDashboard1.BringToFront();
                //ucDashboard1.Dock = DockStyle.Fill;
                Label user = new Label();
                panel4.Controls.Add(user);
                user.Text = " logged in as admin";
                user.BringToFront();
                user.Dock = DockStyle.Right;
                user.Font = new Font("Maiandra GD", 10);
            }


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnlMenu.Width = pnlMenu.Width + 20;
                pbxMenu.Location = new Point(160, 0);
                if (pnlMenu.Width >= pw)
                {
                    tmrSlide.Stop();
                    hidden = false;
                    this.Refresh();
                }
                menuStrip2.Size = new Size(200, 390);
                ordersToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                ordersToolStripMenuItem.Size = new Size(200, 50);
                dashboardToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                dashboardToolStripMenuItem.Size = new Size(200, 50);
                saleToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                saleToolStripMenuItem.Size = new Size(200, 50);
                clientToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                clientToolStripMenuItem.Size = new Size(200, 50);
                productToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                productToolStripMenuItem.Size = new Size(200, 50);

                reportToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                reportToolStripMenuItem.Size = new Size(200, 50);
            }
            else
            {
                pnlMenu.Width = pnlMenu.Width - 20;
                pbxMenu.Location = new Point(12, 0);
                if (pnlMenu.Width <= 60)
                {
                    tmrSlide.Stop();
                    hidden = true;
                    this.Refresh();
                }
                menuStrip2.Size = new Size(60, 390);
                ordersToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                ordersToolStripMenuItem.Size = new Size(50, 50);
                dashboardToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                dashboardToolStripMenuItem.Size = new Size(50, 50);
                saleToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                saleToolStripMenuItem.Size = new Size(50, 50);
                clientToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                clientToolStripMenuItem.Size = new Size(50, 50);
                productToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                productToolStripMenuItem.Size = new Size(50, 50);

                reportToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                reportToolStripMenuItem.Size = new Size(50, 50);
            }
        }
        public void splash()
        {
            Application.Run(new frmSplashScreen());
        }


        private void pbxMenu_Click(object sender, EventArgs e)
        {
            if (hidden)
            {
                pbxMenu.Location = new Point(0, 0);
            }
            tmrSlide.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ucDashboard1.BringToFront();
            //ucDashboard1.Dock=DockStyle.Fill;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to Log out ? ?", "confirmation", MessageBoxButtons.YesNo);


            //ucLogin1.BringToFront();
            //ucLogin1.Dock = DockStyle.Fill;
        }

        public void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //  ucPurchaseOrder1.panel4.Controls.Clear();
            UCNull nullclient = new UCNull();
            // ucPurchaseOrder1.panel4.Controls.Add(nullclient);
            nullclient.BringToFront();
            nullclient.Dock = DockStyle.Fill;
            //ucPurchaseOrder1.BringToFront();
            //ucPurchaseOrder1.Dock = DockStyle.Fill;

        }

        private void supplierOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCSupplier SupplierOrder = new UCSupplier();
            this.panel3.Controls.Add(SupplierOrder);
            SupplierOrder.BringToFront();
            SupplierOrder.Dock = DockStyle.Fill;

            UCViewOrders ViewOrder = new UCViewOrders();
            SupplierOrder.panel4.Controls.Add(ViewOrder);
            ViewOrder.BringToFront();
            ViewOrder.Dock = DockStyle.Fill;
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCSale Sale = new UCSale();
            panel3.Controls.Add(Sale);
            Sale.BringToFront();
            Sale.Dock = DockStyle.Fill;
        }

        private void ucLogin1_Load(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient U_AL = new frmClient("Maintain Client");
            U_AL.TopLevel = false;
            U_AL.AutoScroll = true;
            panel3.Controls.Add(U_AL);
            U_AL.Show();
            U_AL.Dock = DockStyle.Fill;
            U_AL.BringToFront();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCAddClient addClient = new UCAddClient();
            panel3.Controls.Add(addClient);
            addClient.BringToFront();
            addClient.Dock = DockStyle.Fill;
        }

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            frmNotification U_AL = new frmNotification("Maintain Template");
            U_AL.TopLevel = false;
            U_AL.AutoScroll = true;
            panel3.Controls.Add(U_AL);
            U_AL.Show();
            U_AL.Dock = DockStyle.Fill;
            U_AL.BringToFront();

        }

        private void updateCompanyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompanyInformation U_AL = new frmCompanyInformation();
            U_AL.TopLevel = false;
            U_AL.AutoScroll = true;
            panel3.Controls.Add(U_AL);
            U_AL.Show();
            U_AL.Dock = DockStyle.Fill;
            U_AL.BringToFront();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCUserAccessLevel U_AL = new UCUserAccessLevel();
            panel3.Controls.Add(U_AL);
            U_AL.BringToFront();
            U_AL.Dock = DockStyle.Fill;
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCVehicle Vehicle = new UCVehicle();
            this.panel3.Controls.Add(Vehicle);
            Vehicle.BringToFront();
            Vehicle.Dock = DockStyle.Fill;

            UCAddVehicle AddVehicle = new UCAddVehicle();
            Vehicle.panel4.Controls.Add(AddVehicle);
            AddVehicle.BringToFront();
            AddVehicle.Dock = DockStyle.Fill;
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UCDatabaseSettings DatabaseSettings = new UCDatabaseSettings();
            this.panel3.Controls.Add(DatabaseSettings);
            DatabaseSettings.BringToFront();
            DatabaseSettings.Dock = DockStyle.Fill;



        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UCRestore Restore = new UCRestore();
            panel3.Controls.Add(Restore);
            Restore.BringToFront();
            Restore.Dock = DockStyle.Fill;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UCProduct product = new UCProduct();
            panel3.Controls.Add(product);
            product.BringToFront();
            product.Dock = DockStyle.Fill;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCReports report = new UCReports();
            this.panel3.Controls.Add(report);
            report.BringToFront();
            report.Dock = DockStyle.Fill;

            UCNullReport Nullreport = new UCNullReport();
            report.panel4.Controls.Add(Nullreport);
            Nullreport.BringToFront();
            Nullreport.Dock = DockStyle.Fill;
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCEmployee Employee = new UCEmployee();
            this.panel3.Controls.Add(Employee);
            Employee.BringToFront();
            Employee.Dock = DockStyle.Fill;

            UCAddEmployee AddEmployee = new UCAddEmployee();
            Employee.panel4.Controls.Add(AddEmployee);
            AddEmployee.BringToFront();
            AddEmployee.Dock = DockStyle.Fill;
        }

        private void signINOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport U_AL = new frmReport();
            U_AL.TopLevel = false;
            U_AL.AutoScroll = true;
            panel3.Controls.Add(U_AL);
            U_AL.Show();
            U_AL.Dock = DockStyle.Fill;
            U_AL.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void auditLogReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditReports f = new frmAuditReports();
            f.ShowDialog();
        }

        private void outstandingDeliveriesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOustandingDeli_1 f = new frmOustandingDeli_1();
            f.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReportDatePick f = new frmSalesReportDatePick();
            f.ShowDialog();
        }
    }
}
