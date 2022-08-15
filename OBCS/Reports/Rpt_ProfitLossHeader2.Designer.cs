namespace OBCS.Reports
{
    partial class Rpt_ProfitLossHeader2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_ProfitAndLossReport_HeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfitAndLossHeader = new OBCS.Reports.ProfitAndLossHeader();
            this.gbx_Info = new System.Windows.Forms.GroupBox();
            this.btn_fresh = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new OBCS.Purchase.CustomDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new OBCS.Purchase.CustomDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_company = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ProfitAndLossReport_HeaderTableAdapter = new OBCS.Reports.ProfitAndLossHeaderTableAdapters.sp_ProfitAndLossReport_HeaderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ProfitAndLossReport_HeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitAndLossHeader)).BeginInit();
            this.gbx_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_ProfitAndLossReport_HeaderBindingSource
            // 
            this.sp_ProfitAndLossReport_HeaderBindingSource.DataMember = "sp_ProfitAndLossReport_Header";
            this.sp_ProfitAndLossReport_HeaderBindingSource.DataSource = this.ProfitAndLossHeader;
            // 
            // ProfitAndLossHeader
            // 
            this.ProfitAndLossHeader.DataSetName = "ProfitAndLossHeader";
            this.ProfitAndLossHeader.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbx_Info
            // 
            this.gbx_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_Info.Controls.Add(this.btn_fresh);
            this.gbx_Info.Controls.Add(this.dateTimePicker2);
            this.gbx_Info.Controls.Add(this.label4);
            this.gbx_Info.Controls.Add(this.dateTimePicker1);
            this.gbx_Info.Controls.Add(this.label3);
            this.gbx_Info.Controls.Add(this.comboBox4);
            this.gbx_Info.Controls.Add(this.label2);
            this.gbx_Info.Controls.Add(this.cbo_company);
            this.gbx_Info.Controls.Add(this.label1);
            this.gbx_Info.Location = new System.Drawing.Point(12, 5);
            this.gbx_Info.Name = "gbx_Info";
            this.gbx_Info.Size = new System.Drawing.Size(659, 70);
            this.gbx_Info.TabIndex = 10;
            this.gbx_Info.TabStop = false;
            // 
            // btn_fresh
            // 
            this.btn_fresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_fresh.FlatAppearance.BorderSize = 0;
            this.btn_fresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fresh.ForeColor = System.Drawing.Color.White;
            this.btn_fresh.Location = new System.Drawing.Point(572, 11);
            this.btn_fresh.Name = "btn_fresh";
            this.btn_fresh.Size = new System.Drawing.Size(81, 49);
            this.btn_fresh.TabIndex = 719;
            this.btn_fresh.Text = "Refresh";
            this.btn_fresh.UseVisualStyleBackColor = false;
            this.btn_fresh.Click += new System.EventHandler(this.btn_fresh_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.BackColor = System.Drawing.Color.White;
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(479, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(87, 21);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.BackColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.CustomFormat = " MM/dd/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(479, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 21);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(74, 40);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(275, 23);
            this.comboBox4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // cbo_company
            // 
            this.cbo_company.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.cbo_company.FormattingEnabled = true;
            this.cbo_company.Location = new System.Drawing.Point(74, 11);
            this.cbo_company.Name = "cbo_company";
            this.cbo_company.Size = new System.Drawing.Size(194, 23);
            this.cbo_company.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "ProfitAndLossHeader";
            reportDataSource1.Value = this.sp_ProfitAndLossReport_HeaderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.ProfitAndLossHeader.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(659, 872);
            this.reportViewer1.TabIndex = 11;
            this.reportViewer1.Drillthrough += new Microsoft.Reporting.WinForms.DrillthroughEventHandler(this.reportViewer1_Drillthrough);
            // 
            // sp_ProfitAndLossReport_HeaderTableAdapter
            // 
            this.sp_ProfitAndLossReport_HeaderTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_ProfitLossHeader2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 965);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.gbx_Info);
            this.Name = "Rpt_ProfitLossHeader2";
            this.Text = "Profit & Loss Report";
            this.Load += new System.EventHandler(this.Rpt_ProfitLossHeader2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ProfitAndLossReport_HeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitAndLossHeader)).EndInit();
            this.gbx_Info.ResumeLayout(false);
            this.gbx_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Info;
        private System.Windows.Forms.Button btn_fresh;
        private Purchase.CustomDateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private Purchase.CustomDateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_company;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ProfitAndLossReport_HeaderBindingSource;
        private ProfitAndLossHeader ProfitAndLossHeader;
        private ProfitAndLossHeaderTableAdapters.sp_ProfitAndLossReport_HeaderTableAdapter sp_ProfitAndLossReport_HeaderTableAdapter;
    }
}