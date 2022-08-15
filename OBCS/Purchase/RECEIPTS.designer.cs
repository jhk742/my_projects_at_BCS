namespace OBCS.Purchase
{
    partial class RECEIPTS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabReceipt = new System.Windows.Forms.TabPage();
            this.txt_PRSPOID = new OBCS.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PRSMemo = new OBCS.CustomTextBox();
            this.cbo_PRSSite = new OBCS.Tools.CustomComboBox();
            this.txt_PRSSupplier = new OBCS.CustomTextBox();
            this.txt_PRSRECID = new OBCS.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grid_receipt = new OBCS.CustomGrid();
            this.tabWIP = new System.Windows.Forms.TabPage();
            this.cbo_POSSite = new OBCS.Tools.CustomComboBox();
            this.txt_POSMemo = new OBCS.CustomTextBox();
            this.txt_POSSupplier = new OBCS.CustomTextBox();
            this.txt_POSPOID = new OBCS.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_selectionHeader = new OBCS.CustomGrid();
            this.dateTimePickerReceipt = new System.Windows.Forms.DateTimePicker();
            this.btn_create = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.customLabel22 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerRequire = new System.Windows.Forms.DateTimePicker();
            this.LabelRequireDate = new OBCS.Tools.CustomLabel();
            this.customLabel15 = new OBCS.Tools.CustomLabel();
            this.txt_supplierName = new OBCS.CustomTextBox();
            this.customLabel17 = new OBCS.Tools.CustomLabel();
            this.customLabel13 = new OBCS.Tools.CustomLabel();
            this.txt_totalPOQty = new OBCS.CustomTextBox();
            this.txt_totalPOAmount = new OBCS.CustomTextBox();
            this.txt_totalQty = new OBCS.CustomTextBox();
            this.customLabel16 = new OBCS.Tools.CustomLabel();
            this.txt_totalAmount = new OBCS.CustomTextBox();
            this.customLabel14 = new OBCS.Tools.CustomLabel();
            this.btn_print = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_poNumber = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_receivingSite = new OBCS.CustomTextBox();
            this.txt_memo = new OBCS.CustomTextBox();
            this.txt_receiptNumber = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_supplierID = new OBCS.CustomTextBox();
            this.cbo_site = new OBCS.Tools.CustomComboBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.customLabel19 = new OBCS.Tools.CustomLabel();
            this.customLabel18 = new OBCS.Tools.CustomLabel();
            this.customLabel20 = new OBCS.Tools.CustomLabel();
            this.txt_totalDiffQty = new OBCS.CustomTextBox();
            this.txt_totalDiffAmount = new OBCS.CustomTextBox();
            this.customLabel21 = new OBCS.Tools.CustomLabel();
            this.grid_detail = new OBCS.CustomGrid();
            this.tabControl1.SuspendLayout();
            this.tabReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_receipt)).BeginInit();
            this.tabWIP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_selectionHeader)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabReceipt);
            this.tabControl1.Controls.Add(this.tabWIP);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 837);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabReceipt
            // 
            this.tabReceipt.Controls.Add(this.txt_PRSPOID);
            this.tabReceipt.Controls.Add(this.label6);
            this.tabReceipt.Controls.Add(this.txt_PRSMemo);
            this.tabReceipt.Controls.Add(this.cbo_PRSSite);
            this.tabReceipt.Controls.Add(this.txt_PRSSupplier);
            this.tabReceipt.Controls.Add(this.txt_PRSRECID);
            this.tabReceipt.Controls.Add(this.label9);
            this.tabReceipt.Controls.Add(this.label1);
            this.tabReceipt.Controls.Add(this.label10);
            this.tabReceipt.Controls.Add(this.label11);
            this.tabReceipt.Controls.Add(this.grid_receipt);
            this.tabReceipt.Location = new System.Drawing.Point(4, 27);
            this.tabReceipt.Name = "tabReceipt";
            this.tabReceipt.Padding = new System.Windows.Forms.Padding(3);
            this.tabReceipt.Size = new System.Drawing.Size(489, 806);
            this.tabReceipt.TabIndex = 0;
            this.tabReceipt.Text = "Purchase Receipts";
            this.tabReceipt.UseVisualStyleBackColor = true;
            // 
            // txt_PRSPOID
            // 
            this.txt_PRSPOID.BackColor = System.Drawing.Color.White;
            this.txt_PRSPOID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PRSPOID.Location = new System.Drawing.Point(6, 21);
            this.txt_PRSPOID.Name = "txt_PRSPOID";
            this.txt_PRSPOID.Size = new System.Drawing.Size(69, 21);
            this.txt_PRSPOID.TabIndex = 465;
            this.txt_PRSPOID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchREC);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 464;
            this.label6.Text = "PO Number";
            // 
            // txt_PRSMemo
            // 
            this.txt_PRSMemo.BackColor = System.Drawing.Color.White;
            this.txt_PRSMemo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PRSMemo.Location = new System.Drawing.Point(331, 21);
            this.txt_PRSMemo.Name = "txt_PRSMemo";
            this.txt_PRSMemo.Size = new System.Drawing.Size(153, 21);
            this.txt_PRSMemo.TabIndex = 463;
            this.txt_PRSMemo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchREC);
            // 
            // cbo_PRSSite
            // 
            this.cbo_PRSSite.BackColor = System.Drawing.Color.White;
            this.cbo_PRSSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PRSSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_PRSSite.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_PRSSite.FormattingEnabled = true;
            this.cbo_PRSSite.Location = new System.Drawing.Point(269, 19);
            this.cbo_PRSSite.Name = "cbo_PRSSite";
            this.cbo_PRSSite.Size = new System.Drawing.Size(56, 23);
            this.cbo_PRSSite.TabIndex = 461;
            this.cbo_PRSSite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchREC);
            // 
            // txt_PRSSupplier
            // 
            this.txt_PRSSupplier.BackColor = System.Drawing.Color.White;
            this.txt_PRSSupplier.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PRSSupplier.Location = new System.Drawing.Point(177, 21);
            this.txt_PRSSupplier.Name = "txt_PRSSupplier";
            this.txt_PRSSupplier.Size = new System.Drawing.Size(86, 21);
            this.txt_PRSSupplier.TabIndex = 462;
            this.txt_PRSSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchREC);
            // 
            // txt_PRSRECID
            // 
            this.txt_PRSRECID.BackColor = System.Drawing.Color.White;
            this.txt_PRSRECID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_PRSRECID.Location = new System.Drawing.Point(81, 21);
            this.txt_PRSRECID.Name = "txt_PRSRECID";
            this.txt_PRSRECID.Size = new System.Drawing.Size(90, 21);
            this.txt_PRSRECID.TabIndex = 461;
            this.txt_PRSRECID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchREC);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Memo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Site";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Supplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Receipt Number";
            // 
            // grid_receipt
            // 
            this.grid_receipt.AllowUserToAddRows = false;
            this.grid_receipt.AllowUserToDeleteRows = false;
            this.grid_receipt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_receipt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_receipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_receipt.BackgroundColor = System.Drawing.Color.White;
            this.grid_receipt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_receipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_receipt.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_receipt.EnableHeadersVisualStyles = false;
            this.grid_receipt.GridColor = System.Drawing.Color.LightGray;
            this.grid_receipt.Location = new System.Drawing.Point(6, 45);
            this.grid_receipt.MultiSelect = false;
            this.grid_receipt.Name = "grid_receipt";
            this.grid_receipt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_receipt.RowHeadersVisible = false;
            this.grid_receipt.RowTemplate.Height = 19;
            this.grid_receipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_receipt.Size = new System.Drawing.Size(478, 755);
            this.grid_receipt.StandardTab = true;
            this.grid_receipt.TabIndex = 1;
            this.grid_receipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_receipt_CellClick);
            // 
            // tabWIP
            // 
            this.tabWIP.Controls.Add(this.cbo_POSSite);
            this.tabWIP.Controls.Add(this.txt_POSMemo);
            this.tabWIP.Controls.Add(this.txt_POSSupplier);
            this.tabWIP.Controls.Add(this.txt_POSPOID);
            this.tabWIP.Controls.Add(this.label2);
            this.tabWIP.Controls.Add(this.label3);
            this.tabWIP.Controls.Add(this.label4);
            this.tabWIP.Controls.Add(this.label5);
            this.tabWIP.Controls.Add(this.grid_selectionHeader);
            this.tabWIP.Location = new System.Drawing.Point(4, 27);
            this.tabWIP.Name = "tabWIP";
            this.tabWIP.Padding = new System.Windows.Forms.Padding(3);
            this.tabWIP.Size = new System.Drawing.Size(489, 806);
            this.tabWIP.TabIndex = 1;
            this.tabWIP.Text = "Order Selection";
            this.tabWIP.UseVisualStyleBackColor = true;
            // 
            // cbo_POSSite
            // 
            this.cbo_POSSite.BackColor = System.Drawing.Color.White;
            this.cbo_POSSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_POSSite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_POSSite.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_POSSite.FormattingEnabled = true;
            this.cbo_POSSite.Location = new System.Drawing.Point(178, 19);
            this.cbo_POSSite.Name = "cbo_POSSite";
            this.cbo_POSSite.Size = new System.Drawing.Size(57, 23);
            this.cbo_POSSite.TabIndex = 461;
            this.cbo_POSSite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchPO);
            // 
            // txt_POSMemo
            // 
            this.txt_POSMemo.BackColor = System.Drawing.Color.White;
            this.txt_POSMemo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_POSMemo.Location = new System.Drawing.Point(241, 21);
            this.txt_POSMemo.Name = "txt_POSMemo";
            this.txt_POSMemo.Size = new System.Drawing.Size(243, 21);
            this.txt_POSMemo.TabIndex = 463;
            this.txt_POSMemo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchPO);
            // 
            // txt_POSSupplier
            // 
            this.txt_POSSupplier.BackColor = System.Drawing.Color.White;
            this.txt_POSSupplier.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_POSSupplier.Location = new System.Drawing.Point(81, 21);
            this.txt_POSSupplier.Name = "txt_POSSupplier";
            this.txt_POSSupplier.Size = new System.Drawing.Size(91, 21);
            this.txt_POSSupplier.TabIndex = 462;
            this.txt_POSSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchPO);
            // 
            // txt_POSPOID
            // 
            this.txt_POSPOID.BackColor = System.Drawing.Color.White;
            this.txt_POSPOID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_POSPOID.Location = new System.Drawing.Point(6, 21);
            this.txt_POSPOID.Name = "txt_POSPOID";
            this.txt_POSPOID.Size = new System.Drawing.Size(69, 21);
            this.txt_POSPOID.TabIndex = 461;
            this.txt_POSPOID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchPO);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Memo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Site";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "PO Number";
            // 
            // grid_selectionHeader
            // 
            this.grid_selectionHeader.AllowUserToAddRows = false;
            this.grid_selectionHeader.AllowUserToDeleteRows = false;
            this.grid_selectionHeader.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_selectionHeader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_selectionHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_selectionHeader.BackgroundColor = System.Drawing.Color.White;
            this.grid_selectionHeader.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_selectionHeader.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_selectionHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_selectionHeader.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_selectionHeader.EnableHeadersVisualStyles = false;
            this.grid_selectionHeader.GridColor = System.Drawing.Color.LightGray;
            this.grid_selectionHeader.Location = new System.Drawing.Point(6, 45);
            this.grid_selectionHeader.MultiSelect = false;
            this.grid_selectionHeader.Name = "grid_selectionHeader";
            this.grid_selectionHeader.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_selectionHeader.RowHeadersVisible = false;
            this.grid_selectionHeader.RowTemplate.Height = 19;
            this.grid_selectionHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_selectionHeader.Size = new System.Drawing.Size(478, 755);
            this.grid_selectionHeader.StandardTab = true;
            this.grid_selectionHeader.TabIndex = 4;
            this.grid_selectionHeader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_selectionHeader_CellClick);
            // 
            // dateTimePickerReceipt
            // 
            this.dateTimePickerReceipt.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReceipt.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerReceipt.Enabled = false;
            this.dateTimePickerReceipt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReceipt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReceipt.Location = new System.Drawing.Point(7, 23);
            this.dateTimePickerReceipt.Name = "dateTimePickerReceipt";
            this.dateTimePickerReceipt.Size = new System.Drawing.Size(107, 22);
            this.dateTimePickerReceipt.TabIndex = 3;
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(1168, 13);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(110, 116);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "Receiving";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.dateTimePickerOrder);
            this.panel1.Controls.Add(this.customLabel22);
            this.panel1.Controls.Add(this.dateTimePickerRequire);
            this.panel1.Controls.Add(this.LabelRequireDate);
            this.panel1.Controls.Add(this.customLabel15);
            this.panel1.Controls.Add(this.txt_supplierName);
            this.panel1.Controls.Add(this.customLabel17);
            this.panel1.Controls.Add(this.customLabel13);
            this.panel1.Controls.Add(this.txt_totalPOQty);
            this.panel1.Controls.Add(this.txt_totalPOAmount);
            this.panel1.Controls.Add(this.txt_totalQty);
            this.panel1.Controls.Add(this.customLabel16);
            this.panel1.Controls.Add(this.txt_totalAmount);
            this.panel1.Controls.Add(this.customLabel14);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.customLabel7);
            this.panel1.Controls.Add(this.dateTimePickerReceipt);
            this.panel1.Controls.Add(this.txt_poNumber);
            this.panel1.Controls.Add(this.customLabel1);
            this.panel1.Controls.Add(this.customLabel4);
            this.panel1.Controls.Add(this.customLabel3);
            this.panel1.Controls.Add(this.txt_receivingSite);
            this.panel1.Controls.Add(this.txt_memo);
            this.panel1.Controls.Add(this.txt_receiptNumber);
            this.panel1.Controls.Add(this.customLabel2);
            this.panel1.Controls.Add(this.customLabel5);
            this.panel1.Controls.Add(this.txt_supplierID);
            this.panel1.Controls.Add(this.cbo_site);
            this.panel1.Controls.Add(this.customLabel6);
            this.panel1.Location = new System.Drawing.Point(511, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 137);
            this.panel1.TabIndex = 459;
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerOrder.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOrder.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerOrder.Enabled = false;
            this.dateTimePickerOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOrder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOrder.Location = new System.Drawing.Point(515, 22);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(85, 22);
            this.dateTimePickerOrder.TabIndex = 509;
            // 
            // customLabel22
            // 
            this.customLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel22.AutoSize = true;
            this.customLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel22.Location = new System.Drawing.Point(512, 6);
            this.customLabel22.Name = "customLabel22";
            this.customLabel22.Size = new System.Drawing.Size(67, 15);
            this.customLabel22.TabIndex = 510;
            this.customLabel22.Text = "Order Date";
            // 
            // dateTimePickerRequire
            // 
            this.dateTimePickerRequire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerRequire.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRequire.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerRequire.Enabled = false;
            this.dateTimePickerRequire.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerRequire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRequire.Location = new System.Drawing.Point(606, 22);
            this.dateTimePickerRequire.Name = "dateTimePickerRequire";
            this.dateTimePickerRequire.Size = new System.Drawing.Size(85, 22);
            this.dateTimePickerRequire.TabIndex = 507;
            // 
            // LabelRequireDate
            // 
            this.LabelRequireDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRequireDate.AutoSize = true;
            this.LabelRequireDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRequireDate.Location = new System.Drawing.Point(603, 6);
            this.LabelRequireDate.Name = "LabelRequireDate";
            this.LabelRequireDate.Size = new System.Drawing.Size(77, 15);
            this.LabelRequireDate.TabIndex = 508;
            this.LabelRequireDate.Text = "Require Date";
            // 
            // customLabel15
            // 
            this.customLabel15.AutoSize = true;
            this.customLabel15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel15.Location = new System.Drawing.Point(202, 47);
            this.customLabel15.Name = "customLabel15";
            this.customLabel15.Size = new System.Drawing.Size(87, 15);
            this.customLabel15.TabIndex = 502;
            this.customLabel15.Text = "Supplier Name";
            // 
            // txt_supplierName
            // 
            this.txt_supplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_supplierName.BackColor = System.Drawing.Color.White;
            this.txt_supplierName.Enabled = false;
            this.txt_supplierName.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_supplierName.Location = new System.Drawing.Point(205, 65);
            this.txt_supplierName.Name = "txt_supplierName";
            this.txt_supplierName.Size = new System.Drawing.Size(486, 21);
            this.txt_supplierName.TabIndex = 501;
            this.txt_supplierName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customLabel17
            // 
            this.customLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel17.AutoSize = true;
            this.customLabel17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel17.Location = new System.Drawing.Point(694, 47);
            this.customLabel17.Name = "customLabel17";
            this.customLabel17.Size = new System.Drawing.Size(103, 15);
            this.customLabel17.TabIndex = 500;
            this.customLabel17.Text = "Total PO Quantity";
            // 
            // customLabel13
            // 
            this.customLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel13.AutoSize = true;
            this.customLabel13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel13.Location = new System.Drawing.Point(854, 47);
            this.customLabel13.Name = "customLabel13";
            this.customLabel13.Size = new System.Drawing.Size(165, 15);
            this.customLabel13.TabIndex = 500;
            this.customLabel13.Text = "Receiving / Total GR Quantity";
            // 
            // txt_totalPOQty
            // 
            this.txt_totalPOQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalPOQty.BackColor = System.Drawing.Color.White;
            this.txt_totalPOQty.Enabled = false;
            this.txt_totalPOQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalPOQty.Location = new System.Drawing.Point(697, 65);
            this.txt_totalPOQty.Name = "txt_totalPOQty";
            this.txt_totalPOQty.Size = new System.Drawing.Size(154, 21);
            this.txt_totalPOQty.TabIndex = 499;
            this.txt_totalPOQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_totalPOAmount
            // 
            this.txt_totalPOAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalPOAmount.BackColor = System.Drawing.Color.White;
            this.txt_totalPOAmount.Enabled = false;
            this.txt_totalPOAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalPOAmount.Location = new System.Drawing.Point(697, 107);
            this.txt_totalPOAmount.Name = "txt_totalPOAmount";
            this.txt_totalPOAmount.Size = new System.Drawing.Size(154, 21);
            this.txt_totalPOAmount.TabIndex = 497;
            this.txt_totalPOAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_totalQty
            // 
            this.txt_totalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalQty.BackColor = System.Drawing.Color.White;
            this.txt_totalQty.Enabled = false;
            this.txt_totalQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalQty.Location = new System.Drawing.Point(857, 65);
            this.txt_totalQty.Name = "txt_totalQty";
            this.txt_totalQty.Size = new System.Drawing.Size(189, 21);
            this.txt_totalQty.TabIndex = 499;
            this.txt_totalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel16
            // 
            this.customLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel16.Location = new System.Drawing.Point(694, 89);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(98, 15);
            this.customLabel16.TabIndex = 498;
            this.customLabel16.Text = "Total PO Amount";
            // 
            // txt_totalAmount
            // 
            this.txt_totalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalAmount.BackColor = System.Drawing.Color.White;
            this.txt_totalAmount.Enabled = false;
            this.txt_totalAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalAmount.Location = new System.Drawing.Point(857, 107);
            this.txt_totalAmount.Name = "txt_totalAmount";
            this.txt_totalAmount.Size = new System.Drawing.Size(189, 21);
            this.txt_totalAmount.TabIndex = 497;
            this.txt_totalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel14
            // 
            this.customLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel14.AutoSize = true;
            this.customLabel14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel14.Location = new System.Drawing.Point(854, 89);
            this.customLabel14.Name = "customLabel14";
            this.customLabel14.Size = new System.Drawing.Size(160, 15);
            this.customLabel14.TabIndex = 498;
            this.customLabel14.Text = "Receiving / Total GR Amount";
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(1052, 13);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(110, 116);
            this.btn_print.TabIndex = 460;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1284, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 116);
            this.button1.TabIndex = 459;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customLabel7
            // 
            this.customLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(694, 6);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(69, 15);
            this.customLabel7.TabIndex = 458;
            this.customLabel7.Text = "PO Number";
            // 
            // txt_poNumber
            // 
            this.txt_poNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_poNumber.BackColor = System.Drawing.Color.White;
            this.txt_poNumber.Enabled = false;
            this.txt_poNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_poNumber.Location = new System.Drawing.Point(697, 22);
            this.txt_poNumber.Name = "txt_poNumber";
            this.txt_poNumber.Size = new System.Drawing.Size(154, 21);
            this.txt_poNumber.TabIndex = 457;
            this.txt_poNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(4, 6);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(75, 15);
            this.customLabel1.TabIndex = 444;
            this.customLabel1.Text = "Receipt Date";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(205, 6);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(82, 15);
            this.customLabel4.TabIndex = 456;
            this.customLabel4.Text = "Receiving Site";
            this.customLabel4.Visible = false;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(4, 89);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(178, 15);
            this.customLabel3.TabIndex = 445;
            this.customLabel3.Text = "Memo (Maximum Length: 200)";
            // 
            // txt_receivingSite
            // 
            this.txt_receivingSite.BackColor = System.Drawing.Color.White;
            this.txt_receivingSite.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_receivingSite.Location = new System.Drawing.Point(205, 22);
            this.txt_receivingSite.Name = "txt_receivingSite";
            this.txt_receivingSite.Size = new System.Drawing.Size(138, 21);
            this.txt_receivingSite.TabIndex = 455;
            this.txt_receivingSite.Visible = false;
            // 
            // txt_memo
            // 
            this.txt_memo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_memo.BackColor = System.Drawing.Color.White;
            this.txt_memo.Enabled = false;
            this.txt_memo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_memo.Location = new System.Drawing.Point(7, 107);
            this.txt_memo.MaxLength = 200;
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(684, 21);
            this.txt_memo.TabIndex = 4;
            // 
            // txt_receiptNumber
            // 
            this.txt_receiptNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_receiptNumber.BackColor = System.Drawing.Color.White;
            this.txt_receiptNumber.Enabled = false;
            this.txt_receiptNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_receiptNumber.Location = new System.Drawing.Point(857, 22);
            this.txt_receiptNumber.Name = "txt_receiptNumber";
            this.txt_receiptNumber.Size = new System.Drawing.Size(189, 21);
            this.txt_receiptNumber.TabIndex = 1;
            this.txt_receiptNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(4, 47);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(68, 15);
            this.customLabel2.TabIndex = 453;
            this.customLabel2.Text = "Supplier ID";
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(854, 6);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(93, 15);
            this.customLabel5.TabIndex = 449;
            this.customLabel5.Text = "Receipt Number";
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.BackColor = System.Drawing.Color.White;
            this.txt_supplierID.Enabled = false;
            this.txt_supplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_supplierID.Location = new System.Drawing.Point(7, 65);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.Size = new System.Drawing.Size(192, 21);
            this.txt_supplierID.TabIndex = 2;
            this.txt_supplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_site
            // 
            this.cbo_site.BackColor = System.Drawing.Color.White;
            this.cbo_site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_site.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_site.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_site.FormattingEnabled = true;
            this.cbo_site.Location = new System.Drawing.Point(120, 23);
            this.cbo_site.Name = "cbo_site";
            this.cbo_site.Size = new System.Drawing.Size(79, 23);
            this.cbo_site.TabIndex = 0;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(117, 7);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(81, 15);
            this.customLabel6.TabIndex = 451;
            this.customLabel6.Text = "Receiving site";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(437, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(68, 23);
            this.btn_refresh.TabIndex = 642;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(349, 13);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(85, 22);
            this.dateTimePickerTo.TabIndex = 640;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(261, 13);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(85, 22);
            this.dateTimePickerFrom.TabIndex = 639;
            // 
            // customLabel19
            // 
            this.customLabel19.AutoSize = true;
            this.customLabel19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel19.Location = new System.Drawing.Point(347, -2);
            this.customLabel19.Name = "customLabel19";
            this.customLabel19.Size = new System.Drawing.Size(19, 15);
            this.customLabel19.TabIndex = 641;
            this.customLabel19.Text = "To";
            // 
            // customLabel18
            // 
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel18.Location = new System.Drawing.Point(259, -2);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(35, 15);
            this.customLabel18.TabIndex = 638;
            this.customLabel18.Text = "From";
            // 
            // customLabel20
            // 
            this.customLabel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel20.AutoSize = true;
            this.customLabel20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel20.Location = new System.Drawing.Point(882, 212);
            this.customLabel20.Name = "customLabel20";
            this.customLabel20.Size = new System.Drawing.Size(107, 15);
            this.customLabel20.TabIndex = 506;
            this.customLabel20.Text = "Total Diff Quantity";
            this.customLabel20.Visible = false;
            // 
            // txt_totalDiffQty
            // 
            this.txt_totalDiffQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalDiffQty.BackColor = System.Drawing.Color.White;
            this.txt_totalDiffQty.Enabled = false;
            this.txt_totalDiffQty.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalDiffQty.Location = new System.Drawing.Point(885, 230);
            this.txt_totalDiffQty.Name = "txt_totalDiffQty";
            this.txt_totalDiffQty.Size = new System.Drawing.Size(120, 21);
            this.txt_totalDiffQty.TabIndex = 505;
            this.txt_totalDiffQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_totalDiffQty.Visible = false;
            // 
            // txt_totalDiffAmount
            // 
            this.txt_totalDiffAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_totalDiffAmount.BackColor = System.Drawing.Color.White;
            this.txt_totalDiffAmount.Enabled = false;
            this.txt_totalDiffAmount.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_totalDiffAmount.Location = new System.Drawing.Point(885, 272);
            this.txt_totalDiffAmount.Name = "txt_totalDiffAmount";
            this.txt_totalDiffAmount.Size = new System.Drawing.Size(120, 21);
            this.txt_totalDiffAmount.TabIndex = 503;
            this.txt_totalDiffAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_totalDiffAmount.Visible = false;
            // 
            // customLabel21
            // 
            this.customLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel21.AutoSize = true;
            this.customLabel21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel21.Location = new System.Drawing.Point(882, 254);
            this.customLabel21.Name = "customLabel21";
            this.customLabel21.Size = new System.Drawing.Size(102, 15);
            this.customLabel21.TabIndex = 504;
            this.customLabel21.Text = "Total Diff Amount";
            this.customLabel21.Visible = false;
            // 
            // grid_detail
            // 
            this.grid_detail.AllowUserToAddRows = false;
            this.grid_detail.AllowUserToDeleteRows = false;
            this.grid_detail.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_detail.BackgroundColor = System.Drawing.Color.White;
            this.grid_detail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_detail.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_detail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_detail.EnableHeadersVisualStyles = false;
            this.grid_detail.GridColor = System.Drawing.Color.LightGray;
            this.grid_detail.Location = new System.Drawing.Point(511, 164);
            this.grid_detail.MultiSelect = false;
            this.grid_detail.Name = "grid_detail";
            this.grid_detail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_detail.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_detail.RowHeadersVisible = false;
            this.grid_detail.RowTemplate.Height = 19;
            this.grid_detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_detail.Size = new System.Drawing.Size(1371, 685);
            this.grid_detail.StandardTab = true;
            this.grid_detail.TabIndex = 1;
            this.grid_detail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detail_CellClick);
            this.grid_detail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detail_CellDoubleClick);
            this.grid_detail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detail_CellEndEdit);
            this.grid_detail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grid_detail_CellValidating);
            this.grid_detail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_detail_CellValueChanged);
            this.grid_detail.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.grid_detail_ColumnWidthChanged);
            this.grid_detail.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_detail_DataBindingComplete);
            this.grid_detail.Scroll += new System.Windows.Forms.ScrollEventHandler(this.grid_detail_Scroll);
            // 
            // RECEIPTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1894, 861);
            this.Controls.Add(this.customLabel20);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_totalDiffQty);
            this.Controls.Add(this.customLabel19);
            this.Controls.Add(this.txt_totalDiffAmount);
            this.Controls.Add(this.customLabel18);
            this.Controls.Add(this.customLabel21);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_detail);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1806, 842);
            this.Name = "RECEIPTS";
            this.Text = "Goods Receipt";
            this.tabControl1.ResumeLayout(false);
            this.tabReceipt.ResumeLayout(false);
            this.tabReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_receipt)).EndInit();
            this.tabWIP.ResumeLayout(false);
            this.tabWIP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_selectionHeader)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabReceipt;
        private System.Windows.Forms.TabPage tabWIP;
        private CustomGrid grid_detail;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerReceipt;
        private CustomTextBox txt_memo;
        private Tools.CustomLabel customLabel5;
        private CustomTextBox txt_receiptNumber;
        private Tools.CustomLabel customLabel6;
        private Tools.CustomComboBox cbo_site;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_supplierID;
        private System.Windows.Forms.Button btn_create;
        private CustomGrid grid_receipt;
        private CustomGrid grid_selectionHeader;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_receivingSite;
        private Tools.CustomLabel customLabel7;
        private CustomTextBox txt_poNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_refresh;
        private Tools.CustomLabel customLabel19;
        private Tools.CustomLabel customLabel18;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btn_print;
        private CustomTextBox txt_PRSMemo;
        private Tools.CustomComboBox cbo_PRSSite;
        private CustomTextBox txt_PRSSupplier;
        private CustomTextBox txt_PRSRECID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private CustomTextBox txt_POSPOID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Tools.CustomComboBox cbo_POSSite;
        private CustomTextBox txt_POSMemo;
        private CustomTextBox txt_POSSupplier;
        private CustomTextBox txt_PRSPOID;
        private System.Windows.Forms.Label label6;
        private Tools.CustomLabel customLabel13;
        private CustomTextBox txt_totalQty;
        private CustomTextBox txt_totalAmount;
        private Tools.CustomLabel customLabel14;
        private Tools.CustomLabel customLabel15;
        private CustomTextBox txt_supplierName;
        private Tools.CustomLabel customLabel17;
        private CustomTextBox txt_totalPOQty;
        private CustomTextBox txt_totalPOAmount;
        private Tools.CustomLabel customLabel16;
        private Tools.CustomLabel customLabel20;
        private CustomTextBox txt_totalDiffQty;
        private CustomTextBox txt_totalDiffAmount;
        private Tools.CustomLabel customLabel21;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequire;
        private Tools.CustomLabel LabelRequireDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private Tools.CustomLabel customLabel22;
    }
}