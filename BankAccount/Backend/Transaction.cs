using System;
namespace Backend
{
    public class Transaction : ITransaction
    {
        public void Withdraw(BankAccount account, decimal amount)
        {
            if(account.balance - amount >= 0)
            {
                account.balance -= amount;
            }
            else
            {
                throw new Exception();
            }
        }

        public void Deposit(BankAccount account, decimal amount)
        {
            account.balance += amount;
        }
    }
}
