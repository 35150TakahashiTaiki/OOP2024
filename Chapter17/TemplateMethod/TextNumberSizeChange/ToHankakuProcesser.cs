using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;
using System.IO;
using TextNumberSizeChange.Framework;

namespace TextNumberSizeChange {
    class ToHankakuProcesser : ITextFileService {

        private Dictionary<char, char> fullWidthToHalfWidth = new Dictionary<char, char> {
            {'０', '0'}, {'１', '1'}, {'２', '2'}, {'３', '3'},
            {'４', '4'}, {'５', '5'}, {'６', '6'}, {'７', '7'},
            {'８', '8'}, {'９', '9'}
        };

        private int _count;
        string _text = "";

        public void Initialize(string fname) {
            _count = 0;

        }

        public void Execute(string line) {
            
           
            string convertedLine = ConvertFullToHalf(line);
            Console.WriteLine(convertedLine);
            _count++;
        }

        public void Terminate() {
            
            Console.WriteLine("{0}行",_count);
        }


        private string ConvertFullToHalf(string input) {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++) {
                if (fullWidthToHalfWidth.TryGetValue(input[i], out char halfWidthChar)) {
                    result[i] = halfWidthChar; 
                } else {
                    result[i] = input[i]; 
                }
            }
            return new string(result);
        }

        

        

    }
}
