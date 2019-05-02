﻿using System;

namespace Generics
{
    //  where is a constraint witch is a limit or restriction
    //  (Grenze , Einschränkung)
    //
    // where T : IComparable
    // where T : Product (class)
    // where T : struct
    // where T : class 
    // where T : new() (have a ctor)
    public class Utilities<T> where T : IComparable, new()
    {
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
