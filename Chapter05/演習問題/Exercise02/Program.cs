using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            int number;
            Console.Write("数字入力：");
            string str = Console.ReadLine();        
            bool result = int.TryParse(str,out number);
            if (result) {
                Console.WriteLine(number.ToString("#,#"));
            } else {
                Console.WriteLine("false");
            }
        }
    }
}
