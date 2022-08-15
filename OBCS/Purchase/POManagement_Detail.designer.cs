namespace OBCS.Purchase
{
    partial class POManagement_Detail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_RecDate = new System.Windows.Forms.RadioButton();
            this.rad_PoDate = new System.Windows.Forms.RadioButton();
            this.dateTimePickerTo = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerFrom = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_PMsearch = new System.Windows.Forms.Button();
            this.SUPPLIER = new OBCS.Tools.CustomLabel();
            this.cbx_Supplier = new OBCS.Tools.CustomComboBox();
            this.cbx_Product = new OBCS.Tools.CustomComboBox();
            this.cbx_Brand = new OBCS.Tools.CustomComboBox();
            this.cbx_Received = new OBCS.Tools.CustomComboBox();
            this.cbx_Confirmed = new OBCS.Tools.CustomComboBox();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.grid_PoManagement_detail = new OBCS.CustomGrid();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PoManagement_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rad_RecDate);
            this.groupBox1.Controls.Add(this.rad_PoDate);
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.customLabel2);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Controls.Add(this.customLabel5);
            this.groupBox1.Location = new System.Drawing.Point(1156, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 67);
            this.groupBox1.TabIndex = 516;
            this.groupBox1.TabStop = false;
            // 
            // rad_RecDate
            // 
            this.rad_RecDate.AutoSize = true;
            this.rad_RecDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.rad_RecDate.Location = new System.Drawing.Point(17, 41);
            this.rad_RecDate.Name = "rad_RecDate";
            this.rad_RecDate.Size = new System.Drawing.Size(94, 20);
            this.rad_RecDate.TabIndex = 519;
            this.rad_RecDate.TabStop = true;
            this.rad_RecDate.Text = "REC DATE";
            this.rad_RecDate.UseVisualStyleBackColor = true;
            // 
            // rad_PoDate
            // 
            this.rad_PoDate.AutoSize = true;
            this.rad_PoDate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.rad_PoDate.Location = new System.Drawing.Point(17, 13);
            this.rad_PoDate.Name = "rad_PoDate";
            this.rad_PoDate.Size = new System.Drawing.Size(85, 20);
            this.rad_PoDate.TabIndex = 518;
            this.rad_PoDate.TabStop = true;
            this.rad_PoDate.Text = "PO DATE";
            this.rad_PoDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.BackColor = System.Drawing.Color.White;
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(303, 25);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(94, 21);
            this.dateTimePickerTo.TabIndex = 515;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(274, 28);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(23, 15);
            this.customLabel2.TabIndex = 517;
            this.customLabel2.Text = "TO";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.BackColor = System.Drawing.Color.White;
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFrom.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(166, 25);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(94, 21);
            this.dateTimePickerFrom.TabIndex = 514;
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(120, 28);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(40, 15);
            this.customLabel5.TabIndex = 516;
            this.customLabel5.Text = "FROM";
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(1719, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(137, 67);
            this.btn_export.TabIndex = 515;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_PMsearch
            // 
            this.btn_PMsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PMsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_PMsearch.FlatAppearance.BorderSize = 0;
            this.btn_PMsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PMsearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PMsearch.ForeColor = System.Drawing.Color.White;
            this.btn_PMsearch.Location = new System.Drawing.Point(1576, 12);
            this.btn_PMsearch.Name = "btn_PMsearch";
            this.btn_PMsearch.Size = new System.Drawing.Size(137, 67);
            this.btn_PMsearch.TabIndex = 510;
            this.btn_PMsearch.Text = "Search";
            this.btn_PMsearch.UseVisualStyleBackColor = false;
            this.btn_PMsearch.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // SUPPLIER
            // 
            this.SUPPLIER.AutoSize = true;
            this.SUPPLIER.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.SUPPLIER.Location = new System.Drawing.Point(23, 41);
            this.SUPPLIER.Name = "SUPPLIER";
            this.SUPPLIER.Size = new System.Drawing.Size(64, 15);
            this.SUPPLIER.TabIndex = 527;
            this.SUPPLIER.Text = "SUPPLIER";
            // 
            // cbx_Supplier
            // 
            this.cbx_Supplier.BackColor = System.Drawing.Color.White;
            this.cbx_Supplier.Font = new System.Drawing.Font("Arial", 9F);
            this.cbx_Supplier.FormattingEnabled = true;
            this.cbx_Supplier.Location = new System.Drawing.Point(93, 38);
            this.cbx_Supplier.Name = "cbx_Supplier";
            this.cbx_Supplier.Size = new System.Drawing.Size(184, 23);
            this.cbx_Supplier.TabIndex = 526;
            // 
            // cbx_Product
            // 
            this.cbx_Product.BackColor = System.Drawing.Color.White;
            this.cbx_Product.Font = new System.Drawing.Font("Arial", 9F);
            this.cbx_Product.FormattingEnabled = true;
            this.cbx_Product.Location = new System.Drawing.Point(620, 38);
            this.cbx_Product.Name = "cbx_Product";
            this.cbx_Product.Size = new System.Drawing.Size(114, 23);
            this.cbx_Product.TabIndex = 525;
            // 
            // cbx_Brand
            // 
            this.cbx_Brand.BackColor = System.Drawing.Color.White;
            this.cbx_Brand.Font = new System.Drawing.Font("Arial", 9F);
            this.cbx_Brand.FormattingEnabled = true;
            this.cbx_Brand.Location = new System.Drawing.Point(349, 38);
            this.cbx_Brand.Name = "cbx_Brand";
            this.cbx_Brand.Size = new System.Drawing.Size(184, 23);
            this.cbx_Brand.TabIndex = 524;
            // 
            // cbx_Received
            // 
            this.cbx_Received.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Received.BackColor = System.Drawing.Color.White;
            this.cbx_Received.Font = new System.Drawing.Font("Arial", 9F);
            this.cbx_Received.FormattingEnabled = true;
            this.cbx_Received.Location = new System.Drawing.Point(1049, 52);
            this.cbx_Received.Name = "cbx_Received";
            this.cbx_Received.Size = new System.Drawing.Size(101, 23);
            this.cbx_Received.TabIndex = 523;
            // 
            // cbx_Confirmed
            // 
            this.cbx_Confirmed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_Confirmed.BackColor = System.Drawing.Color.White;
            this.cbx_Confirmed.Font = new System.Drawing.Font("Arial", 9F);
            this.cbx_Confirmed.FormattingEnabled = true;
            this.cbx_Confirmed.Location = new System.Drawing.Point(1049, 22);
            this.cbx_Confirmed.Name = "cbx_Confirmed";
            this.cbx_Confirmed.Size = new System.Drawing.Size(101, 23);
            this.cbx_Confirmed.TabIndex = 522;
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel8.Location = new System.Drawing.Point(551, 41);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(63, 15);
            this.customLabel8.TabIndex = 518;
            this.customLabel8.Text = "PRODUCT";
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel7.Location = new System.Drawing.Point(296, 41);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(47, 15);
            this.customLabel7.TabIndex = 519;
            this.customLabel7.Text = "BRAND";
            // 
            // grid_PoManagement_detail
            // 
            this.grid_PoManagement_detail.AllowUserToAddRows = false;
            this.grid_PoManagement_detail.AllowUserToDeleteRows = false;
            this.grid_PoManagement_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_PoManagement_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_PoManagement_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_PoManagement_detail.BackgroundColor = System.Drawing.Color.White;
            this.grid_PoManagement_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_PoManagement_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_PoManagement_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_PoManagement_detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_PoManagement_detail.EnableHeadersVisualStyles = false;
            this.grid_PoManagement_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_PoManagement_detail.Location = new System.Drawing.Point(26, 85);
            this.grid_PoManagement_detail.MultiSelect = false;
            this.grid_PoManagement_detail.Name = "grid_PoManagement_detail";
            this.grid_PoManagement_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_PoManagement_detail.RowHeadersVisible = false;
            this.grid_PoManagement_detail.RowTemplate.Height = 19;
            this.grid_PoManagement_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_PoManagement_detail.Size = new System.Drawing.Size(1830, 760);
            this.grid_PoManagement_detail.StandardTab = true;
            this.grid_PoManagement_detail.TabIndex = 517;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel4.Location = new System.Drawing.Point(992, 56);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(55, 15);
            this.customLabel4.TabIndex = 513;
            this.customLabel4.Text = "RECEIVE";
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel3.Location = new System.Drawing.Point(988, 26);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(59, 15);
            this.customLabel3.TabIndex = 511;
            this.customLabel3.Text = "CONFIRM";
            // 
            // POManagement_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 871);
            this.Controls.Add(this.SUPPLIER);
            this.Controls.Add(this.cbx_Supplier);
            this.Controls.Add(this.cbx_Product);
            this.Controls.Add(this.cbx_Brand);
            this.Controls.Add(this.cbx_Received);
            this.Controls.Add(this.cbx_Confirmed);
            this.Controls.Add(this.customLabel8);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.grid_PoManagement_detail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.btn_PMsearch);
            this.MinimumSize = new System.Drawing.Size(1885, 833);
            this.Name = "POManagement_Detail";
            this.Text = "Purchase Order Management Detail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PoManagement_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_export;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel3;
        private System.Windows.Forms.Button btn_PMsearch;
        private CustomGrid grid_PoManagement_detail;
        private Tools.CustomLabel customLabel8;
        private Tools.CustomLabel customLabel7;
        private Tools.CustomComboBox cbx_Confirmed;
        private Tools.CustomComboBox cbx_Received;
        private Tools.CustomComboBox cbx_Brand;
        private Tools.CustomComboBox cbx_Product;
        private Tools.CustomComboBox cbx_Supplier;
        private Tools.CustomLabel SUPPLIER;
        private System.Windows.Forms.RadioButton rad_RecDate;
        private System.Windows.Forms.RadioButton rad_PoDate;
        private CustomDateTimePicker dateTimePickerTo;
        private Tools.CustomLabel customLabel2;
        private CustomDateTimePicker dateTimePickerFrom;
        private Tools.CustomLabel customLabel5;
    }
}