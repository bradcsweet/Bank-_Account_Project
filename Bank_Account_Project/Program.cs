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
                Console.Clear();
                Console.WriteLine("Welcome to Crystal Ball Banking, please choose from the following menu choices.\n");
                Console.WriteLine("1 - View Client Information");
                Console.WriteLine("2 - View Account Balance");
                Console.WriteLine("3 - Deposit Funds");
                Console.WriteLine("4 - Withdraw Funds");
                Console.WriteLine("5 - Exit\n");

                int menuChoice = int.Parse(Console.ReadLine());

                if (menuChoice == 1)
                {
                    Client oneClient = new Client();
                    oneClient.ClientInfo();

                    Console.WriteLine("Go BACK or EXIT?");
                    userExit = Console.ReadLine().ToUpper();
                    if (userExit == "EXIT")
                    {
                        break;
                    }
                    else
                    {
                        userExit = "NO";
                    }
                }
                else if (menuChoice == 2)
                {
                    Console.WriteLine("\na - Checking Account\n");
                    Console.WriteLine("b - Savings Account");
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

                    Console.WriteLine("\nGo BACK or EXIT?");
                    userExit = Console.ReadLine().ToUpper();
                    if (userExit == "EXIT")
                    {
                        break;
                    }
                    else
                    {
                        userExit = "NO";
                    }

                }
                else if (menuChoice == 3)
                {
                    Console.WriteLine("\na - Checking Account\n");
                    Console.WriteLine("b - Savings Account");
                    string accountChoice = Console.ReadLine().ToLower();

                    Console.WriteLine("Enter the amount to Deposit");
                    double userDeposit = double.Parse(Console.ReadLine());

                    if (accountChoice == "a")
                    {
                        Checking newDeposit = new Checking(userDeposit, 0);

                        Console.WriteLine("Your new balance is " + newDeposit.Deposit());
                        
                    }
                    else if (accountChoice == "b")
                    {
                        Savings newDeposit = new Savings(userDeposit, 0);
                        Console.WriteLine("Your new balance is " + newDeposit.Deposit());
                    }

                    Console.WriteLine("\nGo BACK or EXIT?");
                    userExit = Console.ReadLine().ToUpper();
                    if (userExit == "EXIT")
                    {
                        break;
                    }
                    else
                    {
                        userExit = "NO";
                    }



                }
                else if (menuChoice == 4)
                {
                    Console.WriteLine("\na - Checking Account\n");
                    Console.WriteLine("b - Savings Account");
                    string accountChoice = Console.ReadLine().ToLower();

                    Console.WriteLine("Enter the amount to Withdraw");
                    double userWithdraw = double.Parse(Console.ReadLine());

                    if (accountChoice == "a")
                    {
                        Checking newWithdraw = new Checking(0, userWithdraw);
                        Console.WriteLine("Your current balance is " + newWithdraw.Withdraw());
                    }
                    else if (accountChoice == "b")
                    {
                        Savings newWithdraw = new Savings(0, userWithdraw);
                        
                        Console.WriteLine("Your current balance is " + newWithdraw.Withdraw());
                    }


                    Console.WriteLine("\nGo BACK or EXIT?");
                    userExit = Console.ReadLine().ToUpper();
                    if (userExit == "EXIT")
                    {
                        break;
                    }
                    else
                    {
                        userExit = "NO";
                    }


                }
                else if (menuChoice == 5)
                {
                    Console.WriteLine("Are you sure you would like to EXIT this session? YES/NO ");

                    userExit = Console.ReadLine().ToUpper();
                }
            }
            while (userExit == "NO");
            Console.Clear();

            Console.WriteLine("Thank you for choosing Crystal Ball Banking. Have a nice day! \n\n");

        }
    }
}
