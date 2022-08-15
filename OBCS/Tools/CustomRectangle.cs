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
    class CustomRectangle : Panel
    {
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
            SolidBrush brush = new SolidBrush(Color.Black);//(Color.FromArgb(176, 214, 115));

            g.FillRectangle(brush, rect);
        }


        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    int width = this.Size.Width;
        //    int height = this.Size.Height;

        //    Graphics g = this.CreateGraphics();
        //    //g.Clear(this.BackColor);/
        //    Rectangle rect = new Rectangle(0, 0, width - 1, height - 1);
        //    Pen pen = new Pen(Color.Black); //(Color.FromArgb(176, 214, 115));

        //    g.DrawRectangle(pen, rect);
        //}
    }
}
