
namespace OBCS.Tools
{
    partial class UserControlIncluded
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Days = new System.Windows.Forms.Label();
            this.grid_includedPO = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_includedPO)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Days
            // 
            this.label_Days.AutoSize = true;
            this.label_Days.BackColor = System.Drawing.Color.AliceBlue;
            this.label_Days.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Days.ForeColor = System.Drawing.Color.Black;
            this.label_Days.Location = new System.Drawing.Point(1, 3);
            this.label_Days.Name = "label_Days";
            this.label_Days.Size = new System.Drawing.Size(40, 15);
            this.label_Days.TabIndex = 0;
            this.label_Days.Text = "label1";
            // 
            // grid_includedPO
            // 
            this.grid_includedPO.AllowUserToAddRows = false;
            this.grid_includedPO.AllowUserToDeleteRows = false;
            this.grid_includedPO.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_includedPO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_includedPO.BackgroundColor = System.Drawing.Color.White;
            this.grid_includedPO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_includedPO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grid_includedPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_includedPO.DefaultCellStyle = dataGridViewCellStyle9;
            this.grid_includedPO.EnableHeadersVisualStyles = false;
            this.grid_includedPO.GridColor = System.Drawing.Color.LightGray;
            this.grid_includedPO.Location = new System.Drawing.Point(0, 0);
            this.grid_includedPO.MultiSelect = false;
            this.grid_includedPO.Name = "grid_includedPO";
            this.grid_includedPO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_includedPO.RowHeadersVisible = false;
            this.grid_includedPO.RowTemplate.Height = 19;
            this.grid_includedPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_includedPO.Size = new System.Drawing.Size(261, 146);
            this.grid_includedPO.StandardTab = true;
            this.grid_includedPO.TabIndex = 1;
            this.grid_includedPO.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_includedPO_CellDoubleClick);
            this.grid_includedPO.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_includedPO_DataBindingComplete);
            // 
            // UserControlIncluded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_Days);
            this.Controls.Add(this.grid_includedPO);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UserControlIncluded";
            this.Size = new System.Drawing.Size(261, 146);
            ((System.ComponentModel.ISupportInitialize)(this.grid_includedPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Days;
        private CustomGrid grid_includedPO;
    }
}
