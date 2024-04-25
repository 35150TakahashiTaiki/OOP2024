using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize1 {
    internal class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
            new Song("Come true", "Itasuto", 194),
            new Song("Clear morning", "Ogura Yui", 253),
            new Song("真昼の夜の月", "Abidosu", 90),
            };
            PrintSongs(songs);
        }

        private static void PrintSongs(Song[] songs)  {
            foreach (var song in songs) {
                Console.WriteLine("{0}  {1}  {2}:{3}", song.Title, song.ArtistName, song.Length / 60, song.Length % 60);
            }
        }
        
    }
}
