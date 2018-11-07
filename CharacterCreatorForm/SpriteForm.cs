using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;

namespace CharacterCreator
{
    public partial class SpriteForm : Form
    {
        Bitmap drawArea = null;

        Character character = new Character();

        public Spritesheet Spritesheet
        {
            get { return character.Spritesheet; }
            set
            {
                if (string.Compare(value.Path, character.Spritesheet.Path) == 0)
                {
                    // the path is the same, so we can simply replace the reference
                    character.Spritesheet = value;
                }
                else
                {
                    // otherwise, we clear the layers too
                    character.Spritesheet = value;
                    character.Layers.Clear();
                }
            }
        }

        public SpriteForm()
        {
            InitializeComponent();

            drawArea = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        private void SpriteForm_Activated(object sender, EventArgs e)
        {
            MdiClient parent = Parent as MdiClient;
            if (parent != null)
            {
                foreach (Form child in parent.MdiChildren)
                {
                    if (child.GetType() == typeof(SpriteSheetForm))
                    {
                        SpriteSheetForm sheet = child as SpriteSheetForm;
                        Spritesheet ss = sheet.Spritesheet;
                        if (ss != null && !comboBoxSheets.Items.Contains(ss))
                        {
                            comboBoxSheets.Items.Add(ss);
                        }
                    }
                }
            }

            if (character.Spritesheet != null)
            {
                comboBoxSheets.SelectedItem = character.Spritesheet;
            }
            else if (comboBoxSheets.Items.Count > 0)
            {
                comboBoxSheets.SelectedIndex = 0;
                character.Spritesheet = comboBoxSheets.SelectedItem as Spritesheet;
            }

            // fill list view with any layers the character has
            listViewTiles.Items.Clear();
            for (int i = 0; i < character.Layers.Count; i++)
            {
                listViewTiles.Items.Add(character.Layers[i].GetListViewItem());
            }
        }

        public SpriteSheetForm FindSheet()
        {
            MdiClient parent = Parent as MdiClient;
            if (parent != null)
            {
                foreach (Form child in parent.MdiChildren)
                {
                    if (child.GetType() == typeof(SpriteSheetForm))
                    {
                        SpriteSheetForm sheet = child as SpriteSheetForm;
                        if (sheet.Spritesheet == character.Spritesheet)
                            return sheet;
                    }
                }
            }
            return null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (character != null)
            {
                SpriteSheetForm sheet = FindSheet();
                if (sheet != null)
                {
                    Layer layer = new Layer("Unnamed Layer");
                    layer.TileCoordinates = sheet.CurrentTile;
                    layer.Priority = character.Layers.Count + 1;

                    character.Layers.Add(layer);

                    listViewTiles.Items.Add(layer.GetListViewItem());

                    DrawCharacter();
                }
            }
        }

        private void DrawCharacter()
        {
            Graphics g = Graphics.FromImage(drawArea);
            g.FillRectangle(Brushes.White, 0, 0, drawArea.Width, drawArea.Height);

            Rectangle dest = new Rectangle(0, 0,
                character.Spritesheet.GridWidth << 2,
                character.Spritesheet.GridHeight << 2);

            foreach (Layer layer in character.Layers)
            {
                Rectangle source = new Rectangle(
                    layer.TileCoordinates.X * (character.Spritesheet.GridWidth + character.Spritesheet.Spacing),
                    layer.TileCoordinates.Y * (character.Spritesheet.GridHeight + character.Spritesheet.Spacing),
                    character.Spritesheet.GridWidth,
                    character.Spritesheet.GridHeight);

                g.DrawImage(character.Spritesheet.Image, dest, source, GraphicsUnit.Pixel);
            }
            g.Dispose();

            pictureBox.Image = drawArea;
        }

        private void comboBoxSheets_SelectedValueChanged(object sender, EventArgs e)
        {
            // validate that a new item was actually selected (since this event is also called
            // when initially setting the selected value during the Activated event handler)
            if (character.Spritesheet == comboBoxSheets.SelectedItem as Spritesheet)
                return;

            // different spritesheet selected, clear the layers
            listViewTiles.Items.Clear();

            character.Spritesheet = comboBoxSheets.SelectedItem as Spritesheet;
            character.Layers.Clear();

            // clear the image

            Graphics g = Graphics.FromImage(drawArea);
            g.FillRectangle(Brushes.White, 0, 0, drawArea.Width, drawArea.Height);
            g.Dispose();
            pictureBox.Image = drawArea;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indicies = listViewTiles.SelectedIndices;
            if (indicies.Count <= 0)
                return;

            // remove the selected layer from the layers list
            character.Layers.RemoveAt(indicies[0]);

            // delete and rebuild the list view (with updated priority values)
            listViewTiles.Items.Clear();

            // renumber layers
            for (int i = 0; i < character.Layers.Count; i++)
            {
                character.Layers[i].Priority = i + 1;
                listViewTiles.Items.Add(character.Layers[i].GetListViewItem());
            }

            DrawCharacter();
        }

        private void listViewTiles_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            int index = e.Item;
            character.Layers[index].Name = e.Label;
        }

        public void SerializeItem(string fileName, IFormatter formatter)
        {
            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, character);
            s.Close();
        }

        public void DeserializeItem(string fileName, IFormatter formatter)
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            character = (Character)formatter.Deserialize(s);
            s.Close();
            DrawCharacter();
        }

    }
}
