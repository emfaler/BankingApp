using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Checking : Account
    {
        public double MinimumRequiredBalance { get; set; }
        public int CheckNumber { get; set; }



        public Checking()
        {
            MinimumRequiredBalance = 200.00;
            CheckNumber = 1;
            Balance = 250;
        }

        public Checking(string nickName, string accountNumber)
        {
            MinimumRequiredBalance = 200.00;
            CheckNumber = 1;
            Balance = 250;
            NickName = nickName;
            AccountNumber = accountNumber;
        }

        public void WriteCheck()
        {
            CheckNumber++;
        }
    }
}
