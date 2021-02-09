using System;
using System.Collections.Generic;
using System.Text;

namespace MicroProject
{
    class GiftCardAccount : Bank
    {
        private decimal _monthlyDeposit = 0m;
        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
        {
            this._monthlyDeposit = monthlyDeposit;
        }
        public override void PerformEndOfMonthTransaction()
        {
            //base.PerformEndOfMonthTransaction();
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "depositing gift card amount for further expenses");
            }
        }
    }
}
