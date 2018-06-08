namespace BankAggregator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedreference : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Reference", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "Reference");
        }
    }
}
