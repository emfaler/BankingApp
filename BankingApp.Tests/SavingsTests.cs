using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingApp.Tests
{
    public class SavingsTests
    {
        Savings mySavings;

        public SavingsTests()
        {
            mySavings = new Savings();
        }


        [Fact]
        public void New_Savings_Should_Have_Balance_of_200()
        {

            //Arrnage

            //Act

            //Assert
            Assert.Equal(200.00, mySavings.Balance);

        }




    }
}

