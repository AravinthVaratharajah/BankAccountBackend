﻿using System.Collections.Generic;

namespace Backend
{
    public class Account
    {
        public int accountId { get; set; }

        public decimal balance { get; set; }

        public List<Operation> operations { get; set; }

        public Account(int id)
        {
            accountId = id;
            balance = 0.00m;
            operations = new List<Operation>();
        }
    }
}
