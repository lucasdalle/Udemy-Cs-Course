namespace Exercise3_Nested_If
{
    internal class Program
    {
        public static void NestedCheck(int number)
        {
            if (number % 3 == 0)
                Console.WriteLine("Divisible by 3.");
            else if (number % 7 == 0)
                Console.WriteLine("Divisible by 7.");
            else
            {
                if (number % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
        }

        static void Main(string[] args)
        {
            NestedCheck(1);
            NestedCheck(2);
            NestedCheck(3);
            NestedCheck(4);
            NestedCheck(5);
            NestedCheck(6);
            NestedCheck(7);
        }
    }
}