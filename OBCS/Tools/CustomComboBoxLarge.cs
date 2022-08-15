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
    public class CustomComboBoxLarge : ComboBox
    {
        Color backcolor = Color.White;
        Color backcolorFocus = Color.White;
        //Color backcolorFocus = Color.GreenYellow;
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, UIntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindow(String sClassName, String sAppName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, String lpszClass, String lpszWindow);

        public CustomComboBoxLarge()
        {
            BackColor = backcolor;
            Font = new Font("Arial", 13F, FontStyle.Bold);
            
        }
        protected override void OnGotFocus(EventArgs e)
        {
            //string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            //string keyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
            //System.Diagnostics.Process.Start(keyboardPath);
            BackColor = backcolorFocus;
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            //uint WM_SYSCOMMAND = 0x0112;
            //UIntPtr SC_CLOSE = new UIntPtr(0xF060);
            //IntPtr y = new IntPtr(0);
            //IntPtr KeyboardWnd = FindWindow("IPTip_Main_Window", null);
            //PostMessage(KeyboardWnd, WM_SYSCOMMAND, SC_CLOSE, y);
            BackColor = backcolor;
            base.OnLostFocus(e);
        }

        protected override void InitLayout()
        {
            //init
            if (this.Enabled == false)
            {
                BackColor = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
                this.ForeColor = Color.Black;
            }
            else
            {
                BackColor = backcolor;
            }
            Font = new Font("Arial", 13F, FontStyle.Bold);

            //this.CharacterCasing = CharacterCasing.Upper;

            base.InitLayout();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            //string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            //string keyboardPath = System.IO.Path.Combine(progFiles, "TabTip.exe");
            //System.Diagnostics.Process.Start(keyboardPath);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar.ToString().ToUpper()[0];
            DroppedDown = true;
            base.OnKeyPress(e);
        }

    }
}
