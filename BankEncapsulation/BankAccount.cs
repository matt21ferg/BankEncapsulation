using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        
        }
        public double Balance 
        {
            get { return _balance; }


            set { _balance = value; } 
        }




        private double _balance = 0;
        public double AccountBalance()
        {
            return _balance;
        }
        public double Deposit(double Amount)
        {
            return Balance += Amount;
        }
        public double Withdraw(double Amount)
        { return Balance -= Amount; }
    
    
    
    }

}
