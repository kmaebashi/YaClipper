using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YaClipper.MouseListener;
using YaClipper.Gdi;

namespace YaClipper
{
    public partial class MainForm : Form
    {
        TrackBar zoomTrackBar;

        private double[] zoomRatioArray =
        {
            0.125,
            0.25,
            0.5,
            1.0,
            2.0,
            3.0,
            4.0,
            5.0,
            6.0,
            7.0,
            8.0
        };
        private int currentZoomRatioIndex = 3; // 1.0
        private double currentZoomRatio = 1.0;
        private Bitmap currentImage;
        private Gdi32 gdi32;

        private IMouseListener currentMouseListener;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.zoomTrackBar = new TrackBar();
            this.zoomTrackBar.AutoSize = false;
            this.zoomTrackBar.Size = new Size(80, 20);
            var toolStripHost = new ToolStripControlHost(this.zoomTrackBar);
            this.statusStrip.Items.Add(toolStripHost);

            this.KeyPreview = true;
            this.MouseEnter += new EventHandler(this.MainForm_MouseEnter);
            this.MouseWheel += new MouseEventHandler(this.MainForm_MouseWheel);
            KeyDown += new KeyEventHandler(MainForm_KeyDown);
            this.gdi32 = new Gdi32(this.mainPictureBox.CreateGraphics());

            this.currentMouseListener = new EditMouseListener(this.mainPictureBox, gdi32);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Image image = Clipboard.GetImage();
                this.currentImage = new Bitmap(image);
                this.mainPictureBox.Size = this.currentImage.Size;
                //this.mainPictureBox.Image = this.currentImage;
                this.mainPictureBox.Invalidate();
            }
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void MainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Math.Abs(e.Delta) < 120) return;

            if ((Control.ModifierKeys & Keys.Control) == 0)
            {
                ScrollableControl control = (ScrollableControl)this.mainPanel;
                var scroll = control.VerticalScroll;

                var maximum = 1 + scroll.Maximum - scroll.LargeChange;
                var delta = -(e.Delta / 120) * scroll.SmallChange;
                var offset = Math.Min(Math.Max(scroll.Value + delta, scroll.Minimum), maximum);
                control.AutoScrollPosition = new Point(0, offset);
            }
            else
            {
                int delta = e.Delta / 120;

                if (this.currentZoomRatioIndex + delta < 0)
                {
                    this.currentZoomRatioIndex = 0;
                }
                else if (this.currentZoomRatioIndex + delta >= this.zoomRatioArray.Length)
                {
                    this.currentZoomRatioIndex = this.zoomRatioArray.Length -1;
                }
                else
                {
                    this.currentZoomRatioIndex = this.currentZoomRatioIndex + delta;
                }
                this.currentZoomRatio = this.zoomRatioArray[this.currentZoomRatioIndex];
                this.mainPictureBox.Size = new Size((int)(this.currentImage.Width * this.currentZoomRatio),
                                                    (int)(this.currentImage.Height * this.currentZoomRatio));
                this.mainPictureBox.Invalidate();
            }
        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("mainPictureBox_Paint called.");
            ScrollableControl scrollable = (ScrollableControl)this.mainPanel;
            Console.WriteLine("Horizontal Value.." + scrollable.HorizontalScroll.Value);
            Console.WriteLine("Vertical Value.." + scrollable.VerticalScroll.Value);
            Console.WriteLine("scrollable area.." + scrollable.Left + ", " + scrollable.Top + "-" + scrollable.Right + ", " + scrollable.Bottom);
            if (this.currentImage == null)
            {
                Console.WriteLine("currentImage == null");
                return;
            }

            Rectangle destRect = new Rectangle(scrollable.HorizontalScroll.Value,
                                               scrollable.VerticalScroll.Value,
                                               this.mainPanel.Width, this.mainPanel.Height);
            Console.WriteLine("destRect.." + destRect);
            int srcX = (int)(scrollable.HorizontalScroll.Value / this.currentZoomRatio);
            int srcY = (int)(scrollable.VerticalScroll.Value / this.currentZoomRatio);
            int srcWidth = (int)(this.mainPanel.Width / this.currentZoomRatio);
            int srcHeight = (int)(this.mainPanel.Height / this.currentZoomRatio);

            Graphics g = e.Graphics;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(this.currentImage, destRect, srcX, srcY, srcWidth, srcHeight, GraphicsUnit.Pixel);


            //g.DrawLine(pen, scrollable.HorizontalScroll.Value, scrollable.VerticalScroll.Value,
            //    scrollable.HorizontalScroll.Value + this.mainPanel.Width,
            //    scrollable.VerticalScroll.Value + this.mainPanel.Height);
        }

        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.currentMouseListener.OnMouseDown(e);
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.currentMouseListener.OnMouseUp(e);
        }

        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.currentMouseListener.OnMouseMove(e);
        }

    }
}
