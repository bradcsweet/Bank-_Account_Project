using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Client : Accounts
    {
        public string clientName;
        public int savingsAcctNumber;
        public int checkingAcctNumber;

        public string ClientName 
        {
            get { return this.clientName;}
            set { this.clientName = value;}
        } 

        public int SavingsAcctNumber
        {
            get { return this.savingsAcctNumber; }
        }

        public int CheckingAcctNumber
        {
            get { return this.checkingAcctNumber; }
        }

        public Client()
        {
        }

        public Client(string clientName, int savingsAcctNumber, int checkingAcctNumber)
        {
            this.clientName = clientName;
            this.savingsAcctNumber = savingsAcctNumber;
            this.checkingAcctNumber = checkingAcctNumber;
        }

        



    }
}
