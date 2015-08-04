using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsTileMaker.Forms;
using nsTileMaker.lib;

namespace nsTileMaker.Controls
{
    public partial class SourceImage : UserControl
    {
        #region Member

        private Bitmap originalBitmap = null;
        //private Bitmap resultBitmap = null;

        //            this.pictureBox.MouseDown +=pictureBox_MouseDown;
        //    this.pictureBox.Paint +=pictureBox_Paint;
        //    this.pictureBox.MouseUp +=pictureBox_MouseUp;
        //    this.pictureBox.MouseMove +=pictureBox_MouseMove;

        // Current selection as a Bitmap
        private Bitmap SelectedImage;

        private Point       RectStartPoint;
        private Rectangle   Rect            =   new Rectangle();
        private Brush       selectionBrush  =   new SolidBrush(Color.FromArgb(128, 72, 145, 220));
        

        #endregion

        #region Properties

        /// <summary>
        /// Get current selection as a Bitmap
        /// </summary>
        public Bitmap Selection
        {
            get { return SelectedImage; }
        }

        #endregion

        #region Constructors

        public SourceImage()
        {
            InitializeComponent();
        }

        public SourceImage(Image img)
        {
            InitializeComponent();
            this.SelectedImage      =   new Bitmap(img);
            this.originalBitmap     =   this.SelectedImage;            
            this.pictureBox.Image = img;
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region private methods

        /// <summary>
        /// Sets the new color tone of the image
        /// </summary>
        /// <param name="preview">bool which shows if a preview is shown</param>
        private void ApplyFilter(bool preview)
        {
            if (this.pictureBox.Image == null)
            {
                return;
            }
            

            if (preview == true)
            {
                this.pictureBox.Image = originalBitmap.ColorBalance((byte)trcBlue.Value,
                                        (byte)trcGreen.Value, (byte)trcRed.Value);
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Draw area
        /// </summary>        
        private void pictureBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Draw the rectangle...
            if (this.pictureBox.Image != null)
            {
                if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                {
                    e.Graphics.FillRectangle(selectionBrush, Rect);                    
                }
            }
        }

        /// <summary>
        /// save selection
        /// </summary>        
        private void pictureBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Rect.Width > 0 && Rect.Height > 0)
            {
                try
                {
                    if ((Rect.Location.X + Rect.Width) > this.pictureBox.Image.Size.Width)
                    {
                        Rect.Width = (this.pictureBox.Image.Size.Width - Rect.Location.X);
                    }
                    if ((Rect.Location.Y + Rect.Height) > this.pictureBox.Image.Size.Height)
                    {
                        Rect.Height = (this.pictureBox.Image.Size.Height - Rect.Location.Y);
                    }
                    if (Rect.Location.X < 0)
                    {
                        Rect.Width = Rect.Width + Rect.Location.X;
                        Rect.Location = new Point(0, Rect.Location.Y);
                    }
                    if (Rect.Location.Y < 0)
                    {
                        Rect.Height = Rect.Height + Rect.Location.Y;
                        Rect.Location = new Point(Rect.Location.X, 0);
                    }

                    this.SelectedImage = ((Bitmap)this.pictureBox.Image).Clone(Rect, System.Drawing.Imaging.PixelFormat.Format16bppArgb1555);
                    ((CtrlTileEditControl)((TabControl)(((TabPage)this.Parent).Parent)).Parent).SetNewPicture(this.SelectedImage);
                }
                catch (Exception ex)
                {}
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (Rect.Contains(e.Location))
                {
                    //ToDo:
                    // Rechtsklick-Funktionen
                }
            }
        }

        /// <summary>
        /// Draw Rectangle
        /// </summary>        
        private void pictureBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            Point tempEndPoint = e.Location;

            Rect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y));

            Rect.Size = new Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y));

            this.pictureBox.Invalidate();
        }

        private void pictureBox_MouseLeave(object sender, System.EventArgs e)
        {
            try
            {
                if (Rect.Width > 0 && Rect.Height > 0)
                {
                    this.SelectedImage = ((Bitmap)this.pictureBox.Image).Clone(Rect, System.Drawing.Imaging.PixelFormat.Format16bppArgb1555);
                    ((CtrlTileEditControl)((TabControl)(((TabPage)this.Parent).Parent)).Parent).SetNewPicture(this.SelectedImage);
                }
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// Start Rectangle
        /// </summary>        
        private void pictureBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Determine the initial rectangle coordinates...
            RectStartPoint = e.Location;
            this.pictureBox.Invalidate();
        }

        private void ColourComponentValueChangedEventHandler(object sender, EventArgs e)
        {
            lblBlueValue.Text = trcBlue.Value.ToString();
            lblGreenValue.Text = trcGreen.Value.ToString();
            lblRedValue.Text = trcRed.Value.ToString();

            ApplyFilter(true);
        }

        #endregion

        private void CloseTab_Click(object sender, EventArgs e)
        {
            try
            {
                ((TabControl)((TabPage)this.Parent).Parent).TabPages.Remove(((TabPage)this.Parent));
            }
            catch (Exception ex)
            { }
        }
    }
}
