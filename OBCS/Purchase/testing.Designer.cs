
namespace OBCS.Purchase
{
    partial class testing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerFromDate = new OBCS.Purchase.CustomDateTimePicker();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.cbo_SupplierID = new OBCS.Tools.CustomComboBox();
            this.cbo_poOpenStatus = new OBCS.Tools.CustomComboBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_checkNo = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.dateTimePickerAsOf = new OBCS.Purchase.CustomDateTimePicker();
            this.grid_AR = new OBCS.CustomGrid();
            this.lblStatus = new OBCS.Tools.CustomLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_AR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(616, 56);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(616, 114);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(314, 23);
            this.progressBar.Step = 20;
            this.progressBar.TabIndex = 5;
            // 
            // customLabel6
            // 
            this.customLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel6.Location = new System.Drawing.Point(59, 34);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(38, 17);
            this.customLabel6.TabIndex = 678;
            this.customLabel6.Text = "From";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerFromDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerFromDate.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFromDate.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerFromDate.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(62, 55);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerFromDate.TabIndex = 677;
            // 
            // customLabel5
            // 
            this.customLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(157, 34);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(22, 17);
            this.customLabel5.TabIndex = 676;
            this.customLabel5.Text = "To";
            // 
            // cbo_SupplierID
            // 
            this.cbo_SupplierID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_SupplierID.BackColor = System.Drawing.Color.White;
            this.cbo_SupplierID.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_SupplierID.FormattingEnabled = true;
            this.cbo_SupplierID.Location = new System.Drawing.Point(258, 53);
            this.cbo_SupplierID.Name = "cbo_SupplierID";
            this.cbo_SupplierID.Size = new System.Drawing.Size(134, 23);
            this.cbo_SupplierID.TabIndex = 669;
            // 
            // cbo_poOpenStatus
            // 
            this.cbo_poOpenStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_poOpenStatus.BackColor = System.Drawing.Color.White;
            this.cbo_poOpenStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_poOpenStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_poOpenStatus.FormattingEnabled = true;
            this.cbo_poOpenStatus.Location = new System.Drawing.Point(513, 53);
            this.cbo_poOpenStatus.Name = "cbo_poOpenStatus";
            this.cbo_poOpenStatus.Size = new System.Drawing.Size(97, 23);
            this.cbo_poOpenStatus.TabIndex = 671;
            // 
            // customLabel3
            // 
            this.customLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel3.Location = new System.Drawing.Point(510, 34);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(100, 17);
            this.customLabel3.TabIndex = 675;
            this.customLabel3.Text = "SO Open Status";
            // 
            // customLabel2
            // 
            this.customLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(395, 34);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(94, 17);
            this.customLabel2.TabIndex = 674;
            this.customLabel2.Text = "Check Number";
            // 
            // txt_checkNo
            // 
            this.txt_checkNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_checkNo.BackColor = System.Drawing.Color.White;
            this.txt_checkNo.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_checkNo.Location = new System.Drawing.Point(398, 55);
            this.txt_checkNo.Name = "txt_checkNo";
            this.txt_checkNo.Size = new System.Drawing.Size(109, 21);
            this.txt_checkNo.TabIndex = 670;
            // 
            // customLabel1
            // 
            this.customLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.Location = new System.Drawing.Point(255, 34);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(73, 17);
            this.customLabel1.TabIndex = 673;
            this.customLabel1.Text = "Supplier ID";
            // 
            // dateTimePickerAsOf
            // 
            this.dateTimePickerAsOf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerAsOf.BackColor = System.Drawing.Color.White;
            this.dateTimePickerAsOf.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerAsOf.CustomFormat = " MM/dd/yyyy";
            this.dateTimePickerAsOf.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerAsOf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAsOf.Location = new System.Drawing.Point(160, 55);
            this.dateTimePickerAsOf.Name = "dateTimePickerAsOf";
            this.dateTimePickerAsOf.Size = new System.Drawing.Size(92, 21);
            this.dateTimePickerAsOf.TabIndex = 672;
            // 
            // grid_AR
            // 
            this.grid_AR.AllowUserToAddRows = false;
            this.grid_AR.AllowUserToDeleteRows = false;
            this.grid_AR.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_AR.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_AR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_AR.BackgroundColor = System.Drawing.Color.White;
            this.grid_AR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_AR.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_AR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_AR.DefaultCellStyle = dataGridViewCellStyle7;
            this.grid_AR.EnableHeadersVisualStyles = false;
            this.grid_AR.GridColor = System.Drawing.Color.LightGray;
            this.grid_AR.Location = new System.Drawing.Point(62, 85);
            this.grid_AR.MultiSelect = false;
            this.grid_AR.Name = "grid_AR";
            this.grid_AR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_AR.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_AR.RowHeadersVisible = false;
            this.grid_AR.RowTemplate.Height = 19;
            this.grid_AR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_AR.Size = new System.Drawing.Size(536, 101);
            this.grid_AR.StandardTab = true;
            this.grid_AR.TabIndex = 679;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(616, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 17);
            this.lblStatus.TabIndex = 680;
            this.lblStatus.Text = "SO Open Status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(616, 163);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(314, 23);
            this.progressBar1.TabIndex = 681;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 682;
            this.button1.Text = "drawing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(368, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 195);
            this.panel1.TabIndex = 683;
            // 
            // testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grid_AR);
            this.Controls.Add(this.customLabel6);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.customLabel5);
            this.Controls.Add(this.cbo_SupplierID);
            this.Controls.Add(this.cbo_poOpenStatus);
            this.Controls.Add(this.customLabel3);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_checkNo);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.dateTimePickerAsOf);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Name = "testing";
            this.Text = "testing";
            ((System.ComponentModel.ISupportInitialize)(this.grid_AR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar;
        private Tools.CustomLabel customLabel6;
        private CustomDateTimePicker dateTimePickerFromDate;
        private Tools.CustomLabel customLabel5;
        private Tools.CustomComboBox cbo_SupplierID;
        private Tools.CustomComboBox cbo_poOpenStatus;
        private Tools.CustomLabel customLabel3;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_checkNo;
        private Tools.CustomLabel customLabel1;
        private CustomDateTimePicker dateTimePickerAsOf;
        private CustomGrid grid_AR;
        private Tools.CustomLabel lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}