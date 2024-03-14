namespace Exercise1_Methods
{
    internal class Program
    {
        // Place for your methods
        public static string LowUpper(string input)
        {
            return string.Concat(input.ToLower() + input.ToUpper());
        }

        public static void Count(string input)
        {
            Console.WriteLine("The amount of characters is {0}.", input.Length);
        }

        static void Main(string[] args)
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }
    }
}