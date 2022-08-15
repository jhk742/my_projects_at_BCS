namespace OBCS.Sales
{
    partial class ConfirmedSalesOrder
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
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lbl_todate = new System.Windows.Forms.Label();
            this.lbl_fromdate = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_multipleOrdersAmount = new OBCS.CustomTextBox();
            this.cbx_multipleOrders = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_salesRep = new OBCS.Tools.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_customerID = new OBCS.Tools.CustomComboBox();
            this.txt_TOA = new OBCS.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grid_ORDER = new OBCS.CustomGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(971, 36);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(88, 22);
            this.dateTimePickerTo.TabIndex = 2;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(971, 8);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(88, 22);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // lbl_todate
            // 
            this.lbl_todate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_todate.AutoSize = true;
            this.lbl_todate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_todate.Location = new System.Drawing.Point(946, 39);
            this.lbl_todate.Name = "lbl_todate";
            this.lbl_todate.Size = new System.Drawing.Size(19, 15);
            this.lbl_todate.TabIndex = 326;
            this.lbl_todate.Text = "To";
            // 
            // lbl_fromdate
            // 
            this.lbl_fromdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fromdate.AutoSize = true;
            this.lbl_fromdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fromdate.Location = new System.Drawing.Point(930, 11);
            this.lbl_fromdate.Name = "lbl_fromdate";
            this.lbl_fromdate.Size = new System.Drawing.Size(35, 15);
            this.lbl_fromdate.TabIndex = 325;
            this.lbl_fromdate.Text = "From";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1065, 7);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(104, 51);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Search";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.txt_multipleOrdersAmount);
            this.panel1.Controls.Add(this.cbx_multipleOrders);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbo_salesRep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbo_customerID);
            this.panel1.Controls.Add(this.txt_TOA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Controls.Add(this.lbl_fromdate);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.lbl_todate);
            this.panel1.Location = new System.Drawing.Point(13, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 65);
            this.panel1.TabIndex = 327;
            // 
            // txt_multipleOrdersAmount
            // 
            this.txt_multipleOrdersAmount.BackColor = System.Drawing.Color.White;
            this.txt_multipleOrdersAmount.Enabled = false;
            this.txt_multipleOrdersAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_multipleOrdersAmount.Location = new System.Drawing.Point(140, 33);
            this.txt_multipleOrdersAmount.Name = "txt_multipleOrdersAmount";
            this.txt_multipleOrdersAmount.Size = new System.Drawing.Size(149, 21);
            this.txt_multipleOrdersAmount.TabIndex = 726;
            this.txt_multipleOrdersAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbx_multipleOrders
            // 
            this.cbx_multipleOrders.AutoSize = true;
            this.cbx_multipleOrders.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_multipleOrders.Location = new System.Drawing.Point(140, 11);
            this.cbx_multipleOrders.Name = "cbx_multipleOrders";
            this.cbx_multipleOrders.Size = new System.Drawing.Size(152, 19);
            this.cbx_multipleOrders.TabIndex = 725;
            this.cbx_multipleOrders.Text = "Redundant Sales Order";
            this.cbx_multipleOrders.UseVisualStyleBackColor = true;
            this.cbx_multipleOrders.CheckedChanged += new System.EventHandler(this.cbx_multipleOrders_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 333;
            this.label3.Text = "Sales Rep.";
            // 
            // cbo_salesRep
            // 
            this.cbo_salesRep.BackColor = System.Drawing.Color.White;
            this.cbo_salesRep.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_salesRep.FormattingEnabled = true;
            this.cbo_salesRep.Location = new System.Drawing.Point(791, 36);
            this.cbo_salesRep.Name = "cbo_salesRep";
            this.cbo_salesRep.Size = new System.Drawing.Size(78, 23);
            this.cbo_salesRep.TabIndex = 332;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(714, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 331;
            this.label2.Text = "CustomerID";
            // 
            // cbo_customerID
            // 
            this.cbo_customerID.BackColor = System.Drawing.Color.White;
            this.cbo_customerID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_customerID.FormattingEnabled = true;
            this.cbo_customerID.Location = new System.Drawing.Point(791, 7);
            this.cbo_customerID.Name = "cbo_customerID";
            this.cbo_customerID.Size = new System.Drawing.Size(121, 23);
            this.cbo_customerID.TabIndex = 330;
            // 
            // txt_TOA
            // 
            this.txt_TOA.BackColor = System.Drawing.Color.White;
            this.txt_TOA.Enabled = false;
            this.txt_TOA.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_TOA.Location = new System.Drawing.Point(12, 33);
            this.txt_TOA.Name = "txt_TOA";
            this.txt_TOA.Size = new System.Drawing.Size(117, 21);
            this.txt_TOA.TabIndex = 329;
            this.txt_TOA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 328;
            this.label1.Text = "Total Order Amount";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1175, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_ORDER
            // 
            this.grid_ORDER.AllowUserToAddRows = false;
            this.grid_ORDER.AllowUserToDeleteRows = false;
            this.grid_ORDER.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_ORDER.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_ORDER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_ORDER.BackgroundColor = System.Drawing.Color.White;
            this.grid_ORDER.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ORDER.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_ORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_ORDER.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_ORDER.EnableHeadersVisualStyles = false;
            this.grid_ORDER.GridColor = System.Drawing.Color.LightGray;
            this.grid_ORDER.Location = new System.Drawing.Point(13, 75);
            this.grid_ORDER.MultiSelect = false;
            this.grid_ORDER.Name = "grid_ORDER";
            this.grid_ORDER.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_ORDER.RowHeadersVisible = false;
            this.grid_ORDER.RowTemplate.Height = 19;
            this.grid_ORDER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ORDER.Size = new System.Drawing.Size(1285, 605);
            this.grid_ORDER.StandardTab = true;
            this.grid_ORDER.TabIndex = 0;
            this.grid_ORDER.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ORDER_CellDoubleClick);
            this.grid_ORDER.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_ORDER_DataBindingComplete);
            this.grid_ORDER.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grid_ORDER_RowPostPaint);
            this.grid_ORDER.Sorted += new System.EventHandler(this.grid_ORDER_Sorted);
            // 
            // Order2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1310, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_ORDER);
            this.MinimumSize = new System.Drawing.Size(1326, 728);
            this.Name = "Order2";
            this.Text = "Comfirm Sales Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ORDER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGrid grid_ORDER;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lbl_todate;
        private System.Windows.Forms.Label lbl_fromdate;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private CustomTextBox txt_TOA;
        private Tools.CustomComboBox cbo_customerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Tools.CustomComboBox cbo_salesRep;
        private System.Windows.Forms.CheckBox cbx_multipleOrders;
        private CustomTextBox txt_multipleOrdersAmount;
    }
}