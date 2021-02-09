using System;
using System.Collections.Generic;
using System.Text;

namespace MicroProject
{
    //This is a base class
    class Bank
    {
        public string Owner { get; set; }
        public string AccNumber { get; }

        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach(var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }

        }
        public static int accountNumberSeed = 1234567890;
        public static int totalBankAccounts = 0;
        private readonly decimal minimumBalance;

        public Bank(string name, decimal initialBalance) : this(name, initialBalance, 0) { }
        public Bank(string name, decimal initialBalance, decimal minimumBalance)
        {
            this.Owner = name;
            this.AccNumber = accountNumberSeed.ToString();
            this.minimumBalance = minimumBalance;
            accountNumberSeed++;
            totalBankAccounts++;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            
        }


        private List<Transaction> allTransactions = new List<Transaction>();
        public void MakeDeposit(decimal amount, DateTime date, string Note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount should be greater than zero");
            }
            Transaction deposit = new Transaction(amount, date, Note);
            allTransactions.Add(deposit);
        }

        // MakeWithdrawal and MakeDeposit cannot come under static method, because, it can to be done only on one object at a time.
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            var overdraftTransaction = CheckWithdrawalLimit(Balance - amount < minimumBalance);
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }
        // static method means, a method which is related to all the objects. 
        // It can be called without creating an object
        // example: className.methodname() ---------- (Bank.GetNoOfAccounts());
        public static int GetNoOfAccounts()
        {
            return totalBankAccounts;
        }

        // Writing the virtual method, we can override this method in other classes if we want
        public virtual void PerformEndOfMonthTransaction() 
        {
            Console.WriteLine("I'm in base class");
        }

        

    }
   
}
