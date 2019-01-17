using Backend;
using NFluent;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]     public class BankAccountTest     {         public BankAccount account { get; set; }          [TestCase(1, 100.00)]         [TestCase(2, 200.00)]         public void Should_Return_The_Balance_With_AccountId(int accountId, decimal expectedBalance)         {             account = new BankAccount(accountId)             {                 balance = expectedBalance             };             Check.That(account.GetBalance(account)).IsEqualTo(expectedBalance);         }          [TestCase(0.00)]         public void Should_Create_New_Account_With_Zero_Balance(decimal expectedBalance)         {             account = new BankAccount(1);             Check.That(account.GetBalance(account)).IsEqualTo(expectedBalance);         }     } 
}
