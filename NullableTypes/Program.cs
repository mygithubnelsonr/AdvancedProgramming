using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beispiel 1: using nullable types");
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("DateTime date = null ->  forces an error");
            Console.WriteLine("define nullable type: Nullable<DateTime> date = null ->  is ok");
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value" + date.Value);     // forces an error'Das Objekt mit Nullwert muss einen Wert haben.'

            date = new DateTime(2014, 1, 1);
            Console.WriteLine("DateTime date2 = date forces an error!\n can not assign a nullable variable to a not nullable variable");
            Console.WriteLine("date2 = date, useing date.GetValueOrDefault() is ok");
            DateTime date2 = date.GetValueOrDefault();
            Console.WriteLine(date2);
            Console.WriteLine("nullable type can easily defined with not nullable type");
            DateTime? date3 = date2;
            Console.WriteLine(date3);
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Beispiel 2: null coalescing operator");

            date = null;
            DateTime date4;

            Console.WriteLine("using standard way with if else");
            Console.WriteLine(@"
if (date != null)
    date4 = date.GetValueOrDefault();
else
    date4 = DateTime.Today;");

            if (date != null)
                date4 = date.GetValueOrDefault();
            else
                date4 = DateTime.Today;

            Console.WriteLine(date4);

            Console.WriteLine("using null coalescing operator ?? ");
            Console.WriteLine("date4 = date ?? DateTime.Today");
            Console.WriteLine("use date if has a value , otherwhise use second value");

            date4 = date ?? DateTime.Today;
            Console.WriteLine(date4);

#if DEBUG
            Console.WriteLine("press any key to finish");
            Console.ReadKey();
#endif
        }
    }
}
