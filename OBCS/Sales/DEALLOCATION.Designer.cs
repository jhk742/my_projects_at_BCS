namespace OBCS.Sales
{
    partial class DEALLOCATION
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
            this.rbtn_all = new System.Windows.Forms.RadioButton();
            this.rbtn_invoice = new System.Windows.Forms.RadioButton();
            this.rbtn_noInvoice = new System.Windows.Forms.RadioButton();
            this.txt_DeliveryNumber = new OBCS.CustomTextBox();
            this.customLabel2 = new OBCS.Tools.CustomLabel();
            this.txt_CustomerID = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.grid_deallocation = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_deallocation)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_all
            // 
            this.rbtn_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_all.AutoSize = true;
            this.rbtn_all.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_all.Location = new System.Drawing.Point(924, 7);
            this.rbtn_all.Name = "rbtn_all";
            this.rbtn_all.Size = new System.Drawing.Size(43, 22);
            this.rbtn_all.TabIndex = 1;
            this.rbtn_all.Text = "All";
            this.rbtn_all.UseVisualStyleBackColor = true;
            this.rbtn_all.CheckedChanged += new System.EventHandler(this.rbtn_all_CheckedChanged);
            // 
            // rbtn_invoice
            // 
            this.rbtn_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_invoice.AutoSize = true;
            this.rbtn_invoice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_invoice.Location = new System.Drawing.Point(972, 7);
            this.rbtn_invoice.Name = "rbtn_invoice";
            this.rbtn_invoice.Size = new System.Drawing.Size(71, 22);
            this.rbtn_invoice.TabIndex = 2;
            this.rbtn_invoice.Text = "Invoice";
            this.rbtn_invoice.UseVisualStyleBackColor = true;
            this.rbtn_invoice.CheckedChanged += new System.EventHandler(this.rbtn_invoice_CheckedChanged);
            // 
            // rbtn_noInvoice
            // 
            this.rbtn_noInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtn_noInvoice.AutoSize = true;
            this.rbtn_noInvoice.Checked = true;
            this.rbtn_noInvoice.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_noInvoice.Location = new System.Drawing.Point(1049, 7);
            this.rbtn_noInvoice.Name = "rbtn_noInvoice";
            this.rbtn_noInvoice.Size = new System.Drawing.Size(92, 22);
            this.rbtn_noInvoice.TabIndex = 3;
            this.rbtn_noInvoice.TabStop = true;
            this.rbtn_noInvoice.Text = "No Invoice";
            this.rbtn_noInvoice.UseVisualStyleBackColor = true;
            this.rbtn_noInvoice.CheckedChanged += new System.EventHandler(this.rbtn_noInvoice_CheckedChanged);
            // 
            // txt_DeliveryNumber
            // 
            this.txt_DeliveryNumber.BackColor = System.Drawing.Color.White;
            this.txt_DeliveryNumber.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_DeliveryNumber.Location = new System.Drawing.Point(359, 8);
            this.txt_DeliveryNumber.Name = "txt_DeliveryNumber";
            this.txt_DeliveryNumber.Size = new System.Drawing.Size(117, 21);
            this.txt_DeliveryNumber.TabIndex = 11;
            this.txt_DeliveryNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.Location = new System.Drawing.Point(239, 9);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(114, 18);
            this.customLabel2.TabIndex = 10;
            this.customLabel2.Text = "Delivery Number";
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.BackColor = System.Drawing.Color.White;
            this.txt_CustomerID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_CustomerID.Location = new System.Drawing.Point(99, 8);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.Size = new System.Drawing.Size(121, 21);
            this.txt_CustomerID.TabIndex = 9;
            this.txt_CustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(12, 9);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(84, 18);
            this.customLabel1.TabIndex = 8;
            this.customLabel1.Text = "Customer ID";
            // 
            // grid_deallocation
            // 
            this.grid_deallocation.AllowUserToAddRows = false;
            this.grid_deallocation.AllowUserToDeleteRows = false;
            this.grid_deallocation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_deallocation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_deallocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_deallocation.BackgroundColor = System.Drawing.Color.White;
            this.grid_deallocation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_deallocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_deallocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_deallocation.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_deallocation.EnableHeadersVisualStyles = false;
            this.grid_deallocation.GridColor = System.Drawing.Color.LightGray;
            this.grid_deallocation.Location = new System.Drawing.Point(12, 35);
            this.grid_deallocation.MultiSelect = false;
            this.grid_deallocation.Name = "grid_deallocation";
            this.grid_deallocation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_deallocation.RowHeadersVisible = false;
            this.grid_deallocation.RowTemplate.Height = 19;
            this.grid_deallocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_deallocation.Size = new System.Drawing.Size(1129, 643);
            this.grid_deallocation.StandardTab = true;
            this.grid_deallocation.TabIndex = 0;
            this.grid_deallocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_deallocation_CellClick);
            // 
            // DEALLOCATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1153, 690);
            this.Controls.Add(this.txt_DeliveryNumber);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.txt_CustomerID);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.rbtn_noInvoice);
            this.Controls.Add(this.rbtn_invoice);
            this.Controls.Add(this.rbtn_all);
            this.Controls.Add(this.grid_deallocation);
            this.Name = "DEALLOCATION";
            this.Text = "Deallocation";
            ((System.ComponentModel.ISupportInitialize)(this.grid_deallocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGrid grid_deallocation;
        private System.Windows.Forms.RadioButton rbtn_all;
        private System.Windows.Forms.RadioButton rbtn_invoice;
        private System.Windows.Forms.RadioButton rbtn_noInvoice;
        private CustomTextBox txt_DeliveryNumber;
        private Tools.CustomLabel customLabel2;
        private CustomTextBox txt_CustomerID;
        private Tools.CustomLabel customLabel1;
    }
}