namespace OBCS.Sales
{
    partial class PreparationPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_selectOrders = new System.Windows.Forms.Button();
            this.btn_saveRouteOrders = new System.Windows.Forms.Button();
            this.btn_deleteRouteOrders = new System.Windows.Forms.Button();
            this.btn_createPrepPlan = new System.Windows.Forms.Button();
            this.btn_updatePickZone = new System.Windows.Forms.Button();
            this.btn_refresh2 = new System.Windows.Forms.Button();
            this.btn_globalShortage = new System.Windows.Forms.Button();
            this.btn_bulkNutLabel = new System.Windows.Forms.Button();
            this.cbox_vendor = new System.Windows.Forms.CheckBox();
            this.btn_updateStopNo = new System.Windows.Forms.Button();
            this.btn_createPickingList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.cbo_SearchCode = new OBCS.Tools.CustomComboBox();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.btn_RouteMap = new System.Windows.Forms.Button();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_TotalAmount = new OBCS.CustomTextBox();
            this.btn_bulkNutLabelList = new System.Windows.Forms.Button();
            this.btn_deliveryList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.cbo_drivers = new OBCS.Tools.CustomComboBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.cbo_trucks = new OBCS.Tools.CustomComboBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.dateTimePicker_routingDate = new OBCS.Purchase.CustomDateTimePicker();
            this.txt_amount = new OBCS.CustomTextBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.grid_RouteDeliveryPlan = new OBCS.CustomGrid();
            this.grid_RouteHeader = new OBCS.CustomGrid();
            this.customTextBox2 = new OBCS.CustomTextBox();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.customTextBox4 = new OBCS.CustomTextBox();
            this.customTextBox3 = new OBCS.CustomTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.grid_RouteDetail = new OBCS.CustomGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteDeliveryPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(256, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(85, 76);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(347, 12);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(91, 76);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create a New Route";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_selectOrders
            // 
            this.btn_selectOrders.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_selectOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectOrders.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectOrders.Location = new System.Drawing.Point(454, 12);
            this.btn_selectOrders.Name = "btn_selectOrders";
            this.btn_selectOrders.Size = new System.Drawing.Size(125, 35);
            this.btn_selectOrders.TabIndex = 5;
            this.btn_selectOrders.Text = "Select Orders";
            this.btn_selectOrders.UseVisualStyleBackColor = true;
            this.btn_selectOrders.Click += new System.EventHandler(this.btn_selectOrders_Click);
            // 
            // btn_saveRouteOrders
            // 
            this.btn_saveRouteOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveRouteOrders.Location = new System.Drawing.Point(476, 282);
            this.btn_saveRouteOrders.Name = "btn_saveRouteOrders";
            this.btn_saveRouteOrders.Size = new System.Drawing.Size(144, 45);
            this.btn_saveRouteOrders.TabIndex = 329;
            this.btn_saveRouteOrders.Text = "(Visual False) Save Route Orders";
            this.btn_saveRouteOrders.UseVisualStyleBackColor = true;
            this.btn_saveRouteOrders.Visible = false;
            this.btn_saveRouteOrders.Click += new System.EventHandler(this.btn_saveRouteOrders_Click);
            // 
            // btn_deleteRouteOrders
            // 
            this.btn_deleteRouteOrders.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteRouteOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteRouteOrders.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRouteOrders.Location = new System.Drawing.Point(585, 12);
            this.btn_deleteRouteOrders.Name = "btn_deleteRouteOrders";
            this.btn_deleteRouteOrders.Size = new System.Drawing.Size(158, 35);
            this.btn_deleteRouteOrders.TabIndex = 6;
            this.btn_deleteRouteOrders.Text = "Delete Route Orders";
            this.btn_deleteRouteOrders.UseVisualStyleBackColor = true;
            this.btn_deleteRouteOrders.Click += new System.EventHandler(this.btn_deleteRouteOrders_Click);
            // 
            // btn_createPrepPlan
            // 
            this.btn_createPrepPlan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createPrepPlan.Location = new System.Drawing.Point(1329, 9);
            this.btn_createPrepPlan.Name = "btn_createPrepPlan";
            this.btn_createPrepPlan.Size = new System.Drawing.Size(159, 56);
            this.btn_createPrepPlan.TabIndex = 331;
            this.btn_createPrepPlan.Text = "Create Prep. Plan";
            this.btn_createPrepPlan.UseVisualStyleBackColor = true;
            this.btn_createPrepPlan.Visible = false;
            // 
            // btn_updatePickZone
            // 
            this.btn_updatePickZone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePickZone.Location = new System.Drawing.Point(1329, 65);
            this.btn_updatePickZone.Name = "btn_updatePickZone";
            this.btn_updatePickZone.Size = new System.Drawing.Size(159, 56);
            this.btn_updatePickZone.TabIndex = 332;
            this.btn_updatePickZone.Text = "Update Pick Zone";
            this.btn_updatePickZone.UseVisualStyleBackColor = true;
            this.btn_updatePickZone.Visible = false;
            // 
            // btn_refresh2
            // 
            this.btn_refresh2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh2.Location = new System.Drawing.Point(1489, 9);
            this.btn_refresh2.Name = "btn_refresh2";
            this.btn_refresh2.Size = new System.Drawing.Size(97, 112);
            this.btn_refresh2.TabIndex = 333;
            this.btn_refresh2.Text = "Refresh";
            this.btn_refresh2.UseVisualStyleBackColor = true;
            this.btn_refresh2.Visible = false;
            // 
            // btn_globalShortage
            // 
            this.btn_globalShortage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_globalShortage.Location = new System.Drawing.Point(1587, 9);
            this.btn_globalShortage.Name = "btn_globalShortage";
            this.btn_globalShortage.Size = new System.Drawing.Size(159, 36);
            this.btn_globalShortage.TabIndex = 334;
            this.btn_globalShortage.Text = "Global Shortage";
            this.btn_globalShortage.UseVisualStyleBackColor = true;
            this.btn_globalShortage.Visible = false;
            // 
            // btn_bulkNutLabel
            // 
            this.btn_bulkNutLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bulkNutLabel.Location = new System.Drawing.Point(1587, 84);
            this.btn_bulkNutLabel.Name = "btn_bulkNutLabel";
            this.btn_bulkNutLabel.Size = new System.Drawing.Size(159, 37);
            this.btn_bulkNutLabel.TabIndex = 336;
            this.btn_bulkNutLabel.Text = "Bulk Nut Label";
            this.btn_bulkNutLabel.UseVisualStyleBackColor = true;
            this.btn_bulkNutLabel.Visible = false;
            // 
            // cbox_vendor
            // 
            this.cbox_vendor.AutoSize = true;
            this.cbox_vendor.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_vendor.Location = new System.Drawing.Point(185, 12);
            this.cbox_vendor.Name = "cbox_vendor";
            this.cbox_vendor.Size = new System.Drawing.Size(66, 19);
            this.cbox_vendor.TabIndex = 339;
            this.cbox_vendor.Text = "Vendor";
            this.cbox_vendor.UseVisualStyleBackColor = true;
            // 
            // btn_updateStopNo
            // 
            this.btn_updateStopNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateStopNo.Location = new System.Drawing.Point(608, 254);
            this.btn_updateStopNo.Name = "btn_updateStopNo";
            this.btn_updateStopNo.Size = new System.Drawing.Size(127, 23);
            this.btn_updateStopNo.TabIndex = 347;
            this.btn_updateStopNo.Text = "Update Stop No.";
            this.btn_updateStopNo.UseVisualStyleBackColor = true;
            this.btn_updateStopNo.Visible = false;
            // 
            // btn_createPickingList
            // 
            this.btn_createPickingList.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_createPickingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createPickingList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createPickingList.Location = new System.Drawing.Point(749, 12);
            this.btn_createPickingList.Name = "btn_createPickingList";
            this.btn_createPickingList.Size = new System.Drawing.Size(159, 35);
            this.btn_createPickingList.TabIndex = 7;
            this.btn_createPickingList.Text = "Create Picking List";
            this.btn_createPickingList.UseVisualStyleBackColor = true;
            this.btn_createPickingList.Click += new System.EventHandler(this.btn_createPickingList_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btn_Sort);
            this.panel1.Controls.Add(this.customLabel8);
            this.panel1.Controls.Add(this.cbo_SearchCode);
            this.panel1.Controls.Add(this.btn_DeleteAll);
            this.panel1.Controls.Add(this.btn_RouteMap);
            this.panel1.Controls.Add(this.customLabel7);
            this.panel1.Controls.Add(this.txt_TotalAmount);
            this.panel1.Controls.Add(this.btn_bulkNutLabelList);
            this.panel1.Controls.Add(this.btn_deliveryList);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_deleteRouteOrders);
            this.panel1.Controls.Add(this.btn_createPickingList);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Controls.Add(this.cbo_drivers);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Controls.Add(this.cbo_trucks);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.customLabel4);
            this.panel1.Controls.Add(this.dateTimePicker_routingDate);
            this.panel1.Controls.Add(this.txt_amount);
            this.panel1.Controls.Add(this.btn_selectOrders);
            this.panel1.Controls.Add(this.cbox_vendor);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1593, 98);
            this.panel1.TabIndex = 348;
            // 
            // btn_Sort
            // 
            this.btn_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.btn_Sort.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sort.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sort.ForeColor = System.Drawing.Color.Black;
            this.btn_Sort.Location = new System.Drawing.Point(1012, 53);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(61, 35);
            this.btn_Sort.TabIndex = 361;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = false;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(749, 50);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(75, 15);
            this.customLabel8.TabIndex = 360;
            this.customLabel8.Text = "Sort By Code";
            // 
            // cbo_SearchCode
            // 
            this.cbo_SearchCode.BackColor = System.Drawing.Color.White;
            this.cbo_SearchCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SearchCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_SearchCode.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_SearchCode.FormattingEnabled = true;
            this.cbo_SearchCode.Location = new System.Drawing.Point(749, 65);
            this.cbo_SearchCode.Name = "cbo_SearchCode";
            this.cbo_SearchCode.Size = new System.Drawing.Size(257, 23);
            this.cbo_SearchCode.TabIndex = 359;
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteAll.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteAll.Location = new System.Drawing.Point(585, 53);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(158, 35);
            this.btn_DeleteAll.TabIndex = 358;
            this.btn_DeleteAll.Text = "Delete All";
            this.btn_DeleteAll.UseVisualStyleBackColor = true;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // btn_RouteMap
            // 
            this.btn_RouteMap.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_RouteMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RouteMap.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RouteMap.Location = new System.Drawing.Point(454, 53);
            this.btn_RouteMap.Name = "btn_RouteMap";
            this.btn_RouteMap.Size = new System.Drawing.Size(125, 35);
            this.btn_RouteMap.TabIndex = 357;
            this.btn_RouteMap.Text = "Route Map";
            this.btn_RouteMap.UseVisualStyleBackColor = true;
            this.btn_RouteMap.Click += new System.EventHandler(this.btn_RouteMap_Click);
            // 
            // customLabel7
            // 
            this.customLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(1113, 15);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(167, 15);
            this.customLabel7.TabIndex = 356;
            this.customLabel7.Text = "Total Amount by Routing Date";
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TotalAmount.BackColor = System.Drawing.Color.White;
            this.txt_TotalAmount.Enabled = false;
            this.txt_TotalAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_TotalAmount.Location = new System.Drawing.Point(1286, 12);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.Size = new System.Drawing.Size(79, 21);
            this.txt_TotalAmount.TabIndex = 355;
            this.txt_TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_bulkNutLabelList
            // 
            this.btn_bulkNutLabelList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bulkNutLabelList.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_bulkNutLabelList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bulkNutLabelList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bulkNutLabelList.Location = new System.Drawing.Point(1371, 12);
            this.btn_bulkNutLabelList.Name = "btn_bulkNutLabelList";
            this.btn_bulkNutLabelList.Size = new System.Drawing.Size(140, 35);
            this.btn_bulkNutLabelList.TabIndex = 351;
            this.btn_bulkNutLabelList.Text = "Bulk Nut Label List";
            this.btn_bulkNutLabelList.UseVisualStyleBackColor = true;
            this.btn_bulkNutLabelList.Click += new System.EventHandler(this.btn_bulkNutLabelList_Click);
            // 
            // btn_deliveryList
            // 
            this.btn_deliveryList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deliveryList.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deliveryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deliveryList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliveryList.Location = new System.Drawing.Point(1371, 53);
            this.btn_deliveryList.Name = "btn_deliveryList";
            this.btn_deliveryList.Size = new System.Drawing.Size(140, 35);
            this.btn_deliveryList.TabIndex = 350;
            this.btn_deliveryList.Text = "Delivery List";
            this.btn_deliveryList.UseVisualStyleBackColor = true;
            this.btn_deliveryList.Click += new System.EventHandler(this.btn_deliveryList_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1517, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 76);
            this.button1.TabIndex = 349;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(9, 39);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(41, 15);
            this.customLabel1.TabIndex = 317;
            this.customLabel1.Text = "Driver";
            // 
            // cbo_drivers
            // 
            this.cbo_drivers.BackColor = System.Drawing.Color.White;
            this.cbo_drivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_drivers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_drivers.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_drivers.FormattingEnabled = true;
            this.cbo_drivers.Location = new System.Drawing.Point(56, 36);
            this.cbo_drivers.Name = "cbo_drivers";
            this.cbo_drivers.Size = new System.Drawing.Size(194, 23);
            this.cbo_drivers.TabIndex = 1;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(14, 68);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(36, 15);
            this.customLabel2.TabIndex = 319;
            this.customLabel2.Text = "Truck";
            // 
            // cbo_trucks
            // 
            this.cbo_trucks.BackColor = System.Drawing.Color.White;
            this.cbo_trucks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_trucks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_trucks.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_trucks.FormattingEnabled = true;
            this.cbo_trucks.Location = new System.Drawing.Point(56, 65);
            this.cbo_trucks.Name = "cbo_trucks";
            this.cbo_trucks.Size = new System.Drawing.Size(194, 23);
            this.cbo_trucks.TabIndex = 2;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(9, 12);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(85, 15);
            this.customLabel3.TabIndex = 327;
            this.customLabel3.Text = "Routing Date :";
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(1165, 39);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(115, 15);
            this.customLabel4.TabIndex = 341;
            this.customLabel4.Text = "The Routing Amount";
            // 
            // dateTimePicker_routingDate
            // 
            this.dateTimePicker_routingDate.BackColor = System.Drawing.Color.White;
            this.dateTimePicker_routingDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_routingDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker_routingDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_routingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_routingDate.Location = new System.Drawing.Point(94, 9);
            this.dateTimePicker_routingDate.Name = "dateTimePicker_routingDate";
            this.dateTimePicker_routingDate.Size = new System.Drawing.Size(85, 21);
            this.dateTimePicker_routingDate.TabIndex = 0;
            // 
            // txt_amount
            // 
            this.txt_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Enabled = false;
            this.txt_amount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_amount.Location = new System.Drawing.Point(1286, 36);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(79, 21);
            this.txt_amount.TabIndex = 340;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.gMapControl1.Location = new System.Drawing.Point(1020, 710);
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
            this.gMapControl1.Size = new System.Drawing.Size(296, 128);
            this.gMapControl1.TabIndex = 376;
            this.gMapControl1.Visible = false;
            this.gMapControl1.Zoom = 0D;
            // 
            // grid_RouteDeliveryPlan
            // 
            this.grid_RouteDeliveryPlan.AllowUserToAddRows = false;
            this.grid_RouteDeliveryPlan.AllowUserToDeleteRows = false;
            this.grid_RouteDeliveryPlan.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_RouteDeliveryPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.grid_RouteDeliveryPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_RouteDeliveryPlan.BackgroundColor = System.Drawing.Color.White;
            this.grid_RouteDeliveryPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_RouteDeliveryPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grid_RouteDeliveryPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_RouteDeliveryPlan.DefaultCellStyle = dataGridViewCellStyle15;
            this.grid_RouteDeliveryPlan.EnableHeadersVisualStyles = false;
            this.grid_RouteDeliveryPlan.GridColor = System.Drawing.Color.LightGray;
            this.grid_RouteDeliveryPlan.Location = new System.Drawing.Point(1322, 497);
            this.grid_RouteDeliveryPlan.MultiSelect = false;
            this.grid_RouteDeliveryPlan.Name = "grid_RouteDeliveryPlan";
            this.grid_RouteDeliveryPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_RouteDeliveryPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grid_RouteDeliveryPlan.RowHeadersVisible = false;
            this.grid_RouteDeliveryPlan.RowTemplate.Height = 19;
            this.grid_RouteDeliveryPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_RouteDeliveryPlan.Size = new System.Drawing.Size(267, 341);
            this.grid_RouteDeliveryPlan.StandardTab = true;
            this.grid_RouteDeliveryPlan.TabIndex = 826;
            this.grid_RouteDeliveryPlan.Visible = false;
            // 
            // grid_RouteHeader
            // 
            this.grid_RouteHeader.AllowUserToAddRows = false;
            this.grid_RouteHeader.AllowUserToDeleteRows = false;
            this.grid_RouteHeader.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_RouteHeader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.grid_RouteHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_RouteHeader.BackgroundColor = System.Drawing.Color.White;
            this.grid_RouteHeader.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_RouteHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.grid_RouteHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_RouteHeader.DefaultCellStyle = dataGridViewCellStyle19;
            this.grid_RouteHeader.EnableHeadersVisualStyles = false;
            this.grid_RouteHeader.GridColor = System.Drawing.Color.LightGray;
            this.grid_RouteHeader.Location = new System.Drawing.Point(8, 112);
            this.grid_RouteHeader.MultiSelect = false;
            this.grid_RouteHeader.Name = "grid_RouteHeader";
            this.grid_RouteHeader.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_RouteHeader.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.grid_RouteHeader.RowHeadersVisible = false;
            this.grid_RouteHeader.RowTemplate.Height = 19;
            this.grid_RouteHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_RouteHeader.Size = new System.Drawing.Size(438, 732);
            this.grid_RouteHeader.StandardTab = true;
            this.grid_RouteHeader.TabIndex = 337;
            this.grid_RouteHeader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RTTMPH_CellClick);
            this.grid_RouteHeader.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RouteHeader_CellDoubleClick);
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.Color.White;
            this.customTextBox2.Enabled = false;
            this.customTextBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.customTextBox2.Location = new System.Drawing.Point(531, 204);
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Size = new System.Drawing.Size(181, 21);
            this.customTextBox2.TabIndex = 343;
            this.customTextBox2.Visible = false;
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(475, 206);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(45, 16);
            this.customLabel5.TabIndex = 342;
            this.customLabel5.Text = "Weight";
            this.customLabel5.Visible = false;
            // 
            // customTextBox4
            // 
            this.customTextBox4.BackColor = System.Drawing.Color.White;
            this.customTextBox4.Font = new System.Drawing.Font("Arial", 9F);
            this.customTextBox4.Location = new System.Drawing.Point(531, 255);
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Size = new System.Drawing.Size(72, 21);
            this.customTextBox4.TabIndex = 346;
            this.customTextBox4.Visible = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.Color.White;
            this.customTextBox3.Font = new System.Drawing.Font("Arial", 9F);
            this.customTextBox3.Location = new System.Drawing.Point(531, 231);
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Size = new System.Drawing.Size(204, 21);
            this.customTextBox3.TabIndex = 345;
            this.customTextBox3.Visible = false;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(473, 233);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(52, 16);
            this.customLabel6.TabIndex = 344;
            this.customLabel6.Text = "Barcode";
            this.customLabel6.Visible = false;
            // 
            // grid_RouteDetail
            // 
            this.grid_RouteDetail.AllowUserToAddRows = false;
            this.grid_RouteDetail.AllowUserToDeleteRows = false;
            this.grid_RouteDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_RouteDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.grid_RouteDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_RouteDetail.BackgroundColor = System.Drawing.Color.White;
            this.grid_RouteDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_RouteDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grid_RouteDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_RouteDetail.DefaultCellStyle = dataGridViewCellStyle23;
            this.grid_RouteDetail.EnableHeadersVisualStyles = false;
            this.grid_RouteDetail.GridColor = System.Drawing.Color.LightGray;
            this.grid_RouteDetail.Location = new System.Drawing.Point(452, 112);
            this.grid_RouteDetail.MultiSelect = false;
            this.grid_RouteDetail.Name = "grid_RouteDetail";
            this.grid_RouteDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_RouteDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.grid_RouteDetail.RowHeadersVisible = false;
            this.grid_RouteDetail.RowTemplate.Height = 19;
            this.grid_RouteDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_RouteDetail.Size = new System.Drawing.Size(1149, 732);
            this.grid_RouteDetail.StandardTab = true;
            this.grid_RouteDetail.TabIndex = 338;
            this.grid_RouteDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RouteDetail_CellClick);
            this.grid_RouteDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RouteDetail_CellDoubleClick);
            this.grid_RouteDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RTTMPD_CellEndEdit);
            this.grid_RouteDetail.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RouteDetail_CellEnter);
            this.grid_RouteDetail.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_RouteDetail_ColumnHeaderMouseClick);
            this.grid_RouteDetail.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_RouteDetail_DataBindingComplete);
            this.grid_RouteDetail.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grid_RTTMPD_RowPostPaint);
            this.grid_RouteDetail.DragDrop += new System.Windows.Forms.DragEventHandler(this.grid_RTTMPD_DragDrop);
            this.grid_RouteDetail.DragOver += new System.Windows.Forms.DragEventHandler(this.grid_RTTMPD_DragOver);
            this.grid_RouteDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_RouteDetail_KeyDown);
            this.grid_RouteDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grid_RouteDetail_KeyPress);
            this.grid_RouteDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grid_RTTMPD_MouseDown);
            this.grid_RouteDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grid_RTTMPD_MouseMove);
            // 
            // PreparationPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1608, 850);
            this.Controls.Add(this.grid_RouteDeliveryPlan);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_createPrepPlan);
            this.Controls.Add(this.btn_bulkNutLabel);
            this.Controls.Add(this.btn_globalShortage);
            this.Controls.Add(this.btn_refresh2);
            this.Controls.Add(this.btn_updatePickZone);
            this.Controls.Add(this.grid_RouteHeader);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.btn_updateStopNo);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.btn_saveRouteOrders);
            this.Controls.Add(this.grid_RouteDetail);
            this.Name = "PreparationPlan";
            this.Text = "Preparation Plan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PreparationPlan_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteDeliveryPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Tools.CustomComboBox cbo_drivers;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomComboBox cbo_trucks;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_create;
        private Purchase.CustomDateTimePicker dateTimePicker_routingDate;
        private Tools.CustomLabel customLabel3;
        private System.Windows.Forms.Button btn_selectOrders;
        private System.Windows.Forms.Button btn_saveRouteOrders;
        private System.Windows.Forms.Button btn_deleteRouteOrders;
        private System.Windows.Forms.Button btn_createPrepPlan;
        private System.Windows.Forms.Button btn_updatePickZone;
        private System.Windows.Forms.Button btn_refresh2;
        private System.Windows.Forms.Button btn_globalShortage;
        private System.Windows.Forms.Button btn_bulkNutLabel;
        private CustomGrid grid_RouteHeader;
        private CustomGrid grid_RouteDetail;
        private System.Windows.Forms.CheckBox cbox_vendor;
        private CustomTextBox txt_amount;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel5;
        private CustomTextBox customTextBox2;
        private Tools.CustomLabel customLabel6;
        private CustomTextBox customTextBox3;
        private CustomTextBox customTextBox4;
        private System.Windows.Forms.Button btn_updateStopNo;
        private System.Windows.Forms.Button btn_createPickingList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_deliveryList;
        private System.Windows.Forms.Button btn_bulkNutLabelList;
        private CustomTextBox txt_TotalAmount;
        private Tools.CustomLabel customLabel7;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btn_DeleteAll;
        private System.Windows.Forms.Button btn_RouteMap;
        private System.Windows.Forms.Button btn_Sort;
        private Tools.CustomLabel customLabel8;
        private Tools.CustomComboBox cbo_SearchCode;
        private CustomGrid grid_RouteDeliveryPlan;
    }
}