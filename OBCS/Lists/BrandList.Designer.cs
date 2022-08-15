namespace OBCS.Lists
{
    partial class BrandList
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BrandMemo = new OBCS.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_leadTime = new OBCS.CustomTextBox();
            this.cbo_BrandStatus = new OBCS.Tools.CustomComboBox();
            this.txt_BrandCode = new OBCS.CustomTextBox();
            this.txt_BrandName = new OBCS.CustomTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.cbx_inactive = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_searchBrandDesc = new OBCS.CustomTextBox();
            this.txt_searchBrandCode = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.grid_brand = new OBCS.CustomGrid();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_newSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_brand)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1298, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(125, 30);
            this.btn_save.TabIndex = 714;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(617, 4);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(77, 15);
            this.label56.TabIndex = 9;
            this.label56.Text = "Brand Status";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(175, 6);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 15);
            this.label33.TabIndex = 2;
            this.label33.Text = "Brand Name";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(5, 6);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(70, 15);
            this.label32.TabIndex = 2;
            this.label32.Text = "Brand Code";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_BrandMemo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_leadTime);
            this.panel1.Controls.Add(this.cbo_BrandStatus);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label56);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.txt_BrandCode);
            this.panel1.Controls.Add(this.txt_BrandName);
            this.panel1.Location = new System.Drawing.Point(714, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 87);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Brand Memo";
            // 
            // txt_BrandMemo
            // 
            this.txt_BrandMemo.BackColor = System.Drawing.Color.White;
            this.txt_BrandMemo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_BrandMemo.Location = new System.Drawing.Point(88, 51);
            this.txt_BrandMemo.MaxLength = 100;
            this.txt_BrandMemo.Name = "txt_BrandMemo";
            this.txt_BrandMemo.Size = new System.Drawing.Size(612, 21);
            this.txt_BrandMemo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lead Time";
            // 
            // txt_leadTime
            // 
            this.txt_leadTime.BackColor = System.Drawing.Color.White;
            this.txt_leadTime.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_leadTime.Location = new System.Drawing.Point(527, 24);
            this.txt_leadTime.MaxLength = 30;
            this.txt_leadTime.Name = "txt_leadTime";
            this.txt_leadTime.Size = new System.Drawing.Size(87, 21);
            this.txt_leadTime.TabIndex = 2;
            // 
            // cbo_BrandStatus
            // 
            this.cbo_BrandStatus.BackColor = System.Drawing.Color.White;
            this.cbo_BrandStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_BrandStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_BrandStatus.FormattingEnabled = true;
            this.cbo_BrandStatus.Location = new System.Drawing.Point(620, 22);
            this.cbo_BrandStatus.Name = "cbo_BrandStatus";
            this.cbo_BrandStatus.Size = new System.Drawing.Size(80, 23);
            this.cbo_BrandStatus.TabIndex = 3;
            // 
            // txt_BrandCode
            // 
            this.txt_BrandCode.BackColor = System.Drawing.Color.White;
            this.txt_BrandCode.Enabled = false;
            this.txt_BrandCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_BrandCode.Location = new System.Drawing.Point(7, 24);
            this.txt_BrandCode.MaxLength = 30;
            this.txt_BrandCode.Name = "txt_BrandCode";
            this.txt_BrandCode.Size = new System.Drawing.Size(165, 21);
            this.txt_BrandCode.TabIndex = 0;
            this.txt_BrandCode.TextChanged += new System.EventHandler(this.txt_BrandCode_TextChanged);
            this.txt_BrandCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BrandCode_KeyPress);
            // 
            // txt_BrandName
            // 
            this.txt_BrandName.BackColor = System.Drawing.Color.White;
            this.txt_BrandName.Enabled = false;
            this.txt_BrandName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_BrandName.Location = new System.Drawing.Point(178, 24);
            this.txt_BrandName.MaxLength = 100;
            this.txt_BrandName.Name = "txt_BrandName";
            this.txt_BrandName.Size = new System.Drawing.Size(343, 21);
            this.txt_BrandName.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(12, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(91, 33);
            this.label31.TabIndex = 745;
            this.label31.Text = "Brands";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(107, 3);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(70, 15);
            this.label34.TabIndex = 770;
            this.label34.Text = "Brand Code";
            // 
            // cbx_inactive
            // 
            this.cbx_inactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_inactive.AutoSize = true;
            this.cbx_inactive.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_inactive.Location = new System.Drawing.Point(553, 23);
            this.cbx_inactive.Name = "cbx_inactive";
            this.cbx_inactive.Size = new System.Drawing.Size(155, 19);
            this.cbx_inactive.TabIndex = 2;
            this.cbx_inactive.Text = "Include Inactive Brands";
            this.cbx_inactive.UseVisualStyleBackColor = true;
            this.cbx_inactive.CheckedChanged += new System.EventHandler(this.cbx_inactive_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(203, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 772;
            this.label8.Text = "Brand Name";
            // 
            // txt_searchBrandDesc
            // 
            this.txt_searchBrandDesc.BackColor = System.Drawing.Color.White;
            this.txt_searchBrandDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchBrandDesc.Location = new System.Drawing.Point(205, 21);
            this.txt_searchBrandDesc.MaxLength = 30;
            this.txt_searchBrandDesc.Name = "txt_searchBrandDesc";
            this.txt_searchBrandDesc.Size = new System.Drawing.Size(219, 21);
            this.txt_searchBrandDesc.TabIndex = 1;
            this.txt_searchBrandDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searchProductDesc_KeyPress);
            // 
            // txt_searchBrandCode
            // 
            this.txt_searchBrandCode.BackColor = System.Drawing.Color.White;
            this.txt_searchBrandCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchBrandCode.Location = new System.Drawing.Point(109, 21);
            this.txt_searchBrandCode.MaxLength = 30;
            this.txt_searchBrandCode.Name = "txt_searchBrandCode";
            this.txt_searchBrandCode.Size = new System.Drawing.Size(90, 21);
            this.txt_searchBrandCode.TabIndex = 0;
            this.txt_searchBrandCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_searchProductID_KeyPress);
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(-384, 12);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(46, 15);
            this.customLabel2.TabIndex = 624;
            this.customLabel2.Text = "Branch";
            this.customLabel2.Visible = false;
            // 
            // grid_brand
            // 
            this.grid_brand.AllowUserToAddRows = false;
            this.grid_brand.AllowUserToDeleteRows = false;
            this.grid_brand.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_brand.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_brand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_brand.BackgroundColor = System.Drawing.Color.White;
            this.grid_brand.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_brand.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_brand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_brand.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_brand.EnableHeadersVisualStyles = false;
            this.grid_brand.GridColor = System.Drawing.Color.LightGray;
            this.grid_brand.Location = new System.Drawing.Point(12, 45);
            this.grid_brand.MultiSelect = false;
            this.grid_brand.Name = "grid_brand";
            this.grid_brand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_brand.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_brand.RowHeadersVisible = false;
            this.grid_brand.RowTemplate.Height = 19;
            this.grid_brand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_brand.Size = new System.Drawing.Size(696, 707);
            this.grid_brand.StandardTab = true;
            this.grid_brand.TabIndex = 4;
            this.grid_brand.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_product_CellEnter);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(1298, 138);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(125, 30);
            this.btn_new.TabIndex = 775;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_newSave
            // 
            this.btn_newSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newSave.Location = new System.Drawing.Point(1298, 174);
            this.btn_newSave.Name = "btn_newSave";
            this.btn_newSave.Size = new System.Drawing.Size(125, 48);
            this.btn_newSave.TabIndex = 776;
            this.btn_newSave.Text = "Save New Brand";
            this.btn_newSave.UseVisualStyleBackColor = true;
            this.btn_newSave.Visible = false;
            this.btn_newSave.Click += new System.EventHandler(this.btn_newSave_Click);
            // 
            // BrandList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 764);
            this.Controls.Add(this.btn_newSave);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_searchBrandDesc);
            this.Controls.Add(this.cbx_inactive);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txt_searchBrandCode);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.grid_brand);
            this.Name = "BrandList";
            this.Text = "Brand List";
            this.Load += new System.EventHandler(this.BrandList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_brand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_brand;
        private Tools.CustomLabel customLabel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private CustomTextBox txt_BrandName;
        private CustomTextBox txt_BrandCode;
        private Tools.CustomComboBox cbo_BrandStatus;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label34;
        private CustomTextBox txt_searchBrandCode;
        private System.Windows.Forms.CheckBox cbx_inactive;
        private System.Windows.Forms.Label label8;
        private CustomTextBox txt_searchBrandDesc;
        private System.Windows.Forms.Label label1;
        private CustomTextBox txt_leadTime;
        private System.Windows.Forms.Label label2;
        private CustomTextBox txt_BrandMemo;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_newSave;
    }
}