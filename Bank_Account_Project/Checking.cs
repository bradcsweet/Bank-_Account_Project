using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Checking : Client
    {
        //constructors
        public Checking()
        {
        }

        public Checking(double depositAmount, double withdrawAmount)
        {
            this.depositAmount = depositAmount;
            this.withdrawAmount = withdrawAmount;
        }
        
        //methods
        //menuchoice 2
        public override string TotalBalance()
        {
            acctType = "Checking";
            return "\nThis " + acctType + " Account has: $" + checkingBalance;
        }

        //menuchoice 3
        public override double Deposit()
        {
            return checkingBalance += depositAmount;
        }

        //menuchoice 4
        public override double Withdraw()
        {
            return checkingBalance -= withdrawAmount;
        }

    }
}
