namespace Exercise10_Lists
{
    internal class Program
    {
        public static List<int> Solution()
        {
            List<int> list = new List<int>();
            for(int i = 100; i <= 170; i++)
            {
                if(i % 2 == 0)
                    list.Add(i);
            }

            return list;
        }
        static void Main(string[] args)
        {
            List<int> list = Solution();
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}