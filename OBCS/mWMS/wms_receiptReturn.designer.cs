namespace OBCS.mWMS
{
    partial class wms_receiptReturn
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
            this.grid_detail = new OBCS.CustomGrid();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_productID = new OBCS.CustomTextBox();
            this.cbo_supplierID = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_productDesc = new OBCS.CustomTextBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_availableQty = new OBCS.CustomTextBox();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_returnQty = new OBCS.CustomTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.txt_price = new OBCS.CustomTextBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_amount = new OBCS.CustomTextBox();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.txt_LOTNumber = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_detail
            // 
            this.grid_detail.AllowUserToAddRows = false;
            this.grid_detail.AllowUserToDeleteRows = false;
            this.grid_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_detail.BackgroundColor = System.Drawing.Color.White;
            this.grid_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_detail.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_detail.EnableHeadersVisualStyles = false;
            this.grid_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_detail.Location = new System.Drawing.Point(12, 12);
            this.grid_detail.MultiSelect = false;
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_detail.RowHeadersVisible = false;
            this.grid_detail.RowTemplate.Height = 19;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(450, 732);
            this.grid_detail.StandardTab = true;
            this.grid_detail.TabIndex = 645;
            this.grid_detail.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detail_CellEnter);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(468, 227);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(260, 31);
            this.btn_confirm.TabIndex = 646;
            this.btn_confirm.Text = "Confirm Supplier Return";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(468, 180);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(68, 15);
            this.customLabel2.TabIndex = 648;
            this.customLabel2.Text = "Supplier ID";
            // 
            // txt_productID
            // 
            this.txt_productID.BackColor = System.Drawing.Color.White;
            this.txt_productID.Enabled = false;
            this.txt_productID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_productID.Location = new System.Drawing.Point(468, 30);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(126, 21);
            this.txt_productID.TabIndex = 647;
            // 
            // cbo_supplierID
            // 
            this.cbo_supplierID.BackColor = System.Drawing.Color.White;
            this.cbo_supplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_supplierID.FormattingEnabled = true;
            this.cbo_supplierID.Location = new System.Drawing.Point(468, 198);
            this.cbo_supplierID.Name = "cbo_supplierID";
            this.cbo_supplierID.Size = new System.Drawing.Size(260, 23);
            this.cbo_supplierID.TabIndex = 649;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(468, 12);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(65, 15);
            this.customLabel1.TabIndex = 650;
            this.customLabel1.Text = "Product ID";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(468, 54);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(79, 15);
            this.customLabel3.TabIndex = 652;
            this.customLabel3.Text = "Product Desc";
            // 
            // txt_productDesc
            // 
            this.txt_productDesc.BackColor = System.Drawing.Color.White;
            this.txt_productDesc.Enabled = false;
            this.txt_productDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_productDesc.Location = new System.Drawing.Point(468, 72);
            this.txt_productDesc.Name = "txt_productDesc";
            this.txt_productDesc.Size = new System.Drawing.Size(544, 21);
            this.txt_productDesc.TabIndex = 651;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(468, 96);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(83, 15);
            this.customLabel4.TabIndex = 654;
            this.customLabel4.Text = "Available Qty.";
            // 
            // txt_availableQty
            // 
            this.txt_availableQty.BackColor = System.Drawing.Color.White;
            this.txt_availableQty.Enabled = false;
            this.txt_availableQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_availableQty.Location = new System.Drawing.Point(468, 114);
            this.txt_availableQty.Name = "txt_availableQty";
            this.txt_availableQty.Size = new System.Drawing.Size(83, 21);
            this.txt_availableQty.TabIndex = 653;
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(468, 138);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(70, 15);
            this.customLabel5.TabIndex = 656;
            this.customLabel5.Text = "Return Qty.";
            // 
            // txt_returnQty
            // 
            this.txt_returnQty.BackColor = System.Drawing.Color.White;
            this.txt_returnQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_returnQty.Location = new System.Drawing.Point(468, 156);
            this.txt_returnQty.Name = "txt_returnQty";
            this.txt_returnQty.Size = new System.Drawing.Size(83, 21);
            this.txt_returnQty.TabIndex = 655;
            this.txt_returnQty.Leave += new System.EventHandler(this.txt_returnQty_Leave);
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(557, 138);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(35, 15);
            this.customLabel6.TabIndex = 658;
            this.customLabel6.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.Enabled = false;
            this.txt_price.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_price.Location = new System.Drawing.Point(557, 156);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(83, 21);
            this.txt_price.TabIndex = 657;
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(646, 138);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(49, 15);
            this.customLabel7.TabIndex = 660;
            this.customLabel7.Text = "Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Enabled = false;
            this.txt_amount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_amount.Location = new System.Drawing.Point(646, 156);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(83, 21);
            this.txt_amount.TabIndex = 659;
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(600, 12);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(73, 15);
            this.customLabel8.TabIndex = 662;
            this.customLabel8.Text = "LOT Number";
            // 
            // txt_LOTNumber
            // 
            this.txt_LOTNumber.BackColor = System.Drawing.Color.White;
            this.txt_LOTNumber.Enabled = false;
            this.txt_LOTNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_LOTNumber.Location = new System.Drawing.Point(600, 30);
            this.txt_LOTNumber.Name = "txt_LOTNumber";
            this.txt_LOTNumber.Size = new System.Drawing.Size(129, 21);
            this.txt_LOTNumber.TabIndex = 661;
            // 
            // wms_receiptReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 756);
            this.Controls.Add(this.customLabel8);
            this.Controls.Add(this.txt_LOTNumber);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.txt_returnQty);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_availableQty);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.txt_productDesc);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.cbo_supplierID);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.grid_detail);
            this.Name = "wms_receiptReturn";
            this.Text = "Receipt Return WMS";
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomGrid grid_detail;
        private System.Windows.Forms.Button btn_confirm;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_productID;
        private Tools.CustomComboBox cbo_supplierID;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_productDesc;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_availableQty;
        private Tools.CustomLabel customLabel5;
        private CustomTextBox txt_returnQty;
        private Tools.CustomLabel customLabel6;
        private CustomTextBox txt_price;
        private Tools.CustomLabel customLabel7;
        private CustomTextBox txt_amount;
        private Tools.CustomLabel customLabel8;
        private CustomTextBox txt_LOTNumber;
    }
}