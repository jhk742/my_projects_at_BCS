using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Tools
{
    class CustomTabMenuButton : Button
    {
        Color defaultColor = Color.FromArgb(1, 63, 45);
        //Color MouseEnterColor = Color.FromArgb(176, 214, 115);
        Color MouseEnterColor = Color.FromArgb(1, 63, 45);
        Color MouseLeaveColor = Color.FromArgb(1, 63, 45);
        Color MouseDownColor = Color.FromArgb(102, 143, 76);
        Color MouseUpColor = Color.FromArgb(1, 63, 45);

        public CustomTabMenuButton()
        {
            //Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ForeColor = this.ForeColor = Color.White;
        }

        protected override void InitLayout()
        {
            //init
            //this.ForeColor = Color.Black;
            //Font = new Font("Arial", 10F, FontStyle.Bold);

            base.InitLayout();

            this.FlatStyle = FlatStyle.Flat;
            //this.BackColor = defaultColor;
            this.SetStyle(ControlStyles.Selectable, false);
            
            this.MouseEnter += new EventHandler(this.button_MouseEnter);
            this.MouseLeave += new EventHandler(this.button_MouseLeave);
            this.MouseDown += new MouseEventHandler(this.button_MouseDown);
            this.MouseUp += new MouseEventHandler(this.button_MouseUp);
            this.EnabledChanged += new EventHandler(this.button_EnabledChanged);
            //this.Paint += new PaintEventHandler(this.button_Paint);
        }

        private void button_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
            //this.BackColor = defaultColor;
            this.FlatAppearance.BorderColor = defaultColor;
            this.FlatAppearance.BorderSize = 1;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        private void button_MouseEnter(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = MouseEnterColor;
        }

        private void button_MouseLeave(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = MouseUpColor;
        }

        private void button_MouseDown(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = defaultColor;
        }

        private void button_MouseUp(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = MouseUpColor;
        }

        private void button_EnabledChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(23, 58, 29);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            //base.OnMouseEnter(e);
            this.BackColor = MouseEnterColor;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            this.BackColor = MouseDownColor;
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - 1f,
                             Rect.Y + Rect.Height - 1f, 1f, 1f, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 1f, 1f, 1f, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(-1, -1, this.Width +1, this.Height +1);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 12))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.FromArgb(1, 63, 45), 1.5f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
    }
}
