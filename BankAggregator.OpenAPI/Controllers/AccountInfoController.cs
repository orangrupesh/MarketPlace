using BankAggregator.Data;
using BankAggregator.OpenAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankAggregator.OpenAPI.Controllers
{
    [RoutePrefix("api/accountInfo")]
    public class AccountInfoController : ApiController
    {
        [Route("{username}")]
        public AccountInformation GetAccounts(string username)
        {
            AccountDbContext context = new AccountDbContext();
            context.Configuration.ProxyCreationEnabled = false;
            var info = new AccountInformation();
            info.Accounts = context.Accounts.Where(row=> row.Customer.UserName == username).ToList();
            return info;
        }

        [Route("bank/{accountNumber}")]
        public AccountInformation GetTransactions(string accountNumber)
        {
            AccountDbContext context = new AccountDbContext();
            context.Configuration.ProxyCreationEnabled = false;
            var info = new AccountInformation();
            info.Accounts = context.Accounts.Where(row => row.AccountNumber == accountNumber).ToList();
            info.Transactions = context.Transactions.Where(row => row.Account.AccountNumber == accountNumber).ToList();

            return info;
        }
    }
}
