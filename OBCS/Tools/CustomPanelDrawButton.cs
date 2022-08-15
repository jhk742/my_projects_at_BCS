using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Tools
{
    class CustomPanelDrawButton : Panel
    {
        Color MouseEnterColor = Color.FromArgb(176, 214, 115);
        Color MouseLeaveColor = Color.Transparent;
        Color MouseDownColor = Color.FromArgb(102, 143, 76);
        Color MouseUpColor = Color.FromArgb(176, 214, 115);

        public CustomPanelDrawButton()
        {
            //Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline);
            Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline);
            ForeColor = this.ForeColor = Color.White;
        }

        protected override void InitLayout()
        {
            //init
            //this.ForeColor = Color.Black;
            //Font = new Font("Arial", 10F, FontStyle.Bold);

            base.InitLayout();
            this.MouseEnter += new EventHandler(this.panel_MouseEnter);
            this.MouseLeave += new EventHandler(this.panel_MouseLeave);
            this.MouseDown += new MouseEventHandler(this.panel_MouseDown);
            this.MouseUp += new MouseEventHandler(this.panel_MouseUp);
            this.EnabledChanged += new EventHandler(this.panel_EnabledChanged);
            this.Paint += new PaintEventHandler(this.panel_paint);

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, this, new object[] { true });
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        private void panel_MouseEnter(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = MouseEnterColor;
            this.ForeColor = Color.Black;
        }

        private void panel_MouseLeave(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = MouseLeaveColor;
            this.ForeColor = Color.White;
        }

        private void panel_MouseDown(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = MouseDownColor;
        }

        private void panel_MouseUp(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
        }

        private void panel_EnabledChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(23, 58, 29);
        }

        private void panel_paint(object sender, System.EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;

            Graphics g = this.CreateGraphics();
            //g.Clear(this.BackColor);/
            Rectangle rect = new Rectangle(0, 0, width - 1, height - 1);
            Pen pen = new Pen(Color.FromArgb(176, 214, 115));

            g.DrawRectangle(pen, rect);
            //g.Dispose();

            
            Label label = new Label();
            label.Text = "Download PDF";
            label.Location = new Point(1,1);
            label.Size = new Size(width-2, height-2);
            //textbox.BackColor = Color.Transparent;
            //textbox.FlatStyle = FlatStyle.Popup;
            ///aspbutton.Click += initDownload;


            //button.FlatAppearance.BorderColor = Color.Red;
            //button.FlatAppearance.BorderSize = 1;


            this.Controls.Add(label);

            //this.Controls.Add(new LiteralControl("some more text!"));
        }
    }
}
