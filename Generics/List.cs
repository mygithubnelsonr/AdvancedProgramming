using System.Diagnostics;

namespace Generics
{
    // sample of an List class. This List can only used to store Numbers !
    // nothig else.
    class List
    {
        public void Add(int number)
        {
            // throw new NotImplementedException();
            Debug.Print("add to list");
        }

        public int this[int index]
        {
            get { return 0; }

        }
    }
}
