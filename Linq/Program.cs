using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Beispiel 1
            // Linq Query Operators
            Console.WriteLine("Linq Query Operators");
            var cheaperBooks =
                from b in books
                where b.Price < 9
                orderby b.Title
                select b.Title;

            // Linq Extension Methods
            Console.WriteLine("Linq Extension Methods");
            var cheapeBooks = books
                        .Where(b => b.Price > 9)
                        .OrderBy(b => b.Title)
                        .Select(b => new { b.Title, b.Price });
            foreach (var bk in cheapeBooks)
            {
                string s = " ".PadRight(33 - bk.Title.Length - bk.Price.ToString().Length);
                Console.WriteLine(bk.Title + s + bk.Price);
            }
            Console.WriteLine(new string('-', 40));

            Book book;
            // Beispiel 2, using single, singleordefault instead of where
            Console.WriteLine("searching for book 'ASP.Net MVC'");
            book = books.Single(b => b.Title == "ASP.Net MVC");
            // returns only one record if find one, otherwhise it throws an error
            // e.g. var book = books.Single(b => b.Title == "ASP.Net MVC++");
            if (book == null)
                Console.WriteLine("book not found!");
            else
                Console.WriteLine(book.Title);

            Console.WriteLine("searching for not existing book 'ASP.Net MVC++'");
            book = books.SingleOrDefault(b => b.Title == "ASP.Net MVC++");
            // returns only one record if find one, otherwhise returns null

            if (book == null)
                Console.WriteLine("book is null (not found)");
            else
                Console.WriteLine(book.Title);

            Console.WriteLine(new String('-', 40));

            // Beispiel 3
            Console.WriteLine("using\nFirst, FirstOrDefault\nLast, LastOrDefault\nSkip, Take");
            Console.WriteLine("First or FirstOrDefault");
            book = books.Find(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book.Title + "\t\t" + book.Price);
            Console.WriteLine("Last or LastOrDefault");
            book = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book.Title + "\t\t" + book.Price);
            Console.WriteLine(new String('-', 40));

            // Beispiel 4, use skip and take for e.g. paging
            Console.WriteLine("skip and take for e.g. paging");
            var page = books.Skip(2).Take(3);

            foreach (var b in page)
            {
                string s = " ".PadRight(33 - b.Title.Length - b.Price.ToString().Length);
                Console.WriteLine(b.Title + s + b.Price);
            }
            Console.WriteLine(new string('-', 40));

            // Beispiel 5, using aggregate functions
            Console.WriteLine("using aggregate functions");
            var cnt2 = books.Count();
            Console.WriteLine("count of all books is " + cnt2);

            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine("max price in books is " + maxPrice);

            var minPrice = books.Min(b => b.Price);
            Console.WriteLine("min price in books is " + minPrice);

            var sumPrice = books.Sum(b => b.Price);
            Console.WriteLine("sum of price in books is " + sumPrice);

            var avPrice = books.Average(b => b.Price);
            Console.WriteLine("average price in books is " + avPrice);

            Console.WriteLine(new string('-', 40));

#if DEBUG
            Console.WriteLine("press any key to finish");
            Console.ReadKey();
#endif
        }
    }
}
