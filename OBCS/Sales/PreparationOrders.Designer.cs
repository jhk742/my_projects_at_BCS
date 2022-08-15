namespace OBCS.Sales
{
    partial class PreparationOrders
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_RouteNumber = new OBCS.CustomTextBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_truck = new OBCS.CustomTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_driver = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.grid_ORDERS = new OBCS.CustomGrid();
            this.btn_hybrid = new System.Windows.Forms.Button();
            this.btn_Map = new System.Windows.Forms.Button();
            this.btn_DeliveryRoutePlan = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btn_BcsLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDERS)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1350, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 36);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(986, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(115, 36);
            this.btn_refresh.TabIndex = 353;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_RouteNumber
            // 
            this.txt_RouteNumber.BackColor = System.Drawing.Color.White;
            this.txt_RouteNumber.Enabled = false;
            this.txt_RouteNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_RouteNumber.Location = new System.Drawing.Point(12, 20);
            this.txt_RouteNumber.Name = "txt_RouteNumber";
            this.txt_RouteNumber.Size = new System.Drawing.Size(60, 21);
            this.txt_RouteNumber.TabIndex = 826;
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(9, 2);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(38, 15);
            this.customLabel7.TabIndex = 825;
            this.customLabel7.Text = "Route";
            // 
            // txt_truck
            // 
            this.txt_truck.BackColor = System.Drawing.Color.White;
            this.txt_truck.Enabled = false;
            this.txt_truck.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_truck.Location = new System.Drawing.Point(234, 20);
            this.txt_truck.Name = "txt_truck";
            this.txt_truck.Size = new System.Drawing.Size(100, 21);
            this.txt_truck.TabIndex = 373;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(231, 2);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(36, 15);
            this.customLabel3.TabIndex = 372;
            this.customLabel3.Text = "Truck";
            // 
            // txt_driver
            // 
            this.txt_driver.BackColor = System.Drawing.Color.White;
            this.txt_driver.Enabled = false;
            this.txt_driver.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_driver.Location = new System.Drawing.Point(78, 20);
            this.txt_driver.Name = "txt_driver";
            this.txt_driver.Size = new System.Drawing.Size(150, 21);
            this.txt_driver.TabIndex = 371;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(75, 2);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(41, 15);
            this.customLabel2.TabIndex = 370;
            this.customLabel2.Text = "Driver";
            // 
            // grid_ORDERS
            // 
            this.grid_ORDERS.AllowUserToAddRows = false;
            this.grid_ORDERS.AllowUserToDeleteRows = false;
            this.grid_ORDERS.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_ORDERS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_ORDERS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_ORDERS.BackgroundColor = System.Drawing.Color.White;
            this.grid_ORDERS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ORDERS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_ORDERS.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_ORDERS.EnableHeadersVisualStyles = false;
            this.grid_ORDERS.GridColor = System.Drawing.Color.LightGray;
            this.grid_ORDERS.Location = new System.Drawing.Point(12, 47);
            this.grid_ORDERS.MultiSelect = false;
            this.grid_ORDERS.Name = "grid_ORDERS";
            this.grid_ORDERS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ORDERS.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_ORDERS.RowHeadersVisible = false;
            this.grid_ORDERS.RowTemplate.Height = 19;
            this.grid_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ORDERS.Size = new System.Drawing.Size(1089, 741);
            this.grid_ORDERS.StandardTab = true;
            this.grid_ORDERS.TabIndex = 0;
            this.grid_ORDERS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ORDERS_CellEnter);
            this.grid_ORDERS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ORDERS_CellDoubleClick);
            this.grid_ORDERS.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ORDERS_CellEnter);
            this.grid_ORDERS.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_ORDERS_DataBindingComplete);
            this.grid_ORDERS.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grid_ORDERS_RowPostPaint);
            // 
            // btn_hybrid
            // 
            this.btn_hybrid.BackColor = System.Drawing.Color.White;
            this.btn_hybrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hybrid.Location = new System.Drawing.Point(1171, 47);
            this.btn_hybrid.Name = "btn_hybrid";
            this.btn_hybrid.Size = new System.Drawing.Size(58, 23);
            this.btn_hybrid.TabIndex = 829;
            this.btn_hybrid.Text = "Hybrid";
            this.btn_hybrid.UseVisualStyleBackColor = false;
            this.btn_hybrid.Click += new System.EventHandler(this.btn_hybrid_Click);
            // 
            // btn_Map
            // 
            this.btn_Map.BackColor = System.Drawing.Color.White;
            this.btn_Map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Map.Location = new System.Drawing.Point(1107, 47);
            this.btn_Map.Name = "btn_Map";
            this.btn_Map.Size = new System.Drawing.Size(58, 23);
            this.btn_Map.TabIndex = 828;
            this.btn_Map.Text = "Map";
            this.btn_Map.UseVisualStyleBackColor = false;
            this.btn_Map.Click += new System.EventHandler(this.btn_Map_Click);
            // 
            // btn_DeliveryRoutePlan
            // 
            this.btn_DeliveryRoutePlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeliveryRoutePlan.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeliveryRoutePlan.Location = new System.Drawing.Point(1107, 5);
            this.btn_DeliveryRoutePlan.Name = "btn_DeliveryRoutePlan";
            this.btn_DeliveryRoutePlan.Size = new System.Drawing.Size(237, 36);
            this.btn_DeliveryRoutePlan.TabIndex = 832;
            this.btn_DeliveryRoutePlan.Text = "Select From Delivery Route Plan";
            this.btn_DeliveryRoutePlan.UseVisualStyleBackColor = true;
            this.btn_DeliveryRoutePlan.Click += new System.EventHandler(this.btn_DeliveryRoutePlan_Click);
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
            this.gMapControl1.Location = new System.Drawing.Point(1107, 47);
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
            this.gMapControl1.Size = new System.Drawing.Size(318, 741);
            this.gMapControl1.TabIndex = 827;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            this.gMapControl1.OnMarkerDoubleClick += new GMap.NET.WindowsForms.MarkerDoubleClick(this.gMapControl1_OnMarkerDoubleClick);
            // 
            // btn_BcsLogo
            // 
            this.btn_BcsLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BcsLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_BcsLogo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_BcsLogo.BackgroundImage = global::OBCS.Properties.Resources.BCS_LOGO;
            this.btn_BcsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BcsLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BcsLogo.Location = new System.Drawing.Point(1375, 756);
            this.btn_BcsLogo.Name = "btn_BcsLogo";
            this.btn_BcsLogo.Size = new System.Drawing.Size(50, 32);
            this.btn_BcsLogo.TabIndex = 833;
            this.btn_BcsLogo.UseVisualStyleBackColor = false;
            this.btn_BcsLogo.Click += new System.EventHandler(this.btn_BcsLogo_Click);
            // 
            // PreparationOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 800);
            this.Controls.Add(this.btn_BcsLogo);
            this.Controls.Add(this.btn_DeliveryRoutePlan);
            this.Controls.Add(this.btn_hybrid);
            this.Controls.Add(this.btn_Map);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.txt_RouteNumber);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.txt_truck);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.txt_driver);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.grid_ORDERS);
            this.MinimumSize = new System.Drawing.Size(1453, 39);
            this.Name = "PreparationOrders";
            this.Text = "Preparation Plan Orders";
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_refresh;
        private CustomGrid grid_ORDERS;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel7;
        private System.Windows.Forms.Button btn_hybrid;
        private System.Windows.Forms.Button btn_Map;
        private System.Windows.Forms.Button btn_DeliveryRoutePlan;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        public CustomTextBox txt_driver;
        public CustomTextBox txt_truck;
        public CustomTextBox txt_RouteNumber;
        private System.Windows.Forms.Button btn_BcsLogo;
    }
}