using Backend;
using NFluent;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class TransactionTest
    {
        public BankAccount account { get; set; }


        [TestCase(1, 100.00)]
        [TestCase(2, 200.00)]
        public void Should_Deposit_Money_In_Account(int accountId, decimal expectedBalance)
        {
            account = new BankAccount(accountId);
            
            Check.That(account.GetBalance(account)).IsEqualTo(expectedBalance);
        }

        [TestCase(1, 0.00)]
        [TestCase(2, 100.00)]
        public void Should_WithDraw_Money_In_Account(int accountId, decimal expectedBalance)
        {
            account = new BankAccount(accountId);

            Check.That(account.GetBalance(account)).IsEqualTo(expectedBalance);
        }
    }
}
