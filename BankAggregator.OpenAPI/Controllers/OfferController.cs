using BankAggregator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankAggregator.OpenAPI.Controllers
{
    [RoutePrefix("api/offer")]
    public class OfferController : ApiController
    {
        [Route("{accountNumber}")]
        public List<Offer> Get(string AccountNumber)
        {
            AccountDbContext context = new AccountDbContext();
            context.Configuration.ProxyCreationEnabled = false;
            return context.Offers.Where(row => row.Account.AccountNumber == AccountNumber).ToList();
        }
    }
}
