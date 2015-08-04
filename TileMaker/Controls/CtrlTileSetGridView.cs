using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using nsTileMaker.Forms;
using System.ComponentModel;

namespace nsTileMaker.lib
{
    public class CtrlTileSetGridView : DataGridView
    {
        #region Members
        protected       TileSet             Tile;
        protected       bool                isSource;

        #endregion

        #region Properties

        /// <summary>
        /// Get currently selected cell
        /// </summary>
        public DataGridViewCell CurrentSelection
        {
            get
            {
                try
                {
                    return this.SelectedCells[0];
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of TileSetGridView
        /// </summary>
        public CtrlTileSetGridView()
        {        }

        /// <summary>
        /// Initializes a new instance of TileSetGridView
        /// </summary>
        /// <param name="TileSet">Target tileset</param>
        public CtrlTileSetGridView(bool isSource) 
        {
            //Initialize
            this.isSource       =   isSource;
        }

        #region Public methods

        /// <summary>
        /// Fill GridView with tiles from the file
        /// </summary>
        /// <param name="TileSet">Tileset to fill into control</param>
        public void Fill(TileSet TileSet)
        {
            //InitializeComponent();         
            this.Tile = TileSet;

            Bitmap temp = new Bitmap(this.Tile.Path);

            this.FillTile((temp.Width / this.Tile.GetCellSize.Width), (temp.Height / this.Tile.GetCellSize.Height));
            this.LoadTileSet();
        }

        /// <summary>
        /// Replace a tile in a cell with a new one
        /// </summary>
        /// <param name="iRowID">Row of tile to switch</param>
        /// <param name="iColumnID">column in row of tile to switch</param>
        /// <param name="newCell">new Cell object which replaces the old one</param>
        public void AddAt(int iRowID, int iColumnID, DataGridViewCell newCell)
        {            
            Image   temp        =   (Image)newCell.Value;
            this.AddAt(iRowID, iColumnID, temp);            
        }

        /// <summary>
        /// Replace a tile in a cell with a new one
        /// </summary>
        /// <param name="iRowID">Row of tile to switch</param>
        /// <param name="iColumnID">column in row of tile to switch</param>
        /// <param name="newImage">new Image object which replaces the old one</param>
        public void AddAt(int iRowID, int iColumnID, Image newImage)
        {            
            Bitmap tempbmp = new Bitmap(newImage, this.Tile.GetCellSize.Width, this.Tile.GetCellSize.Height);
            //tempbmp = tempbmp.Clone(new Rectangle(0, 0, tempbmp.Width, tempbmp.Height), PixelFormat.Format16bppRgb555);

            this.Rows[iRowID].Cells[iColumnID].Value = tempbmp;
            ((CtrlTileEditControl)this.Parent).SwitchHasChanged();
        }

        /// <summary>
        /// Returns an Image object with the current Tiles
        /// </summary>
        /// <returns>Image object</returns>
        public Image ToImage()
        {
            // temporary file for temp saving
            string  tempfilename    =   String.Format(Path.GetTempPath() + "{0}", "\\tempTile.png");
            int     x               =   0;
            int     y               =   0;

            MemoryStream stream     =   null;
            Image   img             =   null;
            if (Tile.Path != null)
            {
                stream              =   new MemoryStream(File.ReadAllBytes(this.Tile.Path), true);
                img                 =   Image.FromStream(stream);
            }
            else
            {
                img                 =   new Bitmap(this.Tile.GetSize.Width, this.Tile.GetSize.Height, PixelFormat.Format16bppRgb555);
            }

            Bitmap BMP = new Bitmap(img);
            BMP = BMP.Clone(new Rectangle(0, 0, img.Width, img.Height), PixelFormat.Format16bppRgb555);

            Image       tempFile        =   BMP;
            Image       tempTile        =   null;
            Graphics    graph           =   Graphics.FromImage(tempFile);

            // go through rows and cells, adding the new tiles to graphics object
            foreach (DataGridViewRow row in this.Rows)
            {
                if (row.Index == this.Rows.Count - 1)
                    break;

                // go through cells
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                        tempTile = new Bitmap(this.Tile.GetCellSize.Width, this.Tile.GetCellSize.Height);
                    else
                        tempTile = (Image)cell.Value;

                    graph.DrawImage(tempTile, x, y, tempTile.Width, tempTile.Height);
                    graph.Dispose();

                    // save this change
                    tempFile.Save(tempfilename);

                    //ToDo: performance!
                    // renew stream and tempFile
                    stream      =   new MemoryStream(File.ReadAllBytes(tempfilename), true);
                    tempFile    =   Image.FromStream(stream);

                    // renew graphics object
                    graph       =   Graphics.FromImage(tempFile);

                    // add pixel ID to X-coordinate
                    x += tempTile.Size.Width;

                    stream.Dispose();
                }

                // add pixel ID to Y-coordinate
                y   +=  tempTile.Size.Height;
                x   =   0;

                // collect garbage
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            // delete tempTile file            
            File.Delete(tempfilename);
            return tempFile;
        }

        #endregion

        #region protected methods

        /// <summary>
        /// Creates the gridview for the tileset
        /// </summary>
        /// <param name="columnAmount">amount of columns in this tileset</param>
        /// <param name="rowAmount">amount of rows in this tileset</param>
        protected void FillTile(int columnAmount, int rowAmount)
        {
            // create basic grid content
            DataGridViewColumn  col     =   new DataGridViewImageColumn();
            DataGridViewRow     row     =   new DataGridViewRow();

            // clear content if neccessary
            this.Rows.Clear();
            this.Columns.Clear();

            // add columns
            for (int i = 0; i < columnAmount; i++)
            {
                this.Columns.Add(col);
                col = new DataGridViewImageColumn();
            }

            // add rows
            for (int j = 0; j < rowAmount; j++)
            {
                this.Rows.Add(row);
                row = new DataGridViewRow();
            }            
        }

        /// <summary>
        /// load current tileset into the gridview
        /// </summary>
        protected virtual void LoadTileSet()
        {
            Bitmap target = new Bitmap(this.Tile.Path, false);            

            // index for filling the grid
            int rowIndex    =   0;
            int cellIndex   =   0;

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

            // ToDo: Parent-Parent ist TileEditControl
            // hide ProgressBar
            //((CtrlTileEditControl)this.Parent).Progressbar.Value = 0;
            //((CtrlTileEditControl)this.Parent).Progressbar.Visible = false;
            //((CtrlTileEditControl)this.Parent).LoadingLabel.Visible = false;
        }

        /// <summary>
        /// Load new tileset into the gridview
        /// </summary>
        /// <param name="tileset">new tileset object</param>
        protected void LoadTileSet(TileSet tileset)
        {            
        }

        /// <summary>
        /// Converts tilesets to a List of Tile objects
        /// </summary>
        /// <param name="source">Bitmap object of the target TileSet</param>
        /// <param name="colAmount">amount of Columns</param>
        /// <param name="rowAmount">amount of rows</param>
        /// <param name="tileSize">size of each tile</param>
        /// <returns>List of Tile</returns>
        protected virtual List<Tile> SeperateTiles(Bitmap source, int rowAmount, int colAmount, ref int currentRow, ref int currentColumn, Size tileSize)
        {
            List<Tile> TileList = new List<Tile>();

            // boundarys of image
            int maxWidth = source.Width;
            int maxHeight = source.Height;

            //default values
            Point p = new Point(0, 0);
            int[] cells = new int[rowAmount * colAmount];

            //go through columns and rows, adding each tile to tileList
            //for (int i = 0; i < cells; i++)
            foreach (int i in cells)
            {
                TileList.Add(new Tile(tileSize, source.Clone(new RectangleF(p, tileSize), System.Drawing.Imaging.PixelFormat.Format16bppRgb555)));

                // next tile in row
                p.X += tileSize.Width;

                if (p.X >= maxWidth)
                {
                    p.X = 0;

                    // move startpoint p to next column
                    p.Y += tileSize.Height;

                    // catch the end of the file
                    if (p.Y >= maxHeight)
                        return TileList;
                }
                // Perform progress step                    
                //((CtrlTileEditControl)this.Parent).Progressbar.PerformStep();
            }
            return TileList;
        }

        /// <summary>
        /// Converts tilesets to a List of Tile objects
        /// </summary>
        /// <param name="source">Bitmap object of the target TileSet</param>
        /// <param name="colAmount">amount of Columns</param>
        /// <param name="rowAmount">amount of rows</param>
        /// <param name="tileSize">size of each tile</param>
        /// <returns>List of Tile</returns>
        protected virtual List<Tile> SeperateTiles(Bitmap source, int rowAmount, int colAmount, Size tileSize)
        {
            List<Tile> TileList = new List<Tile>();

            // boundarys of image
            int maxWidth    =   source.Width;
            int maxHeight   =   source.Height;

            Point p = new Point(0, 0);
            int[] cells     =   new int[rowAmount * colAmount];

            //go through columns and rows, adding each tile to tileList
            //for (int i = 0; i < cells; i++)
            foreach (int i in cells)
            {
                TileList.Add(new Tile(tileSize, source.Clone(new RectangleF(p, tileSize), System.Drawing.Imaging.PixelFormat.Format16bppRgb555)));

                // next tile in row
                p.X += tileSize.Width;

                if (p.X >= maxWidth)
                {
                    // Perform progress step                    
                    //((CtrlTileEditControl)this.Parent).Progressbar.PerformStep();

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

        #endregion        

        #region Overrides   

        #endregion


    }
}
public static class ImageExtensions
{
    public static byte[] ToByteArray(this Image image, ImageFormat format)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            image.Save(ms, format);
            return ms.ToArray();
        }
    }
}