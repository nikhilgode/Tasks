namespace ConstructorInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount ca = new CurrentAccount();
            Account a  = new Account(ca);
            a.printdetails();



            
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


        public class SavingAccount: IAccount
        {
            public void printdetails()
            {
                Console.WriteLine("Hello from SavingAccount");
            }
        }

           class Account
          {
            
            private IAccount account;

            public Account(IAccount account)
            {
                this.account = account;
            }

            public void printdetails()
            {
                account.printdetails();
            }

        }

    }
}
