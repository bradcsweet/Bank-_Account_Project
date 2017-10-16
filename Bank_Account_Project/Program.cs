using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string userExit = "";
            do
            {
                // You are Balthazar Runze and you have 567.45 in your checking and 1243.22 in your savings. Happy banking!
                //Program will loop and hold values of balances for multiple transactions before exiting
                //Classes organized as Accounts(abstract) : Clients : Checking/Savings 
                Console.Clear();
                Console.WriteLine("Welcome to Crystal Ball Banking, please choose from the following menu choices.\n\n");
                Console.WriteLine("1 - View Client Information\n");
                Console.WriteLine("2 - View Account Balance\n");
                Console.WriteLine("3 - Deposit Funds\n");
                Console.WriteLine("4 - Withdraw Funds\n");
                Console.WriteLine("5 - Exit\n");

                int menuChoice = int.Parse(Console.ReadLine());
                
                //Menu beginning - 5 total choices with 2 choice sub menu for choices 1-4
                if (menuChoice == 1)
                {
                    Client oneClient = new Client();
                    oneClient.ClientInfo();

                    //This is a main method that we'll use to return to beginning of menu
                    userExit = backOrExit();

                }

                else if (menuChoice == 2)
                {
                    //submenu choices - will be the same for menuChoice 2-4
                    Console.WriteLine("\na - Checking Account\n");
                    Console.WriteLine("b - Savings Account\n");
                    string accountChoice = Console.ReadLine().ToLower();

                    if (accountChoice == "a")
                    {
                        Checking displayBalance = new Checking();
                        Console.WriteLine(displayBalance.TotalBalance());
                    }
                    else if (accountChoice == "b")
                    {
                        Savings displayBalance = new Savings();
                        Console.WriteLine(displayBalance.TotalBalance());
                    }

                    userExit = backOrExit();
                    
                }

                else if (menuChoice == 3)
                {
                    Console.WriteLine("\na - Checking Account\n");
                    Console.WriteLine("b - Savings Account\n");
                    string accountChoice = Console.ReadLine().ToLower();

                    Console.WriteLine("\nEnter the amount to Deposit\n");
                    double userDeposit = double.Parse(Console.ReadLine());

                    if (accountChoice == "a")
                    {
                        Checking newDeposit = new Checking(userDeposit, 0);

                        Console.WriteLine("\nYour current balance is " + newDeposit.Deposit());

                    }
                    else if (accountChoice == "b")
                    {
                        Savings newDeposit = new Savings(userDeposit, 0);
                        Console.WriteLine("\nYour current balance is " + newDeposit.Deposit());
                    }

                    userExit = backOrExit();
                    
                }

                else if (menuChoice == 4)
                {
                    Console.WriteLine("\na - Checking Account\n");
                    Console.WriteLine("b - Savings Account\n");
                    string accountChoice = Console.ReadLine().ToLower();

                    Console.WriteLine("\nEnter the amount to Withdraw\n");
                    double userWithdraw = double.Parse(Console.ReadLine());

                    if (accountChoice == "a")
                    {
                        Checking newWithdraw = new Checking(0, userWithdraw);
                        Console.WriteLine("\nYour current balance is " + newWithdraw.Withdraw());
                    }
                    else if (accountChoice == "b")
                    {
                        Savings newWithdraw = new Savings(0, userWithdraw);

                        Console.WriteLine("\nYour current balance is " + newWithdraw.WithdrawWithMinimum());
                    }

                    userExit = backOrExit();

                }

                else if (menuChoice == 5)
                {
                    Console.WriteLine("\nAre you sure you would like to EXIT this session? YES/NO ");

                    userExit = Console.ReadLine().ToUpper();
                }

            }
            while (userExit == "NO");
            Console.Clear();

            Console.WriteLine("Thank you for choosing Crystal Ball Banking. Have a nice day! \n\n");

        }
        //Main method
        public static string backOrExit()
        {
            Console.WriteLine("\nGo BACK or EXIT?\n");
            string userExit;
            userExit = Console.ReadLine().ToUpper();
            if (userExit == "EXIT")
            {
                return userExit = "YES";
            }
            else
            {
                return userExit = "NO";
            }
        }
    }
}
