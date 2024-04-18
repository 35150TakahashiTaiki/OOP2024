﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DistanceConverter {
    public class Program {
        static void Main(string[] args) {
            
            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {  
                PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }

        private static void PrintMeterToFeetList(int start, int stop) {
            FeetConverter fc = new FeetConverter();
            //メートルからフィートへの対応表を出力
            for (int meter = start; meter <= stop; meter++) {
                double feet = fc.MeterToFeet(meter);
                Console.WriteLine("{0}m = {1:0.0000}ft", meter, feet);
            }
        }

        private static void PrintFeetToMeterList(int start,int stop) {
            FeetConverter fc = new FeetConverter();
            //フィートからメートルへの対応表を出力
            for (int feet = start; feet <= stop; feet++) {
                double meter = fc.FeetToMeter(feet);
                Console.WriteLine("{0}ft = {1:0.0000}m", feet, meter);
            }
        }

       
    }
}
