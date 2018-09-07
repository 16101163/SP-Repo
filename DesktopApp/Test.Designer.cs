namespace DesktopApp
{
    partial class Test
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
           // this.OutstandingDelDs = new DesktopApp.OutstandingDelDs();
            this.Outstanding_DelBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.Outstanding_DelTableAdapter = new DesktopApp.OutstandingDelDsTableAdapters.Outstanding_DelTableAdapter();
           // ((System.ComponentModel.ISupportInitialize)(this.OutstandingDelDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Outstanding_DelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Outstanding_Report";
            reportDataSource1.Value = this.Outstanding_DelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DesktopApp.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(50, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // OutstandingDelDs
            // 
          //  this.OutstandingDelDs.DataSetName = "OutstandingDelDs";
          //  this.OutstandingDelDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Outstanding_DelBindingSource
            // 
            this.Outstanding_DelBindingSource.DataMember = "Outstanding_Del";
           // this.Outstanding_DelBindingSource.DataSource = this.OutstandingDelDs;
            //// 
            // Outstanding_DelTableAdapter
            // 
            //this.Outstanding_DelTableAdapter.ClearBeforeFill = true;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 351);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
           // ((System.ComponentModel.ISupportInitialize)(this.OutstandingDelDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Outstanding_DelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Outstanding_DelBindingSource;
      //  private OutstandingDelDs OutstandingDelDs;
     //   private OutstandingDelDsTableAdapters.Outstanding_DelTableAdapter Outstanding_DelTableAdapter;
    }
}