using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using nsTileMaker.lib;

namespace nsTileMaker
{
    public class TileSet
    {

        #region Member
        protected     string      szName;
        protected     string      path;
        
        protected     int         iTypeID;

        protected     Size        size;
        protected     Size        cellSize;

        protected     VersionInfo vInfo;

        #endregion
        
        /// <summary>
        /// returns ID which indicates the type of the tilesets
        /// </summary>
        public int GetID
        {
            get { return this.iTypeID; }
        }

        /// <summary>
        /// returns ID which indicates the type of the tilesets
        /// </summary>
        public int GetRowAmount
        {
            get { return (this.size.Height / this.cellSize.Height); }
        }

        /// <summary>
        /// returns ID which indicates the type of the tilesets
        /// </summary>
        public int GetColumnAmount
        {
            get { return (this.size.Width / this.cellSize.Width); }
        }

        /// <summary>
        /// Solution of the tileset in pixel
        /// </summary>
        public Size GetSize
        {
            get { return this.size; }            
        }

        /// <summary>
        /// Solution of one single tile in pixel
        /// </summary>
        public Size GetCellSize
        {
            get { return this.cellSize; }
        }

        /// <summary>
        /// path to tileset file
        /// </summary>
        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }

        /// <summary>
        /// Gets or sets the VersionInfo for this TileSet
        /// </summary>
        public VersionInfo VersionInfo
        {
            get { return this.vInfo; }
            set { this.vInfo = value; }
        }

        #region Constructors

        protected TileSet() { }

        protected TileSet(string path) { }


        /// <summary>
        /// Initializes a new instance of CTileset class. Creates an empty tileset
        /// </summary>
        /// <param name="ID">Type-ID of the tileset</param>
        /// <param name="vInfo">VersionInfo object saved settings</param>
        public TileSet(int ID, VersionInfo vInfo)
        {
            this.iTypeID    =   ID;
            this.vInfo      =   vInfo;

            this.InitializeWithID(ID);
        }

        /// <summary>
        /// Initializes a new instance of CTileset class
        /// </summary>
        /// <param name="name">name of the tileset</param>
        /// <param name="path">path to the file</param>
        /// <param name="vInfo">VersionInfo object saved settings</param>
        public TileSet(string name, string path, VersionInfo vInfo)
        {
            // initialize Tileset information
            this.szName     =   name;
            this.path       =   path;
            this.vInfo      =   vInfo;

            // get picture
            Bitmap bmp = new Bitmap(path);

            // get type of TileSet
            this.iTypeID = RecognizeTileType(bmp.Size);
            this.InitializeWithID(this.iTypeID);
        }

        #endregion

        /// <summary>
        /// Trys to recognize the type of the TileSet by it´s size
        /// </summary>
        /// <param name="size">Size of the TileSet</param>
        /// <returns>ID which indicates TileType</returns>
        protected int RecognizeTileType(Size size)
        {
            switch (vInfo.Version)
            {
                case VersionInfo.Versions.RPGMaker2000:
                    return 1;
                case VersionInfo.Versions.RPGMaker2k3:
                    return 1;
                case VersionInfo.Versions.RPGMakerXP:
                    if (size.Width == 256)
                        return 1;
                    else
                        return 0;                    
                case VersionInfo.Versions.RPGMakerVX:
                    {
                        #region check VX tiletype
                        switch (size.Height)
                        {
                            case 384:
                                if (size.Width == 512)
                                    return 1;
                                else if (size.Width == 384)
                                    return 7;
                                return 0;
                            case 386:
                                return 2;
                            case 256:
                                return 3;
                            case 480:
                                return 4;
                            case 512:
                                if (size.Width == 256)
                                {
                                    return 5;
                                }
                                else
                                {
                                    return 6;
                                }                            
                        }
                        #endregion
                        return 0;
                    }
                default:
                    break;
            }

            return 0;
        }

        /// <summary>
        /// Sets all of the values after given tiletype ID
        /// </summary>
        /// <param name="ID">TileType ID</param>
        protected void InitializeWithID(int ID)
        {
            switch (ID)
            {
                case 0:
                    this.size = new Size(512, 3000);
                    this.cellSize = new Size(32, 32);
                    break;
                case 1:
                    this.size = new Size(this.vInfo.A1Size.Width, this.vInfo.A1Size.Height);
                    this.cellSize = new Size(this.vInfo.A1TileSize.Width, this.vInfo.A1TileSize.Height);
                    break;
                case 2:
                    this.size = new Size(this.vInfo.A2Size.Width, this.vInfo.A2Size.Height);
                    this.cellSize = new Size(this.vInfo.A2TileSize.Width, this.vInfo.A2TileSize.Height);
                    break;
                case 3:
                    this.size = new Size(this.vInfo.A3Size.Width, this.vInfo.A3Size.Height);
                    this.cellSize = new Size(this.vInfo.A3TileSize.Width, this.vInfo.A3TileSize.Height);
                    break;
                case 4:
                    this.size = new Size(this.vInfo.A4Size.Width, this.vInfo.A4Size.Height);
                    this.cellSize = new Size(this.vInfo.A4TileSize.Width, this.vInfo.A4TileSize.Height);
                    break;
                case 5:
                    this.size = new Size(this.vInfo.A5Size.Width, this.vInfo.A5Size.Height);
                    this.cellSize = new Size(this.vInfo.A5TileSize.Width, this.vInfo.A5TileSize.Height);
                    break;
                case 6:
                    this.size = new Size(this.vInfo.BCDESize.Width, this.vInfo.BCDESize.Height);
                    this.cellSize = new Size(this.vInfo.BCDETileSize.Width, this.vInfo.BCDETileSize.Height);
                    break;
                case 7:
                    this.size = new Size(this.vInfo.IconSize.Width, this.vInfo.IconSize.Height);
                    this.cellSize = new Size(this.vInfo.IconTileSize.Width, this.vInfo.IconTileSize.Height);
                    break;
                default:
                    break;
            }
        }
    }
}
