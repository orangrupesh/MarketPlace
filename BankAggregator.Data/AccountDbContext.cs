using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAggregator.Data
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext()
           : base("AccountDbContext")
        {
            Database.SetInitializer<AccountDbContext>(null);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}
