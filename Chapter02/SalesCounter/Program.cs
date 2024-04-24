using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    internal class Program {
        static void Main(string[] args) {
            //戻り値を受け取る
            List<Sale> sales = ReadSales(@"C:\Users\infosys\source\repos\OOP2024\Chapter02\SalesCounter\bin\Debug\date\Sales.csv");

            //戻り値のコレクションを一件ずつ出力する
            foreach (Sale sale in sales) {
                Console.WriteLine(sale.ShopName + "  " + sale.ProductCategory + "  " + sale.Amount);
                //Console.WriteLine("{0} {1} {2}",sale.ShopName, sale.ProductCategory ,sale.Amount);
            }
            {

            }
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

    }
}
