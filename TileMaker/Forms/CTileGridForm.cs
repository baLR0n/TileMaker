//using System;
//using System.IO;
//using System.Drawing;
//using System.Windows.Forms;
//using nsTileMaker.Forms;
//using nsTileMaker.lib;
//using nsTileMaker.lib.Style;


//namespace nsTileMaker
//{
//    public partial class TileGridForm : Form
//    {
//        #region Member       

//        private TileSet         TargetTile;
//        private TileSet         SourceTile;

//        private OpenFileDialog  FileDia1;
//        private OpenFileDialog  FileDia2;

//        private SaveFileDialog  SaveDia1;
//        private SaveFileDialog  SaveDia2;

//        private NewGridForm     newGridDia;

//        private Control         ActiveControl;

//        #endregion

//            //        this.TileGrid1 = new TileSetGridView(true);
//            //this.TileGrid2 = new TileSetGridView(false);
//        public TileGridForm(TileSet target)
//        {
//            InitializeComponent();
//            this.TargetTile                 =   target;
//            this.CenterToolStrip.Renderer   =   new MyRenderer();
//            this.ActiveControl              =   new Control();            
//        }

//        public TileGridForm()
//        {
//            InitializeComponent();
//            this.CenterToolStrip.Renderer   =   new MyRenderer();
//            this.ActiveControl              =   new Control();
//        }

//        /// <summary>
//        /// Sets picturebox image value
//        /// </summary>
//        /// <param name="img">image to display</param>
//        public void SetNewPicture(Image img)
//        {
//            this.pictureBoxNew.Image    =   img;
//        }

//        /// <summary>
//        /// Sets picturebox image value
//        /// </summary>
//        /// <param name="img">image to display</param>
//        public void SetOldPicture(Image img)
//        {
//            this.pictureBoxOld.Image    =   img;
//        }

//        /// <summary>
//        /// Saves the changes to TileSet1 in a customized location
//        /// </summary>
//        private void SaveAs()
//        {
//            SaveDia1.Filter         =       "Picture files|*.png;*.bmp;*.jpg;";
//            if (SaveDia1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
//            {
//                // create file if it doesn´t exist
//                if (!File.Exists(SaveDia1.FileName))
//                {
//                    File.Create(SaveDia1.FileName).Close();
//                }              

//                // Save new image from TileSetGridView
//                this.TileGrid1.ToImage().Save(SaveDia1.FileName);
//            }
//        }

//        /// <summary>
//        /// Save the changes to TileSet1
//        /// </summary>
//        private void Save()
//        {
//            if (this.TargetTile.Path != null && File.Exists(this.TargetTile.Path))
//            {
//                // save changes to TileSet
//                this.TileGrid1.ToImage().Save(this.TargetTile.Path);
//            }
//        }
       
//        /// <summary>
//        /// Uncheck the controls
//        /// </summary>
//        private void UncheckButtons()
//        {
//            this.ToolStripA1.Checked = false;
//            this.ToolStripA2.Checked = false;
//            this.ToolStripA3.Checked = false;
//            this.ToolStripA4.Checked = false;
//            this.ToolStripA5.Checked = false;
//            this.ToolStripA6.Checked = false;
//        }

//        /// <summary>
//        /// Checks the button to indicate active tileset type
//        /// </summary>
//        /// <param name="ID">ID of Tileset</param>        
//        private void CheckTypeButton(int ID)
//        {
//            switch (ID)
//            {
//                case 1:                    
//                    this.ToolStripA1.Checked = true;
//                    break;
//                case 2:                    
//                    this.ToolStripA2.Checked = true;
//                    break;
//                case 3:                    
//                    this.ToolStripA3.Checked = true;
//                    break;
//                case 4:                    
//                    this.ToolStripA4.Checked = true;
//                    break;
//                case 5:
//                        this.ToolStripA5.Checked = true;
//                        break;
//                case 6:
//                        this.ToolStripA6.Checked = true;
//                        break;
//            }
//        }

//        #region Control events

//        /// <summary>
//        /// Opens a dialog for opening a new first tileset
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void OpenTile1_Click(object sender, EventArgs e)
//        {
//            if (FileDia1.ShowDialog() == DialogResult.OK)
//            {
//                // reset all the controls
//                this.UncheckButtons();
                
//                // fill tilegrid with tileset
//                this.TargetTile     =   new TileSet(FileDia1.FileName, FileDia1.FileName);
//                this.Text           =   this.TargetTile.Path;
//                this.TileGrid1.Fill(this.TargetTile);

//                // check button with active tiletype
//                this.CheckTypeButton(this.TargetTile.GetID);
//                this.Height      =   this.TargetTile.GetSize.Height + 200;
//            }
//        }

//        /// <summary>
//        /// Creates a empty TileGrid for customizing
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void OpenTile1Blank_Click(object sender, EventArgs e)
//        {
//            // reset all the controls
//            this.UncheckButtons();

//            this.newGridDia     =   new NewGridForm();
//            this.newGridDia.ShowDialog();

//            // create empty tileset
//            this.TargetTile     =   new TileSet(newGridDia.ID);
//            this.Text           =   "Blank TileSet";
            
//            this.CheckTypeButton(this.TargetTile.GetID);
//            this.TileGrid1.CreateBlank(this.TargetTile);

//        }

//        /// <summary>
//        /// Opens a dialog for opening a new second tileset
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void OpenTile2_Click(object sender, EventArgs e)
//        {
//            //if (FileDia2.ShowDialog() == DialogResult.OK)
//            //{
//            //    this.SourceTile = new TileSet(FileDia2.FileName, FileDia2.FileName);

//            //    // check if sourcetile got the same type as targettile
//            //    if (!(this.SourceTile.GetID == this.TargetTile.GetID))
//            //    {
//            //        if (MessageBox.Show("TileSets don´t match! Continue?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
//            //        {
//            //            this.TileGrid2.Fill(this.SourceTile);
//            //        }
//            //    }
//            //    else
//            //    {
//            //        this.TileGrid2.Fill(this.SourceTile);
//            //    }
//            //}
//        }

//        /// <summary>
//        /// Transport selected Tile from sourcetile to selected tile from targettile
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void BtnSwitchTile_Click(object sender, EventArgs e)
//        {
//            if (TileGrid1.CurrentSelection != null && TileGrid2.CurrentSelection != null)
//            {
//                // replace tile
//                this.TileGrid1.AddAt(this.TileGrid1.CurrentSelection.RowIndex, this.TileGrid1.CurrentSelection.ColumnIndex, this.TileGrid2.CurrentSelection);
//            }
//            this.ActiveControl.Focus();
//        }

//        /// <summary>
//        /// Saves the changes to TileSet1
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void SaveTile1_Click(object sender, EventArgs e)
//        {
//            this.Save();
//        }

//        /// <summary>
//        /// Saves the changes to TileSet1 in a custom location
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void SaveAsTile1_Click(object sender, EventArgs e)
//        {
//            this.SaveAs();
//        }

//        /// <summary>
//        /// Saves the changes to TileSet1
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void CenterSaveButton_Click(object sender, EventArgs e)
//        {
//            this.SaveAs();
//        }

//        private void transportSelectionToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            if (TileGrid1.CurrentSelection != null && TileGrid2.CurrentSelection != null)
//            {
//                // replace tile
//                this.TileGrid1.AddAt(this.TileGrid1.CurrentSelection.RowIndex, this.TileGrid1.CurrentSelection.ColumnIndex, this.TileGrid2.CurrentSelection);
//                this.ActiveControl.Focus();
//            }
//        }
//        #endregion       
//    }
//}
