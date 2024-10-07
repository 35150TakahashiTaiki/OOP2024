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
            var query = Library.Books.Where(a => a.PublishedYear == 2016)
                                        .Join(Library.Categories,book => book.CategoryId
                                                                ,category => category.Id
                                                                ,(book,category)=>category.Name).Distinct();
            foreach (var item in query) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_6() {
            var groups= Library.Categories.GroupJoin(Library.Books,c=>c.Id
                                                                  ,b=>b.CategoryId,
                                                     (c, books) => new {Category=c.Name, Books=books})
                                                    .OrderBy(y=>y.Category);
            foreach (var item in groups) {
                Console.WriteLine($"#{item.Category}");
                foreach (var book in item.Books) {
                    Console.WriteLine($" {book.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var category = Library.Categories.Single(a => a.Name == "Development").Id;
            var query = Library.Books.Where(b => b.CategoryId == category)
                                     .GroupBy(b => b.PublishedYear)
                                     .OrderBy(b => b.Key);
            
            foreach (var item in query) {
                Console.WriteLine($"#{item.Key}年");
                foreach(var title in item) {
                    Console.WriteLine($" {title.Title}");
                }
                
            }

        }
            private static void Exercise1_8() {
            
        }
    }
}
