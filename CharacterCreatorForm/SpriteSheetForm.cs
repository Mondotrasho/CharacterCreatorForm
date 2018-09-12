using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class SpriteSheetForm : Form
    {
        Spritesheet spritesheet = null;
        Bitmap drawArea;
        int gridWidth = 16;
        int gridHeight = 16;
        int spacing = 0;
        public SpriteSheetForm()
        {
            InitializeComponent();
            drawArea = new Bitmap(pictureBox.Width, pictureBox.Height);
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.CheckFileExists == true)
                {
                    spritesheet = new Spritesheet(dlg.FileName);
                    drawGrid();
                }
            }
        }
        private void drawGrid()
        {
            pictureBox.DrawToBitmap(drawArea, pictureBox.Bounds);
            Graphics g;
            g = Graphics.FromImage(drawArea);
            g.Clear(Color.White);
            if (spritesheet != null)
            {
                g.DrawImage(spritesheet.image, 0, 0);
            }
            Pen pen = new Pen(Brushes.Black);
            int height = pictureBox.Height;
            int width = pictureBox.Width;
            for (int y = 0; y < height; y += gridHeight + spacing)
            {
                g.DrawLine(pen, 0, y, width, y);
            }
            for (int x = 0; x < width; x += gridWidth + spacing)
            {
                g.DrawLine(pen, x, 0, x, height);
            }
            g.Dispose();
            pictureBox.Image = drawArea;
        }
        private void Height_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Height.Text, out gridHeight) == true)
            {
                drawGrid();
            }
            Height.Text = gridHeight.ToString();
        }
        private void Width_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Width.Text, out gridWidth) == true)
            {
                drawGrid();
            }
            Width.Text = gridWidth.ToString();
        }
        private void Spacing_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(Spacing.Text, out spacing) == true)
            {
                drawGrid();
            }
            Spacing.Text = spacing.ToString();
        }
        private void SpriteSheetForm_Shown(object sender, EventArgs e)
        {
            drawGrid();
        }
    }
}

