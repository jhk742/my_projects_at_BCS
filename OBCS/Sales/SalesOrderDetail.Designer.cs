namespace OBCS.Sales
{
    partial class SalesOrderDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_product = new OBCS.CustomGrid();
            this.txt_searchProductID = new OBCS.CustomTextBox();
            this.txt_searchProductDesc = new OBCS.CustomTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbo_salesRep = new OBCS.Tools.CustomComboBox();
            this.txt_shipPhone = new OBCS.CustomTextBox();
            this.txt_billPhone = new OBCS.CustomTextBox();
            this.txt_orderID = new OBCS.CustomTextBox();
            this.customLabel10 = new OBCS.Tools.CustomLabel();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_credit = new OBCS.CustomTextBox();
            this.cbo_customerID = new OBCS.Tools.CustomComboBox();
            this.customLabel9 = new OBCS.Tools.CustomLabel();
            this.txt_shipStateCode = new OBCS.CustomTextBox();
            this.txt_shipCity = new OBCS.CustomTextBox();
            this.txt_shipAddress2 = new OBCS.CustomTextBox();
            this.txt_billPostalCode = new OBCS.CustomTextBox();
            this.txt_billStateCode = new OBCS.CustomTextBox();
            this.txt_billCity = new OBCS.CustomTextBox();
            this.txt_salesRep = new OBCS.CustomTextBox();
            this.txt_billAddress2 = new OBCS.CustomTextBox();
            this.txt_billAddress1 = new OBCS.CustomTextBox();
            this.txt_orderMemo = new OBCS.CustomTextBox();
            this.customLabel17 = new OBCS.Tools.CustomLabel();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.cbo_site = new OBCS.Tools.CustomComboBox();
            this.txt_shipAddress1 = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_shipPostalCode = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_company = new OBCS.CustomTextBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.btn_send = new System.Windows.Forms.Button();
            this.cbx_SearchBrand = new OBCS.Tools.CustomComboBox();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.txt_totalAmount = new OBCS.CustomTextBox();
            this.txt_orderAmount = new OBCS.CustomTextBox();
            this.customLabel15 = new OBCS.Tools.CustomLabel();
            this.txt_creditAmount = new OBCS.CustomTextBox();
            this.customLabel14 = new OBCS.Tools.CustomLabel();
            this.grid_OrderDetail = new OBCS.CustomGrid();
            this.btn_export = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerDate.Enabled = false;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(571, 24);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(86, 22);
            this.dateTimePickerDate.TabIndex = 642;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 789;
            this.label8.Text = "Product Description";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(5, 5);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 15);
            this.label34.TabIndex = 788;
            this.label34.Text = "Product ID";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(1064, 331);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(40, 15);
            this.label45.TabIndex = 790;
            this.label45.Text = "Brand";
            this.label45.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.grid_product);
            this.panel1.Controls.Add(this.txt_searchProductID);
            this.panel1.Controls.Add(this.txt_searchProductDesc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 611);
            this.panel1.TabIndex = 0;
            // 
            // grid_product
            // 
            this.grid_product.AllowUserToAddRows = false;
            this.grid_product.AllowUserToDeleteRows = false;
            this.grid_product.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_product.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_product.BackgroundColor = System.Drawing.Color.White;
            this.grid_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_product.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_product.EnableHeadersVisualStyles = false;
            this.grid_product.GridColor = System.Drawing.Color.LightGray;
            this.grid_product.Location = new System.Drawing.Point(7, 50);
            this.grid_product.MultiSelect = false;
            this.grid_product.Name = "grid_product";
            this.grid_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_product.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_product.RowHeadersVisible = false;
            this.grid_product.RowTemplate.Height = 19;
            this.grid_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_product.Size = new System.Drawing.Size(650, 553);
            this.grid_product.StandardTab = true;
            this.grid_product.TabIndex = 11;
            this.grid_product.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_product_CellDoubleClick);
            this.grid_product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_product_KeyDown);
            // 
            // txt_searchProductID
            // 
            this.txt_searchProductID.BackColor = System.Drawing.Color.White;
            this.txt_searchProductID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_searchProductID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchProductID.Location = new System.Drawing.Point(7, 23);
            this.txt_searchProductID.MaxLength = 30;
            this.txt_searchProductID.Name = "txt_searchProductID";
            this.txt_searchProductID.Size = new System.Drawing.Size(122, 21);
            this.txt_searchProductID.TabIndex = 1;
            this.txt_searchProductID.Enter += new System.EventHandler(this.searchProduct_Enter);
            this.txt_searchProductID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_searchProductID_KeyDown);
            this.txt_searchProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searchProductID_KeyPress);
            // 
            // txt_searchProductDesc
            // 
            this.txt_searchProductDesc.BackColor = System.Drawing.Color.White;
            this.txt_searchProductDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchProductDesc.Location = new System.Drawing.Point(135, 23);
            this.txt_searchProductDesc.MaxLength = 30;
            this.txt_searchProductDesc.Name = "txt_searchProductDesc";
            this.txt_searchProductDesc.Size = new System.Drawing.Size(522, 21);
            this.txt_searchProductDesc.TabIndex = 2;
            this.txt_searchProductDesc.Enter += new System.EventHandler(this.searchProduct_Enter);
            this.txt_searchProductDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searchProductDesc_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbo_salesRep);
            this.panel2.Controls.Add(this.txt_shipPhone);
            this.panel2.Controls.Add(this.txt_billPhone);
            this.panel2.Controls.Add(this.txt_orderID);
            this.panel2.Controls.Add(this.customLabel10);
            this.panel2.Controls.Add(this.customLabel4);
            this.panel2.Controls.Add(this.txt_credit);
            this.panel2.Controls.Add(this.cbo_customerID);
            this.panel2.Controls.Add(this.customLabel9);
            this.panel2.Controls.Add(this.txt_shipStateCode);
            this.panel2.Controls.Add(this.txt_shipCity);
            this.panel2.Controls.Add(this.txt_shipAddress2);
            this.panel2.Controls.Add(this.txt_billPostalCode);
            this.panel2.Controls.Add(this.txt_billStateCode);
            this.panel2.Controls.Add(this.txt_billCity);
            this.panel2.Controls.Add(this.txt_salesRep);
            this.panel2.Controls.Add(this.txt_billAddress2);
            this.panel2.Controls.Add(this.txt_billAddress1);
            this.panel2.Controls.Add(this.txt_orderMemo);
            this.panel2.Controls.Add(this.customLabel17);
            this.panel2.Controls.Add(this.customLabel5);
            this.panel2.Controls.Add(this.cbo_site);
            this.panel2.Controls.Add(this.txt_shipAddress1);
            this.panel2.Controls.Add(this.customLabel2);
            this.panel2.Controls.Add(this.txt_shipPostalCode);
            this.panel2.Controls.Add(this.customLabel1);
            this.panel2.Controls.Add(this.customLabel3);
            this.panel2.Controls.Add(this.txt_company);
            this.panel2.Controls.Add(this.customLabel7);
            this.panel2.Controls.Add(this.customLabel6);
            this.panel2.Controls.Add(this.dateTimePickerDate);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 209);
            this.panel2.TabIndex = 0;
            // 
            // cbo_salesRep
            // 
            this.cbo_salesRep.BackColor = System.Drawing.Color.White;
            this.cbo_salesRep.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_salesRep.Location = new System.Drawing.Point(552, 52);
            this.cbo_salesRep.Name = "cbo_salesRep";
            this.cbo_salesRep.Size = new System.Drawing.Size(50, 23);
            this.cbo_salesRep.TabIndex = 799;
            this.cbo_salesRep.Visible = false;
            // 
            // txt_shipPhone
            // 
            this.txt_shipPhone.BackColor = System.Drawing.Color.White;
            this.txt_shipPhone.Enabled = false;
            this.txt_shipPhone.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_shipPhone.Location = new System.Drawing.Point(268, 131);
            this.txt_shipPhone.Name = "txt_shipPhone";
            this.txt_shipPhone.Size = new System.Drawing.Size(254, 21);
            this.txt_shipPhone.TabIndex = 800;
            this.txt_shipPhone.TabStop = false;
            // 
            // txt_billPhone
            // 
            this.txt_billPhone.BackColor = System.Drawing.Color.White;
            this.txt_billPhone.Enabled = false;
            this.txt_billPhone.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_billPhone.Location = new System.Drawing.Point(8, 131);
            this.txt_billPhone.Name = "txt_billPhone";
            this.txt_billPhone.Size = new System.Drawing.Size(254, 21);
            this.txt_billPhone.TabIndex = 799;
            this.txt_billPhone.TabStop = false;
            // 
            // txt_orderID
            // 
            this.txt_orderID.BackColor = System.Drawing.Color.White;
            this.txt_orderID.Enabled = false;
            this.txt_orderID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_orderID.Location = new System.Drawing.Point(7, 25);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(89, 21);
            this.txt_orderID.TabIndex = 797;
            this.txt_orderID.TabStop = false;
            // 
            // customLabel10
            // 
            this.customLabel10.AutoSize = true;
            this.customLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel10.Location = new System.Drawing.Point(5, 9);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.Size = new System.Drawing.Size(59, 15);
            this.customLabel10.TabIndex = 796;
            this.customLabel10.Text = "ORDER ID";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(8, 55);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(46, 15);
            this.customLabel4.TabIndex = 621;
            this.customLabel4.Text = "BILL TO";
            // 
            // txt_credit
            // 
            this.txt_credit.BackColor = System.Drawing.Color.White;
            this.txt_credit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_credit.Location = new System.Drawing.Point(524, 177);
            this.txt_credit.Name = "txt_credit";
            this.txt_credit.Size = new System.Drawing.Size(42, 21);
            this.txt_credit.TabIndex = 4;
            this.txt_credit.TabStop = false;
            this.txt_credit.Text = "0";
            this.txt_credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_credit.TextChanged += new System.EventHandler(this.txt_credit_TextChanged);
            this.txt_credit.Leave += new System.EventHandler(this.txt_credit_Leave);
            // 
            // cbo_customerID
            // 
            this.cbo_customerID.BackColor = System.Drawing.Color.White;
            this.cbo_customerID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_customerID.FormattingEnabled = true;
            this.cbo_customerID.Location = new System.Drawing.Point(102, 23);
            this.cbo_customerID.Name = "cbo_customerID";
            this.cbo_customerID.Size = new System.Drawing.Size(160, 23);
            this.cbo_customerID.TabIndex = 0;
            this.cbo_customerID.SelectedValueChanged += new System.EventHandler(this.cbo_customerID_SelectedValueChanged);
            this.cbo_customerID.Leave += new System.EventHandler(this.cbo_customerID_Leave);
            // 
            // customLabel9
            // 
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.Location = new System.Drawing.Point(521, 161);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(45, 15);
            this.customLabel9.TabIndex = 792;
            this.customLabel9.Text = "CREDIT";
            // 
            // txt_shipStateCode
            // 
            this.txt_shipStateCode.BackColor = System.Drawing.Color.White;
            this.txt_shipStateCode.Enabled = false;
            this.txt_shipStateCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_shipStateCode.Location = new System.Drawing.Point(397, 111);
            this.txt_shipStateCode.MaxLength = 2;
            this.txt_shipStateCode.Name = "txt_shipStateCode";
            this.txt_shipStateCode.Size = new System.Drawing.Size(50, 21);
            this.txt_shipStateCode.TabIndex = 629;
            this.txt_shipStateCode.TabStop = false;
            // 
            // txt_shipCity
            // 
            this.txt_shipCity.BackColor = System.Drawing.Color.White;
            this.txt_shipCity.Enabled = false;
            this.txt_shipCity.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_shipCity.Location = new System.Drawing.Point(268, 111);
            this.txt_shipCity.MaxLength = 30;
            this.txt_shipCity.Name = "txt_shipCity";
            this.txt_shipCity.Size = new System.Drawing.Size(130, 21);
            this.txt_shipCity.TabIndex = 628;
            this.txt_shipCity.TabStop = false;
            // 
            // txt_shipAddress2
            // 
            this.txt_shipAddress2.BackColor = System.Drawing.Color.White;
            this.txt_shipAddress2.Enabled = false;
            this.txt_shipAddress2.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_shipAddress2.Location = new System.Drawing.Point(268, 91);
            this.txt_shipAddress2.Name = "txt_shipAddress2";
            this.txt_shipAddress2.Size = new System.Drawing.Size(254, 21);
            this.txt_shipAddress2.TabIndex = 627;
            this.txt_shipAddress2.TabStop = false;
            // 
            // txt_billPostalCode
            // 
            this.txt_billPostalCode.BackColor = System.Drawing.Color.White;
            this.txt_billPostalCode.Enabled = false;
            this.txt_billPostalCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_billPostalCode.Location = new System.Drawing.Point(186, 111);
            this.txt_billPostalCode.MaxLength = 5;
            this.txt_billPostalCode.Name = "txt_billPostalCode";
            this.txt_billPostalCode.Size = new System.Drawing.Size(76, 21);
            this.txt_billPostalCode.TabIndex = 625;
            this.txt_billPostalCode.TabStop = false;
            // 
            // txt_billStateCode
            // 
            this.txt_billStateCode.BackColor = System.Drawing.Color.White;
            this.txt_billStateCode.Enabled = false;
            this.txt_billStateCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_billStateCode.Location = new System.Drawing.Point(137, 111);
            this.txt_billStateCode.MaxLength = 2;
            this.txt_billStateCode.Name = "txt_billStateCode";
            this.txt_billStateCode.Size = new System.Drawing.Size(50, 21);
            this.txt_billStateCode.TabIndex = 624;
            this.txt_billStateCode.TabStop = false;
            // 
            // txt_billCity
            // 
            this.txt_billCity.BackColor = System.Drawing.Color.White;
            this.txt_billCity.Enabled = false;
            this.txt_billCity.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_billCity.Location = new System.Drawing.Point(8, 111);
            this.txt_billCity.MaxLength = 30;
            this.txt_billCity.Name = "txt_billCity";
            this.txt_billCity.Size = new System.Drawing.Size(130, 21);
            this.txt_billCity.TabIndex = 630;
            this.txt_billCity.TabStop = false;
            // 
            // txt_salesRep
            // 
            this.txt_salesRep.BackColor = System.Drawing.Color.White;
            this.txt_salesRep.Enabled = false;
            this.txt_salesRep.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_salesRep.Location = new System.Drawing.Point(523, 25);
            this.txt_salesRep.Name = "txt_salesRep";
            this.txt_salesRep.Size = new System.Drawing.Size(42, 21);
            this.txt_salesRep.TabIndex = 652;
            this.txt_salesRep.TabStop = false;
            this.txt_salesRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_salesRep.Leave += new System.EventHandler(this.txt_salesRep_Leave);
            // 
            // txt_billAddress2
            // 
            this.txt_billAddress2.BackColor = System.Drawing.Color.White;
            this.txt_billAddress2.Enabled = false;
            this.txt_billAddress2.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_billAddress2.Location = new System.Drawing.Point(8, 91);
            this.txt_billAddress2.Name = "txt_billAddress2";
            this.txt_billAddress2.Size = new System.Drawing.Size(254, 21);
            this.txt_billAddress2.TabIndex = 623;
            this.txt_billAddress2.TabStop = false;
            // 
            // txt_billAddress1
            // 
            this.txt_billAddress1.BackColor = System.Drawing.Color.White;
            this.txt_billAddress1.Enabled = false;
            this.txt_billAddress1.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_billAddress1.Location = new System.Drawing.Point(8, 71);
            this.txt_billAddress1.Name = "txt_billAddress1";
            this.txt_billAddress1.Size = new System.Drawing.Size(254, 21);
            this.txt_billAddress1.TabIndex = 620;
            this.txt_billAddress1.TabStop = false;
            // 
            // txt_orderMemo
            // 
            this.txt_orderMemo.BackColor = System.Drawing.Color.White;
            this.txt_orderMemo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_orderMemo.Location = new System.Drawing.Point(7, 177);
            this.txt_orderMemo.Name = "txt_orderMemo";
            this.txt_orderMemo.Size = new System.Drawing.Size(511, 21);
            this.txt_orderMemo.TabIndex = 3;
            this.txt_orderMemo.TabStop = false;
            this.txt_orderMemo.Leave += new System.EventHandler(this.txt_orderMemo_Leave);
            // 
            // customLabel17
            // 
            this.customLabel17.AutoSize = true;
            this.customLabel17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel17.Location = new System.Drawing.Point(5, 161);
            this.customLabel17.Name = "customLabel17";
            this.customLabel17.Size = new System.Drawing.Size(84, 15);
            this.customLabel17.TabIndex = 644;
            this.customLabel17.Text = "ORDER MEMO";
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(265, 53);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(50, 15);
            this.customLabel5.TabIndex = 622;
            this.customLabel5.Text = "SHIP TO";
            // 
            // cbo_site
            // 
            this.cbo_site.BackColor = System.Drawing.Color.White;
            this.cbo_site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_site.Enabled = false;
            this.cbo_site.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_site.FormattingEnabled = true;
            this.cbo_site.Location = new System.Drawing.Point(571, 175);
            this.cbo_site.Name = "cbo_site";
            this.cbo_site.Size = new System.Drawing.Size(85, 23);
            this.cbo_site.TabIndex = 638;
            // 
            // txt_shipAddress1
            // 
            this.txt_shipAddress1.BackColor = System.Drawing.Color.White;
            this.txt_shipAddress1.Enabled = false;
            this.txt_shipAddress1.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_shipAddress1.Location = new System.Drawing.Point(268, 71);
            this.txt_shipAddress1.Name = "txt_shipAddress1";
            this.txt_shipAddress1.Size = new System.Drawing.Size(254, 21);
            this.txt_shipAddress1.TabIndex = 626;
            this.txt_shipAddress1.TabStop = false;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(569, 161);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(88, 15);
            this.customLabel2.TabIndex = 636;
            this.customLabel2.Text = "SHIPMENT SITE";
            // 
            // txt_shipPostalCode
            // 
            this.txt_shipPostalCode.BackColor = System.Drawing.Color.White;
            this.txt_shipPostalCode.Enabled = false;
            this.txt_shipPostalCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_shipPostalCode.Location = new System.Drawing.Point(446, 111);
            this.txt_shipPostalCode.MaxLength = 5;
            this.txt_shipPostalCode.Name = "txt_shipPostalCode";
            this.txt_shipPostalCode.Size = new System.Drawing.Size(76, 21);
            this.txt_shipPostalCode.TabIndex = 631;
            this.txt_shipPostalCode.TabStop = false;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(99, 6);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(82, 15);
            this.customLabel1.TabIndex = 632;
            this.customLabel1.Text = "CUSTOMER ID";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(265, 7);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(61, 15);
            this.customLabel3.TabIndex = 634;
            this.customLabel3.Text = "COMPANY";
            // 
            // txt_company
            // 
            this.txt_company.BackColor = System.Drawing.Color.White;
            this.txt_company.Enabled = false;
            this.txt_company.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_company.Location = new System.Drawing.Point(268, 25);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(249, 21);
            this.txt_company.TabIndex = 633;
            this.txt_company.TabStop = false;
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(569, 7);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(33, 15);
            this.customLabel7.TabIndex = 643;
            this.customLabel7.Text = "DATE";
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(530, 6);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(27, 15);
            this.customLabel6.TabIndex = 639;
            this.customLabel6.Text = "REP";
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_send.FlatAppearance.BorderSize = 0;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_send.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(1610, 763);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(104, 75);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // cbx_SearchBrand
            // 
            this.cbx_SearchBrand.BackColor = System.Drawing.Color.White;
            this.cbx_SearchBrand.Font = new System.Drawing.Font("Arial", 9F);
            this.cbx_SearchBrand.Location = new System.Drawing.Point(1066, 347);
            this.cbx_SearchBrand.Name = "cbx_SearchBrand";
            this.cbx_SearchBrand.Size = new System.Drawing.Size(105, 23);
            this.cbx_SearchBrand.TabIndex = 791;
            this.cbx_SearchBrand.Visible = false;
            // 
            // customLabel8
            // 
            this.customLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(1464, 820);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(34, 15);
            this.customLabel8.TabIndex = 653;
            this.customLabel8.Text = "Total";
            // 
            // txt_totalAmount
            // 
            this.txt_totalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalAmount.BackColor = System.Drawing.Color.White;
            this.txt_totalAmount.Enabled = false;
            this.txt_totalAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalAmount.Location = new System.Drawing.Point(1502, 817);
            this.txt_totalAmount.Name = "txt_totalAmount";
            this.txt_totalAmount.Size = new System.Drawing.Size(102, 21);
            this.txt_totalAmount.TabIndex = 651;
            this.txt_totalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_orderAmount
            // 
            this.txt_orderAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_orderAmount.BackColor = System.Drawing.Color.White;
            this.txt_orderAmount.Enabled = false;
            this.txt_orderAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_orderAmount.Location = new System.Drawing.Point(1502, 763);
            this.txt_orderAmount.Name = "txt_orderAmount";
            this.txt_orderAmount.Size = new System.Drawing.Size(102, 21);
            this.txt_orderAmount.TabIndex = 649;
            this.txt_orderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel15
            // 
            this.customLabel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel15.AutoSize = true;
            this.customLabel15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel15.Location = new System.Drawing.Point(1419, 766);
            this.customLabel15.Name = "customLabel15";
            this.customLabel15.Size = new System.Drawing.Size(77, 15);
            this.customLabel15.TabIndex = 648;
            this.customLabel15.Text = "Order Amont";
            // 
            // txt_creditAmount
            // 
            this.txt_creditAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_creditAmount.BackColor = System.Drawing.Color.White;
            this.txt_creditAmount.Enabled = false;
            this.txt_creditAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_creditAmount.Location = new System.Drawing.Point(1502, 790);
            this.txt_creditAmount.Name = "txt_creditAmount";
            this.txt_creditAmount.Size = new System.Drawing.Size(102, 21);
            this.txt_creditAmount.TabIndex = 647;
            this.txt_creditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_creditAmount.TextChanged += new System.EventHandler(this.txt_creditAmount_TextChanged);
            // 
            // customLabel14
            // 
            this.customLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel14.AutoSize = true;
            this.customLabel14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel14.Location = new System.Drawing.Point(1413, 793);
            this.customLabel14.Name = "customLabel14";
            this.customLabel14.Size = new System.Drawing.Size(85, 15);
            this.customLabel14.TabIndex = 646;
            this.customLabel14.Text = "Credit Amount";
            // 
            // grid_OrderDetail
            // 
            this.grid_OrderDetail.AllowUserToAddRows = false;
            this.grid_OrderDetail.AllowUserToDeleteRows = false;
            this.grid_OrderDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_OrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_OrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_OrderDetail.BackgroundColor = System.Drawing.Color.White;
            this.grid_OrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_OrderDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_OrderDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_OrderDetail.EnableHeadersVisualStyles = false;
            this.grid_OrderDetail.GridColor = System.Drawing.Color.LightGray;
            this.grid_OrderDetail.Location = new System.Drawing.Point(683, 12);
            this.grid_OrderDetail.MultiSelect = false;
            this.grid_OrderDetail.Name = "grid_OrderDetail";
            this.grid_OrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_OrderDetail.RowHeadersVisible = false;
            this.grid_OrderDetail.RowTemplate.Height = 19;
            this.grid_OrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_OrderDetail.Size = new System.Drawing.Size(1141, 745);
            this.grid_OrderDetail.StandardTab = true;
            this.grid_OrderDetail.TabIndex = 618;
            this.grid_OrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_OrderDetail_CellClick);
            this.grid_OrderDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_OrderDetail_CellValueChanged);
            this.grid_OrderDetail.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_OrderDetail_DataBindingComplete);
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(1720, 763);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(104, 75);
            this.btn_export.TabIndex = 3;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // SalesOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1836, 850);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbx_SearchBrand);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.customLabel8);
            this.Controls.Add(this.txt_totalAmount);
            this.Controls.Add(this.txt_orderAmount);
            this.Controls.Add(this.customLabel15);
            this.Controls.Add(this.txt_creditAmount);
            this.Controls.Add(this.customLabel14);
            this.Controls.Add(this.grid_OrderDetail);
            this.Controls.Add(this.panel1);
            this.Name = "SalesOrderDetail";
            this.Text = "Sales Order";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesOrderDetail_FormClosed);
            this.Load += new System.EventHandler(this.ManualOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_product;
        private CustomGrid grid_OrderDetail;
        private CustomTextBox txt_shipAddress1;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel5;
        private CustomTextBox txt_billAddress1;
        private CustomTextBox txt_billAddress2;
        private CustomTextBox txt_billCity;
        private CustomTextBox txt_billStateCode;
        private CustomTextBox txt_billPostalCode;
        private CustomTextBox txt_shipAddress2;
        private CustomTextBox txt_shipCity;
        private CustomTextBox txt_shipStateCode;
        private CustomTextBox txt_shipPostalCode;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_company;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomComboBox cbo_site;
        private Tools.CustomLabel customLabel6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private Tools.CustomLabel customLabel7;
        private CustomTextBox txt_orderMemo;
        private Tools.CustomLabel customLabel17;
        private CustomTextBox txt_totalAmount;
        private CustomTextBox txt_orderAmount;
        private Tools.CustomLabel customLabel15;
        private CustomTextBox txt_creditAmount;
        private Tools.CustomLabel customLabel14;
        private CustomTextBox txt_salesRep;
        private Tools.CustomLabel customLabel8;
        private System.Windows.Forms.Label label8;
        private CustomTextBox txt_searchProductDesc;
        private System.Windows.Forms.Label label34;
        private CustomTextBox txt_searchProductID;
        private CustomTextBox txt_credit;
        private Tools.CustomLabel customLabel9;
        private System.Windows.Forms.Label label45;
        private Tools.CustomComboBox cbx_SearchBrand;
        private System.Windows.Forms.Panel panel1;
        private Tools.CustomComboBox cbo_customerID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_send;
        private CustomTextBox txt_orderID;
        private Tools.CustomLabel customLabel10;
        private CustomTextBox txt_shipPhone;
        private CustomTextBox txt_billPhone;
        private System.Windows.Forms.Button btn_export;
        private Tools.CustomComboBox cbo_salesRep;
    }
}