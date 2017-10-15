using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Checking : Accounts
    {
        
        public Checking()
        {
        }

        public Checking(double depositAmount, double withdrawAmount)
        {
            this.depositAmount = depositAmount;
            this.withdrawAmount = withdrawAmount;
        }




        //methods
        public override string TotalBalance()
        {
            acctType = "Checking";
            return "This " + acctType + " Account has: $" + checkingBalance;
        }

        public override double Deposit()
        {
            return checkingBalance += depositAmount;
        }

        public override double Withdraw()
        {
            return checkingBalance -= withdrawAmount;
        }

    }
}
