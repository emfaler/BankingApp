using System;
using System.Collections.Generic;


namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank();

            Account myAccount = new Account();


            Checking checkingAccount = new Checking();
         


            Console.WriteLine("Welcome to the BankingApp!\n" );

            bool keepBanking = true;
            while (keepBanking)
            {



                Console.WriteLine("Select the service you'd like to use from below: ");
                Console.WriteLine("1: Add Checking Account");
                Console.WriteLine("2: Add Savings Account");
                Console.WriteLine("3: Check Account Balance");
                Console.WriteLine("4: Withdraw $10");
                Console.WriteLine("5: Deposit $50");
                Console.WriteLine("6: Write a Check");
                Console.WriteLine("7: Exit");
                

                string accountChoice = Console.ReadLine();

                switch (accountChoice)
                {
                    case "1":
                        Console.WriteLine("What is your nickname for your checking account?");
                        string nickName = Console.ReadLine();
                        Console.WriteLine("What is the account number for your checking account?");
                        string accountNumber = Console.ReadLine();
                        myAccount = new Checking(nickName, accountNumber);
                        myBank.AddAccount(myAccount);
                        break;
                    case "2":
                        Console.WriteLine("What is your nickname for your savings account?");
                        nickName = Console.ReadLine();
                        Console.WriteLine("What is the account number for your savings account?");
                        accountNumber = Console.ReadLine();
                        myAccount = new Savings(nickName, accountNumber);
                        myBank.AddAccount(myAccount);
                        break;
                    case "3":
                        foreach (Account account in myBank.ListofAccounts)
                        {
                            double currentBalance = account.GetBalance();
                            Console.WriteLine($"Your balance of {account.NickName} is {currentBalance:C2}");
                        }
                        break;
                    case "4":
                        myAccount = myBank.SelectAccount();
                        myAccount.Withdraw();
                        Console.WriteLine($"You withdrew $10");
                        break;
                    case "5":
                        myAccount = myBank.SelectAccount();
                        myAccount.Deposit();
                        Console.WriteLine($"You deposited $50");
                        break;
                    case "6":
                        myAccount = myBank.SelectAccount();
                        Console.WriteLine("You have written a check");
                        Console.WriteLine($"You are on check number: {checkingAccount.GetCheckNumber()}");
                        checkingAccount.WriteCheck();
                        break;

                    case "7":
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
