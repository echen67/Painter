using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Painter
{
    public partial class Form1 : Form
    {
        bool drawFlag = false;
        int[] xPos = new int[2];
        int[] yPos = new int[2];
        Graphics G;
        Color fgColor = Color.Black;
        int brushSize = 1;
        int toolSelected = 0;
        Pen pen;

        Bitmap myBitmap;
        Bitmap layer2;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            pen = new Pen(fgColor, brushSize);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics graphicsObj;
            myBitmap = new Bitmap(panel.Width, panel.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            myBitmap.MakeTransparent();
            graphicsObj = Graphics.FromImage(myBitmap);
            graphicsObj.Clear(Color.Transparent);
            Pen myPen = new Pen(Color.Plum, 3);
            Rectangle rectangleObj = new Rectangle(10, 10, 200, 200);
            graphicsObj.DrawEllipse(myPen, rectangleObj);
            graphicsObj.Dispose();

            Graphics g2;
            layer2 = new Bitmap(panel.Width, panel.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            layer2.MakeTransparent();
            g2 = Graphics.FromImage(layer2);
            g2.Clear(Color.Transparent);
            myPen = new Pen(Color.Tomato, 5);
            Rectangle r2 = new Rectangle(15, 15, 200, 200);
            g2.DrawEllipse(myPen, r2);
            g2.Dispose();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;
            Graphics g2 = e.Graphics;

            //graphicsObj.DrawImage(myBitmap, 50, 50, myBitmap.Width, myBitmap.Height);
            g2.DrawImage(layer2, 0, 0, layer2.Width, layer2.Height);
            graphicsObj.DrawImage(myBitmap, 50, 50, myBitmap.Width, myBitmap.Height);

            graphicsObj.Dispose();
            g2.Dispose();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Enabled = true;
            pictureBox.Visible = true;

            pictureBox.BackColor = Color.White;
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bmp;
            G = Graphics.FromImage(bmp);
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pictureBox.DrawToBitmap(bmp, pictureBox.ClientRectangle);

            Form2 newDialog = new Form2();
            Button ok = newDialog.Controls.Find("okButton", true).First() as Button;

            //Image img2 = new Bitmap(500, 500);
            //pictureBox.Image = img2;

            //Form newDialog = new Form();
            //Button okButton = new Button();
            //okButton.Text = "OK";
            //newDialog.Controls.Add(okButton);

            //if (newDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    Image img = new Bitmap(500, 500);
            //    pictureBox.Image = img;
            //} else
            //{
            //    //
            //}
            //newDialog.Dispose();
        }

        private void colorFG_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                colorFG.BackColor = colorDialog.Color;
                fgColor = colorDialog.Color;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Image img = Image.FromStream(myStream);
                            pictureBox.Image = img;
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void fitToScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Size = panel.Size;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.Fill;
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Height += 50;
            pictureBox.Width += 50;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.None;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.Height -= 50;
            pictureBox.Width -= 50;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Dock = DockStyle.None;
        }

        private void actualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            panel.AutoScroll = true;
            pictureBox.Dock = DockStyle.None;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            drawFlag = true;
            xPos[0] = e.X;
            xPos[1] = e.X;
            yPos[0] = e.Y;
            yPos[1] = e.Y;
            //G.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, brushSize, brushSize);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawFlag == true && toolSelected == 0)
            {
                xPos[0] = xPos[1];
                xPos[1] = e.X;
                yPos[0] = yPos[1];
                yPos[1] = e.Y;
                pen.Color = fgColor;
                pen.Width = brushSize;
                G.DrawLine(pen, xPos[0], yPos[0], xPos[1], yPos[1]);
                pictureBox.Refresh();
            } else if (toolSelected == 1)
            {
                //
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            drawFlag = false;
            if (toolSelected == 1)
            {
                Pen pen = new Pen(fgColor, brushSize);
                G.DrawLine(pen, xPos[0], yPos[0], e.X, e.Y);
                pictureBox.Refresh();
            }
        }

        private void brushSizeBox_ValueChanged(object sender, EventArgs e)
        {
            brushSize = Decimal.ToInt32(brushSizeBox.Value);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(saveFileDialog.FileName);
            }
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            toolSelected = 1;
        }

        private void brushButton_Click(object sender, EventArgs e)
        {
            toolSelected = 0;
        }
    }
}
