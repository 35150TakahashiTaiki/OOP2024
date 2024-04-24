using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize1 {
    internal class Program {
        static void Main(string[] args) {
            var songs = new Song[3];
            songs[0] = new Song("Come true", "itasuto", 194);
            songs[1] = new Song("Clear morning", "Ogura Yui", 253);
            songs[2] = new Song("真昼の夜の月", "Abidosu",90 );

            foreach(var song in songs) {
                Console.WriteLine("{0}  {1}  {2}:{3}",song.Title,song.ArtistName,song.Length/60,song.Length%60);
            }
        }
    }
}
