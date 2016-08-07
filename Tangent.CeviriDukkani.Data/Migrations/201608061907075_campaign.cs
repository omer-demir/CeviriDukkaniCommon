namespace Tangent.CeviriDukkani.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class campaign : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CampaignItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Description = c.String(),
                        DiscountRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Used = c.Boolean(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Sale.Order", "CampaignItemId", c => c.Int());
            CreateIndex("Sale.Order", "CampaignItemId");
            AddForeignKey("Sale.Order", "CampaignItemId", "dbo.CampaignItems", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Sale.Order", "CampaignItemId", "dbo.CampaignItems");
            DropIndex("Sale.Order", new[] { "CampaignItemId" });
            DropColumn("Sale.Order", "CampaignItemId");
            DropTable("dbo.CampaignItems");
        }
    }
}
