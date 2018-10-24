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
        public Spritesheet Spritesheet { get; private set; }
        Bitmap drawArea;
        public Point CurrentTile { get; private set; } = new Point();
        public string Filename
        {
            get
            {
                return (Spritesheet != null) ?
                    Spritesheet.Filename : string.Empty;
            }
        }
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
                    Spritesheet = new Spritesheet(dlg.FileName);
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
            if (Spritesheet == null)
                return;
            g.DrawImage(Spritesheet.image, 0, 0);

            Pen pen = new Pen(Brushes.Black);
            int height = pictureBox.Height;
            int width = pictureBox.Width;
            for (int y = 0; y < height; y += Spritesheet.GridHeight + Spritesheet.Spacing)
            {
                g.DrawLine(pen, 0, y, width, y);
            }
            for (int x = 0; x < width; x += Spritesheet.GridWidth + Spritesheet.Spacing)
            {
                g.DrawLine(pen, x, 0, x, height);
            }

            Pen highlight = new Pen(Brushes.Red);
            g.DrawRectangle(highlight,
                CurrentTile.X * (Spritesheet.GridWidth + Spritesheet.Spacing),
                CurrentTile.Y * (Spritesheet.GridHeight + Spritesheet.Spacing),
                Spritesheet.GridWidth + Spritesheet.Spacing,
                Spritesheet.GridHeight + Spritesheet.Spacing);

            g.Dispose();
            pictureBox.Image = drawArea;
        }
        private void Height_TextChanged(object sender, EventArgs e)
        {
            int height;
            if (int.TryParse(Height.Text, out height) == true)
            {
                Spritesheet.GridHeight = height;
                drawGrid();
            }
            Height.Text = Spritesheet.Height.ToString();
        }
        private void Width_TextChanged(object sender, EventArgs e)
        {
            int width;
            if (int.TryParse(Width.Text, out width) == true)
            {
                Spritesheet.GridWidth = width;
                drawGrid();
            }
            Width.Text = Spritesheet.GridWidth.ToString();
        }
        private void Spacing_TextChanged(object sender, EventArgs e)
        {
            int spacing;
            if (int.TryParse(Spacing.Text, out spacing) == true)
            {
                Spritesheet.Spacing = spacing;
                drawGrid();
            }
            Spacing.Text = Spritesheet.Spacing.ToString();
        }
        private void SpriteSheetForm_Shown(object sender, EventArgs e)
        {
            drawGrid();
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (Spritesheet == null)
                return;
            // get tile coordinate of click
            if (e.GetType() == typeof(MouseEventArgs))
            {
                MouseEventArgs mouse = e as MouseEventArgs;
                CurrentTile = new Point(
                    mouse.X / (Spritesheet.GridWidth + Spritesheet.Spacing),
                    mouse.Y / (Spritesheet.GridHeight + Spritesheet.Spacing));
                drawGrid();
            }
        }
    }
}

//UP TO PAGE 6