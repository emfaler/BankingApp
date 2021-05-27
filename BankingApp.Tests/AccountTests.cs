using System;
using Xunit;

namespace BankingApp.Tests
{


    
    public class AccountTests
    {

        Account myAccount;

        public AccountTests()
        {
            myAccount = new Account();
        }


        [Fact]
        public void New_Account_Should_Have_Balance_of_25()
        {

            //Arrange 
            //Account myAccount = new Account();

            //Act 

            //Assert
            Assert.Equal(25.00, myAccount.Balance);

        }

        [Fact]

        public void GetBalance_Should_Return_Balance()
        {
            //Arrange
            //Account myAccount = new Account();
            myAccount.Balance = 25;

            //Act
            double myBalance = myAccount.GetBalance();

            //Assert
            Assert.Equal(25, myBalance);

        }

        [Fact]
        public void Withdraw_Should_Decrease_Balance_By_10()
        {
            //Arrange
            //Account myAccount = new Account();
            myAccount.Balance = 50;
            double finalBalance = myAccount.Balance - 10;


            //Act
            myAccount.Withdraw();

            //Assert
            Assert.Equal(finalBalance, myAccount.Balance);

        }

        [Fact]
        public void Deposit_Should_Increase_Balance_By_50()
        {
            //Arrange
            myAccount.Balance = 50;
            double finalBalance = myAccount.Balance + 50;


            //Act
            myAccount.Deposit();

            //Assert
            Assert.Equal(finalBalance, myAccount.Balance);


        }



    }
}
