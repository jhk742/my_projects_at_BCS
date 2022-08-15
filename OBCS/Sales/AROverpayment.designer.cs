namespace OBCS.Sales
{
    partial class AROverpayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_export = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_CreditAmount = new OBCS.CustomTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_RemainingAmount = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_TransferAmount = new OBCS.CustomTextBox();
            this.cbo_CustomerID = new OBCS.Tools.CustomComboBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_customerName = new OBCS.CustomTextBox();
            this.customLabel19 = new OBCS.Tools.CustomLabel();
            this.customLabel18 = new OBCS.Tools.CustomLabel();
            this.grid_AROverPayment = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_AROverPayment)).BeginInit();
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
            this.btn_export.Location = new System.Drawing.Point(1059, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(104, 39);
            this.btn_export.TabIndex = 648;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(827, 29);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerTo.TabIndex = 646;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(676, 29);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerFrom.TabIndex = 645;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(949, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(104, 39);
            this.btn_refresh.TabIndex = 643;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(367, 860);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(85, 15);
            this.customLabel4.TabIndex = 658;
            this.customLabel4.Text = "Credit Amount";
            // 
            // txt_CreditAmount
            // 
            this.txt_CreditAmount.BackColor = System.Drawing.Color.White;
            this.txt_CreditAmount.Enabled = false;
            this.txt_CreditAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_CreditAmount.Location = new System.Drawing.Point(455, 857);
            this.txt_CreditAmount.Name = "txt_CreditAmount";
            this.txt_CreditAmount.ReadOnly = true;
            this.txt_CreditAmount.Size = new System.Drawing.Size(161, 21);
            this.txt_CreditAmount.TabIndex = 659;
            this.txt_CreditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(622, 860);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(110, 15);
            this.customLabel3.TabIndex = 656;
            this.customLabel3.Text = "Remaining Amount";
            // 
            // txt_RemainingAmount
            // 
            this.txt_RemainingAmount.BackColor = System.Drawing.Color.White;
            this.txt_RemainingAmount.Enabled = false;
            this.txt_RemainingAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_RemainingAmount.Location = new System.Drawing.Point(735, 857);
            this.txt_RemainingAmount.Name = "txt_RemainingAmount";
            this.txt_RemainingAmount.ReadOnly = true;
            this.txt_RemainingAmount.Size = new System.Drawing.Size(161, 21);
            this.txt_RemainingAmount.TabIndex = 657;
            this.txt_RemainingAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(902, 860);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(97, 15);
            this.customLabel1.TabIndex = 654;
            this.customLabel1.Text = "Transfer Amount";
            // 
            // txt_TransferAmount
            // 
            this.txt_TransferAmount.BackColor = System.Drawing.Color.White;
            this.txt_TransferAmount.Enabled = false;
            this.txt_TransferAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_TransferAmount.Location = new System.Drawing.Point(1002, 857);
            this.txt_TransferAmount.Name = "txt_TransferAmount";
            this.txt_TransferAmount.ReadOnly = true;
            this.txt_TransferAmount.Size = new System.Drawing.Size(161, 21);
            this.txt_TransferAmount.TabIndex = 655;
            this.txt_TransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbo_CustomerID
            // 
            this.cbo_CustomerID.BackColor = System.Drawing.Color.White;
            this.cbo_CustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_CustomerID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_CustomerID.FormattingEnabled = true;
            this.cbo_CustomerID.Location = new System.Drawing.Point(185, 28);
            this.cbo_CustomerID.Name = "cbo_CustomerID";
            this.cbo_CustomerID.Size = new System.Drawing.Size(132, 23);
            this.cbo_CustomerID.TabIndex = 653;
            this.cbo_CustomerID.SelectedIndexChanged += new System.EventHandler(this.cbo_CustomerID_SelectedIndexChanged);
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(105, 32);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(74, 15);
            this.customLabel2.TabIndex = 651;
            this.customLabel2.Text = "Customer ID";
            // 
            // txt_customerName
            // 
            this.txt_customerName.BackColor = System.Drawing.Color.White;
            this.txt_customerName.Enabled = false;
            this.txt_customerName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_customerName.Location = new System.Drawing.Point(323, 29);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.ReadOnly = true;
            this.txt_customerName.Size = new System.Drawing.Size(301, 21);
            this.txt_customerName.TabIndex = 652;
            // 
            // customLabel19
            // 
            this.customLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel19.AutoSize = true;
            this.customLabel19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel19.Location = new System.Drawing.Point(802, 32);
            this.customLabel19.Name = "customLabel19";
            this.customLabel19.Size = new System.Drawing.Size(19, 15);
            this.customLabel19.TabIndex = 647;
            this.customLabel19.Text = "To";
            // 
            // customLabel18
            // 
            this.customLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel18.Location = new System.Drawing.Point(635, 33);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(35, 15);
            this.customLabel18.TabIndex = 644;
            this.customLabel18.Text = "From";
            // 
            // grid_AROverPayment
            // 
            this.grid_AROverPayment.AllowUserToAddRows = false;
            this.grid_AROverPayment.AllowUserToDeleteRows = false;
            this.grid_AROverPayment.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_AROverPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_AROverPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_AROverPayment.BackgroundColor = System.Drawing.Color.White;
            this.grid_AROverPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_AROverPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_AROverPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_AROverPayment.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_AROverPayment.EnableHeadersVisualStyles = false;
            this.grid_AROverPayment.GridColor = System.Drawing.Color.LightGray;
            this.grid_AROverPayment.Location = new System.Drawing.Point(12, 57);
            this.grid_AROverPayment.MultiSelect = false;
            this.grid_AROverPayment.Name = "grid_AROverPayment";
            this.grid_AROverPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_AROverPayment.RowHeadersVisible = false;
            this.grid_AROverPayment.RowTemplate.Height = 19;
            this.grid_AROverPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_AROverPayment.Size = new System.Drawing.Size(1151, 794);
            this.grid_AROverPayment.StandardTab = true;
            this.grid_AROverPayment.TabIndex = 642;
            this.grid_AROverPayment.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_AROverPayment_DataBindingComplete);
            // 
            // AROverpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 885);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_CreditAmount);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.txt_RemainingAmount);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_TransferAmount);
            this.Controls.Add(this.cbo_CustomerID);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.customLabel19);
            this.Controls.Add(this.customLabel18);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.grid_AROverPayment);
            this.Name = "AROverpayment";
            this.Text = "AR Overpayment Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_AROverPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_export;
        private Tools.CustomLabel customLabel19;
        private Tools.CustomLabel customLabel18;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btn_refresh;
        private CustomGrid grid_AROverPayment;
        private Tools.CustomComboBox cbo_CustomerID;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_customerName;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_TransferAmount;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_RemainingAmount;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_CreditAmount;
    }
}