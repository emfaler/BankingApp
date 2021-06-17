﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Account

    {

        public Account()
        {
            Balance = 100;
        }
        
        
        public double Balance { get; set; }
        public string AccountNumber { get; set; }
        public string NickName { get; set; }

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
