using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account();

            Console.WriteLine("Welcome to the BankingApp!\n" );

            bool keepBanking = true;
            while (keepBanking)
            {



                Console.WriteLine("Select the service you'd like to use from below: ");
                Console.WriteLine("1: Check Account Balance");
                Console.WriteLine("2: Withdraw $10");
                Console.WriteLine("3: Deposit $50");
                Console.WriteLine("4: Exit");

                string accountChoice = Console.ReadLine();

                switch (accountChoice)
                {
                    case "1":
                        double currentBalance = account.GetBalance();
                        Console.WriteLine($"Your balance is {currentBalance:C2}");
                        break;
                    case "2":
                        account.Withdraw();
                        Console.WriteLine($"You withdrew $10");
                        break;
                    case "3":
                        account.Deposit();
                        Console.WriteLine($"You have deposited $50");
                        break;
                    case "4":
                        Console.WriteLine("Thank you for banking with us");
                        keepBanking = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;


                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
