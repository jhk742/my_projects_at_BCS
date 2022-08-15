namespace OBCS.Sales
{
    partial class AROPENCLOSED_ALL
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_statement = new System.Windows.Forms.Button();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.DateTimePickerTo = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.DateTimePickerFrom = new OBCS.Purchase.CustomDateTimePicker();
            this.grid_all = new OBCS.CustomGrid();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.cbox_customer = new OBCS.Tools.CustomComboBoxLarge();
            ((System.ComponentModel.ISupportInitialize)(this.grid_all)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(731, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 27);
            this.btn_search.TabIndex = 390;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_statement
            // 
            this.btn_statement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_statement.FlatAppearance.BorderSize = 0;
            this.btn_statement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statement.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statement.ForeColor = System.Drawing.Color.White;
            this.btn_statement.Location = new System.Drawing.Point(847, 6);
            this.btn_statement.Name = "btn_statement";
            this.btn_statement.Size = new System.Drawing.Size(110, 27);
            this.btn_statement.TabIndex = 389;
            this.btn_statement.Text = "Export";
            this.btn_statement.UseVisualStyleBackColor = false;
            this.btn_statement.Click += new System.EventHandler(this.btn_statement_Click);
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(612, 11);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(24, 16);
            this.customLabel2.TabIndex = 395;
            this.customLabel2.Text = "To";
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.BackColor = System.Drawing.Color.White;
            this.DateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerTo.CustomFormat = " MM/dd/yyyy";
            this.DateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerTo.Location = new System.Drawing.Point(638, 9);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(87, 21);
            this.DateTimePickerTo.TabIndex = 394;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.Location = new System.Drawing.Point(374, 11);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(136, 16);
            this.customLabel1.TabIndex = 393;
            this.customLabel1.Text = "Invoice Date From";
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.BackColor = System.Drawing.Color.White;
            this.DateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerFrom.CustomFormat = " MM/dd/yyyy";
            this.DateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerFrom.Location = new System.Drawing.Point(516, 9);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(87, 21);
            this.DateTimePickerFrom.TabIndex = 392;
            // 
            // grid_all
            // 
            this.grid_all.AllowUserToAddRows = false;
            this.grid_all.AllowUserToDeleteRows = false;
            this.grid_all.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_all.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_all.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_all.BackgroundColor = System.Drawing.Color.White;
            this.grid_all.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_all.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_all.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_all.EnableHeadersVisualStyles = false;
            this.grid_all.GridColor = System.Drawing.Color.LightGray;
            this.grid_all.Location = new System.Drawing.Point(12, 39);
            this.grid_all.MultiSelect = false;
            this.grid_all.Name = "grid_all";
            this.grid_all.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_all.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_all.RowHeadersVisible = false;
            this.grid_all.RowTemplate.Height = 19;
            this.grid_all.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_all.Size = new System.Drawing.Size(1817, 887);
            this.grid_all.StandardTab = true;
            this.grid_all.TabIndex = 391;
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(12, 9);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(68, 18);
            this.customLabel5.TabIndex = 388;
            this.customLabel5.Text = "Customer";
            // 
            // cbox_customer
            // 
            this.cbox_customer.BackColor = System.Drawing.Color.White;
            this.cbox_customer.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.cbox_customer.FormattingEnabled = true;
            this.cbox_customer.Location = new System.Drawing.Point(86, 6);
            this.cbox_customer.Name = "cbox_customer";
            this.cbox_customer.Size = new System.Drawing.Size(282, 27);
            this.cbox_customer.TabIndex = 387;
            // 
            // AROPENCLOSED_ALL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 938);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.DateTimePickerTo);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.DateTimePickerFrom);
            this.Controls.Add(this.grid_all);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_statement);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.cbox_customer);
            this.Name = "AROPENCLOSED_ALL";
            this.Text = "AR OPEN & CLOSE ALL";
            ((System.ComponentModel.ISupportInitialize)(this.grid_all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_statement;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomComboBoxLarge cbox_customer;
        private CustomGrid grid_all;
        private Purchase.CustomDateTimePicker DateTimePickerFrom;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomLabel customLabel2;
        private Purchase.CustomDateTimePicker DateTimePickerTo;
    }
}