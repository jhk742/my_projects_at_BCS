namespace OBCS.Sales
{
    partial class Invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_todate = new System.Windows.Forms.Label();
            this.lbl_fromdate = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbo_site = new OBCS.Tools.CustomComboBox();
            this.cbo_gl = new OBCS.Tools.CustomComboBox();
            this.txt_amount = new OBCS.CustomTextBox();
            this.cbo_company = new OBCS.Tools.CustomComboBox();
            this.cbo_customerID = new OBCS.Tools.CustomComboBox();
            this.cbo_invoiceType = new OBCS.Tools.CustomComboBox();
            this.txt_memo = new OBCS.CustomTextBox();
            this.grid_ORDER = new OBCS.CustomGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_searchCustomerID = new OBCS.Tools.CustomComboBox();
            this.cbo_SalesRep = new OBCS.Tools.CustomComboBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.customLabel9 = new OBCS.Tools.CustomLabel();
            this.customLabel10 = new OBCS.Tools.CustomLabel();
            this.customLabel11 = new OBCS.Tools.CustomLabel();
            this.customLabel12 = new OBCS.Tools.CustomLabel();
            this.customLabel13 = new OBCS.Tools.CustomLabel();
            this.customLabel14 = new OBCS.Tools.CustomLabel();
            this.customLabel15 = new OBCS.Tools.CustomLabel();
            this.customLabel16 = new OBCS.Tools.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDER)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(184, 28);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(100, 26);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(51, 28);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(100, 26);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // lbl_todate
            // 
            this.lbl_todate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_todate.AutoSize = true;
            this.lbl_todate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_todate.Location = new System.Drawing.Point(158, 32);
            this.lbl_todate.Name = "lbl_todate";
            this.lbl_todate.Size = new System.Drawing.Size(22, 18);
            this.lbl_todate.TabIndex = 326;
            this.lbl_todate.Text = "To";
            // 
            // lbl_fromdate
            // 
            this.lbl_fromdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fromdate.AutoSize = true;
            this.lbl_fromdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fromdate.Location = new System.Drawing.Point(9, 32);
            this.lbl_fromdate.Name = "lbl_fromdate";
            this.lbl_fromdate.Size = new System.Drawing.Size(40, 18);
            this.lbl_fromdate.TabIndex = 325;
            this.lbl_fromdate.Text = "From";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(12, 89);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(271, 41);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Search";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(12, 618);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(271, 37);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 464);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cbo_site
            // 
            this.cbo_site.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_site.BackColor = System.Drawing.Color.White;
            this.cbo_site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_site.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_site.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_site.FormattingEnabled = true;
            this.cbo_site.Location = new System.Drawing.Point(122, 377);
            this.cbo_site.Name = "cbo_site";
            this.cbo_site.Size = new System.Drawing.Size(161, 23);
            this.cbo_site.TabIndex = 0;
            // 
            // cbo_gl
            // 
            this.cbo_gl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_gl.BackColor = System.Drawing.Color.White;
            this.cbo_gl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_gl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_gl.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_gl.FormattingEnabled = true;
            this.cbo_gl.Location = new System.Drawing.Point(122, 577);
            this.cbo_gl.Name = "cbo_gl";
            this.cbo_gl.Size = new System.Drawing.Size(161, 23);
            this.cbo_gl.TabIndex = 7;
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_amount.Location = new System.Drawing.Point(122, 548);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(161, 21);
            this.txt_amount.TabIndex = 6;
            // 
            // cbo_company
            // 
            this.cbo_company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_company.BackColor = System.Drawing.Color.White;
            this.cbo_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_company.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_company.FormattingEnabled = true;
            this.cbo_company.Location = new System.Drawing.Point(122, 406);
            this.cbo_company.Name = "cbo_company";
            this.cbo_company.Size = new System.Drawing.Size(161, 23);
            this.cbo_company.TabIndex = 1;
            // 
            // cbo_customerID
            // 
            this.cbo_customerID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_customerID.BackColor = System.Drawing.Color.White;
            this.cbo_customerID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_customerID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_customerID.FormattingEnabled = true;
            this.cbo_customerID.Location = new System.Drawing.Point(122, 492);
            this.cbo_customerID.Name = "cbo_customerID";
            this.cbo_customerID.Size = new System.Drawing.Size(161, 23);
            this.cbo_customerID.TabIndex = 4;
            // 
            // cbo_invoiceType
            // 
            this.cbo_invoiceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_invoiceType.BackColor = System.Drawing.Color.White;
            this.cbo_invoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_invoiceType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_invoiceType.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_invoiceType.FormattingEnabled = true;
            this.cbo_invoiceType.Location = new System.Drawing.Point(122, 435);
            this.cbo_invoiceType.Name = "cbo_invoiceType";
            this.cbo_invoiceType.Size = new System.Drawing.Size(161, 23);
            this.cbo_invoiceType.TabIndex = 2;
            // 
            // txt_memo
            // 
            this.txt_memo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_memo.BackColor = System.Drawing.Color.White;
            this.txt_memo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_memo.Location = new System.Drawing.Point(122, 521);
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(161, 21);
            this.txt_memo.TabIndex = 5;
            // 
            // grid_ORDER
            // 
            this.grid_ORDER.AllowUserToAddRows = false;
            this.grid_ORDER.AllowUserToDeleteRows = false;
            this.grid_ORDER.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_ORDER.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_ORDER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_ORDER.BackgroundColor = System.Drawing.Color.White;
            this.grid_ORDER.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ORDER.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_ORDER.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_ORDER.EnableHeadersVisualStyles = false;
            this.grid_ORDER.GridColor = System.Drawing.Color.LightGray;
            this.grid_ORDER.Location = new System.Drawing.Point(13, 12);
            this.grid_ORDER.MultiSelect = false;
            this.grid_ORDER.Name = "grid_ORDER";
            this.grid_ORDER.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ORDER.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_ORDER.RowHeadersVisible = false;
            this.grid_ORDER.RowTemplate.Height = 19;
            this.grid_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ORDER.Size = new System.Drawing.Size(775, 668);
            this.grid_ORDER.StandardTab = true;
            this.grid_ORDER.TabIndex = 4;
            this.grid_ORDER.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ORDER_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbo_searchCustomerID);
            this.panel1.Controls.Add(this.cbo_SalesRep);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.cbo_site);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.lbl_todate);
            this.panel1.Controls.Add(this.customLabel9);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Controls.Add(this.cbo_gl);
            this.panel1.Controls.Add(this.lbl_fromdate);
            this.panel1.Controls.Add(this.customLabel10);
            this.panel1.Controls.Add(this.customLabel11);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.customLabel12);
            this.panel1.Controls.Add(this.customLabel13);
            this.panel1.Controls.Add(this.customLabel14);
            this.panel1.Controls.Add(this.customLabel15);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.customLabel16);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txt_memo);
            this.panel1.Controls.Add(this.cbo_company);
            this.panel1.Controls.Add(this.cbo_invoiceType);
            this.panel1.Controls.Add(this.cbo_customerID);
            this.panel1.Location = new System.Drawing.Point(794, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 668);
            this.panel1.TabIndex = 328;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 412;
            this.label2.Text = "Misc. AR Creation";
            // 
            // cbo_searchCustomerID
            // 
            this.cbo_searchCustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_searchCustomerID.BackColor = System.Drawing.Color.White;
            this.cbo_searchCustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_searchCustomerID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_searchCustomerID.FormattingEnabled = true;
            this.cbo_searchCustomerID.Location = new System.Drawing.Point(100, 60);
            this.cbo_searchCustomerID.Name = "cbo_searchCustomerID";
            this.cbo_searchCustomerID.Size = new System.Drawing.Size(184, 23);
            this.cbo_searchCustomerID.TabIndex = 411;
            // 
            // cbo_SalesRep
            // 
            this.cbo_SalesRep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_SalesRep.BackColor = System.Drawing.Color.White;
            this.cbo_SalesRep.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_SalesRep.FormattingEnabled = true;
            this.cbo_SalesRep.Location = new System.Drawing.Point(128, 287);
            this.cbo_SalesRep.Name = "cbo_SalesRep";
            this.cbo_SalesRep.Size = new System.Drawing.Size(51, 23);
            this.cbo_SalesRep.TabIndex = 410;
            this.cbo_SalesRep.Visible = false;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(10, 61);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(84, 18);
            this.customLabel2.TabIndex = 408;
            this.customLabel2.Text = "Customer ID";
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(47, 292);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(75, 18);
            this.customLabel1.TabIndex = 407;
            this.customLabel1.Text = "Sales Code";
            this.customLabel1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 401;
            this.label1.Text = "Invoice Date";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(13, 136);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(271, 39);
            this.btn_close.TabIndex = 400;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // customLabel9
            // 
            this.customLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.Location = new System.Drawing.Point(9, 379);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(27, 15);
            this.customLabel9.TabIndex = 381;
            this.customLabel9.Text = "Site";
            // 
            // customLabel10
            // 
            this.customLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel10.AutoSize = true;
            this.customLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel10.Location = new System.Drawing.Point(9, 579);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.Size = new System.Drawing.Size(25, 15);
            this.customLabel10.TabIndex = 399;
            this.customLabel10.Text = "G/L";
            // 
            // customLabel11
            // 
            this.customLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel11.AutoSize = true;
            this.customLabel11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel11.Location = new System.Drawing.Point(9, 410);
            this.customLabel11.Name = "customLabel11";
            this.customLabel11.Size = new System.Drawing.Size(58, 15);
            this.customLabel11.TabIndex = 382;
            this.customLabel11.Text = "Company";
            // 
            // customLabel12
            // 
            this.customLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel12.AutoSize = true;
            this.customLabel12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel12.Location = new System.Drawing.Point(9, 554);
            this.customLabel12.Name = "customLabel12";
            this.customLabel12.Size = new System.Drawing.Size(49, 15);
            this.customLabel12.TabIndex = 398;
            this.customLabel12.Text = "Amount";
            // 
            // customLabel13
            // 
            this.customLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel13.AutoSize = true;
            this.customLabel13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel13.Location = new System.Drawing.Point(9, 439);
            this.customLabel13.Name = "customLabel13";
            this.customLabel13.Size = new System.Drawing.Size(73, 15);
            this.customLabel13.TabIndex = 383;
            this.customLabel13.Text = "Invoice type";
            // 
            // customLabel14
            // 
            this.customLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel14.AutoSize = true;
            this.customLabel14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel14.Location = new System.Drawing.Point(9, 469);
            this.customLabel14.Name = "customLabel14";
            this.customLabel14.Size = new System.Drawing.Size(94, 15);
            this.customLabel14.TabIndex = 384;
            this.customLabel14.Text = "Accounting date";
            // 
            // customLabel15
            // 
            this.customLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel15.AutoSize = true;
            this.customLabel15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel15.Location = new System.Drawing.Point(9, 496);
            this.customLabel15.Name = "customLabel15";
            this.customLabel15.Size = new System.Drawing.Size(59, 15);
            this.customLabel15.TabIndex = 394;
            this.customLabel15.Text = "Customer";
            // 
            // customLabel16
            // 
            this.customLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel16.Location = new System.Drawing.Point(9, 523);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(41, 15);
            this.customLabel16.TabIndex = 396;
            this.customLabel16.Text = "Memo";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_ORDER);
            this.MinimumSize = new System.Drawing.Size(1115, 731);
            this.Name = "Invoice";
            this.Text = "Misc. AR Creation";
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDER)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGrid grid_ORDER;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lbl_todate;
        private System.Windows.Forms.Label lbl_fromdate;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_create;
        private Tools.CustomComboBox cbo_invoiceType;
        private Tools.CustomComboBox cbo_site;
        private Tools.CustomComboBox cbo_company;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Tools.CustomComboBox cbo_customerID;
        private CustomTextBox txt_memo;
        private CustomTextBox txt_amount;
        private Tools.CustomComboBox cbo_gl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private Tools.CustomLabel customLabel9;
        private Tools.CustomLabel customLabel10;
        private Tools.CustomLabel customLabel11;
        private Tools.CustomLabel customLabel12;
        private Tools.CustomLabel customLabel13;
        private Tools.CustomLabel customLabel14;
        private Tools.CustomLabel customLabel15;
        private Tools.CustomLabel customLabel16;
        private System.Windows.Forms.Label label1;
        private Tools.CustomComboBox cbo_SalesRep;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomComboBox cbo_searchCustomerID;
        private System.Windows.Forms.Label label2;
    }
}