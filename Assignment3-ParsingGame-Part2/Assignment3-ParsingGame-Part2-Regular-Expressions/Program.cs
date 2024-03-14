using System.IO;
using System.Text.RegularExpressions;

namespace Assignment3_ParsingGame_Part2_Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\lucas\source\repos\C#_Udemy_Course\Assignment3-ParsingGame-Part2\input2.txt";
            string fileText = File.ReadAllText(filePath);
            string pattern = @"\d{2,3}";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(fileText);
            foreach (Match match in matches)
            {
                GroupCollection group = match.Groups;
                char chararacter = (char)int.Parse(group[0].Value);
                Console.Write(chararacter + " ");
            }
        }
    }
}
