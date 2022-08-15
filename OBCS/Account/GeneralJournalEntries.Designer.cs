namespace OBCS.Account
{
    partial class GeneralJournalEntries
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.multiColumnComboBox1 = new MyCustomControls.InheritedCombo.MultiColumnComboBox(this.components);
            this.btn_newLine = new System.Windows.Forms.Button();
            this.cbo_company = new OBCS.Tools.CustomComboBox();
            this.customLabel12 = new OBCS.Tools.CustomLabel();
            this.txt_totalCredit = new OBCS.CustomTextBox();
            this.txt_totalDebit = new OBCS.CustomTextBox();
            this.grid_journal = new OBCS.CustomGrid();
            this.dateTimePicker_accountDate = new OBCS.Purchase.CustomDateTimePicker();
            this.txt_EntryNumber = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_journal)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1159, 746);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 33);
            this.btn_save.TabIndex = 800;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(823, 746);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 33);
            this.button3.TabIndex = 804;
            this.button3.Text = "Revert";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 807;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 806;
            this.label4.Text = "Entry No.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 749);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 811;
            this.label1.Text = "Totals";
            // 
            // multiColumnComboBox1
            // 
            this.multiColumnComboBox1.FormattingEnabled = true;
            this.multiColumnComboBox1.Location = new System.Drawing.Point(798, 6);
            this.multiColumnComboBox1.Name = "multiColumnComboBox1";
            this.multiColumnComboBox1.Size = new System.Drawing.Size(121, 21);
            this.multiColumnComboBox1.TabIndex = 815;
            this.multiColumnComboBox1.Visible = false;
            // 
            // btn_newLine
            // 
            this.btn_newLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_newLine.BackColor = System.Drawing.Color.Snow;
            this.btn_newLine.FlatAppearance.BorderSize = 0;
            this.btn_newLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newLine.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newLine.ForeColor = System.Drawing.Color.DimGray;
            this.btn_newLine.Location = new System.Drawing.Point(12, 746);
            this.btn_newLine.Name = "btn_newLine";
            this.btn_newLine.Size = new System.Drawing.Size(113, 33);
            this.btn_newLine.TabIndex = 816;
            this.btn_newLine.Text = "Add a new line";
            this.btn_newLine.UseVisualStyleBackColor = false;
            this.btn_newLine.Click += new System.EventHandler(this.btn_newLine_Click);
            // 
            // cbo_company
            // 
            this.cbo_company.BackColor = System.Drawing.Color.White;
            this.cbo_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_company.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_company.FormattingEnabled = true;
            this.cbo_company.Location = new System.Drawing.Point(395, 6);
            this.cbo_company.Name = "cbo_company";
            this.cbo_company.Size = new System.Drawing.Size(319, 23);
            this.cbo_company.TabIndex = 813;
            // 
            // customLabel12
            // 
            this.customLabel12.AutoSize = true;
            this.customLabel12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel12.Location = new System.Drawing.Point(331, 9);
            this.customLabel12.Name = "customLabel12";
            this.customLabel12.Size = new System.Drawing.Size(58, 15);
            this.customLabel12.TabIndex = 814;
            this.customLabel12.Text = "Company";
            // 
            // txt_totalCredit
            // 
            this.txt_totalCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_totalCredit.BackColor = System.Drawing.Color.White;
            this.txt_totalCredit.Enabled = false;
            this.txt_totalCredit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalCredit.Location = new System.Drawing.Point(463, 746);
            this.txt_totalCredit.MaxLength = 50;
            this.txt_totalCredit.Name = "txt_totalCredit";
            this.txt_totalCredit.Size = new System.Drawing.Size(150, 21);
            this.txt_totalCredit.TabIndex = 812;
            this.txt_totalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_totalDebit
            // 
            this.txt_totalDebit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_totalDebit.BackColor = System.Drawing.Color.White;
            this.txt_totalDebit.Enabled = false;
            this.txt_totalDebit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalDebit.Location = new System.Drawing.Point(314, 746);
            this.txt_totalDebit.MaxLength = 50;
            this.txt_totalDebit.Name = "txt_totalDebit";
            this.txt_totalDebit.Size = new System.Drawing.Size(150, 21);
            this.txt_totalDebit.TabIndex = 810;
            this.txt_totalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grid_journal
            // 
            this.grid_journal.AllowUserToAddRows = false;
            this.grid_journal.AllowUserToDeleteRows = false;
            this.grid_journal.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_journal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_journal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_journal.BackgroundColor = System.Drawing.Color.White;
            this.grid_journal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_journal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_journal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_journal.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_journal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_journal.EnableHeadersVisualStyles = false;
            this.grid_journal.GridColor = System.Drawing.Color.LightGray;
            this.grid_journal.Location = new System.Drawing.Point(12, 33);
            this.grid_journal.MultiSelect = false;
            this.grid_journal.Name = "grid_journal";
            this.grid_journal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_journal.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_journal.RowHeadersVisible = false;
            this.grid_journal.RowTemplate.Height = 19;
            this.grid_journal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_journal.Size = new System.Drawing.Size(1260, 707);
            this.grid_journal.StandardTab = true;
            this.grid_journal.TabIndex = 809;
            this.grid_journal.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_journal_CellEndEdit);
            // 
            // dateTimePicker_accountDate
            // 
            this.dateTimePicker_accountDate.BackColor = System.Drawing.Color.White;
            this.dateTimePicker_accountDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_accountDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker_accountDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_accountDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_accountDate.Location = new System.Drawing.Point(50, 6);
            this.dateTimePicker_accountDate.Name = "dateTimePicker_accountDate";
            this.dateTimePicker_accountDate.Size = new System.Drawing.Size(102, 21);
            this.dateTimePicker_accountDate.TabIndex = 808;
            // 
            // txt_EntryNumber
            // 
            this.txt_EntryNumber.BackColor = System.Drawing.Color.White;
            this.txt_EntryNumber.Enabled = false;
            this.txt_EntryNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_EntryNumber.Location = new System.Drawing.Point(220, 6);
            this.txt_EntryNumber.MaxLength = 50;
            this.txt_EntryNumber.Name = "txt_EntryNumber";
            this.txt_EntryNumber.Size = new System.Drawing.Size(91, 21);
            this.txt_EntryNumber.TabIndex = 805;
            // 
            // GeneralJournalEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 791);
            this.Controls.Add(this.btn_newLine);
            this.Controls.Add(this.multiColumnComboBox1);
            this.Controls.Add(this.cbo_company);
            this.Controls.Add(this.customLabel12);
            this.Controls.Add(this.txt_totalCredit);
            this.Controls.Add(this.txt_totalDebit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_journal);
            this.Controls.Add(this.dateTimePicker_accountDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_EntryNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_save);
            this.MinimumSize = new System.Drawing.Size(1300, 830);
            this.Name = "GeneralJournalEntries";
            this.Text = "Make General Journal Entries";
            ((System.ComponentModel.ISupportInitialize)(this.grid_journal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button3;
        private Purchase.CustomDateTimePicker dateTimePicker_accountDate;
        private System.Windows.Forms.Label label5;
        private CustomTextBox txt_EntryNumber;
        private System.Windows.Forms.Label label4;
        private CustomGrid grid_journal;
        private CustomTextBox txt_totalDebit;
        private System.Windows.Forms.Label label1;
        private CustomTextBox txt_totalCredit;
        private Tools.CustomComboBox cbo_company;
        private Tools.CustomLabel customLabel12;
        private MyCustomControls.InheritedCombo.MultiColumnComboBox multiColumnComboBox1;
        private System.Windows.Forms.Button btn_newLine;
    }
}