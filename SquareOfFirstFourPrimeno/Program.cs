namespace SquareOfFirstFourPrimeno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int c = 0;
            int x = 2;

            Console.WriteLine("enter numbers upto you want");
              string y=Console.ReadLine();
            int yy= int.Parse(y);


            while (c <yy )
            {
                if (isprime(x))
                {
                    int k = x;
                    Console.WriteLine(k * k);
                    c++;
                    
                }
                x++;
            }


            Console.WriteLine(isprime(22));
        }

       public static bool isprime(int n) 
        {
           bool f = true; 

            if(n==2)
            {
              return f;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                   f= false;
                    break;
                }
              
            }

            return f;                                
        }
    }
}
