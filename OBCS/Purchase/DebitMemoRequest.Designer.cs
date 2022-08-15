namespace OBCS.Purchase
{
    partial class DebitMemoRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_poNumber = new OBCS.CustomTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.cbo_dmReason = new OBCS.Tools.CustomComboBox();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.cbo_companyID = new OBCS.Tools.CustomComboBox();
            this.txt_companyName = new OBCS.CustomTextBox();
            this.customLabel22 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerTo = new OBCS.Purchase.CustomDateTimePicker();
            this.cbo_poNumber = new OBCS.Tools.CustomComboBox();
            this.txt_dmReasonDesc = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_memo = new OBCS.CustomTextBox();
            this.cbo_supplierID = new OBCS.Tools.CustomComboBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.customLabel15 = new OBCS.Tools.CustomLabel();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.customLabel16 = new OBCS.Tools.CustomLabel();
            this.txt_amount = new OBCS.CustomTextBox();
            this.btn_request = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbo_searchSupplierID = new OBCS.Tools.CustomComboBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.grid_debit = new OBCS.CustomGrid();
            this.grid_pending = new OBCS.CustomGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_debit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pending)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_poNumber);
            this.panel1.Controls.Add(this.customLabel6);
            this.panel1.Controls.Add(this.cbo_dmReason);
            this.panel1.Controls.Add(this.customLabel5);
            this.panel1.Controls.Add(this.cbo_companyID);
            this.panel1.Controls.Add(this.txt_companyName);
            this.panel1.Controls.Add(this.customLabel22);
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.cbo_poNumber);
            this.panel1.Controls.Add(this.txt_dmReasonDesc);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Controls.Add(this.txt_memo);
            this.panel1.Controls.Add(this.cbo_supplierID);
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.customLabel15);
            this.panel1.Controls.Add(this.customLabel4);
            this.panel1.Controls.Add(this.customLabel16);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Location = new System.Drawing.Point(817, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 238);
            this.panel1.TabIndex = 0;
            // 
            // txt_poNumber
            // 
            this.txt_poNumber.BackColor = System.Drawing.Color.White;
            this.txt_poNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_poNumber.Location = new System.Drawing.Point(192, 65);
            this.txt_poNumber.MaxLength = 6;
            this.txt_poNumber.Name = "txt_poNumber";
            this.txt_poNumber.Size = new System.Drawing.Size(58, 21);
            this.txt_poNumber.TabIndex = 3;
            this.txt_poNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_poNumber_KeyPress);
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(12, 68);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(174, 15);
            this.customLabel6.TabIndex = 759;
            this.customLabel6.Text = "Search Supplier by PO Number";
            // 
            // cbo_dmReason
            // 
            this.cbo_dmReason.BackColor = System.Drawing.Color.White;
            this.cbo_dmReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_dmReason.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_dmReason.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_dmReason.FormattingEnabled = true;
            this.cbo_dmReason.Location = new System.Drawing.Point(86, 177);
            this.cbo_dmReason.Name = "cbo_dmReason";
            this.cbo_dmReason.Size = new System.Drawing.Size(63, 23);
            this.cbo_dmReason.TabIndex = 7;
            this.cbo_dmReason.SelectedValueChanged += new System.EventHandler(this.cbo_dmReason_SelectedValueChanged);
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(48, 12);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(32, 15);
            this.customLabel5.TabIndex = 764;
            this.customLabel5.Text = "Date";
            // 
            // cbo_companyID
            // 
            this.cbo_companyID.BackColor = System.Drawing.Color.White;
            this.cbo_companyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_companyID.Enabled = false;
            this.cbo_companyID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_companyID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_companyID.FormattingEnabled = true;
            this.cbo_companyID.Location = new System.Drawing.Point(86, 36);
            this.cbo_companyID.Name = "cbo_companyID";
            this.cbo_companyID.Size = new System.Drawing.Size(57, 23);
            this.cbo_companyID.TabIndex = 1;
            this.cbo_companyID.SelectedValueChanged += new System.EventHandler(this.cbo_companyID_SelectedValueChanged);
            // 
            // txt_companyName
            // 
            this.txt_companyName.BackColor = System.Drawing.Color.White;
            this.txt_companyName.Enabled = false;
            this.txt_companyName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_companyName.Location = new System.Drawing.Point(149, 38);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(232, 21);
            this.txt_companyName.TabIndex = 2;
            // 
            // customLabel22
            // 
            this.customLabel22.AutoSize = true;
            this.customLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel22.Location = new System.Drawing.Point(22, 39);
            this.customLabel22.Name = "customLabel22";
            this.customLabel22.Size = new System.Drawing.Size(58, 15);
            this.customLabel22.TabIndex = 770;
            this.customLabel22.Text = "Company";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.BackColor = System.Drawing.Color.White;
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerTo.Enabled = false;
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(86, 9);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(107, 21);
            this.dateTimePickerTo.TabIndex = 0;
            // 
            // cbo_poNumber
            // 
            this.cbo_poNumber.BackColor = System.Drawing.Color.White;
            this.cbo_poNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_poNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_poNumber.FormattingEnabled = true;
            this.cbo_poNumber.Location = new System.Drawing.Point(86, 121);
            this.cbo_poNumber.Name = "cbo_poNumber";
            this.cbo_poNumber.Size = new System.Drawing.Size(107, 23);
            this.cbo_poNumber.TabIndex = 5;
            // 
            // txt_dmReasonDesc
            // 
            this.txt_dmReasonDesc.BackColor = System.Drawing.Color.White;
            this.txt_dmReasonDesc.Enabled = false;
            this.txt_dmReasonDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_dmReasonDesc.Location = new System.Drawing.Point(149, 179);
            this.txt_dmReasonDesc.Name = "txt_dmReasonDesc";
            this.txt_dmReasonDesc.Size = new System.Drawing.Size(232, 21);
            this.txt_dmReasonDesc.TabIndex = 8;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(12, 182);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(69, 15);
            this.customLabel1.TabIndex = 767;
            this.customLabel1.Text = "DM Reason";
            // 
            // txt_memo
            // 
            this.txt_memo.BackColor = System.Drawing.Color.White;
            this.txt_memo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_memo.Location = new System.Drawing.Point(86, 206);
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(295, 21);
            this.txt_memo.TabIndex = 9;
            // 
            // cbo_supplierID
            // 
            this.cbo_supplierID.BackColor = System.Drawing.Color.White;
            this.cbo_supplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_supplierID.FormattingEnabled = true;
            this.cbo_supplierID.Location = new System.Drawing.Point(86, 92);
            this.cbo_supplierID.Name = "cbo_supplierID";
            this.cbo_supplierID.Size = new System.Drawing.Size(164, 23);
            this.cbo_supplierID.TabIndex = 4;
            this.cbo_supplierID.SelectedIndexChanged += new System.EventHandler(this.cbo_supplierID_SelectedIndexChanged);
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(39, 209);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(41, 15);
            this.customLabel3.TabIndex = 761;
            this.customLabel3.Text = "Memo";
            // 
            // customLabel15
            // 
            this.customLabel15.AutoSize = true;
            this.customLabel15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel15.Location = new System.Drawing.Point(12, 95);
            this.customLabel15.Name = "customLabel15";
            this.customLabel15.Size = new System.Drawing.Size(68, 15);
            this.customLabel15.TabIndex = 758;
            this.customLabel15.Text = "Supplier ID";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(11, 124);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(69, 15);
            this.customLabel4.TabIndex = 766;
            this.customLabel4.Text = "PO Number";
            // 
            // customLabel16
            // 
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel16.Location = new System.Drawing.Point(10, 153);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(71, 15);
            this.customLabel16.TabIndex = 759;
            this.customLabel16.Text = "DM Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_amount.Location = new System.Drawing.Point(86, 150);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(67, 21);
            this.txt_amount.TabIndex = 6;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_request
            // 
            this.btn_request.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_request.FlatAppearance.BorderSize = 0;
            this.btn_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_request.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_request.ForeColor = System.Drawing.Color.White;
            this.btn_request.Location = new System.Drawing.Point(1214, 12);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(86, 238);
            this.btn_request.TabIndex = 1;
            this.btn_request.Text = "Reqeust Debit Memo";
            this.btn_request.UseVisualStyleBackColor = false;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(174, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(68, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbo_searchSupplierID
            // 
            this.cbo_searchSupplierID.BackColor = System.Drawing.Color.White;
            this.cbo_searchSupplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_searchSupplierID.FormattingEnabled = true;
            this.cbo_searchSupplierID.Location = new System.Drawing.Point(12, 30);
            this.cbo_searchSupplierID.Name = "cbo_searchSupplierID";
            this.cbo_searchSupplierID.Size = new System.Drawing.Size(156, 23);
            this.cbo_searchSupplierID.TabIndex = 4;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(9, 12);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(193, 15);
            this.customLabel2.TabIndex = 502;
            this.customLabel2.Text = "Search Debit Memo by Supplier ID";
            // 
            // grid_debit
            // 
            this.grid_debit.AllowUserToAddRows = false;
            this.grid_debit.AllowUserToDeleteRows = false;
            this.grid_debit.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_debit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.grid_debit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_debit.BackgroundColor = System.Drawing.Color.White;
            this.grid_debit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_debit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grid_debit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_debit.DefaultCellStyle = dataGridViewCellStyle19;
            this.grid_debit.EnableHeadersVisualStyles = false;
            this.grid_debit.GridColor = System.Drawing.Color.LightGray;
            this.grid_debit.Location = new System.Drawing.Point(12, 59);
            this.grid_debit.MultiSelect = false;
            this.grid_debit.Name = "grid_debit";
            this.grid_debit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_debit.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.grid_debit.RowHeadersVisible = false;
            this.grid_debit.RowTemplate.Height = 19;
            this.grid_debit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_debit.Size = new System.Drawing.Size(799, 557);
            this.grid_debit.StandardTab = true;
            this.grid_debit.TabIndex = 3;
            this.grid_debit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_debit_CellClick);
            this.grid_debit.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grid_debit_RowPostPaint);
            // 
            // grid_pending
            // 
            this.grid_pending.AllowUserToAddRows = false;
            this.grid_pending.AllowUserToDeleteRows = false;
            this.grid_pending.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_pending.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.grid_pending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_pending.BackgroundColor = System.Drawing.Color.White;
            this.grid_pending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_pending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grid_pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_pending.DefaultCellStyle = dataGridViewCellStyle23;
            this.grid_pending.EnableHeadersVisualStyles = false;
            this.grid_pending.GridColor = System.Drawing.Color.LightGray;
            this.grid_pending.Location = new System.Drawing.Point(817, 256);
            this.grid_pending.MultiSelect = false;
            this.grid_pending.Name = "grid_pending";
            this.grid_pending.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_pending.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.grid_pending.RowHeadersVisible = false;
            this.grid_pending.RowTemplate.Height = 19;
            this.grid_pending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_pending.Size = new System.Drawing.Size(483, 360);
            this.grid_pending.StandardTab = true;
            this.grid_pending.TabIndex = 2;
            // 
            // DebitMemoRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1312, 628);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cbo_searchSupplierID);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_debit);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.grid_pending);
            this.Name = "DebitMemoRequest";
            this.Text = "Debit Memo Request";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_debit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pending)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomGrid grid_debit;
        private CustomGrid grid_pending;
        private System.Windows.Forms.Panel panel1;
        private Tools.CustomComboBox cbo_searchSupplierID;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.Button btn_search;
        private Tools.CustomComboBox cbo_dmReason;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomComboBox cbo_companyID;
        private CustomTextBox txt_companyName;
        private Tools.CustomLabel customLabel22;
        private CustomDateTimePicker dateTimePickerTo;
        private Tools.CustomComboBox cbo_poNumber;
        private CustomTextBox txt_dmReasonDesc;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_memo;
        private Tools.CustomComboBox cbo_supplierID;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel15;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel16;
        private CustomTextBox txt_amount;
        private CustomTextBox txt_poNumber;
        private Tools.CustomLabel customLabel6;
    }
}