using System;

namespace Generics
{
    // the book List can only used to save book objects!
    // nothing else
    public class BookList
    {
        public void Add(Book book)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"Book {book.ISBN} was added to the booklist.");
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
