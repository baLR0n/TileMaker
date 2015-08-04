using nsTileMaker.lib;

namespace nsTileMaker.Forms
{
    partial class CtrlTileEditControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlTileEditControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPictureNew = new System.Windows.Forms.Label();
            this.lblOldPicture = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemTile1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTile1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Open2kTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenXPTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenVXAce = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTile1Blank = new System.Windows.Forms.ToolStripMenuItem();
            this.BlankRPGM2000 = new System.Windows.Forms.ToolStripMenuItem();
            this.BlankRPGMXP = new System.Windows.Forms.ToolStripMenuItem();
            this.BlankRPGMVXAce = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTile1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsTile1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearTile1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTile2 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSrcTileSet = new System.Windows.Forms.ToolStripMenuItem();
            this.Open2kSource = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenXPSource = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenVXSource = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSrcImage = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSrcEmpty = new System.Windows.Forms.ToolStripMenuItem();
            this.transportSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDia2 = new System.Windows.Forms.OpenFileDialog();
            this.SaveDia1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveDia2 = new System.Windows.Forms.SaveFileDialog();
            this.BtnSwitchTile = new System.Windows.Forms.Button();
            this.CenterToolStrip = new System.Windows.Forms.ToolStrip();
            this.CenterSaveButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripA1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripA2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripA3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripA4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripA5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripA6 = new System.Windows.Forms.ToolStripButton();
            this.FileDia1 = new System.Windows.Forms.OpenFileDialog();
            this.SourceTileSetTabControl = new System.Windows.Forms.TabControl();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
            this.pictureBoxOld = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Open2k3 = new System.Windows.Forms.ToolStripButton();
            this.OpenXP = new System.Windows.Forms.ToolStripButton();
            this.OpenVX = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenSourceVX = new System.Windows.Forms.ToolStripButton();
            this.OpenSourceXP = new System.Windows.Forms.ToolStripButton();
            this.OpenSource2k3 = new System.Windows.Forms.ToolStripButton();
            this.OpenSourceImage = new System.Windows.Forms.ToolStripButton();
            this.TabPageContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.GridView = new nsTileMaker.lib.CtrlTargetGridView();
            this.menuStrip1.SuspendLayout();
            this.CenterToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.TabPageContextMenu.SuspendLayout();
            this.BottomStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPictureNew
            // 
            this.lblPictureNew.AutoSize = true;
            this.lblPictureNew.Location = new System.Drawing.Point(606, 404);
            this.lblPictureNew.Name = "lblPictureNew";
            this.lblPictureNew.Size = new System.Drawing.Size(29, 13);
            this.lblPictureNew.TabIndex = 15;
            this.lblPictureNew.Text = "New";
            // 
            // lblOldPicture
            // 
            this.lblOldPicture.AutoSize = true;
            this.lblOldPicture.Location = new System.Drawing.Point(606, 273);
            this.lblOldPicture.Name = "lblOldPicture";
            this.lblOldPicture.Size = new System.Drawing.Size(23, 13);
            this.lblOldPicture.TabIndex = 14;
            this.lblOldPicture.Text = "Old";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTile1,
            this.MenuItemTile2});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 30);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemTile1
            // 
            this.MenuItemTile1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTile1,
            this.OpenTile1Blank,
            this.SaveTile1,
            this.SaveAsTile1,
            this.toolStripSeparator1,
            this.ClearTile1});
            this.MenuItemTile1.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemTile1.Image")));
            this.MenuItemTile1.Name = "MenuItemTile1";
            this.MenuItemTile1.Size = new System.Drawing.Size(70, 26);
            this.MenuItemTile1.Text = "TileSet";
            // 
            // OpenTile1
            // 
            this.OpenTile1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open2kTarget,
            this.OpenXPTarget,
            this.OpenVXAce});
            this.OpenTile1.Image = global::nsTileMaker.Properties.Resources.open_button;
            this.OpenTile1.Name = "OpenTile1";
            this.OpenTile1.Size = new System.Drawing.Size(140, 22);
            this.OpenTile1.Text = "Open";
            // 
            // Open2kTarget
            // 
            this.Open2kTarget.Image = global::nsTileMaker.Properties.Resources.rpgm2k3;
            this.Open2kTarget.Name = "Open2kTarget";
            this.Open2kTarget.Size = new System.Drawing.Size(157, 22);
            this.Open2kTarget.Text = "RPGM 2000/2k3";
            this.Open2kTarget.Click += new System.EventHandler(this.Open2kTarget_Click);
            // 
            // OpenXPTarget
            // 
            this.OpenXPTarget.Image = global::nsTileMaker.Properties.Resources.rpgmXP;
            this.OpenXPTarget.Name = "OpenXPTarget";
            this.OpenXPTarget.Size = new System.Drawing.Size(157, 22);
            this.OpenXPTarget.Text = "RPGM XP";
            this.OpenXPTarget.Click += new System.EventHandler(this.OpenXPTarget_Click);
            // 
            // OpenVXAce
            // 
            this.OpenVXAce.Image = global::nsTileMaker.Properties.Resources.rpgmVXAce;
            this.OpenVXAce.Name = "OpenVXAce";
            this.OpenVXAce.Size = new System.Drawing.Size(157, 22);
            this.OpenVXAce.Text = "RPGM VX (Ace)";
            this.OpenVXAce.Click += new System.EventHandler(this.OpenVXAce_Click);
            // 
            // OpenTile1Blank
            // 
            this.OpenTile1Blank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlankRPGM2000,
            this.BlankRPGMXP,
            this.BlankRPGMVXAce});
            this.OpenTile1Blank.Image = global::nsTileMaker.Properties.Resources.table_icon;
            this.OpenTile1Blank.Name = "OpenTile1Blank";
            this.OpenTile1Blank.Size = new System.Drawing.Size(140, 22);
            this.OpenTile1Blank.Text = "Open blank";
            // 
            // BlankRPGM2000
            // 
            this.BlankRPGM2000.Name = "BlankRPGM2000";
            this.BlankRPGM2000.Size = new System.Drawing.Size(131, 22);
            this.BlankRPGM2000.Text = "RPGM2000";
            this.BlankRPGM2000.Click += new System.EventHandler(this.BlankRPGM2000_Click);
            // 
            // BlankRPGMXP
            // 
            this.BlankRPGMXP.Name = "BlankRPGMXP";
            this.BlankRPGMXP.Size = new System.Drawing.Size(131, 22);
            this.BlankRPGMXP.Text = "RPGM XP";
            this.BlankRPGMXP.Click += new System.EventHandler(this.BlankRPGMXP_Click);
            // 
            // BlankRPGMVXAce
            // 
            this.BlankRPGMVXAce.Name = "BlankRPGMVXAce";
            this.BlankRPGMVXAce.Size = new System.Drawing.Size(131, 22);
            this.BlankRPGMVXAce.Text = "RPGM VX";
            this.BlankRPGMVXAce.Click += new System.EventHandler(this.BlankRPGMVXAce_Click);
            // 
            // SaveTile1
            // 
            this.SaveTile1.Image = global::nsTileMaker.Properties.Resources.save_button;
            this.SaveTile1.Name = "SaveTile1";
            this.SaveTile1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveTile1.Size = new System.Drawing.Size(140, 22);
            this.SaveTile1.Text = "Save";
            this.SaveTile1.Click += new System.EventHandler(this.SaveTile1_Click);
            // 
            // SaveAsTile1
            // 
            this.SaveAsTile1.Name = "SaveAsTile1";
            this.SaveAsTile1.Size = new System.Drawing.Size(140, 22);
            this.SaveAsTile1.Text = "Save as";
            this.SaveAsTile1.Click += new System.EventHandler(this.SaveAsTile1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // ClearTile1
            // 
            this.ClearTile1.Image = global::nsTileMaker.Properties.Resources.clear_icon;
            this.ClearTile1.Name = "ClearTile1";
            this.ClearTile1.Size = new System.Drawing.Size(140, 22);
            this.ClearTile1.Text = "Clear";
            // 
            // MenuItemTile2
            // 
            this.MenuItemTile2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSrcTileSet,
            this.OpenSrcImage,
            this.OpenSrcEmpty,
            this.transportSelectionToolStripMenuItem});
            this.MenuItemTile2.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemTile2.Image")));
            this.MenuItemTile2.Name = "MenuItemTile2";
            this.MenuItemTile2.Size = new System.Drawing.Size(71, 26);
            this.MenuItemTile2.Text = "Source";
            // 
            // OpenSrcTileSet
            // 
            this.OpenSrcTileSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open2kSource,
            this.OpenXPSource,
            this.OpenVXSource});
            this.OpenSrcTileSet.Image = global::nsTileMaker.Properties.Resources.open_button;
            this.OpenSrcTileSet.Name = "OpenSrcTileSet";
            this.OpenSrcTileSet.Size = new System.Drawing.Size(242, 22);
            this.OpenSrcTileSet.Text = "Add TileSet Source";
            // 
            // Open2kSource
            // 
            this.Open2kSource.Image = global::nsTileMaker.Properties.Resources.rpgm2k3;
            this.Open2kSource.Name = "Open2kSource";
            this.Open2kSource.Size = new System.Drawing.Size(157, 22);
            this.Open2kSource.Text = "RPGM 2000/2k3";
            this.Open2kSource.Click += new System.EventHandler(this.Open2kSource_Click);
            // 
            // OpenXPSource
            // 
            this.OpenXPSource.Image = global::nsTileMaker.Properties.Resources.rpgmXP;
            this.OpenXPSource.Name = "OpenXPSource";
            this.OpenXPSource.Size = new System.Drawing.Size(157, 22);
            this.OpenXPSource.Text = "RPGM XP";
            this.OpenXPSource.Click += new System.EventHandler(this.OpenXPSource_Click);
            // 
            // OpenVXSource
            // 
            this.OpenVXSource.Image = global::nsTileMaker.Properties.Resources.rpgmVXAce;
            this.OpenVXSource.Name = "OpenVXSource";
            this.OpenVXSource.Size = new System.Drawing.Size(157, 22);
            this.OpenVXSource.Text = "RPGM VX(Ace)";
            this.OpenVXSource.Click += new System.EventHandler(this.OpenVXSource_Click);
            // 
            // OpenSrcImage
            // 
            this.OpenSrcImage.Name = "OpenSrcImage";
            this.OpenSrcImage.Size = new System.Drawing.Size(242, 22);
            this.OpenSrcImage.Text = "Add Image Source";
            this.OpenSrcImage.Click += new System.EventHandler(this.OpenSrcImage_Click);
            // 
            // OpenSrcEmpty
            // 
            this.OpenSrcEmpty.Enabled = false;
            this.OpenSrcEmpty.Name = "OpenSrcEmpty";
            this.OpenSrcEmpty.Size = new System.Drawing.Size(242, 22);
            this.OpenSrcEmpty.Text = "Add empty Source";
            // 
            // transportSelectionToolStripMenuItem
            // 
            this.transportSelectionToolStripMenuItem.Image = global::nsTileMaker.Properties.Resources.arrow_button;
            this.transportSelectionToolStripMenuItem.Name = "transportSelectionToolStripMenuItem";
            this.transportSelectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.transportSelectionToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.transportSelectionToolStripMenuItem.Text = "Transport selection";
            this.transportSelectionToolStripMenuItem.Click += new System.EventHandler(this.transportSelectionToolStripMenuItem_Click);
            // 
            // FileDia2
            // 
            this.FileDia2.RestoreDirectory = true;
            // 
            // SaveDia1
            // 
            this.SaveDia1.CreatePrompt = true;
            this.SaveDia1.RestoreDirectory = true;
            // 
            // SaveDia2
            // 
            this.SaveDia2.RestoreDirectory = true;
            // 
            // BtnSwitchTile
            // 
            this.BtnSwitchTile.Location = new System.Drawing.Point(596, 348);
            this.BtnSwitchTile.Name = "BtnSwitchTile";
            this.BtnSwitchTile.Size = new System.Drawing.Size(52, 51);
            this.BtnSwitchTile.TabIndex = 11;
            this.BtnSwitchTile.Text = "<<<";
            this.BtnSwitchTile.UseVisualStyleBackColor = true;
            this.BtnSwitchTile.Click += new System.EventHandler(this.BtnSwitchTile_Click);
            // 
            // CenterToolStrip
            // 
            this.CenterToolStrip.AutoSize = false;
            this.CenterToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.CenterToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.CenterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CenterSaveButton,
            this.ToolStripA1,
            this.ToolStripA2,
            this.ToolStripA3,
            this.ToolStripA4,
            this.ToolStripA5,
            this.ToolStripA6});
            this.CenterToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.CenterToolStrip.Location = new System.Drawing.Point(598, 57);
            this.CenterToolStrip.Name = "CenterToolStrip";
            this.CenterToolStrip.Size = new System.Drawing.Size(52, 173);
            this.CenterToolStrip.TabIndex = 10;
            this.CenterToolStrip.Text = "toolStrip1";
            this.CenterToolStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // CenterSaveButton
            // 
            this.CenterSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterSaveButton.Image = global::nsTileMaker.Properties.Resources.save_button;
            this.CenterSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterSaveButton.Name = "CenterSaveButton";
            this.CenterSaveButton.Size = new System.Drawing.Size(50, 20);
            this.CenterSaveButton.Click += new System.EventHandler(this.CenterSaveButton_Click);
            // 
            // ToolStripA1
            // 
            this.ToolStripA1.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStripA1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripA1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ToolStripA1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA1.Image")));
            this.ToolStripA1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripA1.Name = "ToolStripA1";
            this.ToolStripA1.Size = new System.Drawing.Size(50, 19);
            this.ToolStripA1.Text = "A1";
            this.ToolStripA1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ToolStripA2
            // 
            this.ToolStripA2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripA2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA2.Image")));
            this.ToolStripA2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripA2.Name = "ToolStripA2";
            this.ToolStripA2.Size = new System.Drawing.Size(50, 19);
            this.ToolStripA2.Text = "A2";
            this.ToolStripA2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ToolStripA3
            // 
            this.ToolStripA3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripA3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA3.Image")));
            this.ToolStripA3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripA3.Name = "ToolStripA3";
            this.ToolStripA3.Size = new System.Drawing.Size(50, 19);
            this.ToolStripA3.Text = "A3";
            this.ToolStripA3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ToolStripA4
            // 
            this.ToolStripA4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripA4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA4.Image")));
            this.ToolStripA4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripA4.Name = "ToolStripA4";
            this.ToolStripA4.Size = new System.Drawing.Size(50, 19);
            this.ToolStripA4.Text = "A4";
            this.ToolStripA4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ToolStripA5
            // 
            this.ToolStripA5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripA5.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA5.Image")));
            this.ToolStripA5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripA5.Name = "ToolStripA5";
            this.ToolStripA5.Size = new System.Drawing.Size(50, 19);
            this.ToolStripA5.Text = "A5";
            this.ToolStripA5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // ToolStripA6
            // 
            this.ToolStripA6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripA6.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA6.Image")));
            this.ToolStripA6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripA6.Name = "ToolStripA6";
            this.ToolStripA6.Size = new System.Drawing.Size(50, 19);
            this.ToolStripA6.Text = "A6";
            this.ToolStripA6.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // FileDia1
            // 
            this.FileDia1.RestoreDirectory = true;
            // 
            // SourceTileSetTabControl
            // 
            this.SourceTileSetTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceTileSetTabControl.Location = new System.Drawing.Point(654, 57);
            this.SourceTileSetTabControl.Name = "SourceTileSetTabControl";
            this.SourceTileSetTabControl.SelectedIndex = 0;
            this.SourceTileSetTabControl.Size = new System.Drawing.Size(587, 342);
            this.SourceTileSetTabControl.TabIndex = 16;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(3, 505);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(54, 13);
            this.lblLoading.TabIndex = 18;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.Visible = false;
            // 
            // pictureBoxNew
            // 
            this.pictureBoxNew.Location = new System.Drawing.Point(598, 420);
            this.pictureBoxNew.Name = "pictureBoxNew";
            this.pictureBoxNew.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxNew.TabIndex = 13;
            this.pictureBoxNew.TabStop = false;
            // 
            // pictureBoxOld
            // 
            this.pictureBoxOld.Location = new System.Drawing.Point(598, 289);
            this.pictureBoxOld.Name = "pictureBoxOld";
            this.pictureBoxOld.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxOld.TabIndex = 12;
            this.pictureBoxOld.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open2k3,
            this.OpenXP,
            this.OpenVX,
            this.toolStripSeparator2,
            this.OpenSourceVX,
            this.OpenSourceXP,
            this.OpenSource2k3,
            this.OpenSourceImage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1244, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Open2k3
            // 
            this.Open2k3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open2k3.Image = global::nsTileMaker.Properties.Resources.rpgm2k3;
            this.Open2k3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open2k3.Name = "Open2k3";
            this.Open2k3.Size = new System.Drawing.Size(23, 22);
            this.Open2k3.Text = "Open RPG Maker 2000/2k3 Tileset";
            this.Open2k3.Click += new System.EventHandler(this.Open2k3_Click);
            // 
            // OpenXP
            // 
            this.OpenXP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenXP.Image = global::nsTileMaker.Properties.Resources.rpgmXP;
            this.OpenXP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenXP.Name = "OpenXP";
            this.OpenXP.Size = new System.Drawing.Size(23, 22);
            this.OpenXP.Text = "Open RPG Maker XP Tileset";
            this.OpenXP.Click += new System.EventHandler(this.OpenXP_Click);
            // 
            // OpenVX
            // 
            this.OpenVX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenVX.Image = global::nsTileMaker.Properties.Resources.rpgmVXAce;
            this.OpenVX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenVX.Name = "OpenVX";
            this.OpenVX.Size = new System.Drawing.Size(23, 22);
            this.OpenVX.Text = "Open RPG Maker VX(Ace) Tileset";
            this.OpenVX.Click += new System.EventHandler(this.OpenVX_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // OpenSourceVX
            // 
            this.OpenSourceVX.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OpenSourceVX.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenSourceVX.Image = global::nsTileMaker.Properties.Resources.rpgmVXAce;
            this.OpenSourceVX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenSourceVX.Name = "OpenSourceVX";
            this.OpenSourceVX.Size = new System.Drawing.Size(23, 22);
            this.OpenSourceVX.Text = "Open RPG Maker VX Source";
            this.OpenSourceVX.Click += new System.EventHandler(this.OpenSourceVX_Click);
            // 
            // OpenSourceXP
            // 
            this.OpenSourceXP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OpenSourceXP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenSourceXP.Image = global::nsTileMaker.Properties.Resources.rpgmXP;
            this.OpenSourceXP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenSourceXP.Name = "OpenSourceXP";
            this.OpenSourceXP.Size = new System.Drawing.Size(23, 22);
            this.OpenSourceXP.Text = "Open RPG Maker XP Source";
            this.OpenSourceXP.Click += new System.EventHandler(this.OpenSourceXP_Click);
            // 
            // OpenSource2k3
            // 
            this.OpenSource2k3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OpenSource2k3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenSource2k3.Image = global::nsTileMaker.Properties.Resources.rpgm2k3;
            this.OpenSource2k3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenSource2k3.Name = "OpenSource2k3";
            this.OpenSource2k3.Size = new System.Drawing.Size(23, 22);
            this.OpenSource2k3.Text = "Open RPG Maker 2000/2k3 Source";
            this.OpenSource2k3.Click += new System.EventHandler(this.OpenSource2k3_Click);
            // 
            // OpenSourceImage
            // 
            this.OpenSourceImage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OpenSourceImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenSourceImage.Image = ((System.Drawing.Image)(resources.GetObject("OpenSourceImage.Image")));
            this.OpenSourceImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenSourceImage.Name = "OpenSourceImage";
            this.OpenSourceImage.Size = new System.Drawing.Size(23, 22);
            this.OpenSourceImage.Text = "Open source Image";
            this.OpenSourceImage.Click += new System.EventHandler(this.OpenSourceImage_Click);
            // 
            // TabPageContextMenu
            // 
            this.TabPageContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.TabPageContextMenu.Name = "TabPageContextMenu";
            this.TabPageContextMenu.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // BottomStrip
            // 
            this.BottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProgressBar});
            this.BottomStrip.Location = new System.Drawing.Point(0, 521);
            this.BottomStrip.Name = "BottomStrip";
            this.BottomStrip.Size = new System.Drawing.Size(1244, 22);
            this.BottomStrip.TabIndex = 20;
            // 
            // ToolStripProgressBar
            // 
            this.ToolStripProgressBar.Name = "ToolStripProgressBar";
            this.ToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ToolStripProgressBar.Step = 1;
            // 
            // GridView
            // 
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridView.BackgroundColor = System.Drawing.Color.White;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.GridColor = System.Drawing.Color.Black;
            this.GridView.Location = new System.Drawing.Point(3, 59);
            this.GridView.MultiSelect = false;
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView.ShowEditingIcon = false;
            this.GridView.Size = new System.Drawing.Size(591, 432);
            this.GridView.TabIndex = 0;
            // 
            // CtrlTileEditControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.BottomStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.SourceTileSetTabControl);
            this.Controls.Add(this.pictureBoxNew);
            this.Controls.Add(this.lblPictureNew);
            this.Controls.Add(this.lblOldPicture);
            this.Controls.Add(this.pictureBoxOld);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BtnSwitchTile);
            this.Controls.Add(this.CenterToolStrip);
            this.Controls.Add(this.GridView);
            this.Name = "CtrlTileEditControl";
            this.Size = new System.Drawing.Size(1244, 543);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CenterToolStrip.ResumeLayout(false);
            this.CenterToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TabPageContextMenu.ResumeLayout(false);
            this.BottomStrip.ResumeLayout(false);
            this.BottomStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton ToolStripA1;
        private System.Windows.Forms.PictureBox pictureBoxNew;
        private System.Windows.Forms.ToolStripButton ToolStripA3;
        private System.Windows.Forms.Label lblPictureNew;
        private System.Windows.Forms.Label lblOldPicture;
        private System.Windows.Forms.ToolStripButton ToolStripA4;
        private System.Windows.Forms.ToolStripButton ToolStripA5;
        private System.Windows.Forms.ToolStripButton ToolStripA6;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTile1;
        private System.Windows.Forms.ToolStripMenuItem OpenTile1;
        private System.Windows.Forms.ToolStripMenuItem OpenTile1Blank;
        private System.Windows.Forms.ToolStripMenuItem SaveTile1;
        private System.Windows.Forms.ToolStripMenuItem SaveAsTile1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ClearTile1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTile2;
        private System.Windows.Forms.ToolStripMenuItem OpenSrcTileSet;
        private System.Windows.Forms.ToolStripMenuItem OpenSrcImage;
        private System.Windows.Forms.ToolStripMenuItem OpenSrcEmpty;
        private System.Windows.Forms.ToolStripMenuItem transportSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ToolStripA2;
        private System.Windows.Forms.PictureBox pictureBoxOld;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton CenterSaveButton;
        private CtrlTargetGridView GridView;        
        //private System.Windows.Forms.OpenFileDialog FileDia2;
        //private System.Windows.Forms.SaveFileDialog SaveDia1;
        //private System.Windows.Forms.SaveFileDialog SaveDia2;
        //private System.Windows.Forms.OpenFileDialog FileDia1;
        private System.Windows.Forms.Button BtnSwitchTile;
        private System.Windows.Forms.ToolStrip CenterToolStrip;
        private System.Windows.Forms.TabControl SourceTileSetTabControl;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ToolStripMenuItem Open2kTarget;
        private System.Windows.Forms.ToolStripMenuItem OpenXPTarget;
        private System.Windows.Forms.ToolStripMenuItem OpenVXAce;
        private System.Windows.Forms.ToolStripMenuItem Open2kSource;
        private System.Windows.Forms.ToolStripMenuItem OpenXPSource;
        private System.Windows.Forms.ToolStripMenuItem OpenVXSource;
        private System.Windows.Forms.ToolStripMenuItem BlankRPGM2000;
        private System.Windows.Forms.ToolStripMenuItem BlankRPGMXP;
        private System.Windows.Forms.ToolStripMenuItem BlankRPGMVXAce;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Open2k3;
        private System.Windows.Forms.ToolStripButton OpenXP;
        private System.Windows.Forms.ToolStripButton OpenVX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton OpenSourceVX;
        private System.Windows.Forms.ToolStripButton OpenSourceXP;
        private System.Windows.Forms.ToolStripButton OpenSource2k3;
        private System.Windows.Forms.ToolStripButton OpenSourceImage;
        private System.Windows.Forms.ContextMenuStrip TabPageContextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip BottomStrip;
        private System.Windows.Forms.ToolStripProgressBar ToolStripProgressBar;
    }
}
