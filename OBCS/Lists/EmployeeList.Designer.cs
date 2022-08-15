namespace OBCS.Lists
{
    partial class EmployeeList
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
            this.button1 = new System.Windows.Forms.Button();
            this.grid_employeeList = new OBCS.CustomGrid();
            this.txt_employee = new OBCS.CustomTextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.customLabel16 = new OBCS.Tools.CustomLabel();
            this.cbox_isInactive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_employeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(199, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 332;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_employeeList
            // 
            this.grid_employeeList.AllowUserToAddRows = false;
            this.grid_employeeList.AllowUserToDeleteRows = false;
            this.grid_employeeList.AllowUserToResizeRows = false;
            this.grid_employeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_employeeList.BackgroundColor = System.Drawing.Color.White;
            this.grid_employeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_employeeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_employeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_employeeList.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_employeeList.EnableHeadersVisualStyles = false;
            this.grid_employeeList.GridColor = System.Drawing.Color.LightGray;
            this.grid_employeeList.Location = new System.Drawing.Point(12, 52);
            this.grid_employeeList.MultiSelect = false;
            this.grid_employeeList.Name = "grid_employeeList";
            this.grid_employeeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_employeeList.RowHeadersVisible = false;
            this.grid_employeeList.RowTemplate.Height = 19;
            this.grid_employeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_employeeList.Size = new System.Drawing.Size(1177, 571);
            this.grid_employeeList.StandardTab = true;
            this.grid_employeeList.TabIndex = 331;
            this.grid_employeeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_employeeList_CellDoubleClick);
            // 
            // txt_employee
            // 
            this.txt_employee.BackColor = System.Drawing.Color.OldLace;
            this.txt_employee.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_employee.Location = new System.Drawing.Point(15, 25);
            this.txt_employee.Name = "txt_employee";
            this.txt_employee.Size = new System.Drawing.Size(178, 21);
            this.txt_employee.TabIndex = 330;
            this.txt_employee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_employee_KeyPress);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(1088, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(104, 30);
            this.btn_refresh.TabIndex = 329;
            this.btn_refresh.Text = "Add";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // customLabel16
            // 
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel16.Location = new System.Drawing.Point(12, 9);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(86, 16);
            this.customLabel16.TabIndex = 328;
            this.customLabel16.Text = "Find Employee";
            // 
            // cbox_isInactive
            // 
            this.cbox_isInactive.AutoSize = true;
            this.cbox_isInactive.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_isInactive.Location = new System.Drawing.Point(265, 26);
            this.cbox_isInactive.Name = "cbox_isInactive";
            this.cbox_isInactive.Size = new System.Drawing.Size(131, 20);
            this.cbox_isInactive.TabIndex = 333;
            this.cbox_isInactive.Text = "Including InActinve";
            this.cbox_isInactive.UseVisualStyleBackColor = true;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 635);
            this.Controls.Add(this.cbox_isInactive);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid_employeeList);
            this.Controls.Add(this.txt_employee);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.customLabel16);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            ((System.ComponentModel.ISupportInitialize)(this.grid_employeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CustomGrid grid_employeeList;
        private CustomTextBox txt_employee;
        private System.Windows.Forms.Button btn_refresh;
        private Tools.CustomLabel customLabel16;
        private System.Windows.Forms.CheckBox cbox_isInactive;
    }
}