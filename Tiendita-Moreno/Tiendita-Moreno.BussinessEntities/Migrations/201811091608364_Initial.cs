namespace Tiendita_Moreno.BussinessEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cut",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InitialAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FinalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Deference = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Description = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        BarCode = c.String(nullable: false, maxLength: 16, unicode: false, storeType: "nvarchar"),
                        DepartmentId = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ganancia = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Current_Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.DetailSale",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaleId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sale", t => t.SaleId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SaleId);
            
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfSale = c.DateTime(nullable: false, precision: 0),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuantityOfItem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Uid = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        Pwd = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetailSale", "SaleId", "dbo.Sale");
            DropForeignKey("dbo.DetailSale", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "DepartmentId", "dbo.Department");
            DropIndex("dbo.DetailSale", new[] { "SaleId" });
            DropIndex("dbo.DetailSale", new[] { "ProductId" });
            DropIndex("dbo.Product", new[] { "DepartmentId" });
            DropTable("dbo.User");
            DropTable("dbo.Sale");
            DropTable("dbo.DetailSale");
            DropTable("dbo.Product");
            DropTable("dbo.Department");
            DropTable("dbo.Cut");
        }
    }
}
