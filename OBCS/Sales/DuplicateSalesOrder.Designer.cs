namespace OBCS.Sales
{
    partial class DuplicateSalesOrder
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
            this.btn_search = new System.Windows.Forms.Button();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.btn_duplicate = new System.Windows.Forms.Button();
            this.cbo_customerID = new OBCS.Tools.CustomComboBoxLarge();
            this.cbo_deliveryNumber = new OBCS.Tools.CustomComboBoxLarge();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(381, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(104, 27);
            this.btn_search.TabIndex = 367;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(95, 45);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(84, 18);
            this.customLabel5.TabIndex = 368;
            this.customLabel5.Text = "Customer ID";
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(65, 79);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(114, 18);
            this.customLabel1.TabIndex = 370;
            this.customLabel1.Text = "Delivery Number";
            // 
            // btn_duplicate
            // 
            this.btn_duplicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_duplicate.FlatAppearance.BorderSize = 0;
            this.btn_duplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duplicate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_duplicate.ForeColor = System.Drawing.Color.White;
            this.btn_duplicate.Location = new System.Drawing.Point(381, 74);
            this.btn_duplicate.Name = "btn_duplicate";
            this.btn_duplicate.Size = new System.Drawing.Size(104, 27);
            this.btn_duplicate.TabIndex = 533;
            this.btn_duplicate.Text = "Duplicate";
            this.btn_duplicate.UseVisualStyleBackColor = false;
            this.btn_duplicate.Click += new System.EventHandler(this.btn_duplicate_Click);
            // 
            // cbo_customerID
            // 
            this.cbo_customerID.BackColor = System.Drawing.Color.White;
            this.cbo_customerID.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.cbo_customerID.FormattingEnabled = true;
            this.cbo_customerID.Location = new System.Drawing.Point(185, 41);
            this.cbo_customerID.Name = "cbo_customerID";
            this.cbo_customerID.Size = new System.Drawing.Size(190, 27);
            this.cbo_customerID.TabIndex = 534;
            this.cbo_customerID.SelectedValueChanged += new System.EventHandler(this.cbo_customerID_SelectedValueChanged);
            this.cbo_customerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbox_customerID_KeyPress);
            // 
            // cbo_deliveryNumber
            // 
            this.cbo_deliveryNumber.BackColor = System.Drawing.Color.White;
            this.cbo_deliveryNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_deliveryNumber.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.cbo_deliveryNumber.FormattingEnabled = true;
            this.cbo_deliveryNumber.Location = new System.Drawing.Point(185, 74);
            this.cbo_deliveryNumber.Name = "cbo_deliveryNumber";
            this.cbo_deliveryNumber.Size = new System.Drawing.Size(190, 27);
            this.cbo_deliveryNumber.TabIndex = 535;
            // 
            // DuplicateSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 144);
            this.Controls.Add(this.cbo_deliveryNumber);
            this.Controls.Add(this.cbo_customerID);
            this.Controls.Add(this.btn_duplicate);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.customLabel5);
            this.Name = "DuplicateSalesOrder";
            this.Text = "Duplicate Sales Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomLabel customLabel1;
        private System.Windows.Forms.Button btn_duplicate;
        private Tools.CustomComboBoxLarge cbo_customerID;
        private Tools.CustomComboBoxLarge cbo_deliveryNumber;
    }
}