using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Client : Accounts
    {
        //client info hardcoded here.

        private string clientName = "Balthazar Runze";
        private int savingsAcctNumber = 0912093091;
        private int checkingAcctNumber = 0912390344;
        protected static double checkingBalance = 567.45;
        protected static double savingsBalance = 1243.22;

        //properties
        public string ClientName 
        {
            get { return this.clientName;}
            set { this.clientName = value;}
        } 

        public double CheckingBalance { get; set; }
        
        public double SavingsBalance { get; set; }
        

        //constructor
        public Client()
        {
        }
                
        public Client(string clientName, int savingsAcctNumber, int checkingAcctNumber)
        {
            this.clientName = clientName;
            this.savingsAcctNumber = savingsAcctNumber;
            this.checkingAcctNumber = checkingAcctNumber;
        }

        //methods
        public override void ClientInfo()
        {
            Console.WriteLine("\nName on account: " +clientName);
            Console.WriteLine("\nSavings account number: " + savingsAcctNumber);
            Console.WriteLine("\nChecking account number: " + checkingAcctNumber);
        }
    }
}
