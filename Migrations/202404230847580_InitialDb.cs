namespace CnrMigrationData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        product_id = c.Int(nullable: false, identity: true),
                        product_code = c.String(nullable: false, maxLength: 2147483647),
                        product_name = c.String(nullable: false, maxLength: 2147483647),
                        cost_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        sell_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        product_qty = c.Int(nullable: false),
                        product_status = c.String(maxLength: 2147483647),
                        VendorId = c.Int(),
                        Vendor_vendor_id = c.Int(),
                    })
                .PrimaryKey(t => t.product_id)
                .ForeignKey("dbo.Vendor", t => t.Vendor_vendor_id)
                .Index(t => t.product_code, unique: true)
                .Index(t => t.Vendor_vendor_id);
            
            CreateTable(
                "dbo.Vendor",
                c => new
                    {
                        vendor_id = c.Int(nullable: false, identity: true),
                        vendor_code = c.String(nullable: false, maxLength: 2147483647),
                        vendor_name = c.String(nullable: false, maxLength: 2147483647),
                        vendor_status = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.vendor_id)
                .Index(t => t.vendor_code, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Vendor_vendor_id", "dbo.Vendor");
            DropIndex("dbo.Vendor", new[] { "vendor_code" });
            DropIndex("dbo.Product", new[] { "Vendor_vendor_id" });
            DropIndex("dbo.Product", new[] { "product_code" });
            DropTable("dbo.Vendor");
            DropTable("dbo.Product");
        }
    }
}
