using Backend;
using NFluent;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class BankAccountTest
    {
        public Account account { get; set; }
        public ITransaction transaction { get; set; }

        [SetUp]
        public void SetUp()
        {
            transaction = new Transaction();
        }

        [TestCase(1, 100.00)]
        [TestCase(2, 200.00)]
        public void Should_Check_The_Account_Balance(int accountId, decimal expectedBalance)
        {
            account = new Account(accountId)
            {
                balance = expectedBalance
            };
            Check.That(account.balance).IsEqualTo(expectedBalance);
        }

        [TestCase(0.00)]
        public void Should_Create_New_Account_With_Zero_Balance(decimal expectedBalance)
        {
            account = new Account(1);
            Check.That(account.balance).IsEqualTo(expectedBalance);
        }

        [TestCase]
        public void Should_Return_Operation_List()
        {
            account = new Account(1);
            transaction.Deposit(account, 100);
            transaction.Withdraw(account, 50);
            transaction.Withdraw(account, 50);

            Check.That(account.operations.Count).IsEqualTo(3);
        }
    }

}
