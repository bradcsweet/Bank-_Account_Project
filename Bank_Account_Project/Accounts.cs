
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    abstract class Accounts
    {
        
        protected string acctType;
        protected static double checkingBalance = 567.45;
        protected static double savingsBalance = 1243.22;
        protected static double totalBalance;
        protected double depositAmount;
        protected double withdrawAmount;
        protected int accountMinBalance = 200;
        
        public double DepositAmount
        {
            get { return this.depositAmount; }
            set { this.depositAmount = value; }
        }
        
        public double WithdrawAmount
        {
            get { return this.withdrawAmount; }
            set { this.withdrawAmount = value; }
        }       



        public Accounts()
        {

        }

        

        //Methods

        public virtual string TotalBalance()
        {
           return "This " + acctType + " Account has: $" + totalBalance;
        }

        public virtual double Deposit()
        {
            return totalBalance += depositAmount;
        }

        public virtual void Withdraw()
        {
            do
            {
                if ((totalBalance - withdrawAmount) >= accountMinBalance)
                {
                    totalBalance -= withdrawAmount;
                }
                else
                {
                    Console.WriteLine("Your account will be below minimum balance.");
                    Console.WriteLine("You can withdraw up to: $" + (totalBalance - accountMinBalance) + " at this time.");
                    Console.WriteLine("Please enter a new withdrawal ammount.");
                }
            } while (totalBalance < accountMinBalance);
        }


    }
}
