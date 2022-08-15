namespace OBCS.Sales
{
    partial class SelectDeliveryRoutePlan
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_amount = new OBCS.CustomTextBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.cbo_SearchCode = new OBCS.Tools.CustomComboBox();
            this.grid_RoutePlanDetail = new OBCS.CustomGrid();
            this.grid_ORDERS = new OBCS.CustomGrid();
            this.txt_RouteNumber = new OBCS.CustomTextBox();
            this.txt_truck = new OBCS.CustomTextBox();
            this.txt_driver = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RoutePlanDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDERS)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(1107, 673);
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
            this.gMapControl1.Size = new System.Drawing.Size(548, 216);
            this.gMapControl1.TabIndex = 326;
            this.gMapControl1.Zoom = 0D;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(1540, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(115, 39);
            this.btn_Add.TabIndex = 838;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(986, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(115, 39);
            this.btn_refresh.TabIndex = 841;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(928, 4);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(52, 15);
            this.customLabel4.TabIndex = 840;
            this.customLabel4.Text = "Amount";
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Enabled = false;
            this.txt_amount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_amount.Location = new System.Drawing.Point(887, 22);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(93, 21);
            this.txt_amount.TabIndex = 839;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(9, 4);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(38, 15);
            this.customLabel7.TabIndex = 834;
            this.customLabel7.Text = "Route";
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(231, 4);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(36, 15);
            this.customLabel1.TabIndex = 833;
            this.customLabel1.Text = "Truck";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(75, 4);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(41, 15);
            this.customLabel2.TabIndex = 832;
            this.customLabel2.Text = "Driver";
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(1104, 2);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(34, 15);
            this.customLabel3.TabIndex = 325;
            this.customLabel3.Text = "Code";
            // 
            // cbo_SearchCode
            // 
            this.cbo_SearchCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_SearchCode.BackColor = System.Drawing.Color.White;
            this.cbo_SearchCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_SearchCode.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_SearchCode.FormattingEnabled = true;
            this.cbo_SearchCode.Location = new System.Drawing.Point(1107, 20);
            this.cbo_SearchCode.Name = "cbo_SearchCode";
            this.cbo_SearchCode.Size = new System.Drawing.Size(261, 23);
            this.cbo_SearchCode.TabIndex = 324;
            this.cbo_SearchCode.SelectedIndexChanged += new System.EventHandler(this.cbo_SearchCode_SelectedIndexChanged);
            // 
            // grid_RoutePlanDetail
            // 
            this.grid_RoutePlanDetail.AllowUserToAddRows = false;
            this.grid_RoutePlanDetail.AllowUserToDeleteRows = false;
            this.grid_RoutePlanDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_RoutePlanDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_RoutePlanDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_RoutePlanDetail.BackgroundColor = System.Drawing.Color.White;
            this.grid_RoutePlanDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_RoutePlanDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_RoutePlanDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_RoutePlanDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_RoutePlanDetail.EnableHeadersVisualStyles = false;
            this.grid_RoutePlanDetail.GridColor = System.Drawing.Color.LightGray;
            this.grid_RoutePlanDetail.Location = new System.Drawing.Point(1107, 49);
            this.grid_RoutePlanDetail.MultiSelect = false;
            this.grid_RoutePlanDetail.Name = "grid_RoutePlanDetail";
            this.grid_RoutePlanDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_RoutePlanDetail.RowHeadersVisible = false;
            this.grid_RoutePlanDetail.RowTemplate.Height = 19;
            this.grid_RoutePlanDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_RoutePlanDetail.Size = new System.Drawing.Size(548, 618);
            this.grid_RoutePlanDetail.StandardTab = true;
            this.grid_RoutePlanDetail.TabIndex = 2;
            // 
            // grid_ORDERS
            // 
            this.grid_ORDERS.AllowUserToAddRows = false;
            this.grid_ORDERS.AllowUserToDeleteRows = false;
            this.grid_ORDERS.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_ORDERS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_ORDERS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_ORDERS.BackgroundColor = System.Drawing.Color.White;
            this.grid_ORDERS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ORDERS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_ORDERS.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_ORDERS.EnableHeadersVisualStyles = false;
            this.grid_ORDERS.GridColor = System.Drawing.Color.LightGray;
            this.grid_ORDERS.Location = new System.Drawing.Point(12, 49);
            this.grid_ORDERS.MultiSelect = false;
            this.grid_ORDERS.Name = "grid_ORDERS";
            this.grid_ORDERS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_ORDERS.RowHeadersVisible = false;
            this.grid_ORDERS.RowTemplate.Height = 19;
            this.grid_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ORDERS.Size = new System.Drawing.Size(1089, 840);
            this.grid_ORDERS.StandardTab = true;
            this.grid_ORDERS.TabIndex = 1;
            this.grid_ORDERS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ORDERS_CellClick);
            this.grid_ORDERS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ORDERS_CellDoubleClick);
            this.grid_ORDERS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_ORDERS_DataBindingComplete);
            this.grid_ORDERS.Sorted += new System.EventHandler(this.grid_ORDERS_Sorted);
            // 
            // txt_RouteNumber
            // 
            this.txt_RouteNumber.BackColor = System.Drawing.Color.White;
            this.txt_RouteNumber.Enabled = false;
            this.txt_RouteNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_RouteNumber.Location = new System.Drawing.Point(12, 22);
            this.txt_RouteNumber.Name = "txt_RouteNumber";
            this.txt_RouteNumber.Size = new System.Drawing.Size(60, 21);
            this.txt_RouteNumber.TabIndex = 844;
            // 
            // txt_truck
            // 
            this.txt_truck.BackColor = System.Drawing.Color.White;
            this.txt_truck.Enabled = false;
            this.txt_truck.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_truck.Location = new System.Drawing.Point(234, 22);
            this.txt_truck.Name = "txt_truck";
            this.txt_truck.Size = new System.Drawing.Size(100, 21);
            this.txt_truck.TabIndex = 843;
            // 
            // txt_driver
            // 
            this.txt_driver.BackColor = System.Drawing.Color.White;
            this.txt_driver.Enabled = false;
            this.txt_driver.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_driver.Location = new System.Drawing.Point(78, 22);
            this.txt_driver.Name = "txt_driver";
            this.txt_driver.Size = new System.Drawing.Size(150, 21);
            this.txt_driver.TabIndex = 842;
            // 
            // SelectDeliveryRoutePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1667, 901);
            this.Controls.Add(this.txt_RouteNumber);
            this.Controls.Add(this.txt_truck);
            this.Controls.Add(this.txt_driver);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.cbo_SearchCode);
            this.Controls.Add(this.grid_RoutePlanDetail);
            this.Controls.Add(this.grid_ORDERS);
            this.MinimumSize = new System.Drawing.Size(1300, 760);
            this.Name = "SelectDeliveryRoutePlan";
            this.Text = "SelectDeliveryRoutePlan";
            ((System.ComponentModel.ISupportInitialize)(this.grid_RoutePlanDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_ORDERS;
        private CustomGrid grid_RoutePlanDetail;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomComboBox cbo_SearchCode;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Tools.CustomLabel customLabel7;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.Button btn_Add;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_amount;
        private System.Windows.Forms.Button btn_refresh;
        public CustomTextBox txt_RouteNumber;
        public CustomTextBox txt_truck;
        public CustomTextBox txt_driver;
    }
}