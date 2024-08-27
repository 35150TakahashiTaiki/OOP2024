using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            //シリアル化
            var employee = new Employee {
                Id = 04,
                Name = "飛鳥",
                HireDate = new DateTime(2009,6,3),
            };

            var settings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };
            using (var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(writer, employee);
            }
            //逆シリアル化
            using (var reader = XmlReader.Create("employee.xml")) {
                var serializer = new XmlSerializer(typeof(Employee));
                var emp = (Employee)serializer.Deserialize(reader);
                Console.WriteLine(emp);
            }
        }

        private static void Exercise1_2(string outfile) {
            var emps = new Employee[] {
                new Employee{
                Id = 123,
                Name = "出水　秀明",
                HireDate =new DateTime(2005,5,10),
                },
                new Employee{
                Id = 139,
                Name = "大橋　孝志",
                HireDate =new DateTime(2004,12,1),
                },
            };
            var settings = new XmlWriterSettings {
                Encoding = new UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

      
            using (var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new DataContractSerializer(outfile.GetType());
                serializer.WriteObject(writer, outfile);
            }
        }

        private static void Exercise1_3(string file) {
            
        }

        private static void Exercise1_4(string file) {
            
        }
    }
}
