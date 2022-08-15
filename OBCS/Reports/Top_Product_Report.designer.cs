namespace OBCS.Reports
{
    partial class Top_Product_Report
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
            this.btn_exportDetail = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_exportSummary = new System.Windows.Forms.Button();
            this.rad_ShowAll = new System.Windows.Forms.RadioButton();
            this.rad_Top20A = new System.Windows.Forms.RadioButton();
            this.rad_Top20Q = new System.Windows.Forms.RadioButton();
            this.cbo_Salerep = new System.Windows.Forms.ComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.grid_Top_detail = new OBCS.CustomGrid();
            this.DateTimePickerTo = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.DateTimePickerFrom = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_ProductID = new OBCS.CustomTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.grid_Top_Summary = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Top_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Top_Summary)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exportDetail
            // 
            this.btn_exportDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_exportDetail.FlatAppearance.BorderSize = 0;
            this.btn_exportDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportDetail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportDetail.ForeColor = System.Drawing.Color.White;
            this.btn_exportDetail.Location = new System.Drawing.Point(626, 42);
            this.btn_exportDetail.Name = "btn_exportDetail";
            this.btn_exportDetail.Size = new System.Drawing.Size(104, 40);
            this.btn_exportDetail.TabIndex = 652;
            this.btn_exportDetail.Text = "Export Detail";
            this.btn_exportDetail.UseVisualStyleBackColor = false;
            this.btn_exportDetail.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(409, 41);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(83, 41);
            this.btn_refresh.TabIndex = 651;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_exportSummary
            // 
            this.btn_exportSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_exportSummary.FlatAppearance.BorderSize = 0;
            this.btn_exportSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportSummary.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportSummary.ForeColor = System.Drawing.Color.White;
            this.btn_exportSummary.Location = new System.Drawing.Point(498, 41);
            this.btn_exportSummary.Name = "btn_exportSummary";
            this.btn_exportSummary.Size = new System.Drawing.Size(122, 41);
            this.btn_exportSummary.TabIndex = 656;
            this.btn_exportSummary.Text = "Export Summary";
            this.btn_exportSummary.UseVisualStyleBackColor = false;
            this.btn_exportSummary.Click += new System.EventHandler(this.btn_Summaryexport_Click);
            // 
            // rad_ShowAll
            // 
            this.rad_ShowAll.AutoSize = true;
            this.rad_ShowAll.Checked = true;
            this.rad_ShowAll.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rad_ShowAll.Location = new System.Drawing.Point(12, 12);
            this.rad_ShowAll.Name = "rad_ShowAll";
            this.rad_ShowAll.Size = new System.Drawing.Size(76, 21);
            this.rad_ShowAll.TabIndex = 657;
            this.rad_ShowAll.TabStop = true;
            this.rad_ShowAll.Text = "Show All";
            this.rad_ShowAll.UseVisualStyleBackColor = true;
            // 
            // rad_Top20A
            // 
            this.rad_Top20A.AutoSize = true;
            this.rad_Top20A.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rad_Top20A.Location = new System.Drawing.Point(217, 13);
            this.rad_Top20A.Name = "rad_Top20A";
            this.rad_Top20A.Size = new System.Drawing.Size(116, 21);
            this.rad_Top20A.TabIndex = 658;
            this.rad_Top20A.Text = "Top 20 Amount";
            this.rad_Top20A.UseVisualStyleBackColor = true;
            // 
            // rad_Top20Q
            // 
            this.rad_Top20Q.AutoSize = true;
            this.rad_Top20Q.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.rad_Top20Q.Location = new System.Drawing.Point(107, 13);
            this.rad_Top20Q.Name = "rad_Top20Q";
            this.rad_Top20Q.Size = new System.Drawing.Size(90, 21);
            this.rad_Top20Q.TabIndex = 659;
            this.rad_Top20Q.Text = "Top 20 Qty";
            this.rad_Top20Q.UseVisualStyleBackColor = true;
            // 
            // cbo_Salerep
            // 
            this.cbo_Salerep.FormattingEnabled = true;
            this.cbo_Salerep.Location = new System.Drawing.Point(12, 59);
            this.cbo_Salerep.Name = "cbo_Salerep";
            this.cbo_Salerep.Size = new System.Drawing.Size(77, 23);
            this.cbo_Salerep.TabIndex = 662;
            this.cbo_Salerep.SelectedIndexChanged += new System.EventHandler(this.cbo_Salerep_SelectedIndexChanged);
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(9, 41);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(64, 15);
            this.customLabel1.TabIndex = 660;
            this.customLabel1.Text = "Sales Man";
            // 
            // grid_Top_detail
            // 
            this.grid_Top_detail.AllowUserToAddRows = false;
            this.grid_Top_detail.AllowUserToDeleteRows = false;
            this.grid_Top_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Top_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Top_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Top_detail.BackgroundColor = System.Drawing.Color.White;
            this.grid_Top_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Top_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Top_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Top_detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Top_detail.EnableHeadersVisualStyles = false;
            this.grid_Top_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_Top_detail.Location = new System.Drawing.Point(498, 88);
            this.grid_Top_detail.MultiSelect = false;
            this.grid_Top_detail.Name = "grid_Top_detail";
            this.grid_Top_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_Top_detail.RowHeadersVisible = false;
            this.grid_Top_detail.RowTemplate.Height = 19;
            this.grid_Top_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Top_detail.Size = new System.Drawing.Size(1024, 651);
            this.grid_Top_detail.StandardTab = true;
            this.grid_Top_detail.TabIndex = 653;
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.BackColor = System.Drawing.Color.White;
            this.DateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerTo.CustomFormat = " MM/dd/yyyy";
            this.DateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerTo.Location = new System.Drawing.Point(297, 61);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(106, 21);
            this.DateTimePickerTo.TabIndex = 13;
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(294, 41);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(19, 15);
            this.customLabel5.TabIndex = 12;
            this.customLabel5.Text = "To";
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.BackColor = System.Drawing.Color.White;
            this.DateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerFrom.CustomFormat = " MM/dd/yyyy";
            this.DateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerFrom.Location = new System.Drawing.Point(182, 61);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(109, 21);
            this.DateTimePickerFrom.TabIndex = 11;
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(179, 41);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(35, 15);
            this.customLabel4.TabIndex = 10;
            this.customLabel4.Text = "From";
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BackColor = System.Drawing.Color.White;
            this.txt_ProductID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ProductID.Location = new System.Drawing.Point(95, 61);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(81, 21);
            this.txt_ProductID.TabIndex = 9;
            this.txt_ProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductID_KeyPress);
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(95, 41);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(65, 15);
            this.customLabel3.TabIndex = 8;
            this.customLabel3.Text = "Product ID";
            // 
            // grid_Top_Summary
            // 
            this.grid_Top_Summary.AllowUserToAddRows = false;
            this.grid_Top_Summary.AllowUserToDeleteRows = false;
            this.grid_Top_Summary.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Top_Summary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Top_Summary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_Top_Summary.BackgroundColor = System.Drawing.Color.White;
            this.grid_Top_Summary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Top_Summary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_Top_Summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Top_Summary.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_Top_Summary.EnableHeadersVisualStyles = false;
            this.grid_Top_Summary.GridColor = System.Drawing.Color.LightGray;
            this.grid_Top_Summary.Location = new System.Drawing.Point(12, 88);
            this.grid_Top_Summary.MultiSelect = false;
            this.grid_Top_Summary.Name = "grid_Top_Summary";
            this.grid_Top_Summary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_Top_Summary.RowHeadersVisible = false;
            this.grid_Top_Summary.RowTemplate.Height = 19;
            this.grid_Top_Summary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Top_Summary.Size = new System.Drawing.Size(480, 651);
            this.grid_Top_Summary.StandardTab = true;
            this.grid_Top_Summary.TabIndex = 3;
            this.grid_Top_Summary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Top_Summary_CellClick);
            // 
            // Top_Product_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 751);
            this.Controls.Add(this.cbo_Salerep);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.rad_Top20Q);
            this.Controls.Add(this.rad_Top20A);
            this.Controls.Add(this.rad_ShowAll);
            this.Controls.Add(this.btn_exportSummary);
            this.Controls.Add(this.grid_Top_detail);
            this.Controls.Add(this.btn_exportDetail);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.DateTimePickerTo);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.DateTimePickerFrom);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.grid_Top_Summary);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.MinimumSize = new System.Drawing.Size(1550, 790);
            this.Name = "Top_Product_Report";
            this.Text = "Sales by Product Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Top_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Top_Summary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomGrid grid_Top_Summary;
        private Purchase.CustomDateTimePicker DateTimePickerTo;
        private Tools.CustomLabel customLabel5;
        private Purchase.CustomDateTimePicker DateTimePickerFrom;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_ProductID;
        private Tools.CustomLabel customLabel3;
        private System.Windows.Forms.Button btn_exportDetail;
        private System.Windows.Forms.Button btn_refresh;
        private CustomGrid grid_Top_detail;
        private System.Windows.Forms.Button btn_exportSummary;
        private System.Windows.Forms.RadioButton rad_ShowAll;
        private System.Windows.Forms.RadioButton rad_Top20A;
        private System.Windows.Forms.RadioButton rad_Top20Q;
        private Tools.CustomLabel customLabel1;
        private System.Windows.Forms.ComboBox cbo_Salerep;
    }
}