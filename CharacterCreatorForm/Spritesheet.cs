using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CharacterCreator
{
    using System.IO;

    public class Spritesheet
    {

        public string Path { get; private set; }
        public int GridWidth { get; set; } = 16;
        public int GridHeight { get; set; } = 16;
        public int Spacing { get; set; } = 1;
        public string Filename
        {
            get { return Path.Substring(Path.LastIndexOf('\\')); }
        }

        public Image image { get; set; }

    private string path;
        public int Width
        {
            get
            {
                return (image != null) ? image.Width : 0;
            }
        }
        public int Height
        {
            get
            {
                return (image != null) ? image.Height : 0;
            }
        }

        public Spritesheet(string path)
        {
            Path = path;
            image = Image.FromFile(path);
        }

        public override string ToString()
        {
            return Filename;
        }

    }
}

