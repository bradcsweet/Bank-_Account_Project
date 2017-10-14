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
            string userExit ="";
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome, please choose from the following menu choices.\n");
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

                    }
                    else if(accountChoice == "b")
                    {

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

                }
                else if (menuChoice == 4)
                {

                }
                else if (menuChoice == 5)
                {
                    Console.WriteLine("Are you sure you would like to EXIT? YES/NO ");

                    userExit = Console.ReadLine().ToUpper();
                }
            }
            while (userExit == "NO");
            Console.Clear();

            Console.WriteLine("Thank you for choosing Crystal Ball Banking. Have a nice day! \n\n");
        
        }
    }
}
