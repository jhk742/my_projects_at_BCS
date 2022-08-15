namespace OBCS.Sales
{
    partial class SalesARbyRepReport
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
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.grid_salesReport = new OBCS.CustomGrid();
            this.cbx_SalesRep = new OBCS.Tools.CustomComboBox();
            this.customLabel4 = new OBCS.Tools.CustomLabel();
            this.txt_YearGoal = new OBCS.CustomTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_Cumulative = new OBCS.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CumulativeRatio = new OBCS.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesReport)).BeginInit();
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
            this.btn_export.Location = new System.Drawing.Point(1581, 12);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(104, 39);
            this.btn_export.TabIndex = 662;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1471, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(104, 39);
            this.btn_refresh.TabIndex = 657;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // grid_salesReport
            // 
            this.grid_salesReport.AllowUserToAddRows = false;
            this.grid_salesReport.AllowUserToDeleteRows = false;
            this.grid_salesReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_salesReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_salesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_salesReport.BackgroundColor = System.Drawing.Color.White;
            this.grid_salesReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_salesReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_salesReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_salesReport.EnableHeadersVisualStyles = false;
            this.grid_salesReport.GridColor = System.Drawing.Color.LightGray;
            this.grid_salesReport.Location = new System.Drawing.Point(12, 57);
            this.grid_salesReport.MultiSelect = false;
            this.grid_salesReport.Name = "grid_salesReport";
            this.grid_salesReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_salesReport.RowHeadersVisible = false;
            this.grid_salesReport.RowTemplate.Height = 19;
            this.grid_salesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_salesReport.Size = new System.Drawing.Size(1673, 730);
            this.grid_salesReport.StandardTab = true;
            this.grid_salesReport.TabIndex = 656;
            this.grid_salesReport.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_salesReport_DataBindingComplete);
            // 
            // cbx_SalesRep
            // 
            this.cbx_SalesRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_SalesRep.BackColor = System.Drawing.Color.White;
            this.cbx_SalesRep.Font = new System.Drawing.Font("Arial", 9F);
            this.cbx_SalesRep.FormattingEnabled = true;
            this.cbx_SalesRep.Location = new System.Drawing.Point(1402, 28);
            this.cbx_SalesRep.Name = "cbx_SalesRep";
            this.cbx_SalesRep.Size = new System.Drawing.Size(63, 23);
            this.cbx_SalesRep.TabIndex = 664;
            // 
            // customLabel4
            // 
            this.customLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.Location = new System.Drawing.Point(1368, 32);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(28, 15);
            this.customLabel4.TabIndex = 663;
            this.customLabel4.Text = "Rep";
            // 
            // txt_YearGoal
            // 
            this.txt_YearGoal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_YearGoal.BackColor = System.Drawing.Color.White;
            this.txt_YearGoal.Enabled = false;
            this.txt_YearGoal.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_YearGoal.Location = new System.Drawing.Point(1319, 809);
            this.txt_YearGoal.Name = "txt_YearGoal";
            this.txt_YearGoal.ReadOnly = true;
            this.txt_YearGoal.Size = new System.Drawing.Size(149, 21);
            this.txt_YearGoal.TabIndex = 750;
            this.txt_YearGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1366, 791);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 15);
            this.label22.TabIndex = 751;
            this.label22.Text = "Year Goal";
            // 
            // txt_Cumulative
            // 
            this.txt_Cumulative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cumulative.BackColor = System.Drawing.Color.White;
            this.txt_Cumulative.Enabled = false;
            this.txt_Cumulative.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_Cumulative.Location = new System.Drawing.Point(1474, 809);
            this.txt_Cumulative.Name = "txt_Cumulative";
            this.txt_Cumulative.ReadOnly = true;
            this.txt_Cumulative.Size = new System.Drawing.Size(149, 21);
            this.txt_Cumulative.TabIndex = 752;
            this.txt_Cumulative.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1491, 791);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 753;
            this.label1.Text = "Cumulative Amount";
            // 
            // txt_CumulativeRatio
            // 
            this.txt_CumulativeRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CumulativeRatio.BackColor = System.Drawing.Color.White;
            this.txt_CumulativeRatio.Enabled = false;
            this.txt_CumulativeRatio.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_CumulativeRatio.Location = new System.Drawing.Point(1629, 809);
            this.txt_CumulativeRatio.Name = "txt_CumulativeRatio";
            this.txt_CumulativeRatio.ReadOnly = true;
            this.txt_CumulativeRatio.Size = new System.Drawing.Size(56, 21);
            this.txt_CumulativeRatio.TabIndex = 754;
            this.txt_CumulativeRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1648, 791);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 755;
            this.label2.Text = "%";
            // 
            // SalesARbyRepReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 842);
            this.Controls.Add(this.txt_CumulativeRatio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Cumulative);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_YearGoal);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cbx_SalesRep);
            this.Controls.Add(this.customLabel4);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.grid_salesReport);
            this.Name = "SalesARbyRepReport";
            this.Text = "Sales Performance Report";
            ((System.ComponentModel.ISupportInitialize)(this.grid_salesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_refresh;
        private CustomGrid grid_salesReport;
        private Tools.CustomComboBox cbx_SalesRep;
        private Tools.CustomLabel customLabel4;
        private CustomTextBox txt_YearGoal;
        private System.Windows.Forms.Label label22;
        private CustomTextBox txt_Cumulative;
        private System.Windows.Forms.Label label1;
        private CustomTextBox txt_CumulativeRatio;
        private System.Windows.Forms.Label label2;
    }
}