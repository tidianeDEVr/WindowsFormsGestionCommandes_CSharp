using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace WindowsFormsGestionCommandes.services
{
    static class ViewService
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public static void FirstBtnMark(Panel pnlNav, Button btn)
        {
            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            pnlNav.Left = btn.Left;
            btn.BackColor = Color.FromArgb(37, 150, 190);
        }
        public static void OtherBtnMark(Panel pnlNav, Button btn)
        {
            pnlNav.Height = btn.Height;
            pnlNav.Top = btn.Top;
            btn.BackColor = Color.FromArgb(37, 150, 190);
        }
        public static void RemoveBtnMark(Panel pnlNav, Button btn)
        {
            btn.BackColor = Color.FromArgb(51, 51, 51);
        }
    }
}
