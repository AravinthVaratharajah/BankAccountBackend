using System;
namespace Backend
{
    public class Transaction : ITransaction
    {
        public void Withdraw(Account account, decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount to withdraw can't be negative");
            }
            if (account.balance - amount < 0)
            {
                throw new InvalidOperationException("Not enough funds");
            }

            account.balance -= amount;
            account.operations.Add(new Operation() { operationDate = DateTime.Now, amount = -amount });
        }

        public void Deposit(Account account, decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Amount to deposit can't be negative");
            }

            account.balance += amount;
            account.operations.Add(new Operation() { operationDate = DateTime.Now, amount = amount });
        }
    }
}
