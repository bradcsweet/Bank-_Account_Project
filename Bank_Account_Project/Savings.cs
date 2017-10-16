using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Savings : Client
    {
        //constructors
        public Savings()
        {
        }

        public Savings(double depositAmount, double withdrawAmount)
        {
            this.depositAmount = depositAmount;
            this.withdrawAmount = withdrawAmount;
        }

        //menuchoice 2
        public override string TotalBalance()
        {
            acctType = "Savings";
            return "\nThis " + acctType + " Account has: $" + savingsBalance;
        }

        //menuchoice 3
        public override double Deposit()
        {
            return savingsBalance += depositAmount;
        }

        //menuchoice 4
        public override double WithdrawWithMinimum()
        {
            double newWithdrawAmount;
            if ((savingsBalance - withdrawAmount) < accountMinBalance)
            {
                do
                {
                    Console.WriteLine("\nYour account will be below minimum balance of $200.");
                    Console.WriteLine("You can only withdraw up to: $" + (savingsBalance - accountMinBalance) + " at this time.");
                    Console.WriteLine("Enter a new withdraw amount\n");
                    newWithdrawAmount = double.Parse(Console.ReadLine());
                } while (newWithdrawAmount >= savingsBalance - accountMinBalance);
                return savingsBalance -= newWithdrawAmount;
            }
            else
                return savingsBalance -= withdrawAmount;
        }

    }
}
