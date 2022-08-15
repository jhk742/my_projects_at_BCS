
namespace OBCS.Purchase
{
    partial class POCalendarDetail
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
            this.grid_POReceptionDetail = new OBCS.CustomGrid();
            this.label_PONumber = new System.Windows.Forms.Label();
            this.label_SupplierName = new System.Windows.Forms.Label();
            this.txt_PONumber = new System.Windows.Forms.TextBox();
            this.txt_SupplierName = new System.Windows.Forms.TextBox();
            this.text_receptionDate = new System.Windows.Forms.TextBox();
            this.label_ReceptionDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_POReceptionDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_POReceptionDetail
            // 
            this.grid_POReceptionDetail.AllowUserToAddRows = false;
            this.grid_POReceptionDetail.AllowUserToDeleteRows = false;
            this.grid_POReceptionDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_POReceptionDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_POReceptionDetail.BackgroundColor = System.Drawing.Color.White;
            this.grid_POReceptionDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_POReceptionDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_POReceptionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_POReceptionDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_POReceptionDetail.EnableHeadersVisualStyles = false;
            this.grid_POReceptionDetail.GridColor = System.Drawing.Color.LightGray;
            this.grid_POReceptionDetail.Location = new System.Drawing.Point(0, 60);
            this.grid_POReceptionDetail.MinimumSize = new System.Drawing.Size(1808, 799);
            this.grid_POReceptionDetail.MultiSelect = false;
            this.grid_POReceptionDetail.Name = "grid_POReceptionDetail";
            this.grid_POReceptionDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_POReceptionDetail.RowHeadersVisible = false;
            this.grid_POReceptionDetail.RowTemplate.Height = 19;
            this.grid_POReceptionDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_POReceptionDetail.Size = new System.Drawing.Size(1808, 799);
            this.grid_POReceptionDetail.StandardTab = true;
            this.grid_POReceptionDetail.TabIndex = 0;
            this.grid_POReceptionDetail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.grid_POReceptionDetail_KeyUp);
            // 
            // label_PONumber
            // 
            this.label_PONumber.AutoSize = true;
            this.label_PONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PONumber.Location = new System.Drawing.Point(12, 8);
            this.label_PONumber.Name = "label_PONumber";
            this.label_PONumber.Size = new System.Drawing.Size(29, 13);
            this.label_PONumber.TabIndex = 1;
            this.label_PONumber.Text = "PO#";
            // 
            // label_SupplierName
            // 
            this.label_SupplierName.AutoSize = true;
            this.label_SupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SupplierName.Location = new System.Drawing.Point(134, 8);
            this.label_SupplierName.Name = "label_SupplierName";
            this.label_SupplierName.Size = new System.Drawing.Size(45, 13);
            this.label_SupplierName.TabIndex = 2;
            this.label_SupplierName.Text = "Supplier";
            // 
            // txt_PONumber
            // 
            this.txt_PONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PONumber.Location = new System.Drawing.Point(15, 25);
            this.txt_PONumber.Name = "txt_PONumber";
            this.txt_PONumber.ReadOnly = true;
            this.txt_PONumber.Size = new System.Drawing.Size(116, 20);
            this.txt_PONumber.TabIndex = 4;
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupplierName.Location = new System.Drawing.Point(137, 25);
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.ReadOnly = true;
            this.txt_SupplierName.Size = new System.Drawing.Size(286, 20);
            this.txt_SupplierName.TabIndex = 5;
            // 
            // text_receptionDate
            // 
            this.text_receptionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_receptionDate.Location = new System.Drawing.Point(429, 25);
            this.text_receptionDate.Name = "text_receptionDate";
            this.text_receptionDate.ReadOnly = true;
            this.text_receptionDate.Size = new System.Drawing.Size(160, 20);
            this.text_receptionDate.TabIndex = 6;
            // 
            // label_ReceptionDate
            // 
            this.label_ReceptionDate.AutoSize = true;
            this.label_ReceptionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ReceptionDate.Location = new System.Drawing.Point(426, 8);
            this.label_ReceptionDate.Name = "label_ReceptionDate";
            this.label_ReceptionDate.Size = new System.Drawing.Size(163, 13);
            this.label_ReceptionDate.TabIndex = 7;
            this.label_ReceptionDate.Text = "Reception Date (MM/DD/YYYY)";
            // 
            // JINTEST_DETAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 820);
            this.Controls.Add(this.label_ReceptionDate);
            this.Controls.Add(this.text_receptionDate);
            this.Controls.Add(this.txt_SupplierName);
            this.Controls.Add(this.txt_PONumber);
            this.Controls.Add(this.label_SupplierName);
            this.Controls.Add(this.label_PONumber);
            this.Controls.Add(this.grid_POReceptionDetail);
            this.MaximumSize = new System.Drawing.Size(1830, 859);
            this.MinimumSize = new System.Drawing.Size(1808, 859);
            this.Name = "JINTEST_DETAIL";
            this.Text = "PO Reception Detail";
            ((System.ComponentModel.ISupportInitialize)(this.grid_POReceptionDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_POReceptionDetail;
        private System.Windows.Forms.Label label_PONumber;
        private System.Windows.Forms.Label label_SupplierName;
        private System.Windows.Forms.TextBox txt_PONumber;
        private System.Windows.Forms.TextBox txt_SupplierName;
        private System.Windows.Forms.TextBox txt_ReceptionDate;
        private System.Windows.Forms.TextBox text_receptionDate;
        private System.Windows.Forms.Label label_ReceptionDate;
    }
}