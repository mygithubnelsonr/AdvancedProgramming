using System;
using System.IO;

namespace ExeptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample4.Sample();

#if DEBUG
            Console.WriteLine("press any key to finish");
            Console.ReadKey();
#endif
        }
    }

    class Sample1
    {
        public static void Sample()
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
                Console.WriteLine(result);
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("you can not devide by 0!");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("a Arithmethic exeption occured.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Sample2
    {
        //Beispiel 2: using finaly block
        //for unmanaged objects like: system.IO, Database Connections,
        //Network connections, Graphic Handels
        public static void Sample()
        {
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"C:\Users\erone\Documents\test.json");
                var contend = streamReader.ReadToEnd();
                Console.WriteLine(contend);
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
        }
    }

    class Sample3
    {
        // Beispiel 3: use Using in the try block to dispose an object e.g. filestream
        public static void Sample()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(@"C:\Users\erone\Documents\test.json"))
                {
                    string contend = streamReader.ReadToEnd();
                    Console.WriteLine(contend);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Sample4
    {
        // Beispiel 4: 
        public static void Sample()
        {
            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("Bob");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }

}
