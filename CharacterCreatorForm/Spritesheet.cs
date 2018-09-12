using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CharacterCreator
{
    using System.IO;

    class Spritesheet
    {
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
            this.path = path;
            Load();
        }

        public void Load()
        {
            
            {
                this.image = Image.FromFile(path);
            }
        }
        public override string ToString()
        {
            return base.ToString() + ": " + path.ToString();
        }
        
    }
}

