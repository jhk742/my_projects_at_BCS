using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBCS.Tools
{
    class CustomLabelReportButton : Label
    {
        Color MouseEnterColor = Color.FromArgb(176, 214, 115);
        Color MouseLeaveColor = Color.Transparent;
        Color MouseDownColor = Color.FromArgb(102, 143, 76);
        Color MouseUpColor = Color.FromArgb(176, 214, 115);

        public CustomLabelReportButton()
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
            this.MouseEnter += new EventHandler(this.label_MouseEnter);
            this.MouseLeave += new EventHandler(this.label_MouseLeave);
            this.MouseDown += new MouseEventHandler(this.label_MouseDown);
            this.MouseUp += new MouseEventHandler(this.label_MouseUp);
            this.EnabledChanged += new EventHandler(this.label_EnabledChanged);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        private void label_MouseEnter(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = MouseEnterColor;
            this.ForeColor = Color.Black;
        }

        private void label_MouseLeave(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = MouseLeaveColor;
            this.ForeColor = Color.White;
        }

        private void label_MouseDown(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = MouseDownColor;
        }

        private void label_MouseUp(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
        }

        private void label_EnabledChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(23, 58, 29);
        }

    }
}
