namespace OBCS.Stock
{
    partial class Disassembly
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.dateTimePickerAcc = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_CompanyName = new OBCS.CustomTextBox();
            this.customLabel10 = new OBCS.Tools.CustomLabel();
            this.txt_BasePrice = new OBCS.CustomTextBox();
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
            this.cbo_Company = new OBCS.Tools.CustomComboBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_ProductDesc = new OBCS.CustomTextBox();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_availableQty = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_globalAllocated = new OBCS.CustomTextBox();
            this.cbo_product = new OBCS.Tools.CustomComboBox();
            this.cbo_storageSite = new OBCS.Tools.CustomComboBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.customLabel19 = new OBCS.Tools.CustomLabel();
            this.customLabel18 = new OBCS.Tools.CustomLabel();
            this.grid_header = new OBCS.CustomGrid();
            this.grid_detail = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            this.SuspendLayout();
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
            this.dateTimePickerTo.TabIndex = 853;
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
            this.dateTimePickerFrom.TabIndex = 852;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(643, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 29);
            this.btn_refresh.TabIndex = 850;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
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
            this.btn_Add.TabIndex = 869;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(742, 50);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 15);
            this.label34.TabIndex = 866;
            this.label34.Text = "Product ID";
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
            this.dateTimePickerAcc.TabIndex = 859;
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
            this.btn_Save.TabIndex = 883;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.BackColor = System.Drawing.Color.White;
            this.txt_CompanyName.Enabled = false;
            this.txt_CompanyName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_CompanyName.Location = new System.Drawing.Point(862, 22);
            this.txt_CompanyName.MaxLength = 30;
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(212, 21);
            this.txt_CompanyName.TabIndex = 886;
            // 
            // customLabel10
            // 
            this.customLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel10.AutoSize = true;
            this.customLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel10.Location = new System.Drawing.Point(1345, 4);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.Size = new System.Drawing.Size(61, 15);
            this.customLabel10.TabIndex = 885;
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
            this.txt_BasePrice.TabIndex = 884;
            this.txt_BasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_BasePrice.Visible = false;
            // 
            // customLabel9
            // 
            this.customLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.Location = new System.Drawing.Point(859, 852);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(41, 15);
            this.customLabel9.TabIndex = 882;
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
            this.txt_Memo.TabIndex = 881;
            // 
            // grid_Basket
            // 
            this.grid_Basket.AllowUserToAddRows = false;
            this.grid_Basket.AllowUserToDeleteRows = false;
            this.grid_Basket.AllowUserToResizeRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Basket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.grid_Basket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Basket.BackgroundColor = System.Drawing.Color.White;
            this.grid_Basket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Basket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.grid_Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Basket.DefaultCellStyle = dataGridViewCellStyle35;
            this.grid_Basket.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_Basket.EnableHeadersVisualStyles = false;
            this.grid_Basket.GridColor = System.Drawing.Color.LightGray;
            this.grid_Basket.Location = new System.Drawing.Point(745, 473);
            this.grid_Basket.MultiSelect = false;
            this.grid_Basket.Name = "grid_Basket";
            this.grid_Basket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Basket.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.grid_Basket.RowHeadersVisible = false;
            this.grid_Basket.RowTemplate.Height = 19;
            this.grid_Basket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Basket.Size = new System.Drawing.Size(1051, 376);
            this.grid_Basket.StandardTab = true;
            this.grid_Basket.TabIndex = 880;
            this.grid_Basket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Basket_CellClick);
            // 
            // grid_stock
            // 
            this.grid_stock.AllowUserToAddRows = false;
            this.grid_stock.AllowUserToDeleteRows = false;
            this.grid_stock.AllowUserToResizeRows = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_stock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.grid_stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_stock.BackgroundColor = System.Drawing.Color.White;
            this.grid_stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.grid_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_stock.DefaultCellStyle = dataGridViewCellStyle39;
            this.grid_stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_stock.EnableHeadersVisualStyles = false;
            this.grid_stock.GridColor = System.Drawing.Color.LightGray;
            this.grid_stock.Location = new System.Drawing.Point(745, 93);
            this.grid_stock.MultiSelect = false;
            this.grid_stock.Name = "grid_stock";
            this.grid_stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_stock.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.grid_stock.RowHeadersVisible = false;
            this.grid_stock.RowTemplate.Height = 19;
            this.grid_stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_stock.Size = new System.Drawing.Size(1051, 374);
            this.grid_stock.StandardTab = true;
            this.grid_stock.TabIndex = 879;
            this.grid_stock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_stock_CellEndEdit);
            this.grid_stock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_stock_DataBindingComplete);
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(859, 48);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(115, 15);
            this.customLabel8.TabIndex = 878;
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
            this.customLabel6.TabIndex = 877;
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
            this.txt_PackSize.TabIndex = 876;
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
            this.customLabel3.TabIndex = 875;
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
            this.txt_IssueQty.TabIndex = 874;
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
            this.customLabel2.TabIndex = 873;
            this.customLabel2.Text = "Transaction Date";
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
            this.cbo_Company.Location = new System.Drawing.Point(745, 23);
            this.cbo_Company.Name = "cbo_Company";
            this.cbo_Company.Size = new System.Drawing.Size(110, 23);
            this.cbo_Company.TabIndex = 867;
            this.cbo_Company.SelectedValueChanged += new System.EventHandler(this.cbo_Company_SelectedValueChanged);
            // 
            // customLabel7
            // 
            this.customLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(742, 4);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(58, 15);
            this.customLabel7.TabIndex = 868;
            this.customLabel7.Text = "Company";
            // 
            // txt_ProductDesc
            // 
            this.txt_ProductDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProductDesc.BackColor = System.Drawing.Color.White;
            this.txt_ProductDesc.Enabled = false;
            this.txt_ProductDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ProductDesc.Location = new System.Drawing.Point(862, 66);
            this.txt_ProductDesc.MaxLength = 30;
            this.txt_ProductDesc.Name = "txt_ProductDesc";
            this.txt_ProductDesc.Size = new System.Drawing.Size(738, 21);
            this.txt_ProductDesc.TabIndex = 865;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(1517, 5);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(59, 15);
            this.customLabel5.TabIndex = 864;
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
            this.txt_availableQty.TabIndex = 863;
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
            this.customLabel1.TabIndex = 862;
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
            this.txt_globalAllocated.TabIndex = 861;
            this.txt_globalAllocated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbo_product
            // 
            this.cbo_product.BackColor = System.Drawing.Color.White;
            this.cbo_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_product.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_product.FormattingEnabled = true;
            this.cbo_product.Location = new System.Drawing.Point(745, 66);
            this.cbo_product.Name = "cbo_product";
            this.cbo_product.Size = new System.Drawing.Size(110, 23);
            this.cbo_product.TabIndex = 860;
            this.cbo_product.TextUpdate += new System.EventHandler(this.cbo_product_TextUpdate);
            this.cbo_product.SelectedValueChanged += new System.EventHandler(this.cbo_product_SelectedValueChanged);
            this.cbo_product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_product_KeyPress);
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
            this.cbo_storageSite.Location = new System.Drawing.Point(1080, 21);
            this.cbo_storageSite.Name = "cbo_storageSite";
            this.cbo_storageSite.Size = new System.Drawing.Size(69, 23);
            this.cbo_storageSite.TabIndex = 855;
            this.cbo_storageSite.SelectedValueChanged += new System.EventHandler(this.cbo_storageSite_SelectedValueChanged);
            this.cbo_storageSite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_storageSite_KeyPress);
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(1077, 2);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(28, 15);
            this.customLabel4.TabIndex = 856;
            this.customLabel4.Text = "Site";
            // 
            // customLabel19
            // 
            this.customLabel19.AutoSize = true;
            this.customLabel19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel19.Location = new System.Drawing.Point(175, 10);
            this.customLabel19.Name = "customLabel19";
            this.customLabel19.Size = new System.Drawing.Size(19, 15);
            this.customLabel19.TabIndex = 854;
            this.customLabel19.Text = "To";
            // 
            // customLabel18
            // 
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel18.Location = new System.Drawing.Point(12, 10);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(35, 15);
            this.customLabel18.TabIndex = 851;
            this.customLabel18.Text = "From";
            // 
            // grid_header
            // 
            this.grid_header.AllowUserToAddRows = false;
            this.grid_header.AllowUserToDeleteRows = false;
            this.grid_header.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_header.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.grid_header.BackgroundColor = System.Drawing.Color.White;
            this.grid_header.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_header.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.grid_header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_header.DefaultCellStyle = dataGridViewCellStyle43;
            this.grid_header.EnableHeadersVisualStyles = false;
            this.grid_header.GridColor = System.Drawing.Color.LightGray;
            this.grid_header.Location = new System.Drawing.Point(12, 36);
            this.grid_header.MultiSelect = false;
            this.grid_header.Name = "grid_header";
            this.grid_header.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_header.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.grid_header.RowHeadersVisible = false;
            this.grid_header.RowTemplate.Height = 19;
            this.grid_header.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_header.Size = new System.Drawing.Size(727, 431);
            this.grid_header.StandardTab = true;
            this.grid_header.TabIndex = 849;
            this.grid_header.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_header_CellEnter);
            // 
            // grid_detail
            // 
            this.grid_detail.AllowUserToAddRows = false;
            this.grid_detail.AllowUserToDeleteRows = false;
            this.grid_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.grid_detail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_detail.BackgroundColor = System.Drawing.Color.White;
            this.grid_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_detail.DefaultCellStyle = dataGridViewCellStyle47;
            this.grid_detail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_detail.EnableHeadersVisualStyles = false;
            this.grid_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_detail.Location = new System.Drawing.Point(12, 473);
            this.grid_detail.MultiSelect = false;
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.grid_detail.RowHeadersVisible = false;
            this.grid_detail.RowTemplate.Height = 19;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(727, 419);
            this.grid_detail.StandardTab = true;
            this.grid_detail.TabIndex = 848;
            // 
            // Disassembly
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
            this.Name = "Disassembly";
            this.Text = "Disassembly";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.CustomLabel customLabel19;
        private Tools.CustomLabel customLabel18;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btn_refresh;
        private CustomGrid grid_header;
        private CustomGrid grid_detail;
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
        private CustomTextBox txt_PackSize;
        private Tools.CustomLabel customLabel6;
        private Tools.CustomLabel customLabel8;
        private CustomGrid grid_stock;
        private CustomGrid grid_Basket;
        private Tools.CustomLabel customLabel9;
        private CustomTextBox txt_Memo;
        private System.Windows.Forms.Button btn_Save;
        private Tools.CustomLabel customLabel10;
        private CustomTextBox txt_BasePrice;
        private CustomTextBox txt_CompanyName;
    }
}