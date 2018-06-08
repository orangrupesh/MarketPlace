using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAggregator.Data
{
    public class Offer
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string OfferLink { get; set; }

        public virtual Account Account { get; set; }
    }
}
