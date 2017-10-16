
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    abstract class Accounts
    {
        //A few hardcoded values for balances and savings account minimum balance requirement
        protected string acctType;
        protected static double totalBalance;
        protected double depositAmount;
        protected double withdrawAmount;
        protected int accountMinBalance = 200;

        //properties
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
        
        //default constructor
        public Accounts()
        {
        }

        //Base Methods used in child classes and one abstract
        public abstract void ClientInfo();

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
            return totalBalance -= withdrawAmount;
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
                    Console.WriteLine("Enter a new withdraw amount\n");
                    newWithdrawAmount = double.Parse(Console.ReadLine());
                } while (newWithdrawAmount >= totalBalance - accountMinBalance);
                return totalBalance -= newWithdrawAmount;
            }
            else
                return totalBalance -= withdrawAmount;
        }
    }
}
