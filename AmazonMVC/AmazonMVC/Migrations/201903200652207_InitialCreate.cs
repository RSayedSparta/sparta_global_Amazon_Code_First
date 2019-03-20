namespace AmazonMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        addressID = c.Int(nullable: false, identity: true),
                        doorNumber = c.String(),
                        roadName = c.String(),
                        city = c.String(),
                        postcode = c.String(),
                    })
                .PrimaryKey(t => t.addressID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastNmae = c.String(),
                        address_addressID = c.Int(),
                    })
                .PrimaryKey(t => t.customerID)
                .ForeignKey("dbo.Addresses", t => t.address_addressID)
                .Index(t => t.address_addressID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "address_addressID", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "address_addressID" });
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
