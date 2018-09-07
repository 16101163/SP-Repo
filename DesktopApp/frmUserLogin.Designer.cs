namespace DesktopApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.newReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tmrSlide = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCompanyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imlMaxNorm = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditLogReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outstandingDeliveriesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMenu.Controls.Add(this.menuStrip2);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(1, 1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(202, 468);
            this.pnlMenu.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.productToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.newReportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 40);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(186, 428);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // newReportToolStripMenuItem
            // 
            this.newReportToolStripMenuItem.Name = "newReportToolStripMenuItem";
            this.newReportToolStripMenuItem.Size = new System.Drawing.Size(173, 35);
            this.newReportToolStripMenuItem.Text = "New Report";
            this.newReportToolStripMenuItem.Click += new System.EventHandler(this.newReportToolStripMenuItem_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pbxMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 40);
            this.panel5.TabIndex = 4;
            // 
            // tmrSlide
            // 
            this.tmrSlide.Interval = 30;
            this.tmrSlide.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(203, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 40);
            this.panel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.AutoSize = false;
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(74, 36);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.vehicleToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(94, 36);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.userToolStripMenuItem.Text = "User and Access Level";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationToolStripMenuItem,
            this.updateCompanyInformationToolStripMenuItem,
            this.toolStripSeparator1,
            this.backupToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // notificationToolStripMenuItem
            // 
            this.notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            this.notificationToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.notificationToolStripMenuItem.Text = "Notification";
            this.notificationToolStripMenuItem.Click += new System.EventHandler(this.notificationToolStripMenuItem_Click);
            // 
            // updateCompanyInformationToolStripMenuItem
            // 
            this.updateCompanyInformationToolStripMenuItem.Name = "updateCompanyInformationToolStripMenuItem";
            this.updateCompanyInformationToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.updateCompanyInformationToolStripMenuItem.Text = "Update Company Information";
            this.updateCompanyInformationToolStripMenuItem.Click += new System.EventHandler(this.updateCompanyInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(346, 6);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.backupToolStripMenuItem.Text = "Database Settings";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(294, 28);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            this.vehicleToolStripMenuItem.Click += new System.EventHandler(this.vehicleToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 428);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // imlMaxNorm
            // 
            this.imlMaxNorm.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMaxNorm.ImageStream")));
            this.imlMaxNorm.TransparentColor = System.Drawing.Color.Transparent;
            this.imlMaxNorm.Images.SetKeyName(0, "Maximise.png");
            this.imlMaxNorm.Images.SetKeyName(1, "Normal.png");
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 469);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(825, 30);
            this.panel4.TabIndex = 6;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.TabIndex = 0;
            this.metroTile1.UseSelectable = true;
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.dashboardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashboardToolStripMenuItem.Image")));
            this.dashboardToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(173, 52);
            this.dashboardToolStripMenuItem.Text = "Home";
            this.dashboardToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrderToolStripMenuItem,
            this.supplierOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.ordersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersToolStripMenuItem.Image")));
            this.ordersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(173, 52);
            this.ordersToolStripMenuItem.Text = "Order";
            this.ordersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            this.purchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderToolStripMenuItem_Click);
            // 
            // supplierOrderToolStripMenuItem
            // 
            this.supplierOrderToolStripMenuItem.Name = "supplierOrderToolStripMenuItem";
            this.supplierOrderToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.supplierOrderToolStripMenuItem.Text = "Supplier Order";
            this.supplierOrderToolStripMenuItem.Click += new System.EventHandler(this.supplierOrderToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.saleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saleToolStripMenuItem.Image")));
            this.saleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(173, 52);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.clientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientToolStripMenuItem.Image")));
            this.clientToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(173, 52);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.productToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productToolStripMenuItem.Image")));
            this.productToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(173, 52);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditLogReportToolStripMenuItem,
            this.outstandingDeliveriesReportToolStripMenuItem,
            this.salesToolStripMenuItem});
            this.reportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(173, 52);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // auditLogReportToolStripMenuItem
            // 
            this.auditLogReportToolStripMenuItem.Name = "auditLogReportToolStripMenuItem";
            this.auditLogReportToolStripMenuItem.Size = new System.Drawing.Size(392, 36);
            this.auditLogReportToolStripMenuItem.Text = "Audit Log";
            this.auditLogReportToolStripMenuItem.Click += new System.EventHandler(this.auditLogReportToolStripMenuItem_Click);
            // 
            // outstandingDeliveriesReportToolStripMenuItem
            // 
            this.outstandingDeliveriesReportToolStripMenuItem.Name = "outstandingDeliveriesReportToolStripMenuItem";
            this.outstandingDeliveriesReportToolStripMenuItem.Size = new System.Drawing.Size(392, 36);
            this.outstandingDeliveriesReportToolStripMenuItem.Text = "Outstanding Deliveries ";
            this.outstandingDeliveriesReportToolStripMenuItem.Click += new System.EventHandler(this.outstandingDeliveriesReportToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(392, 36);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // pbxMenu
            // 
            this.pbxMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbxMenu.Image")));
            this.pbxMenu.Location = new System.Drawing.Point(161, 0);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(40, 40);
            this.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMenu.TabIndex = 1;
            this.pbxMenu.TabStop = false;
            this.pbxMenu.Click += new System.EventHandler(this.pbxMenu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(827, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel4);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Timer tmrSlide;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ImageList imlMaxNorm;
        //private UCLogin ucLogin1;
        private System.Windows.Forms.Panel panel4;
        //private UCDashboard ucDashboard1;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCompanyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ToolStripMenuItem newReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditLogReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outstandingDeliveriesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
    }
}