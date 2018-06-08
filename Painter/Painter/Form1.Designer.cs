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
            this.button1 = new System.Windows.Forms.Button();
            this.brushButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lineButton = new System.Windows.Forms.Button();
            this.layerPanel = new System.Windows.Forms.CheckedListBox();
            this.newLayer = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.opacityBar = new System.Windows.Forms.TrackBar();
            this.eyeDropButton = new System.Windows.Forms.Button();
            this.panel = new Painter.DoubleBufferedPanel();
            this.debug = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.colorFG.Location = new System.Drawing.Point(1065, 362);
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
            this.brushSizeBox.Location = new System.Drawing.Point(1065, 72);
            this.brushSizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brushSizeBox.Name = "brushSizeBox";
            this.brushSizeBox.Size = new System.Drawing.Size(75, 22);
            this.brushSizeBox.TabIndex = 6;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1079, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // brushButton
            // 
            this.brushButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brushButton.Location = new System.Drawing.Point(1065, 43);
            this.brushButton.Name = "brushButton";
            this.brushButton.Size = new System.Drawing.Size(75, 23);
            this.brushButton.TabIndex = 4;
            this.brushButton.Text = "Brush";
            this.brushButton.UseVisualStyleBackColor = true;
            this.brushButton.Click += new System.EventHandler(this.brushButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineButton.Location = new System.Drawing.Point(1065, 100);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(75, 23);
            this.lineButton.TabIndex = 7;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // layerPanel
            // 
            this.layerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.layerPanel.FormattingEnabled = true;
            this.layerPanel.Items.AddRange(new object[] {
            "Layer1",
            "Layer0"});
            this.layerPanel.Location = new System.Drawing.Point(951, 627);
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Size = new System.Drawing.Size(190, 123);
            this.layerPanel.TabIndex = 1;
            this.layerPanel.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.layerPanel_ItemCheck);
            this.layerPanel.SelectedIndexChanged += new System.EventHandler(this.layerPanel_SelectedIndexChanged);
            // 
            // newLayer
            // 
            this.newLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newLayer.Location = new System.Drawing.Point(951, 756);
            this.newLayer.Name = "newLayer";
            this.newLayer.Size = new System.Drawing.Size(75, 23);
            this.newLayer.TabIndex = 8;
            this.newLayer.Text = "New";
            this.newLayer.UseVisualStyleBackColor = true;
            this.newLayer.Click += new System.EventHandler(this.newLayer_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eraseButton.Location = new System.Drawing.Point(1065, 129);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(75, 23);
            this.eraseButton.TabIndex = 9;
            this.eraseButton.Text = "Eraser";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // opacityBar
            // 
            this.opacityBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opacityBar.Location = new System.Drawing.Point(1052, 158);
            this.opacityBar.Maximum = 255;
            this.opacityBar.Name = "opacityBar";
            this.opacityBar.Size = new System.Drawing.Size(104, 56);
            this.opacityBar.TabIndex = 10;
            this.opacityBar.Value = 255;
            // 
            // eyeDropButton
            // 
            this.eyeDropButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.eyeDropButton.Location = new System.Drawing.Point(1065, 202);
            this.eyeDropButton.Name = "eyeDropButton";
            this.eyeDropButton.Size = new System.Drawing.Size(75, 23);
            this.eyeDropButton.TabIndex = 11;
            this.eyeDropButton.Text = "Eyedropper";
            this.eyeDropButton.UseVisualStyleBackColor = true;
            this.eyeDropButton.Click += new System.EventHandler(this.eyeDropButton_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.debug);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(12, 43);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(913, 736);
            this.panel.TabIndex = 2;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.ForeColor = System.Drawing.Color.White;
            this.debug.Location = new System.Drawing.Point(3, 713);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(48, 17);
            this.debug.TabIndex = 1;
            this.debug.Text = "debug";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox.Enabled = false;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1156, 799);
            this.Controls.Add(this.eyeDropButton);
            this.Controls.Add(this.opacityBar);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.newLayer);
            this.Controls.Add(this.layerPanel);
            this.Controls.Add(this.colorFG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.brushSizeBox);
            this.Controls.Add(this.brushButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityBar)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
        private System.Windows.Forms.Button colorFG;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button brushButton;
        private System.Windows.Forms.NumericUpDown brushSizeBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button lineButton;
        private DoubleBufferedPanel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckedListBox layerPanel;
        private System.Windows.Forms.Button newLayer;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.TrackBar opacityBar;
        private System.Windows.Forms.Button eyeDropButton;
        private System.Windows.Forms.Label debug;
    }
}

