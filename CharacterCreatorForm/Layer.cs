using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace CharacterCreator
{
    [Serializable]
    public class Layer : ISerializable
    {
        public string Name { get; set; }

        public Point TileCoordinates { get; set; }

        public int Priority { get; set; }

        public ListViewItem GetListViewItem()
        {
            ListViewItem item = new ListViewItem(Name);
            item.SubItems.Add(Priority.ToString());
            item.SubItems.Add(TileCoordinates.X.ToString());
            item.SubItems.Add(TileCoordinates.Y.ToString());

            return item;
        }

        public Layer(string name)
        {
            Name = name;
        }

        public Layer(string name, Point coordinates)
        {
            Name = name;
            TileCoordinates = coordinates;
        }

        // The special constructor is used to deserialize values.
        public Layer(SerializationInfo info, StreamingContext context)
        {
            // Reset the property value using the GetValue method.
            Name = (string)info.GetValue("name", typeof(string));
            Priority = (int)info.GetValue("priority", typeof(int));

            Point tile = new Point();
            tile.X = (int)info.GetValue("tilex", typeof(int));
            tile.Y = (int)info.GetValue("tiley", typeof(int));
            TileCoordinates = tile;
        }

        // The method is called on serialization.
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("name", Name, typeof(string));
            info.AddValue("priority", Priority, typeof(int));
            info.AddValue("tilex", TileCoordinates.X, typeof(int));
            info.AddValue("tiley", TileCoordinates.Y, typeof(int));
        }
    }
}
