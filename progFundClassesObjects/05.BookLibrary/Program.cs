using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBNnumber { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library()
            {
                Name = "",
                Books = new List<Book>()
            };

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact((input[3]), "dd.MM.yyyy", null);
                string ISBN = input[4];
                double price = double.Parse(input[5]);

                Book book = new Book();
                book.Title = title;
                book.Author = author;
                book.Publisher = publisher;
                book.ReleaseDate = releaseDate;
                book.ISBNnumber = ISBN;
                book.Price = price;

                library.Books.Add(book);
            }

            foreach (var book in library.Books
                .GroupBy(b => b.Author)
                .OrderByDescending(x => x.Sum(p => p.Price))
                .ThenBy(k => k.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(p => p.Price):F2}");
            }
        }
    }
}
