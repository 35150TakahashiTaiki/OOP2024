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
            foreach (var xfilelist in xelements) {
                var xkanji = xfilelist.Element("name").Attribute("kanji");
                var xteammembers = xfilelist.Element("teammembers");
                Console.WriteLine("{0}({1})", xkanji.Value, xteammembers.Value);
            }

        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().OrderByDescending(x => x.Element("teammembers").Value).First();
            Console.WriteLine($"{xelements.Element("name").Value}");
        }

        private static void Exercise1_4(string file, string newfile) {
            ReadAddElement(file, newfile);
        }

        private static void AddElement(string file, string newfile) {
            var element = new XElement(file,
                            new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                            new XElement("teammembers", "11"),
                            new XElement("firstplayed", "1863")
                          );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);

            xdoc.Save(newfile);
        }

        public static void ReadAddElement(string file,string newfile) {
            int count;
            List<XElement> list = new List<XElement>();  
            var xdoc = XDocument.Load(file);
            while (true) {  
                //入力処理
                Console.Write("名称：");
                var readname = Console.ReadLine();
                Console.Write("漢字：");
                var readkanji = Console.ReadLine();
                Console.Write("人数：");
                var readteammembers = Console.ReadLine();
                Console.Write("起源：");
                var readfirstplayed = Console.ReadLine();

                //一件分の要素作成
                var element = new XElement(file,
                   new XElement("name", readname, new XAttribute("kanji", readkanji)),
                   new XElement("teammembers", readteammembers.ToString()),
                   new XElement("firstplayed", readfirstplayed.ToString())
                 );

                list.Add(element);//リストに要素追加

                Console.Write("追加[1] 保存[2] >");
                 count = int.Parse(Console.ReadLine());
                if(count ==2) {
                    break;
                }
            }
            xdoc.Root.Add(list);
            xdoc.Save(newfile);
        }
    }
}
