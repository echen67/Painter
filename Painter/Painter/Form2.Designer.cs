namespace Painter
{
    partial class Form2
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
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._cancelButton = new System.Windows.Forms.Button();
            this._sizeLabel = new System.Windows.Forms.Label();
            this._widthChoose = new System.Windows.Forms.NumericUpDown();
            this._heightChoose = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._widthChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._heightChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(42, 115);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(56, 19);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "pixels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "pixels";
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._cancelButton.Location = new System.Drawing.Point(144, 115);
            this._cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(56, 19);
            this._cancelButton.TabIndex = 4;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _sizeLabel
            // 
            this._sizeLabel.AutoSize = true;
            this._sizeLabel.Location = new System.Drawing.Point(37, 10);
            this._sizeLabel.Name = "_sizeLabel";
            this._sizeLabel.Size = new System.Drawing.Size(85, 13);
            this._sizeLabel.TabIndex = 5;
            this._sizeLabel.Text = "Set canvas size:";
            // 
            // _widthChoose
            // 
            this._widthChoose.Location = new System.Drawing.Point(81, 43);
            this._widthChoose.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this._widthChoose.Name = "_widthChoose";
            this._widthChoose.Size = new System.Drawing.Size(89, 20);
            this._widthChoose.TabIndex = 6;
            this._widthChoose.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // _heightChoose
            // 
            this._heightChoose.Location = new System.Drawing.Point(81, 75);
            this._heightChoose.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._heightChoose.Name = "_heightChoose";
            this._heightChoose.Size = new System.Drawing.Size(89, 20);
            this._heightChoose.TabIndex = 7;
            this._heightChoose.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 140);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._heightChoose);
            this.Controls.Add(this._widthChoose);
            this.Controls.Add(this._sizeLabel);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Canvas Size";
            ((System.ComponentModel.ISupportInitialize)(this._widthChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._heightChoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _sizeLabel;
        private System.Windows.Forms.NumericUpDown _widthChoose;
        private System.Windows.Forms.NumericUpDown _heightChoose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}