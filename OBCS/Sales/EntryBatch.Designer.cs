namespace OBCS.Sales
{
    partial class EntryBatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_header = new OBCS.CustomGrid();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grid_detail = new OBCS.CustomGrid();
            this.customLabel25 = new OBCS.Tools.CustomLabel();
            this.txt_total = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_entryBatch = new OBCS.CustomTextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_achTotal = new OBCS.CustomTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_checkTotal = new OBCS.CustomTextBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_cashTotal = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_header
            // 
            this.grid_header.AllowUserToAddRows = false;
            this.grid_header.AllowUserToDeleteRows = false;
            this.grid_header.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_header.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_header.BackgroundColor = System.Drawing.Color.White;
            this.grid_header.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_header.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_header.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_header.EnableHeadersVisualStyles = false;
            this.grid_header.GridColor = System.Drawing.Color.LightGray;
            this.grid_header.Location = new System.Drawing.Point(12, 40);
            this.grid_header.MultiSelect = false;
            this.grid_header.Name = "grid_header";
            this.grid_header.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_header.RowHeadersVisible = false;
            this.grid_header.RowTemplate.Height = 19;
            this.grid_header.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_header.Size = new System.Drawing.Size(321, 746);
            this.grid_header.StandardTab = true;
            this.grid_header.TabIndex = 0;
            this.grid_header.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_header_CellEnter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker1.TabIndex = 701;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // grid_detail
            // 
            this.grid_detail.AllowUserToAddRows = false;
            this.grid_detail.AllowUserToDeleteRows = false;
            this.grid_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_detail.BackgroundColor = System.Drawing.Color.White;
            this.grid_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_detail.DefaultCellStyle = dataGridViewCellStyle12;
            this.grid_detail.EnableHeadersVisualStyles = false;
            this.grid_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_detail.Location = new System.Drawing.Point(339, 40);
            this.grid_detail.MultiSelect = false;
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_detail.RowHeadersVisible = false;
            this.grid_detail.RowTemplate.Height = 19;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(991, 719);
            this.grid_detail.StandardTab = true;
            this.grid_detail.TabIndex = 702;
            // 
            // customLabel25
            // 
            this.customLabel25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel25.AutoSize = true;
            this.customLabel25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel25.Location = new System.Drawing.Point(1190, 768);
            this.customLabel25.Name = "customLabel25";
            this.customLabel25.Size = new System.Drawing.Size(34, 15);
            this.customLabel25.TabIndex = 704;
            this.customLabel25.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.BackColor = System.Drawing.Color.White;
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_total.Location = new System.Drawing.Point(1230, 765);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 21);
            this.txt_total.TabIndex = 703;
            this.txt_total.TabStop = false;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(336, 18);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(69, 15);
            this.customLabel1.TabIndex = 706;
            this.customLabel1.Text = "Entry Batch";
            // 
            // txt_entryBatch
            // 
            this.txt_entryBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_entryBatch.BackColor = System.Drawing.Color.White;
            this.txt_entryBatch.Enabled = false;
            this.txt_entryBatch.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_entryBatch.Location = new System.Drawing.Point(411, 15);
            this.txt_entryBatch.Name = "txt_entryBatch";
            this.txt_entryBatch.Size = new System.Drawing.Size(919, 21);
            this.txt_entryBatch.TabIndex = 705;
            this.txt_entryBatch.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(129, 8);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(89, 26);
            this.btn_refresh.TabIndex = 709;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(1072, 768);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(29, 15);
            this.customLabel2.TabIndex = 711;
            this.customLabel2.Text = "ACH";
            // 
            // txt_achTotal
            // 
            this.txt_achTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_achTotal.BackColor = System.Drawing.Color.White;
            this.txt_achTotal.Enabled = false;
            this.txt_achTotal.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_achTotal.Location = new System.Drawing.Point(1107, 765);
            this.txt_achTotal.Name = "txt_achTotal";
            this.txt_achTotal.Size = new System.Drawing.Size(77, 21);
            this.txt_achTotal.TabIndex = 710;
            this.txt_achTotal.TabStop = false;
            this.txt_achTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(944, 768);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(39, 15);
            this.customLabel3.TabIndex = 713;
            this.customLabel3.Text = "Check";
            // 
            // txt_checkTotal
            // 
            this.txt_checkTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_checkTotal.BackColor = System.Drawing.Color.White;
            this.txt_checkTotal.Enabled = false;
            this.txt_checkTotal.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_checkTotal.Location = new System.Drawing.Point(989, 765);
            this.txt_checkTotal.Name = "txt_checkTotal";
            this.txt_checkTotal.Size = new System.Drawing.Size(77, 21);
            this.txt_checkTotal.TabIndex = 712;
            this.txt_checkTotal.TabStop = false;
            this.txt_checkTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(821, 768);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(34, 15);
            this.customLabel4.TabIndex = 715;
            this.customLabel4.Text = "Cash";
            // 
            // txt_cashTotal
            // 
            this.txt_cashTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cashTotal.BackColor = System.Drawing.Color.White;
            this.txt_cashTotal.Enabled = false;
            this.txt_cashTotal.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_cashTotal.Location = new System.Drawing.Point(861, 765);
            this.txt_cashTotal.Name = "txt_cashTotal";
            this.txt_cashTotal.Size = new System.Drawing.Size(77, 21);
            this.txt_cashTotal.TabIndex = 714;
            this.txt_cashTotal.TabStop = false;
            this.txt_cashTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EntryBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 798);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_cashTotal);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.txt_checkTotal);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_achTotal);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_entryBatch);
            this.Controls.Add(this.customLabel25);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.grid_detail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grid_header);
            this.Name = "EntryBatch";
            this.Text = "Entry Batch";
            ((System.ComponentModel.ISupportInitialize)(this.grid_header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_header;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private CustomGrid grid_detail;
        private Tools.CustomLabel customLabel25;
        private CustomTextBox txt_total;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_entryBatch;
        private System.Windows.Forms.Button btn_refresh;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_achTotal;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_checkTotal;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_cashTotal;
    }
}