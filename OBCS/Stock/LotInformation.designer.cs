namespace OBCS.Stock
{
    partial class LotInformation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Lot = new OBCS.CustomTextBox();
            this.customLabel14 = new OBCS.Tools.CustomLabel();
            this.customLabel13 = new OBCS.Tools.CustomLabel();
            this.txt_Memo = new OBCS.CustomTextBox();
            this.txt_ProductPacksizeInfo = new OBCS.CustomTextBox();
            this.txt_ProductDescInfo = new OBCS.CustomTextBox();
            this.txt_Onhand = new OBCS.CustomTextBox();
            this.customLabel12 = new OBCS.Tools.CustomLabel();
            this.txt_Detailed = new OBCS.CustomTextBox();
            this.customLabel11 = new OBCS.Tools.CustomLabel();
            this.txt_Global = new OBCS.CustomTextBox();
            this.customLabel10 = new OBCS.Tools.CustomLabel();
            this.txt_NYWH = new OBCS.CustomTextBox();
            this.customLabel9 = new OBCS.Tools.CustomLabel();
            this.txt_NJWH = new OBCS.CustomTextBox();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.txt_ProductIDInfo = new OBCS.CustomTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.cbo_transaction = new OBCS.Tools.CustomComboBox();
            this.txt_location = new OBCS.CustomTextBox();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.cbo_category = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_ProductID = new OBCS.CustomTextBox();
            this.cbo_Site = new OBCS.Tools.CustomComboBox();
            this.cbo_Status = new OBCS.Tools.CustomComboBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.grid_LOTINFO = new OBCS.CustomGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LOTINFO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_transaction);
            this.groupBox1.Controls.Add(this.txt_location);
            this.groupBox1.Controls.Add(this.customLabel5);
            this.groupBox1.Controls.Add(this.customLabel4);
            this.groupBox1.Controls.Add(this.cbo_category);
            this.groupBox1.Controls.Add(this.customLabel1);
            this.groupBox1.Controls.Add(this.txt_ProductID);
            this.groupBox1.Controls.Add(this.cbo_Site);
            this.groupBox1.Controls.Add(this.cbo_Status);
            this.groupBox1.Controls.Add(this.btn_export);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.customLabel7);
            this.groupBox1.Controls.Add(this.customLabel3);
            this.groupBox1.Controls.Add(this.customLabel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 129);
            this.groupBox1.TabIndex = 672;
            this.groupBox1.TabStop = false;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(696, 71);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(110, 45);
            this.btn_export.TabIndex = 689;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(696, 20);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(110, 45);
            this.btn_refresh.TabIndex = 688;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_Lot);
            this.groupBox2.Controls.Add(this.customLabel14);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.customLabel13);
            this.groupBox2.Controls.Add(this.txt_Memo);
            this.groupBox2.Controls.Add(this.txt_ProductPacksizeInfo);
            this.groupBox2.Controls.Add(this.txt_ProductDescInfo);
            this.groupBox2.Controls.Add(this.txt_Onhand);
            this.groupBox2.Controls.Add(this.customLabel12);
            this.groupBox2.Controls.Add(this.txt_Detailed);
            this.groupBox2.Controls.Add(this.customLabel11);
            this.groupBox2.Controls.Add(this.txt_Global);
            this.groupBox2.Controls.Add(this.customLabel10);
            this.groupBox2.Controls.Add(this.txt_NYWH);
            this.groupBox2.Controls.Add(this.customLabel9);
            this.groupBox2.Controls.Add(this.txt_NJWH);
            this.groupBox2.Controls.Add(this.customLabel8);
            this.groupBox2.Controls.Add(this.txt_ProductIDInfo);
            this.groupBox2.Controls.Add(this.customLabel6);
            this.groupBox2.Location = new System.Drawing.Point(840, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(854, 129);
            this.groupBox2.TabIndex = 673;
            this.groupBox2.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(730, 86);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 30);
            this.btn_Save.TabIndex = 699;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Lot
            // 
            this.txt_Lot.BackColor = System.Drawing.Color.White;
            this.txt_Lot.Enabled = false;
            this.txt_Lot.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Lot.Location = new System.Drawing.Point(730, 57);
            this.txt_Lot.Name = "txt_Lot";
            this.txt_Lot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Lot.Size = new System.Drawing.Size(112, 21);
            this.txt_Lot.TabIndex = 702;
            // 
            // customLabel14
            // 
            this.customLabel14.AutoSize = true;
            this.customLabel14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel14.Location = new System.Drawing.Point(696, 60);
            this.customLabel14.Name = "customLabel14";
            this.customLabel14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel14.Size = new System.Drawing.Size(27, 15);
            this.customLabel14.TabIndex = 701;
            this.customLabel14.Text = "LOT";
            // 
            // customLabel13
            // 
            this.customLabel13.AutoSize = true;
            this.customLabel13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel13.Location = new System.Drawing.Point(247, 98);
            this.customLabel13.Name = "customLabel13";
            this.customLabel13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel13.Size = new System.Drawing.Size(41, 15);
            this.customLabel13.TabIndex = 700;
            this.customLabel13.Text = "Memo";
            // 
            // txt_Memo
            // 
            this.txt_Memo.BackColor = System.Drawing.Color.White;
            this.txt_Memo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Memo.Location = new System.Drawing.Point(292, 95);
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Memo.Size = new System.Drawing.Size(431, 21);
            this.txt_Memo.TabIndex = 699;
            // 
            // txt_ProductPacksizeInfo
            // 
            this.txt_ProductPacksizeInfo.BackColor = System.Drawing.Color.White;
            this.txt_ProductPacksizeInfo.Enabled = false;
            this.txt_ProductPacksizeInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ProductPacksizeInfo.Location = new System.Drawing.Point(730, 19);
            this.txt_ProductPacksizeInfo.Name = "txt_ProductPacksizeInfo";
            this.txt_ProductPacksizeInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ProductPacksizeInfo.Size = new System.Drawing.Size(112, 21);
            this.txt_ProductPacksizeInfo.TabIndex = 692;
            // 
            // txt_ProductDescInfo
            // 
            this.txt_ProductDescInfo.BackColor = System.Drawing.Color.White;
            this.txt_ProductDescInfo.Enabled = false;
            this.txt_ProductDescInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ProductDescInfo.Location = new System.Drawing.Point(214, 19);
            this.txt_ProductDescInfo.Name = "txt_ProductDescInfo";
            this.txt_ProductDescInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ProductDescInfo.Size = new System.Drawing.Size(510, 21);
            this.txt_ProductDescInfo.TabIndex = 691;
            // 
            // txt_Onhand
            // 
            this.txt_Onhand.BackColor = System.Drawing.Color.White;
            this.txt_Onhand.Enabled = false;
            this.txt_Onhand.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Onhand.Location = new System.Drawing.Point(617, 57);
            this.txt_Onhand.Name = "txt_Onhand";
            this.txt_Onhand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Onhand.Size = new System.Drawing.Size(75, 21);
            this.txt_Onhand.TabIndex = 690;
            // 
            // customLabel12
            // 
            this.customLabel12.AutoSize = true;
            this.customLabel12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel12.Location = new System.Drawing.Point(559, 60);
            this.customLabel12.Name = "customLabel12";
            this.customLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel12.Size = new System.Drawing.Size(54, 15);
            this.customLabel12.TabIndex = 689;
            this.customLabel12.Text = "On hand";
            // 
            // txt_Detailed
            // 
            this.txt_Detailed.BackColor = System.Drawing.Color.White;
            this.txt_Detailed.Enabled = false;
            this.txt_Detailed.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Detailed.Location = new System.Drawing.Point(478, 57);
            this.txt_Detailed.Name = "txt_Detailed";
            this.txt_Detailed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Detailed.Size = new System.Drawing.Size(75, 21);
            this.txt_Detailed.TabIndex = 688;
            // 
            // customLabel11
            // 
            this.customLabel11.AutoSize = true;
            this.customLabel11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel11.Location = new System.Drawing.Point(375, 60);
            this.customLabel11.Name = "customLabel11";
            this.customLabel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel11.Size = new System.Drawing.Size(99, 15);
            this.customLabel11.TabIndex = 687;
            this.customLabel11.Text = "Detail allocation";
            // 
            // txt_Global
            // 
            this.txt_Global.BackColor = System.Drawing.Color.White;
            this.txt_Global.Enabled = false;
            this.txt_Global.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Global.Location = new System.Drawing.Point(292, 57);
            this.txt_Global.Name = "txt_Global";
            this.txt_Global.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Global.Size = new System.Drawing.Size(75, 21);
            this.txt_Global.TabIndex = 686;
            // 
            // customLabel10
            // 
            this.customLabel10.AutoSize = true;
            this.customLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel10.Location = new System.Drawing.Point(185, 60);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel10.Size = new System.Drawing.Size(103, 15);
            this.customLabel10.TabIndex = 685;
            this.customLabel10.Text = "Global allocation";
            // 
            // txt_NYWH
            // 
            this.txt_NYWH.BackColor = System.Drawing.Color.White;
            this.txt_NYWH.Enabled = false;
            this.txt_NYWH.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_NYWH.Location = new System.Drawing.Point(88, 95);
            this.txt_NYWH.Name = "txt_NYWH";
            this.txt_NYWH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NYWH.Size = new System.Drawing.Size(89, 21);
            this.txt_NYWH.TabIndex = 684;
            // 
            // customLabel9
            // 
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.Location = new System.Drawing.Point(38, 98);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel9.Size = new System.Drawing.Size(44, 15);
            this.customLabel9.TabIndex = 683;
            this.customLabel9.Text = "NY WH";
            // 
            // txt_NJWH
            // 
            this.txt_NJWH.BackColor = System.Drawing.Color.White;
            this.txt_NJWH.Enabled = false;
            this.txt_NJWH.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_NJWH.Location = new System.Drawing.Point(88, 57);
            this.txt_NJWH.Name = "txt_NJWH";
            this.txt_NJWH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_NJWH.Size = new System.Drawing.Size(89, 21);
            this.txt_NJWH.TabIndex = 682;
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(40, 60);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel8.Size = new System.Drawing.Size(42, 15);
            this.customLabel8.TabIndex = 681;
            this.customLabel8.Text = "NJ WH";
            // 
            // txt_ProductIDInfo
            // 
            this.txt_ProductIDInfo.BackColor = System.Drawing.Color.White;
            this.txt_ProductIDInfo.Enabled = false;
            this.txt_ProductIDInfo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ProductIDInfo.Location = new System.Drawing.Point(88, 19);
            this.txt_ProductIDInfo.Name = "txt_ProductIDInfo";
            this.txt_ProductIDInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ProductIDInfo.Size = new System.Drawing.Size(120, 21);
            this.txt_ProductIDInfo.TabIndex = 680;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(17, 22);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel6.Size = new System.Drawing.Size(65, 15);
            this.customLabel6.TabIndex = 679;
            this.customLabel6.Text = "Product ID";
            // 
            // cbo_transaction
            // 
            this.cbo_transaction.BackColor = System.Drawing.Color.White;
            this.cbo_transaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_transaction.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_transaction.FormattingEnabled = true;
            this.cbo_transaction.Location = new System.Drawing.Point(129, 83);
            this.cbo_transaction.Name = "cbo_transaction";
            this.cbo_transaction.Size = new System.Drawing.Size(189, 23);
            this.cbo_transaction.TabIndex = 698;
            // 
            // txt_location
            // 
            this.txt_location.BackColor = System.Drawing.Color.White;
            this.txt_location.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_location.Location = new System.Drawing.Point(564, 83);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(96, 21);
            this.txt_location.TabIndex = 697;
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(26, 86);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(97, 15);
            this.customLabel5.TabIndex = 696;
            this.customLabel5.Text = "Transaction type";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(502, 86);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(53, 15);
            this.customLabel4.TabIndex = 695;
            this.customLabel4.Text = "Location";
            // 
            // cbo_category
            // 
            this.cbo_category.BackColor = System.Drawing.Color.White;
            this.cbo_category.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(395, 83);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(89, 23);
            this.cbo_category.TabIndex = 694;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(334, 86);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(55, 15);
            this.customLabel1.TabIndex = 693;
            this.customLabel1.Text = "Category";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BackColor = System.Drawing.Color.White;
            this.txt_ProductID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ProductID.Location = new System.Drawing.Point(129, 32);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ProductID.Size = new System.Drawing.Size(189, 21);
            this.txt_ProductID.TabIndex = 692;
            // 
            // cbo_Site
            // 
            this.cbo_Site.BackColor = System.Drawing.Color.White;
            this.cbo_Site.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Site.FormattingEnabled = true;
            this.cbo_Site.Location = new System.Drawing.Point(395, 32);
            this.cbo_Site.Name = "cbo_Site";
            this.cbo_Site.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbo_Site.Size = new System.Drawing.Size(89, 23);
            this.cbo_Site.TabIndex = 691;
            // 
            // cbo_Status
            // 
            this.cbo_Status.BackColor = System.Drawing.Color.White;
            this.cbo_Status.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Status.FormattingEnabled = true;
            this.cbo_Status.Location = new System.Drawing.Point(564, 32);
            this.cbo_Status.Name = "cbo_Status";
            this.cbo_Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbo_Status.Size = new System.Drawing.Size(96, 23);
            this.cbo_Status.TabIndex = 690;
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(26, 35);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel7.Size = new System.Drawing.Size(65, 15);
            this.customLabel7.TabIndex = 687;
            this.customLabel7.Text = "Product ID";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(514, 35);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel3.Size = new System.Drawing.Size(41, 15);
            this.customLabel3.TabIndex = 686;
            this.customLabel3.Text = "Status";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(362, 35);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customLabel2.Size = new System.Drawing.Size(27, 15);
            this.customLabel2.TabIndex = 685;
            this.customLabel2.Text = "Site";
            // 
            // grid_LOTINFO
            // 
            this.grid_LOTINFO.AllowUserToAddRows = false;
            this.grid_LOTINFO.AllowUserToDeleteRows = false;
            this.grid_LOTINFO.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_LOTINFO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_LOTINFO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_LOTINFO.BackgroundColor = System.Drawing.Color.White;
            this.grid_LOTINFO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_LOTINFO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_LOTINFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_LOTINFO.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_LOTINFO.EnableHeadersVisualStyles = false;
            this.grid_LOTINFO.GridColor = System.Drawing.Color.LightGray;
            this.grid_LOTINFO.Location = new System.Drawing.Point(12, 142);
            this.grid_LOTINFO.MultiSelect = false;
            this.grid_LOTINFO.Name = "grid_LOTINFO";
            this.grid_LOTINFO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_LOTINFO.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_LOTINFO.RowHeadersVisible = false;
            this.grid_LOTINFO.RowTemplate.Height = 19;
            this.grid_LOTINFO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_LOTINFO.Size = new System.Drawing.Size(1682, 601);
            this.grid_LOTINFO.StandardTab = true;
            this.grid_LOTINFO.TabIndex = 654;
            this.grid_LOTINFO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_LOTINFO_CellClick);
            this.grid_LOTINFO.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_LOTINFO_DataBindingComplete);
            // 
            // LotInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 755);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_LOTINFO);
            this.MinimumSize = new System.Drawing.Size(1722, 450);
            this.Name = "LotInformation";
            this.Text = "Inventory Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LOTINFO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGrid grid_LOTINFO;
        private System.Windows.Forms.GroupBox groupBox1;
        private Tools.CustomComboBox cbo_transaction;
        private CustomTextBox txt_location;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomComboBox cbo_category;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_ProductID;
        private Tools.CustomComboBox cbo_Site;
        private Tools.CustomComboBox cbo_Status;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_refresh;
        private Tools.CustomLabel customLabel7;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomTextBox txt_ProductPacksizeInfo;
        private CustomTextBox txt_ProductDescInfo;
        private CustomTextBox txt_Onhand;
        private Tools.CustomLabel customLabel12;
        private CustomTextBox txt_Detailed;
        private Tools.CustomLabel customLabel11;
        private CustomTextBox txt_Global;
        private Tools.CustomLabel customLabel10;
        private CustomTextBox txt_NYWH;
        private Tools.CustomLabel customLabel9;
        private CustomTextBox txt_NJWH;
        private Tools.CustomLabel customLabel8;
        private CustomTextBox txt_ProductIDInfo;
        private Tools.CustomLabel customLabel6;
        private Tools.CustomLabel customLabel13;
        private CustomTextBox txt_Memo;
        private System.Windows.Forms.Button btn_Save;
        private CustomTextBox txt_Lot;
        private Tools.CustomLabel customLabel14;
    }
}