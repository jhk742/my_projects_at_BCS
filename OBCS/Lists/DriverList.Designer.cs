namespace OBCS.Lists
{
    partial class DriverList
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
            this.grid_driver = new OBCS.CustomGrid();
            this.txt_driver = new OBCS.CustomTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_driver)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_driver
            // 
            this.grid_driver.AllowUserToAddRows = false;
            this.grid_driver.AllowUserToDeleteRows = false;
            this.grid_driver.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_driver.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_driver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_driver.BackgroundColor = System.Drawing.Color.White;
            this.grid_driver.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_driver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_driver.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_driver.EnableHeadersVisualStyles = false;
            this.grid_driver.GridColor = System.Drawing.Color.LightGray;
            this.grid_driver.Location = new System.Drawing.Point(12, 12);
            this.grid_driver.MultiSelect = false;
            this.grid_driver.Name = "grid_driver";
            this.grid_driver.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_driver.RowHeadersVisible = false;
            this.grid_driver.RowTemplate.Height = 19;
            this.grid_driver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_driver.Size = new System.Drawing.Size(501, 757);
            this.grid_driver.StandardTab = true;
            this.grid_driver.TabIndex = 369;
            this.grid_driver.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_driver_CellClick);
            // 
            // txt_driver
            // 
            this.txt_driver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_driver.BackColor = System.Drawing.Color.White;
            this.txt_driver.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_driver.Location = new System.Drawing.Point(522, 27);
            this.txt_driver.Name = "txt_driver";
            this.txt_driver.Size = new System.Drawing.Size(244, 21);
            this.txt_driver.TabIndex = 377;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(522, 54);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(244, 52);
            this.btn_save.TabIndex = 374;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(519, 9);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(101, 15);
            this.customLabel1.TabIndex = 370;
            this.customLabel1.Text = "New Driver Name";
            // 
            // DriverList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 781);
            this.Controls.Add(this.txt_driver);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.grid_driver);
            this.Name = "DriverList";
            this.Text = "Driver List";
            ((System.ComponentModel.ISupportInitialize)(this.grid_driver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_driver;
        private CustomTextBox txt_driver;
        private System.Windows.Forms.Button btn_save;
        private Tools.CustomLabel customLabel1;
    }
}