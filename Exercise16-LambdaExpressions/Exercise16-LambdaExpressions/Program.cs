namespace Exercise16_LambdaExpressions
{
    internal class Program
    {
        public static Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>
        {
            { "+", (num1, num2) => num1 + num2 },
            { "-", (num1, num2) => num1 - num2 },
            { "/", (num1, num2) => num1 / num2 },
            { "*", (num1, num2) => num1 * num2 }
        };

        public static Func<float, float, float> OperationGet(string operation)
        {
            if(Operators.ContainsKey(operation))
            {
                return Operators[operation];
            }
            else 
                return null;
        }

        static void Main(string[] args)
        {

        }
    }
}
