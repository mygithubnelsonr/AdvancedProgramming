using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingTheBookList();

            // using generics instate
            UsingTheGenericList();

            UsingGenericDictionary();

            UsingNullable();

#if DEBUG
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
#endif
        }

        public static void UsingTheBookList()
        {
            Console.WriteLine("\nUsingTheBookList");
            Console.WriteLine("----------------");

            var book = new Book { ISBN = "121212", Title = "C# advanced" };
            Console.WriteLine($"create a new Book: Title={book.Title}, ISBN={book.ISBN}");

            // usual way working with lists
            var numbers = new List();
            numbers.Add(10);

            var books = new BookList();
            books.Add(book);
        }

        public static void UsingTheGenericList()
        {
            Console.WriteLine("\nUsingTheGenericList");
            Console.WriteLine("--------------------");

            var book = new Book { ISBN = "121212", Title = "C# advanced" };
            Console.WriteLine($"create a new Book: Title={book.Title}, ISBN={book.ISBN}");

            // we want a list of integers, so we define T as type integer
            var numbers = new GenericList<int>();
            numbers.Add(10);

            // we want a list of books, so we define T as type book
            var books = new GenericList<Book>();
            books.Add(book);
        }

        public static void UsingGenericDictionary()
        {
            Console.WriteLine("\nUsingGenericDictionary");
            Console.WriteLine("----------------------");

            var dictionary = new GenericDictionary<string, Book>();
            Console.WriteLine("add a string '234234' and a new Book");
            dictionary.Add("234234", new Book());
        }

        public static void UsingNullable()
        {
            Console.WriteLine("\nUsingNullable");
            Console.WriteLine("-------------");

            // Nullable is a integrated function to
            // var number = new System.Nullable<int>(5);
            var number = new Nullable<int>(5);
            Console.WriteLine("has number? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            number = new Nullable<int>();
            Console.WriteLine("has number? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
