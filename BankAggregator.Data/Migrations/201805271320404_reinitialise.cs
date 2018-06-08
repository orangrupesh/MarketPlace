namespace BankAggregator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reinitialise : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "AccountType", c => c.String());
            AddColumn("dbo.Transactions", "TransactionDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Transactions", "Credit", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "Debit", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "FirstName");
            DropColumn("dbo.Customers", "LastName");
            DropColumn("dbo.Customers", "Mobile");
            DropColumn("dbo.Transactions", "DestinationAccount");
            DropColumn("dbo.Transactions", "TransactioDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "TransactioDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Transactions", "DestinationAccount", c => c.String());
            AddColumn("dbo.Customers", "Mobile", c => c.String());
            AddColumn("dbo.Customers", "LastName", c => c.String());
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            AlterColumn("dbo.Transactions", "Debit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Transactions", "Credit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Transactions", "TransactionDate");
            DropColumn("dbo.Accounts", "AccountType");
        }
    }
}
