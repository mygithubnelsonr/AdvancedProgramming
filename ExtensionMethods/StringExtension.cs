using System.Linq;

namespace System
{
    public static class StringExtension
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            try
            {
                if (numberOfWords <= 0)
                    throw new ArgumentOutOfRangeException("number of words must be greater than 0 !");

                if (numberOfWords == 0)
                    return String.Empty;

                var words = str.Split(' ');

                if (words.Length < numberOfWords)
                    return str;

                return String.Join(" ", words.Take(numberOfWords));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return String.Empty;
            }
        }
    }
}
