using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new account
            // var account = new BankAccount("Nick Davies", 2500);
            // Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} opening balance.");

            try
            {
                var invalidAccount = new BankAccount("invalid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance.");
                Console.WriteLine(e.ToString());
            }

            // Make a withdrawal
            // account.MakeWithdrawal(500, DateTime.Now, "Rent Payment");
            // Console.WriteLine($"Balance: {account.Balance}");

            // Make a deposit
            // account.MakeDeposit(2000, DateTime.Now, "Salary");
            // Console.WriteLine($"Balance: {account.Balance}");

            // Try to make a withdrawal over the available balance
            // account.MakeWithdrawal(7500, DateTime.Now, "Fraud");
            // Console.WriteLine($"Balance: {account.Balance}");

        }
    }
}
