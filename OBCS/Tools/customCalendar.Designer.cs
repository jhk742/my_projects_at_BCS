
namespace OBCS.Tools
{
    partial class customCalendar
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
            this.daysContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Monday = new System.Windows.Forms.Label();
            this.label_Tuesday = new System.Windows.Forms.Label();
            this.label_Wednesday = new System.Windows.Forms.Label();
            this.label_Thursday = new System.Windows.Forms.Label();
            this.label_Saturday = new System.Windows.Forms.Label();
            this.label_Sunday = new System.Windows.Forms.Label();
            this.label_displayDate = new System.Windows.Forms.Label();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_PrevYear = new System.Windows.Forms.Button();
            this.btn_NextYear = new System.Windows.Forms.Button();
            this.Yearly = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bulkNutLabelList1 = new OBCS.Reports.BulkNutLabelList();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.datePICK = new OBCS.Purchase.CustomDateTimePicker();
            this.label_EXPECTED = new OBCS.Tools.CustomLabel();
            this.label_CONFIRMED = new OBCS.Tools.CustomLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulkNutLabelList1)).BeginInit();
            this.SuspendLayout();
            // 
            // daysContainer
            // 
            this.daysContainer.BackColor = System.Drawing.Color.Snow;
            this.daysContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.daysContainer.Location = new System.Drawing.Point(26, 64);
            this.daysContainer.Name = "daysContainer";
            this.daysContainer.Size = new System.Drawing.Size(1872, 916);
            this.daysContainer.TabIndex = 0;
            // 
            // label_Monday
            // 
            this.label_Monday.AutoSize = true;
            this.label_Monday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Monday.ForeColor = System.Drawing.Color.Black;
            this.label_Monday.Location = new System.Drawing.Point(397, 29);
            this.label_Monday.Name = "label_Monday";
            this.label_Monday.Size = new System.Drawing.Size(77, 22);
            this.label_Monday.TabIndex = 1;
            this.label_Monday.Text = "Monday";
            // 
            // label_Tuesday
            // 
            this.label_Tuesday.AutoSize = true;
            this.label_Tuesday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tuesday.ForeColor = System.Drawing.Color.Black;
            this.label_Tuesday.Location = new System.Drawing.Point(672, 29);
            this.label_Tuesday.Name = "label_Tuesday";
            this.label_Tuesday.Size = new System.Drawing.Size(77, 22);
            this.label_Tuesday.TabIndex = 2;
            this.label_Tuesday.Text = "Tuesday";
            // 
            // label_Wednesday
            // 
            this.label_Wednesday.AutoSize = true;
            this.label_Wednesday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Wednesday.ForeColor = System.Drawing.Color.Black;
            this.label_Wednesday.Location = new System.Drawing.Point(924, 29);
            this.label_Wednesday.Name = "label_Wednesday";
            this.label_Wednesday.Size = new System.Drawing.Size(103, 22);
            this.label_Wednesday.TabIndex = 3;
            this.label_Wednesday.Text = "Wednesday";
            // 
            // label_Thursday
            // 
            this.label_Thursday.AutoSize = true;
            this.label_Thursday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Thursday.ForeColor = System.Drawing.Color.Black;
            this.label_Thursday.Location = new System.Drawing.Point(1196, 29);
            this.label_Thursday.Name = "label_Thursday";
            this.label_Thursday.Size = new System.Drawing.Size(88, 22);
            this.label_Thursday.TabIndex = 4;
            this.label_Thursday.Text = "Thursday";
            // 
            // label_Saturday
            // 
            this.label_Saturday.AutoSize = true;
            this.label_Saturday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Saturday.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Saturday.Location = new System.Drawing.Point(1724, 29);
            this.label_Saturday.Name = "label_Saturday";
            this.label_Saturday.Size = new System.Drawing.Size(84, 22);
            this.label_Saturday.TabIndex = 6;
            this.label_Saturday.Text = "Saturday";
            // 
            // label_Sunday
            // 
            this.label_Sunday.AutoSize = true;
            this.label_Sunday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sunday.ForeColor = System.Drawing.Color.Red;
            this.label_Sunday.Location = new System.Drawing.Point(129, 29);
            this.label_Sunday.Name = "label_Sunday";
            this.label_Sunday.Size = new System.Drawing.Size(70, 22);
            this.label_Sunday.TabIndex = 7;
            this.label_Sunday.Text = "Sunday";
            // 
            // label_displayDate
            // 
            this.label_displayDate.AutoSize = true;
            this.label_displayDate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_displayDate.Location = new System.Drawing.Point(907, -2);
            this.label_displayDate.Name = "label_displayDate";
            this.label_displayDate.Size = new System.Drawing.Size(97, 36);
            this.label_displayDate.TabIndex = 8;
            this.label_displayDate.Text = "label1";
            // 
            // btn_Prev
            // 
            this.btn_Prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_Prev.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prev.ForeColor = System.Drawing.Color.White;
            this.btn_Prev.Location = new System.Drawing.Point(1200, -1);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(78, 22);
            this.btn_Prev.TabIndex = 12;
            this.btn_Prev.Text = "<<";
            this.btn_Prev.UseVisualStyleBackColor = false;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click_1);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_Next.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(1324, -1);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(78, 22);
            this.btn_Next.TabIndex = 11;
            this.btn_Next.Text = ">>";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click_1);
            // 
            // btn_PrevYear
            // 
            this.btn_PrevYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_PrevYear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrevYear.ForeColor = System.Drawing.Color.White;
            this.btn_PrevYear.Location = new System.Drawing.Point(1408, -1);
            this.btn_PrevYear.Name = "btn_PrevYear";
            this.btn_PrevYear.Size = new System.Drawing.Size(78, 22);
            this.btn_PrevYear.TabIndex = 14;
            this.btn_PrevYear.Text = "<<";
            this.btn_PrevYear.UseVisualStyleBackColor = false;
            this.btn_PrevYear.Click += new System.EventHandler(this.btn_PrevYear_Click);
            // 
            // btn_NextYear
            // 
            this.btn_NextYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.btn_NextYear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextYear.ForeColor = System.Drawing.Color.White;
            this.btn_NextYear.Location = new System.Drawing.Point(1534, -1);
            this.btn_NextYear.Name = "btn_NextYear";
            this.btn_NextYear.Size = new System.Drawing.Size(78, 22);
            this.btn_NextYear.TabIndex = 13;
            this.btn_NextYear.Text = ">>";
            this.btn_NextYear.UseVisualStyleBackColor = false;
            this.btn_NextYear.Click += new System.EventHandler(this.btn_NextYear_Click);
            // 
            // Yearly
            // 
            this.Yearly.AutoSize = true;
            this.Yearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearly.Location = new System.Drawing.Point(1492, 4);
            this.Yearly.Name = "Yearly";
            this.Yearly.Size = new System.Drawing.Size(36, 13);
            this.Yearly.TabIndex = 15;
            this.Yearly.Text = "Yearly";
            this.Yearly.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1277, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Monthly";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1200, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 22);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(356, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(356, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 19;
            // 
            // bulkNutLabelList1
            // 
            this.bulkNutLabelList1.DataSetName = "BulkNutLabelList";
            this.bulkNutLabelList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1618, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 22);
            this.button1.TabIndex = 23;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Upon reception of goods, the corresponding PO will no longer be visible on the ca" +
    "lendar.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(178, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 22);
            this.button2.TabIndex = 28;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datePICK
            // 
            this.datePICK.BackColor = System.Drawing.Color.White;
            this.datePICK.CalendarFont = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.datePICK.CustomFormat = " MM/dd/yyyy";
            this.datePICK.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Bold);
            this.datePICK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePICK.Location = new System.Drawing.Point(26, 1);
            this.datePICK.Name = "datePICK";
            this.datePICK.Size = new System.Drawing.Size(146, 21);
            this.datePICK.TabIndex = 27;
            // 
            // label_EXPECTED
            // 
            this.label_EXPECTED.AutoSize = true;
            this.label_EXPECTED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_EXPECTED.Location = new System.Drawing.Point(462, 12);
            this.label_EXPECTED.Name = "label_EXPECTED";
            this.label_EXPECTED.Size = new System.Drawing.Size(29, 15);
            this.label_EXPECTED.TabIndex = 21;
            this.label_EXPECTED.Text = "ETA";
            // 
            // label_CONFIRMED
            // 
            this.label_CONFIRMED.AutoSize = true;
            this.label_CONFIRMED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_CONFIRMED.Location = new System.Drawing.Point(462, -2);
            this.label_CONFIRMED.Name = "label_CONFIRMED";
            this.label_CONFIRMED.Size = new System.Drawing.Size(64, 15);
            this.label_CONFIRMED.TabIndex = 20;
            this.label_CONFIRMED.Text = "Confirmed";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(246, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 22);
            this.button3.TabIndex = 29;
            this.button3.Text = "Now";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1473, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Friday";
            // 
            // customCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datePICK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_EXPECTED);
            this.Controls.Add(this.label_CONFIRMED);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yearly);
            this.Controls.Add(this.btn_PrevYear);
            this.Controls.Add(this.btn_NextYear);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.label_displayDate);
            this.Controls.Add(this.label_Sunday);
            this.Controls.Add(this.label_Saturday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Thursday);
            this.Controls.Add(this.label_Wednesday);
            this.Controls.Add(this.label_Tuesday);
            this.Controls.Add(this.label_Monday);
            this.Controls.Add(this.daysContainer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "customCalendar";
            this.Size = new System.Drawing.Size(1916, 1056);
            this.Load += new System.EventHandler(this.customCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulkNutLabelList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daysContainer;
        private System.Windows.Forms.Label label_Monday;
        private System.Windows.Forms.Label label_Tuesday;
        private System.Windows.Forms.Label label_Wednesday;
        private System.Windows.Forms.Label label_Thursday;
        private System.Windows.Forms.Label label_Saturday;
        private System.Windows.Forms.Label label_Sunday;
        private System.Windows.Forms.Label label_displayDate;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_PrevYear;
        private System.Windows.Forms.Button btn_NextYear;
        private System.Windows.Forms.Label Yearly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private CustomLabel label_CONFIRMED;
        private CustomLabel label_EXPECTED;
        private Reports.BulkNutLabelList bulkNutLabelList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Purchase.CustomDateTimePicker datePICK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}
