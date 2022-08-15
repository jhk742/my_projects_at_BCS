namespace OBCS.Purchase
{
    partial class POPrepData
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart_monthly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_weekly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addMemo = new System.Windows.Forms.Button();
            this.cbo_product = new OBCS.Tools.CustomComboBox();
            this.cbo_basedDate = new OBCS.Tools.CustomComboBox();
            this.dateTimePicker_endDate = new OBCS.Purchase.CustomDateTimePicker();
            this.dateTimePicker_startDate = new OBCS.Purchase.CustomDateTimePicker();
            this.txt_memo = new OBCS.CustomTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.grid_POReceiptHistory = new OBCS.CustomGrid();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.grid_salesHistoryMonthly = new OBCS.CustomGrid();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.grid_salesHistoryWeekly = new OBCS.CustomGrid();
            this.txt_brand = new OBCS.CustomTextBox();
            this.txt_product = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.grid_brandMemo = new OBCS.CustomGrid();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.txt_listPrice = new OBCS.CustomTextBox();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.txt_commissionCode = new OBCS.CustomTextBox();
            this.customLabel9 = new OBCS.Tools.CustomLabel();
            this.txt_bottomPrice = new OBCS.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_monthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_weekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_POReceiptHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesHistoryMonthly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesHistoryWeekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_brandMemo)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_monthly
            // 
            this.chart_monthly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart_monthly.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.White;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart_monthly.Legends.Add(legend1);
            this.chart_monthly.Location = new System.Drawing.Point(15, 573);
            this.chart_monthly.Name = "chart_monthly";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart_monthly.Series.Add(series1);
            this.chart_monthly.Size = new System.Drawing.Size(1275, 281);
            this.chart_monthly.TabIndex = 68;
            this.chart_monthly.Text = "chart1";
            // 
            // chart_weekly
            // 
            this.chart_weekly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart_weekly.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.White;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart_weekly.Legends.Add(legend2);
            this.chart_weekly.Location = new System.Drawing.Point(12, 275);
            this.chart_weekly.Name = "chart_weekly";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_weekly.Series.Add(series2);
            this.chart_weekly.Size = new System.Drawing.Size(1278, 277);
            this.chart_weekly.TabIndex = 69;
            this.chart_weekly.Text = "chart1";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1058, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 71;
            this.label5.Text = "Product ID :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1058, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Memo :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1158, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 75;
            this.label3.Text = "Based Date :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1242, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1335, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 79;
            this.label4.Text = "End Date";
            // 
            // btn_addMemo
            // 
            this.btn_addMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addMemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_addMemo.FlatAppearance.BorderSize = 0;
            this.btn_addMemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMemo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_addMemo.ForeColor = System.Drawing.Color.White;
            this.btn_addMemo.Location = new System.Drawing.Point(1431, 62);
            this.btn_addMemo.Name = "btn_addMemo";
            this.btn_addMemo.Size = new System.Drawing.Size(50, 48);
            this.btn_addMemo.TabIndex = 557;
            this.btn_addMemo.Text = "Add";
            this.btn_addMemo.UseVisualStyleBackColor = false;
            this.btn_addMemo.Click += new System.EventHandler(this.btn_addMemo_Click);
            // 
            // cbo_product
            // 
            this.cbo_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_product.BackColor = System.Drawing.Color.White;
            this.cbo_product.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_product.FormattingEnabled = true;
            this.cbo_product.Location = new System.Drawing.Point(1058, 60);
            this.cbo_product.Name = "cbo_product";
            this.cbo_product.Size = new System.Drawing.Size(97, 23);
            this.cbo_product.TabIndex = 687;
            // 
            // cbo_basedDate
            // 
            this.cbo_basedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_basedDate.BackColor = System.Drawing.Color.White;
            this.cbo_basedDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_basedDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_basedDate.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_basedDate.FormattingEnabled = true;
            this.cbo_basedDate.Location = new System.Drawing.Point(1161, 60);
            this.cbo_basedDate.Name = "cbo_basedDate";
            this.cbo_basedDate.Size = new System.Drawing.Size(78, 23);
            this.cbo_basedDate.TabIndex = 306;
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_endDate.BackColor = System.Drawing.Color.White;
            this.dateTimePicker_endDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_endDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker_endDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(1338, 62);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(87, 21);
            this.dateTimePicker_endDate.TabIndex = 78;
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_startDate.BackColor = System.Drawing.Color.White;
            this.dateTimePicker_startDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_startDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker_startDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(1245, 62);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(87, 21);
            this.dateTimePicker_startDate.TabIndex = 76;
            // 
            // txt_memo
            // 
            this.txt_memo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_memo.BackColor = System.Drawing.Color.White;
            this.txt_memo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_memo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_memo.Location = new System.Drawing.Point(1111, 89);
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(314, 21);
            this.txt_memo.TabIndex = 72;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.Location = new System.Drawing.Point(12, 27);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(66, 15);
            this.customLabel6.TabIndex = 14;
            this.customLabel6.Text = "PO History";
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.Location = new System.Drawing.Point(218, 9);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(50, 15);
            this.customLabel5.TabIndex = 13;
            this.customLabel5.Text = "Product";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(12, 9);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(40, 15);
            this.customLabel4.TabIndex = 12;
            this.customLabel4.Text = "Brand";
            // 
            // grid_POReceiptHistory
            // 
            this.grid_POReceiptHistory.AllowUserToAddRows = false;
            this.grid_POReceiptHistory.AllowUserToDeleteRows = false;
            this.grid_POReceiptHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_POReceiptHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_POReceiptHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_POReceiptHistory.BackgroundColor = System.Drawing.Color.White;
            this.grid_POReceiptHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_POReceiptHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_POReceiptHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_POReceiptHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_POReceiptHistory.EnableHeadersVisualStyles = false;
            this.grid_POReceiptHistory.GridColor = System.Drawing.Color.LightGray;
            this.grid_POReceiptHistory.Location = new System.Drawing.Point(12, 45);
            this.grid_POReceiptHistory.MultiSelect = false;
            this.grid_POReceiptHistory.Name = "grid_POReceiptHistory";
            this.grid_POReceiptHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_POReceiptHistory.RowHeadersVisible = false;
            this.grid_POReceiptHistory.RowTemplate.Height = 19;
            this.grid_POReceiptHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_POReceiptHistory.Size = new System.Drawing.Size(1040, 224);
            this.grid_POReceiptHistory.StandardTab = true;
            this.grid_POReceiptHistory.TabIndex = 11;
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.Location = new System.Drawing.Point(1293, 555);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(136, 15);
            this.customLabel3.TabIndex = 10;
            this.customLabel3.Text = "Sales History (Monthly)";
            // 
            // grid_salesHistoryMonthly
            // 
            this.grid_salesHistoryMonthly.AllowUserToAddRows = false;
            this.grid_salesHistoryMonthly.AllowUserToDeleteRows = false;
            this.grid_salesHistoryMonthly.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_salesHistoryMonthly.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_salesHistoryMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_salesHistoryMonthly.BackgroundColor = System.Drawing.Color.White;
            this.grid_salesHistoryMonthly.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_salesHistoryMonthly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_salesHistoryMonthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_salesHistoryMonthly.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_salesHistoryMonthly.EnableHeadersVisualStyles = false;
            this.grid_salesHistoryMonthly.GridColor = System.Drawing.Color.LightGray;
            this.grid_salesHistoryMonthly.Location = new System.Drawing.Point(1296, 573);
            this.grid_salesHistoryMonthly.MultiSelect = false;
            this.grid_salesHistoryMonthly.Name = "grid_salesHistoryMonthly";
            this.grid_salesHistoryMonthly.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_salesHistoryMonthly.RowHeadersVisible = false;
            this.grid_salesHistoryMonthly.RowTemplate.Height = 19;
            this.grid_salesHistoryMonthly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_salesHistoryMonthly.Size = new System.Drawing.Size(185, 281);
            this.grid_salesHistoryMonthly.StandardTab = true;
            this.grid_salesHistoryMonthly.TabIndex = 9;
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(1293, 257);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(130, 15);
            this.customLabel2.TabIndex = 8;
            this.customLabel2.Text = "Sales History (Weekly)";
            // 
            // grid_salesHistoryWeekly
            // 
            this.grid_salesHistoryWeekly.AllowUserToAddRows = false;
            this.grid_salesHistoryWeekly.AllowUserToDeleteRows = false;
            this.grid_salesHistoryWeekly.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_salesHistoryWeekly.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_salesHistoryWeekly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_salesHistoryWeekly.BackgroundColor = System.Drawing.Color.White;
            this.grid_salesHistoryWeekly.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_salesHistoryWeekly.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_salesHistoryWeekly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_salesHistoryWeekly.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_salesHistoryWeekly.EnableHeadersVisualStyles = false;
            this.grid_salesHistoryWeekly.GridColor = System.Drawing.Color.LightGray;
            this.grid_salesHistoryWeekly.Location = new System.Drawing.Point(1296, 275);
            this.grid_salesHistoryWeekly.MultiSelect = false;
            this.grid_salesHistoryWeekly.Name = "grid_salesHistoryWeekly";
            this.grid_salesHistoryWeekly.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_salesHistoryWeekly.RowHeadersVisible = false;
            this.grid_salesHistoryWeekly.RowTemplate.Height = 19;
            this.grid_salesHistoryWeekly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_salesHistoryWeekly.Size = new System.Drawing.Size(185, 277);
            this.grid_salesHistoryWeekly.StandardTab = true;
            this.grid_salesHistoryWeekly.TabIndex = 7;
            // 
            // txt_brand
            // 
            this.txt_brand.BackColor = System.Drawing.Color.White;
            this.txt_brand.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_brand.Location = new System.Drawing.Point(58, 6);
            this.txt_brand.Name = "txt_brand";
            this.txt_brand.Size = new System.Drawing.Size(154, 21);
            this.txt_brand.TabIndex = 6;
            this.txt_brand.TextChanged += new System.EventHandler(this.txt_brand_TextChanged);
            // 
            // txt_product
            // 
            this.txt_product.BackColor = System.Drawing.Color.White;
            this.txt_product.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_product.Location = new System.Drawing.Point(274, 6);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(88, 21);
            this.txt_product.TabIndex = 4;
            this.txt_product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_product.TextChanged += new System.EventHandler(this.txt_product_TextChanged);
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(1058, 27);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(43, 15);
            this.customLabel1.TabIndex = 3;
            this.customLabel1.Text = "Memo";
            // 
            // grid_brandMemo
            // 
            this.grid_brandMemo.AllowUserToAddRows = false;
            this.grid_brandMemo.AllowUserToDeleteRows = false;
            this.grid_brandMemo.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_brandMemo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_brandMemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_brandMemo.BackgroundColor = System.Drawing.Color.White;
            this.grid_brandMemo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_brandMemo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grid_brandMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_brandMemo.DefaultCellStyle = dataGridViewCellStyle12;
            this.grid_brandMemo.EnableHeadersVisualStyles = false;
            this.grid_brandMemo.GridColor = System.Drawing.Color.LightGray;
            this.grid_brandMemo.Location = new System.Drawing.Point(1058, 116);
            this.grid_brandMemo.MultiSelect = false;
            this.grid_brandMemo.Name = "grid_brandMemo";
            this.grid_brandMemo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_brandMemo.RowHeadersVisible = false;
            this.grid_brandMemo.RowTemplate.Height = 19;
            this.grid_brandMemo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_brandMemo.Size = new System.Drawing.Size(423, 138);
            this.grid_brandMemo.StandardTab = true;
            this.grid_brandMemo.TabIndex = 2;
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(368, 9);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(57, 15);
            this.customLabel7.TabIndex = 689;
            this.customLabel7.Text = "List Price";
            // 
            // txt_listPrice
            // 
            this.txt_listPrice.BackColor = System.Drawing.Color.White;
            this.txt_listPrice.Enabled = false;
            this.txt_listPrice.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_listPrice.Location = new System.Drawing.Point(431, 6);
            this.txt_listPrice.Name = "txt_listPrice";
            this.txt_listPrice.Size = new System.Drawing.Size(67, 21);
            this.txt_listPrice.TabIndex = 688;
            this.txt_listPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(660, 9);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(105, 15);
            this.customLabel8.TabIndex = 693;
            this.customLabel8.Text = "Commission Code";
            // 
            // txt_commissionCode
            // 
            this.txt_commissionCode.BackColor = System.Drawing.Color.White;
            this.txt_commissionCode.Enabled = false;
            this.txt_commissionCode.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_commissionCode.Location = new System.Drawing.Point(771, 6);
            this.txt_commissionCode.Name = "txt_commissionCode";
            this.txt_commissionCode.Size = new System.Drawing.Size(67, 21);
            this.txt_commissionCode.TabIndex = 692;
            this.txt_commissionCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customLabel9
            // 
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.Location = new System.Drawing.Point(504, 9);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(77, 15);
            this.customLabel9.TabIndex = 691;
            this.customLabel9.Text = "Bottom Price";
            // 
            // txt_bottomPrice
            // 
            this.txt_bottomPrice.BackColor = System.Drawing.Color.White;
            this.txt_bottomPrice.Enabled = false;
            this.txt_bottomPrice.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_bottomPrice.Location = new System.Drawing.Point(587, 6);
            this.txt_bottomPrice.Name = "txt_bottomPrice";
            this.txt_bottomPrice.Size = new System.Drawing.Size(67, 21);
            this.txt_bottomPrice.TabIndex = 690;
            this.txt_bottomPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // POPrepData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 866);
            this.Controls.Add(this.customLabel8);
            this.Controls.Add(this.txt_commissionCode);
            this.Controls.Add(this.customLabel9);
            this.Controls.Add(this.txt_bottomPrice);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.txt_listPrice);
            this.Controls.Add(this.cbo_product);
            this.Controls.Add(this.btn_addMemo);
            this.Controls.Add(this.cbo_basedDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_endDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_startDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_memo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart_weekly);
            this.Controls.Add(this.chart_monthly);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.grid_POReceiptHistory);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.grid_salesHistoryMonthly);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.grid_salesHistoryWeekly);
            this.Controls.Add(this.txt_brand);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.grid_brandMemo);
            this.Name = "POPrepData";
            this.Text = "Purchase Order Preparation Data";
            ((System.ComponentModel.ISupportInitialize)(this.chart_monthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_weekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_POReceiptHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesHistoryMonthly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesHistoryWeekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_brandMemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomGrid grid_brandMemo;
        private Tools.CustomLabel customLabel1;
        private CustomGrid grid_salesHistoryWeekly;
        private Tools.CustomLabel customLabel2;
        private CustomGrid grid_salesHistoryMonthly;
        private Tools.CustomLabel customLabel3;
        private CustomGrid grid_POReceiptHistory;
        private Tools.CustomLabel customLabel4;
        private Tools.CustomLabel customLabel5;
        public CustomTextBox txt_product;
        public CustomTextBox txt_brand;
        private Tools.CustomLabel customLabel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_monthly;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_weekly;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private CustomTextBox txt_memo;
        private System.Windows.Forms.Label label3;
        private CustomDateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private CustomDateTimePicker dateTimePicker_endDate;
        private Tools.CustomComboBox cbo_basedDate;
        private System.Windows.Forms.Button btn_addMemo;
        private Tools.CustomComboBox cbo_product;
        private Tools.CustomLabel customLabel7;
        public CustomTextBox txt_listPrice;
        private Tools.CustomLabel customLabel8;
        public CustomTextBox txt_commissionCode;
        private Tools.CustomLabel customLabel9;
        public CustomTextBox txt_bottomPrice;
    }
}