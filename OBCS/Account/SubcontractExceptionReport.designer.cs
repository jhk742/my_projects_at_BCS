namespace OBCS.Account
{
    partial class SubcontractExceptionReport
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
            this.cbo_POStatus = new OBCS.Tools.CustomComboBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerFromDate = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.cbo_Supplier = new OBCS.Tools.CustomComboBox();
            this.cbo_APStatus = new OBCS.Tools.CustomComboBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.grid_Sub = new OBCS.CustomGrid();
            this.dateTimePickerAsOf = new OBCS.Purchase.CustomDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Sub)).BeginInit();
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
            this.btn_export.Location = new System.Drawing.Point(1718, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(113, 42);
            this.btn_export.TabIndex = 672;
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
            this.btn_search.Location = new System.Drawing.Point(1599, 11);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(113, 42);
            this.btn_search.TabIndex = 670;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbo_POStatus
            // 
            this.cbo_POStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_POStatus.BackColor = System.Drawing.Color.White;
            this.cbo_POStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_POStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_POStatus.FormattingEnabled = true;
            this.cbo_POStatus.Location = new System.Drawing.Point(1393, 30);
            this.cbo_POStatus.Name = "cbo_POStatus";
            this.cbo_POStatus.Size = new System.Drawing.Size(97, 23);
            this.cbo_POStatus.TabIndex = 680;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(1390, 11);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(65, 17);
            this.customLabel2.TabIndex = 681;
            this.customLabel2.Text = "PO Status";
            // 
            // customLabel6
            // 
            this.customLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel6.Location = new System.Drawing.Point(1077, 11);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(38, 17);
            this.customLabel6.TabIndex = 679;
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
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(1080, 32);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerFromDate.TabIndex = 678;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(1175, 11);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(22, 17);
            this.customLabel5.TabIndex = 677;
            this.customLabel5.Text = "To";
            // 
            // cbo_Supplier
            // 
            this.cbo_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Supplier.BackColor = System.Drawing.Color.White;
            this.cbo_Supplier.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Supplier.FormattingEnabled = true;
            this.cbo_Supplier.Location = new System.Drawing.Point(1276, 30);
            this.cbo_Supplier.Name = "cbo_Supplier";
            this.cbo_Supplier.Size = new System.Drawing.Size(111, 23);
            this.cbo_Supplier.TabIndex = 667;
            // 
            // cbo_APStatus
            // 
            this.cbo_APStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_APStatus.BackColor = System.Drawing.Color.White;
            this.cbo_APStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_APStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_APStatus.FormattingEnabled = true;
            this.cbo_APStatus.Location = new System.Drawing.Point(1496, 30);
            this.cbo_APStatus.Name = "cbo_APStatus";
            this.cbo_APStatus.Size = new System.Drawing.Size(97, 23);
            this.cbo_APStatus.TabIndex = 669;
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel3.Location = new System.Drawing.Point(1493, 11);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(64, 17);
            this.customLabel3.TabIndex = 676;
            this.customLabel3.Text = "AP Status";
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.Location = new System.Drawing.Point(1273, 11);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(57, 17);
            this.customLabel1.TabIndex = 674;
            this.customLabel1.Text = "Supplier";
            // 
            // grid_Sub
            // 
            this.grid_Sub.AllowUserToAddRows = false;
            this.grid_Sub.AllowUserToDeleteRows = false;
            this.grid_Sub.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Sub.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Sub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Sub.BackgroundColor = System.Drawing.Color.White;
            this.grid_Sub.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Sub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Sub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Sub.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Sub.EnableHeadersVisualStyles = false;
            this.grid_Sub.GridColor = System.Drawing.Color.LightGray;
            this.grid_Sub.Location = new System.Drawing.Point(14, 60);
            this.grid_Sub.MultiSelect = false;
            this.grid_Sub.Name = "grid_Sub";
            this.grid_Sub.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Sub.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Sub.RowHeadersVisible = false;
            this.grid_Sub.RowTemplate.Height = 19;
            this.grid_Sub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Sub.Size = new System.Drawing.Size(1817, 889);
            this.grid_Sub.StandardTab = true;
            this.grid_Sub.TabIndex = 673;
            this.grid_Sub.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_Sub_DataBindingComplete);
            // 
            // dateTimePickerAsOf
            // 
            this.dateTimePickerAsOf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerAsOf.BackColor = System.Drawing.Color.White;
            this.dateTimePickerAsOf.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerAsOf.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerAsOf.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerAsOf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAsOf.Location = new System.Drawing.Point(1178, 32);
            this.dateTimePickerAsOf.Name = "dateTimePickerAsOf";
            this.dateTimePickerAsOf.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerAsOf.TabIndex = 671;
            // 
            // SubcontractExceptionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1844, 961);
            this.Controls.Add(this.cbo_POStatus);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.cbo_Supplier);
            this.Controls.Add(this.cbo_APStatus);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.grid_Sub);
            this.Controls.Add(this.dateTimePickerAsOf);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_search);
            this.Name = "SubcontractExceptionReport";
            this.Text = "Subcontract Exception Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Sub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.CustomLabel customLabel6;
        private Purchase.CustomDateTimePicker dateTimePickerFromDate;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomComboBox cbo_Supplier;
        private Tools.CustomComboBox cbo_APStatus;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel1;
        private CustomGrid grid_Sub;
        private Purchase.CustomDateTimePicker dateTimePickerAsOf;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_search;
        private Tools.CustomComboBox cbo_POStatus;
        private Tools.CustomLabel customLabel2;
    }
}