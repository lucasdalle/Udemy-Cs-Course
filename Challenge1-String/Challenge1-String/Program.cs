using System.Net.Http.Headers;

namespace Challenge1_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Please enter your name and press enter");
            name = Console.ReadLine();

            if (name == null)
                return;

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Trim());
            Console.WriteLine(name.Substring(3));
        }
    }
}