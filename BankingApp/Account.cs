using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Account


    {

        public Account()
        {
            Balance = 25;
        }
        
        
        public double Balance { get; set; }

        public double GetBalance()
        {
            return Balance;
        }

        public void Withdraw()
        {
             Balance -= 10;
        }

        public void Deposit()
        {
            Balance += 50;
        }









    }


}
