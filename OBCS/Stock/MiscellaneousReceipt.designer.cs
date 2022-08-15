namespace OBCS.Stock
{
    partial class MiscellaneousReceipt
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
			this.txt_MrcMemoSummary = new OBCS.CustomTextBox();
			this.cbo_MemoCode = new OBCS.Tools.CustomComboBox();
			this.customLabel10 = new OBCS.Tools.CustomLabel();
			this.cbo_Status = new OBCS.Tools.CustomComboBox();
			this.customLabel9 = new OBCS.Tools.CustomLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.customLabel8 = new OBCS.Tools.CustomLabel();
			this.dateTimePickerExpired = new System.Windows.Forms.DateTimePicker();
			this.btn_Receipt = new System.Windows.Forms.Button();
			this.cbo_Company = new OBCS.Tools.CustomComboBox();
			this.customLabel7 = new OBCS.Tools.CustomLabel();
			this.customLabel19 = new OBCS.Tools.CustomLabel();
			this.customLabel18 = new OBCS.Tools.CustomLabel();
			this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.customLabel3 = new OBCS.Tools.CustomLabel();
			this.txt_ReceiptQty = new OBCS.CustomTextBox();
			this.grid_header = new OBCS.CustomGrid();
			this.grid_Detail = new OBCS.CustomGrid();
			this.grid_stock = new OBCS.CustomGrid();
			this.txt_ProductDesc = new OBCS.CustomTextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.customLabel5 = new OBCS.Tools.CustomLabel();
			this.txt_availableQty = new OBCS.CustomTextBox();
			this.customLabel1 = new OBCS.Tools.CustomLabel();
			this.txt_globalAllocated = new OBCS.CustomTextBox();
			this.cbo_product = new OBCS.Tools.CustomComboBox();
			this.customLabel2 = new OBCS.Tools.CustomLabel();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.txt_MrcMemo = new OBCS.CustomTextBox();
			this.cbo_storageSite = new OBCS.Tools.CustomComboBox();
			this.customLabel4 = new OBCS.Tools.CustomLabel();
			((System.ComponentModel.ISupportInitialize)(this.grid_header)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_Detail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_stock)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_MrcMemoSummary
			// 
			this.txt_MrcMemoSummary.BackColor = System.Drawing.Color.White;
			this.txt_MrcMemoSummary.Enabled = false;
			this.txt_MrcMemoSummary.Font = new System.Drawing.Font("Arial", 9F);
			this.txt_MrcMemoSummary.Location = new System.Drawing.Point(1071, 29);
			this.txt_MrcMemoSummary.MaxLength = 200;
			this.txt_MrcMemoSummary.Name = "txt_MrcMemoSummary";
			this.txt_MrcMemoSummary.Size = new System.Drawing.Size(209, 21);
			this.txt_MrcMemoSummary.TabIndex = 858;
			// 
			// cbo_MemoCode
			// 
			this.cbo_MemoCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.cbo_MemoCode.BackColor = System.Drawing.Color.White;
			this.cbo_MemoCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_MemoCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_MemoCode.Font = new System.Drawing.Font("Arial", 9F);
			this.cbo_MemoCode.FormattingEnabled = true;
			this.cbo_MemoCode.Location = new System.Drawing.Point(996, 29);
			this.cbo_MemoCode.Name = "cbo_MemoCode";
			this.cbo_MemoCode.Size = new System.Drawing.Size(69, 23);
			this.cbo_MemoCode.TabIndex = 856;
			this.cbo_MemoCode.SelectedIndexChanged += new System.EventHandler(this.cbo_MemoCode_SelectedIndexChanged);
			// 
			// customLabel10
			// 
			this.customLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.customLabel10.AutoSize = true;
			this.customLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel10.Location = new System.Drawing.Point(993, 10);
			this.customLabel10.Name = "customLabel10";
			this.customLabel10.Size = new System.Drawing.Size(43, 15);
			this.customLabel10.TabIndex = 857;
			this.customLabel10.Text = "Memo";
			// 
			// cbo_Status
			// 
			this.cbo_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbo_Status.BackColor = System.Drawing.Color.White;
			this.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_Status.Font = new System.Drawing.Font("Arial", 9F);
			this.cbo_Status.FormattingEnabled = true;
			this.cbo_Status.Location = new System.Drawing.Point(1340, 119);
			this.cbo_Status.Name = "cbo_Status";
			this.cbo_Status.Size = new System.Drawing.Size(82, 23);
			this.cbo_Status.TabIndex = 854;
			// 
			// customLabel9
			// 
			this.customLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.customLabel9.AutoSize = true;
			this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel9.Location = new System.Drawing.Point(1337, 100);
			this.customLabel9.Name = "customLabel9";
			this.customLabel9.Size = new System.Drawing.Size(41, 15);
			this.customLabel9.TabIndex = 855;
			this.customLabel9.Text = "Status";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(706, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 15);
			this.label1.TabIndex = 853;
			this.label1.Text = "Product Desc";
			// 
			// customLabel8
			// 
			this.customLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.customLabel8.AutoSize = true;
			this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel8.Location = new System.Drawing.Point(1425, 57);
			this.customLabel8.Name = "customLabel8";
			this.customLabel8.Size = new System.Drawing.Size(70, 15);
			this.customLabel8.TabIndex = 852;
			this.customLabel8.Text = "Expire Date";
			// 
			// dateTimePickerExpired
			// 
			this.dateTimePickerExpired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerExpired.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerExpired.CustomFormat = "MM/dd/yyyy";
			this.dateTimePickerExpired.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerExpired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerExpired.Location = new System.Drawing.Point(1428, 74);
			this.dateTimePickerExpired.Name = "dateTimePickerExpired";
			this.dateTimePickerExpired.Size = new System.Drawing.Size(111, 22);
			this.dateTimePickerExpired.TabIndex = 851;
			// 
			// btn_Receipt
			// 
			this.btn_Receipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.btn_Receipt.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Receipt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Receipt.ForeColor = System.Drawing.Color.White;
			this.btn_Receipt.Location = new System.Drawing.Point(1545, 74);
			this.btn_Receipt.Name = "btn_Receipt";
			this.btn_Receipt.Size = new System.Drawing.Size(110, 66);
			this.btn_Receipt.TabIndex = 850;
			this.btn_Receipt.Text = "Receipt";
			this.btn_Receipt.UseVisualStyleBackColor = false;
			this.btn_Receipt.Click += new System.EventHandler(this.btn_Receipt_Click);
			// 
			// cbo_Company
			// 
			this.cbo_Company.BackColor = System.Drawing.Color.White;
			this.cbo_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_Company.Enabled = false;
			this.cbo_Company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_Company.Font = new System.Drawing.Font("Arial", 9F);
			this.cbo_Company.FormattingEnabled = true;
			this.cbo_Company.Location = new System.Drawing.Point(709, 29);
			this.cbo_Company.Name = "cbo_Company";
			this.cbo_Company.Size = new System.Drawing.Size(206, 23);
			this.cbo_Company.TabIndex = 848;
			// 
			// customLabel7
			// 
			this.customLabel7.AutoSize = true;
			this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel7.Location = new System.Drawing.Point(706, 10);
			this.customLabel7.Name = "customLabel7";
			this.customLabel7.Size = new System.Drawing.Size(58, 15);
			this.customLabel7.TabIndex = 849;
			this.customLabel7.Text = "Company";
			// 
			// customLabel19
			// 
			this.customLabel19.AutoSize = true;
			this.customLabel19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel19.Location = new System.Drawing.Point(176, 15);
			this.customLabel19.Name = "customLabel19";
			this.customLabel19.Size = new System.Drawing.Size(19, 15);
			this.customLabel19.TabIndex = 847;
			this.customLabel19.Text = "To";
			// 
			// customLabel18
			// 
			this.customLabel18.AutoSize = true;
			this.customLabel18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel18.Location = new System.Drawing.Point(10, 16);
			this.customLabel18.Name = "customLabel18";
			this.customLabel18.Size = new System.Drawing.Size(35, 15);
			this.customLabel18.TabIndex = 844;
			this.customLabel18.Text = "From";
			// 
			// dateTimePickerTo
			// 
			this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
			this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerTo.Location = new System.Drawing.Point(201, 12);
			this.dateTimePickerTo.Name = "dateTimePickerTo";
			this.dateTimePickerTo.Size = new System.Drawing.Size(116, 22);
			this.dateTimePickerTo.TabIndex = 846;
			// 
			// dateTimePickerFrom
			// 
			this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
			this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerFrom.Location = new System.Drawing.Point(51, 12);
			this.dateTimePickerFrom.Name = "dateTimePickerFrom";
			this.dateTimePickerFrom.Size = new System.Drawing.Size(116, 22);
			this.dateTimePickerFrom.TabIndex = 845;
			// 
			// btn_refresh
			// 
			this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
			this.btn_refresh.FlatAppearance.BorderSize = 0;
			this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_refresh.ForeColor = System.Drawing.Color.White;
			this.btn_refresh.Location = new System.Drawing.Point(581, 12);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(119, 23);
			this.btn_refresh.TabIndex = 843;
			this.btn_refresh.Text = "Refresh";
			this.btn_refresh.UseVisualStyleBackColor = false;
			this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
			// 
			// customLabel3
			// 
			this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.customLabel3.AutoSize = true;
			this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel3.Location = new System.Drawing.Point(1425, 100);
			this.customLabel3.Name = "customLabel3";
			this.customLabel3.Size = new System.Drawing.Size(71, 15);
			this.customLabel3.TabIndex = 842;
			this.customLabel3.Text = "Receipt Qty";
			// 
			// txt_ReceiptQty
			// 
			this.txt_ReceiptQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_ReceiptQty.BackColor = System.Drawing.Color.White;
			this.txt_ReceiptQty.Font = new System.Drawing.Font("Arial", 9F);
			this.txt_ReceiptQty.Location = new System.Drawing.Point(1428, 119);
			this.txt_ReceiptQty.Name = "txt_ReceiptQty";
			this.txt_ReceiptQty.Size = new System.Drawing.Size(111, 21);
			this.txt_ReceiptQty.TabIndex = 841;
			this.txt_ReceiptQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txt_ReceiptQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ReceiptQty_KeyPress);
			// 
			// grid_header
			// 
			this.grid_header.AllowUserToAddRows = false;
			this.grid_header.AllowUserToDeleteRows = false;
			this.grid_header.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
			this.grid_header.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grid_header.BackgroundColor = System.Drawing.Color.White;
			this.grid_header.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid_header.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grid_header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid_header.DefaultCellStyle = dataGridViewCellStyle3;
			this.grid_header.EnableHeadersVisualStyles = false;
			this.grid_header.GridColor = System.Drawing.Color.LightGray;
			this.grid_header.Location = new System.Drawing.Point(13, 40);
			this.grid_header.MultiSelect = false;
			this.grid_header.Name = "grid_header";
			this.grid_header.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid_header.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.grid_header.RowHeadersVisible = false;
			this.grid_header.RowTemplate.Height = 19;
			this.grid_header.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_header.Size = new System.Drawing.Size(687, 554);
			this.grid_header.StandardTab = true;
			this.grid_header.TabIndex = 840;
			this.grid_header.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_header_CellEnter);
			// 
			// grid_Detail
			// 
			this.grid_Detail.AllowUserToAddRows = false;
			this.grid_Detail.AllowUserToDeleteRows = false;
			this.grid_Detail.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
			this.grid_Detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.grid_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.grid_Detail.BackgroundColor = System.Drawing.Color.White;
			this.grid_Detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid_Detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.grid_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid_Detail.DefaultCellStyle = dataGridViewCellStyle7;
			this.grid_Detail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grid_Detail.EnableHeadersVisualStyles = false;
			this.grid_Detail.GridColor = System.Drawing.Color.LightGray;
			this.grid_Detail.Location = new System.Drawing.Point(13, 600);
			this.grid_Detail.MultiSelect = false;
			this.grid_Detail.Name = "grid_Detail";
			this.grid_Detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid_Detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.grid_Detail.RowHeadersVisible = false;
			this.grid_Detail.RowTemplate.Height = 19;
			this.grid_Detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_Detail.Size = new System.Drawing.Size(687, 216);
			this.grid_Detail.StandardTab = true;
			this.grid_Detail.TabIndex = 839;
			// 
			// grid_stock
			// 
			this.grid_stock.AllowUserToAddRows = false;
			this.grid_stock.AllowUserToDeleteRows = false;
			this.grid_stock.AllowUserToResizeRows = false;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
			this.grid_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
			this.grid_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grid_stock.BackgroundColor = System.Drawing.Color.White;
			this.grid_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.grid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid_stock.DefaultCellStyle = dataGridViewCellStyle11;
			this.grid_stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grid_stock.EnableHeadersVisualStyles = false;
			this.grid_stock.GridColor = System.Drawing.Color.LightGray;
			this.grid_stock.Location = new System.Drawing.Point(710, 149);
			this.grid_stock.MultiSelect = false;
			this.grid_stock.Name = "grid_stock";
			this.grid_stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.grid_stock.RowHeadersVisible = false;
			this.grid_stock.RowTemplate.Height = 19;
			this.grid_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_stock.Size = new System.Drawing.Size(945, 667);
			this.grid_stock.StandardTab = true;
			this.grid_stock.TabIndex = 838;
			// 
			// txt_ProductDesc
			// 
			this.txt_ProductDesc.BackColor = System.Drawing.Color.White;
			this.txt_ProductDesc.Enabled = false;
			this.txt_ProductDesc.Font = new System.Drawing.Font("Arial", 9F);
			this.txt_ProductDesc.Location = new System.Drawing.Point(709, 118);
			this.txt_ProductDesc.MaxLength = 30;
			this.txt_ProductDesc.Name = "txt_ProductDesc";
			this.txt_ProductDesc.Size = new System.Drawing.Size(336, 21);
			this.txt_ProductDesc.TabIndex = 836;
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(706, 56);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(64, 15);
			this.label34.TabIndex = 837;
			this.label34.Text = "Product ID";
			// 
			// customLabel5
			// 
			this.customLabel5.AutoSize = true;
			this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel5.Location = new System.Drawing.Point(962, 56);
			this.customLabel5.Name = "customLabel5";
			this.customLabel5.Size = new System.Drawing.Size(59, 15);
			this.customLabel5.TabIndex = 835;
			this.customLabel5.Text = "Available";
			// 
			// txt_availableQty
			// 
			this.txt_availableQty.BackColor = System.Drawing.Color.White;
			this.txt_availableQty.Enabled = false;
			this.txt_availableQty.Font = new System.Drawing.Font("Arial", 9F);
			this.txt_availableQty.Location = new System.Drawing.Point(965, 74);
			this.txt_availableQty.Name = "txt_availableQty";
			this.txt_availableQty.Size = new System.Drawing.Size(80, 21);
			this.txt_availableQty.TabIndex = 834;
			this.txt_availableQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// customLabel1
			// 
			this.customLabel1.AutoSize = true;
			this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel1.Location = new System.Drawing.Point(876, 56);
			this.customLabel1.Name = "customLabel1";
			this.customLabel1.Size = new System.Drawing.Size(44, 15);
			this.customLabel1.TabIndex = 833;
			this.customLabel1.Text = "Global";
			// 
			// txt_globalAllocated
			// 
			this.txt_globalAllocated.BackColor = System.Drawing.Color.White;
			this.txt_globalAllocated.Enabled = false;
			this.txt_globalAllocated.Font = new System.Drawing.Font("Arial", 9F);
			this.txt_globalAllocated.Location = new System.Drawing.Point(879, 74);
			this.txt_globalAllocated.Name = "txt_globalAllocated";
			this.txt_globalAllocated.Size = new System.Drawing.Size(80, 21);
			this.txt_globalAllocated.TabIndex = 832;
			this.txt_globalAllocated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// cbo_product
			// 
			this.cbo_product.BackColor = System.Drawing.Color.White;
			this.cbo_product.Font = new System.Drawing.Font("Arial", 9F);
			this.cbo_product.FormattingEnabled = true;
			this.cbo_product.Location = new System.Drawing.Point(709, 73);
			this.cbo_product.Name = "cbo_product";
			this.cbo_product.Size = new System.Drawing.Size(164, 23);
			this.cbo_product.TabIndex = 831;
			this.cbo_product.TextUpdate += new System.EventHandler(this.cbo_product_TextUpdate);
			this.cbo_product.SelectedValueChanged += new System.EventHandler(this.cbo_product_SelectedValueChanged);
			this.cbo_product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_product_KeyPress);
			// 
			// customLabel2
			// 
			this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.customLabel2.AutoSize = true;
			this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel2.Location = new System.Drawing.Point(1542, 12);
			this.customLabel2.Name = "customLabel2";
			this.customLabel2.Size = new System.Drawing.Size(75, 15);
			this.customLabel2.TabIndex = 830;
			this.customLabel2.Text = "Receipt Date";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(1544, 29);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
			this.dateTimePicker1.TabIndex = 829;
			// 
			// txt_MrcMemo
			// 
			this.txt_MrcMemo.BackColor = System.Drawing.Color.White;
			this.txt_MrcMemo.Font = new System.Drawing.Font("Arial", 9F);
			this.txt_MrcMemo.Location = new System.Drawing.Point(1286, 29);
			this.txt_MrcMemo.MaxLength = 200;
			this.txt_MrcMemo.Name = "txt_MrcMemo";
			this.txt_MrcMemo.Size = new System.Drawing.Size(252, 21);
			this.txt_MrcMemo.TabIndex = 828;
			// 
			// cbo_storageSite
			// 
			this.cbo_storageSite.BackColor = System.Drawing.Color.White;
			this.cbo_storageSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbo_storageSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbo_storageSite.Font = new System.Drawing.Font("Arial", 9F);
			this.cbo_storageSite.FormattingEnabled = true;
			this.cbo_storageSite.Location = new System.Drawing.Point(921, 29);
			this.cbo_storageSite.Name = "cbo_storageSite";
			this.cbo_storageSite.Size = new System.Drawing.Size(69, 23);
			this.cbo_storageSite.TabIndex = 826;
			this.cbo_storageSite.SelectedValueChanged += new System.EventHandler(this.cbo_storageSite_SelectedValueChanged);
			this.cbo_storageSite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_storageSite_KeyPress);
			// 
			// customLabel4
			// 
			this.customLabel4.AutoSize = true;
			this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customLabel4.Location = new System.Drawing.Point(919, 11);
			this.customLabel4.Name = "customLabel4";
			this.customLabel4.Size = new System.Drawing.Size(28, 15);
			this.customLabel4.TabIndex = 827;
			this.customLabel4.Text = "Site";
			// 
			// MiscellaneousReceipt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1667, 828);
			this.Controls.Add(this.txt_MrcMemoSummary);
			this.Controls.Add(this.cbo_MemoCode);
			this.Controls.Add(this.customLabel10);
			this.Controls.Add(this.cbo_Status);
			this.Controls.Add(this.customLabel9);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.customLabel8);
			this.Controls.Add(this.dateTimePickerExpired);
			this.Controls.Add(this.btn_Receipt);
			this.Controls.Add(this.cbo_Company);
			this.Controls.Add(this.customLabel7);
			this.Controls.Add(this.customLabel19);
			this.Controls.Add(this.customLabel18);
			this.Controls.Add(this.dateTimePickerTo);
			this.Controls.Add(this.dateTimePickerFrom);
			this.Controls.Add(this.btn_refresh);
			this.Controls.Add(this.customLabel3);
			this.Controls.Add(this.txt_ReceiptQty);
			this.Controls.Add(this.grid_header);
			this.Controls.Add(this.grid_Detail);
			this.Controls.Add(this.grid_stock);
			this.Controls.Add(this.txt_ProductDesc);
			this.Controls.Add(this.label34);
			this.Controls.Add(this.customLabel5);
			this.Controls.Add(this.txt_availableQty);
			this.Controls.Add(this.customLabel1);
			this.Controls.Add(this.txt_globalAllocated);
			this.Controls.Add(this.cbo_product);
			this.Controls.Add(this.customLabel2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.txt_MrcMemo);
			this.Controls.Add(this.cbo_storageSite);
			this.Controls.Add(this.customLabel4);
			this.MinimumSize = new System.Drawing.Size(1683, 400);
			this.Name = "MiscellaneousReceipt";
			this.Text = "Miscellaneous Receipt";
			((System.ComponentModel.ISupportInitialize)(this.grid_header)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_Detail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid_stock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private CustomTextBox txt_MrcMemoSummary;
        private Tools.CustomComboBox cbo_MemoCode;
        private Tools.CustomLabel customLabel10;
        private Tools.CustomComboBox cbo_Status;
        private Tools.CustomLabel customLabel9;
        private System.Windows.Forms.Label label1;
        private Tools.CustomLabel customLabel8;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpired;
        private System.Windows.Forms.Button btn_Receipt;
        private Tools.CustomComboBox cbo_Company;
        private Tools.CustomLabel customLabel7;
        private Tools.CustomLabel customLabel19;
        private Tools.CustomLabel customLabel18;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btn_refresh;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_ReceiptQty;
        private CustomGrid grid_header;
        private CustomGrid grid_Detail;
        private CustomGrid grid_stock;
        private CustomTextBox txt_ProductDesc;
        private System.Windows.Forms.Label label34;
        private Tools.CustomLabel customLabel5;
        private CustomTextBox txt_availableQty;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_globalAllocated;
        private Tools.CustomComboBox cbo_product;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CustomTextBox txt_MrcMemo;
        private Tools.CustomComboBox cbo_storageSite;
        private Tools.CustomLabel customLabel4;
    }
}