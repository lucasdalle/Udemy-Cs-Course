namespace Challenge2_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString, firstName, secondName, fullName;
            char inputCharacter;

            Console.WriteLine("Enter a string here:");
            inputString = Console.ReadLine();
            if (inputString == null) return;

            Console.Write("Enter a character to search: ");
            inputCharacter = Console.ReadLine()[0];
            
            Console.WriteLine(inputString.IndexOf(inputCharacter));

            Console.WriteLine("Enter first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter second name:");
            secondName = Console.ReadLine();

            if(firstName == null || secondName == null) return;
                
            fullName = string.Format($"{firstName} {secondName}");
            Console.WriteLine($"Full name: {fullName}");
        }
    }
}