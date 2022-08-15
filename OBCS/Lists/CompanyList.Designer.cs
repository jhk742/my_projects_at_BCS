namespace OBCS.Lists
{
    partial class CompanyList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label24 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_legalName = new OBCS.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_legalCountry = new OBCS.Tools.CustomComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_legalCity = new OBCS.CustomTextBox();
            this.txt_legalState = new OBCS.CustomTextBox();
            this.txt_legalZIP = new OBCS.CustomTextBox();
            this.txt_legalAddress1 = new OBCS.CustomTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_legalAddress2 = new OBCS.CustomTextBox();
            this.btn_newSave = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_companyStatus = new OBCS.Tools.CustomComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_companyWebsite = new OBCS.CustomTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_companyEmail = new OBCS.CustomTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_companyFax = new OBCS.CustomTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbo_companyCountry = new OBCS.Tools.CustomComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_companyPhone = new OBCS.CustomTextBox();
            this.txt_companyAddress = new OBCS.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txt_companyName = new OBCS.CustomTextBox();
            this.txt_companyCode = new OBCS.CustomTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_FEIN = new OBCS.CustomTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_SSN = new OBCS.CustomTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbo_incomeTaxFormUsed = new OBCS.Tools.CustomComboBox();
            this.cbo_taxYear = new OBCS.Tools.CustomComboBox();
            this.cbo_fiscalYear = new OBCS.Tools.CustomComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_payrollPhone = new OBCS.CustomTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txt_payrollContact = new OBCS.CustomTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txt_payrollTitle = new OBCS.CustomTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.cbx_inactive = new System.Windows.Forms.CheckBox();
            this.txt_searchCompanyName = new OBCS.CustomTextBox();
            this.txt_searchCompanyCode = new OBCS.CustomTextBox();
            this.grid_company = new OBCS.CustomGrid();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_company)).BeginInit();
            this.SuspendLayout();
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(517, 218);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(271, 15);
            this.label24.TabIndex = 801;
            this.label24.Text = "Legal Information (Appears on payroll tax forms)";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_legalName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbo_legalCountry);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txt_legalCity);
            this.panel2.Controls.Add(this.txt_legalState);
            this.panel2.Controls.Add(this.txt_legalZIP);
            this.panel2.Controls.Add(this.txt_legalAddress1);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.txt_legalAddress2);
            this.panel2.Location = new System.Drawing.Point(511, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 163);
            this.panel2.TabIndex = 3;
            // 
            // txt_legalName
            // 
            this.txt_legalName.BackColor = System.Drawing.Color.White;
            this.txt_legalName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_legalName.Location = new System.Drawing.Point(99, 19);
            this.txt_legalName.MaxLength = 100;
            this.txt_legalName.Name = "txt_legalName";
            this.txt_legalName.Size = new System.Drawing.Size(259, 21);
            this.txt_legalName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 792;
            this.label3.Text = "Legal Name";
            // 
            // cbo_legalCountry
            // 
            this.cbo_legalCountry.BackColor = System.Drawing.Color.White;
            this.cbo_legalCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_legalCountry.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_legalCountry.FormattingEnabled = true;
            this.cbo_legalCountry.Location = new System.Drawing.Point(99, 127);
            this.cbo_legalCountry.Name = "cbo_legalCountry";
            this.cbo_legalCountry.Size = new System.Drawing.Size(113, 23);
            this.cbo_legalCountry.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 790;
            this.label1.Text = "Legal Country";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 15);
            this.label19.TabIndex = 788;
            this.label19.Text = "City, State, ZIP";
            // 
            // txt_legalCity
            // 
            this.txt_legalCity.BackColor = System.Drawing.Color.White;
            this.txt_legalCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_legalCity.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_legalCity.Location = new System.Drawing.Point(99, 100);
            this.txt_legalCity.MaxLength = 20;
            this.txt_legalCity.Name = "txt_legalCity";
            this.txt_legalCity.Size = new System.Drawing.Size(130, 21);
            this.txt_legalCity.TabIndex = 3;
            // 
            // txt_legalState
            // 
            this.txt_legalState.BackColor = System.Drawing.Color.White;
            this.txt_legalState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_legalState.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_legalState.Location = new System.Drawing.Point(228, 100);
            this.txt_legalState.MaxLength = 2;
            this.txt_legalState.Name = "txt_legalState";
            this.txt_legalState.Size = new System.Drawing.Size(50, 21);
            this.txt_legalState.TabIndex = 4;
            // 
            // txt_legalZIP
            // 
            this.txt_legalZIP.BackColor = System.Drawing.Color.White;
            this.txt_legalZIP.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_legalZIP.Location = new System.Drawing.Point(277, 100);
            this.txt_legalZIP.MaxLength = 5;
            this.txt_legalZIP.Name = "txt_legalZIP";
            this.txt_legalZIP.Size = new System.Drawing.Size(81, 21);
            this.txt_legalZIP.TabIndex = 5;
            // 
            // txt_legalAddress1
            // 
            this.txt_legalAddress1.BackColor = System.Drawing.Color.White;
            this.txt_legalAddress1.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_legalAddress1.Location = new System.Drawing.Point(99, 46);
            this.txt_legalAddress1.MaxLength = 100;
            this.txt_legalAddress1.Name = "txt_legalAddress1";
            this.txt_legalAddress1.Size = new System.Drawing.Size(259, 21);
            this.txt_legalAddress1.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(11, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 15);
            this.label26.TabIndex = 759;
            this.label26.Text = "Legal Address";
            // 
            // txt_legalAddress2
            // 
            this.txt_legalAddress2.BackColor = System.Drawing.Color.White;
            this.txt_legalAddress2.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_legalAddress2.Location = new System.Drawing.Point(99, 73);
            this.txt_legalAddress2.MaxLength = 100;
            this.txt_legalAddress2.Name = "txt_legalAddress2";
            this.txt_legalAddress2.Size = new System.Drawing.Size(259, 21);
            this.txt_legalAddress2.TabIndex = 2;
            // 
            // btn_newSave
            // 
            this.btn_newSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newSave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newSave.Location = new System.Drawing.Point(1117, 13);
            this.btn_newSave.Name = "btn_newSave";
            this.btn_newSave.Size = new System.Drawing.Size(125, 30);
            this.btn_newSave.TabIndex = 7;
            this.btn_newSave.Text = "Save New Company";
            this.btn_newSave.UseVisualStyleBackColor = true;
            this.btn_newSave.Visible = false;
            this.btn_newSave.Click += new System.EventHandler(this.btn_newSave_Click);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(986, 13);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(125, 30);
            this.btn_new.TabIndex = 797;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 796;
            this.label8.Text = "Company Name";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(151, 7);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(88, 15);
            this.label34.TabIndex = 795;
            this.label34.Text = "Company Code";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(12, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(139, 33);
            this.label31.TabIndex = 794;
            this.label31.Text = "Companies";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbo_companyStatus);
            this.panel1.Controls.Add(this.label56);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txt_companyWebsite);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.txt_companyEmail);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txt_companyFax);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cbo_companyCountry);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txt_companyPhone);
            this.panel1.Controls.Add(this.txt_companyAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.txt_companyName);
            this.panel1.Controls.Add(this.txt_companyCode);
            this.panel1.Location = new System.Drawing.Point(512, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 166);
            this.panel1.TabIndex = 2;
            // 
            // cbo_companyStatus
            // 
            this.cbo_companyStatus.BackColor = System.Drawing.Color.White;
            this.cbo_companyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_companyStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_companyStatus.FormattingEnabled = true;
            this.cbo_companyStatus.Location = new System.Drawing.Point(465, 22);
            this.cbo_companyStatus.Name = "cbo_companyStatus";
            this.cbo_companyStatus.Size = new System.Drawing.Size(93, 23);
            this.cbo_companyStatus.TabIndex = 2;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(462, 6);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(96, 15);
            this.label56.TabIndex = 722;
            this.label56.Text = "Customer Status";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(325, 135);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 15);
            this.label21.TabIndex = 720;
            this.label21.Text = "Website";
            // 
            // txt_companyWebsite
            // 
            this.txt_companyWebsite.BackColor = System.Drawing.Color.White;
            this.txt_companyWebsite.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_companyWebsite.Location = new System.Drawing.Point(383, 132);
            this.txt_companyWebsite.MaxLength = 50;
            this.txt_companyWebsite.Name = "txt_companyWebsite";
            this.txt_companyWebsite.Size = new System.Drawing.Size(175, 21);
            this.txt_companyWebsite.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(339, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 15);
            this.label23.TabIndex = 718;
            this.label23.Text = "Email";
            // 
            // txt_companyEmail
            // 
            this.txt_companyEmail.BackColor = System.Drawing.Color.White;
            this.txt_companyEmail.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_companyEmail.Location = new System.Drawing.Point(383, 105);
            this.txt_companyEmail.MaxLength = 50;
            this.txt_companyEmail.Name = "txt_companyEmail";
            this.txt_companyEmail.Size = new System.Drawing.Size(175, 21);
            this.txt_companyEmail.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(351, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 15);
            this.label16.TabIndex = 716;
            this.label16.Text = "Fax";
            // 
            // txt_companyFax
            // 
            this.txt_companyFax.BackColor = System.Drawing.Color.White;
            this.txt_companyFax.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_companyFax.Location = new System.Drawing.Point(383, 78);
            this.txt_companyFax.MaxLength = 50;
            this.txt_companyFax.Name = "txt_companyFax";
            this.txt_companyFax.Size = new System.Drawing.Size(175, 21);
            this.txt_companyFax.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 714;
            this.label15.Text = "Address";
            // 
            // cbo_companyCountry
            // 
            this.cbo_companyCountry.BackColor = System.Drawing.Color.White;
            this.cbo_companyCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_companyCountry.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_companyCountry.FormattingEnabled = true;
            this.cbo_companyCountry.Location = new System.Drawing.Point(65, 132);
            this.cbo_companyCountry.Name = "cbo_companyCountry";
            this.cbo_companyCountry.Size = new System.Drawing.Size(145, 23);
            this.cbo_companyCountry.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 713;
            this.label11.Text = "Country";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(336, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 15);
            this.label20.TabIndex = 709;
            this.label20.Text = "Phone";
            // 
            // txt_companyPhone
            // 
            this.txt_companyPhone.BackColor = System.Drawing.Color.White;
            this.txt_companyPhone.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_companyPhone.Location = new System.Drawing.Point(383, 51);
            this.txt_companyPhone.MaxLength = 50;
            this.txt_companyPhone.Name = "txt_companyPhone";
            this.txt_companyPhone.Size = new System.Drawing.Size(175, 21);
            this.txt_companyPhone.TabIndex = 5;
            // 
            // txt_companyAddress
            // 
            this.txt_companyAddress.BackColor = System.Drawing.Color.White;
            this.txt_companyAddress.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_companyAddress.Location = new System.Drawing.Point(65, 51);
            this.txt_companyAddress.MaxLength = 300;
            this.txt_companyAddress.Multiline = true;
            this.txt_companyAddress.Name = "txt_companyAddress";
            this.txt_companyAddress.Size = new System.Drawing.Size(250, 75);
            this.txt_companyAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(7, 6);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 15);
            this.label32.TabIndex = 2;
            this.label32.Text = "Company Code";
            // 
            // txt_companyName
            // 
            this.txt_companyName.BackColor = System.Drawing.Color.White;
            this.txt_companyName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_companyName.Location = new System.Drawing.Point(115, 24);
            this.txt_companyName.MaxLength = 100;
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(344, 21);
            this.txt_companyName.TabIndex = 1;
            // 
            // txt_companyCode
            // 
            this.txt_companyCode.BackColor = System.Drawing.Color.White;
            this.txt_companyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_companyCode.Enabled = false;
            this.txt_companyCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_companyCode.Location = new System.Drawing.Point(9, 24);
            this.txt_companyCode.MaxLength = 3;
            this.txt_companyCode.Name = "txt_companyCode";
            this.txt_companyCode.Size = new System.Drawing.Size(100, 21);
            this.txt_companyCode.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1117, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 30);
            this.btn_save.TabIndex = 792;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(517, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 15);
            this.label22.TabIndex = 802;
            this.label22.Text = "Contact Information";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(892, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 15);
            this.label10.TabIndex = 804;
            this.label10.Text = "Company Identification";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txt_FEIN);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txt_SSN);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(886, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 114);
            this.panel3.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(7, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 15);
            this.label18.TabIndex = 792;
            this.label18.Text = "no FEIN is entered)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(164, 15);
            this.label17.TabIndex = 791;
            this.label17.Text = "(FEIN is required for Payroll)";
            // 
            // txt_FEIN
            // 
            this.txt_FEIN.BackColor = System.Drawing.Color.White;
            this.txt_FEIN.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_FEIN.Location = new System.Drawing.Point(211, 19);
            this.txt_FEIN.MaxLength = 50;
            this.txt_FEIN.Name = "txt_FEIN";
            this.txt_FEIN.Size = new System.Drawing.Size(135, 21);
            this.txt_FEIN.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 15);
            this.label14.TabIndex = 759;
            this.label14.Text = "Federal Employer Identification No.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 15);
            this.label12.TabIndex = 790;
            this.label12.Text = "(SSN is used on 1099\'s if";
            // 
            // txt_SSN
            // 
            this.txt_SSN.BackColor = System.Drawing.Color.White;
            this.txt_SSN.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SSN.Location = new System.Drawing.Point(211, 70);
            this.txt_SSN.MaxLength = 100;
            this.txt_SSN.Name = "txt_SSN";
            this.txt_SSN.Size = new System.Drawing.Size(135, 21);
            this.txt_SSN.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 15);
            this.label13.TabIndex = 788;
            this.label13.Text = "Social Security Number";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(517, 391);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 15);
            this.label25.TabIndex = 806;
            this.label25.Text = "Report Information";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbo_incomeTaxFormUsed);
            this.panel4.Controls.Add(this.cbo_taxYear);
            this.panel4.Controls.Add(this.cbo_fiscalYear);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.label30);
            this.panel4.Controls.Add(this.label33);
            this.panel4.Location = new System.Drawing.Point(511, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 96);
            this.panel4.TabIndex = 4;
            // 
            // cbo_incomeTaxFormUsed
            // 
            this.cbo_incomeTaxFormUsed.BackColor = System.Drawing.Color.White;
            this.cbo_incomeTaxFormUsed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_incomeTaxFormUsed.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_incomeTaxFormUsed.FormattingEnabled = true;
            this.cbo_incomeTaxFormUsed.Location = new System.Drawing.Point(143, 61);
            this.cbo_incomeTaxFormUsed.Name = "cbo_incomeTaxFormUsed";
            this.cbo_incomeTaxFormUsed.Size = new System.Drawing.Size(215, 23);
            this.cbo_incomeTaxFormUsed.TabIndex = 2;
            // 
            // cbo_taxYear
            // 
            this.cbo_taxYear.BackColor = System.Drawing.Color.White;
            this.cbo_taxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_taxYear.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_taxYear.FormattingEnabled = true;
            this.cbo_taxYear.Location = new System.Drawing.Point(262, 32);
            this.cbo_taxYear.Name = "cbo_taxYear";
            this.cbo_taxYear.Size = new System.Drawing.Size(96, 23);
            this.cbo_taxYear.TabIndex = 1;
            // 
            // cbo_fiscalYear
            // 
            this.cbo_fiscalYear.BackColor = System.Drawing.Color.White;
            this.cbo_fiscalYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_fiscalYear.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_fiscalYear.FormattingEnabled = true;
            this.cbo_fiscalYear.Location = new System.Drawing.Point(108, 32);
            this.cbo_fiscalYear.Name = "cbo_fiscalYear";
            this.cbo_fiscalYear.Size = new System.Drawing.Size(96, 23);
            this.cbo_fiscalYear.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(36, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 15);
            this.label28.TabIndex = 791;
            this.label28.Text = "Fiscal Year";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(7, 13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(115, 15);
            this.label29.TabIndex = 759;
            this.label29.Text = "First month in your:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(8, 67);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(129, 15);
            this.label30.TabIndex = 790;
            this.label30.Text = "Income Tax Form Used";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(210, 35);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(51, 15);
            this.label33.TabIndex = 788;
            this.label33.Text = "Tax Year";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(892, 342);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(164, 15);
            this.label35.TabIndex = 808;
            this.label35.Text = "Payroll Tax Form Information";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txt_payrollPhone);
            this.panel5.Controls.Add(this.label37);
            this.panel5.Controls.Add(this.txt_payrollContact);
            this.panel5.Controls.Add(this.label38);
            this.panel5.Controls.Add(this.label39);
            this.panel5.Controls.Add(this.txt_payrollTitle);
            this.panel5.Controls.Add(this.label40);
            this.panel5.Location = new System.Drawing.Point(886, 349);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(356, 117);
            this.panel5.TabIndex = 6;
            // 
            // txt_payrollPhone
            // 
            this.txt_payrollPhone.BackColor = System.Drawing.Color.White;
            this.txt_payrollPhone.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_payrollPhone.Location = new System.Drawing.Point(62, 85);
            this.txt_payrollPhone.MaxLength = 100;
            this.txt_payrollPhone.Name = "txt_payrollPhone";
            this.txt_payrollPhone.Size = new System.Drawing.Size(284, 21);
            this.txt_payrollPhone.TabIndex = 2;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(7, 37);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(323, 15);
            this.label37.TabIndex = 791;
            this.label37.Text = "(Name of person preparing and signing payroll tax forms)";
            // 
            // txt_payrollContact
            // 
            this.txt_payrollContact.BackColor = System.Drawing.Color.White;
            this.txt_payrollContact.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_payrollContact.Location = new System.Drawing.Point(62, 13);
            this.txt_payrollContact.MaxLength = 50;
            this.txt_payrollContact.Name = "txt_payrollContact";
            this.txt_payrollContact.Size = new System.Drawing.Size(284, 21);
            this.txt_payrollContact.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(7, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(49, 15);
            this.label38.TabIndex = 759;
            this.label38.Text = "Contact";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(7, 85);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(41, 15);
            this.label39.TabIndex = 790;
            this.label39.Text = "Phone";
            // 
            // txt_payrollTitle
            // 
            this.txt_payrollTitle.BackColor = System.Drawing.Color.White;
            this.txt_payrollTitle.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_payrollTitle.Location = new System.Drawing.Point(62, 58);
            this.txt_payrollTitle.MaxLength = 100;
            this.txt_payrollTitle.Name = "txt_payrollTitle";
            this.txt_payrollTitle.Size = new System.Drawing.Size(284, 21);
            this.txt_payrollTitle.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(7, 61);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(31, 15);
            this.label40.TabIndex = 788;
            this.label40.Text = "Title";
            // 
            // cbx_inactive
            // 
            this.cbx_inactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_inactive.AutoSize = true;
            this.cbx_inactive.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_inactive.Location = new System.Drawing.Point(511, 19);
            this.cbx_inactive.Name = "cbx_inactive";
            this.cbx_inactive.Size = new System.Drawing.Size(177, 19);
            this.cbx_inactive.TabIndex = 793;
            this.cbx_inactive.Text = "Include Inactive Companies";
            this.cbx_inactive.UseVisualStyleBackColor = true;
            this.cbx_inactive.CheckedChanged += new System.EventHandler(this.cbx_inactive_CheckedChanged);
            // 
            // txt_searchCompanyName
            // 
            this.txt_searchCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchCompanyName.BackColor = System.Drawing.Color.White;
            this.txt_searchCompanyName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchCompanyName.Location = new System.Drawing.Point(245, 24);
            this.txt_searchCompanyName.MaxLength = 100;
            this.txt_searchCompanyName.Name = "txt_searchCompanyName";
            this.txt_searchCompanyName.Size = new System.Drawing.Size(260, 21);
            this.txt_searchCompanyName.TabIndex = 1;
            this.txt_searchCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // txt_searchCompanyCode
            // 
            this.txt_searchCompanyCode.BackColor = System.Drawing.Color.White;
            this.txt_searchCompanyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_searchCompanyCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchCompanyCode.Location = new System.Drawing.Point(153, 25);
            this.txt_searchCompanyCode.MaxLength = 3;
            this.txt_searchCompanyCode.Name = "txt_searchCompanyCode";
            this.txt_searchCompanyCode.Size = new System.Drawing.Size(86, 21);
            this.txt_searchCompanyCode.TabIndex = 0;
            this.txt_searchCompanyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // grid_company
            // 
            this.grid_company.AllowUserToAddRows = false;
            this.grid_company.AllowUserToDeleteRows = false;
            this.grid_company.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_company.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_company.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_company.BackgroundColor = System.Drawing.Color.White;
            this.grid_company.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_company.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_company.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_company.EnableHeadersVisualStyles = false;
            this.grid_company.GridColor = System.Drawing.Color.LightGray;
            this.grid_company.Location = new System.Drawing.Point(12, 49);
            this.grid_company.MultiSelect = false;
            this.grid_company.Name = "grid_company";
            this.grid_company.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_company.RowHeadersVisible = false;
            this.grid_company.RowTemplate.Height = 19;
            this.grid_company.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_company.Size = new System.Drawing.Size(493, 692);
            this.grid_company.StandardTab = true;
            this.grid_company.TabIndex = 791;
            this.grid_company.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_company_CellEnter);
            // 
            // CompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 749);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_newSave);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_searchCompanyName);
            this.Controls.Add(this.cbx_inactive);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txt_searchCompanyCode);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.grid_company);
            this.MinimumSize = new System.Drawing.Size(1270, 0);
            this.Name = "CompanyList";
            this.Text = "CompanyList";
            this.Load += new System.EventHandler(this.CompanyList_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_company)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_newSave;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label8;
        private CustomTextBox txt_searchCompanyName;
        private System.Windows.Forms.Label label34;
        private CustomTextBox txt_searchCompanyCode;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private CustomTextBox txt_companyPhone;
        private CustomTextBox txt_companyAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label32;
        private CustomTextBox txt_companyName;
        private CustomTextBox txt_companyCode;
        private System.Windows.Forms.Button btn_save;
        private CustomGrid grid_company;
        private CustomTextBox txt_legalAddress2;
        private Tools.CustomComboBox cbo_companyCountry;
        private System.Windows.Forms.Label label11;
        private Tools.CustomComboBox cbo_legalCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private CustomTextBox txt_legalCity;
        private CustomTextBox txt_legalState;
        private CustomTextBox txt_legalZIP;
        private CustomTextBox txt_legalAddress1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label21;
        private CustomTextBox txt_companyWebsite;
        private System.Windows.Forms.Label label23;
        private CustomTextBox txt_companyEmail;
        private System.Windows.Forms.Label label16;
        private CustomTextBox txt_companyFax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private CustomTextBox txt_FEIN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private CustomTextBox txt_SSN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel4;
        private Tools.CustomComboBox cbo_taxYear;
        private Tools.CustomComboBox cbo_fiscalYear;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel5;
        private CustomTextBox txt_payrollPhone;
        private System.Windows.Forms.Label label37;
        private CustomTextBox txt_payrollContact;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private CustomTextBox txt_payrollTitle;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.CheckBox cbx_inactive;
        private Tools.CustomComboBox cbo_companyStatus;
        private System.Windows.Forms.Label label56;
        private Tools.CustomComboBox cbo_incomeTaxFormUsed;
        private CustomTextBox txt_legalName;
        private System.Windows.Forms.Label label3;
    }
}