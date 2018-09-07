namespace DesktopApp
{
    partial class UCOutstandingDeliveriesReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Outstanding_DelBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.OutstandingDelDs = new DesktopApp.OutstandingDelDs();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
           // this.Outstanding_DelTableAdapter = new DesktopApp.OutstandingDelDsTableAdapters.Outstanding_DelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Outstanding_DelBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.OutstandingDelDs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Outstanding_DelBindingSource
            // 
            this.Outstanding_DelBindingSource.DataMember = "Outstanding_Del";
            //this.Outstanding_DelBindingSource.DataSource = this.OutstandingDelDs;
            // 
            // OutstandingDelDs
            // 
          //  this.OutstandingDelDs.DataSetName = "OutstandingDelDs";
           // this.OutstandingDelDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Outstanding Deliveries Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 10F);
            this.groupBox1.Location = new System.Drawing.Point(31, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 405);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outstanding Deliveries report";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Outstanding_Report";
            reportDataSource1.Value = this.Outstanding_DelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DesktopApp.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(48, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(813, 308);
            this.reportViewer1.TabIndex = 0;
            // 
            // Outstanding_DelTableAdapter
            // 
           // this.Outstanding_DelTableAdapter.ClearBeforeFill = true;
            // 
            // UCOutstandingDeliveriesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCOutstandingDeliveriesReport";
            this.Size = new System.Drawing.Size(951, 490);
            this.Load += new System.EventHandler(this.UCOutstandingDeliveriesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Outstanding_DelBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.OutstandingDelDs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
       // private OutstandingDelDsTableAdapters.Outstanding_DelTableAdapter Outstanding_DelTableAdapter;
        private System.Windows.Forms.BindingSource Outstanding_DelBindingSource;
       // private OutstandingDelDs OutstandingDelDs;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
