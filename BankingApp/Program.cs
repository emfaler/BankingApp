using System;
using System.Collections.Generic;


namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Account myAccount = new Account();

            Bank myBank = new Bank();

            //List<Account> ListofAccounts = new List<Account>();

            Checking checkingAccount = new Checking()
            {
                AccountNumber = "C12-345",
                NickName = "First Checking"
                
            };

            //ListofAccounts.Add(checkingAccount);

            //ListofAccounts.Add(new Savings()
            //{
            //    AccountNumber = "S89-212",
            //    NickName = "Goal Savings"

            //});




            Console.WriteLine("Welcome to the BankingApp!\n" );

            bool keepBanking = true;
            while (keepBanking)
            {



                Console.WriteLine("Select the service you'd like to use from below: ");
                Console.WriteLine("1: Check Account Balance");
                Console.WriteLine("2: Withdraw $10");
                Console.WriteLine("3: Deposit $50");
                Console.WriteLine("4: Exit");
                Console.WriteLine("5: Add Checking Account");
                Console.WriteLine("6: Add Savings Account");

                string accountChoice = Console.ReadLine();

                switch (accountChoice)
                {
                    case "1":
                        foreach (Account account in myBank.ListofAccounts)
                        {
                            double currentBalance = account.GetBalance();
                            Console.WriteLine($"Your balance of {account.NickName} is {currentBalance:C2}");
                        }
                        break;
                    case "2":
                        //account.Withdraw();
                        //Console.WriteLine($"You withdrew $10");
                        //break;
                    case "3":
                        //account.Deposit();
                        //Console.WriteLine($"You have deposited $50");
                        //break;
                    case "4":
                        Console.WriteLine("Thank you for banking with us");
                        keepBanking = false;
                        break;
                    case "5":
                        Console.WriteLine("What is your nickname for your checking account?");
                        string nickName = Console.ReadLine();
                        Console.WriteLine("What is the account number for your checking account?");
                        string accountNumber = Console.ReadLine();
                        myAccount = new Checking(nickName, accountNumber);
                        myBank.AddAccount(myAccount);
                        break;
                    case "6":
                        Console.WriteLine("What is your nickname for your savings account?");
                        nickName = Console.ReadLine();
                        Console.WriteLine("What is the account number for your savings account?");
                        accountNumber = Console.ReadLine();
                        myAccount = new Savings(nickName, accountNumber);
                        myBank.AddAccount(myAccount);
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
