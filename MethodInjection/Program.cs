namespace MethodInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account sa = new Account();
            sa.printdetails(new SavingAccount());
        }


        public interface IAccount
        {
            public void printdetails();
        }

        public class CurrentAccount : IAccount
        {
            public void printdetails()
            {
                Console.WriteLine("Hello from CurrntAccount");
            }
        }


        public class SavingAccount : IAccount
        {
            public void printdetails()
            {
                Console.WriteLine("Hello from SavingAccount");
            }
        }

        class Account 
        { 
            public void printdetails(IAccount account) 
            {
              account.printdetails();
            }

        }



    }
}
