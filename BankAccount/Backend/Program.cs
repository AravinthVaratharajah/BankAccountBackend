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
                Console.WriteLine("How much would you like to deposit ?");
                var value = Console.ReadLine();
                try
                {
                    int amount = int.Parse(value);
                    transaction.Deposit(newaccount, amount);
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

            if (info.Key == ConsoleKey.W)
            {
                Console.WriteLine("How much would you like to withdraw ?");
                var value = Console.ReadLine();
                try
                {
                    int amount = int.Parse(value);
                    transaction.Withdraw(newaccount, amount);
                    Console.WriteLine("Your new balance is " + newaccount.balance + "€");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    if(ex.Message != null)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
