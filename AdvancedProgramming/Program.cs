using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book { ISBN = "121212", Title = "C# advanced" };

            //// usual way working with lists
            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            //// using generics instate
            //var numbers = new GenericList<int>();
            //numbers.Add(10);
            //var books = new GenericList<Book>();
            // books.Add(book);
            //books.Add(new Book());
            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("234234", new Book());

            //var nu = new System.Nullable<int>(5);
            var number = new Nullable<int>(5);

            Console.WriteLine("has number? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
            Console.ReadLine();
        }
    }
}
