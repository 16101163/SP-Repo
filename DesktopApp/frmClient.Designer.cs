namespace DesktopApp
{
    partial class frmClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnMaintain = new System.Windows.Forms.Button();
            this.Client_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientVATRegNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientFaxNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physicalAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEmailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditApprovalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client_ID,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientVATRegNumberDataGridViewTextBoxColumn,
            this.clientTelephoneDataGridViewTextBoxColumn,
            this.clientFaxNumberDataGridViewTextBoxColumn,
            this.physicalAddressDataGridViewTextBoxColumn,
            this.clientEmailAddressDataGridViewTextBoxColumn,
            this.provinceIdDataGridViewTextBoxColumn,
            this.cityIdDataGridViewTextBoxColumn,
            this.accountStatusIDDataGridViewTextBoxColumn,
            this.creditApprovalIDDataGridViewTextBoxColumn});
            this.dgvClients.DataSource = this.clientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.Location = new System.Drawing.Point(22, 100);
            this.dgvClients.Name = "dgvClients";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.Size = new System.Drawing.Size(881, 202);
            this.dgvClients.TabIndex = 0;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(DesktopApp.Client);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Criteria:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(111, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(674, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(811, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(735, 385);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 37);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "Add Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnMaintain
            // 
            this.btnMaintain.Location = new System.Drawing.Point(828, 385);
            this.btnMaintain.Name = "btnMaintain";
            this.btnMaintain.Size = new System.Drawing.Size(75, 37);
            this.btnMaintain.TabIndex = 5;
            this.btnMaintain.Text = "Maintain Client";
            this.btnMaintain.UseVisualStyleBackColor = true;
            this.btnMaintain.Click += new System.EventHandler(this.btnMaintain_Click);
            // 
            // Client_ID
            // 
            this.Client_ID.DataPropertyName = "Client_ID";
            this.Client_ID.HeaderText = "Client_ID";
            this.Client_ID.Name = "Client_ID";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientVATRegNumberDataGridViewTextBoxColumn
            // 
            this.clientVATRegNumberDataGridViewTextBoxColumn.DataPropertyName = "Client_VAT_Reg_Number";
            this.clientVATRegNumberDataGridViewTextBoxColumn.HeaderText = "Client_VAT_Reg_Number";
            this.clientVATRegNumberDataGridViewTextBoxColumn.Name = "clientVATRegNumberDataGridViewTextBoxColumn";
            // 
            // clientTelephoneDataGridViewTextBoxColumn
            // 
            this.clientTelephoneDataGridViewTextBoxColumn.DataPropertyName = "Client_Telephone";
            this.clientTelephoneDataGridViewTextBoxColumn.HeaderText = "Client_Telephone";
            this.clientTelephoneDataGridViewTextBoxColumn.Name = "clientTelephoneDataGridViewTextBoxColumn";
            // 
            // clientFaxNumberDataGridViewTextBoxColumn
            // 
            this.clientFaxNumberDataGridViewTextBoxColumn.DataPropertyName = "Client_Fax_Number";
            this.clientFaxNumberDataGridViewTextBoxColumn.HeaderText = "Client_Fax_Number";
            this.clientFaxNumberDataGridViewTextBoxColumn.Name = "clientFaxNumberDataGridViewTextBoxColumn";
            // 
            // physicalAddressDataGridViewTextBoxColumn
            // 
            this.physicalAddressDataGridViewTextBoxColumn.DataPropertyName = "Physical_Address";
            this.physicalAddressDataGridViewTextBoxColumn.HeaderText = "Physical_Address";
            this.physicalAddressDataGridViewTextBoxColumn.Name = "physicalAddressDataGridViewTextBoxColumn";
            // 
            // clientEmailAddressDataGridViewTextBoxColumn
            // 
            this.clientEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "Client_Email_Address";
            this.clientEmailAddressDataGridViewTextBoxColumn.HeaderText = "Client_Email_Address";
            this.clientEmailAddressDataGridViewTextBoxColumn.Name = "clientEmailAddressDataGridViewTextBoxColumn";
            // 
            // provinceIdDataGridViewTextBoxColumn
            // 
            this.provinceIdDataGridViewTextBoxColumn.DataPropertyName = "Province_Id";
            this.provinceIdDataGridViewTextBoxColumn.HeaderText = "Province_Id";
            this.provinceIdDataGridViewTextBoxColumn.Name = "provinceIdDataGridViewTextBoxColumn";
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            this.cityIdDataGridViewTextBoxColumn.DataPropertyName = "City_Id";
            this.cityIdDataGridViewTextBoxColumn.HeaderText = "City_Id";
            this.cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            // 
            // accountStatusIDDataGridViewTextBoxColumn
            // 
            this.accountStatusIDDataGridViewTextBoxColumn.DataPropertyName = "Account_Status_ID";
            this.accountStatusIDDataGridViewTextBoxColumn.HeaderText = "Account_Status_ID";
            this.accountStatusIDDataGridViewTextBoxColumn.Name = "accountStatusIDDataGridViewTextBoxColumn";
            // 
            // creditApprovalIDDataGridViewTextBoxColumn
            // 
            this.creditApprovalIDDataGridViewTextBoxColumn.DataPropertyName = "Credit_Approval_ID";
            this.creditApprovalIDDataGridViewTextBoxColumn.HeaderText = "Credit_Approval_ID";
            this.creditApprovalIDDataGridViewTextBoxColumn.Name = "creditApprovalIDDataGridViewTextBoxColumn";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 434);
            this.Controls.Add(this.btnMaintain);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnMaintain;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientVATRegNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFaxNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physicalAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditApprovalIDDataGridViewTextBoxColumn;
    }
}