
namespace OBCS.Sales
{
    partial class WriteOff
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.btn_export = new System.Windows.Forms.Button();
            this.dateTimePickerFromDate = new OBCS.Purchase.CustomDateTimePicker();
            this.btn_searchHistory = new System.Windows.Forms.Button();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.grid_historyHeader = new OBCS.CustomGrid();
            this.dateTimePickerToDate = new OBCS.Purchase.CustomDateTimePicker();
            this.cbo_customerHistory = new OBCS.Tools.CustomComboBoxLarge();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbo_customerInvoice = new OBCS.Tools.CustomComboBoxLarge();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.btn_searchInvoice = new System.Windows.Forms.Button();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.grid_invoice = new OBCS.CustomGrid();
            this.panel7 = new System.Windows.Forms.Panel();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.cbo_company = new OBCS.Tools.CustomComboBoxLarge();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_Memo = new OBCS.Tools.CustomLabel();
            this.textbox_Memo = new OBCS.CustomTextBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.customLabel11 = new OBCS.Tools.CustomLabel();
            this.lbl_accdate = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_totalPostedAmount = new OBCS.CustomTextBox();
            this.customLabel12 = new OBCS.Tools.CustomLabel();
            this.txt_customerID = new OBCS.CustomTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_historyHeader)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoice)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.customLabel2);
            this.panel2.Controls.Add(this.btn_export);
            this.panel2.Controls.Add(this.dateTimePickerFromDate);
            this.panel2.Controls.Add(this.btn_searchHistory);
            this.panel2.Controls.Add(this.customLabel5);
            this.panel2.Controls.Add(this.grid_historyHeader);
            this.panel2.Controls.Add(this.dateTimePickerToDate);
            this.panel2.Controls.Add(this.cbo_customerHistory);
            this.panel2.Controls.Add(this.customLabel6);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 703);
            this.panel2.TabIndex = 519;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(156, 43);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(38, 17);
            this.customLabel2.TabIndex = 670;
            this.customLabel2.Text = "From";
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(425, 38);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(104, 27);
            this.btn_export.TabIndex = 663;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFromDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerFromDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFromDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerFromDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(200, 41);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerFromDate.TabIndex = 669;
            // 
            // btn_searchHistory
            // 
            this.btn_searchHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_searchHistory.FlatAppearance.BorderSize = 0;
            this.btn_searchHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchHistory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchHistory.ForeColor = System.Drawing.Color.White;
            this.btn_searchHistory.Location = new System.Drawing.Point(425, 5);
            this.btn_searchHistory.Name = "btn_searchHistory";
            this.btn_searchHistory.Size = new System.Drawing.Size(104, 27);
            this.btn_searchHistory.TabIndex = 381;
            this.btn_searchHistory.Text = "Search";
            this.btn_searchHistory.UseVisualStyleBackColor = false;
            this.btn_searchHistory.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(298, 43);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(22, 17);
            this.customLabel5.TabIndex = 668;
            this.customLabel5.Text = "To";
            // 
            // grid_historyHeader
            // 
            this.grid_historyHeader.AllowUserToAddRows = false;
            this.grid_historyHeader.AllowUserToDeleteRows = false;
            this.grid_historyHeader.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_historyHeader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_historyHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_historyHeader.BackgroundColor = System.Drawing.Color.White;
            this.grid_historyHeader.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_historyHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_historyHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_historyHeader.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_historyHeader.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_historyHeader.EnableHeadersVisualStyles = false;
            this.grid_historyHeader.GridColor = System.Drawing.Color.LightGray;
            this.grid_historyHeader.Location = new System.Drawing.Point(7, 71);
            this.grid_historyHeader.MultiSelect = false;
            this.grid_historyHeader.Name = "grid_historyHeader";
            this.grid_historyHeader.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_historyHeader.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_historyHeader.RowHeadersVisible = false;
            this.grid_historyHeader.RowTemplate.Height = 19;
            this.grid_historyHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_historyHeader.Size = new System.Drawing.Size(522, 625);
            this.grid_historyHeader.StandardTab = true;
            this.grid_historyHeader.TabIndex = 367;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerToDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerToDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerToDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerToDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(326, 41);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerToDate.TabIndex = 667;
            // 
            // cbo_customerHistory
            // 
            this.cbo_customerHistory.BackColor = System.Drawing.Color.White;
            this.cbo_customerHistory.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.cbo_customerHistory.FormattingEnabled = true;
            this.cbo_customerHistory.Location = new System.Drawing.Point(87, 5);
            this.cbo_customerHistory.Name = "cbo_customerHistory";
            this.cbo_customerHistory.Size = new System.Drawing.Size(331, 27);
            this.cbo_customerHistory.TabIndex = 377;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(13, 9);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(68, 18);
            this.customLabel6.TabIndex = 378;
            this.customLabel6.Text = "Customer";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.cbo_customerInvoice);
            this.panel5.Controls.Add(this.customLabel8);
            this.panel5.Controls.Add(this.btn_searchInvoice);
            this.panel5.Controls.Add(this.customLabel1);
            this.panel5.Controls.Add(this.grid_invoice);
            this.panel5.Location = new System.Drawing.Point(554, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(897, 703);
            this.panel5.TabIndex = 520;
            // 
            // cbo_customerInvoice
            // 
            this.cbo_customerInvoice.BackColor = System.Drawing.Color.White;
            this.cbo_customerInvoice.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.cbo_customerInvoice.FormattingEnabled = true;
            this.cbo_customerInvoice.Location = new System.Drawing.Point(87, 5);
            this.cbo_customerInvoice.Name = "cbo_customerInvoice";
            this.cbo_customerInvoice.Size = new System.Drawing.Size(256, 27);
            this.cbo_customerInvoice.TabIndex = 675;
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(13, 9);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(68, 18);
            this.customLabel8.TabIndex = 676;
            this.customLabel8.Text = "Customer";
            // 
            // btn_searchInvoice
            // 
            this.btn_searchInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_searchInvoice.FlatAppearance.BorderSize = 0;
            this.btn_searchInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchInvoice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchInvoice.ForeColor = System.Drawing.Color.White;
            this.btn_searchInvoice.Location = new System.Drawing.Point(349, 5);
            this.btn_searchInvoice.Name = "btn_searchInvoice";
            this.btn_searchInvoice.Size = new System.Drawing.Size(104, 27);
            this.btn_searchInvoice.TabIndex = 675;
            this.btn_searchInvoice.Text = "Refresh";
            this.btn_searchInvoice.UseVisualStyleBackColor = false;
            this.btn_searchInvoice.Click += new System.EventHandler(this.btn_searchInvoice_Click);
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(3, 39);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(58, 19);
            this.customLabel1.TabIndex = 368;
            this.customLabel1.Text = "Invoice";
            // 
            // grid_invoice
            // 
            this.grid_invoice.AllowUserToAddRows = false;
            this.grid_invoice.AllowUserToDeleteRows = false;
            this.grid_invoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_invoice.BackgroundColor = System.Drawing.Color.White;
            this.grid_invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_invoice.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_invoice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_invoice.EnableHeadersVisualStyles = false;
            this.grid_invoice.GridColor = System.Drawing.Color.LightGray;
            this.grid_invoice.Location = new System.Drawing.Point(7, 61);
            this.grid_invoice.MultiSelect = false;
            this.grid_invoice.Name = "grid_invoice";
            this.grid_invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_invoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_invoice.RowHeadersVisible = false;
            this.grid_invoice.RowTemplate.Height = 19;
            this.grid_invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_invoice.Size = new System.Drawing.Size(882, 635);
            this.grid_invoice.StandardTab = true;
            this.grid_invoice.TabIndex = 367;
            this.grid_invoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_invoice_CellEndEdit);
            this.grid_invoice.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grid_invoice_DataError);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.customLabel7);
            this.panel7.Controls.Add(this.cbo_company);
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1439, 52);
            this.panel7.TabIndex = 521;
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(15, 17);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(66, 18);
            this.customLabel7.TabIndex = 380;
            this.customLabel7.Text = "Company";
            // 
            // cbo_company
            // 
            this.cbo_company.BackColor = System.Drawing.Color.White;
            this.cbo_company.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.cbo_company.FormattingEnabled = true;
            this.cbo_company.Location = new System.Drawing.Point(87, 13);
            this.cbo_company.Name = "cbo_company";
            this.cbo_company.Size = new System.Drawing.Size(331, 27);
            this.cbo_company.TabIndex = 379;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label_Memo);
            this.panel4.Controls.Add(this.textbox_Memo);
            this.panel4.Controls.Add(this.dateTimePickerFrom);
            this.panel4.Controls.Add(this.customLabel11);
            this.panel4.Controls.Add(this.lbl_accdate);
            this.panel4.Controls.Add(this.btn_save);
            this.panel4.Controls.Add(this.txt_totalPostedAmount);
            this.panel4.Location = new System.Drawing.Point(1457, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 184);
            this.panel4.TabIndex = 522;
            // 
            // label_Memo
            // 
            this.label_Memo.AutoSize = true;
            this.label_Memo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Memo.Location = new System.Drawing.Point(8, 94);
            this.label_Memo.Name = "label_Memo";
            this.label_Memo.Size = new System.Drawing.Size(41, 15);
            this.label_Memo.TabIndex = 376;
            this.label_Memo.Text = "Memo";
            // 
            // textbox_Memo
            // 
            this.textbox_Memo.BackColor = System.Drawing.Color.White;
            this.textbox_Memo.Font = new System.Drawing.Font("Arial", 9F);
            this.textbox_Memo.Location = new System.Drawing.Point(11, 112);
            this.textbox_Memo.Name = "textbox_Memo";
            this.textbox_Memo.Size = new System.Drawing.Size(129, 21);
            this.textbox_Memo.TabIndex = 375;
            this.textbox_Memo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 70);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(129, 22);
            this.dateTimePickerFrom.TabIndex = 369;
            // 
            // customLabel11
            // 
            this.customLabel11.AutoSize = true;
            this.customLabel11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel11.Location = new System.Drawing.Point(9, 10);
            this.customLabel11.Name = "customLabel11";
            this.customLabel11.Size = new System.Drawing.Size(132, 15);
            this.customLabel11.TabIndex = 374;
            this.customLabel11.Text = "Total Write-off Amount";
            // 
            // lbl_accdate
            // 
            this.lbl_accdate.AutoSize = true;
            this.lbl_accdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accdate.Location = new System.Drawing.Point(9, 52);
            this.lbl_accdate.Name = "lbl_accdate";
            this.lbl_accdate.Size = new System.Drawing.Size(95, 15);
            this.lbl_accdate.TabIndex = 370;
            this.lbl_accdate.Text = "Accounting Date";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(11, 139);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(129, 34);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_totalPostedAmount
            // 
            this.txt_totalPostedAmount.BackColor = System.Drawing.Color.White;
            this.txt_totalPostedAmount.Enabled = false;
            this.txt_totalPostedAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalPostedAmount.Location = new System.Drawing.Point(12, 28);
            this.txt_totalPostedAmount.Name = "txt_totalPostedAmount";
            this.txt_totalPostedAmount.Size = new System.Drawing.Size(129, 21);
            this.txt_totalPostedAmount.TabIndex = 1;
            this.txt_totalPostedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel12
            // 
            this.customLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel12.AutoSize = true;
            this.customLabel12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel12.Location = new System.Drawing.Point(1497, 25);
            this.customLabel12.Name = "customLabel12";
            this.customLabel12.Size = new System.Drawing.Size(74, 15);
            this.customLabel12.TabIndex = 524;
            this.customLabel12.Text = "Customer ID";
            // 
            // txt_customerID
            // 
            this.txt_customerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerID.BackColor = System.Drawing.Color.White;
            this.txt_customerID.Enabled = false;
            this.txt_customerID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_customerID.Location = new System.Drawing.Point(1469, 43);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(130, 21);
            this.txt_customerID.TabIndex = 523;
            this.txt_customerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WriteOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 785);
            this.Controls.Add(this.customLabel12);
            this.Controls.Add(this.txt_customerID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1640, 824);
            this.Name = "WriteOff";
            this.Text = "WriteOff";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_historyHeader)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoice)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private CustomGrid grid_historyHeader;
        private System.Windows.Forms.Panel panel5;
        private Tools.CustomLabel customLabel1;
        private CustomGrid grid_invoice;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Button btn_searchHistory;
        private Tools.CustomLabel customLabel7;
        public Tools.CustomComboBoxLarge cbo_customerHistory;
        private Tools.CustomComboBoxLarge cbo_company;
        private Tools.CustomLabel customLabel6;
        private Tools.CustomLabel customLabel12;
        private CustomTextBox txt_customerID;
        private System.Windows.Forms.Panel panel4;
        private Tools.CustomLabel customLabel11;
        private System.Windows.Forms.Button btn_save;
        private CustomTextBox txt_totalPostedAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lbl_accdate;
        private System.Windows.Forms.Button btn_export;
        private Tools.CustomLabel customLabel2;
        private Purchase.CustomDateTimePicker dateTimePickerFromDate;
        private Tools.CustomLabel customLabel5;
        private Purchase.CustomDateTimePicker dateTimePickerToDate;
        public Tools.CustomComboBoxLarge cbo_customerInvoice;
        private Tools.CustomLabel customLabel8;
        public System.Windows.Forms.Button btn_searchInvoice;
        private Tools.CustomLabel label_Memo;
        private CustomTextBox textbox_Memo;
    }
}