namespace OBCS.Sales
{
    partial class ARbyCustomerReport
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
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.cbox_customer = new OBCS.Tools.CustomComboBoxLarge();
            this.grid_open = new OBCS.CustomGrid();
            this.grid_closed = new OBCS.CustomGrid();
            this.txt_totalAR = new OBCS.CustomTextBox();
            this.customLabel22 = new OBCS.Tools.CustomLabel();
            this.txt_count = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.btn_statement = new System.Windows.Forms.Button();
            this.txt_totalSettledAR = new OBCS.CustomTextBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_closed)).BeginInit();
            this.SuspendLayout();
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(12, 9);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(68, 18);
            this.customLabel5.TabIndex = 367;
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
            this.cbox_customer.TabIndex = 366;
            this.cbox_customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_customer_KeyPress);
            // 
            // grid_open
            // 
            this.grid_open.AllowUserToAddRows = false;
            this.grid_open.AllowUserToDeleteRows = false;
            this.grid_open.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_open.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_open.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_open.BackgroundColor = System.Drawing.Color.White;
            this.grid_open.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_open.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_open.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_open.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_open.EnableHeadersVisualStyles = false;
            this.grid_open.GridColor = System.Drawing.Color.LightGray;
            this.grid_open.Location = new System.Drawing.Point(12, 54);
            this.grid_open.MultiSelect = false;
            this.grid_open.Name = "grid_open";
            this.grid_open.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_open.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_open.RowHeadersVisible = false;
            this.grid_open.RowTemplate.Height = 19;
            this.grid_open.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_open.Size = new System.Drawing.Size(1423, 327);
            this.grid_open.StandardTab = true;
            this.grid_open.TabIndex = 368;
            this.grid_open.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_open_DataBindingComplete);
            // 
            // grid_closed
            // 
            this.grid_closed.AllowUserToAddRows = false;
            this.grid_closed.AllowUserToDeleteRows = false;
            this.grid_closed.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_closed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_closed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_closed.BackgroundColor = System.Drawing.Color.White;
            this.grid_closed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_closed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_closed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_closed.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_closed.EnableHeadersVisualStyles = false;
            this.grid_closed.GridColor = System.Drawing.Color.LightGray;
            this.grid_closed.Location = new System.Drawing.Point(12, 402);
            this.grid_closed.MultiSelect = false;
            this.grid_closed.Name = "grid_closed";
            this.grid_closed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_closed.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_closed.RowHeadersVisible = false;
            this.grid_closed.RowTemplate.Height = 19;
            this.grid_closed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_closed.Size = new System.Drawing.Size(1423, 335);
            this.grid_closed.StandardTab = true;
            this.grid_closed.TabIndex = 369;
            // 
            // txt_totalAR
            // 
            this.txt_totalAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalAR.BackColor = System.Drawing.Color.White;
            this.txt_totalAR.Enabled = false;
            this.txt_totalAR.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalAR.Location = new System.Drawing.Point(1009, 12);
            this.txt_totalAR.Name = "txt_totalAR";
            this.txt_totalAR.Size = new System.Drawing.Size(159, 21);
            this.txt_totalAR.TabIndex = 377;
            this.txt_totalAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel22
            // 
            this.customLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel22.AutoSize = true;
            this.customLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel22.Location = new System.Drawing.Point(915, 15);
            this.customLabel22.Name = "customLabel22";
            this.customLabel22.Size = new System.Drawing.Size(88, 15);
            this.customLabel22.TabIndex = 378;
            this.customLabel22.Text = "Total Open A/R";
            // 
            // txt_count
            // 
            this.txt_count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_count.BackColor = System.Drawing.Color.White;
            this.txt_count.Enabled = false;
            this.txt_count.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_count.Location = new System.Drawing.Point(870, 12);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(39, 21);
            this.txt_count.TabIndex = 379;
            this.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(741, 15);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(123, 15);
            this.customLabel1.TabIndex = 380;
            this.customLabel1.Text = "Total Open A/R Count";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(12, 36);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(36, 15);
            this.customLabel2.TabIndex = 381;
            this.customLabel2.Text = "Open";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(12, 384);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(44, 15);
            this.customLabel3.TabIndex = 382;
            this.customLabel3.Text = "Closed";
            // 
            // btn_statement
            // 
            this.btn_statement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_statement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_statement.FlatAppearance.BorderSize = 0;
            this.btn_statement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_statement.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statement.ForeColor = System.Drawing.Color.White;
            this.btn_statement.Location = new System.Drawing.Point(586, 6);
            this.btn_statement.Name = "btn_statement";
            this.btn_statement.Size = new System.Drawing.Size(149, 27);
            this.btn_statement.TabIndex = 383;
            this.btn_statement.Text = "Statement";
            this.btn_statement.UseVisualStyleBackColor = false;
            this.btn_statement.Click += new System.EventHandler(this.btn_statement_Click);
            // 
            // txt_totalSettledAR
            // 
            this.txt_totalSettledAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalSettledAR.BackColor = System.Drawing.Color.White;
            this.txt_totalSettledAR.Enabled = false;
            this.txt_totalSettledAR.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalSettledAR.Location = new System.Drawing.Point(1276, 12);
            this.txt_totalSettledAR.Name = "txt_totalSettledAR";
            this.txt_totalSettledAR.Size = new System.Drawing.Size(159, 21);
            this.txt_totalSettledAR.TabIndex = 384;
            this.txt_totalSettledAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(1174, 15);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(96, 15);
            this.customLabel4.TabIndex = 385;
            this.customLabel4.Text = "Total Settled A/R";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(374, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(104, 27);
            this.btn_search.TabIndex = 386;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // AROPENCLOSED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 749);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_totalSettledAR);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.btn_statement);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_totalAR);
            this.Controls.Add(this.customLabel22);
            this.Controls.Add(this.grid_closed);
            this.Controls.Add(this.grid_open);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.cbox_customer);
            this.Name = "AROPENCLOSED";
            this.Text = "AR by Customer Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_closed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.CustomLabel customLabel5;
        private Tools.CustomComboBoxLarge cbox_customer;
        private CustomGrid grid_open;
        private CustomGrid grid_closed;
        private CustomTextBox txt_totalAR;
        private Tools.CustomLabel customLabel22;
        private CustomTextBox txt_count;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomLabel customLabel3;
        private System.Windows.Forms.Button btn_statement;
        private CustomTextBox txt_totalSettledAR;
        private Tools.CustomLabel customLabel4;
        private System.Windows.Forms.Button btn_search;
    }
}