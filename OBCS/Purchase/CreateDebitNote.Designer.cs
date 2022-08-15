namespace OBCS.Purchase
{
    partial class CreateDebitNote
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
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_typeName = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.cbo_type = new OBCS.Tools.CustomComboBox();
            this.cbo_poNumber = new OBCS.Tools.CustomComboBox();
            this.txt_glAccountNumber = new OBCS.CustomTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_supplierName = new OBCS.CustomTextBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_invoicingCompany = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.cbo_supplierID = new OBCS.Tools.CustomComboBox();
            this.customLabel15 = new OBCS.Tools.CustomLabel();
            this.cbo_site = new OBCS.Tools.CustomComboBox();
            this.customLabel18 = new OBCS.Tools.CustomLabel();
            this.txt_docNo = new OBCS.CustomTextBox();
            this.customLabel16 = new OBCS.Tools.CustomLabel();
            this.cbo_glAccountName = new OBCS.Tools.CustomComboBox();
            this.customLabel17 = new OBCS.Tools.CustomLabel();
            this.txt_amount = new OBCS.CustomTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_PO = new OBCS.Tools.CustomLabel();
            this.txt_poNumber = new OBCS.CustomTextBox();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(790, 114);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(156, 30);
            this.btn_create.TabIndex = 754;
            this.btn_create.Text = "Create a Debit Note";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_typeName
            // 
            this.txt_typeName.BackColor = System.Drawing.Color.White;
            this.txt_typeName.Enabled = false;
            this.txt_typeName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_typeName.Location = new System.Drawing.Point(819, 60);
            this.txt_typeName.Name = "txt_typeName";
            this.txt_typeName.Size = new System.Drawing.Size(127, 21);
            this.txt_typeName.TabIndex = 774;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(714, 61);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(31, 15);
            this.customLabel1.TabIndex = 773;
            this.customLabel1.Text = "Type";
            // 
            // cbo_type
            // 
            this.cbo_type.BackColor = System.Drawing.Color.White;
            this.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_type.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(751, 58);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(69, 23);
            this.cbo_type.TabIndex = 772;
            this.cbo_type.SelectedValueChanged += new System.EventHandler(this.cbo_type_SelectedValueChanged);
            // 
            // cbo_poNumber
            // 
            this.cbo_poNumber.BackColor = System.Drawing.Color.White;
            this.cbo_poNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_poNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_poNumber.FormattingEnabled = true;
            this.cbo_poNumber.Location = new System.Drawing.Point(502, 121);
            this.cbo_poNumber.Name = "cbo_poNumber";
            this.cbo_poNumber.Size = new System.Drawing.Size(107, 23);
            this.cbo_poNumber.TabIndex = 771;
            this.cbo_poNumber.Visible = false;
            // 
            // txt_glAccountNumber
            // 
            this.txt_glAccountNumber.BackColor = System.Drawing.Color.White;
            this.txt_glAccountNumber.Enabled = false;
            this.txt_glAccountNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_glAccountNumber.Location = new System.Drawing.Point(751, 31);
            this.txt_glAccountNumber.Name = "txt_glAccountNumber";
            this.txt_glAccountNumber.Size = new System.Drawing.Size(195, 21);
            this.txt_glAccountNumber.TabIndex = 770;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(677, 12);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(67, 15);
            this.customLabel6.TabIndex = 769;
            this.customLabel6.Text = "GL Account";
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(297, 98);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(69, 15);
            this.customLabel5.TabIndex = 767;
            this.customLabel5.Text = "PO Number";
            // 
            // txt_supplierName
            // 
            this.txt_supplierName.BackColor = System.Drawing.Color.White;
            this.txt_supplierName.Enabled = false;
            this.txt_supplierName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_supplierName.Location = new System.Drawing.Point(372, 41);
            this.txt_supplierName.Name = "txt_supplierName";
            this.txt_supplierName.Size = new System.Drawing.Size(277, 21);
            this.txt_supplierName.TabIndex = 764;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(279, 44);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(87, 15);
            this.customLabel4.TabIndex = 765;
            this.customLabel4.Text = "Supplier Name";
            // 
            // txt_invoicingCompany
            // 
            this.txt_invoicingCompany.BackColor = System.Drawing.Color.White;
            this.txt_invoicingCompany.Enabled = false;
            this.txt_invoicingCompany.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_invoicingCompany.Location = new System.Drawing.Point(129, 9);
            this.txt_invoicingCompany.Name = "txt_invoicingCompany";
            this.txt_invoicingCompany.Size = new System.Drawing.Size(92, 21);
            this.txt_invoicingCompany.TabIndex = 760;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(11, 12);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(112, 15);
            this.customLabel2.TabIndex = 761;
            this.customLabel2.Text = "Invoicing Company";
            // 
            // cbo_supplierID
            // 
            this.cbo_supplierID.BackColor = System.Drawing.Color.White;
            this.cbo_supplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_supplierID.FormattingEnabled = true;
            this.cbo_supplierID.Location = new System.Drawing.Point(372, 12);
            this.cbo_supplierID.Name = "cbo_supplierID";
            this.cbo_supplierID.Size = new System.Drawing.Size(156, 23);
            this.cbo_supplierID.TabIndex = 749;
            this.cbo_supplierID.SelectedIndexChanged += new System.EventHandler(this.cbo_supplierID_SelectedIndexChanged);
            // 
            // customLabel15
            // 
            this.customLabel15.AutoSize = true;
            this.customLabel15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel15.Location = new System.Drawing.Point(298, 15);
            this.customLabel15.Name = "customLabel15";
            this.customLabel15.Size = new System.Drawing.Size(68, 15);
            this.customLabel15.TabIndex = 755;
            this.customLabel15.Text = "Supplier ID";
            // 
            // cbo_site
            // 
            this.cbo_site.BackColor = System.Drawing.Color.White;
            this.cbo_site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_site.Enabled = false;
            this.cbo_site.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_site.FormattingEnabled = true;
            this.cbo_site.Location = new System.Drawing.Point(129, 36);
            this.cbo_site.Name = "cbo_site";
            this.cbo_site.Size = new System.Drawing.Size(76, 23);
            this.cbo_site.TabIndex = 753;
            // 
            // customLabel18
            // 
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel18.Location = new System.Drawing.Point(42, 39);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(81, 15);
            this.customLabel18.TabIndex = 758;
            this.customLabel18.Text = "Invoicing Site";
            // 
            // txt_docNo
            // 
            this.txt_docNo.BackColor = System.Drawing.Color.White;
            this.txt_docNo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_docNo.Location = new System.Drawing.Point(372, 68);
            this.txt_docNo.Name = "txt_docNo";
            this.txt_docNo.Size = new System.Drawing.Size(120, 21);
            this.txt_docNo.TabIndex = 752;
            // 
            // customLabel16
            // 
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel16.Location = new System.Drawing.Point(696, 90);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(49, 15);
            this.customLabel16.TabIndex = 756;
            this.customLabel16.Text = "Amount";
            // 
            // cbo_glAccountName
            // 
            this.cbo_glAccountName.BackColor = System.Drawing.Color.White;
            this.cbo_glAccountName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_glAccountName.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_glAccountName.FormattingEnabled = true;
            this.cbo_glAccountName.Location = new System.Drawing.Point(751, 9);
            this.cbo_glAccountName.Name = "cbo_glAccountName";
            this.cbo_glAccountName.Size = new System.Drawing.Size(195, 23);
            this.cbo_glAccountName.TabIndex = 750;
            this.cbo_glAccountName.SelectedIndexChanged += new System.EventHandler(this.cbo_type_SelectedIndexChanged);
            // 
            // customLabel17
            // 
            this.customLabel17.AutoSize = true;
            this.customLabel17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel17.Location = new System.Drawing.Point(240, 71);
            this.customLabel17.Name = "customLabel17";
            this.customLabel17.Size = new System.Drawing.Size(126, 15);
            this.customLabel17.TabIndex = 757;
            this.customLabel17.Text = "Supplier Doc. Number";
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_amount.Location = new System.Drawing.Point(751, 87);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(69, 21);
            this.txt_amount.TabIndex = 751;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(392, 96);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 19);
            this.panel7.TabIndex = 779;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lbl_PO);
            this.panel6.Location = new System.Drawing.Point(372, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(21, 21);
            this.panel6.TabIndex = 778;
            // 
            // lbl_PO
            // 
            this.lbl_PO.AutoSize = true;
            this.lbl_PO.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PO.Font = new System.Drawing.Font("Arial", 9F);
            this.lbl_PO.Location = new System.Drawing.Point(0, 2);
            this.lbl_PO.Name = "lbl_PO";
            this.lbl_PO.Size = new System.Drawing.Size(24, 15);
            this.lbl_PO.TabIndex = 519;
            this.lbl_PO.Text = "PO";
            // 
            // txt_poNumber
            // 
            this.txt_poNumber.BackColor = System.Drawing.Color.White;
            this.txt_poNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_poNumber.Location = new System.Drawing.Point(391, 95);
            this.txt_poNumber.MaxLength = 6;
            this.txt_poNumber.Name = "txt_poNumber";
            this.txt_poNumber.Size = new System.Drawing.Size(53, 21);
            this.txt_poNumber.TabIndex = 777;
            // 
            // CreateDebitNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(959, 156);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_poNumber);
            this.Controls.Add(this.txt_typeName);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.cbo_type);
            this.Controls.Add(this.cbo_poNumber);
            this.Controls.Add(this.txt_glAccountNumber);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.txt_supplierName);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_invoicingCompany);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.cbo_supplierID);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.customLabel15);
            this.Controls.Add(this.cbo_site);
            this.Controls.Add(this.customLabel18);
            this.Controls.Add(this.txt_docNo);
            this.Controls.Add(this.customLabel16);
            this.Controls.Add(this.cbo_glAccountName);
            this.Controls.Add(this.customLabel17);
            this.Controls.Add(this.txt_amount);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(975, 195);
            this.MinimumSize = new System.Drawing.Size(975, 195);
            this.Name = "CreateDebitNote";
            this.Text = "Create Debit Note";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.CustomComboBox cbo_supplierID;
        private System.Windows.Forms.Button btn_create;
        private Tools.CustomLabel customLabel15;
        private Tools.CustomComboBox cbo_site;
        private Tools.CustomLabel customLabel18;
        private CustomTextBox txt_docNo;
        private Tools.CustomLabel customLabel16;
        private Tools.CustomComboBox cbo_glAccountName;
        private Tools.CustomLabel customLabel17;
        private CustomTextBox txt_amount;
        private CustomTextBox txt_invoicingCompany;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_supplierName;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomLabel customLabel6;
        private CustomTextBox txt_glAccountNumber;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomComboBox cbo_type;
        private CustomTextBox txt_typeName;
        private Tools.CustomComboBox cbo_poNumber;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private Tools.CustomLabel lbl_PO;
        private CustomTextBox txt_poNumber;
    }
}