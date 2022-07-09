using System;
using System.Collections.Generic;

public class bankingOP
{

    public class Account
    {
        public double Balance { get; set; }

        public Account(double amount)
        {
            this.Balance = amount;

        }
        public void Deposite(double amount)
        {
            this.Balance += amount;
        }

        public void withdrea (double amt )
        {
            this.Balance -= amt;
        }
    }

   
}
