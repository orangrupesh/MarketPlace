namespace BankAggregator.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cutomerDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "UserName", c => c.String());
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            AddColumn("dbo.Customers", "LasttName", c => c.String());
            AddColumn("dbo.Customers", "Address", c => c.String());
            AddColumn("dbo.Customers", "PostCode", c => c.String());
            AddColumn("dbo.Customers", "Mobile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Mobile");
            DropColumn("dbo.Customers", "PostCode");
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "LasttName");
            DropColumn("dbo.Customers", "FirstName");
            DropColumn("dbo.Customers", "UserName");
        }
    }
}
