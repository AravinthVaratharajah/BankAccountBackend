using System.Collections.Generic;

namespace Backend
{
    public interface IPrinting
    {
        List<string> Print(Account account);
    }
}
