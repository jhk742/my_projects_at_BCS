namespace OBCS.Purchase
{
    partial class CreditMemoRequest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_poNumber = new OBCS.CustomTextBox();
            this.cbo_cmReason = new OBCS.Tools.CustomComboBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.cbo_companyID = new OBCS.Tools.CustomComboBox();
            this.txt_companyName = new OBCS.CustomTextBox();
            this.customLabel22 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerTo = new OBCS.Purchase.CustomDateTimePicker();
            this.cbo_poNumber = new OBCS.Tools.CustomComboBox();
            this.txt_cmReasonDesc = new OBCS.CustomTextBox();
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
            this.grid_pending = new OBCS.CustomGrid();
            this.grid_credit = new OBCS.CustomGrid();
            this.cbo_searchSupplierID = new OBCS.Tools.CustomComboBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_input = new OBCS.CustomTextBox();
            this.txt_percentage = new OBCS.CustomTextBox();
            this.txt_result = new OBCS.CustomTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pending)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_credit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_poNumber);
            this.panel1.Controls.Add(this.cbo_cmReason);
            this.panel1.Controls.Add(this.customLabel6);
            this.panel1.Controls.Add(this.customLabel5);
            this.panel1.Controls.Add(this.cbo_companyID);
            this.panel1.Controls.Add(this.txt_companyName);
            this.panel1.Controls.Add(this.customLabel22);
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.cbo_poNumber);
            this.panel1.Controls.Add(this.txt_cmReasonDesc);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Controls.Add(this.txt_memo);
            this.panel1.Controls.Add(this.cbo_supplierID);
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.customLabel15);
            this.panel1.Controls.Add(this.customLabel4);
            this.panel1.Controls.Add(this.customLabel16);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Location = new System.Drawing.Point(810, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 240);
            this.panel1.TabIndex = 0;
            // 
            // txt_poNumber
            // 
            this.txt_poNumber.BackColor = System.Drawing.Color.White;
            this.txt_poNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_poNumber.Location = new System.Drawing.Point(193, 65);
            this.txt_poNumber.MaxLength = 6;
            this.txt_poNumber.Name = "txt_poNumber";
            this.txt_poNumber.Size = new System.Drawing.Size(58, 21);
            this.txt_poNumber.TabIndex = 3;
            this.txt_poNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_poNumber_KeyPress);
            // 
            // cbo_cmReason
            // 
            this.cbo_cmReason.BackColor = System.Drawing.Color.White;
            this.cbo_cmReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cmReason.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_cmReason.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_cmReason.FormattingEnabled = true;
            this.cbo_cmReason.Location = new System.Drawing.Point(89, 177);
            this.cbo_cmReason.Name = "cbo_cmReason";
            this.cbo_cmReason.Size = new System.Drawing.Size(63, 23);
            this.cbo_cmReason.TabIndex = 7;
            this.cbo_cmReason.SelectedValueChanged += new System.EventHandler(this.cbo_cmReason_SelectedValueChanged);
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(13, 68);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(174, 15);
            this.customLabel6.TabIndex = 757;
            this.customLabel6.Text = "Search Supplier by PO Number";
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(51, 12);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(32, 15);
            this.customLabel5.TabIndex = 518;
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
            this.cbo_companyID.Location = new System.Drawing.Point(89, 36);
            this.cbo_companyID.Name = "cbo_companyID";
            this.cbo_companyID.Size = new System.Drawing.Size(57, 23);
            this.cbo_companyID.TabIndex = 1;
            this.cbo_companyID.SelectedIndexChanged += new System.EventHandler(this.cbo_companyID_SelectedIndexChanged);
            // 
            // txt_companyName
            // 
            this.txt_companyName.BackColor = System.Drawing.Color.White;
            this.txt_companyName.Enabled = false;
            this.txt_companyName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_companyName.Location = new System.Drawing.Point(152, 38);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(232, 21);
            this.txt_companyName.TabIndex = 2;
            // 
            // customLabel22
            // 
            this.customLabel22.AutoSize = true;
            this.customLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel22.Location = new System.Drawing.Point(25, 39);
            this.customLabel22.Name = "customLabel22";
            this.customLabel22.Size = new System.Drawing.Size(58, 15);
            this.customLabel22.TabIndex = 754;
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
            this.dateTimePickerTo.Location = new System.Drawing.Point(89, 9);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(107, 21);
            this.dateTimePickerTo.TabIndex = 0;
            // 
            // cbo_poNumber
            // 
            this.cbo_poNumber.BackColor = System.Drawing.Color.White;
            this.cbo_poNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_poNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_poNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_poNumber.FormattingEnabled = true;
            this.cbo_poNumber.Location = new System.Drawing.Point(89, 121);
            this.cbo_poNumber.Name = "cbo_poNumber";
            this.cbo_poNumber.Size = new System.Drawing.Size(107, 23);
            this.cbo_poNumber.TabIndex = 5;
            // 
            // txt_cmReasonDesc
            // 
            this.txt_cmReasonDesc.BackColor = System.Drawing.Color.White;
            this.txt_cmReasonDesc.Enabled = false;
            this.txt_cmReasonDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_cmReasonDesc.Location = new System.Drawing.Point(152, 179);
            this.txt_cmReasonDesc.Name = "txt_cmReasonDesc";
            this.txt_cmReasonDesc.Size = new System.Drawing.Size(232, 21);
            this.txt_cmReasonDesc.TabIndex = 8;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(15, 182);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(68, 15);
            this.customLabel1.TabIndex = 751;
            this.customLabel1.Text = "CM Reason";
            // 
            // txt_memo
            // 
            this.txt_memo.BackColor = System.Drawing.Color.White;
            this.txt_memo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_memo.Location = new System.Drawing.Point(89, 206);
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(295, 21);
            this.txt_memo.TabIndex = 9;
            // 
            // cbo_supplierID
            // 
            this.cbo_supplierID.BackColor = System.Drawing.Color.White;
            this.cbo_supplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_supplierID.FormattingEnabled = true;
            this.cbo_supplierID.Location = new System.Drawing.Point(89, 92);
            this.cbo_supplierID.Name = "cbo_supplierID";
            this.cbo_supplierID.Size = new System.Drawing.Size(162, 23);
            this.cbo_supplierID.TabIndex = 4;
            this.cbo_supplierID.SelectedIndexChanged += new System.EventHandler(this.cbo_supplierID_SelectedIndexChanged);
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(42, 209);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(41, 15);
            this.customLabel3.TabIndex = 504;
            this.customLabel3.Text = "Memo";
            // 
            // customLabel15
            // 
            this.customLabel15.AutoSize = true;
            this.customLabel15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel15.Location = new System.Drawing.Point(15, 95);
            this.customLabel15.Name = "customLabel15";
            this.customLabel15.Size = new System.Drawing.Size(68, 15);
            this.customLabel15.TabIndex = 484;
            this.customLabel15.Text = "Supplier ID";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(14, 124);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(69, 15);
            this.customLabel4.TabIndex = 748;
            this.customLabel4.Text = "PO Number";
            // 
            // customLabel16
            // 
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel16.Location = new System.Drawing.Point(13, 153);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(70, 15);
            this.customLabel16.TabIndex = 486;
            this.customLabel16.Text = "CM Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_amount.Location = new System.Drawing.Point(89, 150);
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
            this.btn_request.Location = new System.Drawing.Point(1212, 12);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(88, 240);
            this.btn_request.TabIndex = 1;
            this.btn_request.Text = "Reqeust Credit Memo";
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
            this.btn_search.Location = new System.Drawing.Point(174, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(68, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // grid_pending
            // 
            this.grid_pending.AllowUserToAddRows = false;
            this.grid_pending.AllowUserToDeleteRows = false;
            this.grid_pending.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_pending.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_pending.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_pending.BackgroundColor = System.Drawing.Color.White;
            this.grid_pending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_pending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_pending.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_pending.EnableHeadersVisualStyles = false;
            this.grid_pending.GridColor = System.Drawing.Color.LightGray;
            this.grid_pending.Location = new System.Drawing.Point(810, 258);
            this.grid_pending.MultiSelect = false;
            this.grid_pending.Name = "grid_pending";
            this.grid_pending.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_pending.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_pending.RowHeadersVisible = false;
            this.grid_pending.RowTemplate.Height = 19;
            this.grid_pending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_pending.Size = new System.Drawing.Size(490, 358);
            this.grid_pending.StandardTab = true;
            this.grid_pending.TabIndex = 2;
            // 
            // grid_credit
            // 
            this.grid_credit.AllowUserToAddRows = false;
            this.grid_credit.AllowUserToDeleteRows = false;
            this.grid_credit.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_credit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_credit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_credit.BackgroundColor = System.Drawing.Color.White;
            this.grid_credit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_credit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_credit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_credit.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_credit.EnableHeadersVisualStyles = false;
            this.grid_credit.GridColor = System.Drawing.Color.LightGray;
            this.grid_credit.Location = new System.Drawing.Point(12, 56);
            this.grid_credit.MultiSelect = false;
            this.grid_credit.Name = "grid_credit";
            this.grid_credit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_credit.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_credit.RowHeadersVisible = false;
            this.grid_credit.RowTemplate.Height = 19;
            this.grid_credit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_credit.Size = new System.Drawing.Size(792, 560);
            this.grid_credit.StandardTab = true;
            this.grid_credit.TabIndex = 3;
            this.grid_credit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_credit_CellClick);
            this.grid_credit.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grid_credit_RowPostPaint);
            // 
            // cbo_searchSupplierID
            // 
            this.cbo_searchSupplierID.BackColor = System.Drawing.Color.White;
            this.cbo_searchSupplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_searchSupplierID.FormattingEnabled = true;
            this.cbo_searchSupplierID.Location = new System.Drawing.Point(12, 27);
            this.cbo_searchSupplierID.Name = "cbo_searchSupplierID";
            this.cbo_searchSupplierID.Size = new System.Drawing.Size(156, 23);
            this.cbo_searchSupplierID.TabIndex = 4;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(9, 9);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(197, 15);
            this.customLabel2.TabIndex = 504;
            this.customLabel2.Text = "Search Credit Memo by Supplier ID";
            // 
            // txt_input
            // 
            this.txt_input.BackColor = System.Drawing.Color.White;
            this.txt_input.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_input.Location = new System.Drawing.Point(827, 325);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(67, 21);
            this.txt_input.TabIndex = 505;
            this.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_input.Visible = false;
            // 
            // txt_percentage
            // 
            this.txt_percentage.BackColor = System.Drawing.Color.White;
            this.txt_percentage.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_percentage.Location = new System.Drawing.Point(900, 325);
            this.txt_percentage.Name = "txt_percentage";
            this.txt_percentage.Size = new System.Drawing.Size(67, 21);
            this.txt_percentage.TabIndex = 506;
            this.txt_percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_percentage.Visible = false;
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.Color.White;
            this.txt_result.Enabled = false;
            this.txt_result.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_result.Location = new System.Drawing.Point(973, 325);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(67, 21);
            this.txt_result.TabIndex = 507;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_result.Visible = false;
            // 
            // CreditMemoRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1312, 628);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_percentage);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.grid_pending);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_credit);
            this.Controls.Add(this.cbo_searchSupplierID);
            this.Controls.Add(this.customLabel2);
            this.Name = "CreditMemoRequest";
            this.Text = "Credit Memo Request";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pending)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_credit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.CustomComboBox cbo_searchSupplierID;
        private Tools.CustomLabel customLabel2;
        private CustomGrid grid_credit;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox txt_memo;
        private Tools.CustomComboBox cbo_supplierID;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel15;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel16;
        private CustomTextBox txt_amount;
        private System.Windows.Forms.Button btn_request;
        private CustomGrid grid_pending;
        private System.Windows.Forms.Button btn_search;
        private CustomTextBox txt_cmReasonDesc;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomComboBox cbo_poNumber;
        private Tools.CustomComboBox cbo_cmReason;
        private Tools.CustomComboBox cbo_companyID;
        private CustomTextBox txt_companyName;
        private Tools.CustomLabel customLabel22;
        private Tools.CustomLabel customLabel5;
        private CustomDateTimePicker dateTimePickerTo;
        private CustomTextBox txt_poNumber;
        private Tools.CustomLabel customLabel6;
        private CustomTextBox txt_input;
        private CustomTextBox txt_percentage;
        private CustomTextBox txt_result;
    }
}