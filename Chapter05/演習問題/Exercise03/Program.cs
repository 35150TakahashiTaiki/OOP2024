using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            var text2 = "Jackdaws,love my-big/sphinx:of#quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            Console.WriteLine("-----");

            Exercise3_6(text2);
        }

       

        private static void Exercise3_1(string text) {
            char ch = ' ';
            int blank = text.Count(b => (b == ch));
            Console.WriteLine("空白："+blank);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            string[] subs = text.Split();
            Console.WriteLine("単語："+subs.Length);
        }

        private static void Exercise3_4(string text) {
            var subs = text.Split().Where(s => s.Length <= 4);
            foreach (string sub in subs) {
                Console.WriteLine(sub);
            }
        }

        private static void Exercise3_5(string text) {
            string[] subs = text.Split();
            var sb = new StringBuilder();
            foreach (var word in subs) {
                sb.Append(word);
                sb.Append(' ');
            }
            var tx = sb.ToString();
            Console.WriteLine(tx);
        } 
        
        private static void Exercise3_6(string text2) {
            string[] subs = text2.Split(' ',',','-','^','/',':','#');
            var sb = new StringBuilder();
            foreach (var word in subs) {
                sb.Append(word);
                sb.Append(' ');
            }
            var tx = sb.ToString();
            Console.WriteLine(tx);
        }
    }
}
