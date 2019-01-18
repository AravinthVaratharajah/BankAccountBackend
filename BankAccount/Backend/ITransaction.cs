using System;
namespace Backend
{
    public interface ITransaction
    {

        void Withdraw(BankAccount account, decimal amount);
        void Deposit(BankAccount account, decimal amount);
    }
}
