﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAggregator.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Mobile { get; set; }
        
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
