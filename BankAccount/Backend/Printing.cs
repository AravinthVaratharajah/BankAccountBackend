using System.Collections.Generic;

namespace Backend
{
    public class Printing : IPrinting
    {
        public List<string> Print(Account account)
        {
            List<string> printList  = new List<string>();

            printList.Add("Date | Amount Withdraw or Deposit | Balance");
            foreach (var operation in account.operations)
            {
                printList.Add(string.Format("{0} | {1} | {2}",
                    operation.operationDate,
                    operation.amount,
                    account.balance));
            }
            return printList;
        }
    }
}
