using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Client : Accounts
    {
        private string clientName = "Balthazar Runze";
        private int savingsAcctNumber = 0912093091;
        private int checkingAcctNumber = 0912390344;
        

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

        public void ClientInfo()
        {
            Console.WriteLine("Name on account: " +clientName);
            Console.WriteLine("\nSavings account number: " + savingsAcctNumber);
            Console.WriteLine("\nChecking account number: " + checkingAcctNumber);
        }
        



    }
}
