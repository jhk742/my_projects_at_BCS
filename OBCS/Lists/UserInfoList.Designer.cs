namespace OBCS.Lists
{
    partial class UserInfoList
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.customLabel16 = new OBCS.Tools.CustomLabel();
            this.customTextBox1 = new OBCS.CustomTextBox();
            this.grid_userInfoList = new OBCS.CustomGrid();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_userInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(995, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(104, 30);
            this.btn_refresh.TabIndex = 324;
            this.btn_refresh.Text = "Add";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // customLabel16
            // 
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel16.Location = new System.Drawing.Point(12, 9);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(59, 16);
            this.customLabel16.TabIndex = 319;
            this.customLabel16.Text = "Find User";
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.OldLace;
            this.customTextBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.customTextBox1.Location = new System.Drawing.Point(15, 25);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(178, 21);
            this.customTextBox1.TabIndex = 325;
            // 
            // grid_userInfoList
            // 
            this.grid_userInfoList.AllowUserToAddRows = false;
            this.grid_userInfoList.AllowUserToDeleteRows = false;
            this.grid_userInfoList.AllowUserToResizeRows = false;
            this.grid_userInfoList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_userInfoList.BackgroundColor = System.Drawing.Color.White;
            this.grid_userInfoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_userInfoList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_userInfoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_userInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_userInfoList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_userInfoList.EnableHeadersVisualStyles = false;
            this.grid_userInfoList.GridColor = System.Drawing.Color.LightGray;
            this.grid_userInfoList.Location = new System.Drawing.Point(12, 52);
            this.grid_userInfoList.MultiSelect = false;
            this.grid_userInfoList.Name = "grid_userInfoList";
            this.grid_userInfoList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_userInfoList.RowHeadersVisible = false;
            this.grid_userInfoList.RowTemplate.Height = 19;
            this.grid_userInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_userInfoList.Size = new System.Drawing.Size(1087, 530);
            this.grid_userInfoList.StandardTab = true;
            this.grid_userInfoList.TabIndex = 326;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 327;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid_userInfoList);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.customLabel16);
            this.Name = "UserInfoList";
            this.Text = "User Info List";
            ((System.ComponentModel.ISupportInitialize)(this.grid_userInfoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private Tools.CustomLabel customLabel16;
        private CustomTextBox customTextBox1;
        private CustomGrid grid_userInfoList;
        private System.Windows.Forms.Button button1;
    }
}