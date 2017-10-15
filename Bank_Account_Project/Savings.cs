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

        public override void Withdraw()
        {
            do
            {
                if ((savingsBalance - withdrawAmount) >= accountMinBalance)
                {
                    savingsBalance -= withdrawAmount;
                }
                else
                {
                    Console.WriteLine("Your account will be below minimum balance.");
                    Console.WriteLine("You can withdraw up to: $" + (savingsBalance - accountMinBalance) + " at this time.");
                    Console.WriteLine("Please enter a new withdrawal ammount.");
                }
            } while (savingsBalance < accountMinBalance);
        }
    }
}
