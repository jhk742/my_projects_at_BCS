
namespace OBCS.Account
{
    partial class OverpaymentBalanceAccountReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_endingAmountCredit = new OBCS.CustomTextBox();
            this.customLabel10 = new OBCS.Tools.CustomLabel();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.txt_beginningAmountCredit = new OBCS.CustomTextBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_credit = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_beginningAmountDebit = new OBCS.CustomTextBox();
            this.txt_debit = new OBCS.CustomTextBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_endingAmountDebit = new OBCS.CustomTextBox();
            this.customLabel22 = new OBCS.Tools.CustomLabel();
            this.txt_count = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.grid_OverpaymentBalanceAccount = new OBCS.CustomGrid();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerFromDate = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerToDate = new OBCS.Purchase.CustomDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OverpaymentBalanceAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(1114, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(113, 42);
            this.btn_export.TabIndex = 676;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(995, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(113, 42);
            this.btn_search.TabIndex = 674;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_endingAmountCredit
            // 
            this.txt_endingAmountCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_endingAmountCredit.BackColor = System.Drawing.Color.White;
            this.txt_endingAmountCredit.Enabled = false;
            this.txt_endingAmountCredit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_endingAmountCredit.Location = new System.Drawing.Point(1103, 738);
            this.txt_endingAmountCredit.Name = "txt_endingAmountCredit";
            this.txt_endingAmountCredit.Size = new System.Drawing.Size(124, 21);
            this.txt_endingAmountCredit.TabIndex = 708;
            this.txt_endingAmountCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel10
            // 
            this.customLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel10.AutoSize = true;
            this.customLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel10.Location = new System.Drawing.Point(1100, 720);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.Size = new System.Drawing.Size(127, 15);
            this.customLabel10.TabIndex = 709;
            this.customLabel10.Text = "Ending Balance Credit";
            // 
            // customLabel8
            // 
            this.customLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(579, 720);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(144, 15);
            this.customLabel8.TabIndex = 707;
            this.customLabel8.Text = "Beginning Balance Credit";
            // 
            // txt_beginningAmountCredit
            // 
            this.txt_beginningAmountCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_beginningAmountCredit.BackColor = System.Drawing.Color.White;
            this.txt_beginningAmountCredit.Enabled = false;
            this.txt_beginningAmountCredit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_beginningAmountCredit.Location = new System.Drawing.Point(582, 738);
            this.txt_beginningAmountCredit.Name = "txt_beginningAmountCredit";
            this.txt_beginningAmountCredit.Size = new System.Drawing.Size(141, 21);
            this.txt_beginningAmountCredit.TabIndex = 705;
            this.txt_beginningAmountCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(436, 720);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(140, 15);
            this.customLabel4.TabIndex = 706;
            this.customLabel4.Text = "Beginning Balance Debit";
            // 
            // txt_credit
            // 
            this.txt_credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_credit.BackColor = System.Drawing.Color.White;
            this.txt_credit.Enabled = false;
            this.txt_credit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_credit.Location = new System.Drawing.Point(851, 738);
            this.txt_credit.Name = "txt_credit";
            this.txt_credit.Size = new System.Drawing.Size(120, 21);
            this.txt_credit.TabIndex = 703;
            this.txt_credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(848, 720);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(123, 15);
            this.customLabel1.TabIndex = 704;
            this.customLabel1.Text = "Current Period Credit";
            // 
            // txt_beginningAmountDebit
            // 
            this.txt_beginningAmountDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_beginningAmountDebit.BackColor = System.Drawing.Color.White;
            this.txt_beginningAmountDebit.Enabled = false;
            this.txt_beginningAmountDebit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_beginningAmountDebit.Location = new System.Drawing.Point(439, 738);
            this.txt_beginningAmountDebit.Name = "txt_beginningAmountDebit";
            this.txt_beginningAmountDebit.Size = new System.Drawing.Size(137, 21);
            this.txt_beginningAmountDebit.TabIndex = 702;
            this.txt_beginningAmountDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_debit
            // 
            this.txt_debit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_debit.BackColor = System.Drawing.Color.White;
            this.txt_debit.Enabled = false;
            this.txt_debit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_debit.Location = new System.Drawing.Point(729, 738);
            this.txt_debit.Name = "txt_debit";
            this.txt_debit.Size = new System.Drawing.Size(116, 21);
            this.txt_debit.TabIndex = 700;
            this.txt_debit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel7
            // 
            this.customLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(726, 720);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(119, 15);
            this.customLabel7.TabIndex = 701;
            this.customLabel7.Text = "Current Period Debit";
            // 
            // txt_endingAmountDebit
            // 
            this.txt_endingAmountDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_endingAmountDebit.BackColor = System.Drawing.Color.White;
            this.txt_endingAmountDebit.Enabled = false;
            this.txt_endingAmountDebit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_endingAmountDebit.Location = new System.Drawing.Point(977, 738);
            this.txt_endingAmountDebit.Name = "txt_endingAmountDebit";
            this.txt_endingAmountDebit.Size = new System.Drawing.Size(120, 21);
            this.txt_endingAmountDebit.TabIndex = 698;
            this.txt_endingAmountDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel22
            // 
            this.customLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel22.AutoSize = true;
            this.customLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel22.Location = new System.Drawing.Point(974, 720);
            this.customLabel22.Name = "customLabel22";
            this.customLabel22.Size = new System.Drawing.Size(123, 15);
            this.customLabel22.TabIndex = 699;
            this.customLabel22.Text = "Ending Balance Debit";
            // 
            // txt_count
            // 
            this.txt_count.BackColor = System.Drawing.Color.White;
            this.txt_count.Enabled = false;
            this.txt_count.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_count.Location = new System.Drawing.Point(107, 34);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(39, 21);
            this.txt_count.TabIndex = 696;
            this.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(12, 37);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(89, 15);
            this.customLabel2.TabIndex = 697;
            this.customLabel2.Text = "Total Customer";
            // 
            // grid_OverpaymentBalanceAccount
            // 
            this.grid_OverpaymentBalanceAccount.AllowUserToAddRows = false;
            this.grid_OverpaymentBalanceAccount.AllowUserToDeleteRows = false;
            this.grid_OverpaymentBalanceAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_OverpaymentBalanceAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_OverpaymentBalanceAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_OverpaymentBalanceAccount.BackgroundColor = System.Drawing.Color.White;
            this.grid_OverpaymentBalanceAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OverpaymentBalanceAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_OverpaymentBalanceAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_OverpaymentBalanceAccount.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_OverpaymentBalanceAccount.EnableHeadersVisualStyles = false;
            this.grid_OverpaymentBalanceAccount.GridColor = System.Drawing.Color.LightGray;
            this.grid_OverpaymentBalanceAccount.Location = new System.Drawing.Point(12, 60);
            this.grid_OverpaymentBalanceAccount.MultiSelect = false;
            this.grid_OverpaymentBalanceAccount.Name = "grid_OverpaymentBalanceAccount";
            this.grid_OverpaymentBalanceAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OverpaymentBalanceAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_OverpaymentBalanceAccount.RowHeadersVisible = false;
            this.grid_OverpaymentBalanceAccount.RowTemplate.Height = 19;
            this.grid_OverpaymentBalanceAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_OverpaymentBalanceAccount.Size = new System.Drawing.Size(1215, 657);
            this.grid_OverpaymentBalanceAccount.StandardTab = true;
            this.grid_OverpaymentBalanceAccount.TabIndex = 680;
            // 
            // customLabel6
            // 
            this.customLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel6.Location = new System.Drawing.Point(796, 12);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(38, 17);
            this.customLabel6.TabIndex = 679;
            this.customLabel6.Text = "From";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFromDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerFromDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFromDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerFromDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(799, 33);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerFromDate.TabIndex = 678;
            this.dateTimePickerFromDate.ValueChanged += new System.EventHandler(this.dateTimePickerFromDate_ValueChanged);
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(894, 12);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(22, 17);
            this.customLabel5.TabIndex = 677;
            this.customLabel5.Text = "To";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerToDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerToDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerToDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerToDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(897, 33);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerToDate.TabIndex = 675;
            this.dateTimePickerToDate.ValueChanged += new System.EventHandler(this.dateTimePickerToDate_ValueChanged);
            // 
            // OverpaymentBalanceAccountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 771);
            this.Controls.Add(this.txt_endingAmountCredit);
            this.Controls.Add(this.customLabel10);
            this.Controls.Add(this.customLabel8);
            this.Controls.Add(this.txt_beginningAmountCredit);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_credit);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_beginningAmountDebit);
            this.Controls.Add(this.txt_debit);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.txt_endingAmountDebit);
            this.Controls.Add(this.customLabel22);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.grid_OverpaymentBalanceAccount);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_search);
            this.Name = "OverpaymentBalanceAccountReport";
            this.Text = "Overpayment Balance Account Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_OverpaymentBalanceAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_OverpaymentBalanceAccount;
        private Tools.CustomLabel customLabel6;
        private Purchase.CustomDateTimePicker dateTimePickerFromDate;
        private Tools.CustomLabel customLabel5;
        private Purchase.CustomDateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_search;
        private CustomTextBox txt_count;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_endingAmountCredit;
        private Tools.CustomLabel customLabel10;
        private Tools.CustomLabel customLabel8;
        private CustomTextBox txt_beginningAmountCredit;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_credit;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_beginningAmountDebit;
        private CustomTextBox txt_debit;
        private Tools.CustomLabel customLabel7;
        private CustomTextBox txt_endingAmountDebit;
        private Tools.CustomLabel customLabel22;
    }
}