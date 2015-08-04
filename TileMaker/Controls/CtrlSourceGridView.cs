using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using nsTileMaker.Forms;

namespace nsTileMaker.lib
{
    public class CtrlSourceGridView : CtrlTileSetGridView
    {
        #region Members

        public const bool IsSource = true;

        private Bitmap tempImage;

        #endregion

        #region Accessors

        #endregion

        /// <summary>
        /// Initializes a new instance of SourceGridView
        /// This is the source tileset. Changes here won´t be saved
        /// </summary>
        public CtrlSourceGridView(TileSet sourceTile)
        {
            #region Initialize Member

            #endregion

            #region Initialize GridView            
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BackgroundColor = System.Drawing.Color.White;
            this.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;           
            this.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            #endregion
        }

        #region Public methods

        #endregion

        #region private methods

        #endregion

        //ToDo:

        #region Overrides

        // Drag n drop
        protected override void OnDragDrop(DragEventArgs drgevent)
        {

            base.OnDragDrop(drgevent);
        }


        /// <summary>
        /// Resets preview image
        /// </summary>        
        protected override void OnCellLeave(DataGridViewCellEventArgs e)
        {
            this.CurrentCell.Value = this.tempImage;
            base.OnCellLeave(e);
        }

        /// <summary>
        /// Overrides OnCellEnter method
        /// sets preview picture in the TileGridForm and highlights the current selection
        /// </summary>        
        protected override void OnCellEnter(DataGridViewCellEventArgs e)
        {
            this.tempImage = (Bitmap)this.CurrentCell.Value;
            Image tempIMG = null;

            if (CurrentCell.Value != null)
            {
                tempIMG = ((Image)this.CurrentCell.Value).GetThumbnailImage(48, 48, null, System.IntPtr.Zero);

                ((CtrlTileEditControl)((TabControl)(((TabPage)this.Parent).Parent)).Parent).SetNewPicture(tempIMG);

                // New selection colour
                Bitmap temp = (Bitmap)this.CurrentCell.Value;
                temp = (Bitmap)temp.GetThumbnailImage(temp.Size.Width * 2, temp.Size.Height * 2, null, System.IntPtr.Zero);

                base.OnCellEnter(e);

                this.CurrentCell.Value = temp;
            }
            
        }

        #endregion
    }
}
