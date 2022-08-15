namespace OBCS.Sales
{
    partial class CashCheckCollection
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
            this.btn_apply = new System.Windows.Forms.Button();
            this.txt_date5 = new OBCS.CustomLargeMaskedTextBox();
            this.txt_check5 = new OBCS.CustomLargeTextBox();
            this.txt_amount5 = new OBCS.CustomLargeTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.txt_date4 = new OBCS.CustomLargeMaskedTextBox();
            this.txt_check4 = new OBCS.CustomLargeTextBox();
            this.txt_amount4 = new OBCS.CustomLargeTextBox();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_date3 = new OBCS.CustomLargeMaskedTextBox();
            this.txt_check3 = new OBCS.CustomLargeTextBox();
            this.txt_amount3 = new OBCS.CustomLargeTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_date2 = new OBCS.CustomLargeMaskedTextBox();
            this.txt_check2 = new OBCS.CustomLargeTextBox();
            this.txt_amount2 = new OBCS.CustomLargeTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_date1 = new OBCS.CustomLargeMaskedTextBox();
            this.txt_check1 = new OBCS.CustomLargeTextBox();
            this.txt_amount1 = new OBCS.CustomLargeTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_cash = new OBCS.CustomLargeTextBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_orderID = new OBCS.CustomTextBox();
            this.SuspendLayout();
            // 
            // btn_apply
            // 
            this.btn_apply.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.Location = new System.Drawing.Point(546, 12);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(212, 354);
            this.btn_apply.TabIndex = 16;
            this.btn_apply.Text = "APPLY";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // txt_date5
            // 
            this.txt_date5.BackColor = System.Drawing.Color.White;
            this.txt_date5.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_date5.Location = new System.Drawing.Point(15, 332);
            this.txt_date5.Mask = "00/00/0000";
            this.txt_date5.Name = "txt_date5";
            this.txt_date5.Size = new System.Drawing.Size(126, 34);
            this.txt_date5.TabIndex = 13;
            this.txt_date5.ValidatingType = typeof(System.DateTime);
            // 
            // txt_check5
            // 
            this.txt_check5.BackColor = System.Drawing.Color.White;
            this.txt_check5.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_check5.Location = new System.Drawing.Point(147, 332);
            this.txt_check5.Name = "txt_check5";
            this.txt_check5.Size = new System.Drawing.Size(253, 34);
            this.txt_check5.TabIndex = 14;
            // 
            // txt_amount5
            // 
            this.txt_amount5.BackColor = System.Drawing.Color.White;
            this.txt_amount5.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_amount5.Location = new System.Drawing.Point(406, 332);
            this.txt_amount5.Name = "txt_amount5";
            this.txt_amount5.Size = new System.Drawing.Size(134, 34);
            this.txt_amount5.TabIndex = 15;
            this.txt_amount5.Text = "$0.00";
            this.txt_amount5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(12, 311);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(298, 19);
            this.customLabel6.TabIndex = 362;
            this.customLabel6.Text = "CHECK #5 --> DATE | CHECK NO | AMOUNT";
            // 
            // txt_date4
            // 
            this.txt_date4.BackColor = System.Drawing.Color.White;
            this.txt_date4.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_date4.Location = new System.Drawing.Point(15, 274);
            this.txt_date4.Mask = "00/00/0000";
            this.txt_date4.Name = "txt_date4";
            this.txt_date4.Size = new System.Drawing.Size(126, 34);
            this.txt_date4.TabIndex = 10;
            this.txt_date4.ValidatingType = typeof(System.DateTime);
            // 
            // txt_check4
            // 
            this.txt_check4.BackColor = System.Drawing.Color.White;
            this.txt_check4.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_check4.Location = new System.Drawing.Point(147, 274);
            this.txt_check4.Name = "txt_check4";
            this.txt_check4.Size = new System.Drawing.Size(253, 34);
            this.txt_check4.TabIndex = 11;
            // 
            // txt_amount4
            // 
            this.txt_amount4.BackColor = System.Drawing.Color.White;
            this.txt_amount4.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_amount4.Location = new System.Drawing.Point(406, 274);
            this.txt_amount4.Name = "txt_amount4";
            this.txt_amount4.Size = new System.Drawing.Size(134, 34);
            this.txt_amount4.TabIndex = 12;
            this.txt_amount4.Text = "$0.00";
            this.txt_amount4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(12, 253);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(298, 19);
            this.customLabel5.TabIndex = 358;
            this.customLabel5.Text = "CHECK #4 --> DATE | CHECK NO | AMOUNT";
            // 
            // txt_date3
            // 
            this.txt_date3.BackColor = System.Drawing.Color.White;
            this.txt_date3.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_date3.Location = new System.Drawing.Point(15, 216);
            this.txt_date3.Mask = "00/00/0000";
            this.txt_date3.Name = "txt_date3";
            this.txt_date3.Size = new System.Drawing.Size(126, 34);
            this.txt_date3.TabIndex = 7;
            this.txt_date3.ValidatingType = typeof(System.DateTime);
            // 
            // txt_check3
            // 
            this.txt_check3.BackColor = System.Drawing.Color.White;
            this.txt_check3.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_check3.Location = new System.Drawing.Point(147, 216);
            this.txt_check3.Name = "txt_check3";
            this.txt_check3.Size = new System.Drawing.Size(253, 34);
            this.txt_check3.TabIndex = 8;
            // 
            // txt_amount3
            // 
            this.txt_amount3.BackColor = System.Drawing.Color.White;
            this.txt_amount3.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_amount3.Location = new System.Drawing.Point(406, 216);
            this.txt_amount3.Name = "txt_amount3";
            this.txt_amount3.Size = new System.Drawing.Size(134, 34);
            this.txt_amount3.TabIndex = 9;
            this.txt_amount3.Text = "$0.00";
            this.txt_amount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(12, 195);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(298, 19);
            this.customLabel3.TabIndex = 354;
            this.customLabel3.Text = "CHECK #3 --> DATE | CHECK NO | AMOUNT";
            // 
            // txt_date2
            // 
            this.txt_date2.BackColor = System.Drawing.Color.White;
            this.txt_date2.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_date2.Location = new System.Drawing.Point(15, 158);
            this.txt_date2.Mask = "00/00/0000";
            this.txt_date2.Name = "txt_date2";
            this.txt_date2.Size = new System.Drawing.Size(126, 34);
            this.txt_date2.TabIndex = 4;
            this.txt_date2.ValidatingType = typeof(System.DateTime);
            // 
            // txt_check2
            // 
            this.txt_check2.BackColor = System.Drawing.Color.White;
            this.txt_check2.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_check2.Location = new System.Drawing.Point(147, 158);
            this.txt_check2.Name = "txt_check2";
            this.txt_check2.Size = new System.Drawing.Size(253, 34);
            this.txt_check2.TabIndex = 5;
            // 
            // txt_amount2
            // 
            this.txt_amount2.BackColor = System.Drawing.Color.White;
            this.txt_amount2.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_amount2.Location = new System.Drawing.Point(406, 158);
            this.txt_amount2.Name = "txt_amount2";
            this.txt_amount2.Size = new System.Drawing.Size(134, 34);
            this.txt_amount2.TabIndex = 6;
            this.txt_amount2.Text = "$0.00";
            this.txt_amount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(12, 137);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(298, 19);
            this.customLabel2.TabIndex = 350;
            this.customLabel2.Text = "CHECK #2 --> DATE | CHECK NO | AMOUNT";
            // 
            // txt_date1
            // 
            this.txt_date1.BackColor = System.Drawing.Color.White;
            this.txt_date1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_date1.Location = new System.Drawing.Point(15, 100);
            this.txt_date1.Mask = "00/00/0000";
            this.txt_date1.Name = "txt_date1";
            this.txt_date1.Size = new System.Drawing.Size(126, 34);
            this.txt_date1.TabIndex = 1;
            this.txt_date1.ValidatingType = typeof(System.DateTime);
            // 
            // txt_check1
            // 
            this.txt_check1.BackColor = System.Drawing.Color.White;
            this.txt_check1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_check1.Location = new System.Drawing.Point(147, 100);
            this.txt_check1.Name = "txt_check1";
            this.txt_check1.Size = new System.Drawing.Size(253, 34);
            this.txt_check1.TabIndex = 2;
            // 
            // txt_amount1
            // 
            this.txt_amount1.BackColor = System.Drawing.Color.White;
            this.txt_amount1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_amount1.Location = new System.Drawing.Point(406, 100);
            this.txt_amount1.Name = "txt_amount1";
            this.txt_amount1.Size = new System.Drawing.Size(134, 34);
            this.txt_amount1.TabIndex = 3;
            this.txt_amount1.Text = "$0.00";
            this.txt_amount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(12, 79);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(298, 19);
            this.customLabel1.TabIndex = 340;
            this.customLabel1.Text = "CHECK #1 --> DATE | CHECK NO | AMOUNT";
            // 
            // txt_cash
            // 
            this.txt_cash.BackColor = System.Drawing.Color.White;
            this.txt_cash.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.txt_cash.Location = new System.Drawing.Point(12, 30);
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.Size = new System.Drawing.Size(528, 34);
            this.txt_cash.TabIndex = 0;
            this.txt_cash.Text = "$0.00";
            this.txt_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cash.Leave += new System.EventHandler(this.txt_cash_Leave);
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(252, 9);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(45, 19);
            this.customLabel4.TabIndex = 337;
            this.customLabel4.Text = "CASH";
            // 
            // txt_orderID
            // 
            this.txt_orderID.BackColor = System.Drawing.Color.White;
            this.txt_orderID.Enabled = false;
            this.txt_orderID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_orderID.Location = new System.Drawing.Point(12, 3);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(100, 21);
            this.txt_orderID.TabIndex = 363;
            // 
            // CashCheckCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 378);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.txt_date5);
            this.Controls.Add(this.txt_check5);
            this.Controls.Add(this.txt_amount5);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.txt_date4);
            this.Controls.Add(this.txt_check4);
            this.Controls.Add(this.txt_amount4);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.txt_date3);
            this.Controls.Add(this.txt_check3);
            this.Controls.Add(this.txt_amount3);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.txt_date2);
            this.Controls.Add(this.txt_check2);
            this.Controls.Add(this.txt_amount2);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_date1);
            this.Controls.Add(this.txt_check1);
            this.Controls.Add(this.txt_amount1);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_cash);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.customLabel4);
            this.Name = "CashCheckCollection";
            this.Text = "Cash & Check Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_apply;
        private Tools.CustomLabel customLabel4;
        private CustomLargeTextBox txt_cash;
        private CustomLargeTextBox txt_amount1;
        private Tools.CustomLabel customLabel1;
        private CustomLargeTextBox txt_check1;
        private CustomLargeMaskedTextBox txt_date1;
        private CustomLargeMaskedTextBox txt_date2;
        private CustomLargeTextBox txt_check2;
        private CustomLargeTextBox txt_amount2;
        private Tools.CustomLabel customLabel2;
        private CustomLargeMaskedTextBox txt_date3;
        private CustomLargeTextBox txt_check3;
        private CustomLargeTextBox txt_amount3;
        private Tools.CustomLabel customLabel3;
        private CustomLargeMaskedTextBox txt_date4;
        private CustomLargeTextBox txt_check4;
        private CustomLargeTextBox txt_amount4;
        private Tools.CustomLabel customLabel5;
        private CustomLargeMaskedTextBox txt_date5;
        private CustomLargeTextBox txt_check5;
        private CustomLargeTextBox txt_amount5;
        private Tools.CustomLabel customLabel6;
        private CustomTextBox txt_orderID;
    }
}