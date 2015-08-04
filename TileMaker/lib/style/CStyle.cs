using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace nsTileMaker.lib.Style
{
    public class MyRenderer : ToolStripProfessionalRenderer
    {
        /// <summary>
        /// overrides actions performed when button background changes
        /// </summary>        
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var btn = e.Item as ToolStripButton;
            if (btn != null && btn.Checked)
            {
                Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(Brushes.LimeGreen, bounds);
                btn.ForeColor = Color.Black;
            }
            else base.OnRenderButtonBackground(e);
        }
    }
}
