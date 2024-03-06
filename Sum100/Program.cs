namespace Sum100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 80, 60, 10, 50, 30, 100, 0, 50 };
            sum100(n);
        }

        public static  void sum100(int[] n)
        {
           for (int i = 0; i < n.Length-1; i++)
            {
                for(int j =i+1; j < n.Length; j++)
                {
                    if (n[i] + n[j]==100)
                    Console.WriteLine($"Pair is   {n[i]}   and   {n[j]}");
                }
            }
        }
    }
}
