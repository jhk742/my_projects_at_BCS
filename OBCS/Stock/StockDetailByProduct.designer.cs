namespace OBCS.Stock
{
    partial class StockDetailByProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cbo_Brand = new OBCS.Tools.CustomComboBox();
            this.cbo_Category = new OBCS.Tools.CustomComboBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.cbo_ProductID = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.cbo_Status = new OBCS.Tools.CustomComboBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.grid_STOJOU = new OBCS.CustomGrid();
            this.DateTimePickerTo = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.DateTimePickerFrom = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.cbo_Site = new OBCS.Tools.CustomComboBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.customLabel9 = new OBCS.Tools.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_STOJOU)).BeginInit();
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
            this.btn_export.Location = new System.Drawing.Point(1513, 13);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(115, 81);
            this.btn_export.TabIndex = 667;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1393, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(114, 81);
            this.btn_refresh.TabIndex = 666;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cbo_Brand
            // 
            this.cbo_Brand.BackColor = System.Drawing.Color.White;
            this.cbo_Brand.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Brand.FormattingEnabled = true;
            this.cbo_Brand.Location = new System.Drawing.Point(12, 70);
            this.cbo_Brand.Name = "cbo_Brand";
            this.cbo_Brand.Size = new System.Drawing.Size(136, 23);
            this.cbo_Brand.TabIndex = 675;
            // 
            // cbo_Category
            // 
            this.cbo_Category.BackColor = System.Drawing.Color.White;
            this.cbo_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Category.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Category.FormattingEnabled = true;
            this.cbo_Category.Location = new System.Drawing.Point(230, 24);
            this.cbo_Category.Name = "cbo_Category";
            this.cbo_Category.Size = new System.Drawing.Size(118, 23);
            this.cbo_Category.TabIndex = 674;
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(227, 6);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(55, 15);
            this.customLabel7.TabIndex = 673;
            this.customLabel7.Text = "Category";
            // 
            // cbo_ProductID
            // 
            this.cbo_ProductID.BackColor = System.Drawing.Color.White;
            this.cbo_ProductID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_ProductID.FormattingEnabled = true;
            this.cbo_ProductID.Location = new System.Drawing.Point(154, 70);
            this.cbo_ProductID.Name = "cbo_ProductID";
            this.cbo_ProductID.Size = new System.Drawing.Size(194, 23);
            this.cbo_ProductID.TabIndex = 672;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(151, 50);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(65, 15);
            this.customLabel1.TabIndex = 671;
            this.customLabel1.Text = "Product ID";
            // 
            // cbo_Status
            // 
            this.cbo_Status.BackColor = System.Drawing.Color.White;
            this.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Status.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Status.FormattingEnabled = true;
            this.cbo_Status.Location = new System.Drawing.Point(154, 24);
            this.cbo_Status.Name = "cbo_Status";
            this.cbo_Status.Size = new System.Drawing.Size(70, 23);
            this.cbo_Status.TabIndex = 670;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(151, 6);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(41, 15);
            this.customLabel6.TabIndex = 669;
            this.customLabel6.Text = "Status";
            // 
            // grid_STOJOU
            // 
            this.grid_STOJOU.AllowUserToAddRows = false;
            this.grid_STOJOU.AllowUserToDeleteRows = false;
            this.grid_STOJOU.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_STOJOU.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_STOJOU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_STOJOU.BackgroundColor = System.Drawing.Color.White;
            this.grid_STOJOU.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_STOJOU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_STOJOU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_STOJOU.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_STOJOU.EnableHeadersVisualStyles = false;
            this.grid_STOJOU.GridColor = System.Drawing.Color.LightGray;
            this.grid_STOJOU.Location = new System.Drawing.Point(12, 102);
            this.grid_STOJOU.MultiSelect = false;
            this.grid_STOJOU.Name = "grid_STOJOU";
            this.grid_STOJOU.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_STOJOU.RowHeadersVisible = false;
            this.grid_STOJOU.RowTemplate.Height = 19;
            this.grid_STOJOU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_STOJOU.Size = new System.Drawing.Size(1616, 771);
            this.grid_STOJOU.StandardTab = true;
            this.grid_STOJOU.TabIndex = 668;
            this.grid_STOJOU.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_STOJOU_DataBindingComplete);
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerTo.BackColor = System.Drawing.Color.White;
            this.DateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerTo.CustomFormat = " MM/dd/yyyy";
            this.DateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerTo.Location = new System.Drawing.Point(1279, 72);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(108, 21);
            this.DateTimePickerTo.TabIndex = 663;
            this.DateTimePickerTo.ValueChanged += new System.EventHandler(this.DateTimePickerTo_ValueChanged);
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(1276, 55);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(19, 15);
            this.customLabel5.TabIndex = 664;
            this.customLabel5.Text = "To";
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerFrom.BackColor = System.Drawing.Color.White;
            this.DateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerFrom.CustomFormat = " MM/dd/yyyy";
            this.DateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerFrom.Location = new System.Drawing.Point(1165, 72);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(108, 21);
            this.DateTimePickerFrom.TabIndex = 663;
            this.DateTimePickerFrom.ValueChanged += new System.EventHandler(this.DateTimePickerFrom_ValueChanged);
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(1162, 55);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(35, 15);
            this.customLabel4.TabIndex = 662;
            this.customLabel4.Text = "From";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(12, 52);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(40, 15);
            this.customLabel3.TabIndex = 658;
            this.customLabel3.Text = "Brand";
            // 
            // cbo_Site
            // 
            this.cbo_Site.BackColor = System.Drawing.Color.White;
            this.cbo_Site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Site.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Site.FormattingEnabled = true;
            this.cbo_Site.Location = new System.Drawing.Point(12, 24);
            this.cbo_Site.Name = "cbo_Site";
            this.cbo_Site.Size = new System.Drawing.Size(136, 23);
            this.cbo_Site.TabIndex = 657;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(12, 6);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(27, 15);
            this.customLabel2.TabIndex = 656;
            this.customLabel2.Text = "Site";
            // 
            // customLabel9
            // 
            this.customLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.Location = new System.Drawing.Point(1162, 32);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(121, 15);
            this.customLabel9.TabIndex = 677;
            this.customLabel9.Text = "(From < Period <= To)";
            // 
            // StockDetailByProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 885);
            this.Controls.Add(this.customLabel9);
            this.Controls.Add(this.cbo_Brand);
            this.Controls.Add(this.cbo_Category);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.cbo_ProductID);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.cbo_Status);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.grid_STOJOU);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.DateTimePickerTo);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.DateTimePickerFrom);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.cbo_Site);
            this.Controls.Add(this.customLabel2);
            this.MinimumSize = new System.Drawing.Size(846, 400);
            this.Name = "StockDetailByProduct";
            this.Text = "Stock Movement Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_STOJOU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Tools.CustomLabel customLabel3;
        private Tools.CustomComboBox cbo_Site;
        private Tools.CustomLabel customLabel2;
        private Purchase.CustomDateTimePicker DateTimePickerTo;
        private Tools.CustomLabel customLabel5;
        private Purchase.CustomDateTimePicker DateTimePickerFrom;
        private Tools.CustomLabel customLabel4;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_refresh;
        private CustomGrid grid_STOJOU;
        private Tools.CustomComboBox cbo_ProductID;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomComboBox cbo_Status;
        private Tools.CustomLabel customLabel6;
        private Tools.CustomComboBox cbo_Category;
        private Tools.CustomLabel customLabel7;
        private Tools.CustomComboBox cbo_Brand;
        private Tools.CustomLabel customLabel9;
    }
}