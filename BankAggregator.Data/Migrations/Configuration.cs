namespace BankAggregator.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BankAggregator.Data.AccountDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BankAggregator.Data.AccountDbContext context)
        {
          //  context.Customers.AddOrUpdate(
          //  p => p.Id,
          //  new Customer { Email = "sachin.mittal@gmail.com", FirstName = "Sachin", LastName = "Mittal", Mobile = "9581026771" }
          //);

          //  context.Accounts.AddOrUpdate(
          //      a => a.Id,
          //      new Account { AccountNumber = "GD7874FJF", Balance = 100000000, Bank = "HDFC", Branch = "Delhi" }
          //      );
          //  context.Transactions.AddOrUpdate(
          //      t => t.Id,
          //      new Transaction { Credit = 10000, DestinationAccount = "HGGGF88734", TransactioDate = DateTime.Now },
          //      new Transaction { Credit = 20000, DestinationAccount = "HGGGF88734", TransactioDate = DateTime.Now },
          //      new Transaction { Debit = 10000, DestinationAccount = "HGGGF88734", TransactioDate = DateTime.Now }
          //      );
        }
    }
}
