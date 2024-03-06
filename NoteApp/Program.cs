namespace NoteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            numberofnotes(7770);

            

        }


       static public void numberofnotes(int x) 
        {
            int n2000 = 0, n500 = 0, n200 = 0, n100 = 0, n50 = 0, n10 = 0;

           while(x>0)
            {
                if(x >= 2000)
                { 

                   //onsole.WriteLine("2000=1");
                    n2000++;
                    x = x - 2000;  

                }
                else if (x>=500 )
                {
                   //onsole.WriteLine("500=1");
                    n500++;
                    x = x - 500;

                }

                else if (x >= 200 )
                {
                   //onsole.WriteLine("200=1");
                    n200++;
                    x = x - 200;

                }
                else if (x >= 100 )
                {
                  //Console.WriteLine("100=1");
                    n100++;
                    x = x - 100;

                }
                else if (x >= 50 )
                {
                  //Console.WriteLine("50=1");
                    n50++;
                    x = x - 50;

                }
                else if (x >=10 )
                {
                   //onsole.WriteLine("10=1");
                    n10++;
                    x = x - 10;

                }
            }

            Console.WriteLine("2000RS Notes= " + n2000);
            Console.WriteLine("500RS Notes= " + n500);
            Console.WriteLine("0RS Notes= " + n2000);
            Console.WriteLine("2000RS Notes= " + n2000);
        }
    }
}
