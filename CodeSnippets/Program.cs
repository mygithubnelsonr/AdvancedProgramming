using System;
using System.Collections.Generic;

namespace CodeSnippets
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    // mit ctrl-shift + F12 jump to next error

    public class CodeSnippets
    {
        // eingabe pro + Tab Tab (property)
        public int MyProperty { get; set; }
        // dann Type und Name ändern
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // propfull + Tab Tab   (property full)
        private int myVar;
        public int MyProperty2
        {
            get { return myVar; }
            set { myVar = value; }
        }
        // dann Type und Name ändern
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        // ct + tab tab   (ctor)
        //      public CodeSnippets()
        //      {
        //
        //      }

        public CodeSnippets()
        {
            // cw
            Console.WriteLine();

            // tr  (try block)
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            // tryf (try finaly block)
            try
            {

            }
            finally
            {

            }

            // fo   (for block increment)
            for (int i = 0; i < 10; i++)
            {

            }

            // forr (for block decrement)
            for (int i = 10 - 1; i >= 0; i--)
            {

            }

            var names = new List<string>();
            // fore (foreach block
            foreach (var name in names)
            {

            }

            // w    (while)
            while (true)
            {

            }

            // do   (do loop)
            do
            {

            } while (true);

        }

        // inter    (interface)
        interface IInterface
        {

        }

        // eq   (equals)
        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}
