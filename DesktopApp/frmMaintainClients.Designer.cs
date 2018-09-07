namespace DesktopApp
{
    partial class frmMaintainClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintainClients));
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.clientAccountStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtApprovedBy = new System.Windows.Forms.TextBox();
            this.txtDateTimeDateOfCommencement = new System.Windows.Forms.DateTimePicker();
            this.txtCreditSta = new System.Windows.Forms.ComboBox();
            this.creditStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtProvince = new System.Windows.Forms.ComboBox();
            this.provinceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPhysicalAdd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVatRegNum = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFaxNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountStatusBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(132, 16);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(132, 23);
            this.txtTelephone.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Credit Approval Amount:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtAmount);
            this.groupBox5.Controls.Add(this.comboBox5);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.txtApprovedBy);
            this.groupBox5.Controls.Add(this.txtDateTimeDateOfCommencement);
            this.groupBox5.Controls.Add(this.txtCreditSta);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(631, 40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(404, 276);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Credit Approval Information";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(195, 35);
            this.txtAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 23);
            this.txtAmount.TabIndex = 24;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox5.DataSource = this.clientAccountStatusBindingSource;
            this.comboBox5.DisplayMember = "Account_Status_Description";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(195, 141);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(200, 24);
            this.comboBox5.TabIndex = 23;
            // 
            // clientAccountStatusBindingSource
            // 
            this.clientAccountStatusBindingSource.DataSource = typeof(DesktopApp.Client_Account_Status);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Account Status";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.btnBrowse);
            this.groupBox6.Controls.Add(this.txtFilePath);
            this.groupBox6.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 178);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(392, 86);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Upload Credit Approval Form";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(0, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "File Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.Location = new System.Drawing.Point(305, 56);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFilePath.Location = new System.Drawing.Point(72, 27);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(308, 23);
            this.txtFilePath.TabIndex = 7;
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApprovedBy.Location = new System.Drawing.Point(195, 87);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.Size = new System.Drawing.Size(200, 23);
            this.txtApprovedBy.TabIndex = 7;
            // 
            // txtDateTimeDateOfCommencement
            // 
            this.txtDateTimeDateOfCommencement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDateTimeDateOfCommencement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDateTimeDateOfCommencement.Location = new System.Drawing.Point(195, 112);
            this.txtDateTimeDateOfCommencement.Name = "txtDateTimeDateOfCommencement";
            this.txtDateTimeDateOfCommencement.Size = new System.Drawing.Size(200, 23);
            this.txtDateTimeDateOfCommencement.TabIndex = 19;
            // 
            // txtCreditSta
            // 
            this.txtCreditSta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCreditSta.DataSource = this.creditStatusBindingSource;
            this.txtCreditSta.DisplayMember = "Credit_Status_Description";
            this.txtCreditSta.FormattingEnabled = true;
            this.txtCreditSta.Location = new System.Drawing.Point(195, 61);
            this.txtCreditSta.Name = "txtCreditSta";
            this.txtCreditSta.Size = new System.Drawing.Size(200, 24);
            this.txtCreditSta.TabIndex = 18;
            // 
            // creditStatusBindingSource
            // 
            this.creditStatusBindingSource.DataSource = typeof(DesktopApp.Credit_Status);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "Date of Commencement:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Approved By:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Credit Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email Address:";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(DesktopApp.Client);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fax Number:";
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateClient.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.Location = new System.Drawing.Point(690, 401);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(109, 43);
            this.btnUpdateClient.TabIndex = 17;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 367);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Information";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.txtCity);
            this.groupBox4.Controls.Add(this.txtProvince);
            this.groupBox4.Controls.Add(this.txtPhysicalAdd);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(19, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(605, 170);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Place Of Business";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(541, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 28);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            this.txtCity.DataSource = this.cityBindingSource;
            this.txtCity.DisplayMember = "City_Name";
            this.txtCity.FormattingEnabled = true;
            this.txtCity.Location = new System.Drawing.Point(403, 100);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(132, 24);
            this.txtCity.TabIndex = 19;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DesktopApp.City);
            // 
            // txtProvince
            // 
            this.txtProvince.DataSource = this.provinceBindingSource;
            this.txtProvince.DisplayMember = "Province_Name";
            this.txtProvince.FormattingEnabled = true;
            this.txtProvince.Location = new System.Drawing.Point(129, 102);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(132, 24);
            this.txtProvince.TabIndex = 17;
            // 
            // provinceBindingSource
            // 
            this.provinceBindingSource.DataSource = typeof(DesktopApp.Province);
            // 
            // txtPhysicalAdd
            // 
            this.txtPhysicalAdd.Location = new System.Drawing.Point(129, 22);
            this.txtPhysicalAdd.Multiline = true;
            this.txtPhysicalAdd.Name = "txtPhysicalAdd";
            this.txtPhysicalAdd.Size = new System.Drawing.Size(456, 74);
            this.txtPhysicalAdd.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Physical Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Province:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtVatRegNum);
            this.groupBox2.Location = new System.Drawing.Point(16, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 48);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 23);
            this.txtName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "VAT Registration Number:";
            // 
            // txtVatRegNum
            // 
            this.txtVatRegNum.Location = new System.Drawing.Point(456, 17);
            this.txtVatRegNum.Name = "txtVatRegNum";
            this.txtVatRegNum.Size = new System.Drawing.Size(132, 23);
            this.txtVatRegNum.TabIndex = 1;
            this.txtVatRegNum.Text = " ";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtTelephone);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtFaxNumber);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtEmailAdd);
            this.groupBox3.Location = new System.Drawing.Point(16, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 99);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Information";
            // 
            // txtFaxNumber
            // 
            this.txtFaxNumber.Location = new System.Drawing.Point(456, 11);
            this.txtFaxNumber.Name = "txtFaxNumber";
            this.txtFaxNumber.Size = new System.Drawing.Size(132, 23);
            this.txtFaxNumber.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone:";
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Location = new System.Drawing.Point(132, 56);
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(132, 23);
            this.txtEmailAdd.TabIndex = 4;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteClient.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.Location = new System.Drawing.Point(805, 401);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(109, 43);
            this.btnDeleteClient.TabIndex = 19;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(920, 401);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(94, 43);
            this.btnDownload.TabIndex = 20;
            this.btnDownload.Text = "Download Form";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // frmMaintainClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 463);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnUpdateClient);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMaintainClients";
            this.Text = "frmMaintainClients";
            this.Load += new System.EventHandler(this.frmMaintainClients_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountStatusBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provinceBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource clientAccountStatusBindingSource;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtApprovedBy;
        private System.Windows.Forms.DateTimePicker txtDateTimeDateOfCommencement;
        private System.Windows.Forms.ComboBox txtCreditSta;
        private System.Windows.Forms.BindingSource creditStatusBindingSource;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox txtCity;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.ComboBox txtProvince;
        private System.Windows.Forms.BindingSource provinceBindingSource;
        private System.Windows.Forms.TextBox txtPhysicalAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVatRegNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFaxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.NumericUpDown txtAmount;
    }
}