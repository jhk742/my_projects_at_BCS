namespace OBCS.Sales
{
    partial class Deposit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_total = new OBCS.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnslipPrint = new System.Windows.Forms.Button();
            this.txt_paymentType = new OBCS.CustomTextBox();
            this.txt_bank = new OBCS.CustomTextBox();
            this.txt_site = new OBCS.CustomTextBox();
            this.txt_company = new OBCS.CustomTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbo_paymentType = new OBCS.Tools.CustomComboBox();
            this.cbo_bank = new OBCS.Tools.CustomComboBox();
            this.cbo_site = new OBCS.Tools.CustomComboBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.cbo_company = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.grid_remittances = new OBCS.CustomGrid();
            this.grid_remittancesDetail = new OBCS.CustomGrid();
            this.grid_payments = new OBCS.CustomGrid();
            this.btn_ShowAll = new System.Windows.Forms.Button();
            this.DatetimePicker_Createtime = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_remittances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_remittancesDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_payments)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(381, 14);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(116, 51);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(381, 68);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(116, 59);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "Create Deposit Slip";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.customLabel5);
            this.panel2.Controls.Add(this.txt_total);
            this.panel2.Location = new System.Drawing.Point(690, 609);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 37);
            this.panel2.TabIndex = 385;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(356, 11);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(85, 15);
            this.customLabel5.TabIndex = 383;
            this.customLabel5.Text = "Total Amount :";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.BackColor = System.Drawing.Color.White;
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_total.Location = new System.Drawing.Point(449, 8);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(171, 21);
            this.txt_total.TabIndex = 381;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btnslipPrint);
            this.panel1.Controls.Add(this.txt_paymentType);
            this.panel1.Controls.Add(this.txt_bank);
            this.panel1.Controls.Add(this.txt_site);
            this.panel1.Controls.Add(this.txt_company);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.cbo_paymentType);
            this.panel1.Controls.Add(this.cbo_bank);
            this.panel1.Controls.Add(this.cbo_site);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.customLabel4);
            this.panel1.Controls.Add(this.cbo_company);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Location = new System.Drawing.Point(690, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 137);
            this.panel1.TabIndex = 386;
            // 
            // btnslipPrint
            // 
            this.btnslipPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnslipPrint.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnslipPrint.FlatAppearance.BorderSize = 0;
            this.btnslipPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnslipPrint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnslipPrint.ForeColor = System.Drawing.Color.White;
            this.btnslipPrint.Location = new System.Drawing.Point(503, 14);
            this.btnslipPrint.Name = "btnslipPrint";
            this.btnslipPrint.Size = new System.Drawing.Size(121, 51);
            this.btnslipPrint.TabIndex = 387;
            this.btnslipPrint.Text = "Export Excel";
            this.btnslipPrint.UseVisualStyleBackColor = false;
            this.btnslipPrint.Click += new System.EventHandler(this.btnslipPrint_Click);
            // 
            // txt_paymentType
            // 
            this.txt_paymentType.BackColor = System.Drawing.Color.White;
            this.txt_paymentType.Enabled = false;
            this.txt_paymentType.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_paymentType.Location = new System.Drawing.Point(299, 106);
            this.txt_paymentType.Name = "txt_paymentType";
            this.txt_paymentType.Size = new System.Drawing.Size(63, 21);
            this.txt_paymentType.TabIndex = 386;
            // 
            // txt_bank
            // 
            this.txt_bank.BackColor = System.Drawing.Color.White;
            this.txt_bank.Enabled = false;
            this.txt_bank.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_bank.Location = new System.Drawing.Point(230, 106);
            this.txt_bank.Name = "txt_bank";
            this.txt_bank.Size = new System.Drawing.Size(63, 21);
            this.txt_bank.TabIndex = 385;
            // 
            // txt_site
            // 
            this.txt_site.BackColor = System.Drawing.Color.White;
            this.txt_site.Enabled = false;
            this.txt_site.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_site.Location = new System.Drawing.Point(161, 106);
            this.txt_site.Name = "txt_site";
            this.txt_site.Size = new System.Drawing.Size(63, 21);
            this.txt_site.TabIndex = 384;
            // 
            // txt_company
            // 
            this.txt_company.BackColor = System.Drawing.Color.White;
            this.txt_company.Enabled = false;
            this.txt_company.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_company.Location = new System.Drawing.Point(161, 98);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(63, 21);
            this.txt_company.TabIndex = 383;
            this.txt_company.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(503, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 59);
            this.button1.TabIndex = 382;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbo_paymentType
            // 
            this.cbo_paymentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_paymentType.BackColor = System.Drawing.Color.White;
            this.cbo_paymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_paymentType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_paymentType.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_paymentType.FormattingEnabled = true;
            this.cbo_paymentType.Location = new System.Drawing.Point(201, 69);
            this.cbo_paymentType.Name = "cbo_paymentType";
            this.cbo_paymentType.Size = new System.Drawing.Size(161, 23);
            this.cbo_paymentType.TabIndex = 3;
            // 
            // cbo_bank
            // 
            this.cbo_bank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_bank.BackColor = System.Drawing.Color.White;
            this.cbo_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_bank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_bank.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_bank.FormattingEnabled = true;
            this.cbo_bank.Location = new System.Drawing.Point(8, 69);
            this.cbo_bank.Name = "cbo_bank";
            this.cbo_bank.Size = new System.Drawing.Size(161, 23);
            this.cbo_bank.TabIndex = 2;
            // 
            // cbo_site
            // 
            this.cbo_site.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_site.BackColor = System.Drawing.Color.White;
            this.cbo_site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_site.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_site.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_site.FormattingEnabled = true;
            this.cbo_site.Location = new System.Drawing.Point(201, 24);
            this.cbo_site.Name = "cbo_site";
            this.cbo_site.Size = new System.Drawing.Size(161, 23);
            this.cbo_site.TabIndex = 1;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(198, 5);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(27, 15);
            this.customLabel4.TabIndex = 370;
            this.customLabel4.Text = "Site";
            // 
            // cbo_company
            // 
            this.cbo_company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_company.BackColor = System.Drawing.Color.White;
            this.cbo_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_company.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_company.FormattingEnabled = true;
            this.cbo_company.Location = new System.Drawing.Point(8, 24);
            this.cbo_company.Name = "cbo_company";
            this.cbo_company.Size = new System.Drawing.Size(161, 23);
            this.cbo_company.TabIndex = 0;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(5, 5);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(58, 15);
            this.customLabel1.TabIndex = 371;
            this.customLabel1.Text = "Company";
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(198, 50);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(80, 15);
            this.customLabel3.TabIndex = 374;
            this.customLabel3.Text = "Payment type";
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(5, 50);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(34, 15);
            this.customLabel2.TabIndex = 372;
            this.customLabel2.Text = "Bank";
            // 
            // grid_remittances
            // 
            this.grid_remittances.AllowUserToAddRows = false;
            this.grid_remittances.AllowUserToDeleteRows = false;
            this.grid_remittances.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_remittances.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_remittances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_remittances.BackgroundColor = System.Drawing.Color.White;
            this.grid_remittances.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_remittances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_remittances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_remittances.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_remittances.EnableHeadersVisualStyles = false;
            this.grid_remittances.GridColor = System.Drawing.Color.LightGray;
            this.grid_remittances.Location = new System.Drawing.Point(12, 45);
            this.grid_remittances.MultiSelect = false;
            this.grid_remittances.Name = "grid_remittances";
            this.grid_remittances.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_remittances.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_remittances.RowHeadersVisible = false;
            this.grid_remittances.RowTemplate.Height = 19;
            this.grid_remittances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_remittances.Size = new System.Drawing.Size(672, 868);
            this.grid_remittances.StandardTab = true;
            this.grid_remittances.TabIndex = 2;
            this.grid_remittances.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_remittances_CellClick);
            // 
            // grid_remittancesDetail
            // 
            this.grid_remittancesDetail.AllowUserToAddRows = false;
            this.grid_remittancesDetail.AllowUserToDeleteRows = false;
            this.grid_remittancesDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_remittancesDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_remittancesDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_remittancesDetail.BackgroundColor = System.Drawing.Color.White;
            this.grid_remittancesDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_remittancesDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_remittancesDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_remittancesDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_remittancesDetail.EnableHeadersVisualStyles = false;
            this.grid_remittancesDetail.GridColor = System.Drawing.Color.LightGray;
            this.grid_remittancesDetail.Location = new System.Drawing.Point(690, 652);
            this.grid_remittancesDetail.MultiSelect = false;
            this.grid_remittancesDetail.Name = "grid_remittancesDetail";
            this.grid_remittancesDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_remittancesDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_remittancesDetail.RowHeadersVisible = false;
            this.grid_remittancesDetail.RowTemplate.Height = 19;
            this.grid_remittancesDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_remittancesDetail.Size = new System.Drawing.Size(631, 261);
            this.grid_remittancesDetail.StandardTab = true;
            this.grid_remittancesDetail.TabIndex = 1;
            // 
            // grid_payments
            // 
            this.grid_payments.AllowUserToAddRows = false;
            this.grid_payments.AllowUserToDeleteRows = false;
            this.grid_payments.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_payments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_payments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_payments.BackgroundColor = System.Drawing.Color.White;
            this.grid_payments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_payments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_payments.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid_payments.EnableHeadersVisualStyles = false;
            this.grid_payments.GridColor = System.Drawing.Color.LightGray;
            this.grid_payments.Location = new System.Drawing.Point(690, 155);
            this.grid_payments.MultiSelect = false;
            this.grid_payments.Name = "grid_payments";
            this.grid_payments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_payments.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid_payments.RowHeadersVisible = false;
            this.grid_payments.RowTemplate.Height = 19;
            this.grid_payments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_payments.Size = new System.Drawing.Size(631, 448);
            this.grid_payments.StandardTab = true;
            this.grid_payments.TabIndex = 0;
            // 
            // btn_ShowAll
            // 
            this.btn_ShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_ShowAll.FlatAppearance.BorderSize = 0;
            this.btn_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAll.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAll.ForeColor = System.Drawing.Color.White;
            this.btn_ShowAll.Location = new System.Drawing.Point(12, 12);
            this.btn_ShowAll.Name = "btn_ShowAll";
            this.btn_ShowAll.Size = new System.Drawing.Size(116, 27);
            this.btn_ShowAll.TabIndex = 390;
            this.btn_ShowAll.Text = "Show All";
            this.btn_ShowAll.UseVisualStyleBackColor = false;
            this.btn_ShowAll.Click += new System.EventHandler(this.btn_ShowAll_Click);
            // 
            // DatetimePicker_Createtime
            // 
            this.DatetimePicker_Createtime.BackColor = System.Drawing.Color.White;
            this.DatetimePicker_Createtime.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DatetimePicker_Createtime.CustomFormat = " MM/dd/yyyy";
            this.DatetimePicker_Createtime.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DatetimePicker_Createtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatetimePicker_Createtime.Location = new System.Drawing.Point(597, 18);
            this.DatetimePicker_Createtime.Name = "DatetimePicker_Createtime";
            this.DatetimePicker_Createtime.Size = new System.Drawing.Size(87, 21);
            this.DatetimePicker_Createtime.TabIndex = 392;
            this.DatetimePicker_Createtime.ValueChanged += new System.EventHandler(this.DatetimePicker_Createtime_ValueChanged);
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(510, 19);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(81, 18);
            this.customLabel6.TabIndex = 391;
            this.customLabel6.Text = "Create Date";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 925);
            this.Controls.Add(this.DatetimePicker_Createtime);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.btn_ShowAll);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grid_remittances);
            this.Controls.Add(this.grid_remittancesDetail);
            this.Controls.Add(this.grid_payments);
            this.MinimumSize = new System.Drawing.Size(1206, 964);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_remittances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_remittancesDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_payments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_payments;
        private CustomGrid grid_remittancesDetail;
        private CustomGrid grid_remittances;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomComboBox cbo_company;
        private Tools.CustomComboBox cbo_site;
        private Tools.CustomComboBox cbo_bank;
        private Tools.CustomComboBox cbo_paymentType;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_create;
        private CustomTextBox txt_total;
        private System.Windows.Forms.Panel panel2;
        private Tools.CustomLabel customLabel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private CustomTextBox txt_paymentType;
        private CustomTextBox txt_bank;
        private CustomTextBox txt_site;
        private CustomTextBox txt_company;
        private System.Windows.Forms.Button btnslipPrint;
        private System.Windows.Forms.Button btn_ShowAll;
        private Purchase.CustomDateTimePicker DatetimePicker_Createtime;
        private Tools.CustomLabel customLabel6;
    }
}