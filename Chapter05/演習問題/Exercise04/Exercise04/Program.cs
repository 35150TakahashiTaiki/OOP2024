using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            string[] subs = line.Split(';');
            foreach (var sub in subs) {
                string[] cut = sub.Split('=');
                foreach (var cut2 in cut) {
                    if (cut2.Contains("Novelist")) {
                        var chang = cut2.Replace("Novelist", "作家　：");
                    }
                    Console.WriteLine(cut2);
                }
            }

        }

        //できたら以下のメソッドを完成させて利用する
        //static string ToJapanese(string key) {


        //}
    }
}