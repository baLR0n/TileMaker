using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;

namespace nsTileMaker.lib
{
    public class Tile
    {
        private     Size    size;
        private     Bitmap  BMPcontent;
        private byte[] content;

        public Bitmap Image
        {
            get { return this.BMPcontent; }
        }

        public byte[] Bytes
        {
            get { return this.content; }
        }

        public Tile(Size size, Bitmap content)
        {
            this.size       =   size;
            this.BMPcontent    =   content;
        }

        public Tile(Size size, byte[] content)
        {
            this.size = size;
            this.content = content;
        }
    }
}
