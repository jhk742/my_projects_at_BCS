namespace OBCS.Purchase
{
    partial class ProductFindDialog
    {
        ///// <summary>
        ///// Required designer variable.
        ///// </summary>
        //private System.ComponentModel.IContainer components = null;

        ///// <summary>
        ///// Clean up any resources being used.
        ///// </summary>
        ///// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //#region Windows Form Designer generated code

        ///// <summary>
        ///// Required method for Designer support - do not modify
        ///// the contents of this method with the code editor.
        ///// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbox_SelectAll = new System.Windows.Forms.CheckBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.grid_salesOrderItems = new OBCS.CustomGrid();
            this.customLabel16 = new OBCS.Tools.CustomLabel();
            this.txt_cfmUser = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_SelectAll
            // 
            this.cbox_SelectAll.AutoSize = true;
            this.cbox_SelectAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbox_SelectAll.Location = new System.Drawing.Point(291, 20);
            this.cbox_SelectAll.Name = "cbox_SelectAll";
            this.cbox_SelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbox_SelectAll.TabIndex = 314;
            this.cbox_SelectAll.Text = "Select All";
            this.cbox_SelectAll.UseVisualStyleBackColor = false;
            this.cbox_SelectAll.CheckedChanged += new System.EventHandler(this.cbox_SelectAll_CheckedChanged);
            // 
            // btn_apply
            // 
            this.btn_apply.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.Location = new System.Drawing.Point(684, 12);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(104, 30);
            this.btn_apply.TabIndex = 315;
            this.btn_apply.Text = "APPLY";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // grid_salesOrderItems
            // 
            this.grid_salesOrderItems.AllowUserToAddRows = false;
            this.grid_salesOrderItems.AllowUserToDeleteRows = false;
            this.grid_salesOrderItems.AllowUserToResizeRows = false;
            this.grid_salesOrderItems.BackgroundColor = System.Drawing.Color.White;
            this.grid_salesOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_salesOrderItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_salesOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_salesOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_salesOrderItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_salesOrderItems.EnableHeadersVisualStyles = false;
            this.grid_salesOrderItems.GridColor = System.Drawing.Color.LightGray;
            this.grid_salesOrderItems.Location = new System.Drawing.Point(12, 48);
            this.grid_salesOrderItems.MultiSelect = false;
            this.grid_salesOrderItems.Name = "grid_salesOrderItems";
            this.grid_salesOrderItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_salesOrderItems.RowHeadersVisible = false;
            this.grid_salesOrderItems.RowTemplate.Height = 19;
            this.grid_salesOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_salesOrderItems.Size = new System.Drawing.Size(776, 390);
            this.grid_salesOrderItems.StandardTab = true;
            this.grid_salesOrderItems.TabIndex = 316;
            // 
            // customLabel16
            // 
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel16.Location = new System.Drawing.Point(12, 19);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(77, 16);
            this.customLabel16.TabIndex = 313;
            this.customLabel16.Text = "Find Product";
            // 
            // txt_cfmUser
            // 
            this.txt_cfmUser.BackColor = System.Drawing.Color.OldLace;
            this.txt_cfmUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cfmUser.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_cfmUser.Location = new System.Drawing.Point(95, 17);
            this.txt_cfmUser.Name = "txt_cfmUser";
            this.txt_cfmUser.Size = new System.Drawing.Size(161, 21);
            this.txt_cfmUser.TabIndex = 277;
            // 
            // ProductFindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_salesOrderItems);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.cbox_SelectAll);
            this.Controls.Add(this.customLabel16);
            this.Controls.Add(this.txt_cfmUser);
            this.Name = "ProductFindDialog";
            this.Text = "Find Product";
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //#endregion
        private CustomTextBox txt_cfmUser;
        private Tools.CustomLabel customLabel16;
        private System.Windows.Forms.CheckBox cbox_SelectAll;
        private System.Windows.Forms.Button btn_apply;
        private CustomGrid grid_salesOrderItems;
    }
}