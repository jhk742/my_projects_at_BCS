namespace OBCS.Lists
{
    partial class PriceListEntry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_searchProductID = new OBCS.Tools.CustomComboBox();
            this.cbo_searchCustomerID = new OBCS.Tools.CustomComboBox();
            this.txt_price = new OBCS.CustomTextBox();
            this.grid_EntryDetail = new OBCS.CustomGrid();
            this.cbo_productID = new OBCS.Tools.CustomComboBox();
            this.grid_EntryHeader = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_EntryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_EntryHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(823, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 665;
            this.label4.Text = "Product ID";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(947, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 671;
            this.label7.Text = "Price";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(364, 9);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(95, 39);
            this.btn_refresh.TabIndex = 674;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Visible = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(1014, 9);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(74, 39);
            this.btn_add.TabIndex = 675;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 668;
            this.label6.Text = "Customer ID";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(174, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(84, 39);
            this.btn_search.TabIndex = 676;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 679;
            this.label1.Text = "Product ID";
            // 
            // cbo_searchProductID
            // 
            this.cbo_searchProductID.BackColor = System.Drawing.Color.White;
            this.cbo_searchProductID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_searchProductID.FormattingEnabled = true;
            this.cbo_searchProductID.Location = new System.Drawing.Point(465, 25);
            this.cbo_searchProductID.Name = "cbo_searchProductID";
            this.cbo_searchProductID.Size = new System.Drawing.Size(118, 23);
            this.cbo_searchProductID.TabIndex = 678;
            this.cbo_searchProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_searchProductID_KeyPress);
            // 
            // cbo_searchCustomerID
            // 
            this.cbo_searchCustomerID.BackColor = System.Drawing.Color.White;
            this.cbo_searchCustomerID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_searchCustomerID.FormattingEnabled = true;
            this.cbo_searchCustomerID.Location = new System.Drawing.Point(12, 25);
            this.cbo_searchCustomerID.Name = "cbo_searchCustomerID";
            this.cbo_searchCustomerID.Size = new System.Drawing.Size(156, 23);
            this.cbo_searchCustomerID.TabIndex = 677;
            this.cbo_searchCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_searchCustomerID_KeyPress);
            // 
            // txt_price
            // 
            this.txt_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_price.Location = new System.Drawing.Point(950, 27);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(58, 21);
            this.txt_price.TabIndex = 672;
            // 
            // grid_EntryDetail
            // 
            this.grid_EntryDetail.AllowUserToAddRows = false;
            this.grid_EntryDetail.AllowUserToDeleteRows = false;
            this.grid_EntryDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_EntryDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_EntryDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_EntryDetail.BackgroundColor = System.Drawing.Color.White;
            this.grid_EntryDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_EntryDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_EntryDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_EntryDetail.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_EntryDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_EntryDetail.EnableHeadersVisualStyles = false;
            this.grid_EntryDetail.GridColor = System.Drawing.Color.LightGray;
            this.grid_EntryDetail.Location = new System.Drawing.Point(465, 54);
            this.grid_EntryDetail.MultiSelect = false;
            this.grid_EntryDetail.Name = "grid_EntryDetail";
            this.grid_EntryDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_EntryDetail.RowHeadersVisible = false;
            this.grid_EntryDetail.RowTemplate.Height = 19;
            this.grid_EntryDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_EntryDetail.Size = new System.Drawing.Size(623, 804);
            this.grid_EntryDetail.StandardTab = true;
            this.grid_EntryDetail.TabIndex = 670;
            this.grid_EntryDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_EntryDetail_CellClick);
            this.grid_EntryDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_EntryDetail_CellValueChanged);
            // 
            // cbo_productID
            // 
            this.cbo_productID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_productID.BackColor = System.Drawing.Color.White;
            this.cbo_productID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_productID.FormattingEnabled = true;
            this.cbo_productID.Location = new System.Drawing.Point(826, 25);
            this.cbo_productID.Name = "cbo_productID";
            this.cbo_productID.Size = new System.Drawing.Size(118, 23);
            this.cbo_productID.TabIndex = 666;
            // 
            // grid_EntryHeader
            // 
            this.grid_EntryHeader.AllowUserToAddRows = false;
            this.grid_EntryHeader.AllowUserToDeleteRows = false;
            this.grid_EntryHeader.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_EntryHeader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_EntryHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_EntryHeader.BackgroundColor = System.Drawing.Color.White;
            this.grid_EntryHeader.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_EntryHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grid_EntryHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_EntryHeader.DefaultCellStyle = dataGridViewCellStyle12;
            this.grid_EntryHeader.EnableHeadersVisualStyles = false;
            this.grid_EntryHeader.GridColor = System.Drawing.Color.LightGray;
            this.grid_EntryHeader.Location = new System.Drawing.Point(12, 54);
            this.grid_EntryHeader.MultiSelect = false;
            this.grid_EntryHeader.Name = "grid_EntryHeader";
            this.grid_EntryHeader.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_EntryHeader.RowHeadersVisible = false;
            this.grid_EntryHeader.RowTemplate.Height = 19;
            this.grid_EntryHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_EntryHeader.Size = new System.Drawing.Size(447, 804);
            this.grid_EntryHeader.StandardTab = true;
            this.grid_EntryHeader.TabIndex = 647;
            this.grid_EntryHeader.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_EntryHeader_RowEnter);
            // 
            // PriceListEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 870);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_searchCustomerID);
            this.Controls.Add(this.cbo_productID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_searchProductID);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.grid_EntryDetail);
            this.Controls.Add(this.grid_EntryHeader);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "PriceListEntry";
            this.Text = "Price List Entry";
            ((System.ComponentModel.ISupportInitialize)(this.grid_EntryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_EntryHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomGrid grid_EntryHeader;
        private Tools.CustomComboBox cbo_productID;
        private System.Windows.Forms.Label label4;
        private CustomGrid grid_EntryDetail;
        private CustomTextBox txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_NCustomer;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_search;
        private Tools.CustomComboBox cbo_searchCustomerID;
        private Tools.CustomComboBox cbo_searchProductID;
        private System.Windows.Forms.Label label1;
    }
}