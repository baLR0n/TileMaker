//using nsTileMaker.lib;

//namespace nsTileMaker
//{
//    partial class TileGridForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileGridForm));
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
//            this.MenuItemTile1 = new System.Windows.Forms.ToolStripMenuItem();
//            this.OpenTile1 = new System.Windows.Forms.ToolStripMenuItem();
//            this.OpenTile1Blank = new System.Windows.Forms.ToolStripMenuItem();
//            this.SaveTile1 = new System.Windows.Forms.ToolStripMenuItem();
//            this.SaveAsTile1 = new System.Windows.Forms.ToolStripMenuItem();
//            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
//            this.ClearTile1 = new System.Windows.Forms.ToolStripMenuItem();
//            this.MenuItemTile2 = new System.Windows.Forms.ToolStripMenuItem();
//            this.OpenTile2 = new System.Windows.Forms.ToolStripMenuItem();
//            this.SaveTile2 = new System.Windows.Forms.ToolStripMenuItem();
//            this.SaveAsTile2 = new System.Windows.Forms.ToolStripMenuItem();
//            this.transportSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.FileDia1 = new System.Windows.Forms.OpenFileDialog();
//            this.FileDia2 = new System.Windows.Forms.OpenFileDialog();
//            this.SaveDia1 = new System.Windows.Forms.SaveFileDialog();
//            this.SaveDia2 = new System.Windows.Forms.SaveFileDialog();
//            this.CenterToolStrip = new System.Windows.Forms.ToolStrip();
//            this.CenterSaveButton = new System.Windows.Forms.ToolStripButton();
//            this.ToolStripA1 = new System.Windows.Forms.ToolStripButton();
//            this.ToolStripA2 = new System.Windows.Forms.ToolStripButton();
//            this.ToolStripA3 = new System.Windows.Forms.ToolStripButton();
//            this.ToolStripA4 = new System.Windows.Forms.ToolStripButton();
//            this.ToolStripA5 = new System.Windows.Forms.ToolStripButton();
//            this.ToolStripA6 = new System.Windows.Forms.ToolStripButton();
//            this.BtnSwitchTile = new System.Windows.Forms.Button();
//            this.lblOldPicture = new System.Windows.Forms.Label();
//            this.lblPictureNew = new System.Windows.Forms.Label();
//            this.pictureBoxNew = new System.Windows.Forms.PictureBox();
//            this.pictureBoxOld = new System.Windows.Forms.PictureBox();
//            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
//            this.MenuItem2000 = new System.Windows.Forms.ToolStripMenuItem();
//            this.MenuItem2k3 = new System.Windows.Forms.ToolStripMenuItem();
//            this.MenuItemXP = new System.Windows.Forms.ToolStripMenuItem();
//            this.MenuItemVX = new System.Windows.Forms.ToolStripMenuItem();
//            this.MenuItemVXAce = new System.Windows.Forms.ToolStripMenuItem();
//            this.TileGrid1 = new TargetGridView();            
//            this.menuStrip1.SuspendLayout();
//            this.CenterToolStrip.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.TileGrid1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.TileGrid2)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // menuStrip1
//            // 
//            this.menuStrip1.AutoSize = false;
//            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.MenuItemTile1,
//            this.MenuItemTile2,
//            this.versionToolStripMenuItem});
//            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
//            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
//            this.menuStrip1.Name = "menuStrip1";
//            this.menuStrip1.Size = new System.Drawing.Size(1225, 30);
//            this.menuStrip1.Stretch = false;
//            this.menuStrip1.TabIndex = 2;
//            this.menuStrip1.Text = "menuStrip1";
//            // 
//            // MenuItemTile1
//            // 
//            this.MenuItemTile1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.OpenTile1,
//            this.OpenTile1Blank,
//            this.SaveTile1,
//            this.SaveAsTile1,
//            this.toolStripSeparator1,
//            this.ClearTile1});
//            this.MenuItemTile1.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemTile1.Image")));
//            this.MenuItemTile1.Name = "MenuItemTile1";
//            this.MenuItemTile1.Size = new System.Drawing.Size(63, 26);
//            this.MenuItemTile1.Text = "Tile 1";
//            // 
//            // OpenTile1
//            // 
//            this.OpenTile1.Image = global::nsTileMaker.Properties.Resources.open_button;
//            this.OpenTile1.Name = "OpenTile1";
//            this.OpenTile1.Size = new System.Drawing.Size(152, 22);
//            this.OpenTile1.Text = "Open";
//            this.OpenTile1.Click += new System.EventHandler(this.OpenTile1_Click);
//            // 
//            // OpenTile1Blank
//            // 
//            this.OpenTile1Blank.Image = global::nsTileMaker.Properties.Resources.table_icon;
//            this.OpenTile1Blank.Name = "OpenTile1Blank";
//            this.OpenTile1Blank.Size = new System.Drawing.Size(152, 22);
//            this.OpenTile1Blank.Text = "Open blank";
//            this.OpenTile1Blank.Click += new System.EventHandler(this.OpenTile1Blank_Click);
//            // 
//            // SaveTile1
//            // 
//            this.SaveTile1.Image = global::nsTileMaker.Properties.Resources.save_button;
//            this.SaveTile1.Name = "SaveTile1";
//            this.SaveTile1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
//            this.SaveTile1.Size = new System.Drawing.Size(152, 22);
//            this.SaveTile1.Text = "Save";
//            this.SaveTile1.Click += new System.EventHandler(this.SaveTile1_Click);
//            // 
//            // SaveAsTile1
//            // 
//            this.SaveAsTile1.Name = "SaveAsTile1";
//            this.SaveAsTile1.Size = new System.Drawing.Size(152, 22);
//            this.SaveAsTile1.Text = "Save as";
//            this.SaveAsTile1.Click += new System.EventHandler(this.SaveAsTile1_Click);
//            // 
//            // toolStripSeparator1
//            // 
//            this.toolStripSeparator1.Name = "toolStripSeparator1";
//            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
//            // 
//            // ClearTile1
//            // 
//            this.ClearTile1.Image = global::nsTileMaker.Properties.Resources.clear_icon;
//            this.ClearTile1.Name = "ClearTile1";
//            this.ClearTile1.Size = new System.Drawing.Size(152, 22);
//            this.ClearTile1.Text = "Clear";
//            // 
//            // MenuItemTile2
//            // 
//            this.MenuItemTile2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.OpenTile2,
//            this.SaveTile2,
//            this.SaveAsTile2,
//            this.transportSelectionToolStripMenuItem});
//            this.MenuItemTile2.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemTile2.Image")));
//            this.MenuItemTile2.Name = "MenuItemTile2";
//            this.MenuItemTile2.Size = new System.Drawing.Size(63, 26);
//            this.MenuItemTile2.Text = "Tile 2";
//            // 
//            // OpenTile2
//            // 
//            this.OpenTile2.Image = global::nsTileMaker.Properties.Resources.open_button;
//            this.OpenTile2.Name = "OpenTile2";
//            this.OpenTile2.Size = new System.Drawing.Size(242, 22);
//            this.OpenTile2.Text = "Open";
//            this.OpenTile2.Click += new System.EventHandler(this.OpenTile2_Click);
//            // 
//            // SaveTile2
//            // 
//            this.SaveTile2.Enabled = false;
//            this.SaveTile2.Name = "SaveTile2";
//            this.SaveTile2.Size = new System.Drawing.Size(242, 22);
//            this.SaveTile2.Text = "Save";
//            // 
//            // SaveAsTile2
//            // 
//            this.SaveAsTile2.Enabled = false;
//            this.SaveAsTile2.Name = "SaveAsTile2";
//            this.SaveAsTile2.Size = new System.Drawing.Size(242, 22);
//            this.SaveAsTile2.Text = "Save as";
//            // 
//            // transportSelectionToolStripMenuItem
//            // 
//            this.transportSelectionToolStripMenuItem.Image = global::nsTileMaker.Properties.Resources.arrow_button;
//            this.transportSelectionToolStripMenuItem.Name = "transportSelectionToolStripMenuItem";
//            this.transportSelectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
//            this.transportSelectionToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
//            this.transportSelectionToolStripMenuItem.Text = "Transport selection";
//            this.transportSelectionToolStripMenuItem.Click += new System.EventHandler(this.transportSelectionToolStripMenuItem_Click);
//            // 
//            // FileDia1
//            // 
//            this.FileDia1.RestoreDirectory = true;
//            // 
//            // FileDia2
//            // 
//            this.FileDia2.RestoreDirectory = true;
//            // 
//            // SaveDia1
//            // 
//            this.SaveDia1.CreatePrompt = true;
//            this.SaveDia1.RestoreDirectory = true;
//            // 
//            // SaveDia2
//            // 
//            this.SaveDia2.RestoreDirectory = true;
//            // 
//            // CenterToolStrip
//            // 
//            this.CenterToolStrip.AutoSize = false;
//            this.CenterToolStrip.Dock = System.Windows.Forms.DockStyle.None;
//            this.CenterToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
//            this.CenterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.CenterSaveButton,
//            this.ToolStripA1,
//            this.ToolStripA2,
//            this.ToolStripA3,
//            this.ToolStripA4,
//            this.ToolStripA5,
//            this.ToolStripA6});
//            this.CenterToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
//            this.CenterToolStrip.Location = new System.Drawing.Point(589, 30);
//            this.CenterToolStrip.Name = "CenterToolStrip";
//            this.CenterToolStrip.Size = new System.Drawing.Size(52, 173);
//            this.CenterToolStrip.TabIndex = 3;
//            this.CenterToolStrip.Text = "toolStrip1";
//            this.CenterToolStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
//            // 
//            // CenterSaveButton
//            // 
//            this.CenterSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
//            this.CenterSaveButton.Image = global::nsTileMaker.Properties.Resources.save_button;
//            this.CenterSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.CenterSaveButton.Name = "CenterSaveButton";
//            this.CenterSaveButton.Size = new System.Drawing.Size(50, 20);
//            this.CenterSaveButton.Click += new System.EventHandler(this.CenterSaveButton_Click);
//            // 
//            // ToolStripA1
//            // 
//            this.ToolStripA1.BackColor = System.Drawing.SystemColors.Control;
//            this.ToolStripA1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
//            this.ToolStripA1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
//            this.ToolStripA1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA1.Image")));
//            this.ToolStripA1.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.ToolStripA1.Name = "ToolStripA1";
//            this.ToolStripA1.Size = new System.Drawing.Size(50, 19);
//            this.ToolStripA1.Text = "A1";
//            this.ToolStripA1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
//            // 
//            // ToolStripA2
//            // 
//            this.ToolStripA2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
//            this.ToolStripA2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA2.Image")));
//            this.ToolStripA2.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.ToolStripA2.Name = "ToolStripA2";
//            this.ToolStripA2.Size = new System.Drawing.Size(50, 19);
//            this.ToolStripA2.Text = "A2";
//            this.ToolStripA2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
//            // 
//            // ToolStripA3
//            // 
//            this.ToolStripA3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
//            this.ToolStripA3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA3.Image")));
//            this.ToolStripA3.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.ToolStripA3.Name = "ToolStripA3";
//            this.ToolStripA3.Size = new System.Drawing.Size(50, 19);
//            this.ToolStripA3.Text = "A3";
//            this.ToolStripA3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
//            // 
//            // ToolStripA4
//            // 
//            this.ToolStripA4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
//            this.ToolStripA4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA4.Image")));
//            this.ToolStripA4.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.ToolStripA4.Name = "ToolStripA4";
//            this.ToolStripA4.Size = new System.Drawing.Size(50, 19);
//            this.ToolStripA4.Text = "A4";
//            this.ToolStripA4.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
//            // 
//            // ToolStripA5
//            // 
//            this.ToolStripA5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
//            this.ToolStripA5.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA5.Image")));
//            this.ToolStripA5.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.ToolStripA5.Name = "ToolStripA5";
//            this.ToolStripA5.Size = new System.Drawing.Size(50, 19);
//            this.ToolStripA5.Text = "A5";
//            this.ToolStripA5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
//            // 
//            // ToolStripA6
//            // 
//            this.ToolStripA6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
//            this.ToolStripA6.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripA6.Image")));
//            this.ToolStripA6.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.ToolStripA6.Name = "ToolStripA6";
//            this.ToolStripA6.Size = new System.Drawing.Size(50, 19);
//            this.ToolStripA6.Text = "A6";
//            this.ToolStripA6.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
//            // 
//            // BtnSwitchTile
//            // 
//            this.BtnSwitchTile.Location = new System.Drawing.Point(589, 286);
//            this.BtnSwitchTile.Name = "BtnSwitchTile";
//            this.BtnSwitchTile.Size = new System.Drawing.Size(52, 51);
//            this.BtnSwitchTile.TabIndex = 4;
//            this.BtnSwitchTile.Text = "<<<";
//            this.BtnSwitchTile.UseVisualStyleBackColor = true;
//            this.BtnSwitchTile.Click += new System.EventHandler(this.BtnSwitchTile_Click);
//            // 
//            // lblOldPicture
//            // 
//            this.lblOldPicture.AutoSize = true;
//            this.lblOldPicture.Location = new System.Drawing.Point(588, 211);
//            this.lblOldPicture.Name = "lblOldPicture";
//            this.lblOldPicture.Size = new System.Drawing.Size(23, 13);
//            this.lblOldPicture.TabIndex = 7;
//            this.lblOldPicture.Text = "Old";
//            // 
//            // lblPictureNew
//            // 
//            this.lblPictureNew.AutoSize = true;
//            this.lblPictureNew.Location = new System.Drawing.Point(588, 342);
//            this.lblPictureNew.Name = "lblPictureNew";
//            this.lblPictureNew.Size = new System.Drawing.Size(29, 13);
//            this.lblPictureNew.TabIndex = 8;
//            this.lblPictureNew.Text = "New";
//            // 
//            // pictureBoxNew
//            // 
//            this.pictureBoxNew.Location = new System.Drawing.Point(591, 358);
//            this.pictureBoxNew.Name = "pictureBoxNew";
//            this.pictureBoxNew.Size = new System.Drawing.Size(48, 48);
//            this.pictureBoxNew.TabIndex = 6;
//            this.pictureBoxNew.TabStop = false;
//            // 
//            // pictureBoxOld
//            // 
//            this.pictureBoxOld.Location = new System.Drawing.Point(591, 227);
//            this.pictureBoxOld.Name = "pictureBoxOld";
//            this.pictureBoxOld.Size = new System.Drawing.Size(48, 48);
//            this.pictureBoxOld.TabIndex = 5;
//            this.pictureBoxOld.TabStop = false;
//            // 
//            // TileGrid1
//            // 
//            this.TileGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left)));
//            this.TileGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
//            this.TileGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
//            this.TileGrid1.BackgroundColor = System.Drawing.Color.White;
//            this.TileGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
//            this.TileGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
//            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
//            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
//            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.TileGrid1.DefaultCellStyle = dataGridViewCellStyle1;
//            this.TileGrid1.GridColor = System.Drawing.Color.Black;
//            this.TileGrid1.Location = new System.Drawing.Point(1, 30);
//            this.TileGrid1.MultiSelect = false;
//            this.TileGrid1.Name = "TileGrid1";
//            this.TileGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
//            this.TileGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
//            this.TileGrid1.ShowEditingIcon = false;
//            this.TileGrid1.Size = new System.Drawing.Size(585, 391);
//            this.TileGrid1.TabIndex = 0;
//            // 
//            // TileGrid2
//            // 
//            this.TileGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.TileGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
//            this.TileGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
//            this.TileGrid2.BackgroundColor = System.Drawing.Color.White;
//            this.TileGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
//            this.TileGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
//            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
//            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
//            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
//            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.TileGrid2.DefaultCellStyle = dataGridViewCellStyle2;
//            this.TileGrid2.Location = new System.Drawing.Point(642, 30);
//            this.TileGrid2.MultiSelect = false;
//            this.TileGrid2.Name = "TileGrid2";
//            this.TileGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
//            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
//            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
//            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
//            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.TileGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
//            this.TileGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
//            this.TileGrid2.RowTemplate.Height = 64;
//            this.TileGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
//            this.TileGrid2.ShowEditingIcon = false;
//            this.TileGrid2.Size = new System.Drawing.Size(581, 391);
//            this.TileGrid2.TabIndex = 1;
//            // 
//            // versionToolStripMenuItem
//            // 
//            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.MenuItem2000,
//            this.MenuItem2k3,
//            this.MenuItemXP,
//            this.MenuItemVX,
//            this.MenuItemVXAce});
//            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
//            this.versionToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
//            this.versionToolStripMenuItem.Text = "Version";
//            // 
//            // MenuItem2000
//            // 
//            this.MenuItem2000.Enabled = false;
//            this.MenuItem2000.Name = "MenuItem2000";
//            this.MenuItem2000.Size = new System.Drawing.Size(152, 22);
//            this.MenuItem2000.Text = "RPGM 2000";
//            // 
//            // MenuItem2k3
//            // 
//            this.MenuItem2k3.Enabled = false;
//            this.MenuItem2k3.Name = "MenuItem2k3";
//            this.MenuItem2k3.Size = new System.Drawing.Size(152, 22);
//            this.MenuItem2k3.Text = "RPGM 2k3";
//            // 
//            // MenuItemXP
//            // 
//            this.MenuItemXP.Enabled = false;
//            this.MenuItemXP.Name = "MenuItemXP";
//            this.MenuItemXP.Size = new System.Drawing.Size(152, 22);
//            this.MenuItemXP.Text = "RPGM XP";
//            // 
//            // MenuItemVX
//            // 
//            this.MenuItemVX.Enabled = false;
//            this.MenuItemVX.Name = "MenuItemVX";
//            this.MenuItemVX.Size = new System.Drawing.Size(152, 22);
//            this.MenuItemVX.Text = "RPGM VX";
//            // 
//            // MenuItemVXAce
//            // 
//            this.MenuItemVXAce.Checked = true;
//            this.MenuItemVXAce.CheckState = System.Windows.Forms.CheckState.Checked;
//            this.MenuItemVXAce.Name = "MenuItemVXAce";
//            this.MenuItemVXAce.Size = new System.Drawing.Size(152, 22);
//            this.MenuItemVXAce.Text = "RPGM VX Ace";
//            // 
//            // TileGridForm
//            // 
//            this.ClientSize = new System.Drawing.Size(1225, 421);
//            this.Controls.Add(this.lblPictureNew);
//            this.Controls.Add(this.lblOldPicture);
//            this.Controls.Add(this.pictureBoxNew);
//            this.Controls.Add(this.pictureBoxOld);
//            this.Controls.Add(this.BtnSwitchTile);
//            this.Controls.Add(this.CenterToolStrip);
//            this.Controls.Add(this.TileGrid1);
//            this.Controls.Add(this.TileGrid2);
//            this.Controls.Add(this.menuStrip1);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
//            this.MainMenuStrip = this.menuStrip1;
//            this.MaximizeBox = false;
//            this.Name = "TileGridForm";
//            this.menuStrip1.ResumeLayout(false);
//            this.menuStrip1.PerformLayout();
//            this.CenterToolStrip.ResumeLayout(false);
//            this.CenterToolStrip.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNew)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOld)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.TileGrid1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.TileGrid2)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }        



//        #endregion

//        private System.Windows.Forms.MenuStrip menuStrip1;
//        private System.Windows.Forms.ToolStripMenuItem MenuItemTile1;
//        private System.Windows.Forms.ToolStripMenuItem MenuItemTile2;
//        private System.Windows.Forms.ToolStripMenuItem OpenTile1;
//        private System.Windows.Forms.ToolStripMenuItem SaveTile1;
//        private System.Windows.Forms.ToolStripMenuItem SaveAsTile1;
//        private System.Windows.Forms.ToolStripMenuItem OpenTile2;
//        private System.Windows.Forms.ToolStripMenuItem SaveTile2;
//        private System.Windows.Forms.ToolStripMenuItem SaveAsTile2;
//        private System.Windows.Forms.ToolStrip CenterToolStrip;
//        private System.Windows.Forms.ToolStripButton CenterSaveButton;
//        private System.Windows.Forms.ToolStripButton ToolStripA1;
//        private System.Windows.Forms.ToolStripButton ToolStripA2;
//        private System.Windows.Forms.ToolStripButton ToolStripA3;
//        private System.Windows.Forms.ToolStripButton ToolStripA4;
//        private System.Windows.Forms.ToolStripButton ToolStripA5;
//        private System.Windows.Forms.ToolStripButton ToolStripA6;
//        private System.Windows.Forms.Button BtnSwitchTile;
//        private System.Windows.Forms.ToolStripMenuItem transportSelectionToolStripMenuItem;
//        private TargetGridView TileGrid1;        
//        private System.Windows.Forms.PictureBox pictureBoxOld;
//        private System.Windows.Forms.PictureBox pictureBoxNew;
//        private System.Windows.Forms.Label lblOldPicture;
//        private System.Windows.Forms.Label lblPictureNew;
//        private System.Windows.Forms.ToolStripMenuItem OpenTile1Blank;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
//        private System.Windows.Forms.ToolStripMenuItem ClearTile1;
//        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem MenuItem2000;
//        private System.Windows.Forms.ToolStripMenuItem MenuItem2k3;
//        private System.Windows.Forms.ToolStripMenuItem MenuItemXP;
//        private System.Windows.Forms.ToolStripMenuItem MenuItemVX;
//        private System.Windows.Forms.ToolStripMenuItem MenuItemVXAce;
//    }
//}