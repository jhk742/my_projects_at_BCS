namespace OBCS.mWMS
{
    partial class wms_shipmentReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_notReturned = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.grid_Router = new OBCS.CustomGrid();
            this.grid_header = new OBCS.CustomGrid();
            this.txt_deliveryNumber = new OBCS.CustomTextBox();
            this.lbl_deliveryNumber = new OBCS.Tools.CustomLabel();
            this.customLabel29 = new OBCS.Tools.CustomLabel();
            this.cbo_RM = new OBCS.Tools.CustomComboBox();
            this.txt_qty = new OBCS.CustomTextBox();
            this.txt_addAmount = new OBCS.CustomTextBox();
            this.customLabel34 = new OBCS.Tools.CustomLabel();
            this.customLabel28 = new OBCS.Tools.CustomLabel();
            this.cbo_itemID = new OBCS.Tools.CustomComboBox();
            this.txt_itemDesc = new OBCS.CustomTextBox();
            this.txt_price = new OBCS.CustomTextBox();
            this.customLabel25 = new OBCS.Tools.CustomLabel();
            this.customLabel27 = new OBCS.Tools.CustomLabel();
            this.customLabel24 = new OBCS.Tools.CustomLabel();
            this.grid_detail = new OBCS.CustomGrid();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Router)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.customLabel29);
            this.panel3.Controls.Add(this.cbo_RM);
            this.panel3.Controls.Add(this.txt_qty);
            this.panel3.Controls.Add(this.btn_addItem);
            this.panel3.Controls.Add(this.txt_addAmount);
            this.panel3.Controls.Add(this.customLabel34);
            this.panel3.Controls.Add(this.customLabel28);
            this.panel3.Controls.Add(this.cbo_itemID);
            this.panel3.Controls.Add(this.txt_itemDesc);
            this.panel3.Controls.Add(this.txt_price);
            this.panel3.Controls.Add(this.customLabel25);
            this.panel3.Controls.Add(this.customLabel27);
            this.panel3.Controls.Add(this.customLabel24);
            this.panel3.Location = new System.Drawing.Point(872, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 56);
            this.panel3.TabIndex = 620;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_addItem.FlatAppearance.BorderSize = 0;
            this.btn_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.Location = new System.Drawing.Point(914, 8);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(57, 41);
            this.btn_addItem.TabIndex = 10;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = false;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_deliveryNumber);
            this.panel1.Controls.Add(this.lbl_deliveryNumber);
            this.panel1.Controls.Add(this.btn_notReturned);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_confirm);
            this.panel1.Location = new System.Drawing.Point(872, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 52);
            this.panel1.TabIndex = 622;
            // 
            // btn_notReturned
            // 
            this.btn_notReturned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_notReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_notReturned.FlatAppearance.BorderSize = 0;
            this.btn_notReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notReturned.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notReturned.ForeColor = System.Drawing.Color.White;
            this.btn_notReturned.Location = new System.Drawing.Point(647, 8);
            this.btn_notReturned.Name = "btn_notReturned";
            this.btn_notReturned.Size = new System.Drawing.Size(124, 34);
            this.btn_notReturned.TabIndex = 510;
            this.btn_notReturned.Text = "Not returned";
            this.btn_notReturned.UseVisualStyleBackColor = false;
            this.btn_notReturned.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(892, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 509;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(777, 8);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(109, 34);
            this.btn_confirm.TabIndex = 508;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // grid_Router
            // 
            this.grid_Router.AllowUserToAddRows = false;
            this.grid_Router.AllowUserToDeleteRows = false;
            this.grid_Router.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Router.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Router.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_Router.BackgroundColor = System.Drawing.Color.White;
            this.grid_Router.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Router.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Router.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Router.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Router.EnableHeadersVisualStyles = false;
            this.grid_Router.GridColor = System.Drawing.Color.LightGray;
            this.grid_Router.Location = new System.Drawing.Point(12, 12);
            this.grid_Router.MultiSelect = false;
            this.grid_Router.Name = "grid_Router";
            this.grid_Router.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_Router.RowHeadersVisible = false;
            this.grid_Router.RowTemplate.Height = 19;
            this.grid_Router.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Router.Size = new System.Drawing.Size(123, 860);
            this.grid_Router.StandardTab = true;
            this.grid_Router.TabIndex = 624;
            // 
            // grid_header
            // 
            this.grid_header.AllowUserToAddRows = false;
            this.grid_header.AllowUserToDeleteRows = false;
            this.grid_header.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_header.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_header.BackgroundColor = System.Drawing.Color.White;
            this.grid_header.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_header.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_header.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_header.EnableHeadersVisualStyles = false;
            this.grid_header.GridColor = System.Drawing.Color.LightGray;
            this.grid_header.Location = new System.Drawing.Point(141, 12);
            this.grid_header.MultiSelect = false;
            this.grid_header.Name = "grid_header";
            this.grid_header.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_header.RowHeadersVisible = false;
            this.grid_header.RowTemplate.Height = 19;
            this.grid_header.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_header.Size = new System.Drawing.Size(725, 860);
            this.grid_header.StandardTab = true;
            this.grid_header.TabIndex = 623;
            this.grid_header.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_header_CellEnter);
            // 
            // txt_deliveryNumber
            // 
            this.txt_deliveryNumber.BackColor = System.Drawing.Color.White;
            this.txt_deliveryNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_deliveryNumber.Enabled = false;
            this.txt_deliveryNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_deliveryNumber.Location = new System.Drawing.Point(12, 22);
            this.txt_deliveryNumber.Name = "txt_deliveryNumber";
            this.txt_deliveryNumber.Size = new System.Drawing.Size(117, 21);
            this.txt_deliveryNumber.TabIndex = 618;
            // 
            // lbl_deliveryNumber
            // 
            this.lbl_deliveryNumber.AutoSize = true;
            this.lbl_deliveryNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deliveryNumber.Location = new System.Drawing.Point(9, 4);
            this.lbl_deliveryNumber.Name = "lbl_deliveryNumber";
            this.lbl_deliveryNumber.Size = new System.Drawing.Size(98, 15);
            this.lbl_deliveryNumber.TabIndex = 617;
            this.lbl_deliveryNumber.Text = "Delivery Number";
            // 
            // customLabel29
            // 
            this.customLabel29.AutoSize = true;
            this.customLabel29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel29.Location = new System.Drawing.Point(9, 8);
            this.customLabel29.Name = "customLabel29";
            this.customLabel29.Size = new System.Drawing.Size(65, 15);
            this.customLabel29.TabIndex = 439;
            this.customLabel29.Text = "Product ID";
            // 
            // cbo_RM
            // 
            this.cbo_RM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_RM.BackColor = System.Drawing.Color.White;
            this.cbo_RM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_RM.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_RM.FormattingEnabled = true;
            this.cbo_RM.Location = new System.Drawing.Point(648, 26);
            this.cbo_RM.Name = "cbo_RM";
            this.cbo_RM.Size = new System.Drawing.Size(48, 23);
            this.cbo_RM.TabIndex = 616;
            this.cbo_RM.Leave += new System.EventHandler(this.cbo_RM_Leave);
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_qty.BackColor = System.Drawing.Color.White;
            this.txt_qty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_qty.Location = new System.Drawing.Point(776, 28);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(46, 21);
            this.txt_qty.TabIndex = 5;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty.Leave += new System.EventHandler(this.txt_qty_Leave);
            // 
            // txt_addAmount
            // 
            this.txt_addAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addAmount.BackColor = System.Drawing.Color.White;
            this.txt_addAmount.Enabled = false;
            this.txt_addAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_addAmount.Location = new System.Drawing.Point(828, 28);
            this.txt_addAmount.Name = "txt_addAmount";
            this.txt_addAmount.Size = new System.Drawing.Size(80, 21);
            this.txt_addAmount.TabIndex = 301;
            this.txt_addAmount.TabStop = false;
            this.txt_addAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel34
            // 
            this.customLabel34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel34.AutoSize = true;
            this.customLabel34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel34.Location = new System.Drawing.Point(645, 10);
            this.customLabel34.Name = "customLabel34";
            this.customLabel34.Size = new System.Drawing.Size(48, 15);
            this.customLabel34.TabIndex = 446;
            this.customLabel34.Text = "Remark";
            // 
            // customLabel28
            // 
            this.customLabel28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel28.AutoSize = true;
            this.customLabel28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel28.Location = new System.Drawing.Point(786, 10);
            this.customLabel28.Name = "customLabel28";
            this.customLabel28.Size = new System.Drawing.Size(26, 15);
            this.customLabel28.TabIndex = 440;
            this.customLabel28.Text = "Qty";
            // 
            // cbo_itemID
            // 
            this.cbo_itemID.BackColor = System.Drawing.Color.White;
            this.cbo_itemID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_itemID.FormattingEnabled = true;
            this.cbo_itemID.Location = new System.Drawing.Point(12, 26);
            this.cbo_itemID.Name = "cbo_itemID";
            this.cbo_itemID.Size = new System.Drawing.Size(98, 23);
            this.cbo_itemID.TabIndex = 4;
            this.cbo_itemID.SelectedValueChanged += new System.EventHandler(this.cbo_itemID_SelectedValueChanged);
            // 
            // txt_itemDesc
            // 
            this.txt_itemDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_itemDesc.BackColor = System.Drawing.Color.White;
            this.txt_itemDesc.Enabled = false;
            this.txt_itemDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_itemDesc.Location = new System.Drawing.Point(116, 28);
            this.txt_itemDesc.Name = "txt_itemDesc";
            this.txt_itemDesc.Size = new System.Drawing.Size(526, 21);
            this.txt_itemDesc.TabIndex = 615;
            // 
            // txt_price
            // 
            this.txt_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_price.Location = new System.Drawing.Point(702, 28);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(68, 21);
            this.txt_price.TabIndex = 6;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_price.Leave += new System.EventHandler(this.txt_price_Leave);
            // 
            // customLabel25
            // 
            this.customLabel25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel25.AutoSize = true;
            this.customLabel25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel25.Location = new System.Drawing.Point(859, 10);
            this.customLabel25.Name = "customLabel25";
            this.customLabel25.Size = new System.Drawing.Size(49, 15);
            this.customLabel25.TabIndex = 445;
            this.customLabel25.Text = "Amount";
            // 
            // customLabel27
            // 
            this.customLabel27.AutoSize = true;
            this.customLabel27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel27.Location = new System.Drawing.Point(113, 10);
            this.customLabel27.Name = "customLabel27";
            this.customLabel27.Size = new System.Drawing.Size(79, 15);
            this.customLabel27.TabIndex = 441;
            this.customLabel27.Text = "Product Desc";
            // 
            // customLabel24
            // 
            this.customLabel24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel24.AutoSize = true;
            this.customLabel24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel24.Location = new System.Drawing.Point(735, 10);
            this.customLabel24.Name = "customLabel24";
            this.customLabel24.Size = new System.Drawing.Size(35, 15);
            this.customLabel24.TabIndex = 444;
            this.customLabel24.Text = "Price";
            // 
            // grid_detail
            // 
            this.grid_detail.AllowUserToAddRows = false;
            this.grid_detail.AllowUserToDeleteRows = false;
            this.grid_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grid_detail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_detail.EnableHeadersVisualStyles = false;
            this.grid_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_detail.Location = new System.Drawing.Point(872, 132);
            this.grid_detail.MultiSelect = false;
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_detail.RowHeadersVisible = false;
            this.grid_detail.RowTemplate.Height = 19;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(984, 742);
            this.grid_detail.StandardTab = true;
            this.grid_detail.TabIndex = 619;
            this.grid_detail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detail_CellEndEdit);
            // 
            // wms_shipmentReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 884);
            this.Controls.Add(this.grid_Router);
            this.Controls.Add(this.grid_header);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grid_detail);
            this.MinimumSize = new System.Drawing.Size(1800, 39);
            this.Name = "wms_shipmentReturn";
            this.Text = "Shipment Return WMS";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Router)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Tools.CustomLabel customLabel29;
        private Tools.CustomComboBox cbo_RM;
        private CustomTextBox txt_qty;
        private System.Windows.Forms.Button btn_addItem;
        private CustomTextBox txt_addAmount;
        private Tools.CustomLabel customLabel34;
        private Tools.CustomLabel customLabel28;
        private Tools.CustomComboBox cbo_itemID;
        private CustomTextBox txt_itemDesc;
        private CustomTextBox txt_price;
        private Tools.CustomLabel customLabel25;
        private Tools.CustomLabel customLabel27;
        private Tools.CustomLabel customLabel24;
        private CustomGrid grid_detail;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox txt_deliveryNumber;
        private Tools.CustomLabel lbl_deliveryNumber;
        private System.Windows.Forms.Button btn_notReturned;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_confirm;
        private CustomGrid grid_header;
        private CustomGrid grid_Router;
    }
}