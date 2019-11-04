using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Can't figure out how to get enums to work need to work on this more.
            Song S1 = new Song("Avolon", "Serinity", 4.32);
            Song S2 = new Song("Everlast", "22 Step", 2.45);
            Song S3 = new Song("America", "Eminem", 3.06);
            Song S4 = new Song("123 fake track", "Leona", 4);
            Song S5 = new Song("To the end", "Excella", 3);

            List<Song> Playlist = new List<Song>();
            Playlist.Add(S1);
            Playlist.Add(S2);
            Playlist.Add(S3);
            Playlist.Add(S4);
            Playlist.Add(S5);
            

            Display(Playlist);
            Console.WriteLine();
            Console.WriteLine("Sorting the Artist by Artist,then song title");
            Playlist.Sort();
            Display(Playlist);
            Console.WriteLine();
            Console.WriteLine("Reshuffleing the playlist");
            Reshuffle(Playlist);
            Display(Playlist);
        }
        public static void Reshuffle(List<Song>Songshuffle)
        {
            int randomsong;
            Random shuffle = new Random();//reshuffle method here
            randomsong = shuffle.Next(1,5);//tried the random but not sure here
            //Songshuffle = shuffle
        }

        public static void Display(List<Song>playlist)
        {
            foreach (Song song in playlist)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}",song._Artist,song._title,song._Duration,Genre.Dance);
            }
        }
    }
}
