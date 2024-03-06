namespace PlusPatern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printpattern(15);
        }

        public static void printpattern(int i)
        { 
              for(int j = 0; j <=(i*2); j++)
              {
               
                if(j<i || j>i)
                { 
                 
                      for (int k = 0; k <=i; k++)
                      {
                        if (k < i)
                            Console.Write("  ");
                        else
                        {
                            Console.Write("* ");
                            Console.WriteLine();
                        }
                      }
                }
                else
                {

                    for(int l = 0; l <=(i*2); l++)
                    {
                        Console.Write("* ");
                    }
                }

              }
        }
    }
}
