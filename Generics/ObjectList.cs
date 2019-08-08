using System;

namespace Generics
{
    // we can use a list of objects to store any type
    // but there is a performance problem
    // e.g. integer has to be boxed to change to an object
    // and vice versa
    public class ObjectList
    {
        public void Add(Object value)
        {
            throw new NotImplementedException();
        }

        public Object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
