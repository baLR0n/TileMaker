namespace nsTileMaker
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripNew = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSettings = new System.Windows.Forms.ToolStripButton();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSettings,
            this.MenuInfo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolMenuItemNew,
            this.ToolMenuItemClose});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // ToolMenuItemNew
            // 
            this.ToolMenuItemNew.Image = global::nsTileMaker.Properties.Resources.new_button;
            this.ToolMenuItemNew.Name = "ToolMenuItemNew";
            this.ToolMenuItemNew.Size = new System.Drawing.Size(103, 22);
            this.ToolMenuItemNew.Text = "New";
            this.ToolMenuItemNew.Click += new System.EventHandler(this.ToolMenuItemNew_Click);
            // 
            // ToolMenuItemClose
            // 
            this.ToolMenuItemClose.Image = global::nsTileMaker.Properties.Resources.close_button;
            this.ToolMenuItemClose.Name = "ToolMenuItemClose";
            this.ToolMenuItemClose.Size = new System.Drawing.Size(103, 22);
            this.ToolMenuItemClose.Text = "Close";
            this.ToolMenuItemClose.Click += new System.EventHandler(this.ToolMenuItemClose_Click);
            // 
            // MenuSettings
            // 
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(61, 20);
            this.MenuSettings.Text = "Settings";
            // 
            // MenuInfo
            // 
            this.MenuInfo.Name = "MenuInfo";
            this.MenuInfo.Size = new System.Drawing.Size(40, 20);
            this.MenuInfo.Text = "Info";
            this.MenuInfo.Click += new System.EventHandler(this.MenuInfo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNew,
            this.ToolStripSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1247, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripNew
            // 
            this.ToolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripNew.Image = global::nsTileMaker.Properties.Resources.new_button;
            this.ToolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripNew.Name = "ToolStripNew";
            this.ToolStripNew.Size = new System.Drawing.Size(23, 22);
            this.ToolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // ToolStripSettings
            // 
            this.ToolStripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripSettings.Image = global::nsTileMaker.Properties.Resources.settings_button;
            this.ToolStripSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSettings.Name = "ToolStripSettings";
            this.ToolStripSettings.Size = new System.Drawing.Size(23, 22);
            // 
            // MainTabControl
            // 
            this.MainTabControl.AllowDrop = true;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.HotTrack = true;
            this.MainTabControl.Location = new System.Drawing.Point(0, 49);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1247, 591);
            this.MainTabControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1247, 640);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "TileMaker v0.3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripNew;
        private System.Windows.Forms.ToolStripMenuItem ToolMenuItemNew;
        private System.Windows.Forms.ToolStripButton ToolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolMenuItemClose;
        private System.Windows.Forms.TabControl MainTabControl;
    }
}

