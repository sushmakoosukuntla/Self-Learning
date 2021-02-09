using System;
using System.Collections.Generic;
using System.Text;

namespace MicroProject
{
    class InterestEarningAccount : Bank
    {
        public InterestEarningAccount(String name, decimal initialBalance) : base(name, initialBalance)
        {
            Console.WriteLine("I'm in interest earning account");
        }
        public override void PerformEndOfMonthTransaction()
        {
            //base.PerformEndOfMonthTransaction();
            if (Balance > 500m)
            {
                var interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "deposited monthly interest");
                
            }
        }

    }
}