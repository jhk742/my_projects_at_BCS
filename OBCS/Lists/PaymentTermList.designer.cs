
namespace OBCS.Lists
{
    partial class PaymentTermList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_newSave = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Description = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NetDaysToPay = new OBCS.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DCDays = new OBCS.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DCPercentage = new OBCS.CustomTextBox();
            this.cbo_Status = new OBCS.Tools.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.txt_PaymentTerm = new OBCS.CustomTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_inactive = new System.Windows.Forms.CheckBox();
            this.txt_SearchPMDescription = new OBCS.CustomTextBox();
            this.txt_searchPMCode = new OBCS.CustomTextBox();
            this.grid_PaymentTerm = new OBCS.CustomGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PaymentTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_newSave
            // 
            this.btn_newSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newSave.Location = new System.Drawing.Point(1366, 9);
            this.btn_newSave.Name = "btn_newSave";
            this.btn_newSave.Size = new System.Drawing.Size(154, 40);
            this.btn_newSave.TabIndex = 787;
            this.btn_newSave.Text = "Save New Payment Term";
            this.btn_newSave.UseVisualStyleBackColor = true;
            this.btn_newSave.Visible = false;
            this.btn_newSave.Click += new System.EventHandler(this.btn_newSave_Click);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(1207, 9);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(154, 40);
            this.btn_new.TabIndex = 786;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(185, 9);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(83, 15);
            this.label34.TabIndex = 785;
            this.label34.Text = "Payment Term";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(6, 16);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(176, 33);
            this.label31.TabIndex = 784;
            this.label31.Text = "Payment Term";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_Description);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_NetDaysToPay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_DCDays);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_DCPercentage);
            this.panel1.Controls.Add(this.cbo_Status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label56);
            this.panel1.Controls.Add(this.txt_PaymentTerm);
            this.panel1.Location = new System.Drawing.Point(1156, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 294);
            this.panel1.TabIndex = 782;
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.txt_Description.Location = new System.Drawing.Point(11, 79);
            this.txt_Description.MaxLength = 200;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(340, 83);
            this.txt_Description.TabIndex = 1;
            this.txt_Description.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Net days to pay";
            // 
            // txt_NetDaysToPay
            // 
            this.txt_NetDaysToPay.BackColor = System.Drawing.Color.White;
            this.txt_NetDaysToPay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NetDaysToPay.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_NetDaysToPay.Location = new System.Drawing.Point(11, 248);
            this.txt_NetDaysToPay.MaxLength = 30;
            this.txt_NetDaysToPay.Name = "txt_NetDaysToPay";
            this.txt_NetDaysToPay.Size = new System.Drawing.Size(163, 21);
            this.txt_NetDaysToPay.TabIndex = 4;
            this.txt_NetDaysToPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NetDaysToPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Number_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Discount days";
            // 
            // txt_DCDays
            // 
            this.txt_DCDays.BackColor = System.Drawing.Color.White;
            this.txt_DCDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DCDays.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_DCDays.Location = new System.Drawing.Point(188, 194);
            this.txt_DCDays.MaxLength = 30;
            this.txt_DCDays.Name = "txt_DCDays";
            this.txt_DCDays.Size = new System.Drawing.Size(163, 21);
            this.txt_DCDays.TabIndex = 3;
            this.txt_DCDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DCDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Discount percentage(%)";
            // 
            // txt_DCPercentage
            // 
            this.txt_DCPercentage.BackColor = System.Drawing.Color.White;
            this.txt_DCPercentage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_DCPercentage.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_DCPercentage.Location = new System.Drawing.Point(11, 194);
            this.txt_DCPercentage.MaxLength = 30;
            this.txt_DCPercentage.Name = "txt_DCPercentage";
            this.txt_DCPercentage.Size = new System.Drawing.Size(163, 21);
            this.txt_DCPercentage.TabIndex = 2;
            this.txt_DCPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_DCPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Number_KeyPress);
            // 
            // cbo_Status
            // 
            this.cbo_Status.BackColor = System.Drawing.Color.White;
            this.cbo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Status.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Status.FormattingEnabled = true;
            this.cbo_Status.Location = new System.Drawing.Point(188, 248);
            this.cbo_Status.Name = "cbo_Status";
            this.cbo_Status.Size = new System.Drawing.Size(163, 23);
            this.cbo_Status.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(9, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 15);
            this.label32.TabIndex = 2;
            this.label32.Text = "Payment Term";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(185, 230);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(41, 15);
            this.label56.TabIndex = 9;
            this.label56.Text = "Status";
            // 
            // txt_PaymentTerm
            // 
            this.txt_PaymentTerm.BackColor = System.Drawing.Color.White;
            this.txt_PaymentTerm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PaymentTerm.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PaymentTerm.Location = new System.Drawing.Point(11, 30);
            this.txt_PaymentTerm.MaxLength = 30;
            this.txt_PaymentTerm.Name = "txt_PaymentTerm";
            this.txt_PaymentTerm.Size = new System.Drawing.Size(163, 21);
            this.txt_PaymentTerm.TabIndex = 0;
            this.txt_PaymentTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1366, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(154, 40);
            this.btn_save.TabIndex = 788;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 790;
            this.label5.Text = "Description";
            // 
            // cbx_inactive
            // 
            this.cbx_inactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_inactive.AutoSize = true;
            this.cbx_inactive.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_inactive.Location = new System.Drawing.Point(958, 30);
            this.cbx_inactive.Name = "cbx_inactive";
            this.cbx_inactive.Size = new System.Drawing.Size(192, 19);
            this.cbx_inactive.TabIndex = 791;
            this.cbx_inactive.Text = "Include Inactive Payment Term";
            this.cbx_inactive.UseVisualStyleBackColor = true;
            this.cbx_inactive.CheckedChanged += new System.EventHandler(this.cbx_inactive_CheckedChanged);
            // 
            // txt_SearchPMDescription
            // 
            this.txt_SearchPMDescription.BackColor = System.Drawing.Color.White;
            this.txt_SearchPMDescription.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SearchPMDescription.Location = new System.Drawing.Point(359, 27);
            this.txt_SearchPMDescription.MaxLength = 30;
            this.txt_SearchPMDescription.Name = "txt_SearchPMDescription";
            this.txt_SearchPMDescription.Size = new System.Drawing.Size(318, 21);
            this.txt_SearchPMDescription.TabIndex = 789;
            this.txt_SearchPMDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_searchPMCode
            // 
            this.txt_searchPMCode.BackColor = System.Drawing.Color.White;
            this.txt_searchPMCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_searchPMCode.Location = new System.Drawing.Point(188, 27);
            this.txt_searchPMCode.MaxLength = 30;
            this.txt_searchPMCode.Name = "txt_searchPMCode";
            this.txt_searchPMCode.Size = new System.Drawing.Size(165, 21);
            this.txt_searchPMCode.TabIndex = 781;
            this.txt_searchPMCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // grid_PaymentTerm
            // 
            this.grid_PaymentTerm.AllowUserToAddRows = false;
            this.grid_PaymentTerm.AllowUserToDeleteRows = false;
            this.grid_PaymentTerm.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_PaymentTerm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_PaymentTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_PaymentTerm.BackgroundColor = System.Drawing.Color.White;
            this.grid_PaymentTerm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_PaymentTerm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_PaymentTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_PaymentTerm.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_PaymentTerm.EnableHeadersVisualStyles = false;
            this.grid_PaymentTerm.GridColor = System.Drawing.Color.LightGray;
            this.grid_PaymentTerm.Location = new System.Drawing.Point(12, 55);
            this.grid_PaymentTerm.MultiSelect = false;
            this.grid_PaymentTerm.Name = "grid_PaymentTerm";
            this.grid_PaymentTerm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_PaymentTerm.RowHeadersVisible = false;
            this.grid_PaymentTerm.RowTemplate.Height = 19;
            this.grid_PaymentTerm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_PaymentTerm.Size = new System.Drawing.Size(1138, 708);
            this.grid_PaymentTerm.StandardTab = true;
            this.grid_PaymentTerm.TabIndex = 783;
            this.grid_PaymentTerm.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_PaymentTerm_CellEnter);
            this.grid_PaymentTerm.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_PaymentTerm_DataBindingComplete);
            // 
            // PaymentTermList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 771);
            this.Controls.Add(this.cbx_inactive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SearchPMDescription);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_newSave);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txt_searchPMCode);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_PaymentTerm);
            this.Name = "PaymentTermList";
            this.Text = "Payment Term List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PaymentTerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_newSave;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label34;
        private CustomTextBox txt_searchPMCode;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel panel1;
        private Tools.CustomComboBox cbo_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label56;
        private CustomTextBox txt_PaymentTerm;
        private CustomGrid grid_PaymentTerm;
        private System.Windows.Forms.Label label4;
        private CustomTextBox txt_NetDaysToPay;
        private System.Windows.Forms.Label label3;
        private CustomTextBox txt_DCDays;
        private System.Windows.Forms.Label label1;
        private CustomTextBox txt_DCPercentage;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label5;
        private CustomTextBox txt_SearchPMDescription;
        private System.Windows.Forms.RichTextBox txt_Description;
        private System.Windows.Forms.CheckBox cbx_inactive;
    }
}