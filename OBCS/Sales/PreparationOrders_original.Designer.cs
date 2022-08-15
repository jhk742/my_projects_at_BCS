namespace OBCS.Sales
{
    partial class PreparationOrders_original
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
            this.txt_weight = new OBCS.CustomTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.txt_amount = new OBCS.CustomTextBox();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_orders = new OBCS.CustomTextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_addToRoutePlan = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.cbo_city = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.grid_ORDERS = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDERS)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_weight
            // 
            this.txt_weight.BackColor = System.Drawing.Color.OldLace;
            this.txt_weight.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_weight.Location = new System.Drawing.Point(839, 26);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(117, 21);
            this.txt_weight.TabIndex = 368;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(793, 28);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(45, 16);
            this.customLabel6.TabIndex = 367;
            this.customLabel6.Text = "Weight";
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.OldLace;
            this.txt_amount.Enabled = false;
            this.txt_amount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_amount.Location = new System.Drawing.Point(646, 26);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(141, 21);
            this.txt_amount.TabIndex = 366;
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(595, 28);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(50, 16);
            this.customLabel5.TabIndex = 365;
            this.customLabel5.Text = "Amount";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(504, 28);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(43, 16);
            this.customLabel4.TabIndex = 364;
            this.customLabel4.Text = "Orders";
            // 
            // txt_orders
            // 
            this.txt_orders.BackColor = System.Drawing.Color.OldLace;
            this.txt_orders.Enabled = false;
            this.txt_orders.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_orders.Location = new System.Drawing.Point(548, 26);
            this.txt_orders.Name = "txt_orders";
            this.txt_orders.Size = new System.Drawing.Size(41, 21);
            this.txt_orders.TabIndex = 363;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1326, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 40);
            this.btn_exit.TabIndex = 361;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_addToRoutePlan
            // 
            this.btn_addToRoutePlan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToRoutePlan.Location = new System.Drawing.Point(1182, 9);
            this.btn_addToRoutePlan.Name = "btn_addToRoutePlan";
            this.btn_addToRoutePlan.Size = new System.Drawing.Size(138, 40);
            this.btn_addToRoutePlan.TabIndex = 360;
            this.btn_addToRoutePlan.Text = "Add To Route Plan";
            this.btn_addToRoutePlan.UseVisualStyleBackColor = true;
            this.btn_addToRoutePlan.Click += new System.EventHandler(this.btn_addToRoutePlan_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(365, 9);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(81, 40);
            this.btn_refresh.TabIndex = 353;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_filter
            // 
            this.btn_filter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.Location = new System.Drawing.Point(278, 9);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(81, 40);
            this.btn_filter.TabIndex = 352;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            // 
            // cbo_city
            // 
            this.cbo_city.BackColor = System.Drawing.Color.OldLace;
            this.cbo_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_city.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_city.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_city.FormattingEnabled = true;
            this.cbo_city.Location = new System.Drawing.Point(15, 26);
            this.cbo_city.Name = "cbo_city";
            this.cbo_city.Size = new System.Drawing.Size(257, 23);
            this.cbo_city.TabIndex = 349;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(12, 9);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(33, 16);
            this.customLabel1.TabIndex = 348;
            this.customLabel1.Text = "CITY";
            // 
            // grid_ORDERS
            // 
            this.grid_ORDERS.AllowUserToAddRows = false;
            this.grid_ORDERS.AllowUserToDeleteRows = false;
            this.grid_ORDERS.AllowUserToResizeRows = false;
            this.grid_ORDERS.BackgroundColor = System.Drawing.Color.White;
            this.grid_ORDERS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_ORDERS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ORDERS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_ORDERS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_ORDERS.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_ORDERS.EnableHeadersVisualStyles = false;
            this.grid_ORDERS.GridColor = System.Drawing.Color.LightGray;
            this.grid_ORDERS.Location = new System.Drawing.Point(12, 55);
            this.grid_ORDERS.MultiSelect = false;
            this.grid_ORDERS.Name = "grid_ORDERS";
            this.grid_ORDERS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_ORDERS.RowHeadersVisible = false;
            this.grid_ORDERS.RowTemplate.Height = 19;
            this.grid_ORDERS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ORDERS.Size = new System.Drawing.Size(1413, 738);
            this.grid_ORDERS.StandardTab = true;
            this.grid_ORDERS.TabIndex = 369;
            this.grid_ORDERS.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grid_ORDERS_RowPostPaint);
            // 
            // PreparationOrders_original
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 805);
            this.Controls.Add(this.grid_ORDERS);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_orders);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_addToRoutePlan);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.cbo_city);
            this.Controls.Add(this.customLabel1);
            this.Name = "PreparationOrders_original";
            this.Text = "PreparationOrders";
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDERS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox txt_weight;
        private Tools.CustomLabel customLabel6;
        private CustomTextBox txt_amount;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_orders;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_addToRoutePlan;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_filter;
        private Tools.CustomComboBox cbo_city;
        private Tools.CustomLabel customLabel1;
        private CustomGrid grid_ORDERS;
    }
}