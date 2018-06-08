using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAggregator.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public int Debit { get; set; }
        public int Credit { get; set; }
        public string Reference { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
    }
}
