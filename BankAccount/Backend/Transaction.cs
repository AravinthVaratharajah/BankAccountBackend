using System;
namespace Backend
{
    public class Transaction
    {
        public void Withdraw(BankAccount account, decimal amount)
        {
            account.balance -= amount;
        }

        public void Deposit(BankAccount account, decimal amount)
        {
            account.balance += amount;
        }
    }
}
