namespace OBCS.Reports
{
    partial class Rpt_PORDER
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_Rpt_PORDERDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PORDER = new OBCS.Reports.PORDER();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_Rpt_PORDERDETAILTableAdapter = new OBCS.Reports.PORDERTableAdapters.sp_Rpt_PORDERDETAILTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_attachedFile = new OBCS.CustomTextBox();
            this.customLabel6 = new OBCS.Tools.CustomLabel();
            this.customLabel5 = new OBCS.Tools.CustomLabel();
            this.txt_from = new OBCS.CustomTextBox();
            this.btn_email = new System.Windows.Forms.Button();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_subject = new OBCS.CustomTextBox();
            this.customLabel3 = new OBCS.Tools.CustomLabel();
            this.txt_body = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.customTextBox2 = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.txt_to = new OBCS.CustomTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_PORDERDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PORDER)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_Rpt_PORDERDETAILBindingSource
            // 
            this.sp_Rpt_PORDERDETAILBindingSource.DataMember = "sp_Rpt_PORDERDETAIL";
            this.sp_Rpt_PORDERDETAILBindingSource.DataSource = this.PORDER;
            // 
            // PORDER
            // 
            this.PORDER.DataSetName = "PORDER";
            this.PORDER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "PORDER";
            reportDataSource2.Value = this.sp_Rpt_PORDERDETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OBCS.Reports.PORDER.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1191, 638);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Rpt_PORDERDETAILTableAdapter
            // 
            this.sp_Rpt_PORDERDETAILTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_attachedFile);
            this.groupBox1.Controls.Add(this.customLabel6);
            this.groupBox1.Controls.Add(this.customLabel5);
            this.groupBox1.Controls.Add(this.txt_from);
            this.groupBox1.Controls.Add(this.btn_email);
            this.groupBox1.Controls.Add(this.customLabel4);
            this.groupBox1.Controls.Add(this.txt_subject);
            this.groupBox1.Controls.Add(this.customLabel3);
            this.groupBox1.Controls.Add(this.txt_body);
            this.groupBox1.Controls.Add(this.customLabel2);
            this.groupBox1.Controls.Add(this.customTextBox2);
            this.groupBox1.Controls.Add(this.customLabel1);
            this.groupBox1.Controls.Add(this.txt_to);
            this.groupBox1.Location = new System.Drawing.Point(626, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 403);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // txt_attachedFile
            // 
            this.txt_attachedFile.BackColor = System.Drawing.Color.White;
            this.txt_attachedFile.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_attachedFile.Location = new System.Drawing.Point(72, 366);
            this.txt_attachedFile.Name = "txt_attachedFile";
            this.txt_attachedFile.Size = new System.Drawing.Size(290, 21);
            this.txt_attachedFile.TabIndex = 8;
            this.txt_attachedFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel6.Location = new System.Drawing.Point(363, 368);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(35, 16);
            this.customLabel6.TabIndex = 11;
            this.customLabel6.Text = ".pdf";
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel5.Location = new System.Drawing.Point(22, 25);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(44, 16);
            this.customLabel5.TabIndex = 10;
            this.customLabel5.Text = "From";
            // 
            // txt_from
            // 
            this.txt_from.BackColor = System.Drawing.Color.White;
            this.txt_from.Enabled = false;
            this.txt_from.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_from.Location = new System.Drawing.Point(72, 23);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(407, 21);
            this.txt_from.TabIndex = 9;
            this.txt_from.TextChanged += new System.EventHandler(this.txt_from_TextChanged);
            // 
            // btn_email
            // 
            this.btn_email.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_email.Location = new System.Drawing.Point(404, 366);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(75, 21);
            this.btn_email.TabIndex = 1;
            this.btn_email.Text = "Send";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel4.Location = new System.Drawing.Point(32, 368);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(34, 16);
            this.customLabel4.TabIndex = 7;
            this.customLabel4.Text = "File";
            // 
            // txt_subject
            // 
            this.txt_subject.BackColor = System.Drawing.Color.White;
            this.txt_subject.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_subject.Location = new System.Drawing.Point(72, 128);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(407, 21);
            this.txt_subject.TabIndex = 6;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel3.Location = new System.Drawing.Point(6, 130);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(61, 16);
            this.customLabel3.TabIndex = 5;
            this.customLabel3.Text = "Subject";
            // 
            // txt_body
            // 
            this.txt_body.BackColor = System.Drawing.Color.White;
            this.txt_body.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_body.Location = new System.Drawing.Point(72, 153);
            this.txt_body.Multiline = true;
            this.txt_body.Name = "txt_body";
            this.txt_body.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_body.Size = new System.Drawing.Size(407, 207);
            this.txt_body.TabIndex = 4;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.Location = new System.Drawing.Point(38, 90);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(28, 16);
            this.customLabel2.TabIndex = 3;
            this.customLabel2.Text = "CC";
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.Color.White;
            this.customTextBox2.Enabled = false;
            this.customTextBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.customTextBox2.Location = new System.Drawing.Point(72, 72);
            this.customTextBox2.Multiline = true;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customTextBox2.Size = new System.Drawing.Size(407, 53);
            this.customTextBox2.TabIndex = 2;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.Location = new System.Drawing.Point(42, 50);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(24, 16);
            this.customLabel1.TabIndex = 1;
            this.customLabel1.Text = "To";
            // 
            // txt_to
            // 
            this.txt_to.BackColor = System.Drawing.Color.White;
            this.txt_to.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_to.Location = new System.Drawing.Point(72, 48);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(407, 21);
            this.txt_to.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.Location = new System.Drawing.Point(1128, 12);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send Email";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Rpt_PORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 691);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_PORDER";
            this.Text = "PO";
            this.Load += new System.EventHandler(this.Rpt_PORDER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_Rpt_PORDERDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PORDER)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_Rpt_PORDERDETAILBindingSource;
        private PORDER PORDER;
        private PORDERTableAdapters.sp_Rpt_PORDERDETAILTableAdapter sp_Rpt_PORDERDETAILTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomTextBox txt_attachedFile;
        private Tools.CustomLabel customLabel6;
        private Tools.CustomLabel customLabel5;
        private CustomTextBox txt_from;
        private System.Windows.Forms.Button btn_email;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_subject;
        private Tools.CustomLabel customLabel3;
        private CustomTextBox txt_body;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox customTextBox2;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox txt_to;
        private System.Windows.Forms.Button btn_send;
    }
}