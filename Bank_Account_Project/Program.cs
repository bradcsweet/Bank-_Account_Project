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
                Console.WriteLine("Welcome, please choose from the following menu choices.\n");
                Console.WriteLine("1 - View Client Information");
                Console.WriteLine("2 - View Account Balance");
                Console.WriteLine("3 - Deposit Funds");
                Console.WriteLine("4 - Withdraw Funds");
                Console.WriteLine("5 - Exit");

                int menuChoice = int.Parse(Console.ReadLine());

                if (menuChoice == 1)
                {






                    Console.WriteLine("Are you sure you would like to EXIT? YES/NO ");
                    userExit = Console.ReadLine().ToUpper();
                }
                else if (menuChoice == 2)
                {

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
        
        }
    }
}
