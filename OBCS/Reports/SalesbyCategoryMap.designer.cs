namespace OBCS.Reports
{
    partial class SalesbyCategoryMap
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
            this.btn_BcsLogo = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_hybrid = new System.Windows.Forms.Button();
            this.btn_Satellite = new System.Windows.Forms.Button();
            this.btn_Map = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_TotalAmount = new OBCS.CustomTextBox();
            this.cbo_CustomerID = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.cbo_category = new OBCS.Tools.CustomComboBox();
            this.txt_CategoryName = new OBCS.CustomTextBox();
            this.customLabel19 = new OBCS.Tools.CustomLabel();
            this.customLabel18 = new OBCS.Tools.CustomLabel();
            this.grid_Category = new OBCS.CustomGrid();
            this.grid_Customer = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BcsLogo
            // 
            this.btn_BcsLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BcsLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_BcsLogo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_BcsLogo.BackgroundImage = global::OBCS.Properties.Resources.BCS_LOGO;
            this.btn_BcsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BcsLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BcsLogo.Location = new System.Drawing.Point(1045, 781);
            this.btn_BcsLogo.Name = "btn_BcsLogo";
            this.btn_BcsLogo.Size = new System.Drawing.Size(50, 32);
            this.btn_BcsLogo.TabIndex = 836;
            this.btn_BcsLogo.UseVisualStyleBackColor = false;
            this.btn_BcsLogo.Click += new System.EventHandler(this.btn_BcsLogo_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1002, 11);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 23);
            this.btn_Search.TabIndex = 834;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_hybrid
            // 
            this.btn_hybrid.BackColor = System.Drawing.Color.White;
            this.btn_hybrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hybrid.Location = new System.Drawing.Point(174, 11);
            this.btn_hybrid.Name = "btn_hybrid";
            this.btn_hybrid.Size = new System.Drawing.Size(75, 23);
            this.btn_hybrid.TabIndex = 832;
            this.btn_hybrid.Text = "Hybrid";
            this.btn_hybrid.UseVisualStyleBackColor = false;
            this.btn_hybrid.Click += new System.EventHandler(this.btn_Hybrid_Click);
            // 
            // btn_Satellite
            // 
            this.btn_Satellite.BackColor = System.Drawing.Color.White;
            this.btn_Satellite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Satellite.Location = new System.Drawing.Point(93, 11);
            this.btn_Satellite.Name = "btn_Satellite";
            this.btn_Satellite.Size = new System.Drawing.Size(75, 23);
            this.btn_Satellite.TabIndex = 830;
            this.btn_Satellite.Text = "Satellite";
            this.btn_Satellite.UseVisualStyleBackColor = false;
            this.btn_Satellite.Click += new System.EventHandler(this.btn_Satellite_Click);
            // 
            // btn_Map
            // 
            this.btn_Map.BackColor = System.Drawing.Color.White;
            this.btn_Map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Map.Location = new System.Drawing.Point(12, 11);
            this.btn_Map.Name = "btn_Map";
            this.btn_Map.Size = new System.Drawing.Size(75, 23);
            this.btn_Map.TabIndex = 829;
            this.btn_Map.Text = "Map";
            this.btn_Map.UseVisualStyleBackColor = false;
            this.btn_Map.Click += new System.EventHandler(this.btn_Map_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 41);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(1083, 772);
            this.gMapControl1.TabIndex = 828;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(880, 12);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerTo.TabIndex = 839;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(732, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerFrom.TabIndex = 838;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(1101, 795);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(117, 13);
            this.customLabel2.TabIndex = 847;
            this.customLabel2.Text = "Total Sales Amount";
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalAmount.BackColor = System.Drawing.Color.White;
            this.txt_TotalAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_TotalAmount.Location = new System.Drawing.Point(1224, 792);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.ReadOnly = true;
            this.txt_TotalAmount.Size = new System.Drawing.Size(228, 21);
            this.txt_TotalAmount.TabIndex = 846;
            this.txt_TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbo_CustomerID
            // 
            this.cbo_CustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_CustomerID.BackColor = System.Drawing.Color.White;
            this.cbo_CustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_CustomerID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_CustomerID.FormattingEnabled = true;
            this.cbo_CustomerID.Location = new System.Drawing.Point(1104, 11);
            this.cbo_CustomerID.Name = "cbo_CustomerID";
            this.cbo_CustomerID.Size = new System.Drawing.Size(349, 23);
            this.cbo_CustomerID.TabIndex = 845;
            this.cbo_CustomerID.SelectedValueChanged += new System.EventHandler(this.cbo_CustomerID_SelectedValueChanged);
            this.cbo_CustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_CustomerID_KeyPress);
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(319, 15);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(55, 15);
            this.customLabel1.TabIndex = 844;
            this.customLabel1.Text = "Category";
            // 
            // cbo_category
            // 
            this.cbo_category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_category.BackColor = System.Drawing.Color.White;
            this.cbo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_category.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(380, 12);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(105, 23);
            this.cbo_category.TabIndex = 843;
            this.cbo_category.SelectedValueChanged += new System.EventHandler(this.cbo_category_SelectedValueChanged);
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CategoryName.BackColor = System.Drawing.Color.White;
            this.txt_CategoryName.Enabled = false;
            this.txt_CategoryName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_CategoryName.Location = new System.Drawing.Point(491, 13);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.ReadOnly = true;
            this.txt_CategoryName.Size = new System.Drawing.Size(188, 21);
            this.txt_CategoryName.TabIndex = 842;
            // 
            // customLabel19
            // 
            this.customLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel19.AutoSize = true;
            this.customLabel19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel19.Location = new System.Drawing.Point(855, 15);
            this.customLabel19.Name = "customLabel19";
            this.customLabel19.Size = new System.Drawing.Size(19, 15);
            this.customLabel19.TabIndex = 840;
            this.customLabel19.Text = "To";
            // 
            // customLabel18
            // 
            this.customLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel18.Location = new System.Drawing.Point(691, 16);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(35, 15);
            this.customLabel18.TabIndex = 837;
            this.customLabel18.Text = "From";
            // 
            // grid_Category
            // 
            this.grid_Category.AllowUserToAddRows = false;
            this.grid_Category.AllowUserToDeleteRows = false;
            this.grid_Category.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Category.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_Category.BackgroundColor = System.Drawing.Color.White;
            this.grid_Category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Category.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Category.EnableHeadersVisualStyles = false;
            this.grid_Category.GridColor = System.Drawing.Color.LightGray;
            this.grid_Category.Location = new System.Drawing.Point(12, 128);
            this.grid_Category.MultiSelect = false;
            this.grid_Category.Name = "grid_Category";
            this.grid_Category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_Category.RowHeadersVisible = false;
            this.grid_Category.RowTemplate.Height = 19;
            this.grid_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Category.Size = new System.Drawing.Size(75, 183);
            this.grid_Category.StandardTab = true;
            this.grid_Category.TabIndex = 835;
            this.grid_Category.Visible = false;
            // 
            // grid_Customer
            // 
            this.grid_Customer.AllowUserToAddRows = false;
            this.grid_Customer.AllowUserToDeleteRows = false;
            this.grid_Customer.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Customer.BackgroundColor = System.Drawing.Color.White;
            this.grid_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Customer.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_Customer.EnableHeadersVisualStyles = false;
            this.grid_Customer.GridColor = System.Drawing.Color.LightGray;
            this.grid_Customer.Location = new System.Drawing.Point(1104, 41);
            this.grid_Customer.MultiSelect = false;
            this.grid_Customer.Name = "grid_Customer";
            this.grid_Customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_Customer.RowHeadersVisible = false;
            this.grid_Customer.RowTemplate.Height = 19;
            this.grid_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Customer.Size = new System.Drawing.Size(349, 745);
            this.grid_Customer.StandardTab = true;
            this.grid_Customer.TabIndex = 831;
            this.grid_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Customer_CellClick);
            this.grid_Customer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Customer_CellEnter);
            this.grid_Customer.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_Customer_DataBindingComplete);
            // 
            // SalesbyCategoryMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 825);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.cbo_CustomerID);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.txt_CategoryName);
            this.Controls.Add(this.customLabel19);
            this.Controls.Add(this.customLabel18);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.btn_BcsLogo);
            this.Controls.Add(this.grid_Category);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_hybrid);
            this.Controls.Add(this.grid_Customer);
            this.Controls.Add(this.btn_Satellite);
            this.Controls.Add(this.btn_Map);
            this.Controls.Add(this.gMapControl1);
            this.Name = "SalesbyCategoryMap";
            this.Text = "SalesbyCategoryMap";
            this.Load += new System.EventHandler(this.SalesbyCategoryMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BcsLogo;
        private CustomGrid grid_Category;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_hybrid;
        private CustomGrid grid_Customer;
        private System.Windows.Forms.Button btn_Satellite;
        private System.Windows.Forms.Button btn_Map;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Tools.CustomLabel customLabel19;
        private Tools.CustomLabel customLabel18;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private CustomTextBox txt_CategoryName;
        private Tools.CustomComboBox cbo_category;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomComboBox cbo_CustomerID;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_TotalAmount;
    }
}