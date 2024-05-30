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
                Console.WriteLine(cut.Length);
            }

        }

        //できたら以下のメソッドを完成させて利用する
        //static string ToJapanese(string key) {


        //}
    }
}