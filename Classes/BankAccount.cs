using System;

namespace Classes
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            //
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            //
        }
    }
}