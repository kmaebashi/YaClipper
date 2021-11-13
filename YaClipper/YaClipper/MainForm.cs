using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private Bitmap currentDispImage;

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
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Image image = Clipboard.GetImage();
                this.currentImage = new Bitmap(image);
                setImageToPicutreBox();
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
                setImageToPicutreBox();
            }
        }

        private void setImageToPicutreBox()
        {
            if (this.currentImage == null)
            {
                return;
            }
            this.currentDispImage = new Bitmap(this.currentImage,
                                            (int)(this.currentImage.Width * this.currentZoomRatio),
                                            (int)(this.currentImage.Height * this.currentZoomRatio));
            this.mainPictureBox.Image = this.currentDispImage;
        }
    }
}
