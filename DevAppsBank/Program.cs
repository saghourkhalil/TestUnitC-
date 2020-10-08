using System;

namespace DevAppsBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dataService = new DataServices();
            var accountKhalil = new BankAccount("Khalil", 1200);
            //var accountSaghour = new BankAccount("Saghour", 1200);

            accountKhalil.Credit(200);
            //accountSaghour.Debit(200);

            Console.WriteLine($"Khalil = {accountKhalil.Balance}");
            //Console.WriteLine($"Saghour = {accountSaghour.Balance}");        }
        }
    }
}
