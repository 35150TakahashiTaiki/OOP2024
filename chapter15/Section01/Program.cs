using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var groups = Library.Books.GroupBy(b => b.PublishedYear)
                                      .OrderBy(g => g.Key);

            
            foreach ( var item in groups) {
                Console.WriteLine($"{item.Key}年");
                foreach(var book in item) {
                    Console.WriteLine($" {book}");
                }
            }
        }
    }
}
