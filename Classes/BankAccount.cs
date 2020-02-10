using System;
using System.Collections.Generic;

namespace Classes
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance {
            get 
            {
                decimal balance = 0;
                foreach (var transaction in allTransactions)
                {
                    balance +- transaction.Amount;
                }

                return balance;
            }
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
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