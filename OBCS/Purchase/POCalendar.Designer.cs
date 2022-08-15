
namespace OBCS.Purchase
{
    partial class POCalendar
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
            this.customCalendar1 = new OBCS.Tools.customCalendar();
            this.SuspendLayout();
            // 
            // customCalendar1
            // 
            this.customCalendar1.BackColor = System.Drawing.Color.Snow;
            this.customCalendar1.Location = new System.Drawing.Point(0, 0);
            this.customCalendar1.Name = "customCalendar1";
            this.customCalendar1.Size = new System.Drawing.Size(1913, 992);
            this.customCalendar1.TabIndex = 0;
            // 
            // POCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1917, 1003);
            this.Controls.Add(this.customCalendar1);
            this.Name = "POCalendar";
            this.Text = "PO Reception Calendar";
            this.ResumeLayout(false);

        }

        #endregion

        private Tools.customCalendar customCalendar1;
    }
}