namespace OBCS.Lists
{
    partial class NutCategorySalesReport
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
            this.btn_PMsearch = new System.Windows.Forms.Button();
            this.chb_Mix = new System.Windows.Forms.CheckBox();
            this.grid_NutDelivery = new OBCS.CustomGrid();
            this.cbx_NutNumber = new OBCS.Tools.CustomComboBox();
            this.dateTimePickerTo = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerFrom = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NutDelivery)).BeginInit();
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
            this.btn_export.Location = new System.Drawing.Point(772, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(113, 31);
            this.btn_export.TabIndex = 512;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_PMsearch
            // 
            this.btn_PMsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PMsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_PMsearch.FlatAppearance.BorderSize = 0;
            this.btn_PMsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PMsearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PMsearch.ForeColor = System.Drawing.Color.White;
            this.btn_PMsearch.Location = new System.Drawing.Point(653, 12);
            this.btn_PMsearch.Name = "btn_PMsearch";
            this.btn_PMsearch.Size = new System.Drawing.Size(113, 31);
            this.btn_PMsearch.TabIndex = 511;
            this.btn_PMsearch.Text = "Search";
            this.btn_PMsearch.UseVisualStyleBackColor = false;
            this.btn_PMsearch.Click += new System.EventHandler(this.btn_PMsearch_Click);
            // 
            // chb_Mix
            // 
            this.chb_Mix.AutoSize = true;
            this.chb_Mix.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_Mix.Location = new System.Drawing.Point(12, 21);
            this.chb_Mix.Name = "chb_Mix";
            this.chb_Mix.Size = new System.Drawing.Size(50, 22);
            this.chb_Mix.TabIndex = 516;
            this.chb_Mix.Text = "Mix";
            this.chb_Mix.UseVisualStyleBackColor = true;
            this.chb_Mix.CheckedChanged += new System.EventHandler(this.chb_Mix_CheckedChanged);
            // 
            // grid_NutDelivery
            // 
            this.grid_NutDelivery.AllowUserToAddRows = false;
            this.grid_NutDelivery.AllowUserToDeleteRows = false;
            this.grid_NutDelivery.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_NutDelivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_NutDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_NutDelivery.BackgroundColor = System.Drawing.Color.White;
            this.grid_NutDelivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_NutDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_NutDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_NutDelivery.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_NutDelivery.EnableHeadersVisualStyles = false;
            this.grid_NutDelivery.GridColor = System.Drawing.Color.LightGray;
            this.grid_NutDelivery.Location = new System.Drawing.Point(12, 49);
            this.grid_NutDelivery.MultiSelect = false;
            this.grid_NutDelivery.Name = "grid_NutDelivery";
            this.grid_NutDelivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_NutDelivery.RowHeadersVisible = false;
            this.grid_NutDelivery.RowTemplate.Height = 19;
            this.grid_NutDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_NutDelivery.Size = new System.Drawing.Size(873, 710);
            this.grid_NutDelivery.StandardTab = true;
            this.grid_NutDelivery.TabIndex = 515;
            // 
            // cbx_NutNumber
            // 
            this.cbx_NutNumber.BackColor = System.Drawing.Color.White;
            this.cbx_NutNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_NutNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.cbx_NutNumber.FormattingEnabled = true;
            this.cbx_NutNumber.Location = new System.Drawing.Point(64, 19);
            this.cbx_NutNumber.Name = "cbx_NutNumber";
            this.cbx_NutNumber.Size = new System.Drawing.Size(63, 23);
            this.cbx_NutNumber.TabIndex = 513;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.BackColor = System.Drawing.Color.White;
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(553, 22);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(94, 21);
            this.dateTimePickerTo.TabIndex = 508;
            this.dateTimePickerTo.Visible = false;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(420, 22);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(27, 16);
            this.customLabel2.TabIndex = 510;
            this.customLabel2.Text = "TO";
            this.customLabel2.Visible = false;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.BackColor = System.Drawing.Color.White;
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFrom.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(554, 22);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(94, 21);
            this.dateTimePickerFrom.TabIndex = 507;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(363, 22);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(51, 16);
            this.customLabel5.TabIndex = 509;
            this.customLabel5.Text = "FROM";
            this.customLabel5.Visible = false;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(516, 25);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(32, 15);
            this.customLabel1.TabIndex = 517;
            this.customLabel1.Text = "Date";
            // 
            // NutCategorySalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 771);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.chb_Mix);
            this.Controls.Add(this.grid_NutDelivery);
            this.Controls.Add(this.cbx_NutNumber);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_PMsearch);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.customLabel5);
            this.Name = "NutCategorySalesReport";
            this.Text = "Nut Category Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_NutDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Purchase.CustomDateTimePicker dateTimePickerTo;
        private Tools.CustomLabel customLabel2;
        private Purchase.CustomDateTimePicker dateTimePickerFrom;
        private Tools.CustomLabel customLabel5;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_PMsearch;
        private Tools.CustomComboBox cbx_NutNumber;
        private CustomGrid grid_NutDelivery;
        private System.Windows.Forms.CheckBox chb_Mix;
        private Tools.CustomLabel customLabel1;
    }
}