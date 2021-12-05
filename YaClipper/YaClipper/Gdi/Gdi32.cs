using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaClipper.Gdi
{
    // https://www.codeproject.com/Articles/27389/C-Rubber-Rectangle
    class Gdi32
    {
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool Rectangle(IntPtr hdc, int x1, int y1, int x2, int y2);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr CreatePen(PenStyle penStyle, int width, int color);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr hObject);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hObject);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern IntPtr GetStockObject(int brStyle);
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern int SetROP2(IntPtr hdc, int drawMode);

        private const int NullBrush = 5;

        private IntPtr hdc;
        private IntPtr oldBrush;
        private IntPtr oldPen;
        private IntPtr gdiPen;
        private IntPtr gdiBrush;

        private int GetRGBFromColor(Color fromColor)
        {
            return fromColor.ToArgb() & 0xFFFFFF;
        }

        public Gdi32(Graphics g)
        {
            hdc = g.GetHdc();
            gdiPen = CreatePen(PenStyle.Solid, 0, GetRGBFromColor(Color.White));
            gdiBrush = GetStockObject(NullBrush);
            oldPen = SelectObject(hdc, gdiPen);
            oldBrush = SelectObject(hdc, gdiBrush);
            SetROP2(hdc, (int)RasterOperationCode.XorPen);
        }

        public void DrawXorRectangle(int x1, int y1, int x2, int y2)
        {
            int minX = Math.Min(x1, x2);
            int minY = Math.Min(y1, y2);
            int maxX = Math.Max(x1, x2);
            int maxY = Math.Max(y1, y2);

            Rectangle(this.hdc, minX, minY, maxX, maxY);
        }
    }
}
