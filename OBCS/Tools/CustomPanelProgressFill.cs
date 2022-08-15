using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Tools
{
    class CustomPanelProgressFill : Panel
    {
        public CustomPanelProgressFill()
        {
            //this.Paint += new PaintEventHandler(this.panel_paint);
        }

        protected override void InitLayout()
        {
            //init
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, this, new object[] { true });
        }

        private void panel_paint(object sender, PaintEventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;

            Graphics g = this.CreateGraphics();
            //g.Clear(this.BackColor);
            Rectangle rect = new Rectangle(0, 0, width - 1, height - 1);
            SolidBrush brush = new SolidBrush(Color.FromArgb(176, 214, 115));

            g.FillRectangle(brush, rect);
        }

        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(-1, -1, this.Width + 1, this.Height + 1);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 7))
            {
                this.Region = new Region(GraphPath);
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(176, 214, 115)))
                {
                    //brush.Alignment = PenAlignment.Inset;
                    e.Graphics.FillPath(brush, GraphPath);
                }
            }

            //using (GraphicsPath GraphPath = GetRoundPath(Rect, 10))
            //{
            //    this.Region = new Region(GraphPath);
            //    using (Pen pen = new Pen(Color.FromArgb(176, 214, 115), 1.5f))
            //    {
            //        pen.Alignment = PenAlignment.Inset;
            //        e.Graphics.DrawPath(pen, GraphPath);
            //    }
            //}
        }
    }
}
