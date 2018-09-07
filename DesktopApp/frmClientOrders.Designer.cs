namespace DesktopApp
{
    partial class frmClientOrders
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewerClientOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDetailBindingSource
            // 
            this.OrderDetailBindingSource.DataMember = "OrderDetail";
            // 
            // ReportViewerClientOrder
            // 
            this.ReportViewerClientOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OrderDetails";
            reportDataSource1.Value = this.OrderDetailBindingSource;
            this.ReportViewerClientOrder.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerClientOrder.LocalReport.ReportEmbeddedResource = "DesktopApp.rptClientOrders.rdlc";
            this.ReportViewerClientOrder.Location = new System.Drawing.Point(0, 0);
            this.ReportViewerClientOrder.Name = "ReportViewerClientOrder";
            this.ReportViewerClientOrder.Size = new System.Drawing.Size(813, 486);
            this.ReportViewerClientOrder.TabIndex = 0;
            // 
            // frmClientOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 486);
            this.Controls.Add(this.ReportViewerClientOrder);
            this.Name = "frmClientOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClientOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerClientOrder;
        private System.Windows.Forms.BindingSource OrderDetailBindingSource;
    }
}