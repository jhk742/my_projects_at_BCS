namespace OBCS.mWMS
{
    partial class wms_intersiteTransfersOrderItemDetail
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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_fromSite = new OBCS.CustomTextBox();
            this.txt_BCSStockR = new OBCS.CustomTextBox();
            this.txt_BCSStockQ = new OBCS.CustomTextBox();
            this.cbo_status = new OBCS.Tools.CustomComboBox();
            this.txt_WH2StockR = new OBCS.CustomTextBox();
            this.txt_WH2StockQ = new OBCS.CustomTextBox();
            this.txt_salesUnit = new OBCS.CustomTextBox();
            this.txt_WH2StockA = new OBCS.CustomTextBox();
            this.txt_qty = new OBCS.CustomTextBox();
            this.txt_productID = new OBCS.CustomTextBox();
            this.txt_onhand = new OBCS.CustomTextBox();
            this.txt_basePrice = new OBCS.CustomTextBox();
            this.txt_packSize = new OBCS.CustomTextBox();
            this.txt_productDesc = new OBCS.CustomTextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 372;
            this.label7.Text = "Onhand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 362;
            this.label5.Text = "Base Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 356;
            this.label1.Text = "Pack Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 377;
            this.label8.Text = "Qty.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 380;
            this.label2.Text = "Product ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 381;
            this.label6.Text = "Description";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(437, 214);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(186, 49);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(245, 214);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(186, 49);
            this.btn_cancel.TabIndex = 384;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 386;
            this.label3.Text = "WH2 Stock A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 388;
            this.label4.Text = "Sales Unit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 390;
            this.label9.Text = "WH2 Stock Q";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(238, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 392;
            this.label10.Text = "WH2 Stock R";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 396;
            this.label11.Text = "BCS Stock Q";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 398;
            this.label12.Text = "BCS Stock R";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(477, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 400;
            this.label13.Text = "From Site";
            // 
            // txt_fromSite
            // 
            this.txt_fromSite.BackColor = System.Drawing.Color.White;
            this.txt_fromSite.Enabled = false;
            this.txt_fromSite.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_fromSite.Location = new System.Drawing.Point(541, 9);
            this.txt_fromSite.Name = "txt_fromSite";
            this.txt_fromSite.Size = new System.Drawing.Size(82, 21);
            this.txt_fromSite.TabIndex = 399;
            this.txt_fromSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_BCSStockR
            // 
            this.txt_BCSStockR.BackColor = System.Drawing.Color.White;
            this.txt_BCSStockR.Enabled = false;
            this.txt_BCSStockR.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_BCSStockR.Location = new System.Drawing.Point(122, 147);
            this.txt_BCSStockR.Name = "txt_BCSStockR";
            this.txt_BCSStockR.Size = new System.Drawing.Size(82, 21);
            this.txt_BCSStockR.TabIndex = 397;
            this.txt_BCSStockR.Text = "1234.00";
            this.txt_BCSStockR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_BCSStockQ
            // 
            this.txt_BCSStockQ.BackColor = System.Drawing.Color.White;
            this.txt_BCSStockQ.Enabled = false;
            this.txt_BCSStockQ.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_BCSStockQ.Location = new System.Drawing.Point(122, 120);
            this.txt_BCSStockQ.Name = "txt_BCSStockQ";
            this.txt_BCSStockQ.Size = new System.Drawing.Size(82, 21);
            this.txt_BCSStockQ.TabIndex = 395;
            this.txt_BCSStockQ.Text = "1234.00";
            this.txt_BCSStockQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_status
            // 
            this.cbo_status.BackColor = System.Drawing.Color.White;
            this.cbo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_status.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_status.FormattingEnabled = true;
            this.cbo_status.Location = new System.Drawing.Point(441, 119);
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Size = new System.Drawing.Size(36, 23);
            this.cbo_status.TabIndex = 393;
            // 
            // txt_WH2StockR
            // 
            this.txt_WH2StockR.BackColor = System.Drawing.Color.White;
            this.txt_WH2StockR.Enabled = false;
            this.txt_WH2StockR.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_WH2StockR.Location = new System.Drawing.Point(320, 147);
            this.txt_WH2StockR.Name = "txt_WH2StockR";
            this.txt_WH2StockR.Size = new System.Drawing.Size(82, 21);
            this.txt_WH2StockR.TabIndex = 391;
            this.txt_WH2StockR.Text = "1234.00";
            this.txt_WH2StockR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_WH2StockQ
            // 
            this.txt_WH2StockQ.BackColor = System.Drawing.Color.White;
            this.txt_WH2StockQ.Enabled = false;
            this.txt_WH2StockQ.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_WH2StockQ.Location = new System.Drawing.Point(320, 120);
            this.txt_WH2StockQ.Name = "txt_WH2StockQ";
            this.txt_WH2StockQ.Size = new System.Drawing.Size(82, 21);
            this.txt_WH2StockQ.TabIndex = 389;
            this.txt_WH2StockQ.Text = "1234.00";
            this.txt_WH2StockQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_salesUnit
            // 
            this.txt_salesUnit.BackColor = System.Drawing.Color.White;
            this.txt_salesUnit.Enabled = false;
            this.txt_salesUnit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_salesUnit.Location = new System.Drawing.Point(281, 66);
            this.txt_salesUnit.Name = "txt_salesUnit";
            this.txt_salesUnit.Size = new System.Drawing.Size(51, 21);
            this.txt_salesUnit.TabIndex = 387;
            this.txt_salesUnit.Text = "BX";
            // 
            // txt_WH2StockA
            // 
            this.txt_WH2StockA.BackColor = System.Drawing.Color.White;
            this.txt_WH2StockA.Enabled = false;
            this.txt_WH2StockA.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_WH2StockA.Location = new System.Drawing.Point(320, 93);
            this.txt_WH2StockA.Name = "txt_WH2StockA";
            this.txt_WH2StockA.Size = new System.Drawing.Size(82, 21);
            this.txt_WH2StockA.TabIndex = 385;
            this.txt_WH2StockA.Text = "1234.00";
            this.txt_WH2StockA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.White;
            this.txt_qty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_qty.Location = new System.Drawing.Point(517, 120);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(82, 21);
            this.txt_qty.TabIndex = 0;
            this.txt_qty.Text = "1";
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_KeyPress);
            // 
            // txt_productID
            // 
            this.txt_productID.BackColor = System.Drawing.Color.White;
            this.txt_productID.Enabled = false;
            this.txt_productID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_productID.Location = new System.Drawing.Point(85, 12);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(119, 21);
            this.txt_productID.TabIndex = 375;
            this.txt_productID.Text = "10ALM05";
            // 
            // txt_onhand
            // 
            this.txt_onhand.BackColor = System.Drawing.Color.White;
            this.txt_onhand.Enabled = false;
            this.txt_onhand.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_onhand.Location = new System.Drawing.Point(122, 93);
            this.txt_onhand.Name = "txt_onhand";
            this.txt_onhand.Size = new System.Drawing.Size(82, 21);
            this.txt_onhand.TabIndex = 371;
            this.txt_onhand.Text = "1234.00";
            this.txt_onhand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_basePrice
            // 
            this.txt_basePrice.BackColor = System.Drawing.Color.White;
            this.txt_basePrice.Enabled = false;
            this.txt_basePrice.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_basePrice.Location = new System.Drawing.Point(411, 66);
            this.txt_basePrice.Name = "txt_basePrice";
            this.txt_basePrice.Size = new System.Drawing.Size(82, 21);
            this.txt_basePrice.TabIndex = 361;
            this.txt_basePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_packSize
            // 
            this.txt_packSize.BackColor = System.Drawing.Color.White;
            this.txt_packSize.Enabled = false;
            this.txt_packSize.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_packSize.Location = new System.Drawing.Point(85, 66);
            this.txt_packSize.Name = "txt_packSize";
            this.txt_packSize.Size = new System.Drawing.Size(119, 21);
            this.txt_packSize.TabIndex = 355;
            this.txt_packSize.Text = "1/10.00LB";
            // 
            // txt_productDesc
            // 
            this.txt_productDesc.BackColor = System.Drawing.Color.White;
            this.txt_productDesc.Enabled = false;
            this.txt_productDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_productDesc.Location = new System.Drawing.Point(85, 39);
            this.txt_productDesc.Name = "txt_productDesc";
            this.txt_productDesc.Size = new System.Drawing.Size(537, 21);
            this.txt_productDesc.TabIndex = 354;
            this.txt_productDesc.Text = "Almond Blanched Whole";
            // 
            // wms_intersiteTransfersOrderItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 275);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_fromSite);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_BCSStockR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_BCSStockQ);
            this.Controls.Add(this.cbo_status);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_WH2StockR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_WH2StockQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_salesUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_WH2StockA);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_onhand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_basePrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_packSize);
            this.Controls.Add(this.txt_productDesc);
            this.Name = "wms_intersiteTransfersOrderItemDetail";
            this.Text = "Item Detail";
            this.Load += new System.EventHandler(this.ManualOrderItemDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Reports.BulkNutLabelList bulkNutLabelList1;
        private System.Windows.Forms.Label label7;
        private CustomTextBox txt_onhand;
        private System.Windows.Forms.Label label5;
        private CustomTextBox txt_basePrice;
        private System.Windows.Forms.Label label1;
        private CustomTextBox txt_productDesc;
        private System.Windows.Forms.Label label8;
        private CustomTextBox txt_qty;
        private CustomTextBox txt_productID;
        private CustomTextBox txt_packSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
        private CustomTextBox txt_WH2StockA;
        private System.Windows.Forms.Label label4;
        private CustomTextBox txt_salesUnit;
        private System.Windows.Forms.Label label9;
        private CustomTextBox txt_WH2StockQ;
        private System.Windows.Forms.Label label10;
        private CustomTextBox txt_WH2StockR;
        private Tools.CustomComboBox cbo_status;
        private System.Windows.Forms.Label label11;
        private CustomTextBox txt_BCSStockQ;
        private System.Windows.Forms.Label label12;
        private CustomTextBox txt_BCSStockR;
        private System.Windows.Forms.Label label13;
        private CustomTextBox txt_fromSite;
    }
}