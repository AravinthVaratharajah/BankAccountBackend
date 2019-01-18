using System;
namespace Backend
{
    public interface ITransaction
    {

        void Withdraw(Account account, decimal amount);
        void Deposit(Account account, decimal amount);
    }
}
