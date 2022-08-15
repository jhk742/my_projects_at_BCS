namespace OBCS.Sales
{
    partial class PackageNutLabelPrint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label24 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_labelType = new OBCS.CustomTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbx_printName = new System.Windows.Forms.CheckBox();
            this.cbx_customLabel = new System.Windows.Forms.CheckBox();
            this.txt_nutMarkup = new OBCS.CustomTextBox();
            this.cbx_showRetailPrice = new System.Windows.Forms.CheckBox();
            this.cbx_printAddress = new System.Windows.Forms.CheckBox();
            this.cbx_byMarkup = new System.Windows.Forms.CheckBox();
            this.cbx_byCustomerPrice = new System.Windows.Forms.CheckBox();
            this.txt_storeAddress = new OBCS.CustomTextBox();
            this.txt_storeName = new OBCS.CustomTextBox();
            this.Date = new OBCS.Tools.CustomLabel();
            this.dateTimePicker_date = new OBCS.Purchase.CustomDateTimePicker();
            this.grid_DETAIL = new OBCS.CustomGrid();
            this.grid_Header = new OBCS.CustomGrid();
            this.cbx_all = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DETAIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Header)).BeginInit();
            this.SuspendLayout();
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1520, 27);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 15);
            this.label24.TabIndex = 791;
            this.label24.Text = "Option";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_labelType);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.cbx_printName);
            this.panel2.Controls.Add(this.cbx_customLabel);
            this.panel2.Controls.Add(this.txt_nutMarkup);
            this.panel2.Controls.Add(this.cbx_showRetailPrice);
            this.panel2.Controls.Add(this.cbx_printAddress);
            this.panel2.Controls.Add(this.cbx_byMarkup);
            this.panel2.Controls.Add(this.cbx_byCustomerPrice);
            this.panel2.Location = new System.Drawing.Point(1514, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 249);
            this.panel2.TabIndex = 792;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 799;
            this.label2.Text = "Label Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 793;
            this.label1.Text = "Customer Markup";
            // 
            // txt_labelType
            // 
            this.txt_labelType.BackColor = System.Drawing.Color.White;
            this.txt_labelType.Enabled = false;
            this.txt_labelType.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_labelType.Location = new System.Drawing.Point(8, 217);
            this.txt_labelType.MaxLength = 30;
            this.txt_labelType.Name = "txt_labelType";
            this.txt_labelType.Size = new System.Drawing.Size(139, 21);
            this.txt_labelType.TabIndex = 798;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(92, 178);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 15);
            this.label22.TabIndex = 791;
            this.label22.Text = "%";
            // 
            // cbx_printName
            // 
            this.cbx_printName.AutoSize = true;
            this.cbx_printName.Enabled = false;
            this.cbx_printName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_printName.Location = new System.Drawing.Point(8, 35);
            this.cbx_printName.Name = "cbx_printName";
            this.cbx_printName.Size = new System.Drawing.Size(87, 19);
            this.cbx_printName.TabIndex = 784;
            this.cbx_printName.Text = "Print Name";
            this.cbx_printName.UseVisualStyleBackColor = true;
            // 
            // cbx_customLabel
            // 
            this.cbx_customLabel.AutoSize = true;
            this.cbx_customLabel.Enabled = false;
            this.cbx_customLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_customLabel.Location = new System.Drawing.Point(8, 10);
            this.cbx_customLabel.Name = "cbx_customLabel";
            this.cbx_customLabel.Size = new System.Drawing.Size(99, 19);
            this.cbx_customLabel.TabIndex = 789;
            this.cbx_customLabel.Text = "Custom Label";
            this.cbx_customLabel.UseVisualStyleBackColor = true;
            // 
            // txt_nutMarkup
            // 
            this.txt_nutMarkup.BackColor = System.Drawing.Color.White;
            this.txt_nutMarkup.Enabled = false;
            this.txt_nutMarkup.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_nutMarkup.Location = new System.Drawing.Point(8, 175);
            this.txt_nutMarkup.MaxLength = 30;
            this.txt_nutMarkup.Name = "txt_nutMarkup";
            this.txt_nutMarkup.Size = new System.Drawing.Size(78, 21);
            this.txt_nutMarkup.TabIndex = 714;
            this.txt_nutMarkup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbx_showRetailPrice
            // 
            this.cbx_showRetailPrice.AutoSize = true;
            this.cbx_showRetailPrice.Enabled = false;
            this.cbx_showRetailPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_showRetailPrice.Location = new System.Drawing.Point(8, 85);
            this.cbx_showRetailPrice.Name = "cbx_showRetailPrice";
            this.cbx_showRetailPrice.Size = new System.Drawing.Size(121, 19);
            this.cbx_showRetailPrice.TabIndex = 788;
            this.cbx_showRetailPrice.Text = "Show Retail Price";
            this.cbx_showRetailPrice.UseVisualStyleBackColor = true;
            // 
            // cbx_printAddress
            // 
            this.cbx_printAddress.AutoSize = true;
            this.cbx_printAddress.Enabled = false;
            this.cbx_printAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_printAddress.Location = new System.Drawing.Point(8, 60);
            this.cbx_printAddress.Name = "cbx_printAddress";
            this.cbx_printAddress.Size = new System.Drawing.Size(100, 19);
            this.cbx_printAddress.TabIndex = 787;
            this.cbx_printAddress.Text = "Print Address";
            this.cbx_printAddress.UseVisualStyleBackColor = true;
            // 
            // cbx_byMarkup
            // 
            this.cbx_byMarkup.AutoSize = true;
            this.cbx_byMarkup.Enabled = false;
            this.cbx_byMarkup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_byMarkup.Location = new System.Drawing.Point(8, 135);
            this.cbx_byMarkup.Name = "cbx_byMarkup";
            this.cbx_byMarkup.Size = new System.Drawing.Size(85, 19);
            this.cbx_byMarkup.TabIndex = 785;
            this.cbx_byMarkup.Text = "By Markup";
            this.cbx_byMarkup.UseVisualStyleBackColor = true;
            // 
            // cbx_byCustomerPrice
            // 
            this.cbx_byCustomerPrice.AutoSize = true;
            this.cbx_byCustomerPrice.Enabled = false;
            this.cbx_byCustomerPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_byCustomerPrice.Location = new System.Drawing.Point(8, 110);
            this.cbx_byCustomerPrice.Name = "cbx_byCustomerPrice";
            this.cbx_byCustomerPrice.Size = new System.Drawing.Size(125, 19);
            this.cbx_byCustomerPrice.TabIndex = 786;
            this.cbx_byCustomerPrice.Text = "By Customer Price";
            this.cbx_byCustomerPrice.UseVisualStyleBackColor = true;
            // 
            // txt_storeAddress
            // 
            this.txt_storeAddress.BackColor = System.Drawing.Color.White;
            this.txt_storeAddress.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_storeAddress.Location = new System.Drawing.Point(943, 9);
            this.txt_storeAddress.MaxLength = 50;
            this.txt_storeAddress.Name = "txt_storeAddress";
            this.txt_storeAddress.Size = new System.Drawing.Size(282, 21);
            this.txt_storeAddress.TabIndex = 794;
            this.txt_storeAddress.Visible = false;
            // 
            // txt_storeName
            // 
            this.txt_storeName.BackColor = System.Drawing.Color.White;
            this.txt_storeName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_storeName.Location = new System.Drawing.Point(749, 9);
            this.txt_storeName.MaxLength = 50;
            this.txt_storeName.Name = "txt_storeName";
            this.txt_storeName.Size = new System.Drawing.Size(188, 21);
            this.txt_storeName.TabIndex = 793;
            this.txt_storeName.Visible = false;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(12, 9);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(38, 15);
            this.Date.TabIndex = 363;
            this.Date.Text = "Date :";
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.BackColor = System.Drawing.Color.White;
            this.dateTimePicker_date.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_date.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker_date.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(56, 6);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(85, 21);
            this.dateTimePicker_date.TabIndex = 362;
            this.dateTimePicker_date.ValueChanged += new System.EventHandler(this.dateTimePicker_date_ValueChanged);
            // 
            // grid_DETAIL
            // 
            this.grid_DETAIL.AllowUserToAddRows = false;
            this.grid_DETAIL.AllowUserToDeleteRows = false;
            this.grid_DETAIL.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_DETAIL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_DETAIL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_DETAIL.BackgroundColor = System.Drawing.Color.White;
            this.grid_DETAIL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_DETAIL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_DETAIL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_DETAIL.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid_DETAIL.EnableHeadersVisualStyles = false;
            this.grid_DETAIL.GridColor = System.Drawing.Color.LightGray;
            this.grid_DETAIL.Location = new System.Drawing.Point(749, 34);
            this.grid_DETAIL.MultiSelect = false;
            this.grid_DETAIL.Name = "grid_DETAIL";
            this.grid_DETAIL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_DETAIL.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid_DETAIL.RowHeadersVisible = false;
            this.grid_DETAIL.RowTemplate.Height = 19;
            this.grid_DETAIL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_DETAIL.Size = new System.Drawing.Size(759, 874);
            this.grid_DETAIL.StandardTab = true;
            this.grid_DETAIL.TabIndex = 2;
            this.grid_DETAIL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DETAIL_CellDoubleClick);
            this.grid_DETAIL.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DETAIL_CellEnter);
            this.grid_DETAIL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_DETAIL_KeyDown);
            // 
            // grid_Header
            // 
            this.grid_Header.AllowUserToAddRows = false;
            this.grid_Header.AllowUserToDeleteRows = false;
            this.grid_Header.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Header.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.grid_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_Header.BackgroundColor = System.Drawing.Color.White;
            this.grid_Header.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Header.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grid_Header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Header.DefaultCellStyle = dataGridViewCellStyle15;
            this.grid_Header.EnableHeadersVisualStyles = false;
            this.grid_Header.GridColor = System.Drawing.Color.LightGray;
            this.grid_Header.Location = new System.Drawing.Point(12, 33);
            this.grid_Header.MultiSelect = false;
            this.grid_Header.Name = "grid_Header";
            this.grid_Header.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Header.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grid_Header.RowHeadersVisible = false;
            this.grid_Header.RowTemplate.Height = 19;
            this.grid_Header.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Header.Size = new System.Drawing.Size(731, 875);
            this.grid_Header.StandardTab = true;
            this.grid_Header.TabIndex = 1;
            this.grid_Header.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DRIVER_CellClick);
            this.grid_Header.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Header_CellEnter);
            // 
            // cbx_all
            // 
            this.cbx_all.AutoSize = true;
            this.cbx_all.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_all.Location = new System.Drawing.Point(638, 11);
            this.cbx_all.Name = "cbx_all";
            this.cbx_all.Size = new System.Drawing.Size(105, 19);
            this.cbx_all.TabIndex = 796;
            this.cbx_all.Text = "View All Order";
            this.cbx_all.UseVisualStyleBackColor = true;
            this.cbx_all.CheckedChanged += new System.EventHandler(this.cbx_all_CheckedChanged);
            // 
            // PackageNutLabelPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1684, 920);
            this.Controls.Add(this.cbx_all);
            this.Controls.Add(this.txt_storeAddress);
            this.Controls.Add(this.txt_storeName);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.grid_DETAIL);
            this.Controls.Add(this.grid_Header);
            this.MinimumSize = new System.Drawing.Size(1700, 959);
            this.Name = "PackageNutLabelPrint";
            this.Text = "Package Nut Label Print";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DETAIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomGrid grid_Header;
        private CustomGrid grid_DETAIL;
        private Tools.CustomLabel Date;
        private Purchase.CustomDateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox cbx_printName;
        private System.Windows.Forms.CheckBox cbx_customLabel;
        private CustomTextBox txt_nutMarkup;
        private System.Windows.Forms.CheckBox cbx_showRetailPrice;
        private System.Windows.Forms.CheckBox cbx_printAddress;
        private System.Windows.Forms.CheckBox cbx_byMarkup;
        private System.Windows.Forms.CheckBox cbx_byCustomerPrice;
        private CustomTextBox txt_storeName;
        private CustomTextBox txt_storeAddress;
        private System.Windows.Forms.Label label2;
        private CustomTextBox txt_labelType;
        private System.Windows.Forms.CheckBox cbx_all;
    }
}