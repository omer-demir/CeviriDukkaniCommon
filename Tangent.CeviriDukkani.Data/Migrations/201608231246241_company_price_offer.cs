namespace Tangent.CeviriDukkani.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class company_price_offer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sale.CompanyPriceOffer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        PricePerCharacter = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Common.Company", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Sale.CompanyPriceOffer", "CompanyId", "Common.Company");
            DropIndex("Sale.CompanyPriceOffer", new[] { "CompanyId" });
            DropTable("Sale.CompanyPriceOffer");
        }
    }
}
