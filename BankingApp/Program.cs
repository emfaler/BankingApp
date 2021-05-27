using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the BankingApp!\n" );

            Console.WriteLine("Select the service you'd like to use from below: ");
            Console.WriteLine("1: Check Account Balance");
            Console.WriteLine("2: Withdraw $10");
            Console.WriteLine("3: Deposit $50");
            Console.WriteLine("4: Exit");

            string accountChoice = Console.ReadLine();

        }
    }
}
