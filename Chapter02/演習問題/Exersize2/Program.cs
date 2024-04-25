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
            } else if (args.Length >= 1 && args[0] == "-sam") {
                PrintMetertoInti(int.Parse(args[1]), int.Parse(args[2]));
            } else if (args.Length >= 1 && args[0] == "-maria") {
                PrintYardtoMeter(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                PrintMetertoYard(int.Parse(args[1]), int.Parse(args[2]));
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
            //ヤードからメートル
            private static void PrintYardtoMeter(int start, int stop) {
                for (int yard = start; yard <= stop; yard++) {
                    double meter = YardConverter.MeterToYard(yard);
                    Console.WriteLine("{0}yard = {1:0.0000}m", yard, meter);
                }
            }
            //メートルからヤード
            private static void PrintMetertoYard(int start, int stop) {
                for (int meter = start; meter <= stop; meter++) {
                    double yard = YardConverter.YardToMeter(meter);
                    Console.WriteLine("{0}m = {1:0.0000}yard", meter, yard);
                }
            }
        }
    }

