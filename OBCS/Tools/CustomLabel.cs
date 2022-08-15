using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;


namespace OBCS.Tools
{
    class CustomLabel : Label
    {
        Color backcolor = Color.White;
        Color backcolorFocus = Color.White;
        //Color backcolorFocus = Color.GreenYellow;

        public CustomLabel()
        {
            //BackColor = backcolor;
            Font = new Font("Arial", 10F, FontStyle.Bold);
        }
        
        protected override void InitLayout()
        {
            //init
            //this.ForeColor = Color.Black;
            //Font = new Font("Arial", 10F, FontStyle.Bold);
            
            base.InitLayout();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
