using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using nsTileMaker.Forms;

namespace nsTileMaker.lib
{
    public class CtrlTargetGridView : CtrlTileSetGridView
    {
        #region Members
        private Bitmap tempImage;

        #endregion

        #region Properties

        #endregion

        /// <summary>
        /// Initializes a new instance of TargetGridView
        /// This is the target tileset! Changes made here are saved.
        /// </summary>
        public CtrlTargetGridView()
        {
            #region Initialize Member

            #endregion

        }

        #region Public methods


        /// <summary>
        /// Creates an empty TileSet GridView
        /// </summary>
        /// <param name="tileset">TileSet object which indicates TileType</param>
        public void CreateBlank(TileSet tileset)
        {
            this.Tile       =   tileset;

            this.FillTile((this.Tile.GetSize.Width / this.Tile.GetCellSize.Width), (this.Tile.GetSize.Height / this.Tile.GetCellSize.Height));
        }

        #endregion

        #region private methods
        
        #endregion

        #region Overrides

        /// <summary>
        /// load current tileset into the gridview
        /// </summary>
        protected override void LoadTileSet()
        {
            Bitmap target = new Bitmap(this.Tile.Path, false);
            
            // prepare ProgressBar
            ((CtrlTileEditControl)this.Parent).LoadingLabel.Visible = true;
            ((CtrlTileEditControl)this.Parent).Progressbar.Visible = true;
            ((CtrlTileEditControl)this.Parent).Progressbar.Maximum = ((target.Height / Tile.GetCellSize.Height));
            ((CtrlTileEditControl)this.Parent).LoadingLabel.Update();            

            // index for filling the grid
            int rowIndex = 0;
            int cellIndex = 0;
            
            // first cell
            DataGridViewCell currentCell = this.Rows[rowIndex].Cells[cellIndex];

            foreach (Tile tile in this.SeperateTiles(target, this.Tile.GetRowAmount, this.Tile.GetColumnAmount, this.Tile.GetCellSize))
            {
                currentCell.Value = tile.Image;

                // next cell
                cellIndex++;

                // check if move to next row is neccessary
                if (cellIndex == this.Columns.Count)
                {                    
                    rowIndex++;
                    cellIndex = 0;
                }

                if (rowIndex < this.Tile.GetRowAmount)
                    currentCell = this.Rows[rowIndex].Cells[cellIndex];
                else
                    break;
            }            

            // hide ProgressBar
            ((CtrlTileEditControl)this.Parent).Progressbar.Value = 0;
            ((CtrlTileEditControl)this.Parent).Progressbar.Visible = false;
            ((CtrlTileEditControl)this.Parent).LoadingLabel.Visible = false;
        }

        /// <summary>
        /// Converts tilesets to a List of Tile objects
        /// </summary>
        /// <param name="source">Bitmap object of the target TileSet</param>
        /// <param name="colAmount">amount of Columns</param>
        /// <param name="rowAmount">amount of rows</param>
        /// <param name="tileSize">size of each tile</param>
        /// <returns>List of Tile</returns>
        protected override List<Tile> SeperateTiles(Bitmap source, int rowAmount, int colAmount, Size tileSize)
        {            
            List<Tile> TileList = new List<Tile>();

            // boundarys of image
            int maxWidth    =   source.Width;
            int maxHeight   =   source.Height;
            
            Point p = new Point(0, 0);
            int[] cells     =   new int[rowAmount * colAmount];

            //go through columns and rows, adding each tile to tileList
            //for (int i = 0; i < cells; i++)
            foreach(int i in cells)
            {                
                TileList.Add(new Tile(tileSize, source.Clone(new RectangleF(p, tileSize), System.Drawing.Imaging.PixelFormat.Format16bppRgb555)));
                    
                // next tile in row
                p.X += tileSize.Width;

                if (p.X >= maxWidth)
                {
                    // Perform progress step                    
                    ((CtrlTileEditControl)this.Parent).Progressbar.PerformStep();

                    p.X = 0;

                    // move startpoint p to next column
                    p.Y += tileSize.Height;

                    // catch the end of the file
                    if (p.Y >= maxHeight)
                        return TileList;
                }
            }
            return TileList;
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

                ((CtrlTileEditControl)this.Parent).SetOldPicture(tempIMG);

                // New selection colour
                Bitmap temp = (Bitmap)this.CurrentCell.Value;
                temp = (Bitmap)temp.GetThumbnailImage(temp.Size.Width *2, temp.Size.Height *2, null, System.IntPtr.Zero);

                base.OnCellEnter(e);
                this.CurrentCell.Value = temp;
            }            
        }        

        #endregion


    }
}
