using System;

namespace Generics
{
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            Console.WriteLine($"TKey={key}, TValue={value} added to the GenericDictionary");
        }
    }
}
