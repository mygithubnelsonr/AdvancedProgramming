using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // lambda
            // args => expression (goes)
            // () => ...
            // x => ...
            // (x,y,z) => ...

            // number => number * number

            // sampl1 1
            //Func<int, int> square = Square;
            //Func<int, int> square = number => number * number;
            // Console.WriteLine(square(5));

            // sample 2
            //const int factor = 5;
            //Func<int, int> multiplier = n => n * factor;
            //var result = multiplier(10);
            //Console.WriteLine(result);

            // sample 3

            var books = new BookRepository().GetBooks();

            //foreach (var book in books)
            //{
            //    Console.WriteLine(book.Title + ", " + book.Price);
            //}

            // sample 4
            //var cheepBooks = books.FindAll(IsCheeperEqualThan10Dollars);

            // now with Lambda
            var cheepBooks = books.FindAll(book => book.Price > 10);

            foreach (var book in cheepBooks)
            {
                Console.WriteLine(book.Title);
            }

#if DEBUG
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
#endif
        }

        //static int Square(int number)
        //{
        //    return number * number;
        //}

        // not longer needed when use Lambda
        //static bool IsCheeperThan10Dollars(Book book)
        //{
        //    return book.Price < 10;
        //}
        //static bool IsCheeperEqualThan10Dollars(Book book)
        //{
        //    return book.Price <= 10;
        //}

    }
}
