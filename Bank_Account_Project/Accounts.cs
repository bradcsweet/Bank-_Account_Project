
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

        public virtual double Withdraw()
        {
            return checkingBalance -= withdrawAmount;
        }

        public virtual double WithdrawWithMinimum()
        {
            double newWithdrawAmount;
            if ((totalBalance - withdrawAmount) < accountMinBalance)
            {
                do
                {
                    Console.WriteLine("Your account will be below minimum balance of $200.");
                    Console.WriteLine("You can only withdraw up to: $" + (totalBalance - accountMinBalance) + " at this time.");
                    Console.WriteLine("Enter a new withdraw amount");
                    newWithdrawAmount = double.Parse(Console.ReadLine());
                } while (newWithdrawAmount >= totalBalance - accountMinBalance);
                return totalBalance -= newWithdrawAmount;
            }
            else
                return totalBalance -= withdrawAmount;
        }
    }
}
