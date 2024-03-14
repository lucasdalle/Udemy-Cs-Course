namespace Exercise14_MathClass
{
    internal class Program
    {
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line)
        {
            int angle;
            double angleInRadians;

            if(!int.TryParse(line, out angle) || angle < 0 || angle > 180)
            {
                Console.WriteLine("Check the input!");
                return;
            }

            angleInRadians = ConvertToRadians(angle);

            Console.WriteLine($"Cos = {Math.Cos(angleInRadians)}");
            Console.WriteLine($"Sin = {Math.Sin(angleInRadians)}");
            Console.WriteLine($"Tg = {Math.Tan(angleInRadians)}");
        }

        static void Main(string[] args)
        {
            Run("30");
            Run("45");
            Run("60");
            Run("181");
            Run("-30");
            Run("a");
        }
    }
}
