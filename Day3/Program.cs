using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emplyoyees = new List<Employee>()
            {
                new Employee(){id=111,name="john"},
                new Employee(){id=112,name="kurt"},
                new Employee(){id=113,name="joe"},
                new Employee(){id=114,name="mike"},
                new Employee(){id=115,name="santno"},
                new Employee(){id=116,name="rick"}

            };

            IEnumerable<Employee> IEMEMP = emplyoyees;
            foreach (Employee emp in IEMEMP)
            {
                Console.WriteLine(emp.id + "     " + emp.name);
            }

            IEnumerator<Employee> enumerator = emplyoyees.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.id + "     " + enumerator.Current.name);
            }


            //------------------------------------------------------------------------------------------------//

            FrontendDevloper e1 = new FrontendDevloper();
            e1.id = 111;
            e1.name = "sff";
            e1.sallary = 1123;

            List<BackEndDevloper> bd1 = new List<BackEndDevloper>()
           {
               new BackEndDevloper(){id=112233,name="djcnsj",sallary=22000}
           };


            //------------------------------------------------------------------------------------------------//

            Task.Run(() => dowork());
            Console.WriteLine("Hello from main method");

            Thread t1 = new Thread(dowork); 
            t1.Start();


            //------------------------------------------------------------------------------------------------//


            AsyncAwaitPractice a1 =new AsyncAwaitPractice();
            a1.method();
            Console.WriteLine("In main method");


            //------------------------------------------------------------------------------------------------//

            //--------------------------------------LINQ PRACTICE--------------------------------------------//


            var sortedEMP = emplyoyees.Where(e => e.id == 112);
            var sortedEMP2 = emplyoyees.Where(e => e.id > 112).OrderBy(e => e.name);

            foreach(Employee emp in sortedEMP)
                Console.WriteLine(emp.id+"    "+emp.name);


            Console.WriteLine("-------------//-------------------------------");


            foreach (Employee emp in sortedEMP2)
                Console.WriteLine(emp.id + "    " + emp.name);

            //--------------------------------------STOPWATCH PRCTICE--------------------------------------------//

            //MySopwatch m1 = new MySopwatch();
            //m1.printtime();



            //--------------------------------------VAR AND DYNAMIC PRACTICE--------------------------------------------//
            var s1 = 1;
            dynamic s2 = "123";

            s2 = s1+s2;
            Console.WriteLine(s2);

            //----------------------------------------BALANCED PARANTHISIS--------------------------------------------//


            BalanceParenthisis b1= new BalanceParenthisis();
            b1.checkBalancParnthisis("{{{}})}");







        }

        static void dowork()
        { Console.WriteLine("Hello from doWork"); }
    }
}
