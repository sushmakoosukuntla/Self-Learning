using System;
using System.Collections.Generic;
using System.Text;

namespace MicroProject
{
    class LineOfCreditAccount : Bank
    {
        
        public LineOfCreditAccount(String name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        {
        }
        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
        
            

            isOverdrawn
            ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
            : default;

        
   
        public override void PerformEndOfMonthTransaction()
        {
            //base.PerformEndOfMonthTransaction();  
            if(Balance < 0m)
            {
                // Negate the balance to get a positive interest charge:
                var interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "withdrawing the interest amount");
            }
        }

    }
}
