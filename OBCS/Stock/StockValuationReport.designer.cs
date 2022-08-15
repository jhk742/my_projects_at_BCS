namespace OBCS.Stock
{
    partial class StockValuationReport
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
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_totalAmount = new OBCS.CustomTextBox();
            this.customLabel12 = new OBCS.Tools.CustomLabel();
            this.DateTimePickerAsof = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.grid_stockValuationReport = new OBCS.CustomGrid();
            this.label31 = new System.Windows.Forms.Label();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.cbo_storageSite = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.cbo_status = new OBCS.Tools.CustomComboBox();
            this.txt_TotalQty = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stockValuationReport)).BeginInit();
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
            this.btn_export.Location = new System.Drawing.Point(999, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(121, 50);
            this.btn_export.TabIndex = 532;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(872, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(121, 50);
            this.btn_Search.TabIndex = 527;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_totalAmount
            // 
            this.txt_totalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalAmount.BackColor = System.Drawing.Color.White;
            this.txt_totalAmount.Enabled = false;
            this.txt_totalAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalAmount.Location = new System.Drawing.Point(1018, 903);
            this.txt_totalAmount.Name = "txt_totalAmount";
            this.txt_totalAmount.Size = new System.Drawing.Size(102, 21);
            this.txt_totalAmount.TabIndex = 544;
            this.txt_totalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel12
            // 
            this.customLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel12.AutoSize = true;
            this.customLabel12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel12.Location = new System.Drawing.Point(1038, 884);
            this.customLabel12.Name = "customLabel12";
            this.customLabel12.Size = new System.Drawing.Size(82, 15);
            this.customLabel12.TabIndex = 543;
            this.customLabel12.Text = " Total Amount";
            // 
            // DateTimePickerAsof
            // 
            this.DateTimePickerAsof.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerAsof.BackColor = System.Drawing.Color.White;
            this.DateTimePickerAsof.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerAsof.CustomFormat = " MM/dd/yyyy";
            this.DateTimePickerAsof.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerAsof.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerAsof.Location = new System.Drawing.Point(630, 40);
            this.DateTimePickerAsof.Name = "DateTimePickerAsof";
            this.DateTimePickerAsof.Size = new System.Drawing.Size(106, 21);
            this.DateTimePickerAsof.TabIndex = 540;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(627, 20);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(88, 15);
            this.customLabel5.TabIndex = 539;
            this.customLabel5.Text = "Reference Date";
            // 
            // grid_stockValuationReport
            // 
            this.grid_stockValuationReport.AllowUserToAddRows = false;
            this.grid_stockValuationReport.AllowUserToDeleteRows = false;
            this.grid_stockValuationReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_stockValuationReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_stockValuationReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_stockValuationReport.BackgroundColor = System.Drawing.Color.White;
            this.grid_stockValuationReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stockValuationReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_stockValuationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_stockValuationReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_stockValuationReport.EnableHeadersVisualStyles = false;
            this.grid_stockValuationReport.GridColor = System.Drawing.Color.LightGray;
            this.grid_stockValuationReport.Location = new System.Drawing.Point(12, 68);
            this.grid_stockValuationReport.MultiSelect = false;
            this.grid_stockValuationReport.Name = "grid_stockValuationReport";
            this.grid_stockValuationReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_stockValuationReport.RowHeadersVisible = false;
            this.grid_stockValuationReport.RowTemplate.Height = 19;
            this.grid_stockValuationReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_stockValuationReport.Size = new System.Drawing.Size(1108, 813);
            this.grid_stockValuationReport.StandardTab = true;
            this.grid_stockValuationReport.TabIndex = 531;
            this.grid_stockValuationReport.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_DeliveryOS_DataBindingComplete);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(12, 28);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(272, 33);
            this.label31.TabIndex = 747;
            this.label31.Text = "Stock Valuation Report";
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(739, 20);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(27, 15);
            this.customLabel4.TabIndex = 748;
            this.customLabel4.Text = "Site";
            // 
            // cbo_storageSite
            // 
            this.cbo_storageSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_storageSite.BackColor = System.Drawing.Color.White;
            this.cbo_storageSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_storageSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_storageSite.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_storageSite.FormattingEnabled = true;
            this.cbo_storageSite.Location = new System.Drawing.Point(742, 38);
            this.cbo_storageSite.Name = "cbo_storageSite";
            this.cbo_storageSite.Size = new System.Drawing.Size(80, 23);
            this.cbo_storageSite.TabIndex = 749;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(825, 21);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(41, 15);
            this.customLabel1.TabIndex = 750;
            this.customLabel1.Text = "Status";
            // 
            // cbo_status
            // 
            this.cbo_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_status.BackColor = System.Drawing.Color.White;
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_status.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Location = new System.Drawing.Point(828, 39);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(38, 23);
            this.cbo_status.TabIndex = 751;
            // 
            // txt_TotalQty
            // 
            this.txt_TotalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalQty.BackColor = System.Drawing.Color.White;
            this.txt_TotalQty.Enabled = false;
            this.txt_TotalQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_TotalQty.Location = new System.Drawing.Point(910, 903);
            this.txt_TotalQty.Name = "txt_TotalQty";
            this.txt_TotalQty.Size = new System.Drawing.Size(102, 21);
            this.txt_TotalQty.TabIndex = 753;
            this.txt_TotalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(925, 884);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(87, 15);
            this.customLabel2.TabIndex = 752;
            this.customLabel2.Text = " Total Quantity";
            // 
            // StockValuationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 929);
            this.Controls.Add(this.txt_TotalQty);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.cbo_status);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.cbo_storageSite);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txt_totalAmount);
            this.Controls.Add(this.customLabel12);
            this.Controls.Add(this.DateTimePickerAsof);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.grid_stockValuationReport);
            this.Controls.Add(this.btn_Search);
            this.Name = "StockValuationReport";
            this.Text = "Stock Valuation Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_stockValuationReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_export;
        private CustomGrid grid_stockValuationReport;
        private System.Windows.Forms.Button btn_Search;
        private Purchase.CustomDateTimePicker DateTimePickerAsof;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomLabel customLabel12;
        private CustomTextBox txt_totalAmount;
        private System.Windows.Forms.Label label31;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomComboBox cbo_storageSite;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomComboBox cbo_status;
        private CustomTextBox txt_TotalQty;
        private Tools.CustomLabel customLabel2;
    }
}