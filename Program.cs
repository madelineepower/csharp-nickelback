using System;
using System.Linq;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string artist, string song)> goodSongs = new List<(string artist, string song)>();
            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();

            allSongs.Add(("Nickelback", "Photograph"));
            allSongs.Add(("Nickelback", "How You Remind Me"));
            allSongs.Add(("Nickelback", "Rockstar"));
            allSongs.Add(("Nickelback", "Too Bad"));
            allSongs.Add(("Bruno Mars", "That's What I Like"));
            allSongs.Add(("Adele", "Hello"));
            allSongs.Add(("Beyonce", "Halo"));

            Console.WriteLine("ALL THE SONGS");
            foreach ((string, string) song in allSongs)
            {
                Console.WriteLine($"{song.Item2} by {song.Item1}");
            }
            Console.WriteLine("-------------------");

            foreach((string, string) song in allSongs)
            {
                if (song.Item1 != "Nickelback")
                {
                    goodSongs.Add(song);
                }

            }
            
            Console.WriteLine("These are the GOOD SONGS");
            foreach ((string artist, string song) song in goodSongs)
            {
                Console.WriteLine($"{song.song} by {song.artist}");
            }

        }
    }
}
