using System;

namespace Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            Account newaccount = new Account(1);
            ITransaction transaction = new Transaction();
            Console.WriteLine("Would you like to Deposit (D) or Withdraw (W) ?");
            ConsoleKeyInfo info = Console.ReadKey();

            if (info.Key == ConsoleKey.D)
            {
                MessageKeyPressed(newaccount, transaction, true);
            }

            if (info.Key == ConsoleKey.W)
            {
                MessageKeyPressed(newaccount, transaction, false);
            }
        }

        private static void MessageKeyPressed(Account newaccount, ITransaction transaction, Boolean isDeposit)
        {
            Console.WriteLine("What is the amount ?");
            var value = Console.ReadLine();
            try
            {
                int amount = int.Parse(value);
                if(isDeposit)
                    transaction.Deposit(newaccount, amount);
                else
                    transaction.Withdraw(newaccount, amount);
                Console.WriteLine("Your new balance is " + newaccount.balance + "€");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                if (ex.Message != null)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
