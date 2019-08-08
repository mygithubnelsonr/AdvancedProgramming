using System;

namespace Generics
{
    // a generic list solve this problem
    // generic lists have a parameter T means Template or Type
    public class GenericList<T>
    {
        public void Add(T value)
        {
            Console.WriteLine($"{value} was added to the GenericList.");
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
