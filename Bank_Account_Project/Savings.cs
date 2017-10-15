using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Savings : Accounts
    {

        public Savings()
        {
        }

        public Savings(double depositAmount, double withdrawAmount)
        {
            this.depositAmount = depositAmount;
            this.withdrawAmount = withdrawAmount;
        }


        public override string TotalBalance()
        {
            acctType = "Savings";
            return "This " + acctType + " Account has: $" + savingsBalance;
        }
        public override double Deposit()
        {
            return savingsBalance += depositAmount;
        }

        public override double WithdrawWithMinimum()
        {
            double newWithdrawAmount;
            if ((savingsBalance - withdrawAmount) < accountMinBalance)
            {
                do
                {
                    Console.WriteLine("Your account will be below minimum balance of $200.");
                    Console.WriteLine("You can only withdraw up to: $" + (savingsBalance - accountMinBalance) + " at this time.");
                    Console.WriteLine("Enter a new withdraw amount");
                    newWithdrawAmount = double.Parse(Console.ReadLine());
                } while (newWithdrawAmount >= savingsBalance - accountMinBalance);
                return savingsBalance -= newWithdrawAmount;
            }
            else
                return savingsBalance -= withdrawAmount;
        }

    }
}
