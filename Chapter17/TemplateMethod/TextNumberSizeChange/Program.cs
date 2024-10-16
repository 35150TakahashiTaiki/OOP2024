using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace TextNumberSizeChange {
    internal class Program {
        static void Main(string[] args) {
            //TextProcessor.Run<ToHankakuProcesser>(args[0]);

            var processor = new Framework.TextFileProcesser(new ToHankakuProcesser());
            processor.Run(args[0]);
        }
    }
}
