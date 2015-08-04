namespace nsTileMaker.Controls
{
    partial class SourceImage
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
            this.ImageToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripSaveChanges = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trcBlue = new System.Windows.Forms.TrackBar();
            this.trcRed = new System.Windows.Forms.TrackBar();
            this.trcGreen = new System.Windows.Forms.TrackBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxPanel = new System.Windows.Forms.Panel();
            this.ImageToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).BeginInit();
            this.panel1.SuspendLayout();
            this.PictureBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageToolStrip
            // 
            this.ImageToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSaveChanges});
            this.ImageToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ImageToolStrip.Name = "ImageToolStrip";
            this.ImageToolStrip.Size = new System.Drawing.Size(607, 25);
            this.ImageToolStrip.TabIndex = 1;
            // 
            // ToolStripSaveChanges
            // 
            this.ToolStripSaveChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripSaveChanges.Image = global::nsTileMaker.Properties.Resources.save_button;
            this.ToolStripSaveChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSaveChanges.Name = "ToolStripSaveChanges";
            this.ToolStripSaveChanges.Size = new System.Drawing.Size(23, 22);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 391);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += pictureBox_MouseDown;
            this.pictureBox.Paint += pictureBox_Paint;
            this.pictureBox.MouseUp += pictureBox_MouseUp;
            this.pictureBox.MouseMove += pictureBox_MouseMove;
            this.pictureBox.MouseLeave += pictureBox_MouseLeave;
            // 
            // trcBlue
            // 
            this.trcBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trcBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trcBlue.Location = new System.Drawing.Point(29, 30);
            this.trcBlue.Maximum = 255;
            this.trcBlue.Name = "trcBlue";
            this.trcBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcBlue.Size = new System.Drawing.Size(45, 285);
            this.trcBlue.TabIndex = 2;
            this.trcBlue.Value = 255;
            this.trcBlue.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // trcRed
            // 
            this.trcRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trcRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trcRed.Location = new System.Drawing.Point(135, 30);
            this.trcRed.Maximum = 255;
            this.trcRed.Name = "trcRed";
            this.trcRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcRed.Size = new System.Drawing.Size(45, 285);
            this.trcRed.TabIndex = 3;
            this.trcRed.Value = 255;
            this.trcRed.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // trcGreen
            // 
            this.trcGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trcGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trcGreen.Location = new System.Drawing.Point(80, 30);
            this.trcGreen.Maximum = 255;
            this.trcGreen.Name = "trcGreen";
            this.trcGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcGreen.Size = new System.Drawing.Size(45, 285);
            this.trcGreen.TabIndex = 4;
            this.trcGreen.Value = 255;
            this.trcGreen.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // lblBlue
            // 
            this.lblBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(29, 318);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 5;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(77, 318);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 6;
            this.lblGreen.Text = "Green";
            // 
            // lblRed
            // 
            this.lblRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(132, 318);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 7;
            this.lblRed.Text = "Red";
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.Location = new System.Drawing.Point(29, 14);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(25, 13);
            this.lblBlueValue.TabIndex = 8;
            this.lblBlueValue.Text = "255";
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.Location = new System.Drawing.Point(77, 14);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(25, 13);
            this.lblGreenValue.TabIndex = 9;
            this.lblGreenValue.Text = "255";
            // 
            // lblRedValue
            // 
            this.lblRedValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.Location = new System.Drawing.Point(132, 14);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(25, 13);
            this.lblRedValue.TabIndex = 10;
            this.lblRedValue.Text = "255";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trcBlue);
            this.panel1.Controls.Add(this.lblRedValue);
            this.panel1.Controls.Add(this.lblBlue);
            this.panel1.Controls.Add(this.lblRed);
            this.panel1.Controls.Add(this.trcRed);
            this.panel1.Controls.Add(this.lblBlueValue);
            this.panel1.Controls.Add(this.lblGreen);
            this.panel1.Controls.Add(this.lblGreenValue);
            this.panel1.Controls.Add(this.trcGreen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(403, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 420);
            this.panel1.TabIndex = 11;
            // 
            // PictureBoxPanel
            // 
            this.PictureBoxPanel.AutoScroll = true;
            this.PictureBoxPanel.AutoSize = true;
            this.PictureBoxPanel.Controls.Add(this.pictureBox);
            this.PictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBoxPanel.Location = new System.Drawing.Point(0, 25);
            this.PictureBoxPanel.Name = "PictureBoxPanel";
            this.PictureBoxPanel.Size = new System.Drawing.Size(403, 420);
            this.PictureBoxPanel.TabIndex = 12;
            // 
            // SourceImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.PictureBoxPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ImageToolStrip);
            this.Name = "SourceImage";
            this.Size = new System.Drawing.Size(607, 445);
            this.ImageToolStrip.ResumeLayout(false);
            this.ImageToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PictureBoxPanel.ResumeLayout(false);
            this.PictureBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip ImageToolStrip;
        private System.Windows.Forms.TrackBar trcBlue;
        private System.Windows.Forms.TrackBar trcRed;
        private System.Windows.Forms.TrackBar trcGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblRedValue;        
        private System.Windows.Forms.ToolStripButton ToolStripSaveChanges;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PictureBoxPanel;
    }
}
