using Section01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var price = Library.Books.Max(x => x.Price);
            var book = Library.Books.First(x => x.Price == price);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var year = Library.Books.GroupBy(x=> x.PublishedYear).OrderBy(y=>y.Key);
            
            foreach (var item in year) {
                var count = Library.Books.Count(x=>x.PublishedYear==item.Key);
                Console.WriteLine(item.Key+"年:"+count+"冊");
            }

        }

        private static void Exercise1_4() {
            var books = Library.Books.Join(Library.Categories,
                                            book => book.CategoryId,
                                            category => category.Id,
                                            (book, category) => new {
                                                book.Title,
                                                book.PublishedYear,
                                                book.Price,
                                                CategoryName = category.Name,
                                            }).OrderByDescending(a=>a.PublishedYear)
                                              .ThenByDescending(b=>b.Price);
            foreach (var book in books) {
                Console.WriteLine(book.PublishedYear+"年"+book.Price+"円"+
                                  book.Title+"("+book.CategoryName+")");
            }
        }

        private static void Exercise1_5() {
            var category = Library.Books.Where(a => a.PublishedYear == 2016);
            foreach (var item in category) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_6() {
            var groups= Library.Categories.GroupJoin(Library.Books,c=>c.Id
                                                                  ,b=>b.CategoryId,
                                                     (c, books) => new {Category=c.Name, Books=books}).OrderBy(y=>y.Category);
            foreach (var item in groups) {
                Console.WriteLine($"#{item.Category}");
                foreach (var book in item.Books) {
                    Console.WriteLine($" {book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var category = Library.Books.Where(a => a.CategoryId == 1).OrderBy(s=>s.PublishedYear);
            foreach (var item in category) {
                Console.WriteLine($"#{item.PublishedYear}");
                
            }

        }
            private static void Exercise1_8() {
            
        }
    }
}
