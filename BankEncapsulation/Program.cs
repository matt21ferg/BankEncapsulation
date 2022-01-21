using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var MyBankAccount = new BankAccount();
            MyBankAccount.Deposit(39);
            Console.WriteLine($" your balance is {MyBankAccount.Balance}");
            Console.WriteLine( );
            MyBankAccount.Withdraw(20);
            Console.WriteLine($" your balance is {MyBankAccount.Balance}");

        }
    }
}
