using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersize2 {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                PrintIntitoMeter(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                PrintMetertoInti(int.Parse(args[1]), int.Parse(args[2]));
            }
        }
        //インチからメートル
        private static void PrintIntitoMeter(int start, int stop) {
        for (int inti = start; inti <= stop; inti++) {
                double meter = IntiConverter.IntitoMeter(inti);
                Console.WriteLine("{0}インチ = {1:0.0000}m", inti, meter);
            }
        }
        //メートルからインチ
        private static void PrintMetertoInti(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double inti = IntiConverter.MetertoInti(meter);
                Console.WriteLine("{0}m = {1:0.0000}インチ", meter, inti);
            }
        }
    }
}
