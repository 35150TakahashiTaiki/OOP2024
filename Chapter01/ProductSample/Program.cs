using SampleApp;
using System;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123,"かりんとう",180);
            int price = karinto.Price;//税抜きの価格
            int taxIncluded = karinto.GetPriceIncludingTax();//税込みの価格
            Console.WriteLine(karinto.Name+"の税込み価格" + taxIncluded + "円【税抜き" + price + "円】");

            Product daihuku = new Product(212, "大福", 230);
            int daifukuprice = daihuku.Price;//税抜きの価格
            int daifukutaxIncluded = daihuku.GetPriceIncludingTax();//税込みの価格
            Console.WriteLine(daihuku.Name + "の税込み価格" + daifukutaxIncluded + "円【税抜き" + daifukuprice + "円】");

            Product dorayaki = new Product(98, "どら焼き", 210);
            int dorayakiTax = dorayaki.GetTax();
            Console.WriteLine(dorayaki.Name+"の消費税"+$"{dorayakiTax}円");



        }
    }
}
