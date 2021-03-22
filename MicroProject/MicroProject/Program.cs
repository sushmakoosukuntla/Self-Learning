using System;

namespace MicroProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"No. of accounts = {Bank.GetNoOfAccounts()}");
            Bank s = new Bank("sushma", 1000);
            s.MakeDeposit(1000, DateTime.Now, "Gift from Dad");
            Console.WriteLine($"Total balance of s is {s.Balance}");
            Console.WriteLine($"Bank Account number of s is {s.AccNumber}");
            s.MakeDeposit(300000, DateTime.Now, "gift from mom");
            s.MakeWithdrawal(100000, DateTime.Now, "Gift to Rudransh");
            Console.WriteLine($"No. of accounts = {Bank.GetNoOfAccounts()}");


            //*********************OVER DRAW AND ZERO DEPOSITING EXCEPTION TEST**************
            try
            {
                s.MakeWithdrawal(-1, DateTime.Now, "overdraw exception");

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("caught due to overdraw");
                Console.WriteLine(e.ToString());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Entered the negative");
                Console.WriteLine(e.ToString());
            }
            try
            {
                s.MakeDeposit(0, DateTime.Now, "Depositing zero exception");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Amount should be more than Zero");
                Console.WriteLine(e.ToString());
            }


            //**********CREATING 10 BANKS ARRAY******************
            Bank[] banks = new Bank[11];
            for (int i = 0; i < banks.Length; i++)
            {
                banks[i] = new Bank("sushma" + i, 10000 + i);
                Console.WriteLine($"Account name is {banks[i].Owner} and account number is {banks[i].AccNumber} and the initial balance is {banks[i].Balance}");
            }

            //************************NEW GIFT CARD ACCOUNT ******************************
            // Below is creating object using polymorphism. (creating derived class object in reference to parent class(base class))
            Bank g = new GiftCardAccount("Sushma", 500, 100);
            g.MakeDeposit(200, DateTime.Now, "Adding monthly deposit");
            g.MakeWithdrawal(25, DateTime.Now, "For a toy");
            g.PerformEndOfMonthTransaction();
            Console.WriteLine(g.Balance);

            //******************************************
            // Below is creating object with out using polymorphism. 
            //creating object in reference to derived class
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformEndOfMonthTransaction();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.Balance);

            //**************NEW LINEOFCREDIT ACCOUNT***********************

            Bank l = new LineOfCreditAccount("sushma", 0, 2000);
            //l.MakeWithdrawal(5000, DateTime.Now, "Rudransh day care");
            //l.PerformEndOfMonthTransaction();
            //Console.WriteLine(l.Balance);
            l.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            l.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            l.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            l.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            l.PerformEndOfMonthTransaction();
            Console.WriteLine(l.Balance);
            Console.WriteLine($"No. of accounts = {Bank.GetNoOfAccounts()}");


        
    }
    }
}  
