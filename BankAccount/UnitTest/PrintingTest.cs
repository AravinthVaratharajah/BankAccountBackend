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
        public IPrinting printing { get; set; }
        public ITransaction transaction { get; set; }

        [SetUp]
        public void SetUp()
        {
            account = new Account(1);
            transaction = new Transaction();
            printing = new Printing();
        }

        [TestCase]
        public void Should_Print_Operations()
        {
            transaction.Deposit(account, 100);
            transaction.Withdraw(account, 50);
            var print = printing.Print(account);

            Check.That(print.Count).IsEqualTo(3);
        }

        [TestCase]
        public void Should_Print_Header()
        {
            var print = printing.Print(account);

            Check.That(print.Count).IsEqualTo(1);
        }
    }
}
