using System.Globalization;

namespace Challenge3_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte var1 = 1;
            sbyte var2 = 2;
            int var3 = 3;
            uint var4 = 4;
            short var5 = 5;
            long var6 = 6;
            ulong var7 = 7;
            float var8 = 8.7f;
            double var9 = 9.15;
            char var10 = 'a';
            bool var11 = true;
            string var12 = "string";
            decimal var13 = 13.28M;

            string controlString = "I control text";
            string numberString = "28";
            int numberFromString = int.Parse(numberString);
        }
    }
}