namespace OBCS.Reports
{
    partial class CustomerMap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btn_Map = new System.Windows.Forms.Button();
            this.btn_Satellite = new System.Windows.Forms.Button();
            this.btn_hybrid = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_BcsLogo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grid_SalesRep = new OBCS.CustomGrid();
            this.cbo_Customer = new OBCS.Tools.CustomComboBox();
            this.grid_Customer = new OBCS.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SalesRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(109, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(995, 731);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // btn_Map
            // 
            this.btn_Map.BackColor = System.Drawing.Color.White;
            this.btn_Map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Map.Location = new System.Drawing.Point(120, 22);
            this.btn_Map.Name = "btn_Map";
            this.btn_Map.Size = new System.Drawing.Size(75, 23);
            this.btn_Map.TabIndex = 10;
            this.btn_Map.Text = "Map";
            this.btn_Map.UseVisualStyleBackColor = false;
            this.btn_Map.Click += new System.EventHandler(this.btn_Map_Click);
            // 
            // btn_Satellite
            // 
            this.btn_Satellite.BackColor = System.Drawing.Color.White;
            this.btn_Satellite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Satellite.Location = new System.Drawing.Point(201, 22);
            this.btn_Satellite.Name = "btn_Satellite";
            this.btn_Satellite.Size = new System.Drawing.Size(75, 23);
            this.btn_Satellite.TabIndex = 11;
            this.btn_Satellite.Text = "Satellite";
            this.btn_Satellite.UseVisualStyleBackColor = false;
            this.btn_Satellite.Click += new System.EventHandler(this.btn_Satellite_Click);
            // 
            // btn_hybrid
            // 
            this.btn_hybrid.BackColor = System.Drawing.Color.White;
            this.btn_hybrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hybrid.Location = new System.Drawing.Point(282, 22);
            this.btn_hybrid.Name = "btn_hybrid";
            this.btn_hybrid.Size = new System.Drawing.Size(75, 23);
            this.btn_hybrid.TabIndex = 820;
            this.btn_hybrid.Text = "Hybrid";
            this.btn_hybrid.UseVisualStyleBackColor = false;
            this.btn_hybrid.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(9, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 23);
            this.btn_Search.TabIndex = 823;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_BcsLogo
            // 
            this.btn_BcsLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BcsLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_BcsLogo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_BcsLogo.BackgroundImage = global::OBCS.Properties.Resources.BCS_LOGO;
            this.btn_BcsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BcsLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BcsLogo.Location = new System.Drawing.Point(1053, 711);
            this.btn_BcsLogo.Name = "btn_BcsLogo";
            this.btn_BcsLogo.Size = new System.Drawing.Size(50, 32);
            this.btn_BcsLogo.TabIndex = 826;
            this.btn_BcsLogo.UseVisualStyleBackColor = false;
            this.btn_BcsLogo.Click += new System.EventHandler(this.btn_BcsLogo_Click);
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Enabled = false;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1053, 12);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(46, 202);
            this.listView1.TabIndex = 827;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // grid_SalesRep
            // 
            this.grid_SalesRep.AllowUserToAddRows = false;
            this.grid_SalesRep.AllowUserToDeleteRows = false;
            this.grid_SalesRep.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_SalesRep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_SalesRep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grid_SalesRep.BackgroundColor = System.Drawing.Color.White;
            this.grid_SalesRep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_SalesRep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_SalesRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_SalesRep.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_SalesRep.EnableHeadersVisualStyles = false;
            this.grid_SalesRep.GridColor = System.Drawing.Color.LightGray;
            this.grid_SalesRep.Location = new System.Drawing.Point(9, 41);
            this.grid_SalesRep.MultiSelect = false;
            this.grid_SalesRep.Name = "grid_SalesRep";
            this.grid_SalesRep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_SalesRep.RowHeadersVisible = false;
            this.grid_SalesRep.RowTemplate.Height = 19;
            this.grid_SalesRep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SalesRep.Size = new System.Drawing.Size(93, 702);
            this.grid_SalesRep.StandardTab = true;
            this.grid_SalesRep.TabIndex = 824;
            this.grid_SalesRep.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_SalesRep_ColumnHeaderMouseClick);
            // 
            // cbo_Customer
            // 
            this.cbo_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Customer.BackColor = System.Drawing.Color.White;
            this.cbo_Customer.Font = new System.Drawing.Font("Arial", 9F);
            this.cbo_Customer.FormattingEnabled = true;
            this.cbo_Customer.Location = new System.Drawing.Point(1109, 12);
            this.cbo_Customer.Name = "cbo_Customer";
            this.cbo_Customer.Size = new System.Drawing.Size(328, 23);
            this.cbo_Customer.TabIndex = 821;
            this.cbo_Customer.SelectedIndexChanged += new System.EventHandler(this.cbo_Customer_SelectedIndexChanged);
            // 
            // grid_Customer
            // 
            this.grid_Customer.AllowUserToAddRows = false;
            this.grid_Customer.AllowUserToDeleteRows = false;
            this.grid_Customer.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.grid_Customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_Customer.BackgroundColor = System.Drawing.Color.White;
            this.grid_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(220)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Customer.DefaultCellStyle = dataGridViewCellStyle6;
            this.grid_Customer.EnableHeadersVisualStyles = false;
            this.grid_Customer.GridColor = System.Drawing.Color.LightGray;
            this.grid_Customer.Location = new System.Drawing.Point(1109, 41);
            this.grid_Customer.MultiSelect = false;
            this.grid_Customer.Name = "grid_Customer";
            this.grid_Customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_Customer.RowHeadersVisible = false;
            this.grid_Customer.RowTemplate.Height = 19;
            this.grid_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Customer.Size = new System.Drawing.Size(328, 702);
            this.grid_Customer.StandardTab = true;
            this.grid_Customer.TabIndex = 818;
            this.grid_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.grid_Customer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Customer_CellEnter);
            this.grid_Customer.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grid_Customer_DataBindingComplete);
            // 
            // CustomerMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 755);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_BcsLogo);
            this.Controls.Add(this.grid_SalesRep);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cbo_Customer);
            this.Controls.Add(this.btn_hybrid);
            this.Controls.Add(this.grid_Customer);
            this.Controls.Add(this.btn_Satellite);
            this.Controls.Add(this.btn_Map);
            this.Controls.Add(this.gMapControl1);
            this.MinimumSize = new System.Drawing.Size(793, 356);
            this.Name = "CustomerMap";
            this.Text = "CustomerMap";
            this.Load += new System.EventHandler(this.CustomerMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SalesRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btn_Map;
        private System.Windows.Forms.Button btn_Satellite;
        private CustomGrid grid_Customer;
        private System.Windows.Forms.Button btn_hybrid;
        private Tools.CustomComboBox cbo_Customer;
        private System.Windows.Forms.Button btn_Search;
        private CustomGrid grid_SalesRep;
        private System.Windows.Forms.Button btn_BcsLogo;
        private System.Windows.Forms.ListView listView1;
    }
}