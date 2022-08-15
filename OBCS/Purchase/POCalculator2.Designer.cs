
namespace OBCS.Purchase
{
    partial class POCalculator2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_calculator = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbo_EDLP = new System.Windows.Forms.CheckBox();
            this.cbo_TermPromoP = new System.Windows.Forms.CheckBox();
            this.cbo_EDLPP = new System.Windows.Forms.CheckBox();
            this.cbo_TermPromo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_POCalculator = new OBCS.CustomGrid();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_Difference = new OBCS.CustomTextBox();
            this.dateTimePickerRec = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_SupplierInvoice = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_PaymentType = new OBCS.CustomTextBox();
            this.customLabel37 = new OBCS.Tools.CustomLabel();
            this.txt_BCSInvoice = new OBCS.CustomTextBox();
            this.txt_RECNumber = new OBCS.CustomTextBox();
            this.txt_Supplier = new OBCS.CustomTextBox();
            this.txt_PONumber = new OBCS.CustomTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_POCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btn_calculator);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.customLabel4);
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.txt_Difference);
            this.panel1.Controls.Add(this.dateTimePickerRec);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_SupplierInvoice);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_PaymentType);
            this.panel1.Controls.Add(this.customLabel37);
            this.panel1.Controls.Add(this.txt_BCSInvoice);
            this.panel1.Controls.Add(this.txt_RECNumber);
            this.panel1.Controls.Add(this.txt_Supplier);
            this.panel1.Controls.Add(this.txt_PONumber);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1695, 122);
            this.panel1.TabIndex = 698;
            // 
            // btn_calculator
            // 
            this.btn_calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_calculator.FlatAppearance.BorderSize = 0;
            this.btn_calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculator.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculator.ForeColor = System.Drawing.Color.White;
            this.btn_calculator.Location = new System.Drawing.Point(613, 76);
            this.btn_calculator.Name = "btn_calculator";
            this.btn_calculator.Size = new System.Drawing.Size(135, 37);
            this.btn_calculator.TabIndex = 726;
            this.btn_calculator.Text = "Export";
            this.btn_calculator.UseVisualStyleBackColor = false;
            this.btn_calculator.Click += new System.EventHandler(this.btn_calculator_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbo_EDLP);
            this.panel3.Controls.Add(this.cbo_TermPromoP);
            this.panel3.Controls.Add(this.cbo_EDLPP);
            this.panel3.Controls.Add(this.cbo_TermPromo);
            this.panel3.Location = new System.Drawing.Point(254, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 102);
            this.panel3.TabIndex = 705;
            // 
            // cbo_EDLP
            // 
            this.cbo_EDLP.AutoSize = true;
            this.cbo_EDLP.Checked = true;
            this.cbo_EDLP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbo_EDLP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_EDLP.Location = new System.Drawing.Point(17, 3);
            this.cbo_EDLP.Name = "cbo_EDLP";
            this.cbo_EDLP.Size = new System.Drawing.Size(52, 19);
            this.cbo_EDLP.TabIndex = 0;
            this.cbo_EDLP.Text = "EDLP";
            this.cbo_EDLP.UseVisualStyleBackColor = true;
            this.cbo_EDLP.CheckedChanged += new System.EventHandler(this.cbo_CheckedChanged);
            // 
            // cbo_TermPromoP
            // 
            this.cbo_TermPromoP.AutoSize = true;
            this.cbo_TermPromoP.Checked = true;
            this.cbo_TermPromoP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbo_TermPromoP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TermPromoP.Location = new System.Drawing.Point(17, 78);
            this.cbo_TermPromoP.Name = "cbo_TermPromoP";
            this.cbo_TermPromoP.Size = new System.Drawing.Size(103, 19);
            this.cbo_TermPromoP.TabIndex = 0;
            this.cbo_TermPromoP.Text = "Term Promo %";
            this.cbo_TermPromoP.UseVisualStyleBackColor = true;
            this.cbo_TermPromoP.CheckedChanged += new System.EventHandler(this.cbo_CheckedChanged);
            // 
            // cbo_EDLPP
            // 
            this.cbo_EDLPP.AutoSize = true;
            this.cbo_EDLPP.Checked = true;
            this.cbo_EDLPP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbo_EDLPP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_EDLPP.Location = new System.Drawing.Point(17, 28);
            this.cbo_EDLPP.Name = "cbo_EDLPP";
            this.cbo_EDLPP.Size = new System.Drawing.Size(64, 19);
            this.cbo_EDLPP.TabIndex = 0;
            this.cbo_EDLPP.Text = "EDLP %";
            this.cbo_EDLPP.UseVisualStyleBackColor = true;
            this.cbo_EDLPP.CheckedChanged += new System.EventHandler(this.cbo_CheckedChanged);
            // 
            // cbo_TermPromo
            // 
            this.cbo_TermPromo.AutoSize = true;
            this.cbo_TermPromo.Checked = true;
            this.cbo_TermPromo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbo_TermPromo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TermPromo.Location = new System.Drawing.Point(17, 53);
            this.cbo_TermPromo.Name = "cbo_TermPromo";
            this.cbo_TermPromo.Size = new System.Drawing.Size(91, 19);
            this.cbo_TermPromo.TabIndex = 0;
            this.cbo_TermPromo.Text = "Term Promo";
            this.cbo_TermPromo.UseVisualStyleBackColor = true;
            this.cbo_TermPromo.CheckedChanged += new System.EventHandler(this.cbo_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(431, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 688;
            this.label7.Text = "Difference";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 689;
            this.label6.Text = "Supplier Invoice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(467, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 690;
            this.label5.Text = "BCS";
            // 
            // grid_POCalculator
            // 
            this.grid_POCalculator.AllowUserToAddRows = false;
            this.grid_POCalculator.AllowUserToDeleteRows = false;
            this.grid_POCalculator.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_POCalculator.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_POCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_POCalculator.BackgroundColor = System.Drawing.Color.White;
            this.grid_POCalculator.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_POCalculator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_POCalculator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_POCalculator.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_POCalculator.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_POCalculator.EnableHeadersVisualStyles = false;
            this.grid_POCalculator.GridColor = System.Drawing.Color.LightGray;
            this.grid_POCalculator.Location = new System.Drawing.Point(12, 140);
            this.grid_POCalculator.MultiSelect = false;
            this.grid_POCalculator.Name = "grid_POCalculator";
            this.grid_POCalculator.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_POCalculator.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_POCalculator.RowHeadersVisible = false;
            this.grid_POCalculator.RowTemplate.Height = 19;
            this.grid_POCalculator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_POCalculator.Size = new System.Drawing.Size(1695, 781);
            this.grid_POCalculator.StandardTab = true;
            this.grid_POCalculator.TabIndex = 699;
            this.grid_POCalculator.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_POCalculator_CellEndEdit);
            this.grid_POCalculator.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_POCalculator_DataBindingComplete);
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(36, 96);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(75, 15);
            this.customLabel4.TabIndex = 725;
            this.customLabel4.Text = "Receipt Date";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(796, 92);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(54, 15);
            this.customLabel3.TabIndex = 724;
            this.customLabel3.Text = "Payment";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel3.Visible = false;
            // 
            // txt_Difference
            // 
            this.txt_Difference.BackColor = System.Drawing.Color.White;
            this.txt_Difference.Enabled = false;
            this.txt_Difference.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Difference.Location = new System.Drawing.Point(501, 92);
            this.txt_Difference.Name = "txt_Difference";
            this.txt_Difference.Size = new System.Drawing.Size(106, 21);
            this.txt_Difference.TabIndex = 691;
            this.txt_Difference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePickerRec
            // 
            this.dateTimePickerRec.BackColor = System.Drawing.Color.White;
            this.dateTimePickerRec.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerRec.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerRec.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerRec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRec.Location = new System.Drawing.Point(117, 92);
            this.dateTimePickerRec.Name = "dateTimePickerRec";
            this.dateTimePickerRec.Size = new System.Drawing.Size(96, 21);
            this.dateTimePickerRec.TabIndex = 721;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(6, 68);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(105, 15);
            this.customLabel2.TabIndex = 723;
            this.customLabel2.Text = "Receiving Number";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SupplierInvoice
            // 
            this.txt_SupplierInvoice.BackColor = System.Drawing.Color.White;
            this.txt_SupplierInvoice.Enabled = false;
            this.txt_SupplierInvoice.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SupplierInvoice.Location = new System.Drawing.Point(501, 65);
            this.txt_SupplierInvoice.Name = "txt_SupplierInvoice";
            this.txt_SupplierInvoice.Size = new System.Drawing.Size(106, 21);
            this.txt_SupplierInvoice.TabIndex = 692;
            this.txt_SupplierInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(42, 41);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(69, 15);
            this.customLabel1.TabIndex = 722;
            this.customLabel1.Text = "PO Number";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_PaymentType
            // 
            this.txt_PaymentType.BackColor = System.Drawing.Color.White;
            this.txt_PaymentType.Enabled = false;
            this.txt_PaymentType.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PaymentType.Location = new System.Drawing.Point(856, 88);
            this.txt_PaymentType.Name = "txt_PaymentType";
            this.txt_PaymentType.Size = new System.Drawing.Size(96, 21);
            this.txt_PaymentType.TabIndex = 696;
            this.txt_PaymentType.Visible = false;
            // 
            // customLabel37
            // 
            this.customLabel37.AutoSize = true;
            this.customLabel37.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel37.Location = new System.Drawing.Point(43, 14);
            this.customLabel37.Name = "customLabel37";
            this.customLabel37.Size = new System.Drawing.Size(68, 15);
            this.customLabel37.TabIndex = 705;
            this.customLabel37.Text = "Supplier ID";
            this.customLabel37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_BCSInvoice
            // 
            this.txt_BCSInvoice.BackColor = System.Drawing.Color.White;
            this.txt_BCSInvoice.Enabled = false;
            this.txt_BCSInvoice.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_BCSInvoice.Location = new System.Drawing.Point(501, 38);
            this.txt_BCSInvoice.Name = "txt_BCSInvoice";
            this.txt_BCSInvoice.Size = new System.Drawing.Size(106, 21);
            this.txt_BCSInvoice.TabIndex = 693;
            this.txt_BCSInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_RECNumber
            // 
            this.txt_RECNumber.BackColor = System.Drawing.Color.White;
            this.txt_RECNumber.Enabled = false;
            this.txt_RECNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_RECNumber.Location = new System.Drawing.Point(117, 65);
            this.txt_RECNumber.Name = "txt_RECNumber";
            this.txt_RECNumber.Size = new System.Drawing.Size(85, 21);
            this.txt_RECNumber.TabIndex = 687;
            // 
            // txt_Supplier
            // 
            this.txt_Supplier.BackColor = System.Drawing.Color.White;
            this.txt_Supplier.Enabled = false;
            this.txt_Supplier.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Supplier.Location = new System.Drawing.Point(117, 11);
            this.txt_Supplier.Name = "txt_Supplier";
            this.txt_Supplier.Size = new System.Drawing.Size(131, 21);
            this.txt_Supplier.TabIndex = 682;
            // 
            // txt_PONumber
            // 
            this.txt_PONumber.BackColor = System.Drawing.Color.White;
            this.txt_PONumber.Enabled = false;
            this.txt_PONumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PONumber.Location = new System.Drawing.Point(117, 38);
            this.txt_PONumber.Name = "txt_PONumber";
            this.txt_PONumber.Size = new System.Drawing.Size(85, 21);
            this.txt_PONumber.TabIndex = 684;
            // 
            // POCalculator2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 933);
            this.Controls.Add(this.grid_POCalculator);
            this.Controls.Add(this.panel1);
            this.Name = "POCalculator2";
            this.Text = "POCalculator2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.POCalculator2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_POCalculator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbo_TermPromoP;
        private System.Windows.Forms.CheckBox cbo_TermPromo;
        private System.Windows.Forms.CheckBox cbo_EDLPP;
        private System.Windows.Forms.CheckBox cbo_EDLP;
        private CustomTextBox txt_PaymentType;
        private CustomTextBox txt_Supplier;
        private CustomTextBox txt_PONumber;
        private CustomTextBox txt_Difference;
        private System.Windows.Forms.Label label7;
        private CustomTextBox txt_SupplierInvoice;
        private CustomTextBox txt_RECNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CustomTextBox txt_BCSInvoice;
        private CustomDateTimePicker dateTimePickerRec;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel2;
        private Tools.CustomLabel customLabel1;
        private Tools.CustomLabel customLabel37;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_calculator;
        private CustomGrid grid_POCalculator;
    }
}