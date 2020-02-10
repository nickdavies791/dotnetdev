using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new account
            var account = new BankAccount("Nick Davies", 2500);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} opening balance.");

            // Make a withdrawal
            account.MakeWithdrawal(500, DateTime.Now, "Rent Payment");
            Console.WriteLine($"Balance: {account.Balance}");

            // Make a deposit
            account.MakeDeposit(2000, DateTime.Now, "Salary");
            Console.WriteLine($"Balance: {account.Balance}");
        }
    }
}
