using NUnit.Framework;

namespace Backend
{
    [TestFixture]
    public class BankAccountTest
    {
        [TestCase(1, 100,00)]
        [TestCase(2, 200,00)]
        public void Should_Return_The_Balance_With_AccountId(int accountId, decimal balanceExpected)
        {

        }

        [TestCase(0,00)]
        public void Should_Create_New_Account_With_Zero_Balance(decimal balanceExpected)
        {

        }
    }
}
