namespace OBCS.Account
{
    partial class ChartOfAccount
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.txt_totalLedgerPosting = new OBCS.CustomTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_totalLedgerCredit = new OBCS.CustomTextBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_totalLedgerDebit = new OBCS.CustomTextBox();
            this.customLabel22 = new OBCS.Tools.CustomLabel();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.grid_detail = new OBCS.CustomGrid();
            this.grid_header = new OBCS.CustomGrid();
            this.btn_exportHeader = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.cbo_company = new OBCS.Tools.CustomComboBox();
            this.customLabel12 = new OBCS.Tools.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 22);
            this.dateTimePicker1.TabIndex = 704;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(104, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(86, 22);
            this.dateTimePicker2.TabIndex = 705;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(225, 179);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(127, 37);
            this.btn_refresh.TabIndex = 708;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Visible = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(382, 38);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(100, 37);
            this.btn_export.TabIndex = 716;
            this.btn_export.Text = "Export Detail";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // txt_totalLedgerPosting
            // 
            this.txt_totalLedgerPosting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalLedgerPosting.BackColor = System.Drawing.Color.White;
            this.txt_totalLedgerPosting.Enabled = false;
            this.txt_totalLedgerPosting.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalLedgerPosting.Location = new System.Drawing.Point(641, 54);
            this.txt_totalLedgerPosting.Name = "txt_totalLedgerPosting";
            this.txt_totalLedgerPosting.Size = new System.Drawing.Size(159, 21);
            this.txt_totalLedgerPosting.TabIndex = 713;
            this.txt_totalLedgerPosting.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(520, 57);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(115, 15);
            this.customLabel3.TabIndex = 714;
            this.customLabel3.Text = "Total Ledger Posting";
            // 
            // txt_totalLedgerCredit
            // 
            this.txt_totalLedgerCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalLedgerCredit.BackColor = System.Drawing.Color.White;
            this.txt_totalLedgerCredit.Enabled = false;
            this.txt_totalLedgerCredit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalLedgerCredit.Location = new System.Drawing.Point(1195, 54);
            this.txt_totalLedgerCredit.Name = "txt_totalLedgerCredit";
            this.txt_totalLedgerCredit.Size = new System.Drawing.Size(159, 21);
            this.txt_totalLedgerCredit.TabIndex = 711;
            this.txt_totalLedgerCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(1081, 57);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(108, 15);
            this.customLabel4.TabIndex = 712;
            this.customLabel4.Text = "Total Ledger Credit";
            // 
            // txt_totalLedgerDebit
            // 
            this.txt_totalLedgerDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalLedgerDebit.BackColor = System.Drawing.Color.White;
            this.txt_totalLedgerDebit.Enabled = false;
            this.txt_totalLedgerDebit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalLedgerDebit.Location = new System.Drawing.Point(916, 54);
            this.txt_totalLedgerDebit.Name = "txt_totalLedgerDebit";
            this.txt_totalLedgerDebit.Size = new System.Drawing.Size(159, 21);
            this.txt_totalLedgerDebit.TabIndex = 709;
            this.txt_totalLedgerDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel22
            // 
            this.customLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel22.AutoSize = true;
            this.customLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel22.Location = new System.Drawing.Point(806, 57);
            this.customLabel22.Name = "customLabel22";
            this.customLabel22.Size = new System.Drawing.Size(104, 15);
            this.customLabel22.TabIndex = 710;
            this.customLabel22.Text = "Total Ledger Debit";
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(101, 35);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(19, 15);
            this.customLabel1.TabIndex = 707;
            this.customLabel1.Text = "To";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(9, 35);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(35, 15);
            this.customLabel2.TabIndex = 706;
            this.customLabel2.Text = "From";
            // 
            // grid_detail
            // 
            this.grid_detail.AllowUserToAddRows = false;
            this.grid_detail.AllowUserToDeleteRows = false;
            this.grid_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_detail.BackgroundColor = System.Drawing.Color.White;
            this.grid_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_detail.EnableHeadersVisualStyles = false;
            this.grid_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_detail.Location = new System.Drawing.Point(382, 81);
            this.grid_detail.MultiSelect = false;
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_detail.RowHeadersVisible = false;
            this.grid_detail.RowTemplate.Height = 19;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(975, 656);
            this.grid_detail.StandardTab = true;
            this.grid_detail.TabIndex = 703;
            this.grid_detail.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_detail_DataBindingComplete);
            // 
            // grid_header
            // 
            this.grid_header.AllowUserToAddRows = false;
            this.grid_header.AllowUserToDeleteRows = false;
            this.grid_header.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_header.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_header.BackgroundColor = System.Drawing.Color.White;
            this.grid_header.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_header.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_header.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_header.EnableHeadersVisualStyles = false;
            this.grid_header.GridColor = System.Drawing.Color.LightGray;
            this.grid_header.Location = new System.Drawing.Point(12, 81);
            this.grid_header.MultiSelect = false;
            this.grid_header.Name = "grid_header";
            this.grid_header.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_header.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_header.RowHeadersVisible = false;
            this.grid_header.RowTemplate.Height = 19;
            this.grid_header.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_header.Size = new System.Drawing.Size(364, 656);
            this.grid_header.StandardTab = true;
            this.grid_header.TabIndex = 1;
            this.grid_header.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_header_CellDoubleClick);
            this.grid_header.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_header_CellEnter);
            // 
            // btn_exportHeader
            // 
            this.btn_exportHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_exportHeader.FlatAppearance.BorderSize = 0;
            this.btn_exportHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportHeader.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportHeader.ForeColor = System.Drawing.Color.White;
            this.btn_exportHeader.Location = new System.Drawing.Point(264, 38);
            this.btn_exportHeader.Name = "btn_exportHeader";
            this.btn_exportHeader.Size = new System.Drawing.Size(112, 37);
            this.btn_exportHeader.TabIndex = 717;
            this.btn_exportHeader.Text = "Export Header";
            this.btn_exportHeader.UseVisualStyleBackColor = false;
            this.btn_exportHeader.Click += new System.EventHandler(this.btn_exportHeader_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_new.FlatAppearance.BorderSize = 0;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(196, 38);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(62, 37);
            this.btn_new.TabIndex = 718;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // cbo_company
            // 
            this.cbo_company.BackColor = System.Drawing.Color.White;
            this.cbo_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_company.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_company.FormattingEnabled = true;
            this.cbo_company.Location = new System.Drawing.Point(73, 6);
            this.cbo_company.Name = "cbo_company";
            this.cbo_company.Size = new System.Drawing.Size(303, 23);
            this.cbo_company.TabIndex = 815;
            // 
            // customLabel12
            // 
            this.customLabel12.AutoSize = true;
            this.customLabel12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel12.Location = new System.Drawing.Point(9, 9);
            this.customLabel12.Name = "customLabel12";
            this.customLabel12.Size = new System.Drawing.Size(58, 15);
            this.customLabel12.TabIndex = 816;
            this.customLabel12.Text = "Company";
            // 
            // ChartOfAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 749);
            this.Controls.Add(this.cbo_company);
            this.Controls.Add(this.customLabel12);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_exportHeader);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.txt_totalLedgerPosting);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.txt_totalLedgerCredit);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_totalLedgerDebit);
            this.Controls.Add(this.customLabel22);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grid_detail);
            this.Controls.Add(this.grid_header);
            this.Name = "ChartOfAccount";
            this.Text = "Chart of account";
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_header;
        private CustomGrid grid_detail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomLabel customLabel1;
        private System.Windows.Forms.Button btn_refresh;
        private CustomTextBox txt_totalLedgerCredit;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_totalLedgerDebit;
        private Tools.CustomLabel customLabel22;
        private CustomTextBox txt_totalLedgerPosting;
        private Tools.CustomLabel customLabel3;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_exportHeader;
        private System.Windows.Forms.Button btn_new;
        private Tools.CustomComboBox cbo_company;
        private Tools.CustomLabel customLabel12;
    }
}