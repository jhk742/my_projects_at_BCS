namespace OBCS.Purchase
{
    partial class SalesReport
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
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cbo_Brand = new OBCS.Tools.CustomComboBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.grid_Item = new OBCS.CustomGrid();
            this.grid_SalesDepletion = new OBCS.CustomGrid();
            this.dateTimePickerTo = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerFrom = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_BrandName = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_TQty = new OBCS.CustomTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.txt_TAmount = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SalesDepletion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(1247, 13);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(113, 42);
            this.btn_Export.TabIndex = 536;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1128, 13);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(113, 42);
            this.btn_Search.TabIndex = 535;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cbo_Brand
            // 
            this.cbo_Brand.BackColor = System.Drawing.Color.White;
            this.cbo_Brand.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Brand.FormattingEnabled = true;
            this.cbo_Brand.Location = new System.Drawing.Point(12, 33);
            this.cbo_Brand.Name = "cbo_Brand";
            this.cbo_Brand.Size = new System.Drawing.Size(115, 23);
            this.cbo_Brand.TabIndex = 653;
            this.cbo_Brand.SelectedIndexChanged += new System.EventHandler(this.cbo_Brand_SelectedIndexChanged);
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel3.Location = new System.Drawing.Point(9, 14);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(50, 17);
            this.customLabel3.TabIndex = 652;
            this.customLabel3.Text = "BRAND";
            // 
            // grid_Item
            // 
            this.grid_Item.AllowUserToAddRows = false;
            this.grid_Item.AllowUserToDeleteRows = false;
            this.grid_Item.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_Item.BackgroundColor = System.Drawing.Color.White;
            this.grid_Item.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Item.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Item.EnableHeadersVisualStyles = false;
            this.grid_Item.GridColor = System.Drawing.Color.LightGray;
            this.grid_Item.Location = new System.Drawing.Point(12, 61);
            this.grid_Item.MultiSelect = false;
            this.grid_Item.Name = "grid_Item";
            this.grid_Item.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_Item.RowHeadersVisible = false;
            this.grid_Item.RowTemplate.Height = 19;
            this.grid_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Item.Size = new System.Drawing.Size(400, 650);
            this.grid_Item.StandardTab = true;
            this.grid_Item.TabIndex = 538;
            this.grid_Item.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Item_ColumnHeaderMouseClick);
            // 
            // grid_SalesDepletion
            // 
            this.grid_SalesDepletion.AllowUserToAddRows = false;
            this.grid_SalesDepletion.AllowUserToDeleteRows = false;
            this.grid_SalesDepletion.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_SalesDepletion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_SalesDepletion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_SalesDepletion.BackgroundColor = System.Drawing.Color.White;
            this.grid_SalesDepletion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_SalesDepletion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_SalesDepletion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_SalesDepletion.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_SalesDepletion.EnableHeadersVisualStyles = false;
            this.grid_SalesDepletion.GridColor = System.Drawing.Color.LightGray;
            this.grid_SalesDepletion.Location = new System.Drawing.Point(418, 61);
            this.grid_SalesDepletion.MultiSelect = false;
            this.grid_SalesDepletion.Name = "grid_SalesDepletion";
            this.grid_SalesDepletion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_SalesDepletion.RowHeadersVisible = false;
            this.grid_SalesDepletion.RowTemplate.Height = 19;
            this.grid_SalesDepletion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SalesDepletion.Size = new System.Drawing.Size(942, 650);
            this.grid_SalesDepletion.StandardTab = true;
            this.grid_SalesDepletion.TabIndex = 537;
            this.grid_SalesDepletion.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_SalesDepletion_DataBindingComplete);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.BackColor = System.Drawing.Color.White;
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(1028, 34);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(94, 21);
            this.dateTimePickerTo.TabIndex = 532;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(999, 37);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(23, 15);
            this.customLabel2.TabIndex = 534;
            this.customLabel2.Text = "TO";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.BackColor = System.Drawing.Color.White;
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFrom.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(899, 34);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(94, 21);
            this.dateTimePickerFrom.TabIndex = 531;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(853, 37);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(40, 15);
            this.customLabel5.TabIndex = 533;
            this.customLabel5.Text = "FROM";
            // 
            // txt_BrandName
            // 
            this.txt_BrandName.BackColor = System.Drawing.Color.White;
            this.txt_BrandName.Enabled = false;
            this.txt_BrandName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_BrandName.Location = new System.Drawing.Point(133, 33);
            this.txt_BrandName.Name = "txt_BrandName";
            this.txt_BrandName.Size = new System.Drawing.Size(176, 21);
            this.txt_BrandName.TabIndex = 654;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.Location = new System.Drawing.Point(130, 14);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(89, 17);
            this.customLabel1.TabIndex = 655;
            this.customLabel1.Text = "BRAND NAME";
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel4.Location = new System.Drawing.Point(1000, 720);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(62, 17);
            this.customLabel4.TabIndex = 657;
            this.customLabel4.Text = "Total Qty";
            // 
            // txt_TQty
            // 
            this.txt_TQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TQty.BackColor = System.Drawing.Color.White;
            this.txt_TQty.Enabled = false;
            this.txt_TQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_TQty.Location = new System.Drawing.Point(1068, 717);
            this.txt_TQty.Name = "txt_TQty";
            this.txt_TQty.Size = new System.Drawing.Size(79, 21);
            this.txt_TQty.TabIndex = 656;
            this.txt_TQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel6
            // 
            this.customLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel6.Location = new System.Drawing.Point(1153, 719);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(88, 17);
            this.customLabel6.TabIndex = 659;
            this.customLabel6.Text = "Total Amount";
            // 
            // txt_TAmount
            // 
            this.txt_TAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TAmount.BackColor = System.Drawing.Color.White;
            this.txt_TAmount.Enabled = false;
            this.txt_TAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_TAmount.Location = new System.Drawing.Point(1247, 717);
            this.txt_TAmount.Name = "txt_TAmount";
            this.txt_TAmount.Size = new System.Drawing.Size(113, 21);
            this.txt_TAmount.TabIndex = 658;
            this.txt_TAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 749);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.txt_TAmount);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_TQty);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_BrandName);
            this.Controls.Add(this.cbo_Brand);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.grid_Item);
            this.Controls.Add(this.grid_SalesDepletion);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.btn_Search);
            this.Name = "SalesReport";
            this.Text = "Purchase Order Department Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SalesDepletion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_SalesDepletion;
        private CustomDateTimePicker dateTimePickerTo;
        private Tools.CustomLabel customLabel2;
        private CustomDateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btn_Export;
        private Tools.CustomLabel customLabel5;
        private System.Windows.Forms.Button btn_Search;
        private CustomGrid grid_Item;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomComboBox cbo_Brand;
        private CustomTextBox txt_BrandName;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_TQty;
        private Tools.CustomLabel customLabel6;
        private CustomTextBox txt_TAmount;
    }
}