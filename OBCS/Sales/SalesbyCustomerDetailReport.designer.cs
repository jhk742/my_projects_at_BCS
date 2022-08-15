
namespace OBCS.Sales
{
    partial class SalesbyCustomerDetailReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_export = new System.Windows.Forms.Button();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.txt_REP = new System.Windows.Forms.TextBox();
            this.txt_InvNumber = new System.Windows.Forms.TextBox();
            this.pn_GA = new System.Windows.Forms.Panel();
            this.txt_SalesDiscount = new System.Windows.Forms.TextBox();
            this.txt_GANetSales = new System.Windows.Forms.TextBox();
            this.customLabel11 = new OBCS.Tools.CustomLabel();
            this.customLabel26 = new OBCS.Tools.CustomLabel();
            this.customLabel15 = new OBCS.Tools.CustomLabel();
            this.txt_GAReturnCredit = new System.Windows.Forms.TextBox();
            this.customLabel16 = new OBCS.Tools.CustomLabel();
            this.txt_SalesAllowance = new System.Windows.Forms.TextBox();
            this.txt_GAGrossSales = new System.Windows.Forms.TextBox();
            this.customLabel10 = new OBCS.Tools.CustomLabel();
            this.pn_Sales = new System.Windows.Forms.Panel();
            this.txt_SACredit = new System.Windows.Forms.TextBox();
            this.txt_SAGrossSales = new System.Windows.Forms.TextBox();
            this.txt_SACOGS = new System.Windows.Forms.TextBox();
            this.customLabel13 = new OBCS.Tools.CustomLabel();
            this.customLabel14 = new OBCS.Tools.CustomLabel();
            this.customLabel20 = new OBCS.Tools.CustomLabel();
            this.txt_SANetSales = new System.Windows.Forms.TextBox();
            this.txt_SAReturnCredit = new System.Windows.Forms.TextBox();
            this.customLabel22 = new OBCS.Tools.CustomLabel();
            this.customLabel23 = new OBCS.Tools.CustomLabel();
            this.customLabel24 = new OBCS.Tools.CustomLabel();
            this.txt_SATermCredit = new System.Windows.Forms.TextBox();
            this.txt_SAPromo = new System.Windows.Forms.TextBox();
            this.customLabel25 = new OBCS.Tools.CustomLabel();
            this.rdb_AccountingVersion = new System.Windows.Forms.GroupBox();
            this.rdb_SalesVersion = new System.Windows.Forms.RadioButton();
            this.rdb_GAVersion = new System.Windows.Forms.RadioButton();
            this.customLabel9 = new OBCS.Tools.CustomLabel();
            this.customLabel8 = new OBCS.Tools.CustomLabel();
            this.grid_City = new OBCS.CustomGrid();
            this.grid_State = new OBCS.CustomGrid();
            this.customLabel7 = new OBCS.Tools.CustomLabel();
            this.customLabel19 = new OBCS.Tools.CustomLabel();
            this.customLabel18 = new OBCS.Tools.CustomLabel();
            this.grid_salesDetailReport = new OBCS.CustomGrid();
            this.lbl_RowCount = new System.Windows.Forms.Label();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.pn_GA.SuspendLayout();
            this.pn_Sales.SuspendLayout();
            this.rdb_AccountingVersion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_City)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_State)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesDetailReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(1758, 6);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(104, 52);
            this.btn_export.TabIndex = 828;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTo.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(1524, 36);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(118, 22);
            this.dateTimePickerTo.TabIndex = 826;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFrom.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.CustomFormat = "MM/dd/yyyy";
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(1524, 7);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(118, 22);
            this.dateTimePickerFrom.TabIndex = 825;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1648, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(104, 52);
            this.btn_refresh.TabIndex = 823;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CustomerID.BackColor = System.Drawing.Color.White;
            this.txt_CustomerID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CustomerID.Location = new System.Drawing.Point(1059, 6);
            this.txt_CustomerID.MaxLength = 50;
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(134, 23);
            this.txt_CustomerID.TabIndex = 848;
            // 
            // txt_REP
            // 
            this.txt_REP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_REP.BackColor = System.Drawing.Color.White;
            this.txt_REP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_REP.Location = new System.Drawing.Point(1211, 37);
            this.txt_REP.MaxLength = 5;
            this.txt_REP.Name = "txt_REP";
            this.txt_REP.Size = new System.Drawing.Size(55, 23);
            this.txt_REP.TabIndex = 852;
            // 
            // txt_InvNumber
            // 
            this.txt_InvNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_InvNumber.BackColor = System.Drawing.Color.White;
            this.txt_InvNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InvNumber.Location = new System.Drawing.Point(1372, 37);
            this.txt_InvNumber.MaxLength = 15;
            this.txt_InvNumber.Name = "txt_InvNumber";
            this.txt_InvNumber.Size = new System.Drawing.Size(106, 23);
            this.txt_InvNumber.TabIndex = 854;
            // 
            // pn_GA
            // 
            this.pn_GA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_GA.Controls.Add(this.txt_SalesDiscount);
            this.pn_GA.Controls.Add(this.txt_GANetSales);
            this.pn_GA.Controls.Add(this.customLabel11);
            this.pn_GA.Controls.Add(this.customLabel26);
            this.pn_GA.Controls.Add(this.customLabel15);
            this.pn_GA.Controls.Add(this.txt_GAReturnCredit);
            this.pn_GA.Controls.Add(this.customLabel16);
            this.pn_GA.Controls.Add(this.txt_SalesAllowance);
            this.pn_GA.Controls.Add(this.txt_GAGrossSales);
            this.pn_GA.Controls.Add(this.customLabel10);
            this.pn_GA.Location = new System.Drawing.Point(1338, 828);
            this.pn_GA.Name = "pn_GA";
            this.pn_GA.Size = new System.Drawing.Size(525, 48);
            this.pn_GA.TabIndex = 856;
            this.pn_GA.Visible = false;
            // 
            // txt_SalesDiscount
            // 
            this.txt_SalesDiscount.BackColor = System.Drawing.Color.White;
            this.txt_SalesDiscount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SalesDiscount.Location = new System.Drawing.Point(319, 22);
            this.txt_SalesDiscount.Name = "txt_SalesDiscount";
            this.txt_SalesDiscount.ReadOnly = true;
            this.txt_SalesDiscount.Size = new System.Drawing.Size(100, 23);
            this.txt_SalesDiscount.TabIndex = 844;
            this.txt_SalesDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_GANetSales
            // 
            this.txt_GANetSales.BackColor = System.Drawing.Color.White;
            this.txt_GANetSales.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GANetSales.Location = new System.Drawing.Point(425, 22);
            this.txt_GANetSales.Name = "txt_GANetSales";
            this.txt_GANetSales.ReadOnly = true;
            this.txt_GANetSales.Size = new System.Drawing.Size(100, 23);
            this.txt_GANetSales.TabIndex = 848;
            this.txt_GANetSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel11
            // 
            this.customLabel11.AutoSize = true;
            this.customLabel11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel11.Location = new System.Drawing.Point(335, 4);
            this.customLabel11.Name = "customLabel11";
            this.customLabel11.Size = new System.Drawing.Size(84, 15);
            this.customLabel11.TabIndex = 843;
            this.customLabel11.Text = "Sales Discount";
            // 
            // customLabel26
            // 
            this.customLabel26.AutoSize = true;
            this.customLabel26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel26.Location = new System.Drawing.Point(234, 4);
            this.customLabel26.Name = "customLabel26";
            this.customLabel26.Size = new System.Drawing.Size(82, 15);
            this.customLabel26.TabIndex = 837;
            this.customLabel26.Text = "Return Credit";
            // 
            // customLabel15
            // 
            this.customLabel15.AutoSize = true;
            this.customLabel15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel15.Location = new System.Drawing.Point(34, 4);
            this.customLabel15.Name = "customLabel15";
            this.customLabel15.Size = new System.Drawing.Size(67, 15);
            this.customLabel15.TabIndex = 827;
            this.customLabel15.Text = "Gross Sales";
            // 
            // txt_GAReturnCredit
            // 
            this.txt_GAReturnCredit.BackColor = System.Drawing.Color.White;
            this.txt_GAReturnCredit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GAReturnCredit.Location = new System.Drawing.Point(213, 22);
            this.txt_GAReturnCredit.Name = "txt_GAReturnCredit";
            this.txt_GAReturnCredit.ReadOnly = true;
            this.txt_GAReturnCredit.Size = new System.Drawing.Size(100, 23);
            this.txt_GAReturnCredit.TabIndex = 838;
            this.txt_GAReturnCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel16
            // 
            this.customLabel16.AutoSize = true;
            this.customLabel16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel16.Location = new System.Drawing.Point(468, 4);
            this.customLabel16.Name = "customLabel16";
            this.customLabel16.Size = new System.Drawing.Size(58, 15);
            this.customLabel16.TabIndex = 847;
            this.customLabel16.Text = "Net Sales";
            // 
            // txt_SalesAllowance
            // 
            this.txt_SalesAllowance.BackColor = System.Drawing.Color.White;
            this.txt_SalesAllowance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SalesAllowance.Location = new System.Drawing.Point(107, 22);
            this.txt_SalesAllowance.Name = "txt_SalesAllowance";
            this.txt_SalesAllowance.ReadOnly = true;
            this.txt_SalesAllowance.Size = new System.Drawing.Size(100, 23);
            this.txt_SalesAllowance.TabIndex = 836;
            this.txt_SalesAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_GAGrossSales
            // 
            this.txt_GAGrossSales.BackColor = System.Drawing.Color.White;
            this.txt_GAGrossSales.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GAGrossSales.Location = new System.Drawing.Point(1, 22);
            this.txt_GAGrossSales.Name = "txt_GAGrossSales";
            this.txt_GAGrossSales.ReadOnly = true;
            this.txt_GAGrossSales.Size = new System.Drawing.Size(100, 23);
            this.txt_GAGrossSales.TabIndex = 828;
            this.txt_GAGrossSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel10
            // 
            this.customLabel10.AutoSize = true;
            this.customLabel10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel10.Location = new System.Drawing.Point(114, 4);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.Size = new System.Drawing.Size(93, 15);
            this.customLabel10.TabIndex = 835;
            this.customLabel10.Text = "Sales Allowance";
            // 
            // pn_Sales
            // 
            this.pn_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Sales.Controls.Add(this.txt_SACredit);
            this.pn_Sales.Controls.Add(this.txt_SAGrossSales);
            this.pn_Sales.Controls.Add(this.txt_SACOGS);
            this.pn_Sales.Controls.Add(this.customLabel13);
            this.pn_Sales.Controls.Add(this.customLabel14);
            this.pn_Sales.Controls.Add(this.customLabel20);
            this.pn_Sales.Controls.Add(this.txt_SANetSales);
            this.pn_Sales.Controls.Add(this.txt_SAReturnCredit);
            this.pn_Sales.Controls.Add(this.customLabel22);
            this.pn_Sales.Controls.Add(this.customLabel23);
            this.pn_Sales.Controls.Add(this.customLabel24);
            this.pn_Sales.Controls.Add(this.txt_SATermCredit);
            this.pn_Sales.Controls.Add(this.txt_SAPromo);
            this.pn_Sales.Controls.Add(this.customLabel25);
            this.pn_Sales.Location = new System.Drawing.Point(1125, 828);
            this.pn_Sales.Name = "pn_Sales";
            this.pn_Sales.Size = new System.Drawing.Size(738, 48);
            this.pn_Sales.TabIndex = 855;
            // 
            // txt_SACredit
            // 
            this.txt_SACredit.BackColor = System.Drawing.Color.White;
            this.txt_SACredit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SACredit.Location = new System.Drawing.Point(214, 22);
            this.txt_SACredit.Name = "txt_SACredit";
            this.txt_SACredit.ReadOnly = true;
            this.txt_SACredit.Size = new System.Drawing.Size(100, 23);
            this.txt_SACredit.TabIndex = 834;
            this.txt_SACredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SAGrossSales
            // 
            this.txt_SAGrossSales.BackColor = System.Drawing.Color.White;
            this.txt_SAGrossSales.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SAGrossSales.Location = new System.Drawing.Point(2, 22);
            this.txt_SAGrossSales.Name = "txt_SAGrossSales";
            this.txt_SAGrossSales.ReadOnly = true;
            this.txt_SAGrossSales.Size = new System.Drawing.Size(100, 23);
            this.txt_SAGrossSales.TabIndex = 828;
            this.txt_SAGrossSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SACOGS
            // 
            this.txt_SACOGS.BackColor = System.Drawing.Color.White;
            this.txt_SACOGS.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SACOGS.Location = new System.Drawing.Point(638, 22);
            this.txt_SACOGS.Name = "txt_SACOGS";
            this.txt_SACOGS.ReadOnly = true;
            this.txt_SACOGS.Size = new System.Drawing.Size(100, 23);
            this.txt_SACOGS.TabIndex = 851;
            this.txt_SACOGS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel13
            // 
            this.customLabel13.AutoSize = true;
            this.customLabel13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel13.Location = new System.Drawing.Point(341, 4);
            this.customLabel13.Name = "customLabel13";
            this.customLabel13.Size = new System.Drawing.Size(82, 15);
            this.customLabel13.TabIndex = 837;
            this.customLabel13.Text = "Return Credit";
            // 
            // customLabel14
            // 
            this.customLabel14.AutoSize = true;
            this.customLabel14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel14.Location = new System.Drawing.Point(700, 4);
            this.customLabel14.Name = "customLabel14";
            this.customLabel14.Size = new System.Drawing.Size(37, 15);
            this.customLabel14.TabIndex = 849;
            this.customLabel14.Text = "COGS";
            // 
            // customLabel20
            // 
            this.customLabel20.AutoSize = true;
            this.customLabel20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel20.Location = new System.Drawing.Point(31, 4);
            this.customLabel20.Name = "customLabel20";
            this.customLabel20.Size = new System.Drawing.Size(67, 15);
            this.customLabel20.TabIndex = 827;
            this.customLabel20.Text = "Gross Sales";
            // 
            // txt_SANetSales
            // 
            this.txt_SANetSales.BackColor = System.Drawing.Color.White;
            this.txt_SANetSales.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SANetSales.Location = new System.Drawing.Point(532, 22);
            this.txt_SANetSales.Name = "txt_SANetSales";
            this.txt_SANetSales.ReadOnly = true;
            this.txt_SANetSales.Size = new System.Drawing.Size(100, 23);
            this.txt_SANetSales.TabIndex = 848;
            this.txt_SANetSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SAReturnCredit
            // 
            this.txt_SAReturnCredit.BackColor = System.Drawing.Color.White;
            this.txt_SAReturnCredit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SAReturnCredit.Location = new System.Drawing.Point(320, 22);
            this.txt_SAReturnCredit.Name = "txt_SAReturnCredit";
            this.txt_SAReturnCredit.ReadOnly = true;
            this.txt_SAReturnCredit.Size = new System.Drawing.Size(100, 23);
            this.txt_SAReturnCredit.TabIndex = 838;
            this.txt_SAReturnCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel22
            // 
            this.customLabel22.AutoSize = true;
            this.customLabel22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel22.Location = new System.Drawing.Point(575, 5);
            this.customLabel22.Name = "customLabel22";
            this.customLabel22.Size = new System.Drawing.Size(58, 15);
            this.customLabel22.TabIndex = 847;
            this.customLabel22.Text = "Net Sales";
            // 
            // customLabel23
            // 
            this.customLabel23.AutoSize = true;
            this.customLabel23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel23.Location = new System.Drawing.Point(455, 4);
            this.customLabel23.Name = "customLabel23";
            this.customLabel23.Size = new System.Drawing.Size(72, 15);
            this.customLabel23.TabIndex = 841;
            this.customLabel23.Text = "Term Credit";
            // 
            // customLabel24
            // 
            this.customLabel24.AutoSize = true;
            this.customLabel24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel24.Location = new System.Drawing.Point(144, 4);
            this.customLabel24.Name = "customLabel24";
            this.customLabel24.Size = new System.Drawing.Size(66, 15);
            this.customLabel24.TabIndex = 829;
            this.customLabel24.Text = "Promotion";
            // 
            // txt_SATermCredit
            // 
            this.txt_SATermCredit.BackColor = System.Drawing.Color.White;
            this.txt_SATermCredit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SATermCredit.Location = new System.Drawing.Point(426, 22);
            this.txt_SATermCredit.Name = "txt_SATermCredit";
            this.txt_SATermCredit.ReadOnly = true;
            this.txt_SATermCredit.Size = new System.Drawing.Size(100, 23);
            this.txt_SATermCredit.TabIndex = 842;
            this.txt_SATermCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_SAPromo
            // 
            this.txt_SAPromo.BackColor = System.Drawing.Color.White;
            this.txt_SAPromo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SAPromo.Location = new System.Drawing.Point(108, 22);
            this.txt_SAPromo.Name = "txt_SAPromo";
            this.txt_SAPromo.ReadOnly = true;
            this.txt_SAPromo.Size = new System.Drawing.Size(100, 23);
            this.txt_SAPromo.TabIndex = 830;
            this.txt_SAPromo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel25
            // 
            this.customLabel25.AutoSize = true;
            this.customLabel25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel25.Location = new System.Drawing.Point(274, 4);
            this.customLabel25.Name = "customLabel25";
            this.customLabel25.Size = new System.Drawing.Size(41, 15);
            this.customLabel25.TabIndex = 833;
            this.customLabel25.Text = "Credit";
            // 
            // rdb_AccountingVersion
            // 
            this.rdb_AccountingVersion.Controls.Add(this.rdb_SalesVersion);
            this.rdb_AccountingVersion.Controls.Add(this.rdb_GAVersion);
            this.rdb_AccountingVersion.Location = new System.Drawing.Point(346, 8);
            this.rdb_AccountingVersion.Name = "rdb_AccountingVersion";
            this.rdb_AccountingVersion.Size = new System.Drawing.Size(177, 54);
            this.rdb_AccountingVersion.TabIndex = 857;
            this.rdb_AccountingVersion.TabStop = false;
            // 
            // rdb_SalesVersion
            // 
            this.rdb_SalesVersion.AutoSize = true;
            this.rdb_SalesVersion.Checked = true;
            this.rdb_SalesVersion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_SalesVersion.Location = new System.Drawing.Point(16, 21);
            this.rdb_SalesVersion.Name = "rdb_SalesVersion";
            this.rdb_SalesVersion.Size = new System.Drawing.Size(52, 19);
            this.rdb_SalesVersion.TabIndex = 824;
            this.rdb_SalesVersion.TabStop = true;
            this.rdb_SalesVersion.Text = "Sales";
            this.rdb_SalesVersion.UseVisualStyleBackColor = true;
            this.rdb_SalesVersion.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdb_GAVersion
            // 
            this.rdb_GAVersion.AutoSize = true;
            this.rdb_GAVersion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_GAVersion.Location = new System.Drawing.Point(79, 21);
            this.rdb_GAVersion.Name = "rdb_GAVersion";
            this.rdb_GAVersion.Size = new System.Drawing.Size(85, 19);
            this.rdb_GAVersion.TabIndex = 825;
            this.rdb_GAVersion.Text = "Accounting";
            this.rdb_GAVersion.UseVisualStyleBackColor = true;
            this.rdb_GAVersion.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // customLabel9
            // 
            this.customLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel9.AutoSize = true;
            this.customLabel9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.Location = new System.Drawing.Point(1272, 40);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(94, 15);
            this.customLabel9.TabIndex = 853;
            this.customLabel9.Text = "Invoice Number";
            // 
            // customLabel8
            // 
            this.customLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel8.AutoSize = true;
            this.customLabel8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.Location = new System.Drawing.Point(1176, 40);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(27, 15);
            this.customLabel8.TabIndex = 851;
            this.customLabel8.Text = "REP";
            // 
            // grid_City
            // 
            this.grid_City.AllowUserToAddRows = false;
            this.grid_City.AllowUserToDeleteRows = false;
            this.grid_City.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_City.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_City.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_City.BackgroundColor = System.Drawing.Color.White;
            this.grid_City.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_City.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_City.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_City.EnableHeadersVisualStyles = false;
            this.grid_City.GridColor = System.Drawing.Color.LightGray;
            this.grid_City.Location = new System.Drawing.Point(95, 12);
            this.grid_City.MultiSelect = false;
            this.grid_City.Name = "grid_City";
            this.grid_City.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_City.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_City.RowHeadersVisible = false;
            this.grid_City.RowTemplate.Height = 19;
            this.grid_City.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_City.Size = new System.Drawing.Size(245, 816);
            this.grid_City.StandardTab = true;
            this.grid_City.TabIndex = 850;
            this.grid_City.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_ColumnHeaderMouseClick);
            // 
            // grid_State
            // 
            this.grid_State.AllowUserToAddRows = false;
            this.grid_State.AllowUserToDeleteRows = false;
            this.grid_State.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_State.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_State.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_State.BackgroundColor = System.Drawing.Color.White;
            this.grid_State.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_State.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_State.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_State.EnableHeadersVisualStyles = false;
            this.grid_State.GridColor = System.Drawing.Color.LightGray;
            this.grid_State.Location = new System.Drawing.Point(12, 12);
            this.grid_State.MultiSelect = false;
            this.grid_State.Name = "grid_State";
            this.grid_State.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_State.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_State.RowHeadersVisible = false;
            this.grid_State.RowTemplate.Height = 19;
            this.grid_State.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_State.Size = new System.Drawing.Size(77, 816);
            this.grid_State.StandardTab = true;
            this.grid_State.TabIndex = 849;
            this.grid_State.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_ColumnHeaderMouseClick);
            // 
            // customLabel7
            // 
            this.customLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel7.AutoSize = true;
            this.customLabel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.Location = new System.Drawing.Point(976, 9);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(75, 15);
            this.customLabel7.TabIndex = 847;
            this.customLabel7.Text = "Customer ID";
            // 
            // customLabel19
            // 
            this.customLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel19.AutoSize = true;
            this.customLabel19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel19.Location = new System.Drawing.Point(1499, 39);
            this.customLabel19.Name = "customLabel19";
            this.customLabel19.Size = new System.Drawing.Size(19, 15);
            this.customLabel19.TabIndex = 827;
            this.customLabel19.Text = "To";
            // 
            // customLabel18
            // 
            this.customLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel18.AutoSize = true;
            this.customLabel18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel18.Location = new System.Drawing.Point(1484, 9);
            this.customLabel18.Name = "customLabel18";
            this.customLabel18.Size = new System.Drawing.Size(36, 15);
            this.customLabel18.TabIndex = 824;
            this.customLabel18.Text = "From";
            // 
            // grid_salesDetailReport
            // 
            this.grid_salesDetailReport.AllowUserToAddRows = false;
            this.grid_salesDetailReport.AllowUserToDeleteRows = false;
            this.grid_salesDetailReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_salesDetailReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_salesDetailReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_salesDetailReport.BackgroundColor = System.Drawing.Color.White;
            this.grid_salesDetailReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_salesDetailReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_salesDetailReport.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid_salesDetailReport.EnableHeadersVisualStyles = false;
            this.grid_salesDetailReport.GridColor = System.Drawing.Color.LightGray;
            this.grid_salesDetailReport.Location = new System.Drawing.Point(346, 64);
            this.grid_salesDetailReport.MultiSelect = false;
            this.grid_salesDetailReport.Name = "grid_salesDetailReport";
            this.grid_salesDetailReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_salesDetailReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid_salesDetailReport.RowHeadersVisible = false;
            this.grid_salesDetailReport.RowTemplate.Height = 19;
            this.grid_salesDetailReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_salesDetailReport.Size = new System.Drawing.Size(1517, 764);
            this.grid_salesDetailReport.StandardTab = true;
            this.grid_salesDetailReport.TabIndex = 822;
            // 
            // lbl_RowCount
            // 
            this.lbl_RowCount.AutoSize = true;
            this.lbl_RowCount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RowCount.Location = new System.Drawing.Point(529, 43);
            this.lbl_RowCount.Name = "lbl_RowCount";
            this.lbl_RowCount.Size = new System.Drawing.Size(84, 15);
            this.lbl_RowCount.TabIndex = 858;
            this.lbl_RowCount.Text = "Row Count : 0";
            // 
            // txt_customerName
            // 
            this.txt_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_customerName.BackColor = System.Drawing.Color.White;
            this.txt_customerName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerName.Location = new System.Drawing.Point(1302, 6);
            this.txt_customerName.MaxLength = 50;
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(176, 23);
            this.txt_customerName.TabIndex = 865;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(1199, 9);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(97, 15);
            this.customLabel1.TabIndex = 864;
            this.customLabel1.Text = "Customer Name";
            // 
            // SalesbyCustomerDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 877);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.lbl_RowCount);
            this.Controls.Add(this.rdb_AccountingVersion);
            this.Controls.Add(this.pn_GA);
            this.Controls.Add(this.pn_Sales);
            this.Controls.Add(this.txt_InvNumber);
            this.Controls.Add(this.customLabel9);
            this.Controls.Add(this.txt_REP);
            this.Controls.Add(this.customLabel8);
            this.Controls.Add(this.grid_City);
            this.Controls.Add(this.grid_State);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.customLabel7);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.customLabel19);
            this.Controls.Add(this.customLabel18);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.grid_salesDetailReport);
            this.MinimumSize = new System.Drawing.Size(958, 450);
            this.Name = "SalesbyCustomerDetailReport";
            this.Text = "Sales by Customer Detail Report";
            this.Load += new System.EventHandler(this.SalesbyCustomerDetailReport_Load);
            this.pn_GA.ResumeLayout(false);
            this.pn_GA.PerformLayout();
            this.pn_Sales.ResumeLayout(false);
            this.pn_Sales.PerformLayout();
            this.rdb_AccountingVersion.ResumeLayout(false);
            this.rdb_AccountingVersion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_City)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_State)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesDetailReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_export;
        private Tools.CustomLabel customLabel19;
        private Tools.CustomLabel customLabel18;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btn_refresh;
        private CustomGrid grid_salesDetailReport;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private Tools.CustomLabel customLabel7;
        private CustomGrid grid_State;
        private CustomGrid grid_City;
        private System.Windows.Forms.TextBox txt_REP;
        private Tools.CustomLabel customLabel8;
        private System.Windows.Forms.TextBox txt_InvNumber;
        private Tools.CustomLabel customLabel9;
        private System.Windows.Forms.Panel pn_GA;
        private System.Windows.Forms.TextBox txt_SalesDiscount;
        private System.Windows.Forms.TextBox txt_GANetSales;
        private Tools.CustomLabel customLabel11;
        private Tools.CustomLabel customLabel26;
        private Tools.CustomLabel customLabel15;
        private System.Windows.Forms.TextBox txt_GAReturnCredit;
        private Tools.CustomLabel customLabel16;
        private System.Windows.Forms.TextBox txt_SalesAllowance;
        private System.Windows.Forms.TextBox txt_GAGrossSales;
        private Tools.CustomLabel customLabel10;
        private System.Windows.Forms.Panel pn_Sales;
        private System.Windows.Forms.TextBox txt_SACredit;
        private System.Windows.Forms.TextBox txt_SAGrossSales;
        private System.Windows.Forms.TextBox txt_SACOGS;
        private Tools.CustomLabel customLabel13;
        private Tools.CustomLabel customLabel14;
        private Tools.CustomLabel customLabel20;
        private System.Windows.Forms.TextBox txt_SANetSales;
        private System.Windows.Forms.TextBox txt_SAReturnCredit;
        private Tools.CustomLabel customLabel22;
        private Tools.CustomLabel customLabel23;
        private Tools.CustomLabel customLabel24;
        private System.Windows.Forms.TextBox txt_SATermCredit;
        private System.Windows.Forms.TextBox txt_SAPromo;
        private Tools.CustomLabel customLabel25;
        private System.Windows.Forms.GroupBox rdb_AccountingVersion;
        private System.Windows.Forms.RadioButton rdb_SalesVersion;
        private System.Windows.Forms.RadioButton rdb_GAVersion;
        private System.Windows.Forms.Label lbl_RowCount;
        private System.Windows.Forms.TextBox txt_customerName;
        private Tools.CustomLabel customLabel1;
    }
}