namespace Painter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFG = new System.Windows.Forms.Button();
            this.brushSizeBox = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorBG = new System.Windows.Forms.Button();
            this.brushButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lineButton = new System.Windows.Forms.Button();
            this.layerPanel = new System.Windows.Forms.CheckedListBox();
            this.newLayer = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.opacityBar = new System.Windows.Forms.TrackBar();
            this.eyeDropButton = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel = new Painter.DoubleBufferedPanel();
            this.rectButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.switchButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.deleteLayer = new System.Windows.Forms.Button();
            this.editLayer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.fitToScreenToolStripMenuItem,
            this.actualToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // fitToScreenToolStripMenuItem
            // 
            this.fitToScreenToolStripMenuItem.Name = "fitToScreenToolStripMenuItem";
            this.fitToScreenToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.fitToScreenToolStripMenuItem.Text = "Fit To Screen";
            this.fitToScreenToolStripMenuItem.Click += new System.EventHandler(this.fitToScreenToolStripMenuItem_Click);
            // 
            // actualToolStripMenuItem
            // 
            this.actualToolStripMenuItem.Name = "actualToolStripMenuItem";
            this.actualToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.actualToolStripMenuItem.Text = "Actual Pixels";
            this.actualToolStripMenuItem.Click += new System.EventHandler(this.actualToolStripMenuItem_Click);
            // 
            // colorFG
            // 
            this.colorFG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorFG.BackColor = System.Drawing.Color.Black;
            this.colorFG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorFG.FlatAppearance.BorderSize = 0;
            this.colorFG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorFG.Location = new System.Drawing.Point(1021, 267);
            this.colorFG.Margin = new System.Windows.Forms.Padding(0);
            this.colorFG.Name = "colorFG";
            this.colorFG.Size = new System.Drawing.Size(40, 40);
            this.colorFG.TabIndex = 1;
            this.colorFG.UseVisualStyleBackColor = false;
            this.colorFG.Click += new System.EventHandler(this.colorFG_Click);
            // 
            // brushSizeBox
            // 
            this.brushSizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brushSizeBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brushSizeBox.Location = new System.Drawing.Point(972, 138);
            this.brushSizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brushSizeBox.Name = "brushSizeBox";
            this.brushSizeBox.Size = new System.Drawing.Size(61, 22);
            this.brushSizeBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.brushSizeBox, "Brush Size");
            this.brushSizeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brushSizeBox.ValueChanged += new System.EventHandler(this.brushSizeBox_ValueChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // colorBG
            // 
            this.colorBG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorBG.BackColor = System.Drawing.Color.White;
            this.colorBG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorBG.FlatAppearance.BorderSize = 0;
            this.colorBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBG.Location = new System.Drawing.Point(1035, 282);
            this.colorBG.Margin = new System.Windows.Forms.Padding(0);
            this.colorBG.Name = "colorBG";
            this.colorBG.Size = new System.Drawing.Size(40, 40);
            this.colorBG.TabIndex = 3;
            this.colorBG.UseVisualStyleBackColor = false;
            this.colorBG.Click += new System.EventHandler(this.colorBG_Click);
            // 
            // brushButton
            // 
            this.brushButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brushButton.BackColor = System.Drawing.Color.Transparent;
            this.brushButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brushButton.BackgroundImage")));
            this.brushButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brushButton.Location = new System.Drawing.Point(963, 60);
            this.brushButton.Margin = new System.Windows.Forms.Padding(5);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(50, 50);
            this.brushButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.brushButton, "Brush");
            this.brushButton.UseVisualStyleBackColor = false;
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineButton.BackColor = System.Drawing.Color.Transparent;
            this.lineButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lineButton.BackgroundImage")));
            this.lineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineButton.Location = new System.Drawing.Point(963, 188);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(50, 50);
            this.lineButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.lineButton, "Line Tool");
            this.lineButton.UseVisualStyleBackColor = false;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // layerPanel
            // 
            this.layerPanel.AllowDrop = true;
            this.layerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.layerPanel.FormattingEnabled = true;
            this.layerPanel.Items.AddRange(new object[] {
            "Layer1",
            "Layer0"});
            this.layerPanel.Location = new System.Drawing.Point(951, 355);
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Size = new System.Drawing.Size(190, 395);
            this.layerPanel.TabIndex = 1;
            this.layerPanel.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.layerPanel_ItemCheck);
            this.layerPanel.SelectedIndexChanged += new System.EventHandler(this.layerPanel_SelectedIndexChanged);
            this.layerPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.layerPanel_DragDrop);
            this.layerPanel.DragOver += new System.Windows.Forms.DragEventHandler(this.layerPanel_DragOver);
            this.layerPanel.DoubleClick += new System.EventHandler(this.layerPanel_DoubleClick);
            this.layerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.layerPanel_MouseMove);
            // 
            // newLayer
            // 
            this.newLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newLayer.Location = new System.Drawing.Point(951, 756);
            this.newLayer.Name = "newLayer";
            this.newLayer.Size = new System.Drawing.Size(50, 23);
            this.newLayer.TabIndex = 8;
            this.newLayer.Text = "New";
            this.newLayer.UseVisualStyleBackColor = true;
            this.newLayer.Click += new System.EventHandler(this.newLayer_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eraseButton.BackColor = System.Drawing.Color.Transparent;
            this.eraseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraseButton.BackgroundImage")));
            this.eraseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraseButton.Location = new System.Drawing.Point(1021, 60);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(50, 50);
            this.eraseButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.eraseButton, "Eraser");
            this.eraseButton.UseMnemonic = false;
            this.eraseButton.UseVisualStyleBackColor = false;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // opacityBar
            // 
            this.opacityBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opacityBar.Location = new System.Drawing.Point(1039, 126);
            this.opacityBar.Maximum = 255;
            this.opacityBar.Name = "opacityBar";
            this.opacityBar.Size = new System.Drawing.Size(91, 56);
            this.opacityBar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.opacityBar, "Brush Opacity");
            this.opacityBar.Value = 255;
            // 
            // eyeDropButton
            // 
            this.eyeDropButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eyeDropButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eyeDropButton.BackgroundImage")));
            this.eyeDropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eyeDropButton.Location = new System.Drawing.Point(1077, 60);
            this.eyeDropButton.Name = "eyeDropButton";
            this.eyeDropButton.Size = new System.Drawing.Size(50, 50);
            this.eyeDropButton.TabIndex = 11;
            this.toolTip1.SetToolTip(this.eyeDropButton, "Eyedropper");
            this.eyeDropButton.UseMnemonic = false;
            this.eyeDropButton.UseVisualStyleBackColor = true;
            this.eyeDropButton.Click += new System.EventHandler(this.eyeDropButton_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Controls.Add(this.panel);
            this.panelContainer.Location = new System.Drawing.Point(12, 43);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(920, 736);
            this.panelContainer.TabIndex = 12;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(2000, 2000);
            this.panel.TabIndex = 2;
            this.panel.Visible = false;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // rectButton
            // 
            this.rectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectButton.BackColor = System.Drawing.Color.Transparent;
            this.rectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectButton.BackgroundImage")));
            this.rectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectButton.Location = new System.Drawing.Point(1021, 188);
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(50, 50);
            this.rectButton.TabIndex = 14;
            this.toolTip1.SetToolTip(this.rectButton, "Rectangle Tool");
            this.rectButton.UseVisualStyleBackColor = false;
            this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ellipseButton.BackColor = System.Drawing.Color.Transparent;
            this.ellipseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ellipseButton.BackgroundImage")));
            this.ellipseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipseButton.Location = new System.Drawing.Point(1077, 188);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(50, 50);
            this.ellipseButton.TabIndex = 15;
            this.toolTip1.SetToolTip(this.ellipseButton, "Ellipse Tool");
            this.ellipseButton.UseVisualStyleBackColor = false;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // switchButton
            // 
            this.switchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.switchButton.BackColor = System.Drawing.Color.Transparent;
            this.switchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchButton.BackgroundImage")));
            this.switchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchButton.Location = new System.Drawing.Point(988, 297);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(25, 25);
            this.switchButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.switchButton, "Switch Foreground and Background");
            this.switchButton.UseVisualStyleBackColor = false;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // deleteLayer
            // 
            this.deleteLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteLayer.Location = new System.Drawing.Point(1067, 756);
            this.deleteLayer.Name = "deleteLayer";
            this.deleteLayer.Size = new System.Drawing.Size(70, 23);
            this.deleteLayer.TabIndex = 8;
            this.deleteLayer.Text = "Delete";
            this.deleteLayer.UseVisualStyleBackColor = true;
            this.deleteLayer.Click += new System.EventHandler(this.deleteLayer_Click);
            // 
            // editLayer
            // 
            this.editLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editLayer.Location = new System.Drawing.Point(1011, 756);
            this.editLayer.Name = "editLayer";
            this.editLayer.Size = new System.Drawing.Size(50, 23);
            this.editLayer.TabIndex = 8;
            this.editLayer.Text = "Edit";
            this.editLayer.UseVisualStyleBackColor = true;
            this.editLayer.Click += new System.EventHandler(this.editLayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1156, 799);
            this.Controls.Add(this.opacityBar);
            this.Controls.Add(this.brushSizeBox);
            this.Controls.Add(this.ellipseButton);
            this.Controls.Add(this.rectButton);
            this.Controls.Add(this.eyeDropButton);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.deleteLayer);
            this.Controls.Add(this.editLayer);
            this.Controls.Add(this.newLayer);
            this.Controls.Add(this.layerPanel);
            this.Controls.Add(this.colorFG);
            this.Controls.Add(this.colorBG);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Painter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualToolStripMenuItem;
        private System.Windows.Forms.Button colorBG;
        private System.Windows.Forms.Button brushButton;
        private System.Windows.Forms.NumericUpDown brushSizeBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button lineButton;
        private DoubleBufferedPanel panel;
        private System.Windows.Forms.CheckedListBox layerPanel;
        private System.Windows.Forms.Button newLayer;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.TrackBar opacityBar;
        private System.Windows.Forms.Button eyeDropButton;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button rectButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button colorFG;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button deleteLayer;
        private System.Windows.Forms.Button editLayer;
    }
}

