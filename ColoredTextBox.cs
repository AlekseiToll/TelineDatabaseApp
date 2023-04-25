using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// The solution of the problem is taken from here
// https://stackoverflow.com/questions/9768938/change-the-bordercolor-of-the-textbox

namespace TelineApp
{
    public partial class ColoredTextBox : TextBox
    {
        public ColoredTextBox()
        {
            InitializeComponent();
        }

        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);
        private const int WM_NCPAINT = 0x85;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT && this.Text.Length == 0)
            {
                var dc = GetWindowDC(Handle);
                using (Graphics g = Graphics.FromHdc(dc))
                {
                    Pen pen = new Pen(Color.Red, 2.0f);
                    g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
                }
            }
        }
    }
}
