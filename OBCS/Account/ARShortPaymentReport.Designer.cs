
namespace OBCS.Account
{
    partial class ARShortPaymentReport
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
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_count = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_ledgerDebit = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_ledgerPosting = new OBCS.CustomTextBox();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_ledgerCredit = new OBCS.CustomTextBox();
            this.customLabel22 = new OBCS.Tools.CustomLabel();
            this.grid_ARShortPayment = new OBCS.CustomGrid();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerFromDate = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerToDate = new OBCS.Purchase.CustomDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ARShortPayment)).BeginInit();
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
            this.btn_export.Location = new System.Drawing.Point(1218, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(113, 42);
            this.btn_export.TabIndex = 696;
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
            this.btn_search.Location = new System.Drawing.Point(1099, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(113, 42);
            this.btn_search.TabIndex = 694;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_count
            // 
            this.txt_count.BackColor = System.Drawing.Color.White;
            this.txt_count.Enabled = false;
            this.txt_count.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_count.Location = new System.Drawing.Point(93, 34);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(39, 21);
            this.txt_count.TabIndex = 708;
            this.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(12, 37);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(75, 15);
            this.customLabel2.TabIndex = 709;
            this.customLabel2.Text = "Total Counts";
            // 
            // txt_ledgerDebit
            // 
            this.txt_ledgerDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ledgerDebit.BackColor = System.Drawing.Color.White;
            this.txt_ledgerDebit.Enabled = false;
            this.txt_ledgerDebit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ledgerDebit.Location = new System.Drawing.Point(1085, 761);
            this.txt_ledgerDebit.Name = "txt_ledgerDebit";
            this.txt_ledgerDebit.Size = new System.Drawing.Size(120, 21);
            this.txt_ledgerDebit.TabIndex = 706;
            this.txt_ledgerDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(1131, 743);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(74, 15);
            this.customLabel1.TabIndex = 707;
            this.customLabel1.Text = "Ledger Debit";
            // 
            // txt_ledgerPosting
            // 
            this.txt_ledgerPosting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ledgerPosting.BackColor = System.Drawing.Color.White;
            this.txt_ledgerPosting.Enabled = false;
            this.txt_ledgerPosting.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ledgerPosting.Location = new System.Drawing.Point(963, 761);
            this.txt_ledgerPosting.Name = "txt_ledgerPosting";
            this.txt_ledgerPosting.Size = new System.Drawing.Size(116, 21);
            this.txt_ledgerPosting.TabIndex = 703;
            this.txt_ledgerPosting.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel7
            // 
            this.customLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(994, 743);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(85, 15);
            this.customLabel7.TabIndex = 704;
            this.customLabel7.Text = "Ledger Posting";
            // 
            // txt_ledgerCredit
            // 
            this.txt_ledgerCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ledgerCredit.BackColor = System.Drawing.Color.White;
            this.txt_ledgerCredit.Enabled = false;
            this.txt_ledgerCredit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_ledgerCredit.Location = new System.Drawing.Point(1211, 761);
            this.txt_ledgerCredit.Name = "txt_ledgerCredit";
            this.txt_ledgerCredit.Size = new System.Drawing.Size(120, 21);
            this.txt_ledgerCredit.TabIndex = 701;
            this.txt_ledgerCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel22
            // 
            this.customLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel22.AutoSize = true;
            this.customLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel22.Location = new System.Drawing.Point(1253, 743);
            this.customLabel22.Name = "customLabel22";
            this.customLabel22.Size = new System.Drawing.Size(78, 15);
            this.customLabel22.TabIndex = 702;
            this.customLabel22.Text = "Ledger Credit";
            // 
            // grid_ARShortPayment
            // 
            this.grid_ARShortPayment.AllowUserToAddRows = false;
            this.grid_ARShortPayment.AllowUserToDeleteRows = false;
            this.grid_ARShortPayment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_ARShortPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_ARShortPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_ARShortPayment.BackgroundColor = System.Drawing.Color.White;
            this.grid_ARShortPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ARShortPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_ARShortPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_ARShortPayment.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_ARShortPayment.EnableHeadersVisualStyles = false;
            this.grid_ARShortPayment.GridColor = System.Drawing.Color.LightGray;
            this.grid_ARShortPayment.Location = new System.Drawing.Point(12, 60);
            this.grid_ARShortPayment.MultiSelect = false;
            this.grid_ARShortPayment.Name = "grid_ARShortPayment";
            this.grid_ARShortPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ARShortPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_ARShortPayment.RowHeadersVisible = false;
            this.grid_ARShortPayment.RowTemplate.Height = 19;
            this.grid_ARShortPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_ARShortPayment.Size = new System.Drawing.Size(1319, 680);
            this.grid_ARShortPayment.StandardTab = true;
            this.grid_ARShortPayment.TabIndex = 700;
            // 
            // customLabel6
            // 
            this.customLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel6.Location = new System.Drawing.Point(900, 12);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(38, 17);
            this.customLabel6.TabIndex = 699;
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
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(903, 33);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerFromDate.TabIndex = 698;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(998, 12);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(22, 17);
            this.customLabel5.TabIndex = 697;
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
            this.dateTimePickerToDate.Location = new System.Drawing.Point(1001, 33);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerToDate.TabIndex = 695;
            // 
            // ARShortPaymentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 794);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_ledgerDebit);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_ledgerPosting);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.txt_ledgerCredit);
            this.Controls.Add(this.customLabel22);
            this.Controls.Add(this.grid_ARShortPayment);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_search);
            this.Name = "ARShortPaymentReport";
            this.Text = "AR Short Payment Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_ARShortPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomTextBox txt_count;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_ledgerDebit;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_ledgerPosting;
        private Tools.CustomLabel customLabel7;
        private CustomTextBox txt_ledgerCredit;
        private Tools.CustomLabel customLabel22;
        private CustomGrid grid_ARShortPayment;
        private Tools.CustomLabel customLabel6;
        private Purchase.CustomDateTimePicker dateTimePickerFromDate;
        private Tools.CustomLabel customLabel5;
        private Purchase.CustomDateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_search;
    }
}