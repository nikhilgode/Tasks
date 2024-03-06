using static Day_4.EnumPractice;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var adress1 = new Adress();
            adress1.Name = "A";
            adress1.City = "Mumbai";

            adress1.printname();
            adress1.Printaddress();


            var person1 = new Person();
            person1.Name = "B";

            person1.printname();

            //---------------------------------------------------------------------------------------//


            var a1 = enumpractice111.prac1;


            Console.WriteLine((int)a1);



            //---------------------------------------OVERRIDING---------------------------------------//

            Console.WriteLine("----------OVERRIDING------------");
            MethodOverriding m1 = new MethodOverriding();
            m1.methodovrid();

            Overidingclass o1 = new Overidingclass();
            o1.methodovrid();

            //-------------------------------------Abstract Classs and method--------------------------------//


            AbstracExtendedd ab1=new AbstracExtendedd();
            ab1.implementabstract();
            ab1.print();


            


            //------------------------------------------------------------------------------------------------//


            StaticPractice.statpractice();

            //-------------------------------INTERFACE PROBLEMS--------------------------------------------//

            AudioError aa1=new AudioError();
            aa1.printerrormessage1("Audio Error 1...!");
            aa1.printerrormessage2("Audio Error 2...!");

            VideoError vv1 = new VideoError();
            vv1.printerrormessage1("Video Error 1...!");
            vv1.printerrormessage2("video Error 2...!");

            TvError tv1 = new TvError();
            tv1.printerrormessage2("675577");
            tv1.printerrormessage1("7556657");

            // tv1.printerrormessage1("555444");

            //----------------------------------------AsyncAwait--------------------------------------------------------//



            AsyncAwait.Method();









        }
    }
}
