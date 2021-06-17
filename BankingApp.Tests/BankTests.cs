using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingApp.Tests
{
    public class BankTests
    {



        Bank myBank;

        public BankTests()
        {
            myBank = new Bank();
        }

        [Fact]
        public void AddAccount_Should_Increase_List_Count_By_1()
        {
            //Arrange
            myBank.ListofAccounts.Clear();
            Account newAccount = new Account();


            //Act
            myBank.AddAccount(newAccount);


            //Assert
            Assert.Single(myBank.ListofAccounts);
        }







    }
}
