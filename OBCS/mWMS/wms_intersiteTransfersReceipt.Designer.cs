namespace OBCS.mWMS
{
    partial class wms_intersiteTransfersReceipt
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
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.txt_desc = new OBCS.CustomTextBox();
            this.grid_detail = new OBCS.CustomGrid();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbo_destinationStie = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.cbo_storageSite = new OBCS.Tools.CustomComboBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.grid_header = new OBCS.CustomGrid();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_WHCHGNumber = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).BeginInit();
            this.SuspendLayout();
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(481, 58);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(70, 15);
            this.customLabel6.TabIndex = 673;
            this.customLabel6.Text = "Description";
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.White;
            this.txt_desc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_desc.Location = new System.Drawing.Point(557, 55);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(368, 21);
            this.txt_desc.TabIndex = 674;
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
            this.grid_detail.Location = new System.Drawing.Point(480, 82);
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
            this.grid_detail.Size = new System.Drawing.Size(836, 539);
            this.grid_detail.StandardTab = true;
            this.grid_detail.TabIndex = 672;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(778, 7);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(90, 15);
            this.customLabel2.TabIndex = 671;
            this.customLabel2.Text = "Allocation date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(781, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker1.TabIndex = 670;
            // 
            // cbo_destinationStie
            // 
            this.cbo_destinationStie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_destinationStie.BackColor = System.Drawing.Color.White;
            this.cbo_destinationStie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_destinationStie.Enabled = false;
            this.cbo_destinationStie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_destinationStie.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_destinationStie.FormattingEnabled = true;
            this.cbo_destinationStie.Location = new System.Drawing.Point(686, 24);
            this.cbo_destinationStie.Name = "cbo_destinationStie";
            this.cbo_destinationStie.Size = new System.Drawing.Size(89, 23);
            this.cbo_destinationStie.TabIndex = 668;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(683, 6);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(92, 15);
            this.customLabel1.TabIndex = 669;
            this.customLabel1.Text = "Destination site";
            // 
            // cbo_storageSite
            // 
            this.cbo_storageSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_storageSite.BackColor = System.Drawing.Color.White;
            this.cbo_storageSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_storageSite.Enabled = false;
            this.cbo_storageSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_storageSite.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_storageSite.FormattingEnabled = true;
            this.cbo_storageSite.Location = new System.Drawing.Point(597, 24);
            this.cbo_storageSite.Name = "cbo_storageSite";
            this.cbo_storageSite.Size = new System.Drawing.Size(83, 23);
            this.cbo_storageSite.TabIndex = 666;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(595, 6);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(71, 15);
            this.customLabel4.TabIndex = 667;
            this.customLabel4.Text = "Storage site";
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
            this.grid_header.Location = new System.Drawing.Point(12, 12);
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
            this.grid_header.Size = new System.Drawing.Size(462, 609);
            this.grid_header.StandardTab = true;
            this.grid_header.TabIndex = 675;
            this.grid_header.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_header_CellEnter);
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(931, 44);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(99, 32);
            this.btn_confirm.TabIndex = 676;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(480, 8);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(96, 15);
            this.customLabel3.TabIndex = 677;
            this.customLabel3.Text = "WHCHG Number";
            // 
            // txt_WHCHGNumber
            // 
            this.txt_WHCHGNumber.BackColor = System.Drawing.Color.White;
            this.txt_WHCHGNumber.Enabled = false;
            this.txt_WHCHGNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_WHCHGNumber.Location = new System.Drawing.Point(480, 26);
            this.txt_WHCHGNumber.Name = "txt_WHCHGNumber";
            this.txt_WHCHGNumber.Size = new System.Drawing.Size(111, 21);
            this.txt_WHCHGNumber.TabIndex = 678;
            // 
            // wms_intersiteTransfersReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 633);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.txt_WHCHGNumber);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.grid_header);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.grid_detail);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbo_destinationStie);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.cbo_storageSite);
            this.Controls.Add(this.customLabel4);
            this.Name = "wms_intersiteTransfersReceipt";
            this.Text = "Intersite Transfers Receipt WMS";
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.CustomLabel customLabel6;
        private CustomTextBox txt_desc;
        private CustomGrid grid_detail;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Tools.CustomComboBox cbo_destinationStie;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomComboBox cbo_storageSite;
        private Tools.CustomLabel customLabel4;
        private CustomGrid grid_header;
        private System.Windows.Forms.Button btn_confirm;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_WHCHGNumber;
    }
}