namespace OBCS.Purchase
{
    partial class JITPO
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
            this.Date = new OBCS.Tools.CustomLabel();
            this.dateTimePicker_fromDate = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.dateTimePicker_toDate = new OBCS.Purchase.CustomDateTimePicker();
            this.grid_JIT = new OBCS.CustomGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_brand = new OBCS.Tools.CustomComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.customLabel29 = new OBCS.Tools.CustomLabel();
            this.cbo_productID = new OBCS.Tools.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_JIT)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(768, 15);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(41, 15);
            this.Date.TabIndex = 365;
            this.Date.Text = "From :";
            // 
            // dateTimePicker_fromDate
            // 
            this.dateTimePicker_fromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_fromDate.BackColor = System.Drawing.Color.White;
            this.dateTimePicker_fromDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_fromDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker_fromDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_fromDate.Location = new System.Drawing.Point(815, 12);
            this.dateTimePicker_fromDate.Name = "dateTimePicker_fromDate";
            this.dateTimePicker_fromDate.Size = new System.Drawing.Size(86, 21);
            this.dateTimePicker_fromDate.TabIndex = 364;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(784, 42);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(25, 15);
            this.customLabel1.TabIndex = 367;
            this.customLabel1.Text = "To :";
            // 
            // dateTimePicker_toDate
            // 
            this.dateTimePicker_toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_toDate.BackColor = System.Drawing.Color.White;
            this.dateTimePicker_toDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_toDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker_toDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_toDate.Location = new System.Drawing.Point(815, 39);
            this.dateTimePicker_toDate.Name = "dateTimePicker_toDate";
            this.dateTimePicker_toDate.Size = new System.Drawing.Size(86, 21);
            this.dateTimePicker_toDate.TabIndex = 366;
            // 
            // grid_JIT
            // 
            this.grid_JIT.AllowUserToAddRows = false;
            this.grid_JIT.AllowUserToDeleteRows = false;
            this.grid_JIT.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_JIT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_JIT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_JIT.BackgroundColor = System.Drawing.Color.White;
            this.grid_JIT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_JIT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_JIT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_JIT.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_JIT.EnableHeadersVisualStyles = false;
            this.grid_JIT.GridColor = System.Drawing.Color.LightGray;
            this.grid_JIT.Location = new System.Drawing.Point(12, 66);
            this.grid_JIT.MultiSelect = false;
            this.grid_JIT.Name = "grid_JIT";
            this.grid_JIT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_JIT.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_JIT.RowHeadersVisible = false;
            this.grid_JIT.RowTemplate.Height = 19;
            this.grid_JIT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_JIT.Size = new System.Drawing.Size(1004, 671);
            this.grid_JIT.StandardTab = true;
            this.grid_JIT.TabIndex = 368;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 370;
            this.label1.Text = "Brand";
            // 
            // cbo_brand
            // 
            this.cbo_brand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_brand.BackColor = System.Drawing.Color.White;
            this.cbo_brand.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_brand.FormattingEnabled = true;
            this.cbo_brand.Location = new System.Drawing.Point(563, 12);
            this.cbo_brand.Name = "cbo_brand";
            this.cbo_brand.Size = new System.Drawing.Size(199, 23);
            this.cbo_brand.TabIndex = 369;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(907, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(109, 48);
            this.btn_refresh.TabIndex = 371;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // customLabel29
            // 
            this.customLabel29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel29.AutoSize = true;
            this.customLabel29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel29.Location = new System.Drawing.Point(492, 40);
            this.customLabel29.Name = "customLabel29";
            this.customLabel29.Size = new System.Drawing.Size(65, 15);
            this.customLabel29.TabIndex = 441;
            this.customLabel29.Text = "Product ID";
            // 
            // cbo_productID
            // 
            this.cbo_productID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_productID.BackColor = System.Drawing.Color.White;
            this.cbo_productID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_productID.FormattingEnabled = true;
            this.cbo_productID.Location = new System.Drawing.Point(563, 37);
            this.cbo_productID.Name = "cbo_productID";
            this.cbo_productID.Size = new System.Drawing.Size(199, 23);
            this.cbo_productID.TabIndex = 440;
            // 
            // JITPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.customLabel29);
            this.Controls.Add(this.cbo_productID);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_brand);
            this.Controls.Add(this.grid_JIT);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.dateTimePicker_toDate);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.dateTimePicker_fromDate);
            this.Name = "JITPO";
            this.Text = "Purchase Order Forecast Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_JIT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.CustomLabel Date;
        private CustomDateTimePicker dateTimePicker_fromDate;
        private Tools.CustomLabel customLabel1;
        private CustomDateTimePicker dateTimePicker_toDate;
        private CustomGrid grid_JIT;
        private System.Windows.Forms.Label label1;
        private Tools.CustomComboBox cbo_brand;
        private System.Windows.Forms.Button btn_refresh;
        private Tools.CustomLabel customLabel29;
        private Tools.CustomComboBox cbo_productID;
    }
}