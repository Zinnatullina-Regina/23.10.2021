using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Song
    {
        private string name;
        private string author;

        public string Name
        {
            get { return name; }
        }
        public string Author
        {
            get { return author; }
        }

        public Song(string name, string author)
        {
            this.author = author;
            this.name = name;
        }
        public string Title()
        {
            return name + " " + author;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Song song = obj as Song;
            return (this.name == song.name) && (this.author == song.author);
        }

    }
}
