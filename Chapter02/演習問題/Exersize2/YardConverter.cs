using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersize2 {
    internal class YardConverter {
        public static readonly double ratio = 0.914;//定数
        //メートルからヤードを求める
        public static double MeterToYard(double meter) {
            return meter / ratio;
        }
        //ヤードからメートルを求める
        public static double YardToMeter(double yard) {
            return yard * ratio;
        }
    
}
}
