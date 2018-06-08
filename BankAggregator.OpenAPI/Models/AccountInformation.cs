using BankAggregator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankAggregator.OpenAPI.Models
{
    public class AccountInformation
    {
        public List<Account> Accounts { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}