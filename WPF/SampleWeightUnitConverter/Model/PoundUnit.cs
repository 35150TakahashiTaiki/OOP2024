using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWeightUnitConverter {
    public class PoundUnit : WeightUnit {
        private static List<PoundUnit> units = new List<PoundUnit> {
            new PoundUnit{Name="gr",Coefficient=1,},
            new PoundUnit{Name="dr",Coefficient=7000,},
            new PoundUnit{Name="oz",Coefficient=7000*256,},
            new PoundUnit{Name="lb",Coefficient=7000*256*16,},      
        };

        public static ICollection<PoundUnit> Units { get { return units; } }

        /// <summary>
        /// グラム単位からポンド単位に変換
        /// </summary>
        /// <param name="unit">メートル単位</param>
        /// <param name="value">値</param>
        /// <returns></returns>
        public double FromGramUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient) / 453.6 / this.Coefficient;
        }
    }
}
