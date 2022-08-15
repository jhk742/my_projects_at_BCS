namespace OBCS.Sales
{
    partial class RouteMap
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
            this.btn_hybrid = new System.Windows.Forms.Button();
            this.btn_Map = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btn_BcsLogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hybrid
            // 
            this.btn_hybrid.BackColor = System.Drawing.Color.White;
            this.btn_hybrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hybrid.Location = new System.Drawing.Point(76, 12);
            this.btn_hybrid.Name = "btn_hybrid";
            this.btn_hybrid.Size = new System.Drawing.Size(58, 23);
            this.btn_hybrid.TabIndex = 826;
            this.btn_hybrid.Text = "Hybrid";
            this.btn_hybrid.UseVisualStyleBackColor = false;
            this.btn_hybrid.Click += new System.EventHandler(this.btn_hybrid_Click);
            // 
            // btn_Map
            // 
            this.btn_Map.BackColor = System.Drawing.Color.White;
            this.btn_Map.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Map.Location = new System.Drawing.Point(12, 12);
            this.btn_Map.Name = "btn_Map";
            this.btn_Map.Size = new System.Drawing.Size(58, 23);
            this.btn_Map.TabIndex = 825;
            this.btn_Map.Text = "Map";
            this.btn_Map.UseVisualStyleBackColor = false;
            this.btn_Map.Click += new System.EventHandler(this.btn_Map_Click);
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
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
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
            this.gMapControl1.Size = new System.Drawing.Size(1372, 902);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // btn_BcsLogo
            // 
            this.btn_BcsLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BcsLogo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_BcsLogo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_BcsLogo.BackgroundImage = global::OBCS.Properties.Resources.BCS_LOGO;
            this.btn_BcsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BcsLogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BcsLogo.Location = new System.Drawing.Point(1334, 882);
            this.btn_BcsLogo.Name = "btn_BcsLogo";
            this.btn_BcsLogo.Size = new System.Drawing.Size(50, 32);
            this.btn_BcsLogo.TabIndex = 827;
            this.btn_BcsLogo.UseVisualStyleBackColor = false;
            this.btn_BcsLogo.Click += new System.EventHandler(this.btn_BcsLogo_Click);
            // 
            // RouteMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 926);
            this.Controls.Add(this.btn_BcsLogo);
            this.Controls.Add(this.btn_hybrid);
            this.Controls.Add(this.btn_Map);
            this.Controls.Add(this.gMapControl1);
            this.Name = "RouteMap";
            this.Text = "Route Map";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_hybrid;
        private System.Windows.Forms.Button btn_Map;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btn_BcsLogo;
    }
}