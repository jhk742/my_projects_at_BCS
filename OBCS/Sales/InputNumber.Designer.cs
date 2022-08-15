namespace OBCS.Sales
{
    partial class InputNumber
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
            this.txt_text = new OBCS.CustomExtraLargeTextBox();
            this.lbl_text = new OBCS.Tools.CustomLabel();
            this.SuspendLayout();
            // 
            // txt_text
            // 
            this.txt_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_text.BackColor = System.Drawing.Color.White;
            this.txt_text.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold);
            this.txt_text.Location = new System.Drawing.Point(12, 68);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(314, 84);
            this.txt_text.TabIndex = 0;
            this.txt_text.Text = "0";
            this.txt_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customExtraLargeTextBox1_KeyPress);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.Location = new System.Drawing.Point(12, 9);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(120, 56);
            this.lbl_text.TabIndex = 1;
            this.lbl_text.Text = "Text";
            // 
            // InputNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 164);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.txt_text);
            this.Name = "InputNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomExtraLargeTextBox txt_text;
        private Tools.CustomLabel lbl_text;
    }
}