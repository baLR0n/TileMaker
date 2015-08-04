using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nsTileMaker.Forms;

namespace nsTileMaker
{
    public partial class MainForm : Form
    {
        private FrmAboutBox InfoBox;

        public MainForm(string[] args)
        {
            InitializeComponent();
            this.InfoBox = new FrmAboutBox();
            // check if program runs with argument
            if (args.Length > 0)
            {
                if (File.Exists(args.GetValue(0).ToString()))
                {
                    TileSet ParamTileSet = new TileSet(args.GetValue(0).ToString(), args.GetValue(0).ToString(), new lib.VersionInfo());
                    this.AddPage(new CtrlTileEditControl(ParamTileSet), ParamTileSet.Path);                        
                }
            }
        }

        /// <summary>
        /// Add new page into the main Tabcontrol.
        /// </summary>
        /// <param name="NewCtrl">New control to fill the TabPage</param>
        /// <param name="text">Text of the TabPage</param>
        private void AddPage(CtrlTileEditControl NewCtrl, string text)
        {
            NewCtrl.Dock = DockStyle.Fill;
            this.MainTabControl.TabPages.Add(string.Format("TileSet {0}", this.MainTabControl.TabPages.Count + 1));
            this.MainTabControl.TabPages[this.MainTabControl.TabPages.Count - 1].Controls.Add(NewCtrl);            
            this.MainTabControl.TabPages[this.MainTabControl.TabPages.Count - 1].Text = text;
            this.MainTabControl.SelectTab(this.MainTabControl.TabPages.Count - 1);
        }

        /// <summary>
        //  Initialize TileEditControl and add it to new tabpage
        /// </summary>
        private void ToolMenuItemNew_Click(object sender, EventArgs e)
        {
            this.AddPage(new CtrlTileEditControl(), "Edit TileSet");
        }

        /// <summary>
        //  Initialize TileEditControl and add it to new tabpage
        /// </summary>
        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            this.AddPage(new CtrlTileEditControl(), "Edit TileSet");
        }

        private void ToolMenuItemClose_Click(object sender, EventArgs e)
        {
            //ToDo
            // check open dialogs

            this.Close();
        }

        /// <summary>
        /// Show AboutBox
        /// </summary>        
        private void MenuInfo_Click(object sender, EventArgs e)
        {
            this.InfoBox.ShowDialog();
        }
    }
}
