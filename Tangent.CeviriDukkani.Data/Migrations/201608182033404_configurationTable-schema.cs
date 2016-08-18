namespace Tangent.CeviriDukkani.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configurationTableschema : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CampaignItems", newName: "CampaignItem");
            MoveTable(name: "dbo.CampaignItem", newSchema: "Sale");
            CreateTable(
                "Common.Configuration",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        Value = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Common.Configuration");
            MoveTable(name: "Sale.CampaignItem", newSchema: "dbo");
            RenameTable(name: "dbo.CampaignItem", newName: "CampaignItems");
        }
    }
}
