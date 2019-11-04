using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    public enum Genre
    {
        Rock,
        Pop,
        Dance,
        Other
    }
    class Song : IComparable
    {
       

        public string _title { get; set; }
        public string _Artist { get; set; }
        public double _Duration { get; set; }
        public Genre _genre { get; set; }

        public Song(string title,string artist,Genre genre)
        {
            _title = title;
            _Artist = artist;
            this._genre = genre;
        }

        public void AddGenre(Genre CurrentGenre)
        {
            
        }

        public Song(string name, string artist, double duration)
            : this(name, artist, Genre.Other)
        {
            _title = name;
            _Artist = artist;
            _Duration = duration;
        }

        public override string ToString()
        {
            return string.Format("Artist {0}  Song {1} Duration {2} Genre {3}", _Artist, _title, _Duration,_genre);
        }

        public int CompareTo(object obj)// I comparable
        {
            Song ObjectthatIAmComparingTo = (Song)obj;
            return this._Artist.CompareTo(ObjectthatIAmComparingTo._Artist);
        }
    }
}
