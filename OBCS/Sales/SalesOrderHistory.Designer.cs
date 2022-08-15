namespace OBCS.Sales
{
    partial class SalesOrderHistory
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
            this.txt_customerID = new OBCS.CustomTextBox();
            this.customLabel17 = new OBCS.Tools.CustomLabel();
            this.txt_productID = new OBCS.CustomTextBox();
            this.customLabel1 = new OBCS.Tools.CustomLabel();
            this.tx = new OBCS.CustomTextBox();
            this.txt_productDesc = new OBCS.CustomTextBox();
            this.grid_OrderDetail = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_customerID
            // 
            this.txt_customerID.BackColor = System.Drawing.Color.White;
            this.txt_customerID.Enabled = false;
            this.txt_customerID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_customerID.Location = new System.Drawing.Point(12, 25);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(169, 21);
            this.txt_customerID.TabIndex = 647;
            this.txt_customerID.TabStop = false;
            // 
            // customLabel17
            // 
            this.customLabel17.AutoSize = true;
            this.customLabel17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel17.Location = new System.Drawing.Point(9, 7);
            this.customLabel17.Name = "customLabel17";
            this.customLabel17.Size = new System.Drawing.Size(46, 15);
            this.customLabel17.TabIndex = 646;
            this.customLabel17.Text = "Sold-to";
            // 
            // txt_productID
            // 
            this.txt_productID.BackColor = System.Drawing.Color.White;
            this.txt_productID.Enabled = false;
            this.txt_productID.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_productID.Location = new System.Drawing.Point(12, 65);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.Size = new System.Drawing.Size(169, 21);
            this.txt_productID.TabIndex = 649;
            this.txt_productID.TabStop = false;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel1.Location = new System.Drawing.Point(9, 47);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(50, 15);
            this.customLabel1.TabIndex = 648;
            this.customLabel1.Text = "Product";
            // 
            // tx
            // 
            this.tx.BackColor = System.Drawing.Color.White;
            this.tx.Enabled = false;
            this.tx.Font = new System.Drawing.Font("Arial", 9F);
            this.tx.Location = new System.Drawing.Point(189, 25);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(599, 21);
            this.tx.TabIndex = 650;
            this.tx.TabStop = false;
            this.tx.Visible = false;
            // 
            // txt_productDesc
            // 
            this.txt_productDesc.BackColor = System.Drawing.Color.White;
            this.txt_productDesc.Enabled = false;
            this.txt_productDesc.Font = new System.Drawing.Font("Arial", 9F);
            this.txt_productDesc.Location = new System.Drawing.Point(189, 65);
            this.txt_productDesc.Name = "txt_productDesc";
            this.txt_productDesc.Size = new System.Drawing.Size(599, 21);
            this.txt_productDesc.TabIndex = 651;
            this.txt_productDesc.TabStop = false;
            this.txt_productDesc.Visible = false;
            // 
            // grid_OrderDetail
            // 
            this.grid_OrderDetail.AllowUserToAddRows = false;
            this.grid_OrderDetail.AllowUserToDeleteRows = false;
            this.grid_OrderDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_OrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_OrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_OrderDetail.BackgroundColor = System.Drawing.Color.White;
            this.grid_OrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_OrderDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_OrderDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid_OrderDetail.EnableHeadersVisualStyles = false;
            this.grid_OrderDetail.GridColor = System.Drawing.Color.LightGray;
            this.grid_OrderDetail.Location = new System.Drawing.Point(12, 92);
            this.grid_OrderDetail.MultiSelect = false;
            this.grid_OrderDetail.Name = "grid_OrderDetail";
            this.grid_OrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_OrderDetail.RowHeadersVisible = false;
            this.grid_OrderDetail.RowTemplate.Height = 19;
            this.grid_OrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_OrderDetail.Size = new System.Drawing.Size(776, 346);
            this.grid_OrderDetail.StandardTab = true;
            this.grid_OrderDetail.TabIndex = 652;
            this.grid_OrderDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grid_OrderDetail_KeyPress);
            // 
            // ManualOrderSalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_OrderDetail);
            this.Controls.Add(this.txt_productDesc);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.txt_customerID);
            this.Controls.Add(this.customLabel17);
            this.Name = "ManualOrderSalesHistory";
            this.Text = "Sales History";
            this.Load += new System.EventHandler(this.ManualOrderSalesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_OrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomTextBox txt_customerID;
        private Tools.CustomLabel customLabel17;
        private CustomTextBox txt_productID;
        private Tools.CustomLabel customLabel1;
        private CustomTextBox tx;
        private CustomTextBox txt_productDesc;
        private CustomGrid grid_OrderDetail;
    }
}