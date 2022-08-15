namespace OBCS.Purchase
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_keywords5 = new OBCS.CustomTextBox();
            this.txt_cat5 = new OBCS.CustomTextBox();
            this.txt_keywords4 = new OBCS.CustomTextBox();
            this.txt_cat4 = new OBCS.CustomTextBox();
            this.txt_keywords3 = new OBCS.CustomTextBox();
            this.txt_cat3 = new OBCS.CustomTextBox();
            this.txt_keywords2 = new OBCS.CustomTextBox();
            this.txt_cat2 = new OBCS.CustomTextBox();
            this.txt_cat1 = new OBCS.CustomTextBox();
            this.txt_keywords1 = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_sheet = new OBCS.CustomTextBox();
            this.txt_path = new OBCS.CustomTextBox();
            this.grid_category = new OBCS.CustomGrid();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_no1 = new OBCS.CustomTextBox();
            this.txt_no2 = new OBCS.CustomTextBox();
            this.txt_no4 = new OBCS.CustomTextBox();
            this.txt_no3 = new OBCS.CustomTextBox();
            this.txt_no5 = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Excel File Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(629, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Import";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 574);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(922, 52);
            this.button4.TabIndex = 17;
            this.button4.Text = "Export Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(954, 574);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(377, 52);
            this.button3.TabIndex = 18;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txt_keywords5
            // 
            this.txt_keywords5.BackColor = System.Drawing.Color.OldLace;
            this.txt_keywords5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_keywords5.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_keywords5.Location = new System.Drawing.Point(1065, 467);
            this.txt_keywords5.Multiline = true;
            this.txt_keywords5.Name = "txt_keywords5";
            this.txt_keywords5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_keywords5.Size = new System.Drawing.Size(266, 101);
            this.txt_keywords5.TabIndex = 28;
            // 
            // txt_cat5
            // 
            this.txt_cat5.BackColor = System.Drawing.Color.OldLace;
            this.txt_cat5.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_cat5.Location = new System.Drawing.Point(954, 467);
            this.txt_cat5.Name = "txt_cat5";
            this.txt_cat5.Size = new System.Drawing.Size(105, 21);
            this.txt_cat5.TabIndex = 27;
            // 
            // txt_keywords4
            // 
            this.txt_keywords4.BackColor = System.Drawing.Color.OldLace;
            this.txt_keywords4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_keywords4.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_keywords4.Location = new System.Drawing.Point(1065, 360);
            this.txt_keywords4.Multiline = true;
            this.txt_keywords4.Name = "txt_keywords4";
            this.txt_keywords4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_keywords4.Size = new System.Drawing.Size(266, 101);
            this.txt_keywords4.TabIndex = 26;
            // 
            // txt_cat4
            // 
            this.txt_cat4.BackColor = System.Drawing.Color.OldLace;
            this.txt_cat4.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_cat4.Location = new System.Drawing.Point(954, 360);
            this.txt_cat4.Name = "txt_cat4";
            this.txt_cat4.Size = new System.Drawing.Size(105, 21);
            this.txt_cat4.TabIndex = 25;
            // 
            // txt_keywords3
            // 
            this.txt_keywords3.BackColor = System.Drawing.Color.OldLace;
            this.txt_keywords3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_keywords3.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_keywords3.Location = new System.Drawing.Point(1065, 253);
            this.txt_keywords3.Multiline = true;
            this.txt_keywords3.Name = "txt_keywords3";
            this.txt_keywords3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_keywords3.Size = new System.Drawing.Size(266, 101);
            this.txt_keywords3.TabIndex = 24;
            // 
            // txt_cat3
            // 
            this.txt_cat3.BackColor = System.Drawing.Color.OldLace;
            this.txt_cat3.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_cat3.Location = new System.Drawing.Point(954, 253);
            this.txt_cat3.Name = "txt_cat3";
            this.txt_cat3.Size = new System.Drawing.Size(105, 21);
            this.txt_cat3.TabIndex = 23;
            // 
            // txt_keywords2
            // 
            this.txt_keywords2.BackColor = System.Drawing.Color.OldLace;
            this.txt_keywords2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_keywords2.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_keywords2.Location = new System.Drawing.Point(1065, 146);
            this.txt_keywords2.Multiline = true;
            this.txt_keywords2.Name = "txt_keywords2";
            this.txt_keywords2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_keywords2.Size = new System.Drawing.Size(266, 101);
            this.txt_keywords2.TabIndex = 22;
            // 
            // txt_cat2
            // 
            this.txt_cat2.BackColor = System.Drawing.Color.OldLace;
            this.txt_cat2.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_cat2.Location = new System.Drawing.Point(954, 146);
            this.txt_cat2.Name = "txt_cat2";
            this.txt_cat2.Size = new System.Drawing.Size(105, 21);
            this.txt_cat2.TabIndex = 21;
            // 
            // txt_cat1
            // 
            this.txt_cat1.BackColor = System.Drawing.Color.OldLace;
            this.txt_cat1.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_cat1.Location = new System.Drawing.Point(954, 39);
            this.txt_cat1.Name = "txt_cat1";
            this.txt_cat1.Size = new System.Drawing.Size(105, 21);
            this.txt_cat1.TabIndex = 20;
            // 
            // txt_keywords1
            // 
            this.txt_keywords1.BackColor = System.Drawing.Color.OldLace;
            this.txt_keywords1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_keywords1.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_keywords1.Location = new System.Drawing.Point(1065, 39);
            this.txt_keywords1.Multiline = true;
            this.txt_keywords1.Name = "txt_keywords1";
            this.txt_keywords1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_keywords1.Size = new System.Drawing.Size(266, 101);
            this.txt_keywords1.TabIndex = 19;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(60, 41);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(81, 16);
            this.customLabel1.TabIndex = 5;
            this.customLabel1.Text = "Sheet name";
            // 
            // txt_sheet
            // 
            this.txt_sheet.BackColor = System.Drawing.Color.OldLace;
            this.txt_sheet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sheet.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_sheet.Location = new System.Drawing.Point(147, 39);
            this.txt_sheet.Name = "txt_sheet";
            this.txt_sheet.Size = new System.Drawing.Size(476, 21);
            this.txt_sheet.TabIndex = 4;
            // 
            // txt_path
            // 
            this.txt_path.BackColor = System.Drawing.Color.OldLace;
            this.txt_path.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_path.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_path.Location = new System.Drawing.Point(147, 12);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(476, 21);
            this.txt_path.TabIndex = 2;
            // 
            // grid_category
            // 
            this.grid_category.AllowUserToAddRows = false;
            this.grid_category.AllowUserToDeleteRows = false;
            this.grid_category.AllowUserToResizeRows = false;
            this.grid_category.BackgroundColor = System.Drawing.Color.White;
            this.grid_category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_category.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_category.EnableHeadersVisualStyles = false;
            this.grid_category.GridColor = System.Drawing.Color.LightGray;
            this.grid_category.Location = new System.Drawing.Point(12, 79);
            this.grid_category.MultiSelect = false;
            this.grid_category.Name = "grid_category";
            this.grid_category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_category.RowHeadersVisible = false;
            this.grid_category.RowTemplate.Height = 19;
            this.grid_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_category.Size = new System.Drawing.Size(922, 489);
            this.grid_category.StandardTab = true;
            this.grid_category.TabIndex = 0;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(951, 20);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(63, 16);
            this.customLabel2.TabIndex = 29;
            this.customLabel2.Text = "Category";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(1062, 20);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(68, 16);
            this.customLabel3.TabIndex = 30;
            this.customLabel3.Text = "Keywords";
            // 
            // txt_no1
            // 
            this.txt_no1.BackColor = System.Drawing.Color.OldLace;
            this.txt_no1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_no1.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_no1.Location = new System.Drawing.Point(1202, 39);
            this.txt_no1.Multiline = true;
            this.txt_no1.Name = "txt_no1";
            this.txt_no1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_no1.Size = new System.Drawing.Size(131, 101);
            this.txt_no1.TabIndex = 31;
            this.txt_no1.Visible = false;
            // 
            // txt_no2
            // 
            this.txt_no2.BackColor = System.Drawing.Color.OldLace;
            this.txt_no2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_no2.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_no2.Location = new System.Drawing.Point(1202, 146);
            this.txt_no2.Multiline = true;
            this.txt_no2.Name = "txt_no2";
            this.txt_no2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_no2.Size = new System.Drawing.Size(131, 101);
            this.txt_no2.TabIndex = 32;
            this.txt_no2.Visible = false;
            // 
            // txt_no4
            // 
            this.txt_no4.BackColor = System.Drawing.Color.OldLace;
            this.txt_no4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_no4.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_no4.Location = new System.Drawing.Point(1202, 360);
            this.txt_no4.Multiline = true;
            this.txt_no4.Name = "txt_no4";
            this.txt_no4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_no4.Size = new System.Drawing.Size(131, 101);
            this.txt_no4.TabIndex = 34;
            this.txt_no4.Visible = false;
            // 
            // txt_no3
            // 
            this.txt_no3.BackColor = System.Drawing.Color.OldLace;
            this.txt_no3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_no3.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_no3.Location = new System.Drawing.Point(1202, 253);
            this.txt_no3.Multiline = true;
            this.txt_no3.Name = "txt_no3";
            this.txt_no3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_no3.Size = new System.Drawing.Size(131, 101);
            this.txt_no3.TabIndex = 33;
            this.txt_no3.Visible = false;
            // 
            // txt_no5
            // 
            this.txt_no5.BackColor = System.Drawing.Color.OldLace;
            this.txt_no5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_no5.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_no5.Location = new System.Drawing.Point(1202, 467);
            this.txt_no5.Multiline = true;
            this.txt_no5.Name = "txt_no5";
            this.txt_no5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_no5.Size = new System.Drawing.Size(131, 101);
            this.txt_no5.TabIndex = 35;
            this.txt_no5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 635);
            this.Controls.Add(this.txt_no5);
            this.Controls.Add(this.txt_no4);
            this.Controls.Add(this.txt_no3);
            this.Controls.Add(this.txt_no2);
            this.Controls.Add(this.txt_no1);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_keywords5);
            this.Controls.Add(this.txt_cat5);
            this.Controls.Add(this.txt_keywords4);
            this.Controls.Add(this.txt_cat4);
            this.Controls.Add(this.txt_keywords3);
            this.Controls.Add(this.txt_cat3);
            this.Controls.Add(this.txt_keywords2);
            this.Controls.Add(this.txt_cat2);
            this.Controls.Add(this.txt_cat1);
            this.Controls.Add(this.txt_keywords1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_sheet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid_category);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomGrid grid_category;
        private System.Windows.Forms.Button button1;
        private CustomTextBox txt_path;
        private System.Windows.Forms.Button button2;
        private CustomTextBox txt_sheet;
        private Tools.CustomLabel customLabel1;
        private System.Windows.Forms.Button button4;
        private CustomTextBox txt_keywords5;
        private CustomTextBox txt_cat5;
        private CustomTextBox txt_keywords4;
        private CustomTextBox txt_cat4;
        private CustomTextBox txt_keywords3;
        private CustomTextBox txt_cat3;
        private CustomTextBox txt_keywords2;
        private CustomTextBox txt_cat2;
        private CustomTextBox txt_cat1;
        private CustomTextBox txt_keywords1;
        private System.Windows.Forms.Button button3;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_no1;
        private CustomTextBox txt_no2;
        private CustomTextBox txt_no4;
        private CustomTextBox txt_no3;
        private CustomTextBox txt_no5;
    }
}