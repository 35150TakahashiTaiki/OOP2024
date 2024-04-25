using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exersize2 {
    internal class IntiConverter {
        public static readonly double ratio = 0.0254;//定数
        //インチからメートル
        public static double IntitoMeter(double inti) {
            return inti * ratio;
        }
        //メートルからインチ
        public static double MetertoInti(double meter) {
            return meter / ratio;
        }
    }
}
