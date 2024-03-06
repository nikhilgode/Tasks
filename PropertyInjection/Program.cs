namespace PropertyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account sa = new Account();
            
            sa.account = new SavingAccount();

            sa.printdetails();

            
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
            
            public IAccount account { get; set; }

            public void printdetails()
            {
                account.printdetails();
            }

        }
    }
}
