namespace Exercise2_If
{
    internal class Program
    {
        public static void Check(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
        static void Main(string[] args)
        {
            Check(0);
            Check(1);
            Check(2);
            Check(3);
            Check(4);
        }
    }
}