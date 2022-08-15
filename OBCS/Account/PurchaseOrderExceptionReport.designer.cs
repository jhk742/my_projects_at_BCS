namespace OBCS.Sales
{
    partial class PurchaseOrderExceptionReport
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
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbx_x3 = new System.Windows.Forms.CheckBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerFromDate = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.cbo_SupplierID = new OBCS.Tools.CustomComboBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.cbo_poOpenStatus = new OBCS.Tools.CustomComboBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_checkNo = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.grid_AR = new OBCS.CustomGrid();
            this.dateTimePickerAsOf = new OBCS.Purchase.CustomDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grid_AR)).BeginInit();
            this.SuspendLayout();
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
            this.btn_export.Size = new System.Drawing.Size(113, 42);
            this.btn_export.TabIndex = 540;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(1600, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(113, 42);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbx_x3
            // 
            this.cbx_x3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_x3.AutoSize = true;
            this.cbx_x3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_x3.Location = new System.Drawing.Point(866, 34);
            this.cbx_x3.Name = "cbx_x3";
            this.cbx_x3.Size = new System.Drawing.Size(174, 19);
            this.cbx_x3.TabIndex = 725;
            this.cbx_x3.Text = "Including PO created on x3";
            this.cbx_x3.UseVisualStyleBackColor = true;
            // 
            // customLabel6
            // 
            this.customLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel6.Location = new System.Drawing.Point(1043, 11);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(38, 17);
            this.customLabel6.TabIndex = 668;
            this.customLabel6.Text = "From";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFromDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerFromDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFromDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerFromDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(1046, 32);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerFromDate.TabIndex = 667;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(1141, 11);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(22, 17);
            this.customLabel5.TabIndex = 664;
            this.customLabel5.Text = "To";
            // 
            // cbo_SupplierID
            // 
            this.cbo_SupplierID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_SupplierID.BackColor = System.Drawing.Color.White;
            this.cbo_SupplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_SupplierID.FormattingEnabled = true;
            this.cbo_SupplierID.Location = new System.Drawing.Point(1242, 30);
            this.cbo_SupplierID.Name = "cbo_SupplierID";
            this.cbo_SupplierID.Size = new System.Drawing.Size(134, 23);
            this.cbo_SupplierID.TabIndex = 0;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel4.Location = new System.Drawing.Point(358, 12);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(137, 17);
            this.customLabel4.TabIndex = 662;
            this.customLabel4.Text = "Select Date, Sync First";
            this.customLabel4.Visible = false;
            // 
            // cbo_poOpenStatus
            // 
            this.cbo_poOpenStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_poOpenStatus.BackColor = System.Drawing.Color.White;
            this.cbo_poOpenStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_poOpenStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_poOpenStatus.FormattingEnabled = true;
            this.cbo_poOpenStatus.Location = new System.Drawing.Point(1497, 30);
            this.cbo_poOpenStatus.Name = "cbo_poOpenStatus";
            this.cbo_poOpenStatus.Size = new System.Drawing.Size(97, 23);
            this.cbo_poOpenStatus.TabIndex = 2;
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel3.Location = new System.Drawing.Point(1494, 11);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(100, 17);
            this.customLabel3.TabIndex = 660;
            this.customLabel3.Text = "SO Open Status";
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(1379, 11);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(94, 17);
            this.customLabel2.TabIndex = 659;
            this.customLabel2.Text = "Check Number";
            // 
            // txt_checkNo
            // 
            this.txt_checkNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_checkNo.BackColor = System.Drawing.Color.White;
            this.txt_checkNo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_checkNo.Location = new System.Drawing.Point(1382, 32);
            this.txt_checkNo.Name = "txt_checkNo";
            this.txt_checkNo.Size = new System.Drawing.Size(109, 21);
            this.txt_checkNo.TabIndex = 1;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.Location = new System.Drawing.Point(1239, 11);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(73, 17);
            this.customLabel1.TabIndex = 657;
            this.customLabel1.Text = "Supplier ID";
            // 
            // grid_AR
            // 
            this.grid_AR.AllowUserToAddRows = false;
            this.grid_AR.AllowUserToDeleteRows = false;
            this.grid_AR.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_AR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_AR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_AR.BackgroundColor = System.Drawing.Color.White;
            this.grid_AR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_AR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_AR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_AR.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_AR.EnableHeadersVisualStyles = false;
            this.grid_AR.GridColor = System.Drawing.Color.LightGray;
            this.grid_AR.Location = new System.Drawing.Point(15, 60);
            this.grid_AR.MultiSelect = false;
            this.grid_AR.Name = "grid_AR";
            this.grid_AR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_AR.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_AR.RowHeadersVisible = false;
            this.grid_AR.RowTemplate.Height = 19;
            this.grid_AR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_AR.Size = new System.Drawing.Size(1817, 889);
            this.grid_AR.StandardTab = true;
            this.grid_AR.TabIndex = 541;
            this.grid_AR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_AR_CellDoubleClick);
            // 
            // dateTimePickerAsOf
            // 
            this.dateTimePickerAsOf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerAsOf.BackColor = System.Drawing.Color.White;
            this.dateTimePickerAsOf.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerAsOf.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerAsOf.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerAsOf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAsOf.Location = new System.Drawing.Point(1144, 32);
            this.dateTimePickerAsOf.Name = "dateTimePickerAsOf";
            this.dateTimePickerAsOf.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerAsOf.TabIndex = 537;
            this.dateTimePickerAsOf.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // PurchaseOrderExceptionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1844, 961);
            this.Controls.Add(this.cbx_x3);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.cbo_SupplierID);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.cbo_poOpenStatus);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_checkNo);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.grid_AR);
            this.Controls.Add(this.dateTimePickerAsOf);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_search);
            this.Name = "PurchaseOrderExceptionReport";
            this.Text = "Purchase Order Exception Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_AR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Purchase.CustomDateTimePicker dateTimePickerAsOf;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_search;
        private CustomGrid grid_AR;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_checkNo;
        private Tools.CustomComboBox cbo_poOpenStatus;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomComboBox cbo_SupplierID;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomLabel customLabel6;
        private Purchase.CustomDateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.CheckBox cbx_x3;
    }
}