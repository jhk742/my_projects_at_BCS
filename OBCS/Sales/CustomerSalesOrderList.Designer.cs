namespace OBCS.Sales
{
    partial class CustomerSalesOrderList
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
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_PrintOrder = new System.Windows.Forms.Button();
            this.btn_PrintOrderForAllocation = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.item_profile = new System.Windows.Forms.TabPage();
            this.item_onhand = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.customTextBox1 = new OBCS.CustomTextBox();
            this.customComboBox1 = new OBCS.Tools.CustomComboBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.tabControl1.SuspendLayout();
            this.item_onhand.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(12, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(104, 30);
            this.btn_new.TabIndex = 76;
            this.btn_new.Text = "+";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(122, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(104, 30);
            this.btn_cancel.TabIndex = 77;
            this.btn_cancel.Text = "-";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_PrintOrder
            // 
            this.btn_PrintOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintOrder.Location = new System.Drawing.Point(232, 12);
            this.btn_PrintOrder.Name = "btn_PrintOrder";
            this.btn_PrintOrder.Size = new System.Drawing.Size(104, 30);
            this.btn_PrintOrder.TabIndex = 78;
            this.btn_PrintOrder.Text = "Print Order";
            this.btn_PrintOrder.UseVisualStyleBackColor = true;
            // 
            // btn_PrintOrderForAllocation
            // 
            this.btn_PrintOrderForAllocation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintOrderForAllocation.Location = new System.Drawing.Point(342, 12);
            this.btn_PrintOrderForAllocation.Name = "btn_PrintOrderForAllocation";
            this.btn_PrintOrderForAllocation.Size = new System.Drawing.Size(104, 30);
            this.btn_PrintOrderForAllocation.TabIndex = 79;
            this.btn_PrintOrderForAllocation.Text = "Print Order for Allocation";
            this.btn_PrintOrderForAllocation.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.item_profile);
            this.tabControl1.Controls.Add(this.item_onhand);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 569);
            this.tabControl1.TabIndex = 80;
            // 
            // item_profile
            // 
            this.item_profile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_profile.Location = new System.Drawing.Point(4, 25);
            this.item_profile.Name = "item_profile";
            this.item_profile.Padding = new System.Windows.Forms.Padding(3);
            this.item_profile.Size = new System.Drawing.Size(904, 540);
            this.item_profile.TabIndex = 1;
            this.item_profile.Text = "Customer OrderList";
            this.item_profile.UseVisualStyleBackColor = true;
            this.item_profile.Click += new System.EventHandler(this.item_profile_Click);
            // 
            // item_onhand
            // 
            this.item_onhand.Controls.Add(this.customLabel1);
            this.item_onhand.Controls.Add(this.customComboBox1);
            this.item_onhand.Controls.Add(this.customTextBox1);
            this.item_onhand.Controls.Add(this.textBox1);
            this.item_onhand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_onhand.Location = new System.Drawing.Point(4, 25);
            this.item_onhand.Name = "item_onhand";
            this.item_onhand.Padding = new System.Windows.Forms.Padding(3);
            this.item_onhand.Size = new System.Drawing.Size(904, 540);
            this.item_onhand.TabIndex = 0;
            this.item_onhand.Text = "Not Innvoiced Orders";
            this.item_onhand.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.OldLace;
            this.customTextBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.customTextBox1.Location = new System.Drawing.Point(106, 169);
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(100, 21);
            this.customTextBox1.TabIndex = 1;
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.OldLace;
            this.customComboBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.customComboBox1.FormattingEnabled = true;
            this.customComboBox1.Location = new System.Drawing.Point(106, 29);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(121, 23);
            this.customComboBox1.TabIndex = 2;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.Location = new System.Drawing.Point(7, 35);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(105, 16);
            this.customLabel1.TabIndex = 3;
            this.customLabel1.Text = "customLabel1";
            // 
            // CustomerSalesOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 640);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_PrintOrderForAllocation);
            this.Controls.Add(this.btn_PrintOrder);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_new);
            this.Name = "CustomerSalesOrderList";
            this.Text = "CustomerSalesOrderList";
            this.tabControl1.ResumeLayout(false);
            this.item_onhand.ResumeLayout(false);
            this.item_onhand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_PrintOrder;
        private System.Windows.Forms.Button btn_PrintOrderForAllocation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage item_profile;
        private System.Windows.Forms.TabPage item_onhand;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomComboBox customComboBox1;
        private CustomTextBox customTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}