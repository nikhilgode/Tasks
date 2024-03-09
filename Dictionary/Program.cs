namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3, 4, 5, 1, 5, 6, 8, 9, 2, 2, 22 };

            eliminateDuplicates(n);
        }

        public static void eliminateDuplicates(int[] n)
        {
            Dictionary <int , bool> keyValuePairs = new Dictionary<int , bool>();

            foreach (var item in n)
            {
                if(!keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item] = true;
                }
            }

            var s1 = keyValuePairs.Keys.ToList();

            Console.WriteLine("Array after eleminting duplicaates is...!");
            foreach (var item in s1)
            {
                Console.Write("     "+item);
            }
        }

    }
}
