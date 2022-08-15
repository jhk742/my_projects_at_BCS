namespace OBCS.Sales
{
    partial class CommissionReportOld
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
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.grid_Commission = new OBCS.CustomGrid();
            this.cbx_SalesRep = new OBCS.Tools.CustomComboBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerTo = new OBCS.Purchase.CustomDateTimePicker();
            this.dateTimePickerFrom = new OBCS.Purchase.CustomDateTimePicker();
            this.btn_exportSummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Commission)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(682, 12);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(94, 50);
            this.btn_Export.TabIndex = 518;
            this.btn_Export.Text = "Export Detail";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(580, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(96, 50);
            this.btn_Search.TabIndex = 517;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // grid_Commission
            // 
            this.grid_Commission.AllowUserToAddRows = false;
            this.grid_Commission.AllowUserToDeleteRows = false;
            this.grid_Commission.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Commission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Commission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Commission.BackgroundColor = System.Drawing.Color.White;
            this.grid_Commission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Commission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Commission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Commission.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Commission.EnableHeadersVisualStyles = false;
            this.grid_Commission.GridColor = System.Drawing.Color.LightGray;
            this.grid_Commission.Location = new System.Drawing.Point(12, 68);
            this.grid_Commission.MultiSelect = false;
            this.grid_Commission.Name = "grid_Commission";
            this.grid_Commission.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_Commission.RowHeadersVisible = false;
            this.grid_Commission.RowTemplate.Height = 19;
            this.grid_Commission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Commission.Size = new System.Drawing.Size(883, 779);
            this.grid_Commission.StandardTab = true;
            this.grid_Commission.TabIndex = 521;
            this.grid_Commission.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_Commission_DataBindingComplete);
            // 
            // cbx_SalesRep
            // 
            this.cbx_SalesRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_SalesRep.BackColor = System.Drawing.Color.White;
            this.cbx_SalesRep.Font = new System.Drawing.Font("Arial", 9F);
            this.cbx_SalesRep.FormattingEnabled = true;
            this.cbx_SalesRep.Location = new System.Drawing.Point(233, 39);
            this.cbx_SalesRep.Name = "cbx_SalesRep";
            this.cbx_SalesRep.Size = new System.Drawing.Size(63, 23);
            this.cbx_SalesRep.TabIndex = 520;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel4.Location = new System.Drawing.Point(198, 44);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(29, 15);
            this.customLabel4.TabIndex = 519;
            this.customLabel4.Text = "Rep";
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(451, 44);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(23, 15);
            this.customLabel2.TabIndex = 516;
            this.customLabel2.Text = "TO";
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(305, 44);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(40, 15);
            this.customLabel5.TabIndex = 515;
            this.customLabel5.Text = "FROM";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.BackColor = System.Drawing.Color.White;
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(480, 41);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(94, 21);
            this.dateTimePickerTo.TabIndex = 514;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.BackColor = System.Drawing.Color.White;
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFrom.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(351, 41);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(94, 21);
            this.dateTimePickerFrom.TabIndex = 513;
            // 
            // btn_exportSummary
            // 
            this.btn_exportSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exportSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_exportSummary.FlatAppearance.BorderSize = 0;
            this.btn_exportSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportSummary.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportSummary.ForeColor = System.Drawing.Color.White;
            this.btn_exportSummary.Location = new System.Drawing.Point(782, 12);
            this.btn_exportSummary.Name = "btn_exportSummary";
            this.btn_exportSummary.Size = new System.Drawing.Size(113, 50);
            this.btn_exportSummary.TabIndex = 522;
            this.btn_exportSummary.Text = "Export Summary";
            this.btn_exportSummary.UseVisualStyleBackColor = false;
            this.btn_exportSummary.Click += new System.EventHandler(this.btn_exportSummary_Click);
            // 
            // CommissionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 859);
            this.Controls.Add(this.btn_exportSummary);
            this.Controls.Add(this.grid_Commission);
            this.Controls.Add(this.cbx_SalesRep);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.btn_Search);
            this.Name = "CommissionReport";
            this.Text = "Commission Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Commission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_Commission;
        private Tools.CustomComboBox cbx_SalesRep;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.Button btn_Export;
        private Tools.CustomLabel customLabel5;
        private System.Windows.Forms.Button btn_Search;
        private Purchase.CustomDateTimePicker dateTimePickerTo;
        private Purchase.CustomDateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btn_exportSummary;
    }
}