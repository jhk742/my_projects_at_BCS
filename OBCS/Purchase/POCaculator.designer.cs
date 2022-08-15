namespace OBCS.Purchase
{
    partial class POCaculator
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
            this.dateTimePickerRec = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Export = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_TermPromoP = new System.Windows.Forms.CheckBox();
            this.chb_TermPromo = new System.Windows.Forms.CheckBox();
            this.chb_EDLPP = new System.Windows.Forms.CheckBox();
            this.chb_EDLP = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_SupTPromo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Conversion = new OBCS.CustomTextBox();
            this.txt_Unit = new OBCS.CustomTextBox();
            this.txt_PackSize = new OBCS.CustomTextBox();
            this.txt_SupplierProductID = new OBCS.CustomTextBox();
            this.cbo_ProductID = new OBCS.Tools.CustomComboBox();
            this.txt_Description = new OBCS.CustomTextBox();
            this.txt_PaymentType = new OBCS.CustomTextBox();
            this.txt_Supplier = new OBCS.CustomTextBox();
            this.txt_PONumber = new OBCS.CustomTextBox();
            this.txt_Difference = new OBCS.CustomTextBox();
            this.txt_SupplierInvoice = new OBCS.CustomTextBox();
            this.txt_RECNumber = new OBCS.CustomTextBox();
            this.txt_BCSInvoice = new OBCS.CustomTextBox();
            this.grid_POCalculator = new OBCS.CustomGrid();
            this.txt_SupEDLPP = new OBCS.CustomTextBox();
            this.txt_SupPrice = new OBCS.CustomTextBox();
            this.txt_SupTPromoP = new OBCS.CustomTextBox();
            this.txt_SupQty = new OBCS.CustomTextBox();
            this.customTextBox8 = new OBCS.CustomTextBox();
            this.txt_SupEDLP = new OBCS.CustomTextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_POCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerRec
            // 
            this.dateTimePickerRec.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRec.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerRec.Enabled = false;
            this.dateTimePickerRec.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerRec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRec.Location = new System.Drawing.Point(270, 67);
            this.dateTimePickerRec.Name = "dateTimePickerRec";
            this.dateTimePickerRec.Size = new System.Drawing.Size(122, 23);
            this.dateTimePickerRec.TabIndex = 694;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1365, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 688;
            this.label7.Text = "DIFF";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1343, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 689;
            this.label6.Text = "INVOICE";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1368, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 690;
            this.label5.Text = "BCS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 686;
            this.label4.Text = "REC NO.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 685;
            this.label3.Text = "REC DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 683;
            this.label2.Text = "PO NO.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 681;
            this.label1.Text = "SUPPLIER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 695;
            this.label8.Text = "PAYMENT";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.btn_Export);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_PaymentType);
            this.panel1.Controls.Add(this.txt_Supplier);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePickerRec);
            this.panel1.Controls.Add(this.txt_PONumber);
            this.panel1.Controls.Add(this.txt_Difference);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_SupplierInvoice);
            this.panel1.Controls.Add(this.txt_RECNumber);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_BCSInvoice);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1662, 102);
            this.panel1.TabIndex = 697;
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Export.FlatAppearance.BorderSize = 0;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Location = new System.Drawing.Point(1553, 15);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(92, 75);
            this.btn_Export.TabIndex = 720;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_Conversion);
            this.groupBox2.Controls.Add(this.txt_Unit);
            this.groupBox2.Controls.Add(this.txt_PackSize);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_SupplierProductID);
            this.groupBox2.Controls.Add(this.cbo_ProductID);
            this.groupBox2.Controls.Add(this.txt_Description);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(639, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 88);
            this.groupBox2.TabIndex = 698;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(459, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 15);
            this.label17.TabIndex = 719;
            this.label17.Text = "CONV";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(464, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 15);
            this.label16.TabIndex = 718;
            this.label16.Text = "UOM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(280, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 717;
            this.label15.Text = "PackSize";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 699;
            this.label9.Text = "Supplier Item ID";
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(577, 21);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(62, 58);
            this.btn_Add.TabIndex = 510;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_TermPromoP);
            this.groupBox1.Controls.Add(this.chb_TermPromo);
            this.groupBox1.Controls.Add(this.chb_EDLPP);
            this.groupBox1.Controls.Add(this.chb_EDLP);
            this.groupBox1.Location = new System.Drawing.Point(398, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 57);
            this.groupBox1.TabIndex = 697;
            this.groupBox1.TabStop = false;
            // 
            // chb_TermPromoP
            // 
            this.chb_TermPromoP.AutoSize = true;
            this.chb_TermPromoP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.chb_TermPromoP.Location = new System.Drawing.Point(110, 33);
            this.chb_TermPromoP.Name = "chb_TermPromoP";
            this.chb_TermPromoP.Size = new System.Drawing.Size(106, 19);
            this.chb_TermPromoP.TabIndex = 0;
            this.chb_TermPromoP.Text = "Term Promo %";
            this.chb_TermPromoP.UseVisualStyleBackColor = true;
            this.chb_TermPromoP.CheckedChanged += new System.EventHandler(this.chb_EDLP_CheckedChanged);
            // 
            // chb_TermPromo
            // 
            this.chb_TermPromo.AutoSize = true;
            this.chb_TermPromo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.chb_TermPromo.Location = new System.Drawing.Point(110, 10);
            this.chb_TermPromo.Name = "chb_TermPromo";
            this.chb_TermPromo.Size = new System.Drawing.Size(94, 19);
            this.chb_TermPromo.TabIndex = 0;
            this.chb_TermPromo.Text = "Term Promo";
            this.chb_TermPromo.UseVisualStyleBackColor = true;
            this.chb_TermPromo.CheckedChanged += new System.EventHandler(this.chb_EDLP_CheckedChanged);
            // 
            // chb_EDLPP
            // 
            this.chb_EDLPP.AutoSize = true;
            this.chb_EDLPP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.chb_EDLPP.Location = new System.Drawing.Point(22, 35);
            this.chb_EDLPP.Name = "chb_EDLPP";
            this.chb_EDLPP.Size = new System.Drawing.Size(65, 19);
            this.chb_EDLPP.TabIndex = 0;
            this.chb_EDLPP.Text = "EDLP %";
            this.chb_EDLPP.UseVisualStyleBackColor = true;
            this.chb_EDLPP.CheckedChanged += new System.EventHandler(this.chb_EDLP_CheckedChanged);
            // 
            // chb_EDLP
            // 
            this.chb_EDLP.AutoSize = true;
            this.chb_EDLP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.chb_EDLP.Location = new System.Drawing.Point(22, 10);
            this.chb_EDLP.Name = "chb_EDLP";
            this.chb_EDLP.Size = new System.Drawing.Size(53, 19);
            this.chb_EDLP.TabIndex = 0;
            this.chb_EDLP.Text = "EDLP";
            this.chb_EDLP.UseVisualStyleBackColor = true;
            this.chb_EDLP.CheckedChanged += new System.EventHandler(this.chb_EDLP_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1282, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 15);
            this.label14.TabIndex = 712;
            this.label14.Text = "TPromo%";
            this.label14.Visible = false;
            // 
            // txt_SupTPromo
            // 
            this.txt_SupTPromo.AutoSize = true;
            this.txt_SupTPromo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SupTPromo.Location = new System.Drawing.Point(1291, 138);
            this.txt_SupTPromo.Name = "txt_SupTPromo";
            this.txt_SupTPromo.Size = new System.Drawing.Size(50, 15);
            this.txt_SupTPromo.TabIndex = 710;
            this.txt_SupTPromo.Text = "TPromo";
            this.txt_SupTPromo.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1142, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 708;
            this.label12.Text = "EDLP%";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1151, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 706;
            this.label13.Text = "EDLP";
            this.label13.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1014, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 704;
            this.label11.Text = "Qty";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(880, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 702;
            this.label10.Text = "Price";
            this.label10.Visible = false;
            // 
            // txt_Conversion
            // 
            this.txt_Conversion.BackColor = System.Drawing.Color.White;
            this.txt_Conversion.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Conversion.Location = new System.Drawing.Point(505, 55);
            this.txt_Conversion.Name = "txt_Conversion";
            this.txt_Conversion.ReadOnly = true;
            this.txt_Conversion.Size = new System.Drawing.Size(64, 21);
            this.txt_Conversion.TabIndex = 716;
            this.txt_Conversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Unit
            // 
            this.txt_Unit.BackColor = System.Drawing.Color.White;
            this.txt_Unit.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Unit.Location = new System.Drawing.Point(505, 22);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.ReadOnly = true;
            this.txt_Unit.Size = new System.Drawing.Size(64, 21);
            this.txt_Unit.TabIndex = 715;
            this.txt_Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PackSize
            // 
            this.txt_PackSize.BackColor = System.Drawing.Color.White;
            this.txt_PackSize.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PackSize.Location = new System.Drawing.Point(338, 55);
            this.txt_PackSize.Name = "txt_PackSize";
            this.txt_PackSize.ReadOnly = true;
            this.txt_PackSize.Size = new System.Drawing.Size(116, 21);
            this.txt_PackSize.TabIndex = 714;
            this.txt_PackSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_SupplierProductID
            // 
            this.txt_SupplierProductID.BackColor = System.Drawing.Color.White;
            this.txt_SupplierProductID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SupplierProductID.Location = new System.Drawing.Point(108, 55);
            this.txt_SupplierProductID.Name = "txt_SupplierProductID";
            this.txt_SupplierProductID.Size = new System.Drawing.Size(166, 21);
            this.txt_SupplierProductID.TabIndex = 701;
            this.txt_SupplierProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_ProductID
            // 
            this.cbo_ProductID.BackColor = System.Drawing.Color.White;
            this.cbo_ProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ProductID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_ProductID.FormattingEnabled = true;
            this.cbo_ProductID.Location = new System.Drawing.Point(10, 22);
            this.cbo_ProductID.Name = "cbo_ProductID";
            this.cbo_ProductID.Size = new System.Drawing.Size(92, 23);
            this.cbo_ProductID.TabIndex = 700;
            this.cbo_ProductID.SelectedIndexChanged += new System.EventHandler(this.cbo_ProductID_SelectedIndexChanged);
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.Color.White;
            this.txt_Description.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Description.Location = new System.Drawing.Point(108, 22);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.Size = new System.Drawing.Size(346, 21);
            this.txt_Description.TabIndex = 699;
            this.txt_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PaymentType
            // 
            this.txt_PaymentType.BackColor = System.Drawing.Color.White;
            this.txt_PaymentType.Enabled = false;
            this.txt_PaymentType.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PaymentType.Location = new System.Drawing.Point(270, 40);
            this.txt_PaymentType.Name = "txt_PaymentType";
            this.txt_PaymentType.Size = new System.Drawing.Size(122, 21);
            this.txt_PaymentType.TabIndex = 696;
            this.txt_PaymentType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Supplier
            // 
            this.txt_Supplier.BackColor = System.Drawing.Color.White;
            this.txt_Supplier.Enabled = false;
            this.txt_Supplier.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Supplier.Location = new System.Drawing.Point(76, 13);
            this.txt_Supplier.Name = "txt_Supplier";
            this.txt_Supplier.Size = new System.Drawing.Size(316, 21);
            this.txt_Supplier.TabIndex = 682;
            this.txt_Supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_PONumber
            // 
            this.txt_PONumber.BackColor = System.Drawing.Color.White;
            this.txt_PONumber.Enabled = false;
            this.txt_PONumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PONumber.Location = new System.Drawing.Point(76, 41);
            this.txt_PONumber.Name = "txt_PONumber";
            this.txt_PONumber.Size = new System.Drawing.Size(122, 21);
            this.txt_PONumber.TabIndex = 684;
            this.txt_PONumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Difference
            // 
            this.txt_Difference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Difference.BackColor = System.Drawing.Color.White;
            this.txt_Difference.Enabled = false;
            this.txt_Difference.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Difference.Location = new System.Drawing.Point(1401, 68);
            this.txt_Difference.Name = "txt_Difference";
            this.txt_Difference.Size = new System.Drawing.Size(146, 21);
            this.txt_Difference.TabIndex = 691;
            this.txt_Difference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SupplierInvoice
            // 
            this.txt_SupplierInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SupplierInvoice.BackColor = System.Drawing.Color.White;
            this.txt_SupplierInvoice.Enabled = false;
            this.txt_SupplierInvoice.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SupplierInvoice.Location = new System.Drawing.Point(1401, 41);
            this.txt_SupplierInvoice.Name = "txt_SupplierInvoice";
            this.txt_SupplierInvoice.Size = new System.Drawing.Size(146, 21);
            this.txt_SupplierInvoice.TabIndex = 692;
            this.txt_SupplierInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_RECNumber
            // 
            this.txt_RECNumber.BackColor = System.Drawing.Color.White;
            this.txt_RECNumber.Enabled = false;
            this.txt_RECNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_RECNumber.Location = new System.Drawing.Point(76, 68);
            this.txt_RECNumber.Name = "txt_RECNumber";
            this.txt_RECNumber.Size = new System.Drawing.Size(122, 21);
            this.txt_RECNumber.TabIndex = 687;
            this.txt_RECNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_BCSInvoice
            // 
            this.txt_BCSInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BCSInvoice.BackColor = System.Drawing.Color.White;
            this.txt_BCSInvoice.Enabled = false;
            this.txt_BCSInvoice.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_BCSInvoice.Location = new System.Drawing.Point(1401, 14);
            this.txt_BCSInvoice.Name = "txt_BCSInvoice";
            this.txt_BCSInvoice.Size = new System.Drawing.Size(146, 21);
            this.txt_BCSInvoice.TabIndex = 693;
            this.txt_BCSInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.grid_POCalculator.Location = new System.Drawing.Point(12, 120);
            this.grid_POCalculator.MultiSelect = false;
            this.grid_POCalculator.Name = "grid_POCalculator";
            this.grid_POCalculator.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_POCalculator.RowHeadersVisible = false;
            this.grid_POCalculator.RowTemplate.Height = 19;
            this.grid_POCalculator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_POCalculator.Size = new System.Drawing.Size(1662, 607);
            this.grid_POCalculator.StandardTab = true;
            this.grid_POCalculator.TabIndex = 680;
            this.grid_POCalculator.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_POCalculator_CellClick);
            this.grid_POCalculator.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_POCalculator_CellEndEdit);
            this.grid_POCalculator.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_POCalculator_DataBindingComplete);
            this.grid_POCalculator.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grid_POCalculator_DataError);
            // 
            // txt_SupEDLPP
            // 
            this.txt_SupEDLPP.BackColor = System.Drawing.Color.White;
            this.txt_SupEDLPP.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SupEDLPP.Location = new System.Drawing.Point(1191, 171);
            this.txt_SupEDLPP.Name = "txt_SupEDLPP";
            this.txt_SupEDLPP.Size = new System.Drawing.Size(85, 21);
            this.txt_SupEDLPP.TabIndex = 709;
            this.txt_SupEDLPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SupEDLPP.Visible = false;
            this.txt_SupEDLPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // txt_SupPrice
            // 
            this.txt_SupPrice.BackColor = System.Drawing.Color.White;
            this.txt_SupPrice.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SupPrice.Location = new System.Drawing.Point(920, 171);
            this.txt_SupPrice.Name = "txt_SupPrice";
            this.txt_SupPrice.Size = new System.Drawing.Size(85, 21);
            this.txt_SupPrice.TabIndex = 703;
            this.txt_SupPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SupPrice.Visible = false;
            this.txt_SupPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // txt_SupTPromoP
            // 
            this.txt_SupTPromoP.BackColor = System.Drawing.Color.White;
            this.txt_SupTPromoP.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SupTPromoP.Location = new System.Drawing.Point(1347, 171);
            this.txt_SupTPromoP.Name = "txt_SupTPromoP";
            this.txt_SupTPromoP.Size = new System.Drawing.Size(85, 21);
            this.txt_SupTPromoP.TabIndex = 713;
            this.txt_SupTPromoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SupTPromoP.Visible = false;
            this.txt_SupTPromoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // txt_SupQty
            // 
            this.txt_SupQty.BackColor = System.Drawing.Color.White;
            this.txt_SupQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SupQty.Location = new System.Drawing.Point(1047, 171);
            this.txt_SupQty.Name = "txt_SupQty";
            this.txt_SupQty.Size = new System.Drawing.Size(85, 21);
            this.txt_SupQty.TabIndex = 705;
            this.txt_SupQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SupQty.Visible = false;
            this.txt_SupQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // customTextBox8
            // 
            this.customTextBox8.BackColor = System.Drawing.Color.White;
            this.customTextBox8.Font = new System.Drawing.Font("Arial", 9F);
            this.customTextBox8.Location = new System.Drawing.Point(1347, 135);
            this.customTextBox8.Name = "customTextBox8";
            this.customTextBox8.Size = new System.Drawing.Size(85, 21);
            this.customTextBox8.TabIndex = 711;
            this.customTextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.customTextBox8.Visible = false;
            this.customTextBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // txt_SupEDLP
            // 
            this.txt_SupEDLP.BackColor = System.Drawing.Color.White;
            this.txt_SupEDLP.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_SupEDLP.Location = new System.Drawing.Point(1191, 135);
            this.txt_SupEDLP.Name = "txt_SupEDLP";
            this.txt_SupEDLP.Size = new System.Drawing.Size(85, 21);
            this.txt_SupEDLP.TabIndex = 707;
            this.txt_SupEDLP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SupEDLP.Visible = false;
            this.txt_SupEDLP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // POCaculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_POCalculator);
            this.Controls.Add(this.txt_SupEDLPP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_SupPrice);
            this.Controls.Add(this.txt_SupTPromoP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_SupTPromo);
            this.Controls.Add(this.txt_SupQty);
            this.Controls.Add(this.customTextBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_SupEDLP);
            this.Controls.Add(this.label13);
            this.MinimumSize = new System.Drawing.Size(1650, 350);
            this.Name = "POCaculator";
            this.Text = "PO Caculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.POCaculator_FormClosed);
            this.Load += new System.EventHandler(this.POCaculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_POCalculator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerRec;
        private CustomTextBox txt_Difference;
        private System.Windows.Forms.Label label7;
        private CustomTextBox txt_SupplierInvoice;
        private System.Windows.Forms.Label label6;
        private CustomTextBox txt_BCSInvoice;
        private System.Windows.Forms.Label label5;
        private CustomTextBox txt_RECNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CustomTextBox txt_PONumber;
        private System.Windows.Forms.Label label2;
        private CustomTextBox txt_Supplier;
        private System.Windows.Forms.Label label1;
        private CustomGrid grid_POCalculator;
        private CustomTextBox txt_PaymentType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chb_EDLP;
        private System.Windows.Forms.CheckBox chb_TermPromoP;
        private System.Windows.Forms.CheckBox chb_TermPromo;
        private System.Windows.Forms.CheckBox chb_EDLPP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label14;
        private CustomTextBox txt_SupTPromoP;
        private System.Windows.Forms.Label txt_SupTPromo;
        private CustomTextBox customTextBox8;
        private System.Windows.Forms.Label label12;
        private CustomTextBox txt_SupEDLPP;
        private System.Windows.Forms.Label label13;
        private CustomTextBox txt_SupEDLP;
        private System.Windows.Forms.Label label11;
        private CustomTextBox txt_SupQty;
        private System.Windows.Forms.Label label10;
        private CustomTextBox txt_SupPrice;
        private System.Windows.Forms.Label label9;
        private CustomTextBox txt_SupplierProductID;
        private Tools.CustomComboBox cbo_ProductID;
        private CustomTextBox txt_Description;
        private CustomTextBox txt_Conversion;
        private CustomTextBox txt_Unit;
        private CustomTextBox txt_PackSize;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}