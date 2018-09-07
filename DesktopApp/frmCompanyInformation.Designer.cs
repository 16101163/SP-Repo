namespace DesktopApp
{
    partial class frmCompanyInformation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVatPerc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmailAddr = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVatNumb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCompAddress = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Company Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtVatPerc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtRegNumber);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTelNumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEmailAddr);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtVatNumb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCompAddress);
            this.groupBox1.Controls.Add(this.txtCompName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(129, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 401);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company information";
            // 
            // txtVatPerc
            // 
            this.txtVatPerc.Location = new System.Drawing.Point(120, 175);
            this.txtVatPerc.Multiline = true;
            this.txtVatPerc.Name = "txtVatPerc";
            this.txtVatPerc.Size = new System.Drawing.Size(329, 19);
            this.txtVatPerc.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "VAT Percentage:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(374, 360);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(120, 249);
            this.txtRegNumber.Multiline = true;
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(329, 19);
            this.txtRegNumber.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Registration Number:";
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Location = new System.Drawing.Point(120, 318);
            this.txtTelNumber.Multiline = true;
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.Size = new System.Drawing.Size(329, 19);
            this.txtTelNumber.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telephone Number:";
            // 
            // txtEmailAddr
            // 
            this.txtEmailAddr.Location = new System.Drawing.Point(122, 279);
            this.txtEmailAddr.Multiline = true;
            this.txtEmailAddr.Name = "txtEmailAddr";
            this.txtEmailAddr.Size = new System.Drawing.Size(329, 19);
            this.txtEmailAddr.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email Address:";
            // 
            // txtVatNumb
            // 
            this.txtVatNumb.Location = new System.Drawing.Point(120, 209);
            this.txtVatNumb.Multiline = true;
            this.txtVatNumb.Name = "txtVatNumb";
            this.txtVatNumb.Size = new System.Drawing.Size(329, 19);
            this.txtVatNumb.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "VAT Number:";
            // 
            // txtCompAddress
            // 
            this.txtCompAddress.Location = new System.Drawing.Point(120, 76);
            this.txtCompAddress.Multiline = true;
            this.txtCompAddress.Name = "txtCompAddress";
            this.txtCompAddress.Size = new System.Drawing.Size(329, 83);
            this.txtCompAddress.TabIndex = 3;
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(120, 33);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(329, 20);
            this.txtCompName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Company Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company Name:";
            // 
            // frmCompanyInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 466);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompanyInformation";
            this.Text = "frmCompanyInformation";
            this.Load += new System.EventHandler(this.frmCompanyInformation_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVatPerc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmailAddr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVatNumb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCompAddress;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}