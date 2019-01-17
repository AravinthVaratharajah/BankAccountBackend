using System;
using Backend;
using NFluent;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class TransactionTest
    {
        public BankAccount account { get; set; }
        public Transaction transaction { get; set; }

        [SetUp]
        public void SetUp()
        {
            transaction = new Transaction();
        }

        [TestCase(1, 100.00)]
        [TestCase(2, 200.00)]
        public void Should_Deposit_Money_In_Account(int accountId, decimal expectedBalance)
        {
            account = new BankAccount(accountId);

            transaction.Deposit(account, expectedBalance);

            Check.That(account.GetBalance()).IsEqualTo(expectedBalance);
        }

        [TestCase(1, 0.00)]
        public void Should_WithDraw_Money_In_Account(int accountId, decimal expectedBalance)
        {
            account = new BankAccount(accountId)
            {
                balance = 100.00m
            };

            transaction.Withdraw(account, 100);

            Check.That(account.GetBalance()).IsEqualTo(expectedBalance);
        }

        [TestCase(1, 150.00)]
        [TestCase(1, 250.00)]
        public void Should_ThrowException_If_Customer_Try_To_Withdraw_Without_Balance(int accountId, decimal amountToWithDraw)
        {
            account = new BankAccount(accountId);

            transaction.Withdraw(account, amountToWithDraw);

            Check.ThatCode(() => { throw new Exception(); }).Throws<InvalidOperationException>();
        }

        [TestCase(1, 150.00)]
        [TestCase(1, 250.00)]
        public void Should_WithdrawMoney(int accountId, decimal amountToWithDraw)
        {
            account = new BankAccount(accountId)
            {
                balance = 300.00m
            };

            var balanceHistory = account.GetBalance();

            transaction.Withdraw(account, amountToWithDraw);

            Check.That(account.GetBalance()).IsEqualTo(balanceHistory-amountToWithDraw);
        }
    }
}
