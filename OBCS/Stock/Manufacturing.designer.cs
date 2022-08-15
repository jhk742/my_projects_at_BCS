namespace OBCS.Stock
{
    partial class Manufacturing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_CompanyName = new OBCS.CustomTextBox();
            this.customLabel10 = new OBCS.Tools.CustomLabel();
            this.txt_BasePrice = new OBCS.CustomTextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.customLabel9 = new OBCS.Tools.CustomLabel();
            this.txt_Memo = new OBCS.CustomTextBox();
            this.grid_Basket = new OBCS.CustomGrid();
            this.grid_stock = new OBCS.CustomGrid();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.txt_PackSize = new OBCS.CustomTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_IssueQty = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cbo_Company = new OBCS.Tools.CustomComboBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_ProductDesc = new OBCS.CustomTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_availableQty = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_globalAllocated = new OBCS.CustomTextBox();
            this.cbo_product = new OBCS.Tools.CustomComboBox();
            this.dateTimePickerAcc = new System.Windows.Forms.DateTimePicker();
            this.cbo_storageSite = new OBCS.Tools.CustomComboBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.customLabel19 = new OBCS.Tools.CustomLabel();
            this.customLabel18 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.grid_header = new OBCS.CustomGrid();
            this.grid_detail = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.BackColor = System.Drawing.Color.White;
            this.txt_CompanyName.Enabled = false;
            this.txt_CompanyName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_CompanyName.Location = new System.Drawing.Point(861, 22);
            this.txt_CompanyName.MaxLength = 30;
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(212, 21);
            this.txt_CompanyName.TabIndex = 954;
            // 
            // customLabel10
            // 
            this.customLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel10.AutoSize = true;
            this.customLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel10.Location = new System.Drawing.Point(1345, 4);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.Size = new System.Drawing.Size(61, 15);
            this.customLabel10.TabIndex = 953;
            this.customLabel10.Text = "BasePrice";
            this.customLabel10.Visible = false;
            // 
            // txt_BasePrice
            // 
            this.txt_BasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BasePrice.BackColor = System.Drawing.Color.White;
            this.txt_BasePrice.Enabled = false;
            this.txt_BasePrice.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_BasePrice.Location = new System.Drawing.Point(1348, 22);
            this.txt_BasePrice.Name = "txt_BasePrice";
            this.txt_BasePrice.Size = new System.Drawing.Size(80, 21);
            this.txt_BasePrice.TabIndex = 952;
            this.txt_BasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_BasePrice.Visible = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.btn_Save.Enabled = false;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(1685, 854);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 38);
            this.btn_Save.TabIndex = 951;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // customLabel9
            // 
            this.customLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.Location = new System.Drawing.Point(859, 852);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(41, 15);
            this.customLabel9.TabIndex = 950;
            this.customLabel9.Text = "Memo";
            // 
            // txt_Memo
            // 
            this.txt_Memo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Memo.BackColor = System.Drawing.Color.White;
            this.txt_Memo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Memo.Location = new System.Drawing.Point(862, 871);
            this.txt_Memo.MaxLength = 200;
            this.txt_Memo.Name = "txt_Memo";
            this.txt_Memo.Size = new System.Drawing.Size(817, 21);
            this.txt_Memo.TabIndex = 949;
            // 
            // grid_Basket
            // 
            this.grid_Basket.AllowUserToAddRows = false;
            this.grid_Basket.AllowUserToDeleteRows = false;
            this.grid_Basket.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Basket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Basket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Basket.BackgroundColor = System.Drawing.Color.White;
            this.grid_Basket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Basket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Basket.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Basket.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_Basket.EnableHeadersVisualStyles = false;
            this.grid_Basket.GridColor = System.Drawing.Color.LightGray;
            this.grid_Basket.Location = new System.Drawing.Point(745, 473);
            this.grid_Basket.MultiSelect = false;
            this.grid_Basket.Name = "grid_Basket";
            this.grid_Basket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Basket.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Basket.RowHeadersVisible = false;
            this.grid_Basket.RowTemplate.Height = 19;
            this.grid_Basket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Basket.Size = new System.Drawing.Size(1051, 376);
            this.grid_Basket.StandardTab = true;
            this.grid_Basket.TabIndex = 948;
            this.grid_Basket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Basket_CellClick);
            // 
            // grid_stock
            // 
            this.grid_stock.AllowUserToAddRows = false;
            this.grid_stock.AllowUserToDeleteRows = false;
            this.grid_stock.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_stock.BackgroundColor = System.Drawing.Color.White;
            this.grid_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_stock.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_stock.EnableHeadersVisualStyles = false;
            this.grid_stock.GridColor = System.Drawing.Color.LightGray;
            this.grid_stock.Location = new System.Drawing.Point(745, 93);
            this.grid_stock.MultiSelect = false;
            this.grid_stock.Name = "grid_stock";
            this.grid_stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_stock.RowHeadersVisible = false;
            this.grid_stock.RowTemplate.Height = 19;
            this.grid_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_stock.Size = new System.Drawing.Size(1051, 374);
            this.grid_stock.StandardTab = true;
            this.grid_stock.TabIndex = 947;
            this.grid_stock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_stock_CellEndEdit);
            this.grid_stock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_stock_DataBindingComplete);
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(858, 48);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(115, 15);
            this.customLabel8.TabIndex = 946;
            this.customLabel8.Text = "Product description";
            // 
            // customLabel6
            // 
            this.customLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(1603, 47);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(54, 15);
            this.customLabel6.TabIndex = 945;
            this.customLabel6.Text = "Packsize";
            // 
            // txt_PackSize
            // 
            this.txt_PackSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PackSize.BackColor = System.Drawing.Color.White;
            this.txt_PackSize.Enabled = false;
            this.txt_PackSize.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PackSize.Location = new System.Drawing.Point(1606, 66);
            this.txt_PackSize.MaxLength = 30;
            this.txt_PackSize.Name = "txt_PackSize";
            this.txt_PackSize.Size = new System.Drawing.Size(96, 21);
            this.txt_PackSize.TabIndex = 944;
            this.txt_PackSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(1603, 4);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(54, 15);
            this.customLabel3.TabIndex = 943;
            this.customLabel3.Text = "Quantity";
            // 
            // txt_IssueQty
            // 
            this.txt_IssueQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IssueQty.BackColor = System.Drawing.Color.White;
            this.txt_IssueQty.Enabled = false;
            this.txt_IssueQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_IssueQty.Location = new System.Drawing.Point(1606, 22);
            this.txt_IssueQty.Name = "txt_IssueQty";
            this.txt_IssueQty.Size = new System.Drawing.Size(96, 21);
            this.txt_IssueQty.TabIndex = 942;
            this.txt_IssueQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(742, 852);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(99, 15);
            this.customLabel2.TabIndex = 941;
            this.customLabel2.Text = "Transaction Date";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(29)))));
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1708, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 65);
            this.btn_Add.TabIndex = 940;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cbo_Company
            // 
            this.cbo_Company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_Company.BackColor = System.Drawing.Color.White;
            this.cbo_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Company.Enabled = false;
            this.cbo_Company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_Company.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Company.FormattingEnabled = true;
            this.cbo_Company.Location = new System.Drawing.Point(745, 21);
            this.cbo_Company.Name = "cbo_Company";
            this.cbo_Company.Size = new System.Drawing.Size(110, 23);
            this.cbo_Company.TabIndex = 938;
            this.cbo_Company.SelectedValueChanged += new System.EventHandler(this.cbo_Company_SelectedValueChanged);
            // 
            // customLabel7
            // 
            this.customLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(742, 2);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(58, 15);
            this.customLabel7.TabIndex = 939;
            this.customLabel7.Text = "Company";
            // 
            // txt_ProductDesc
            // 
            this.txt_ProductDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProductDesc.BackColor = System.Drawing.Color.White;
            this.txt_ProductDesc.Enabled = false;
            this.txt_ProductDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ProductDesc.Location = new System.Drawing.Point(861, 66);
            this.txt_ProductDesc.MaxLength = 30;
            this.txt_ProductDesc.Name = "txt_ProductDesc";
            this.txt_ProductDesc.Size = new System.Drawing.Size(739, 21);
            this.txt_ProductDesc.TabIndex = 936;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(742, 48);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 15);
            this.label34.TabIndex = 937;
            this.label34.Text = "Product ID";
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(1517, 5);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(59, 15);
            this.customLabel5.TabIndex = 935;
            this.customLabel5.Text = "Available";
            // 
            // txt_availableQty
            // 
            this.txt_availableQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_availableQty.BackColor = System.Drawing.Color.White;
            this.txt_availableQty.Enabled = false;
            this.txt_availableQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_availableQty.Location = new System.Drawing.Point(1520, 22);
            this.txt_availableQty.Name = "txt_availableQty";
            this.txt_availableQty.Size = new System.Drawing.Size(80, 21);
            this.txt_availableQty.TabIndex = 934;
            this.txt_availableQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(1431, 5);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(44, 15);
            this.customLabel1.TabIndex = 933;
            this.customLabel1.Text = "Global";
            // 
            // txt_globalAllocated
            // 
            this.txt_globalAllocated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_globalAllocated.BackColor = System.Drawing.Color.White;
            this.txt_globalAllocated.Enabled = false;
            this.txt_globalAllocated.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_globalAllocated.Location = new System.Drawing.Point(1434, 22);
            this.txt_globalAllocated.Name = "txt_globalAllocated";
            this.txt_globalAllocated.Size = new System.Drawing.Size(80, 21);
            this.txt_globalAllocated.TabIndex = 932;
            this.txt_globalAllocated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbo_product
            // 
            this.cbo_product.BackColor = System.Drawing.Color.White;
            this.cbo_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_product.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_product.FormattingEnabled = true;
            this.cbo_product.Location = new System.Drawing.Point(745, 64);
            this.cbo_product.Name = "cbo_product";
            this.cbo_product.Size = new System.Drawing.Size(110, 23);
            this.cbo_product.TabIndex = 931;
            this.cbo_product.TextUpdate += new System.EventHandler(this.cbo_product_TextUpdate);
            this.cbo_product.SelectedValueChanged += new System.EventHandler(this.cbo_product_SelectedValueChanged);
            this.cbo_product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_product_KeyPress);
            // 
            // dateTimePickerAcc
            // 
            this.dateTimePickerAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerAcc.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAcc.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerAcc.Enabled = false;
            this.dateTimePickerAcc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAcc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAcc.Location = new System.Drawing.Point(745, 870);
            this.dateTimePickerAcc.Name = "dateTimePickerAcc";
            this.dateTimePickerAcc.Size = new System.Drawing.Size(111, 22);
            this.dateTimePickerAcc.TabIndex = 930;
            // 
            // cbo_storageSite
            // 
            this.cbo_storageSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_storageSite.BackColor = System.Drawing.Color.White;
            this.cbo_storageSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_storageSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_storageSite.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_storageSite.FormattingEnabled = true;
            this.cbo_storageSite.Location = new System.Drawing.Point(1079, 21);
            this.cbo_storageSite.Name = "cbo_storageSite";
            this.cbo_storageSite.Size = new System.Drawing.Size(69, 23);
            this.cbo_storageSite.TabIndex = 928;
            this.cbo_storageSite.SelectedValueChanged += new System.EventHandler(this.cbo_storageSite_SelectedValueChanged);
            this.cbo_storageSite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_storageSite_KeyPress);
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(1076, 2);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(28, 15);
            this.customLabel4.TabIndex = 929;
            this.customLabel4.Text = "Site";
            // 
            // customLabel19
            // 
            this.customLabel19.AutoSize = true;
            this.customLabel19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel19.Location = new System.Drawing.Point(175, 10);
            this.customLabel19.Name = "customLabel19";
            this.customLabel19.Size = new System.Drawing.Size(19, 15);
            this.customLabel19.TabIndex = 927;
            this.customLabel19.Text = "To";
            // 
            // customLabel18
            // 
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel18.Location = new System.Drawing.Point(12, 10);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(35, 15);
            this.customLabel18.TabIndex = 924;
            this.customLabel18.Text = "From";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(200, 7);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerTo.TabIndex = 926;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(50, 7);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerFrom.TabIndex = 925;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(643, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 29);
            this.btn_refresh.TabIndex = 923;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // grid_header
            // 
            this.grid_header.AllowUserToAddRows = false;
            this.grid_header.AllowUserToDeleteRows = false;
            this.grid_header.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_header.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_header.BackgroundColor = System.Drawing.Color.White;
            this.grid_header.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_header.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_header.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid_header.EnableHeadersVisualStyles = false;
            this.grid_header.GridColor = System.Drawing.Color.LightGray;
            this.grid_header.Location = new System.Drawing.Point(12, 36);
            this.grid_header.MultiSelect = false;
            this.grid_header.Name = "grid_header";
            this.grid_header.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_header.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid_header.RowHeadersVisible = false;
            this.grid_header.RowTemplate.Height = 19;
            this.grid_header.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_header.Size = new System.Drawing.Size(727, 431);
            this.grid_header.StandardTab = true;
            this.grid_header.TabIndex = 922;
            this.grid_header.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_header_CellEnter);
            // 
            // grid_detail
            // 
            this.grid_detail.AllowUserToAddRows = false;
            this.grid_detail.AllowUserToDeleteRows = false;
            this.grid_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.grid_detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_detail.BackgroundColor = System.Drawing.Color.White;
            this.grid_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_detail.DefaultCellStyle = dataGridViewCellStyle15;
            this.grid_detail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_detail.EnableHeadersVisualStyles = false;
            this.grid_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_detail.Location = new System.Drawing.Point(12, 473);
            this.grid_detail.MultiSelect = false;
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grid_detail.RowHeadersVisible = false;
            this.grid_detail.RowTemplate.Height = 19;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(727, 419);
            this.grid_detail.StandardTab = true;
            this.grid_detail.TabIndex = 921;
            // 
            // Manufacturing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 900);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.customLabel10);
            this.Controls.Add(this.txt_BasePrice);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.customLabel9);
            this.Controls.Add(this.txt_Memo);
            this.Controls.Add(this.grid_Basket);
            this.Controls.Add(this.grid_stock);
            this.Controls.Add(this.customLabel8);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.txt_PackSize);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.txt_IssueQty);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.cbo_Company);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.txt_ProductDesc);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.txt_availableQty);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_globalAllocated);
            this.Controls.Add(this.cbo_product);
            this.Controls.Add(this.dateTimePickerAcc);
            this.Controls.Add(this.cbo_storageSite);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.customLabel19);
            this.Controls.Add(this.customLabel18);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.grid_header);
            this.Controls.Add(this.grid_detail);
            this.MinimumSize = new System.Drawing.Size(1630, 620);
            this.Name = "Manufacturing";
            this.Text = "Manufacturing";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox txt_CompanyName;
        private Tools.CustomLabel customLabel10;
        private CustomTextBox txt_BasePrice;
        private System.Windows.Forms.Button btn_Save;
        private Tools.CustomLabel customLabel9;
        private CustomTextBox txt_Memo;
        private CustomGrid grid_Basket;
        private CustomGrid grid_stock;
        private Tools.CustomLabel customLabel8;
        private Tools.CustomLabel customLabel6;
        private CustomTextBox txt_PackSize;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_IssueQty;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.Button btn_Add;
        private Tools.CustomComboBox cbo_Company;
        private Tools.CustomLabel customLabel7;
        private CustomTextBox txt_ProductDesc;
        private System.Windows.Forms.Label label34;
        private Tools.CustomLabel customLabel5;
        private CustomTextBox txt_availableQty;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_globalAllocated;
        private Tools.CustomComboBox cbo_product;
        private System.Windows.Forms.DateTimePicker dateTimePickerAcc;
        private Tools.CustomComboBox cbo_storageSite;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel19;
        private Tools.CustomLabel customLabel18;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btn_refresh;
        private CustomGrid grid_header;
        private CustomGrid grid_detail;
    }
}