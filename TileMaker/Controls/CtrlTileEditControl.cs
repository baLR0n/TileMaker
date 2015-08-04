using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using nsTileMaker.lib;
using nsTileMaker.lib.Style;
using nsTileMaker.Controls;
using System.Windows.Forms;

namespace nsTileMaker.Forms
{
    public partial class CtrlTileEditControl : UserControl
    {
        #region Member

        private TileSet TargetTile;
        private TileSet SourceTile;

        private OpenFileDialog FileDia1;
        private OpenFileDialog FileDia2;

        private SaveFileDialog SaveDia1;
        private SaveFileDialog SaveDia2;

        private List<Control> SourceList;

        private VersionInfo.Versions SelectedVersion;

        // Lets the user choose which kind of blank tileset should be opened
        private FrmNewGridForm newGridDia;
        
        private Control ActiveControl;
        
        // Indicates if the content needs to be saved before closing the form
        private bool HasChanged;

        #endregion

        #region Properties

        public ToolStripProgressBar Progressbar
        {            
            get { return this.ToolStripProgressBar; }
        }

        public Label LoadingLabel
        {
            get { return this.lblLoading; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an new instance of TileEditControl with a given TileSet
        /// </summary>
        /// <param name="target">Tileset given via parameter</param>
        public CtrlTileEditControl(TileSet target)
        {
            this.RunStartUpMethods();
         
            // open directly with given Tileset
            // reset all the controls
            this.UncheckButtons();

            // fill tilegrid with tileset
            this.GridView.Fill(this.TargetTile);

            // check type-button and set info text
            this.CheckTypeButton(this.TargetTile.GetID);
        }

        /// <summary>
        /// Initializes an new instance of TileEditControl
        /// </summary>
        public CtrlTileEditControl()
        {
            this.RunStartUpMethods();
        }

        #endregion

        #region public methods

        /// <summary>
        /// Sets picturebox image value
        /// </summary>
        /// <param name="img">image to display</param>
        public void SetNewPicture(Image img)
        {
            Bitmap temp = new Bitmap(img, this.pictureBoxNew.Size);
            this.pictureBoxNew.Image = temp;
        }

        /// <summary>
        /// Sets picturebox image value
        /// </summary>
        /// <param name="img">image to display</param>
        public void SetOldPicture(Image img)
        {
            this.pictureBoxOld.Image = img;
        }

        /// <summary>
        /// Negotiates the member boolean HasChanged
        /// </summary>
        public void SwitchHasChanged()
        {
            this.HasChanged = !this.HasChanged;
        }        

        #endregion

        #region private methods

        /// <summary>
        /// Saves the changes to TileSet1 in a customized location
        /// </summary>
        private void SaveAs()
        {
            SaveDia1.Filter = "Picture files|*.png;*.bmp;*.jpg;";
            if (SaveDia1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // create file if it doesn´t exist
                if (!File.Exists(SaveDia1.FileName))
                {
                    File.Create(SaveDia1.FileName).Close();
                }

                // Save new image from TileSetGridView
                this.GridView.ToImage().Save(SaveDia1.FileName);
            }
            this.HasChanged = false;
        }

        /// <summary>
        /// Save the changes to TileSet1
        /// </summary>
        private void Save()
        {
            if (this.TargetTile.Path != null && File.Exists(this.TargetTile.Path))
            {
                // save changes to TileSet
                this.GridView.ToImage().Save(this.TargetTile.Path);
            }
            this.HasChanged = false;
        }

        /// <summary>
        /// Uncheck the controls
        /// </summary>
        private void UncheckButtons()
        {
            this.ToolStripA1.Checked = false;
            this.ToolStripA2.Checked = false;
            this.ToolStripA3.Checked = false;
            this.ToolStripA4.Checked = false;
            this.ToolStripA5.Checked = false;
            this.ToolStripA6.Checked = false;
        }

        /// <summary>
        /// Checks the button to indicate active tileset type
        /// </summary>
        /// <param name="ID">ID of Tileset</param>        
        private void CheckTypeButton(int ID)
        {
            switch (ID)
            {
                case 1:
                    this.ToolStripA1.Checked = true;
                    break;
                case 2:
                    this.ToolStripA2.Checked = true;
                    break;
                case 3:
                    this.ToolStripA3.Checked = true;
                    break;
                case 4:
                    this.ToolStripA4.Checked = true;
                    break;
                case 5:
                    this.ToolStripA5.Checked = true;
                    break;
                case 6:
                    this.ToolStripA6.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Add a new TabPage with a SourceGridView
        /// </summary>
        /// <param name="name">name of the TabPage</param>
        /// <param name="GridView">SourceGridView object</param>
        private void AddSourceTileSetPage(string name, CtrlSourceGridView GridView)
        {
            // Add new page
            this.SourceTileSetTabControl.TabPages.Add(name);
            TabPage newt = new TabPage();
            
            // Add SourceGridView to page
            this.SourceTileSetTabControl.TabPages[this.SourceTileSetTabControl.TabPages.Count - 1].Controls.Add(GridView);            
            this.SourceTileSetTabControl.TabPages[this.SourceTileSetTabControl.TabPages.Count - 1].ContextMenuStrip = this.TabPageContextMenu;            
            this.SourceTileSetTabControl.TabPages[this.SourceTileSetTabControl.TabPages.Count - 1].AutoScroll = true;            
            this.SourceTileSetTabControl.SelectTab(this.SourceTileSetTabControl.TabPages.Count - 1);

            // Initialize new page and it´s content
            GridView.Parent     =   this.SourceTileSetTabControl.TabPages[this.SourceTileSetTabControl.TabPages.Count - 1];
            GridView.Fill(this.SourceTile);
            GridView.Size       =   new Size(this.SourceTile.GetSize.Width + 20, this.SourceTile.GetSize.Height + 20);

            //this.SourceTileSetTabControl.SelectedTab.Width = GridView.Size.Width;

            // add new SourceGridView to intern list
            this.SourceList.Add(GridView);
        }

        /// <summary>
        /// Add a new TabPage with a SourceImage control
        /// </summary>
        /// <param name="path">path of the image</param>
        /// <param name="img">image file itself</param>
        private void AddSourceImage(string path, Image img)
        {
            // Add new page
            this.SourceTileSetTabControl.TabPages.Add(path);

            // create Image control
            SourceImage ImageControl = new SourceImage(img);            

            // Add SourceGridView to page
            this.SourceTileSetTabControl.TabPages[this.SourceTileSetTabControl.TabPages.Count - 1].Controls.Add(ImageControl);
            this.SourceTileSetTabControl.SelectTab(this.SourceTileSetTabControl.TabPages.Count - 1);

            this.SourceList.Add(ImageControl);
        }

        /// <summary>
        /// Run several methods to initialize the control
        /// </summary>
        private void RunStartUpMethods()
        {
            this.InitializeComponent();
            this.SourceList                 =   new List<Control>();
            this.CenterToolStrip.Renderer   =   new MyRenderer();
            this.ActiveControl              =   new Control();
        }

        /// <summary>
        /// Opens a blank tileset to edit
        /// </summary>
        private void OpenBlank()
        {
            // reset all the controls
            this.UncheckButtons();

            this.newGridDia = new FrmNewGridForm();
            this.newGridDia.ShowDialog();

            // create empty tileset
            this.TargetTile = new TileSet(newGridDia.ID, new VersionInfo(this.SelectedVersion));
            this.Parent.Text = "Blank TileSet";

            this.CheckTypeButton(this.TargetTile.GetID);
            this.GridView.CreateBlank(this.TargetTile);
        }

        #endregion

        #region Control events

        /// <summary>
        /// Opens a dialog for opening a new first tileset
        /// </summary>
        private void OpenTarget()
        {
            if (FileDia1.ShowDialog() == DialogResult.OK)
            {
                this.Cursor         =   Cursors.WaitCursor;
                // reset all the controls
                this.UncheckButtons();

                // fill tilegrid with tileset
                this.TargetTile     =   new TileSet(FileDia1.FileName, FileDia1.FileName, new VersionInfo(this.SelectedVersion));
                this.Parent.Text    =   this.TargetTile.Path;
                this.GridView.Fill(this.TargetTile);

                // check button with active tiletype
                this.CheckTypeButton(this.TargetTile.GetID);
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Opens a dialog for opening a new second tileset
        /// </summary>
        private void OpenSource()
        {
            this.Cursor = Cursors.WaitCursor;

            if (FileDia2.ShowDialog() == DialogResult.OK)
            {
                this.SourceTile = new TileSet(FileDia2.FileName, FileDia2.FileName, new VersionInfo(this.SelectedVersion));
                
                // check if sourcetile got the same type as targettile
                if ((this.TargetTile != null) && (!(this.SourceTile.GetID == this.TargetTile.GetID)))
                {
                    if (MessageBox.Show("TileSets don´t match! Continue?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.AddSourceTileSetPage(FileDia2.SafeFileName, new CtrlSourceGridView(this.SourceTile));
                    }
                }
                else
                {
                    this.AddSourceTileSetPage(FileDia2.SafeFileName, new CtrlSourceGridView(this.SourceTile));
                }
            }
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Opens a dialog to select an Image to load as a source
        /// </summary>
        private void OpenImageSource()
        {
            OpenFileDialog ImgDialog = new OpenFileDialog();

            if (ImgDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.AddSourceImage(ImgDialog.SafeFileName, new Bitmap(ImgDialog.FileName));
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid file!");
                }
            }
        }

        /// <summary>
        /// Switches the image value from the Tileset with the selected new one
        /// </summary>
        private void Switch()
        {
            try
            {
                if (this.SourceTileSetTabControl.SelectedTab.Controls[0].ToString() == "nsTileMaker.lib.CtrlSourceGridView")
                {
                    if (GridView.CurrentSelection != null && ((CtrlSourceGridView)this.SourceList[this.SourceTileSetTabControl.SelectedIndex]).CurrentSelection != null)
                    {
                        // replace tile
                        this.GridView.AddAt(this.GridView.CurrentSelection.RowIndex, this.GridView.CurrentSelection.ColumnIndex, ((CtrlSourceGridView)this.SourceList[this.SourceTileSetTabControl.SelectedIndex]).CurrentSelection);
                    }
                }
                else if (this.SourceTileSetTabControl.SelectedTab.Controls[0].ToString() == "nsTileMaker.Controls.SourceImage")
                {
                    if (GridView.CurrentSelection != null && ((SourceImage)this.SourceTileSetTabControl.SelectedTab.Controls[0]).Selection != null)
                    {
                        // replace tile
                        //ToDo färbung mitnehmen!
                        this.GridView.AddAt(this.GridView.CurrentSelection.RowIndex, this.GridView.CurrentSelection.ColumnIndex, ((SourceImage)this.SourceTileSetTabControl.SelectedTab.Controls[0]).Selection);
                    }
                }
            }
            catch(Exception ex) {}
        }

        /// <summary>
        /// Open a new RPGMaker 2000 / 2k3 TileSet
        /// </summary>
        private void Open2kTarget_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMaker2000;
            this.OpenTarget();
        }

        /// <summary>
        /// Open a new RPGMaker XP TileSet
        /// </summary>
        private void OpenXPTarget_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerXP;
            this.OpenTarget();
        }

        /// <summary>
        /// Open a new RPGMaker VX Ace TileSet
        /// </summary>
        private void OpenVXAce_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerVX;
            this.OpenTarget();
        }

        private void Open2k3_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMaker2000;
            this.OpenTarget();

        }

        private void OpenXP_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerXP;
            this.OpenTarget();
        }

        private void OpenVX_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerVX;
            this.OpenTarget();
        }

        /// <summary>
        /// Open a new RPGMaker 2000 / 2k3 TileSet as a source
        /// </summary>
        private void Open2kSource_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMaker2000;
            this.OpenSource();
        }

        /// <summary>
        /// Open a new RPGMaker XP TileSet as a source
        /// </summary>
        private void OpenXPSource_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerXP;
            this.OpenSource();
        }

        /// <summary>
        /// Open a new RPGMaker VX Ace TileSet as a source
        /// </summary>
        private void OpenVXSource_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerVX;
            this.OpenSource();
        }

        private void OpenSource2k3_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMaker2k3;
            this.OpenSource();
        }

        private void OpenSourceXP_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerXP;
            this.OpenSource();
        }

        private void OpenSourceVX_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerVX;
            this.OpenSource();
        }
        /// <summary>
        /// Opens a dialog for opening an image
        /// </summary>
        private void OpenSrcImage_Click(object sender, EventArgs e)
        {
            // ToDo:            
            this.OpenImageSource();
        }

        private void OpenSourceImage_Click(object sender, EventArgs e)
        {
            this.OpenImageSource();
        }

        private void BlankRPGMVXAce_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerVX;
            this.OpenBlank();
        }

        private void BlankRPGMXP_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMakerXP;
            this.OpenBlank();
        }

        private void BlankRPGM2000_Click(object sender, EventArgs e)
        {
            this.SelectedVersion = VersionInfo.Versions.RPGMaker2000;
            this.OpenBlank();
        }

        /// <summary>
        /// Transport selected Tile from sourcetile to selected tile from targettile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSwitchTile_Click(object sender, EventArgs e)
        {
            this.Switch();
            this.ActiveControl.Focus();
        }       

        /// <summary>
        /// Saves the changes to TileSet1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveTile1_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        /// <summary>
        /// Saves the changes to TileSet1 in a custom location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsTile1_Click(object sender, EventArgs e)
        {
            this.SaveAs();
        }

        /// <summary>
        /// Saves the changes to TileSet1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CenterSaveButton_Click(object sender, EventArgs e)
        {
            this.SaveAs();
        }

        /// <summary>
        /// Transport selected tile form the source to replace the selected target
        /// </summary>  
        private void transportSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BtnSwitchTile.Focus();
            this.Switch();
            this.ActiveControl.Focus();
        }

        #endregion

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ((TabControl)((TabPage)this.Parent).Parent).TabPages.Remove(((TabPage)this.Parent));
            }
            catch (Exception ex)
            { }
        }
        

        #region CheckChanged

        
        //private void MenuItemXP_Click(object sender, EventArgs e)
        //{
        //    this.MenuItemXP.Checked = true;
        //    this.MenuItem2000.Checked = false;
        //    this.MenuItem2k3.Checked = false;
        //    this.MenuItemVXAce.Checked = false;
        //    this.SelectedVersion = VersionInfo.Versions.RPGMakerXP;
        //}

        //private void MenuItemVXAce_Click(object sender, EventArgs e)
        //{
        //    this.MenuItemVXAce.Checked = true;
        //    this.MenuItem2000.Checked = false;
        //    this.MenuItem2k3.Checked = false;
        //    this.MenuItemXP.Checked = false;
        //    this.SelectedVersion = VersionInfo.Versions.RPGMakerVX;
        //}

        //private void MenuItem2k3_Click(object sender, EventArgs e)
        //{
        //    this.MenuItem2k3.Checked = true;
        //    this.MenuItem2000.Checked = false;
        //    this.MenuItemXP.Checked = false;
        //    this.MenuItemVXAce.Checked = false;
        //    this.SelectedVersion = VersionInfo.Versions.RPGMaker2k3;
        //}

        //private void MenuItem2000_Click(object sender, EventArgs e)
        //{
        //    this.MenuItem2000.Checked = true;
        //    this.MenuItemVXAce.Checked = false;
        //    this.MenuItem2k3.Checked = false;
        //    this.MenuItemXP.Checked = false;
        //    this.SelectedVersion = VersionInfo.Versions.RPGMaker2000;
        //}
        #endregion
    }
}
