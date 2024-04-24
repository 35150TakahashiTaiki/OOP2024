using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersize2 {
    internal class Program {
        static void Main(string[] args) {
            double ratio = 0.0254;//定数
            for (int inti = 1; inti <= 10; inti++) {
                double meter = inti * ratio;
                Console.WriteLine("{0}インチ = {1:0.0000}m", inti, meter);
            }
        }
        
    }
}
