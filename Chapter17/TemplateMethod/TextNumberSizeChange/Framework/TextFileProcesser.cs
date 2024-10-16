using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNumberSizeChange.Framework {
    public class TextFileProcesser {
        private ITextFileService _service;

        public TextFileProcesser(ITextFileService service) {
            _service = service;
        }

        public void Run(string filefname) {
            _service.Initialize(filefname);
            using (var sr = new StreamReader(filefname)) {
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    _service.Execute(line);
                }
            }
            _service.Terminate();
        }
    }
}
