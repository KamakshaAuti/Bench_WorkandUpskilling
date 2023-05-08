using System;
using System.Linq;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Red Green WHITE";
            Console.WriteLine("Original String: " + text);
            Console.WriteLine("Number of duplicate characters in the said string: " + test(text));
            text = "ppqrrsttuuu";
            Console.WriteLine("Original String: " + text);
            Console.WriteLine("Number of duplicate characters in the said string: " + test(text));
            text = "dow jones industrial average";
            Console.WriteLine("Original String: " + text);
            Console.WriteLine("Number of duplicate characters in the said string: " + test(text));
        }

        public static int test(string text)
        {
            return text.GroupBy(n => n).Count(n => n.Count() >= 2);
        }
    }
}