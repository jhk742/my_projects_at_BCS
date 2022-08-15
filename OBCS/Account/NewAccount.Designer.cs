namespace OBCS.Account
{
    partial class NewAccount
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
            this.label56 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_subAccount = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dateTimePicker_asOf = new OBCS.Purchase.CustomDateTimePicker();
            this.txt_openingBalance = new OBCS.CustomTextBox();
            this.txt_routingNumber = new OBCS.CustomTextBox();
            this.txt_accountNumber = new OBCS.CustomTextBox();
            this.cbo_subAccount = new OBCS.Tools.CustomComboBox();
            this.txt_desc = new OBCS.CustomTextBox();
            this.cbo_accountType = new OBCS.Tools.CustomComboBox();
            this.txt_name = new OBCS.CustomTextBox();
            this.SuspendLayout();
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(35, 15);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(78, 15);
            this.label56.TabIndex = 752;
            this.label56.Text = "Account Type";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(75, 44);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(38, 15);
            this.label38.TabIndex = 753;
            this.label38.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 755;
            this.label1.Text = "Description";
            // 
            // cbx_subAccount
            // 
            this.cbx_subAccount.AutoSize = true;
            this.cbx_subAccount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_subAccount.Location = new System.Drawing.Point(122, 70);
            this.cbx_subAccount.Name = "cbx_subAccount";
            this.cbx_subAccount.Size = new System.Drawing.Size(104, 19);
            this.cbx_subAccount.TabIndex = 787;
            this.cbx_subAccount.Text = "Subaccount of";
            this.cbx_subAccount.UseVisualStyleBackColor = true;
            this.cbx_subAccount.CheckedChanged += new System.EventHandler(this.cbx_subAccount_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 790;
            this.label2.Text = "Account No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 792;
            this.label3.Text = "Routing Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 794;
            this.label4.Text = "Opening Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 796;
            this.label5.Text = "as of";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(421, 51);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 33);
            this.btn_cancel.TabIndex = 799;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(421, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(113, 33);
            this.btn_save.TabIndex = 798;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dateTimePicker_asOf
            // 
            this.dateTimePicker_asOf.BackColor = System.Drawing.Color.White;
            this.dateTimePicker_asOf.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_asOf.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker_asOf.Enabled = false;
            this.dateTimePicker_asOf.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_asOf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_asOf.Location = new System.Drawing.Point(259, 178);
            this.dateTimePicker_asOf.Name = "dateTimePicker_asOf";
            this.dateTimePicker_asOf.Size = new System.Drawing.Size(92, 21);
            this.dateTimePicker_asOf.TabIndex = 797;
            // 
            // txt_openingBalance
            // 
            this.txt_openingBalance.BackColor = System.Drawing.Color.White;
            this.txt_openingBalance.Enabled = false;
            this.txt_openingBalance.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_openingBalance.Location = new System.Drawing.Point(119, 178);
            this.txt_openingBalance.MaxLength = 50;
            this.txt_openingBalance.Name = "txt_openingBalance";
            this.txt_openingBalance.Size = new System.Drawing.Size(91, 21);
            this.txt_openingBalance.TabIndex = 793;
            // 
            // txt_routingNumber
            // 
            this.txt_routingNumber.BackColor = System.Drawing.Color.White;
            this.txt_routingNumber.Enabled = false;
            this.txt_routingNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_routingNumber.Location = new System.Drawing.Point(119, 151);
            this.txt_routingNumber.MaxLength = 50;
            this.txt_routingNumber.Name = "txt_routingNumber";
            this.txt_routingNumber.Size = new System.Drawing.Size(259, 21);
            this.txt_routingNumber.TabIndex = 791;
            // 
            // txt_accountNumber
            // 
            this.txt_accountNumber.BackColor = System.Drawing.Color.White;
            this.txt_accountNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_accountNumber.Location = new System.Drawing.Point(119, 124);
            this.txt_accountNumber.MaxLength = 50;
            this.txt_accountNumber.Name = "txt_accountNumber";
            this.txt_accountNumber.Size = new System.Drawing.Size(259, 21);
            this.txt_accountNumber.TabIndex = 789;
            // 
            // cbo_subAccount
            // 
            this.cbo_subAccount.BackColor = System.Drawing.Color.White;
            this.cbo_subAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_subAccount.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_subAccount.FormattingEnabled = true;
            this.cbo_subAccount.Location = new System.Drawing.Point(232, 68);
            this.cbo_subAccount.Name = "cbo_subAccount";
            this.cbo_subAccount.Size = new System.Drawing.Size(146, 23);
            this.cbo_subAccount.TabIndex = 788;
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.Color.White;
            this.txt_desc.Enabled = false;
            this.txt_desc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_desc.Location = new System.Drawing.Point(119, 97);
            this.txt_desc.MaxLength = 50;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(259, 21);
            this.txt_desc.TabIndex = 754;
            // 
            // cbo_accountType
            // 
            this.cbo_accountType.BackColor = System.Drawing.Color.White;
            this.cbo_accountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_accountType.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_accountType.FormattingEnabled = true;
            this.cbo_accountType.Location = new System.Drawing.Point(119, 12);
            this.cbo_accountType.Name = "cbo_accountType";
            this.cbo_accountType.Size = new System.Drawing.Size(146, 23);
            this.cbo_accountType.TabIndex = 751;
            this.cbo_accountType.SelectedValueChanged += new System.EventHandler(this.cbo_accountType_SelectedValueChanged);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_name.Location = new System.Drawing.Point(119, 41);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(259, 21);
            this.txt_name.TabIndex = 750;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 214);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dateTimePicker_asOf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_openingBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_routingNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_accountNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_subAccount);
            this.Controls.Add(this.cbx_subAccount);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_accountType);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label38);
            this.Name = "NewAccount";
            this.Text = "New Account";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.CustomComboBox cbo_accountType;
        private System.Windows.Forms.Label label56;
        private CustomTextBox txt_name;
        private System.Windows.Forms.Label label38;
        private CustomTextBox txt_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_subAccount;
        private Tools.CustomComboBox cbo_subAccount;
        private CustomTextBox txt_accountNumber;
        private System.Windows.Forms.Label label2;
        private CustomTextBox txt_routingNumber;
        private System.Windows.Forms.Label label3;
        private CustomTextBox txt_openingBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Purchase.CustomDateTimePicker dateTimePicker_asOf;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
    }
}