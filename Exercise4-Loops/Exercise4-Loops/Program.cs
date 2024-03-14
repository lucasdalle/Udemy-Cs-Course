namespace Exercise4_Loops
{
    internal class Program
    {
        public static void ForLoop()
        {
            for(int i=-3; i<=3; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop()
        {
            int i = 3;
            while(i >= -3)
            {
                Console.WriteLine(i--);
            }
        }
        static void Main(string[] args)
        {
            ForLoop();
            WhileLoop();
        }
    }
}