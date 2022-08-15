
namespace OBCS.Reports
{
    partial class PaymentResolution2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sp_PaymentResolutionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentResolution = new OBCS.Reports.PaymentResolution();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.sp_PaymentResolutionTableAdapter = new OBCS.Reports.PaymentResolutionTableAdapters.sp_PaymentResolutionTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.customLabel27 = new OBCS.Tools.CustomLabel();
            this.customLabel28 = new OBCS.Tools.CustomLabel();
            this.customLabel26 = new OBCS.Tools.CustomLabel();
            this.txt_searchSupplierInvoiceNumber = new OBCS.CustomTextBox();
            this.customLabel29 = new OBCS.Tools.CustomLabel();
            this.txt_searchPONumber = new OBCS.CustomTextBox();
            this.cbo_searchSupplierID = new OBCS.Tools.CustomComboBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.grid_invoice = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PaymentResolutionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_PaymentResolutionBindingSource
            // 
            this.sp_PaymentResolutionBindingSource.DataMember = "sp_PaymentResolution";
            this.sp_PaymentResolutionBindingSource.DataSource = this.PaymentResolution;
            // 
            // PaymentResolution
            // 
            this.PaymentResolution.DataSetName = "PaymentResolution";
            this.PaymentResolution.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "PaymentResolution";
            reportDataSource3.Value = this.sp_PaymentResolutionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PaymentResolution.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(887, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(850, 755);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(433, 22);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(85, 22);
            this.dateTimePickerTo.TabIndex = 702;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(342, 22);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(85, 22);
            this.dateTimePickerFrom.TabIndex = 701;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(524, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(68, 23);
            this.btn_search.TabIndex = 703;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(1643, 12);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(94, 32);
            this.btn_print.TabIndex = 697;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Visible = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(1543, 12);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(94, 32);
            this.btn_confirm.TabIndex = 696;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Visible = false;
            // 
            // sp_PaymentResolutionTableAdapter
            // 
            this.sp_PaymentResolutionTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.DocumentMapWidth = 47;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PaymentResolution.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(670, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(728, 246);
            this.reportViewer2.TabIndex = 710;
            this.reportViewer2.Visible = false;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(243, -4);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(53, 15);
            this.customLabel3.TabIndex = 709;
            this.customLabel3.Text = "Supplier";
            // 
            // customLabel27
            // 
            this.customLabel27.AutoSize = true;
            this.customLabel27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel27.Location = new System.Drawing.Point(430, 4);
            this.customLabel27.Name = "customLabel27";
            this.customLabel27.Size = new System.Drawing.Size(19, 15);
            this.customLabel27.TabIndex = 708;
            this.customLabel27.Text = "To";
            // 
            // customLabel28
            // 
            this.customLabel28.AutoSize = true;
            this.customLabel28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel28.Location = new System.Drawing.Point(339, 5);
            this.customLabel28.Name = "customLabel28";
            this.customLabel28.Size = new System.Drawing.Size(35, 15);
            this.customLabel28.TabIndex = 707;
            this.customLabel28.Text = "From";
            // 
            // customLabel26
            // 
            this.customLabel26.AutoSize = true;
            this.customLabel26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel26.Location = new System.Drawing.Point(243, 7);
            this.customLabel26.Name = "customLabel26";
            this.customLabel26.Size = new System.Drawing.Size(93, 15);
            this.customLabel26.TabIndex = 706;
            this.customLabel26.Text = "Invoice Number";
            // 
            // txt_searchSupplierInvoiceNumber
            // 
            this.txt_searchSupplierInvoiceNumber.BackColor = System.Drawing.Color.White;
            this.txt_searchSupplierInvoiceNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchSupplierInvoiceNumber.Location = new System.Drawing.Point(246, 23);
            this.txt_searchSupplierInvoiceNumber.Name = "txt_searchSupplierInvoiceNumber";
            this.txt_searchSupplierInvoiceNumber.Size = new System.Drawing.Size(90, 21);
            this.txt_searchSupplierInvoiceNumber.TabIndex = 700;
            this.txt_searchSupplierInvoiceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searchSupplierInvoiceNumber_KeyPress);
            // 
            // customLabel29
            // 
            this.customLabel29.AutoSize = true;
            this.customLabel29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel29.Location = new System.Drawing.Point(171, 7);
            this.customLabel29.Name = "customLabel29";
            this.customLabel29.Size = new System.Drawing.Size(69, 15);
            this.customLabel29.TabIndex = 705;
            this.customLabel29.Text = "PO Number";
            // 
            // txt_searchPONumber
            // 
            this.txt_searchPONumber.BackColor = System.Drawing.Color.White;
            this.txt_searchPONumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchPONumber.Location = new System.Drawing.Point(174, 23);
            this.txt_searchPONumber.Name = "txt_searchPONumber";
            this.txt_searchPONumber.Size = new System.Drawing.Size(66, 21);
            this.txt_searchPONumber.TabIndex = 699;
            this.txt_searchPONumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searchPONumber_KeyPress);
            // 
            // cbo_searchSupplierID
            // 
            this.cbo_searchSupplierID.BackColor = System.Drawing.Color.White;
            this.cbo_searchSupplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_searchSupplierID.FormattingEnabled = true;
            this.cbo_searchSupplierID.Location = new System.Drawing.Point(12, 21);
            this.cbo_searchSupplierID.Name = "cbo_searchSupplierID";
            this.cbo_searchSupplierID.Size = new System.Drawing.Size(156, 23);
            this.cbo_searchSupplierID.TabIndex = 698;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(9, 5);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(108, 15);
            this.customLabel2.TabIndex = 704;
            this.customLabel2.Text = "Search Supplier ID";
            // 
            // grid_invoice
            // 
            this.grid_invoice.AllowUserToAddRows = false;
            this.grid_invoice.AllowUserToDeleteRows = false;
            this.grid_invoice.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_invoice.BackgroundColor = System.Drawing.Color.White;
            this.grid_invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_invoice.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid_invoice.EnableHeadersVisualStyles = false;
            this.grid_invoice.GridColor = System.Drawing.Color.LightGray;
            this.grid_invoice.Location = new System.Drawing.Point(12, 50);
            this.grid_invoice.MultiSelect = false;
            this.grid_invoice.Name = "grid_invoice";
            this.grid_invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_invoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid_invoice.RowHeadersVisible = false;
            this.grid_invoice.RowTemplate.Height = 19;
            this.grid_invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_invoice.Size = new System.Drawing.Size(869, 755);
            this.grid_invoice.StandardTab = true;
            this.grid_invoice.TabIndex = 694;
            this.grid_invoice.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_invoice_CellEnter);
            // 
            // PaymentResolution2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 817);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel27);
            this.Controls.Add(this.customLabel28);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.customLabel26);
            this.Controls.Add(this.txt_searchSupplierInvoiceNumber);
            this.Controls.Add(this.customLabel29);
            this.Controls.Add(this.txt_searchPONumber);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cbo_searchSupplierID);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.grid_invoice);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PaymentResolution2";
            this.Text = "Payment Resolution";
            this.Load += new System.EventHandler(this.PaymentResolution2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_PaymentResolutionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_PaymentResolutionBindingSource;
        private PaymentResolution PaymentResolution;
        private PaymentResolutionTableAdapters.sp_PaymentResolutionTableAdapter sp_PaymentResolutionTableAdapter;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel27;
        private Tools.CustomLabel customLabel28;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private Tools.CustomLabel customLabel26;
        private CustomTextBox txt_searchSupplierInvoiceNumber;
        private Tools.CustomLabel customLabel29;
        private Tools.CustomComboBox cbo_searchSupplierID;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_confirm;
        private CustomGrid grid_invoice;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        public CustomTextBox txt_searchPONumber;
        public System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        public System.Windows.Forms.Button btn_search;
    }
}