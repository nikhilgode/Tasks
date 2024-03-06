using static Day5.ValRefType;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-------------------------------------------------------------------------------------------------//


            var n = 10;
            ValRefType.increment(n);
            Console.WriteLine(n);
            Console.WriteLine(ValRefType.increment(n));

            //------------------------------------------------------------------------------------------------//



            Func<int, int> f1 = f => f * f;
            Console.WriteLine(f1(4));

            Func<int,int,int,int> f2= (a,b,c)=> a*b*c;
            Console.WriteLine(f2(3,4,5));


            Func<String, int, int, string> f3 = (a, b, c) => a + b + c;
            Console.WriteLine(f3("Nikhil      ",26,09));



            //--------------------------------------------------------------------------------------------------------------//

            ValRefType v1=new ValRefType();

            var a = ss1.a;
            


            //-------------------------------------------------------------------------------------------//
            int x = 10;

            Console.WriteLine(" OUT REFFF DEMO");
            OutRff.printno(ref x);
            Console.WriteLine(x);

            OutRff.printno2(out x);
            Console.WriteLine(x);


            //-----------------------------------------------------------------------------------------//

               List <int> l1=new List<int>() { 1,2,3,4,5};

            IEnumerable<int> il1=(IEnumerable<int>)l1;

            foreach(var i  in il1)
            {

                Console.WriteLine(i);
            }

            Jeet j1 = new Jeet();
            j1.print();
            


        }
    }
}
