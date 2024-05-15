using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            //var count = numbers.Count(n => n%2== 0);
            //var count = Count(numbers,n => n >= 5 && n<10);
            //var count = Count(numbers, n => n.ToString().Contains('1'));
            double num = numbers.Where(n => n >= 5).Average();
            int total = numbers.Where(n => n >= 5).Sum();
            Console.WriteLine(num);
            Console.WriteLine(total);
        }

        


        /*public static int Count(int[] numbers, Predicate<int> judge) {
            int count = 0;
            foreach (var n in numbers) {
                if(judge(n) == true)
                    count++;
            }
            return count;
       
        } */

    }
}
