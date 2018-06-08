using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAggregator.Data
{
    public class Account
    {
        public int Id { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Transaction> Transactions { get; private set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
