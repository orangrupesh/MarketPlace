namespace BankAggregator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class offer1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "OfferLink", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "OfferLink", c => c.Int(nullable: false));
        }
    }
}
