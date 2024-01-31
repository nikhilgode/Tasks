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




           


        }
    }
}
