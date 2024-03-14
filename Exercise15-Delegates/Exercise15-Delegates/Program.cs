using System.Numerics;

namespace Exercise15_Delegates
{
    internal class Program
    {
        public delegate float OperationDelegate(float num1, float num2);
        
        static void Main(string[] args)
        {
            Console.WriteLine(ApplyOperation(1,2, Add));
            Console.WriteLine(ApplyOperation(1,2, Subtract));
            Console.WriteLine(ApplyOperation(1,2, Multiply));
            Console.WriteLine(ApplyOperation(1,2, Divide));
        }

        public static float ApplyOperation(float num1, float num2, OperationDelegate op)
        {
            return op(num1, num2);
        }

        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
