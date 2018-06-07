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
using System.Collections;

namespace Painter
{
    public partial class Form1 : Form
    {
        bool drawFlag = false;
        int[] xPos = new int[2];
        int[] yPos = new int[2];
        List<Point> points = new List<Point>();
        Graphics G;
        Color fgColor = Color.Black;
        int brushSize = 1;
        int toolSelected = 0;
        Pen pen;

        Bitmap temp;
        List<Bitmap> layers = new List<Bitmap>();   //list of bitmaps, photoshop order
        List<bool> drawLayers = new List<bool>();   //list of whether each layer is checked, photoshop order
        int activeLayer = 0;

        Graphics testG;

        bool draw0;
        bool draw1;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            pen = new Pen(fgColor, brushSize);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;

            this.DoubleBuffered = true;
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            layers.Insert(0, new Bitmap(panel.Width, panel.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb));
            layers[0].MakeTransparent();
            drawLayers.Insert(0, true);

            layers.Insert(1, new Bitmap(panel.Width, panel.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb));
            layers[1].MakeTransparent();
            drawLayers.Insert(1, true);

            temp = new Bitmap(panel.Width, panel.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            temp.MakeTransparent();

            layerPanel.SetItemChecked(0, true);     //CAREFUL: using SetItemChecked() causes ItemCheck() to be called!
            layerPanel.SetItemChecked(1, true);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            int numItems = layerPanel.Items.Count;
            for (int i = 0; i < numItems; i++)
            {
                if (drawLayers[i])
                {
                    e.Graphics.DrawImage(layers[i], 0, 0, layers[i].Width, layers[i].Height);
                }
            }

            e.Graphics.DrawImage(temp, 0, 0, temp.Width, temp.Height);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            drawFlag = true;
            xPos[0] = e.X;
            xPos[1] = e.X;
            yPos[0] = e.Y;
            yPos[1] = e.Y;
            points = new List<Point>();
            points.Add(new Point(e.X, e.Y));
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawFlag == true && toolSelected == 0)      // BRUSH
            {
                xPos[0] = xPos[1];
                xPos[1] = e.X;
                yPos[0] = yPos[1];
                yPos[1] = e.Y;
                points.Add(new Point(e.X, e.Y));
                Point[] pointsArr = points.ToArray<Point>();

                pen.Color = Color.FromArgb(opacityBar.Value, fgColor);
                pen.Width = brushSize;
                testG = Graphics.FromImage(layers[activeLayer]);
                testG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                //Pen eraser = new Pen(Color.FromArgb(0, fgColor), brushSize);
                //testG.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                //testG.DrawLines(eraser, pointsArr);
                //testG.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                //testG.DrawLines(pen, pointsArr);
                testG.DrawLine(pen, xPos[0], yPos[0], xPos[1], yPos[1]);
                panel.Refresh();
            } else if (drawFlag == true && toolSelected == 1)   // LINE PREVIEW
            {
                pen.Color = fgColor;
                pen.Width = brushSize;
                testG = Graphics.FromImage(temp);
                testG.Clear(Color.Transparent);
                testG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                testG.DrawLine(pen, xPos[0], yPos[0], e.X, e.Y);
                panel.Refresh();
            } else if (drawFlag == true && toolSelected == 2)   // ERASER
            {
                xPos[0] = xPos[1];
                xPos[1] = e.X;
                yPos[0] = yPos[1];
                yPos[1] = e.Y;
                pen.Color = Color.Transparent;
                pen.Width = brushSize;
                testG = Graphics.FromImage(layers[activeLayer]);
                testG.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                testG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                testG.DrawLine(pen, xPos[0], yPos[0], xPos[1], yPos[1]);
                panel.Refresh();
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            drawFlag = false;
            if (toolSelected == 1)      // LINE
            {
                pen.Color = fgColor;
                pen.Width = brushSize;
                testG = Graphics.FromImage(layers[activeLayer]);
                testG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                testG.DrawLine(pen, xPos[0], yPos[0], e.X, e.Y);
                panel.Refresh();
            }
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

        private void layerPanel_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int numItems = layerPanel.Items.Count;
            for (int i = 0; i < numItems; i++)
            {
                if (e.Index == (numItems - 1 - i))
                {
                    drawLayers[i] = e.NewValue == CheckState.Checked;
                }
            }
            panel.Refresh();
        }

        private void layerPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeLayer = layerPanel.SelectedIndex;
            activeLayer = layerPanel.Items.Count - 1 - activeLayer;
        }

        private void newLayer_Click(object sender, EventArgs e)
        {
            layerPanel.Items.Insert(0, "Layer");

            //layers.Insert(0, new Bitmap(panel.Width, panel.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb));
            layers.Add(new Bitmap(panel.Width, panel.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb));
            layers[layers.Count-1].MakeTransparent();

            //drawLayers.Insert(0, true);
            drawLayers.Add(true);

            layerPanel.SetItemChecked(0, true);     // CAREFUL: causes ItemCheck() to be called
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            toolSelected = 2;
        }
    }

    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint, true);
        }
    }
}
