using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Nick Davies", 2500);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} opening balance.");
        }
    }
}
