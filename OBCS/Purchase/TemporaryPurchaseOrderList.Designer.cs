namespace OBCS.Purchase
{
    partial class TemporaryPurchaseOrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_brands = new OBCS.CustomGrid();
            this.grid_product = new OBCS.CustomGrid();
            this.btn_reset = new System.Windows.Forms.Button();
            this.customTextBox1 = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_brands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_brands
            // 
            this.grid_brands.AllowUserToAddRows = false;
            this.grid_brands.AllowUserToDeleteRows = false;
            this.grid_brands.AllowUserToResizeRows = false;
            this.grid_brands.BackgroundColor = System.Drawing.Color.White;
            this.grid_brands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_brands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_brands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grid_brands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_brands.DefaultCellStyle = dataGridViewCellStyle14;
            this.grid_brands.EnableHeadersVisualStyles = false;
            this.grid_brands.GridColor = System.Drawing.Color.LightGray;
            this.grid_brands.Location = new System.Drawing.Point(12, 52);
            this.grid_brands.MultiSelect = false;
            this.grid_brands.Name = "grid_brands";
            this.grid_brands.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_brands.RowHeadersVisible = false;
            this.grid_brands.RowTemplate.Height = 19;
            this.grid_brands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_brands.Size = new System.Drawing.Size(587, 528);
            this.grid_brands.StandardTab = true;
            this.grid_brands.TabIndex = 0;
            this.grid_brands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_brands_CellClick);
            // 
            // grid_product
            // 
            this.grid_product.AllowUserToAddRows = false;
            this.grid_product.AllowUserToDeleteRows = false;
            this.grid_product.AllowUserToResizeRows = false;
            this.grid_product.BackgroundColor = System.Drawing.Color.White;
            this.grid_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grid_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_product.DefaultCellStyle = dataGridViewCellStyle16;
            this.grid_product.EnableHeadersVisualStyles = false;
            this.grid_product.GridColor = System.Drawing.Color.LightGray;
            this.grid_product.Location = new System.Drawing.Point(605, 52);
            this.grid_product.MultiSelect = false;
            this.grid_product.Name = "grid_product";
            this.grid_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_product.RowHeadersVisible = false;
            this.grid_product.RowTemplate.Height = 19;
            this.grid_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_product.Size = new System.Drawing.Size(806, 528);
            this.grid_product.StandardTab = true;
            this.grid_product.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(12, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(292, 30);
            this.btn_reset.TabIndex = 69;
            this.btn_reset.Text = "Reset Order";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.OldLace;
            this.customTextBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.customTextBox1.Location = new System.Drawing.Point(310, 21);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(100, 21);
            this.customTextBox1.TabIndex = 70;
            this.customTextBox1.Visible = false;
            // 
            // TemporaryPurchaseOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 592);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.grid_product);
            this.Controls.Add(this.grid_brands);
            this.Name = "TemporaryPurchaseOrderList";
            this.Text = "TemporaryPurchaseOrderList";
            ((System.ComponentModel.ISupportInitialize)(this.grid_brands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_brands;
        private CustomGrid grid_product;
        private System.Windows.Forms.Button btn_reset;
        private CustomTextBox customTextBox1;
    }
}