using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Xml;

namespace nsTileMaker.lib
{
    public class VersionInfo
    {
        #region Member

        private     string          c_ConfigPath = string.Format("{0}\\TileMakerConfig.xml", Environment.CurrentDirectory);
        
        private     XmlDocument     XMLConfig;               

        // Size of each type of TileSet
        private     Size        A1size;
        private     Size        A1Tilesize;
        private     Size        A2size;
        private     Size        A2Tilesize;
        private     Size        A3size;
        private     Size        A3Tilesize;
        private     Size        A4size;
        private     Size        A4Tilesize;
        private     Size        A5size;
        private     Size        A5Tilesize;
        private     Size        BCDEsize;
        private     Size        BCDETilesize;
        private     Size        Iconsize;
        private     Size        IconTilesize;
        
        private     Versions    version;
#endregion

        #region Accessors
        public Size A1Size
        {
            get { return A1size; }
        }

        public Size A1TileSize
        {
            get { return A1Tilesize; }
        }

        public Size A2Size
        {
            get { return A2size; }
        }

        public Size A2TileSize
        {
            get { return A2Tilesize; }
        }

        public Size A3Size
        {
            get { return A3size; }
        }

        public Size A3TileSize
        {
            get { return A3Tilesize; }
        }

        public Size A4Size
        {
            get { return A4size; }
        }

        public Size A4TileSize
        {
            get { return A4Tilesize; }
        }

        public Size A5Size
        {
            get { return A5size; }
        }

        public Size A5TileSize
        {
            get { return A5Tilesize; }
        }

        public Size BCDESize
        {
            get { return BCDEsize; }
        }

        public Size BCDETileSize
        {
            get { return BCDETilesize; }
        }

        public Size IconSize
        {
            get { return Iconsize; }
        }

        public Size IconTileSize
        {
            get { return IconTilesize; }
        }       

        public Versions Version
        {
            get { return version; }
        }
#endregion

        public enum Versions
        {
            RPGMaker2000 = 1,
            RPGMaker2k3 = 2, 
            RPGMakerXP = 3,
            RPGMakerVX = 4,
        }

        public VersionInfo()
        { }

        public VersionInfo(Size size)
        { }

        public VersionInfo(Size size, Size tileSize)
        { }

        public VersionInfo(Versions version)
        {
            this.SetVersion(version);
        }        


        public void SetVersion(Versions version)
        {
            // load XML config
            this.version    =   version;
            this.XMLConfig  =   new XmlDocument();
            this.XMLConfig.Load(c_ConfigPath);

            // load settings            
            this.LoadSettings();
        }


        /// <summary>
        /// Read settings from XML file and saves them
        /// </summary>
        /// <param name="version">Selected version</param>
        private void LoadSettings()
        {
            // Get first node named "configuration"
            XmlNode DocNode = this.XMLConfig.GetElementsByTagName("configuration")[0];            

            // Get setting node
            XmlNodeList WantedNodes = this.GetSettingNodes(DocNode, this.version);
            
            #region Fill values with settings
            
            // A1
            this.A1size.Width   =   Convert.ToInt32(WantedNodes[0].Attributes[0].Value);
            this.A1size.Height  =   Convert.ToInt32(WantedNodes[0].Attributes[1].Value);

            this.A1Tilesize.Width = Convert.ToInt32(WantedNodes[0].Attributes[2].Value);
            this.A1Tilesize.Height = Convert.ToInt32(WantedNodes[0].Attributes[3].Value);

            // A2
            this.A2size.Width = Convert.ToInt32(WantedNodes[1].Attributes[0].Value);
            this.A2size.Height = Convert.ToInt32(WantedNodes[1].Attributes[1].Value);

            this.A2Tilesize.Width = Convert.ToInt32(WantedNodes[1].Attributes[2].Value);
            this.A2Tilesize.Height = Convert.ToInt32(WantedNodes[1].Attributes[3].Value);
            
            // A3
            this.A3size.Width = Convert.ToInt32(WantedNodes[2].Attributes[0].Value);
            this.A3size.Height = Convert.ToInt32(WantedNodes[2].Attributes[1].Value);

            this.A3Tilesize.Width = Convert.ToInt32(WantedNodes[2].Attributes[2].Value);
            this.A3Tilesize.Height = Convert.ToInt32(WantedNodes[2].Attributes[3].Value);

            // A4
            this.A4size.Width = Convert.ToInt32(WantedNodes[3].Attributes[0].Value);
            this.A4size.Height = Convert.ToInt32(WantedNodes[3].Attributes[1].Value);

            this.A4Tilesize.Width = Convert.ToInt32(WantedNodes[3].Attributes[2].Value);
            this.A4Tilesize.Height = Convert.ToInt32(WantedNodes[3].Attributes[3].Value);

            // A5
            this.A5size.Width = Convert.ToInt32(WantedNodes[4].Attributes[0].Value);
            this.A5size.Height = Convert.ToInt32(WantedNodes[4].Attributes[1].Value);

            this.A5Tilesize.Width = Convert.ToInt32(WantedNodes[4].Attributes[2].Value);
            this.A5Tilesize.Height = Convert.ToInt32(WantedNodes[4].Attributes[3].Value);

            //B-C-D-E
            this.BCDEsize.Width = Convert.ToInt32(WantedNodes[5].Attributes[0].Value);
            this.BCDEsize.Height = Convert.ToInt32(WantedNodes[5].Attributes[1].Value);

            this.BCDETilesize.Width = Convert.ToInt32(WantedNodes[5].Attributes[2].Value);
            this.BCDETilesize.Height = Convert.ToInt32(WantedNodes[5].Attributes[3].Value);

            // Icon
            this.Iconsize.Width = Convert.ToInt32(WantedNodes[6].Attributes[0].Value);
            this.Iconsize.Height = Convert.ToInt32(WantedNodes[6].Attributes[1].Value);

            this.IconTilesize.Width = Convert.ToInt32(WantedNodes[6].Attributes[2].Value);
            this.IconTilesize.Height = Convert.ToInt32(WantedNodes[6].Attributes[3].Value);
            #endregion
        }


        /// <summary>
        /// Get settings from a specific version from XML config file
        /// </summary>
        /// <param name="TopNode">XMLNode to start searching</param>
        /// <param name="version">Versions value with wanted version</param>
        /// <returns></returns>
        private XmlNodeList GetSettingNodes(XmlNode TopNode, Versions version)
        {
            foreach (XmlNode child in TopNode.ChildNodes)
            {
                // check name values
                if (child.Attributes[0].Value == version.ToString())
                {
                    return child.ChildNodes;
                }
            }
            return null;
        }
    }
}
