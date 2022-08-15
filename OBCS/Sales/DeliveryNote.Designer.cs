namespace OBCS.Sales
{
    partial class DeliveryNote
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
            this.cbox_vendor = new System.Windows.Forms.CheckBox();
            this.btn_deliveryList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deliveryList2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkbox_Laser = new System.Windows.Forms.CheckBox();
            this.checkbox_Matrix = new System.Windows.Forms.CheckBox();
            this.Date = new OBCS.Tools.CustomLabel();
            this.dateTimePicker_receiptDate = new OBCS.Purchase.CustomDateTimePicker();
            this.grid_PickingNumber = new OBCS.CustomGrid();
            this.grid_RouteDetail = new OBCS.CustomGrid();
            this.grid_RouteHeader = new OBCS.CustomGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PickingNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_vendor
            // 
            this.cbox_vendor.AutoSize = true;
            this.cbox_vendor.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_vendor.Location = new System.Drawing.Point(166, 29);
            this.cbox_vendor.Name = "cbox_vendor";
            this.cbox_vendor.Size = new System.Drawing.Size(66, 19);
            this.cbox_vendor.TabIndex = 364;
            this.cbox_vendor.Text = "Vendor";
            this.cbox_vendor.UseVisualStyleBackColor = true;
            this.cbox_vendor.CheckedChanged += new System.EventHandler(this.cbox_vendor_CheckedChanged);
            // 
            // btn_deliveryList
            // 
            this.btn_deliveryList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deliveryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_deliveryList.FlatAppearance.BorderSize = 0;
            this.btn_deliveryList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deliveryList.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliveryList.ForeColor = System.Drawing.Color.White;
            this.btn_deliveryList.Location = new System.Drawing.Point(1083, 10);
            this.btn_deliveryList.Name = "btn_deliveryList";
            this.btn_deliveryList.Size = new System.Drawing.Size(220, 54);
            this.btn_deliveryList.TabIndex = 366;
            this.btn_deliveryList.Text = "Create Delivery Invoice";
            this.btn_deliveryList.UseVisualStyleBackColor = false;
            this.btn_deliveryList.Click += new System.EventHandler(this.btn_deliveryList_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.checkbox_Matrix);
            this.panel1.Controls.Add(this.checkbox_Laser);
            this.panel1.Controls.Add(this.btn_deliveryList2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_deliveryList);
            this.panel1.Controls.Add(this.cbox_vendor);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.dateTimePicker_receiptDate);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 74);
            this.panel1.TabIndex = 368;
            // 
            // btn_deliveryList2
            // 
            this.btn_deliveryList2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deliveryList2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_deliveryList2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deliveryList2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deliveryList2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliveryList2.ForeColor = System.Drawing.Color.White;
            this.btn_deliveryList2.Location = new System.Drawing.Point(933, 10);
            this.btn_deliveryList2.Name = "btn_deliveryList2";
            this.btn_deliveryList2.Size = new System.Drawing.Size(144, 54);
            this.btn_deliveryList2.TabIndex = 370;
            this.btn_deliveryList2.Text = "Delivery List";
            this.btn_deliveryList2.UseVisualStyleBackColor = false;
            this.btn_deliveryList2.Click += new System.EventHandler(this.btn_deliveryList2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1309, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 54);
            this.button1.TabIndex = 369;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbox_Laser
            // 
            this.checkbox_Laser.AutoSize = true;
            this.checkbox_Laser.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_Laser.Location = new System.Drawing.Point(370, 26);
            this.checkbox_Laser.Name = "checkbox_Laser";
            this.checkbox_Laser.Size = new System.Drawing.Size(55, 19);
            this.checkbox_Laser.TabIndex = 371;
            this.checkbox_Laser.Text = "Laser";
            this.checkbox_Laser.UseVisualStyleBackColor = true;
            this.checkbox_Laser.CheckedChanged += new System.EventHandler(this.checkbox_Laser_CheckedChanged);
            // 
            // checkbox_Matrix
            // 
            this.checkbox_Matrix.AutoSize = true;
            this.checkbox_Matrix.Checked = true;
            this.checkbox_Matrix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_Matrix.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_Matrix.Location = new System.Drawing.Point(370, 45);
            this.checkbox_Matrix.Name = "checkbox_Matrix";
            this.checkbox_Matrix.Size = new System.Drawing.Size(62, 19);
            this.checkbox_Matrix.TabIndex = 372;
            this.checkbox_Matrix.Text = "Matrix";
            this.checkbox_Matrix.UseVisualStyleBackColor = true;
            this.checkbox_Matrix.CheckedChanged += new System.EventHandler(this.checkbox_Matrix_CheckedChanged);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(31, 30);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(38, 15);
            this.Date.TabIndex = 358;
            this.Date.Text = "Date :";
            // 
            // dateTimePicker_receiptDate
            // 
            this.dateTimePicker_receiptDate.BackColor = System.Drawing.Color.White;
            this.dateTimePicker_receiptDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_receiptDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker_receiptDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_receiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_receiptDate.Location = new System.Drawing.Point(75, 27);
            this.dateTimePicker_receiptDate.Name = "dateTimePicker_receiptDate";
            this.dateTimePicker_receiptDate.Size = new System.Drawing.Size(85, 21);
            this.dateTimePicker_receiptDate.TabIndex = 357;
            this.dateTimePicker_receiptDate.ValueChanged += new System.EventHandler(this.dateTimePicker_receiptDate_ValueChanged);
            // 
            // grid_PickingNumber
            // 
            this.grid_PickingNumber.AllowUserToAddRows = false;
            this.grid_PickingNumber.AllowUserToDeleteRows = false;
            this.grid_PickingNumber.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_PickingNumber.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_PickingNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_PickingNumber.BackgroundColor = System.Drawing.Color.White;
            this.grid_PickingNumber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_PickingNumber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_PickingNumber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_PickingNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_PickingNumber.EnableHeadersVisualStyles = false;
            this.grid_PickingNumber.GridColor = System.Drawing.Color.LightGray;
            this.grid_PickingNumber.Location = new System.Drawing.Point(1083, 84);
            this.grid_PickingNumber.MultiSelect = false;
            this.grid_PickingNumber.Name = "grid_PickingNumber";
            this.grid_PickingNumber.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_PickingNumber.RowHeadersVisible = false;
            this.grid_PickingNumber.RowTemplate.Height = 19;
            this.grid_PickingNumber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_PickingNumber.Size = new System.Drawing.Size(347, 653);
            this.grid_PickingNumber.StandardTab = true;
            this.grid_PickingNumber.TabIndex = 365;
            // 
            // grid_RouteDetail
            // 
            this.grid_RouteDetail.AllowUserToAddRows = false;
            this.grid_RouteDetail.AllowUserToDeleteRows = false;
            this.grid_RouteDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_RouteDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_RouteDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_RouteDetail.BackgroundColor = System.Drawing.Color.White;
            this.grid_RouteDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_RouteDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_RouteDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_RouteDetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_RouteDetail.EnableHeadersVisualStyles = false;
            this.grid_RouteDetail.GridColor = System.Drawing.Color.LightGray;
            this.grid_RouteDetail.Location = new System.Drawing.Point(382, 84);
            this.grid_RouteDetail.MultiSelect = false;
            this.grid_RouteDetail.Name = "grid_RouteDetail";
            this.grid_RouteDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_RouteDetail.RowHeadersVisible = false;
            this.grid_RouteDetail.RowTemplate.Height = 19;
            this.grid_RouteDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_RouteDetail.Size = new System.Drawing.Size(695, 653);
            this.grid_RouteDetail.StandardTab = true;
            this.grid_RouteDetail.TabIndex = 363;
            this.grid_RouteDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RouteDetail_CellClick);
            this.grid_RouteDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RouteDetail_CellDoubleClick);
            this.grid_RouteDetail.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RouteDetail_CellEnter);
            this.grid_RouteDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_RouteDetail_KeyDown);
            this.grid_RouteDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grid_RouteDetail_KeyPress);
            // 
            // grid_RouteHeader
            // 
            this.grid_RouteHeader.AllowUserToAddRows = false;
            this.grid_RouteHeader.AllowUserToDeleteRows = false;
            this.grid_RouteHeader.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_RouteHeader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_RouteHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_RouteHeader.BackgroundColor = System.Drawing.Color.White;
            this.grid_RouteHeader.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_RouteHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_RouteHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_RouteHeader.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_RouteHeader.EnableHeadersVisualStyles = false;
            this.grid_RouteHeader.GridColor = System.Drawing.Color.LightGray;
            this.grid_RouteHeader.Location = new System.Drawing.Point(12, 84);
            this.grid_RouteHeader.MultiSelect = false;
            this.grid_RouteHeader.Name = "grid_RouteHeader";
            this.grid_RouteHeader.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_RouteHeader.RowHeadersVisible = false;
            this.grid_RouteHeader.RowTemplate.Height = 19;
            this.grid_RouteHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_RouteHeader.Size = new System.Drawing.Size(364, 653);
            this.grid_RouteHeader.StandardTab = true;
            this.grid_RouteHeader.TabIndex = 362;
            this.grid_RouteHeader.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_RouteHeader_CellEnter);
            // 
            // DeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1442, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_PickingNumber);
            this.Controls.Add(this.grid_RouteDetail);
            this.Controls.Add(this.grid_RouteHeader);
            this.MinimumSize = new System.Drawing.Size(1022, 726);
            this.Name = "DeliveryNote";
            this.Text = "Delivery Note";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PickingNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_RouteHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cbox_vendor;
        private CustomGrid grid_RouteDetail;
        private CustomGrid grid_RouteHeader;
        private Purchase.CustomDateTimePicker dateTimePicker_receiptDate;
        private Tools.CustomLabel Date;
        private CustomGrid grid_PickingNumber;
        private System.Windows.Forms.Button btn_deliveryList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_deliveryList2;
        private System.Windows.Forms.CheckBox checkbox_Matrix;
        private System.Windows.Forms.CheckBox checkbox_Laser;
    }
}