using System;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            // obj is an string but the type can't be resolved e.g. from Watch
            //object obj = "Mosh";
            //var h = obj.GetHashCode();

            // reflection is a way to inspect the metadata about a type
            // and access it's methods and properties
            // this example returns a methodeinfo object
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            // and call some methos and pass parameter
            //methodInfo.Invoke(null, null);
            //Console.WriteLine(methodInfo);

            //Console.WriteLine(new String('-', 40));

            //object excelObject = "Mosh";
            //excelObject.Optimize(); // this shows an error in design time .. does not contain a definition for 'Optimize'

            //but not with dynamic. this throws an exeption on runtime then
            //dynamic excelObject = "Mosh";
            //excelObject.Optimize();

            // assign a string to the variable name and then a integer
            //dynamic name = "Mosh";
            // name = 10; the type of name change from string to integer
            //name++;     // Operator kann nicht auf einen Operanden vom Typ "string" angewendet werden.'

            // var becomes a dynamic variable
            //dynamic a = 10;
            //dynamic b = 5;
            //var c = a + b;

            int i = 5;
            dynamic d = i;
            long l = d;




#if DEBUG
            Console.WriteLine("press any key to finish");
            Console.ReadKey();
#endif
        }
    }
}
