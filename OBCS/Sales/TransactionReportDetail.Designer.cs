
namespace OBCS.Sales
{
    partial class TransactionReportDetail
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
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label_CustomerID = new System.Windows.Forms.Label();
            this.label_InvoiceNo = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_totalqty = new System.Windows.Forms.Label();
            this.label_totalamt = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.txtbox_totqty = new OBCS.CustomTextBox();
            this.txtbox_totamt = new OBCS.CustomTextBox();
            this.txtBox_CustomerName = new OBCS.CustomTextBox();
            this.txtBox_InvoiceNumber = new OBCS.CustomTextBox();
            this.txtBox_CustomerID = new OBCS.CustomTextBox();
            this.dateTimePicker_ToDate = new OBCS.Tools.CustomLabel();
            this.dateTimePicker_FromDate = new OBCS.Tools.CustomLabel();
            this.grid_TransactionDetail = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TransactionDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(1372, 53);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerFrom.TabIndex = 654;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(1522, 53);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerTo.TabIndex = 656;
            // 
            // label_CustomerID
            // 
            this.label_CustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CustomerID.AutoSize = true;
            this.label_CustomerID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerID.Location = new System.Drawing.Point(999, 9);
            this.label_CustomerID.Name = "label_CustomerID";
            this.label_CustomerID.Size = new System.Drawing.Size(74, 15);
            this.label_CustomerID.TabIndex = 658;
            this.label_CustomerID.Text = "Customer ID";
            // 
            // label_InvoiceNo
            // 
            this.label_InvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_InvoiceNo.AutoSize = true;
            this.label_InvoiceNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InvoiceNo.Location = new System.Drawing.Point(1519, 9);
            this.label_InvoiceNo.Name = "label_InvoiceNo";
            this.label_InvoiceNo.Size = new System.Drawing.Size(93, 15);
            this.label_InvoiceNo.TabIndex = 660;
            this.label_InvoiceNo.Text = "Invoice Number";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(1644, 12);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(93, 63);
            this.btn_Refresh.TabIndex = 661;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 663;
            this.label1.Text = "Customer Name";
            // 
            // label_totalqty
            // 
            this.label_totalqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalqty.AutoSize = true;
            this.label_totalqty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalqty.Location = new System.Drawing.Point(1580, 860);
            this.label_totalqty.Name = "label_totalqty";
            this.label_totalqty.Size = new System.Drawing.Size(84, 15);
            this.label_totalqty.TabIndex = 666;
            this.label_totalqty.Text = "Total Quantity";
            // 
            // label_totalamt
            // 
            this.label_totalamt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_totalamt.AutoSize = true;
            this.label_totalamt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalamt.Location = new System.Drawing.Point(1716, 860);
            this.label_totalamt.Name = "label_totalamt";
            this.label_totalamt.Size = new System.Drawing.Size(79, 15);
            this.label_totalamt.TabIndex = 667;
            this.label_totalamt.Text = "Total Amount";
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(1742, 12);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(93, 63);
            this.btn_print.TabIndex = 839;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txtbox_totqty
            // 
            this.txtbox_totqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_totqty.BackColor = System.Drawing.Color.White;
            this.txtbox_totqty.Font = new System.Drawing.Font("Arial", 9F);
            this.txtbox_totqty.Location = new System.Drawing.Point(1583, 878);
            this.txtbox_totqty.Name = "txtbox_totqty";
            this.txtbox_totqty.ReadOnly = true;
            this.txtbox_totqty.Size = new System.Drawing.Size(116, 21);
            this.txtbox_totqty.TabIndex = 665;
            // 
            // txtbox_totamt
            // 
            this.txtbox_totamt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox_totamt.BackColor = System.Drawing.Color.White;
            this.txtbox_totamt.Font = new System.Drawing.Font("Arial", 9F);
            this.txtbox_totamt.Location = new System.Drawing.Point(1719, 878);
            this.txtbox_totamt.Name = "txtbox_totamt";
            this.txtbox_totamt.ReadOnly = true;
            this.txtbox_totamt.Size = new System.Drawing.Size(116, 21);
            this.txtbox_totamt.TabIndex = 664;
            // 
            // txtBox_CustomerName
            // 
            this.txtBox_CustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_CustomerName.BackColor = System.Drawing.Color.White;
            this.txtBox_CustomerName.Font = new System.Drawing.Font("Arial", 9F);
            this.txtBox_CustomerName.Location = new System.Drawing.Point(1259, 27);
            this.txtBox_CustomerName.Name = "txtBox_CustomerName";
            this.txtBox_CustomerName.Size = new System.Drawing.Size(228, 21);
            this.txtBox_CustomerName.TabIndex = 662;
            // 
            // txtBox_InvoiceNumber
            // 
            this.txtBox_InvoiceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_InvoiceNumber.BackColor = System.Drawing.Color.White;
            this.txtBox_InvoiceNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txtBox_InvoiceNumber.Location = new System.Drawing.Point(1522, 27);
            this.txtBox_InvoiceNumber.Name = "txtBox_InvoiceNumber";
            this.txtBox_InvoiceNumber.Size = new System.Drawing.Size(116, 21);
            this.txtBox_InvoiceNumber.TabIndex = 659;
            // 
            // txtBox_CustomerID
            // 
            this.txtBox_CustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_CustomerID.BackColor = System.Drawing.Color.White;
            this.txtBox_CustomerID.Font = new System.Drawing.Font("Arial", 9F);
            this.txtBox_CustomerID.Location = new System.Drawing.Point(1002, 27);
            this.txtBox_CustomerID.Name = "txtBox_CustomerID";
            this.txtBox_CustomerID.Size = new System.Drawing.Size(228, 21);
            this.txtBox_CustomerID.TabIndex = 657;
            // 
            // dateTimePicker_ToDate
            // 
            this.dateTimePicker_ToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_ToDate.AutoSize = true;
            this.dateTimePicker_ToDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_ToDate.Location = new System.Drawing.Point(1497, 57);
            this.dateTimePicker_ToDate.Name = "dateTimePicker_ToDate";
            this.dateTimePicker_ToDate.Size = new System.Drawing.Size(19, 15);
            this.dateTimePicker_ToDate.TabIndex = 655;
            this.dateTimePicker_ToDate.Text = "To";
            // 
            // dateTimePicker_FromDate
            // 
            this.dateTimePicker_FromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_FromDate.AutoSize = true;
            this.dateTimePicker_FromDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_FromDate.Location = new System.Drawing.Point(1331, 57);
            this.dateTimePicker_FromDate.Name = "dateTimePicker_FromDate";
            this.dateTimePicker_FromDate.Size = new System.Drawing.Size(35, 15);
            this.dateTimePicker_FromDate.TabIndex = 653;
            this.dateTimePicker_FromDate.Text = "From";
            // 
            // grid_TransactionDetail
            // 
            this.grid_TransactionDetail.AllowUserToAddRows = false;
            this.grid_TransactionDetail.AllowUserToDeleteRows = false;
            this.grid_TransactionDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_TransactionDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_TransactionDetail.BackgroundColor = System.Drawing.Color.White;
            this.grid_TransactionDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_TransactionDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_TransactionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_TransactionDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_TransactionDetail.EnableHeadersVisualStyles = false;
            this.grid_TransactionDetail.GridColor = System.Drawing.Color.LightGray;
            this.grid_TransactionDetail.Location = new System.Drawing.Point(12, 81);
            this.grid_TransactionDetail.MultiSelect = false;
            this.grid_TransactionDetail.Name = "grid_TransactionDetail";
            this.grid_TransactionDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_TransactionDetail.RowHeadersVisible = false;
            this.grid_TransactionDetail.RowTemplate.Height = 19;
            this.grid_TransactionDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_TransactionDetail.Size = new System.Drawing.Size(1823, 762);
            this.grid_TransactionDetail.StandardTab = true;
            this.grid_TransactionDetail.TabIndex = 0;
            this.grid_TransactionDetail.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_TransactionDetail_DataBindingComplete);
            // 
            // TransactionReportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1847, 911);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label_totalamt);
            this.Controls.Add(this.label_totalqty);
            this.Controls.Add(this.txtbox_totqty);
            this.Controls.Add(this.txtbox_totamt);
            this.Controls.Add(this.txtBox_CustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.txtBox_InvoiceNumber);
            this.Controls.Add(this.label_InvoiceNo);
            this.Controls.Add(this.txtBox_CustomerID);
            this.Controls.Add(this.label_CustomerID);
            this.Controls.Add(this.dateTimePicker_ToDate);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePicker_FromDate);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.grid_TransactionDetail);
            this.Name = "TransactionReportDetail";
            this.Text = "Sales by Customer Transaction Detail Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_TransactionDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_TransactionDetail;
        private Tools.CustomLabel dateTimePicker_FromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private Tools.CustomLabel dateTimePicker_ToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private CustomTextBox txtBox_CustomerID;
        private System.Windows.Forms.Label label_CustomerID;
        private CustomTextBox txtBox_InvoiceNumber;
        private System.Windows.Forms.Label label_InvoiceNo;
        private System.Windows.Forms.Button btn_Refresh;
        private CustomTextBox txtBox_CustomerName;
        private System.Windows.Forms.Label label1;
        private CustomTextBox txtbox_totamt;
        private CustomTextBox txtbox_totqty;
        private System.Windows.Forms.Label label_totalqty;
        private System.Windows.Forms.Label label_totalamt;
        private System.Windows.Forms.Button btn_print;
    }
}