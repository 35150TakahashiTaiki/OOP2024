using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise01 {
    internal class Program {

        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            #region
            /*var sports = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = x.Element("name").Value,
                                    Teammembers = x.Element("teammembers").Value
                                });
            foreach(var sport in sports) {
                Console.WriteLine("{0} {1}",sport.Name,sport.Teammembers);
            }*/
            #endregion
            var xelements = xdoc.Root.Elements();
            foreach (var xfilelist in xelements) {
                var xname = xfilelist.Element("name");
                var xteammembers = xfilelist.Element("teammembers");
                Console.WriteLine($"競技名:{xname.Value}　チームメンバー数:{xteammembers.Value}");
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().OrderBy(x => (string)(x.Element("firstplayed")));
            foreach(var xfilelist in xelements) {
                var xkanji = xfilelist.Element("name").Attribute("kanji");
                var xteammembers = xfilelist.Element("teammembers");
                Console.WriteLine("{0}({1})", xkanji.Value, xteammembers.Value);
            }
            
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Max(x => (string)x.Element("teammembers"));
            Console.WriteLine(xelements.ToString());
        }

        private static void Exercise1_4(string file, string newfile) {

        }
    }
}
