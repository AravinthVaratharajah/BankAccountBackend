using System;
using Backend;
using NFluent;
using NUnit.Framework;


namespace UnitTest
{
    [TestFixture]
    public class PrintingTest
    {
        public Account account { get; set; }
        public ITransaction transaction { get; set; }

        [SetUp]
        public void SetUp()
        {
            account = new Account(1);
            transaction = new Transaction();
        }

        [TestCase]
        public void Should_Print_Operations()
        {
            transaction.Deposit(account, 100);
            transaction.Withdraw(account, 200);
        }
    }
}
