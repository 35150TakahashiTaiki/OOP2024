using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;
using System.IO;

namespace LineCounter {
     class LineCounterProcesser : TextProcessor{

        private int _count;
        string _text = "";

        protected override void Initialize(string fname) {
            _count = 0;

        }

        protected override void Execute(string line) {
            Console.WriteLine(line.ToLower());
            _text = line;
            _count++;
        }

        protected override void Terminate() {
            
            Console.WriteLine("{0}行",_count);
        }
    }
}
