using System;
using System.Drawing;
using System.Windows.Forms;

namespace CharacterCreator
{
    class Layer
    {
        public string Name { get; set; }
        
        public Point TileCoordinates { get; set; }
        
        public int Priority { get; set; }

        public Layer(string name)
        {
            Name = name;
        }
        public ListViewItem GetListViewItem()
        {
            ListViewItem item = new ListViewItem(Name);
            item.SubItems.Add(Priority.ToString());
            item.SubItems.Add(TileCoordinates.X.ToString());
            item.SubItems.Add(TileCoordinates.Y.ToString());
            return item;
        }
        public Layer(string name, Point coordinates)
        {
            Name = name;
            TileCoordinates = coordinates;
        }
    }
}