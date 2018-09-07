namespace DesktopApp
{
    partial class frmPublish
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
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubjectLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btndd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Email_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSright = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1001, 380);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 40);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send To Clients";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSubjectLine);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFrom);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(109, 160);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(856, 300);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email ";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(107, 250);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(714, 43);
            this.listBox2.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(107, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(714, 82);
            this.listBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Conclusion:";
            // 
            // txtSubjectLine
            // 
            this.txtSubjectLine.Location = new System.Drawing.Point(107, 89);
            this.txtSubjectLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubjectLine.Multiline = true;
            this.txtSubjectLine.Name = "txtSubjectLine";
            this.txtSubjectLine.Size = new System.Drawing.Size(714, 32);
            this.txtSubjectLine.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(107, 30);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFrom.Multiline = true;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(714, 32);
            this.txtFrom.TabIndex = 5;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject Line:\r\n\r\n";
            // 
            // btndd
            // 
            this.btndd.Location = new System.Drawing.Point(554, 30);
            this.btndd.Name = "btndd";
            this.btndd.Size = new System.Drawing.Size(75, 23);
            this.btndd.TabIndex = 16;
            this.btndd.Text = "Add";
            this.btndd.UseVisualStyleBackColor = true;
            this.btndd.Click += new System.EventHandler(this.btndd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(554, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.clientNameDataGridViewTextBoxColumn1,
            this.Email,
            this.ColSright});
            this.dataGridView2.DataSource = this.clientBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(653, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(411, 150);
            this.dataGridView2.TabIndex = 18;
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataSource = typeof(DesktopApp.Client);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.Client_Email_Address,
            this.ColSelect});
            this.dataGridView1.DataSource = this.clientBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(134, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 141);
            this.dataGridView1.TabIndex = 14;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "Client_ID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // Client_Email_Address
            // 
            this.Client_Email_Address.DataPropertyName = "Client_Email_Address";
            this.Client_Email_Address.HeaderText = "Email Address";
            this.Client_Email_Address.Name = "Client_Email_Address";
            // 
            // ColSelect
            // 
            this.ColSelect.HeaderText = "Select";
            this.ColSelect.Name = "ColSelect";
            this.ColSelect.Width = 70;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataSource = typeof(DesktopApp.Client);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(DesktopApp.Client);
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client_ID";
            this.Client.HeaderText = "Client_ID";
            this.Client.Name = "Client";
            // 
            // clientNameDataGridViewTextBoxColumn1
            // 
            this.clientNameDataGridViewTextBoxColumn1.DataPropertyName = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn1.HeaderText = "Client_Name";
            this.clientNameDataGridViewTextBoxColumn1.Name = "clientNameDataGridViewTextBoxColumn1";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Client_Email_Address";
            this.Email.HeaderText = "Email Address";
            this.Email.Name = "Email";
            // 
            // ColSright
            // 
            this.ColSright.HeaderText = "Select";
            this.ColSright.Name = "ColSright";
            this.ColSright.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSright.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColSright.Width = 70;
            // 
            // frmPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 473);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btndd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPublish";
            this.Text = "frmPublish";
            this.Load += new System.EventHandler(this.frmPublish_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubjectLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btndd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Email_Address;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelect;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSright;
    }
}