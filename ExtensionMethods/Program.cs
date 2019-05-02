using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // string von https://de.lipsum.com/
            string post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit Etiam lacus.";
            var shortedPost = post.Shorten(0);

            Console.WriteLine(shortedPost + " ...");

#if DEBUG
            Console.WriteLine("press any key to finish");
            Console.ReadKey();
#endif


        }
    }
}
