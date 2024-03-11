namespace HorizontalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printpattrn(5);
        }


        public static void printpattrn(int n)
        {
            int x = 1;
            while (x <= n)
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("*");
                        Console.WriteLine();
                        continue;
                    }
                    else if (i % 2 == 0)
                    {
                        for (int j = 1; j <= i; j++)
                        {

                            Console.Write(" ");

                        }
                        Console.Write("*");
                        Console.WriteLine();
                    }


                }

                for (int i = 3; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        Console.Write("*");
                    }
                    else if (i % 2 == 0)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                        Console.WriteLine();
                    }


                }
                Console.WriteLine();
                x++;

            }

        }
    }
}
