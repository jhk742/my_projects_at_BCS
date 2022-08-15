namespace OBCS.Lists
{
    partial class ProductList2
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
            this.grid_customer = new OBCS.CustomGrid();
            this.txt_product = new OBCS.CustomTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.cbo_branch = new OBCS.Tools.CustomComboBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.cbo_salesPerson = new OBCS.Tools.CustomComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_customer
            // 
            this.grid_customer.AllowUserToAddRows = false;
            this.grid_customer.AllowUserToDeleteRows = false;
            this.grid_customer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_customer.BackgroundColor = System.Drawing.Color.White;
            this.grid_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_customer.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_customer.EnableHeadersVisualStyles = false;
            this.grid_customer.GridColor = System.Drawing.Color.LightGray;
            this.grid_customer.Location = new System.Drawing.Point(12, 62);
            this.grid_customer.MultiSelect = false;
            this.grid_customer.Name = "grid_customer";
            this.grid_customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_customer.RowHeadersVisible = false;
            this.grid_customer.RowTemplate.Height = 19;
            this.grid_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_customer.Size = new System.Drawing.Size(1345, 646);
            this.grid_customer.StandardTab = true;
            this.grid_customer.TabIndex = 0;
            // 
            // txt_product
            // 
            this.txt_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_product.BackColor = System.Drawing.Color.White;
            this.txt_product.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_product.Location = new System.Drawing.Point(346, 31);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(244, 21);
            this.txt_product.TabIndex = 620;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(346, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 19);
            this.radioButton1.TabIndex = 621;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Product ID";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(450, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 19);
            this.radioButton2.TabIndex = 622;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Product Name";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(9, 13);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(46, 15);
            this.customLabel2.TabIndex = 624;
            this.customLabel2.Text = "Branch";
            this.customLabel2.Visible = false;
            // 
            // cbo_branch
            // 
            this.cbo_branch.BackColor = System.Drawing.Color.White;
            this.cbo_branch.Enabled = false;
            this.cbo_branch.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Location = new System.Drawing.Point(12, 31);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(161, 23);
            this.cbo_branch.TabIndex = 623;
            this.cbo_branch.Visible = false;
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(176, 13);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(77, 15);
            this.customLabel3.TabIndex = 626;
            this.customLabel3.Text = "Sales Person";
            this.customLabel3.Visible = false;
            // 
            // cbo_salesPerson
            // 
            this.cbo_salesPerson.BackColor = System.Drawing.Color.White;
            this.cbo_salesPerson.Enabled = false;
            this.cbo_salesPerson.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_salesPerson.FormattingEnabled = true;
            this.cbo_salesPerson.Location = new System.Drawing.Point(179, 31);
            this.cbo_salesPerson.Name = "cbo_salesPerson";
            this.cbo_salesPerson.Size = new System.Drawing.Size(161, 23);
            this.cbo_salesPerson.TabIndex = 625;
            this.cbo_salesPerson.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1232, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 44);
            this.btn_save.TabIndex = 714;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 720);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.cbo_salesPerson);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.cbo_branch);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.grid_customer);
            this.Name = "ProductList";
            this.Text = "Product List";
            ((System.ComponentModel.ISupportInitialize)(this.grid_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_customer;
        private CustomTextBox txt_product;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomComboBox cbo_branch;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomComboBox cbo_salesPerson;
        private System.Windows.Forms.Button btn_save;
    }
}