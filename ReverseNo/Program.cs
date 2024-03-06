namespace ReverseNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pritreverse(789);

            reveresnumberstring(789);

            reveresstring("Nikhil");
           
            printoccurnce("ENGINEERING");


            printpattern(27);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            printpattern2(30);






        }


        public static void pritreverse(int n)
        {
            int a;
            int rev=0;
            while (n > 0) 
            {
                a = n % 10;
                rev = rev * 10 + a;
                n = n / 10;

            }

            Console.WriteLine("reverse="+rev);

        }

      public static void reveresnumberstring(int n) 
        {
            string reve = "";
            string s = Convert.ToString(n);
            foreach (char c in s)
            { 
               reve = c+reve;
            }
            Console.WriteLine("reverse="+reve);
        }

        public static void reveresstring(string s) 
        {
            char [] s1 = s.ToCharArray();
            String rev = "";
            foreach (char c in s1) 
            {
               rev= c+rev;
            }

            Console.WriteLine("reverse="+rev);

        }

        public static void printoccurnce(string s) 
        {
           int l= s.Length;
            int count = 1;
           
            char[] s1 = s.ToCharArray();
              Array.Sort(s1);

            for(int i = 0; i < l; i++)
            {
                if ( i<l-1 && s1[i] == s1[i+1])
                {
                    count++;
                }
                else 
                {
                    Console.WriteLine("Character cont of    " + s1[i] +"     is      "+count);
                    count = 1;
                }

                
            }
           
        }

        public static void printpattern(int n)
        { 
           
            for(int i=1; i<=n; i++)
            {
                  
                if( i%10 == 1 || i%10==2 || i%10==3 || i%10==4 || i%10==5 )
                    Console.Write( i + "    ");
                else
                    Console.Write( "*    ");

                if (i % 10 == 0) Console.WriteLine();


            }

        }

        public static void printpattern2(int n)
        {
            int x = 2;
            for(int i=1; i<=n;i++)
            {
                for (int j=1; j<=i; j++)
                {
                    Console.Write(x);
                   
                    
                }
                Console.WriteLine();
                x = x + 2;
            }

            
        }
        
    }
}
