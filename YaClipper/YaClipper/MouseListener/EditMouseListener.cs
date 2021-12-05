using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YaClipper.Gdi;

namespace YaClipper.MouseListener
{
    class EditMouseListener : IMouseListener
    {
        enum Status
        {
            Initial,
            DragStart,
            Dragging
        }
        private PictureBox pictureBox;
        private Graphics graphics;
        private Gdi32 gdi32;
        private Status currentStatus;
        private int startX;
        private int startY;
        private int prevX;
        private int prevY;

        public EditMouseListener(PictureBox pictureBox, Gdi32 gdi32)
        {
            this.pictureBox = pictureBox;
            this.graphics = pictureBox.CreateGraphics();
            this.gdi32 = gdi32;
            this.currentStatus = Status.Initial;
        }

        public void OnMouseDown(MouseEventArgs e)
        {
            if (this.currentStatus == Status.Initial)
            {
                this.startX = e.X;
                this.startY = e.Y;
                this.currentStatus = Status.DragStart;
            }
        }

        public void OnMouseMove(MouseEventArgs e)
        {
            if (this.currentStatus == Status.DragStart)
            {
                this.gdi32.DrawXorRectangle(this.startX, this.startY, e.X, e.Y);
                this.prevX = e.X;
                this.prevY = e.Y;
                this.currentStatus = Status.Dragging;
            } else if (this.currentStatus == Status.Dragging)
            {
                this.gdi32.DrawXorRectangle(this.startX, this.startY, this.prevX, this.prevY);
                this.gdi32.DrawXorRectangle(this.startX, this.startY, e.X, e.Y);
                this.prevX = e.X;
                this.prevY = e.Y;
            }
        }

        public void OnMouseUp(MouseEventArgs e)
        {
            this.currentStatus = Status.Initial;
        }
    }
}
