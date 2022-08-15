﻿namespace OBCS.Purchase
{
    partial class AP_AGING
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
            this.btn_export = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_CustomerID = new OBCS.CustomTextBox();
            this.txt_91 = new OBCS.CustomTextBox();
            this.txt_notDue = new OBCS.CustomTextBox();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_030 = new OBCS.CustomTextBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_3160 = new OBCS.CustomTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_6190 = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_count = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_totalAR = new OBCS.CustomTextBox();
            this.grid_aging = new OBCS.CustomGrid();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.customLabel22 = new OBCS.Tools.CustomLabel();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aging)).BeginInit();
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
            this.btn_export.Location = new System.Drawing.Point(472, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(104, 44);
            this.btn_export.TabIndex = 423;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 22);
            this.dateTimePicker1.TabIndex = 408;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(362, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(104, 44);
            this.btn_search.TabIndex = 407;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // customLabel7
            // 
            this.customLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(163, 16);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(68, 15);
            this.customLabel7.TabIndex = 422;
            this.customLabel7.Text = "Supplier ID";
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CustomerID.BackColor = System.Drawing.Color.White;
            this.txt_CustomerID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_CustomerID.Location = new System.Drawing.Point(237, 12);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(119, 21);
            this.txt_CustomerID.TabIndex = 421;
            // 
            // txt_91
            // 
            this.txt_91.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_91.BackColor = System.Drawing.Color.White;
            this.txt_91.Enabled = false;
            this.txt_91.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_91.Location = new System.Drawing.Point(1052, 35);
            this.txt_91.Name = "txt_91";
            this.txt_91.Size = new System.Drawing.Size(110, 21);
            this.txt_91.TabIndex = 420;
            this.txt_91.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_notDue
            // 
            this.txt_notDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_notDue.BackColor = System.Drawing.Color.White;
            this.txt_notDue.Enabled = false;
            this.txt_notDue.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_notDue.Location = new System.Drawing.Point(588, 35);
            this.txt_notDue.Name = "txt_notDue";
            this.txt_notDue.Size = new System.Drawing.Size(110, 21);
            this.txt_notDue.TabIndex = 418;
            this.txt_notDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(596, 17);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(102, 15);
            this.customLabel5.TabIndex = 419;
            this.customLabel5.Text = "Current Due Total";
            // 
            // txt_030
            // 
            this.txt_030.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_030.BackColor = System.Drawing.Color.White;
            this.txt_030.Enabled = false;
            this.txt_030.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_030.Location = new System.Drawing.Point(704, 35);
            this.txt_030.Name = "txt_030";
            this.txt_030.Size = new System.Drawing.Size(110, 21);
            this.txt_030.TabIndex = 416;
            this.txt_030.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(746, 17);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(68, 15);
            this.customLabel4.TabIndex = 417;
            this.customLabel4.Text = "1 - 30 Days";
            // 
            // txt_3160
            // 
            this.txt_3160.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_3160.BackColor = System.Drawing.Color.White;
            this.txt_3160.Enabled = false;
            this.txt_3160.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_3160.Location = new System.Drawing.Point(820, 35);
            this.txt_3160.Name = "txt_3160";
            this.txt_3160.Size = new System.Drawing.Size(110, 21);
            this.txt_3160.TabIndex = 414;
            this.txt_3160.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(855, 17);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(75, 15);
            this.customLabel3.TabIndex = 415;
            this.customLabel3.Text = "31 - 60 Days";
            // 
            // txt_6190
            // 
            this.txt_6190.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_6190.BackColor = System.Drawing.Color.White;
            this.txt_6190.Enabled = false;
            this.txt_6190.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_6190.Location = new System.Drawing.Point(936, 35);
            this.txt_6190.Name = "txt_6190";
            this.txt_6190.Size = new System.Drawing.Size(110, 21);
            this.txt_6190.TabIndex = 412;
            this.txt_6190.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(971, 17);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(75, 15);
            this.customLabel2.TabIndex = 413;
            this.customLabel2.Text = "61 - 90 Days";
            // 
            // txt_count
            // 
            this.txt_count.BackColor = System.Drawing.Color.White;
            this.txt_count.Enabled = false;
            this.txt_count.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_count.Location = new System.Drawing.Point(107, 35);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(39, 21);
            this.txt_count.TabIndex = 410;
            this.txt_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(12, 38);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(83, 15);
            this.customLabel1.TabIndex = 411;
            this.customLabel1.Text = "Total Supplier";
            // 
            // txt_totalAR
            // 
            this.txt_totalAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalAR.BackColor = System.Drawing.Color.White;
            this.txt_totalAR.Enabled = false;
            this.txt_totalAR.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalAR.Location = new System.Drawing.Point(1168, 35);
            this.txt_totalAR.Name = "txt_totalAR";
            this.txt_totalAR.Size = new System.Drawing.Size(110, 21);
            this.txt_totalAR.TabIndex = 409;
            this.txt_totalAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grid_aging
            // 
            this.grid_aging.AllowUserToAddRows = false;
            this.grid_aging.AllowUserToDeleteRows = false;
            this.grid_aging.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_aging.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_aging.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_aging.BackgroundColor = System.Drawing.Color.White;
            this.grid_aging.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_aging.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_aging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_aging.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_aging.EnableHeadersVisualStyles = false;
            this.grid_aging.GridColor = System.Drawing.Color.LightGray;
            this.grid_aging.Location = new System.Drawing.Point(11, 62);
            this.grid_aging.MultiSelect = false;
            this.grid_aging.Name = "grid_aging";
            this.grid_aging.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_aging.RowHeadersVisible = false;
            this.grid_aging.RowTemplate.Height = 19;
            this.grid_aging.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_aging.Size = new System.Drawing.Size(1267, 675);
            this.grid_aging.StandardTab = true;
            this.grid_aging.TabIndex = 406;
            this.grid_aging.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_aging_DataBindingComplete);
            // 
            // customLabel6
            // 
            this.customLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(1102, 17);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(60, 15);
            this.customLabel6.TabIndex = 425;
            this.customLabel6.Text = "+ 91 Days";
            // 
            // customLabel22
            // 
            this.customLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel22.AutoSize = true;
            this.customLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel22.Location = new System.Drawing.Point(1244, 17);
            this.customLabel22.Name = "customLabel22";
            this.customLabel22.Size = new System.Drawing.Size(34, 15);
            this.customLabel22.TabIndex = 424;
            this.customLabel22.Text = "Total";
            // 
            // customLabel8
            // 
            this.customLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(197, 37);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(34, 15);
            this.customLabel8.TabIndex = 426;
            this.customLabel8.Text = "As of";
            // 
            // AP_AGING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 749);
            this.Controls.Add(this.customLabel8);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.customLabel22);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.txt_91);
            this.Controls.Add(this.txt_notDue);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.txt_030);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.txt_3160);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.txt_6190);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_totalAR);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.grid_aging);
            this.MinimumSize = new System.Drawing.Size(1306, 39);
            this.Name = "AP_AGING";
            this.Text = "AP AGING";
            ((System.ComponentModel.ISupportInitialize)(this.grid_aging)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_export;
        private Tools.CustomLabel customLabel7;
        private CustomTextBox txt_CustomerID;
        private CustomTextBox txt_91;
        private CustomTextBox txt_notDue;
        private Tools.CustomLabel customLabel5;
        private CustomTextBox txt_030;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_3160;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_6190;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_count;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_totalAR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_search;
        private CustomGrid grid_aging;
        private Tools.CustomLabel customLabel6;
        private Tools.CustomLabel customLabel22;
        private Tools.CustomLabel customLabel8;
    }
}