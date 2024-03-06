using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ListPractice l1 = new ListPractice();

            int[] x = { 1, 2, 3 };

            l1.addinlist(1);
            l1.addinlist(2);
            l1.addinlist(3);
            l1.printlist();
            l1.addinlist(1);
            l1.addrangeinlisr(x);
            l1.printlist();
            l1.removefromlist(1);

            //--------------------------------------------------------------//
           
            lambdaExpressionPrac lmb1= new lambdaExpressionPrac();
            lmb1.uselambda(7);


            var v1=new  BookRepo().allbooks();
           


            var cheapbooks = v1.FindAll(book => book.price < 100);


            foreach (var book in cheapbooks)
            {
                Console.WriteLine(book.id);
            }

          //--------------------------------------------------------------//
            int xxx = 20;

            OutandRef a=new OutandRef();
            a.addition1(ref xxx);
            Console.WriteLine(xxx);
            a.addition2(out xxx);
            Console.WriteLine(xxx);



        }
    }
}
