using System.Diagnostics.Metrics;
using System.IO;

namespace Assignment2_ParsingGame_Part1__Read_from_and_Write_into_File_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"C:\Users\lucas\source\repos\C#_Udemy_Course\Assignment2-ParsingGame-Part1\input.txt";
            string outputFilePath = @"C:\Users\lucas\source\repos\C#_Udemy_Course\Assignment2-ParsingGame-Part1\output.txt";

            foreach (string line in File.ReadLines(inputFilePath))
            {
                if (!line.Contains("split"))
                    continue;

                string[] splittedLine = line.Split(' ');
                File.AppendAllText(outputFilePath, splittedLine[4] + " ");
            }
        }
    }
}
