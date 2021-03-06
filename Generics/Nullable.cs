﻿using System;

namespace Generics
{
    //  where is a constraint witch is a limit or restriction
    //  (Grenze , Einschränkung)
    //
    //public class Nullable<T> where T : struct
    public class Nullable<T> where T : IComparable
    {
        private Object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}
