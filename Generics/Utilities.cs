using System;

namespace Generics
{
    public class Utilities
    {

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //// this forces an Error CS0019
        //// Operator '>' cannot be applied to operands of type 'T' and 'T'
        //public T Max<T>(T a, T b)
        //{
        //    return a > b ? a : b;
        //}

        //  where is a constraint witch is a limit or restriction
        //  (Grenze , Einschränkung)
        //
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    // we can also use the where clause on the class itselfe
    // kind of constraints
    // where T : IComparable
    // where T : Product (class)
    // where T : struct
    // where T : class 
    // where T : new() (have a ctor)
    //public class Utilities<T> where T : IComparable
    public class Utilities<T> where T : IComparable, new()
    {
        // we added the constraint new() to can use new T()
        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
