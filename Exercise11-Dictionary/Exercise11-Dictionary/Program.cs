using System.Collections.Generic;

namespace Exercise11_Dictionary
{
    internal class Program
    {
        public static string Convert(int i)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>() {
                {0, "zero"},
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" }
            };

            string number = "";
            if (numbers.TryGetValue(i, out number))
            {
                return number;
            }
            return "nope";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Convert(0));
            Console.WriteLine(Convert(1));
            Console.WriteLine(Convert(2));
            Console.WriteLine(Convert(3));
            Console.WriteLine(Convert(4));
            Console.WriteLine(Convert(5));
            Console.WriteLine(Convert(6));

        }
    }
}