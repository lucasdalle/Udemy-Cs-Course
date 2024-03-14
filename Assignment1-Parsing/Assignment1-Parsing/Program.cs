namespace Assignment1_Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int
            
            float num1 = float.Parse(stringForFloat);
            int num2 = int.Parse(stringForInt);

            Console.WriteLine("float value: {0}\nint value: {1}", num1, num2);
        }
    }
}