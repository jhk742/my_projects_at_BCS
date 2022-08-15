namespace OBCS.Stock
{
    partial class SHIPMENTRETURN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDone = new System.Windows.Forms.TabPage();
            this.customLabel19 = new OBCS.Tools.CustomLabel();
            this.customLabel18 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.grid_returned = new OBCS.CustomGrid();
            this.tabWIP = new System.Windows.Forms.TabPage();
            this.btn_RefreshWIP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_deliveryNumber = new OBCS.Tools.CustomLabel();
            this.txt_deliveryNumber = new OBCS.CustomTextBox();
            this.grid_tempReturned = new OBCS.CustomGrid();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_notReturned = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.cbo_RM = new OBCS.Tools.CustomComboBox();
            this.customLabel34 = new OBCS.Tools.CustomLabel();
            this.txt_CompanyName = new OBCS.CustomTextBox();
            this.txt_qty = new OBCS.CustomTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.txt_price = new OBCS.CustomTextBox();
            this.customLabel9 = new OBCS.Tools.CustomLabel();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.txt_amount = new OBCS.CustomTextBox();
            this.txt_PackSize = new OBCS.CustomTextBox();
            this.customLabel11 = new OBCS.Tools.CustomLabel();
            this.cbo_Company = new OBCS.Tools.CustomComboBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_ProductDesc = new OBCS.CustomTextBox();
            this.cbo_product = new OBCS.Tools.CustomComboBox();
            this.cbo_storageSite = new OBCS.Tools.CustomComboBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.grid_detail = new OBCS.CustomGrid();
            this.btn_FakeCreate = new System.Windows.Forms.Button();
            this.btn_FakeAdd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_returned)).BeginInit();
            this.tabWIP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tempReturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabDone);
            this.tabControl1.Controls.Add(this.tabWIP);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 860);
            this.tabControl1.TabIndex = 503;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabDone
            // 
            this.tabDone.AutoScroll = true;
            this.tabDone.Controls.Add(this.customLabel19);
            this.tabDone.Controls.Add(this.customLabel18);
            this.tabDone.Controls.Add(this.dateTimePickerTo);
            this.tabDone.Controls.Add(this.dateTimePickerFrom);
            this.tabDone.Controls.Add(this.btn_refresh);
            this.tabDone.Controls.Add(this.grid_returned);
            this.tabDone.Location = new System.Drawing.Point(4, 27);
            this.tabDone.Name = "tabDone";
            this.tabDone.Padding = new System.Windows.Forms.Padding(3);
            this.tabDone.Size = new System.Drawing.Size(871, 829);
            this.tabDone.TabIndex = 0;
            this.tabDone.Text = "Returned product";
            this.tabDone.UseVisualStyleBackColor = true;
            // 
            // customLabel19
            // 
            this.customLabel19.AutoSize = true;
            this.customLabel19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel19.Location = new System.Drawing.Point(169, 22);
            this.customLabel19.Name = "customLabel19";
            this.customLabel19.Size = new System.Drawing.Size(19, 15);
            this.customLabel19.TabIndex = 966;
            this.customLabel19.Text = "To";
            // 
            // customLabel18
            // 
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel18.Location = new System.Drawing.Point(6, 22);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(35, 15);
            this.customLabel18.TabIndex = 963;
            this.customLabel18.Text = "From";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(194, 19);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerTo.TabIndex = 965;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(44, 19);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerFrom.TabIndex = 964;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(780, 10);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(85, 41);
            this.btn_refresh.TabIndex = 962;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // grid_returned
            // 
            this.grid_returned.AllowUserToAddRows = false;
            this.grid_returned.AllowUserToDeleteRows = false;
            this.grid_returned.AllowUserToResizeRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_returned.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.grid_returned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_returned.BackgroundColor = System.Drawing.Color.White;
            this.grid_returned.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_returned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grid_returned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_returned.DefaultCellStyle = dataGridViewCellStyle16;
            this.grid_returned.EnableHeadersVisualStyles = false;
            this.grid_returned.GridColor = System.Drawing.Color.LightGray;
            this.grid_returned.Location = new System.Drawing.Point(6, 60);
            this.grid_returned.MultiSelect = false;
            this.grid_returned.Name = "grid_returned";
            this.grid_returned.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_returned.RowHeadersVisible = false;
            this.grid_returned.RowTemplate.Height = 19;
            this.grid_returned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_returned.Size = new System.Drawing.Size(859, 763);
            this.grid_returned.StandardTab = true;
            this.grid_returned.TabIndex = 503;
            this.grid_returned.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_returned_CellEnter);
            this.grid_returned.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_returned_DataBindingComplete);
            // 
            // tabWIP
            // 
            this.tabWIP.Controls.Add(this.btn_RefreshWIP);
            this.tabWIP.Controls.Add(this.groupBox1);
            this.tabWIP.Controls.Add(this.grid_tempReturned);
            this.tabWIP.Location = new System.Drawing.Point(4, 27);
            this.tabWIP.Name = "tabWIP";
            this.tabWIP.Padding = new System.Windows.Forms.Padding(3);
            this.tabWIP.Size = new System.Drawing.Size(871, 829);
            this.tabWIP.TabIndex = 1;
            this.tabWIP.Text = "WIP";
            this.tabWIP.UseVisualStyleBackColor = true;
            // 
            // btn_RefreshWIP
            // 
            this.btn_RefreshWIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.btn_RefreshWIP.FlatAppearance.BorderSize = 0;
            this.btn_RefreshWIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RefreshWIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshWIP.ForeColor = System.Drawing.Color.White;
            this.btn_RefreshWIP.Location = new System.Drawing.Point(780, 10);
            this.btn_RefreshWIP.Name = "btn_RefreshWIP";
            this.btn_RefreshWIP.Size = new System.Drawing.Size(85, 41);
            this.btn_RefreshWIP.TabIndex = 1032;
            this.btn_RefreshWIP.Text = "Refresh";
            this.btn_RefreshWIP.UseVisualStyleBackColor = false;
            this.btn_RefreshWIP.Click += new System.EventHandler(this.btn_RefreshWIP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_FakeCreate);
            this.groupBox1.Controls.Add(this.customLabel1);
            this.groupBox1.Controls.Add(this.btn_create);
            this.groupBox1.Controls.Add(this.lbl_deliveryNumber);
            this.groupBox1.Controls.Add(this.txt_deliveryNumber);
            this.groupBox1.Location = new System.Drawing.Point(6, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 61);
            this.groupBox1.TabIndex = 619;
            this.groupBox1.TabStop = false;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.ForeColor = System.Drawing.Color.Red;
            this.customLabel1.Location = new System.Drawing.Point(115, 46);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(0, 10);
            this.customLabel1.TabIndex = 619;
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(29)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(367, 14);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(85, 41);
            this.btn_create.TabIndex = 511;
            this.btn_create.Text = "Create a new return";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Visible = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_deliveryNumber
            // 
            this.lbl_deliveryNumber.AutoSize = true;
            this.lbl_deliveryNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deliveryNumber.Location = new System.Drawing.Point(13, 26);
            this.lbl_deliveryNumber.Name = "lbl_deliveryNumber";
            this.lbl_deliveryNumber.Size = new System.Drawing.Size(98, 15);
            this.lbl_deliveryNumber.TabIndex = 617;
            this.lbl_deliveryNumber.Text = "Delivery Number";
            // 
            // txt_deliveryNumber
            // 
            this.txt_deliveryNumber.BackColor = System.Drawing.Color.White;
            this.txt_deliveryNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_deliveryNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_deliveryNumber.Location = new System.Drawing.Point(117, 24);
            this.txt_deliveryNumber.MaxLength = 12;
            this.txt_deliveryNumber.Name = "txt_deliveryNumber";
            this.txt_deliveryNumber.Size = new System.Drawing.Size(244, 21);
            this.txt_deliveryNumber.TabIndex = 618;
            this.txt_deliveryNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_deliveryNumber.TextChanged += new System.EventHandler(this.txt_deliveryNumber_TextChanged);
            // 
            // grid_tempReturned
            // 
            this.grid_tempReturned.AllowUserToAddRows = false;
            this.grid_tempReturned.AllowUserToDeleteRows = false;
            this.grid_tempReturned.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_tempReturned.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.grid_tempReturned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_tempReturned.BackgroundColor = System.Drawing.Color.White;
            this.grid_tempReturned.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_tempReturned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid_tempReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_tempReturned.DefaultCellStyle = dataGridViewCellStyle13;
            this.grid_tempReturned.EnableHeadersVisualStyles = false;
            this.grid_tempReturned.GridColor = System.Drawing.Color.LightGray;
            this.grid_tempReturned.Location = new System.Drawing.Point(6, 60);
            this.grid_tempReturned.MultiSelect = false;
            this.grid_tempReturned.Name = "grid_tempReturned";
            this.grid_tempReturned.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_tempReturned.RowHeadersVisible = false;
            this.grid_tempReturned.RowTemplate.Height = 19;
            this.grid_tempReturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_tempReturned.Size = new System.Drawing.Size(859, 763);
            this.grid_tempReturned.StandardTab = true;
            this.grid_tempReturned.TabIndex = 463;
            this.grid_tempReturned.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tempReturned_CellEnter);
            this.grid_tempReturned.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_tempReturned_DataBindingComplete);
            // 
            // btn_done
            // 
            this.btn_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(214)))), ((int)(((byte)(115)))));
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.Location = new System.Drawing.Point(1632, 828);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(119, 44);
            this.btn_done.TabIndex = 508;
            this.btn_done.Text = "Accept";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_notReturned
            // 
            this.btn_notReturned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_notReturned.BackColor = System.Drawing.Color.DimGray;
            this.btn_notReturned.FlatAppearance.BorderSize = 0;
            this.btn_notReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notReturned.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btn_notReturned.ForeColor = System.Drawing.Color.White;
            this.btn_notReturned.Location = new System.Drawing.Point(1507, 828);
            this.btn_notReturned.Name = "btn_notReturned";
            this.btn_notReturned.Size = new System.Drawing.Size(119, 44);
            this.btn_notReturned.TabIndex = 510;
            this.btn_notReturned.Text = "Decline";
            this.btn_notReturned.UseVisualStyleBackColor = false;
            this.btn_notReturned.Click += new System.EventHandler(this.btn_notReturned_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(29)))));
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1660, 19);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 68);
            this.btn_Add.TabIndex = 1002;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Visible = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(897, 47);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 15);
            this.label34.TabIndex = 1023;
            this.label34.Text = "Product ID";
            // 
            // cbo_RM
            // 
            this.cbo_RM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_RM.BackColor = System.Drawing.Color.White;
            this.cbo_RM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_RM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_RM.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_RM.FormattingEnabled = true;
            this.cbo_RM.Location = new System.Drawing.Point(1476, 65);
            this.cbo_RM.Name = "cbo_RM";
            this.cbo_RM.Size = new System.Drawing.Size(85, 23);
            this.cbo_RM.TabIndex = 616;
            this.cbo_RM.SelectedValueChanged += new System.EventHandler(this.cbo_RM_SelectedValueChanged);
            this.cbo_RM.Leave += new System.EventHandler(this.cbo_RM_Leave);
            // 
            // customLabel34
            // 
            this.customLabel34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel34.AutoSize = true;
            this.customLabel34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel34.Location = new System.Drawing.Point(1473, 48);
            this.customLabel34.Name = "customLabel34";
            this.customLabel34.Size = new System.Drawing.Size(48, 15);
            this.customLabel34.TabIndex = 446;
            this.customLabel34.Text = "Remark";
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.BackColor = System.Drawing.Color.White;
            this.txt_CompanyName.Enabled = false;
            this.txt_CompanyName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_CompanyName.Location = new System.Drawing.Point(1032, 21);
            this.txt_CompanyName.MaxLength = 30;
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(336, 21);
            this.txt_CompanyName.TabIndex = 1031;
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_qty.BackColor = System.Drawing.Color.White;
            this.txt_qty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_qty.Location = new System.Drawing.Point(1564, 22);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(85, 21);
            this.txt_qty.TabIndex = 1003;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_qty.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(1561, 4);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(54, 15);
            this.customLabel3.TabIndex = 1004;
            this.customLabel3.Text = "Quantity";
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(1029, 47);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(115, 15);
            this.customLabel8.TabIndex = 1028;
            this.customLabel8.Text = "Product description";
            // 
            // txt_price
            // 
            this.txt_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_price.BackColor = System.Drawing.Color.White;
            this.txt_price.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_price.Location = new System.Drawing.Point(1476, 22);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(85, 21);
            this.txt_price.TabIndex = 1011;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_price.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // customLabel9
            // 
            this.customLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.Location = new System.Drawing.Point(1473, 4);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(35, 15);
            this.customLabel9.TabIndex = 1012;
            this.customLabel9.Text = "Price";
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(1371, 47);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(54, 15);
            this.customLabel6.TabIndex = 1027;
            this.customLabel6.Text = "Packsize";
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Enabled = false;
            this.txt_amount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_amount.Location = new System.Drawing.Point(1564, 66);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(85, 21);
            this.txt_amount.TabIndex = 1013;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_PackSize
            // 
            this.txt_PackSize.BackColor = System.Drawing.Color.White;
            this.txt_PackSize.Enabled = false;
            this.txt_PackSize.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PackSize.Location = new System.Drawing.Point(1374, 65);
            this.txt_PackSize.MaxLength = 30;
            this.txt_PackSize.Name = "txt_PackSize";
            this.txt_PackSize.Size = new System.Drawing.Size(96, 21);
            this.txt_PackSize.TabIndex = 1026;
            this.txt_PackSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customLabel11
            // 
            this.customLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel11.AutoSize = true;
            this.customLabel11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel11.Location = new System.Drawing.Point(1561, 48);
            this.customLabel11.Name = "customLabel11";
            this.customLabel11.Size = new System.Drawing.Size(49, 15);
            this.customLabel11.TabIndex = 1014;
            this.customLabel11.Text = "Amount";
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
            this.cbo_Company.Location = new System.Drawing.Point(900, 21);
            this.cbo_Company.Name = "cbo_Company";
            this.cbo_Company.Size = new System.Drawing.Size(126, 23);
            this.cbo_Company.TabIndex = 1024;
            // 
            // customLabel7
            // 
            this.customLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(897, 3);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(58, 15);
            this.customLabel7.TabIndex = 1025;
            this.customLabel7.Text = "Company";
            // 
            // txt_ProductDesc
            // 
            this.txt_ProductDesc.BackColor = System.Drawing.Color.White;
            this.txt_ProductDesc.Enabled = false;
            this.txt_ProductDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ProductDesc.Location = new System.Drawing.Point(1032, 65);
            this.txt_ProductDesc.MaxLength = 30;
            this.txt_ProductDesc.Name = "txt_ProductDesc";
            this.txt_ProductDesc.Size = new System.Drawing.Size(336, 21);
            this.txt_ProductDesc.TabIndex = 1022;
            // 
            // cbo_product
            // 
            this.cbo_product.BackColor = System.Drawing.Color.White;
            this.cbo_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_product.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_product.FormattingEnabled = true;
            this.cbo_product.Location = new System.Drawing.Point(900, 64);
            this.cbo_product.Name = "cbo_product";
            this.cbo_product.Size = new System.Drawing.Size(126, 23);
            this.cbo_product.TabIndex = 1017;
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
            this.cbo_storageSite.Enabled = false;
            this.cbo_storageSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_storageSite.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_storageSite.FormattingEnabled = true;
            this.cbo_storageSite.Location = new System.Drawing.Point(1374, 21);
            this.cbo_storageSite.Name = "cbo_storageSite";
            this.cbo_storageSite.Size = new System.Drawing.Size(96, 23);
            this.cbo_storageSite.TabIndex = 1015;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(1371, 3);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(28, 15);
            this.customLabel4.TabIndex = 1016;
            this.customLabel4.Text = "Site";
            // 
            // grid_detail
            // 
            this.grid_detail.AllowUserToAddRows = false;
            this.grid_detail.AllowUserToDeleteRows = false;
            this.grid_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.grid_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_detail.BackgroundColor = System.Drawing.Color.White;
            this.grid_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_detail.DefaultCellStyle = dataGridViewCellStyle19;
            this.grid_detail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_detail.EnableHeadersVisualStyles = false;
            this.grid_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_detail.Location = new System.Drawing.Point(900, 99);
            this.grid_detail.MultiSelect = false;
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.grid_detail.RowHeadersVisible = false;
            this.grid_detail.RowTemplate.Height = 19;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(851, 719);
            this.grid_detail.StandardTab = true;
            this.grid_detail.TabIndex = 464;
            this.grid_detail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detail_CellClick);
            this.grid_detail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detail_CellEndEdit);
            // 
            // btn_FakeCreate
            // 
            this.btn_FakeCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FakeCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(29)))));
            this.btn_FakeCreate.Enabled = false;
            this.btn_FakeCreate.FlatAppearance.BorderSize = 0;
            this.btn_FakeCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FakeCreate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FakeCreate.ForeColor = System.Drawing.Color.White;
            this.btn_FakeCreate.Location = new System.Drawing.Point(367, 14);
            this.btn_FakeCreate.Name = "btn_FakeCreate";
            this.btn_FakeCreate.Size = new System.Drawing.Size(85, 41);
            this.btn_FakeCreate.TabIndex = 620;
            this.btn_FakeCreate.Text = "Create a new return";
            this.btn_FakeCreate.UseVisualStyleBackColor = false;
            this.btn_FakeCreate.Visible = false;
            // 
            // btn_FakeAdd
            // 
            this.btn_FakeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FakeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(90)))), ((int)(((byte)(29)))));
            this.btn_FakeAdd.Enabled = false;
            this.btn_FakeAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_FakeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FakeAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FakeAdd.ForeColor = System.Drawing.Color.White;
            this.btn_FakeAdd.Location = new System.Drawing.Point(1659, 18);
            this.btn_FakeAdd.Name = "btn_FakeAdd";
            this.btn_FakeAdd.Size = new System.Drawing.Size(88, 68);
            this.btn_FakeAdd.TabIndex = 1032;
            this.btn_FakeAdd.Text = "Add";
            this.btn_FakeAdd.UseVisualStyleBackColor = false;
            this.btn_FakeAdd.Visible = false;
            // 
            // SHIPMENTRETURN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1759, 884);
            this.Controls.Add(this.btn_FakeAdd);
            this.Controls.Add(this.cbo_RM);
            this.Controls.Add(this.customLabel34);
            this.Controls.Add(this.txt_CompanyName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel8);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.customLabel9);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_PackSize);
            this.Controls.Add(this.customLabel11);
            this.Controls.Add(this.cbo_Company);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.txt_ProductDesc);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.cbo_product);
            this.Controls.Add(this.cbo_storageSite);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.btn_notReturned);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.grid_detail);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1775, 450);
            this.Name = "SHIPMENTRETURN";
            this.Text = "Shipment Return";
            this.tabControl1.ResumeLayout(false);
            this.tabDone.ResumeLayout(false);
            this.tabDone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_returned)).EndInit();
            this.tabWIP.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tempReturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDone;
        private CustomGrid grid_returned;
        private System.Windows.Forms.TabPage tabWIP;
        private CustomGrid grid_tempReturned;
        private CustomGrid grid_detail;
        private Tools.CustomComboBox cbo_RM;
        private Tools.CustomLabel customLabel34;
        private System.Windows.Forms.Button btn_create;
        private CustomTextBox txt_deliveryNumber;
        private Tools.CustomLabel lbl_deliveryNumber;
        private Tools.CustomLabel customLabel19;
        private Tools.CustomLabel customLabel18;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private Tools.CustomLabel customLabel1;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_notReturned;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_qty;
        private System.Windows.Forms.Button btn_Add;
        private Tools.CustomLabel customLabel9;
        private CustomTextBox txt_price;
        private CustomTextBox txt_amount;
        private Tools.CustomLabel customLabel11;
        private CustomTextBox txt_CompanyName;
        private Tools.CustomLabel customLabel8;
        private Tools.CustomLabel customLabel6;
        private CustomTextBox txt_PackSize;
        private Tools.CustomComboBox cbo_Company;
        private Tools.CustomLabel customLabel7;
        private CustomTextBox txt_ProductDesc;
        private System.Windows.Forms.Label label34;
        private Tools.CustomComboBox cbo_product;
        private Tools.CustomComboBox cbo_storageSite;
        private Tools.CustomLabel customLabel4;
        private System.Windows.Forms.Button btn_RefreshWIP;
        private System.Windows.Forms.Button btn_FakeCreate;
        private System.Windows.Forms.Button btn_FakeAdd;
    }
}