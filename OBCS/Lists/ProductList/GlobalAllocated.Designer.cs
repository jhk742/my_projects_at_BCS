namespace OBCS.Lists
{
    partial class GlobalAllocated
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_searchProductDesc = new OBCS.CustomTextBox();
            this.txt_searchProductID = new OBCS.CustomTextBox();
            this.grid_globalAllocated = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_globalAllocated)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(560, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(71, 34);
            this.btn_refresh.TabIndex = 371;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(10, 7);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 15);
            this.label34.TabIndex = 772;
            this.label34.Text = "Product ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 15);
            this.label8.TabIndex = 774;
            this.label8.Text = "Product Description";
            // 
            // txt_searchProductDesc
            // 
            this.txt_searchProductDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchProductDesc.BackColor = System.Drawing.Color.White;
            this.txt_searchProductDesc.Enabled = false;
            this.txt_searchProductDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchProductDesc.Location = new System.Drawing.Point(108, 25);
            this.txt_searchProductDesc.MaxLength = 30;
            this.txt_searchProductDesc.Name = "txt_searchProductDesc";
            this.txt_searchProductDesc.Size = new System.Drawing.Size(446, 21);
            this.txt_searchProductDesc.TabIndex = 773;
            // 
            // txt_searchProductID
            // 
            this.txt_searchProductID.BackColor = System.Drawing.Color.White;
            this.txt_searchProductID.Enabled = false;
            this.txt_searchProductID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchProductID.Location = new System.Drawing.Point(12, 25);
            this.txt_searchProductID.MaxLength = 30;
            this.txt_searchProductID.Name = "txt_searchProductID";
            this.txt_searchProductID.Size = new System.Drawing.Size(90, 21);
            this.txt_searchProductID.TabIndex = 771;
            // 
            // grid_globalAllocated
            // 
            this.grid_globalAllocated.AllowUserToAddRows = false;
            this.grid_globalAllocated.AllowUserToDeleteRows = false;
            this.grid_globalAllocated.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_globalAllocated.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_globalAllocated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_globalAllocated.BackgroundColor = System.Drawing.Color.White;
            this.grid_globalAllocated.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_globalAllocated.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_globalAllocated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_globalAllocated.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_globalAllocated.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_globalAllocated.EnableHeadersVisualStyles = false;
            this.grid_globalAllocated.GridColor = System.Drawing.Color.LightGray;
            this.grid_globalAllocated.Location = new System.Drawing.Point(12, 52);
            this.grid_globalAllocated.MultiSelect = false;
            this.grid_globalAllocated.Name = "grid_globalAllocated";
            this.grid_globalAllocated.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_globalAllocated.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_globalAllocated.RowHeadersVisible = false;
            this.grid_globalAllocated.RowTemplate.Height = 19;
            this.grid_globalAllocated.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_globalAllocated.Size = new System.Drawing.Size(619, 377);
            this.grid_globalAllocated.StandardTab = true;
            this.grid_globalAllocated.TabIndex = 370;
            this.grid_globalAllocated.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_globalAllocated_CellDoubleClick);
            // 
            // GlobalAllocated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 441);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_searchProductDesc);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txt_searchProductID);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.grid_globalAllocated);
            this.Name = "GlobalAllocated";
            this.Text = "Global Allocated";
            ((System.ComponentModel.ISupportInitialize)(this.grid_globalAllocated)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private CustomGrid grid_globalAllocated;
        private System.Windows.Forms.Label label34;
        private CustomTextBox txt_searchProductID;
        private System.Windows.Forms.Label label8;
        private CustomTextBox txt_searchProductDesc;
    }
}