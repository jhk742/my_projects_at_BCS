namespace OBCS.Sales
{
    partial class EditRouteInfo
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
            this.cbo_trucks = new OBCS.Tools.CustomComboBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.cbo_drivers = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_routeNumber = new OBCS.CustomTextBox();
            this.SuspendLayout();
            // 
            // cbo_trucks
            // 
            this.cbo_trucks.BackColor = System.Drawing.Color.White;
            this.cbo_trucks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_trucks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_trucks.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_trucks.FormattingEnabled = true;
            this.cbo_trucks.Location = new System.Drawing.Point(15, 122);
            this.cbo_trucks.Name = "cbo_trucks";
            this.cbo_trucks.Size = new System.Drawing.Size(242, 23);
            this.cbo_trucks.TabIndex = 324;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(12, 104);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(42, 15);
            this.customLabel2.TabIndex = 323;
            this.customLabel2.Text = "TRUCK";
            // 
            // cbo_drivers
            // 
            this.cbo_drivers.BackColor = System.Drawing.Color.White;
            this.cbo_drivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_drivers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_drivers.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_drivers.FormattingEnabled = true;
            this.cbo_drivers.Location = new System.Drawing.Point(15, 74);
            this.cbo_drivers.Name = "cbo_drivers";
            this.cbo_drivers.Size = new System.Drawing.Size(242, 23);
            this.cbo_drivers.TabIndex = 322;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(12, 56);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(46, 15);
            this.customLabel1.TabIndex = 321;
            this.customLabel1.Text = "DRIVER";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(12, 169);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(249, 52);
            this.btn_save.TabIndex = 325;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(12, 227);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(249, 52);
            this.btn_cancel.TabIndex = 326;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(12, 8);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(84, 15);
            this.customLabel3.TabIndex = 327;
            this.customLabel3.Text = "Route Number";
            // 
            // txt_routeNumber
            // 
            this.txt_routeNumber.BackColor = System.Drawing.Color.White;
            this.txt_routeNumber.Enabled = false;
            this.txt_routeNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_routeNumber.Location = new System.Drawing.Point(15, 26);
            this.txt_routeNumber.Name = "txt_routeNumber";
            this.txt_routeNumber.Size = new System.Drawing.Size(242, 21);
            this.txt_routeNumber.TabIndex = 328;
            // 
            // EditRouteInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(204)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(273, 291);
            this.ControlBox = false;
            this.Controls.Add(this.txt_routeNumber);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbo_trucks);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.cbo_drivers);
            this.Controls.Add(this.customLabel1);
            this.Name = "EditRouteInfo";
            this.Text = "Edit Route Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.CustomComboBox cbo_trucks;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomComboBox cbo_drivers;
        private Tools.CustomLabel customLabel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_routeNumber;
    }
}