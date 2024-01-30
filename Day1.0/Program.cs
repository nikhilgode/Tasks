using System.ComponentModel.DataAnnotations;

namespace Day1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c= new ConstructorDemo();
            c.a = 1;
            c.b = 2;
            c.printvalues(c.a,c.b);


            var d=new ConstructorDemo();
            d.a = 2;
            d.b = 3;
            d.c = "hello world";
            d.printvalues(d.a,d.b,d.c);



            var shape1 = new triangl();
            shape1.drawshape();

            var shape2 = new circle();
            shape2.drawshape();
           
            var sb1=new strinbuilderPractice();
            sb1.useStingBuilder();


            var sb2=new strinbuilderPractice();
            sb2.useStingBuilder();


            var stack =new StackImplementtion();
            stack.push(1);
            stack.push("C++");
            stack.push(sb2.useStingBuilder );
            stack.showstack();
            stack.pop();
            stack.showstack();


            var d1 = new DateTime();
            Console.WriteLine(d1);
            var d2= new DateTime(2015,1,1);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
        }
    }


}
