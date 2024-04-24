using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize1 {
    internal class Song {

        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }
        //コンストラクタ
        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }
    }
}
