using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private Status currentStatus;
        private int startX;
        private int startY;
        private int prevX;
        private int prevY;

        public EditMouseListener()
        {
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
            if (this.currentStatus == Status.Initial)
            {
                this.prevX = e.X;
                this.prevY = e.Y;
            }
        }

        public void OnMouseUp(MouseEventArgs e)
        {
            Console.WriteLine("OnMouseUp:(" + e.X + ", " + e.Y + ")" + e.Button);
        }

    }
}
