namespace Tangent.CeviriDukkani.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class capacti_rate_changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("Common.Capacity", "TranslationWorkingTypeId", c => c.Int(nullable: false));
            AddColumn("Common.Capacity", "ReviewsWorkingTypeId", c => c.Int(nullable: false));
            AddColumn("Common.Capacity", "ProofReadingWorkingTypeId", c => c.Int(nullable: false));
            AddColumn("System.RateItem", "CurrencyId", c => c.Int(nullable: false));
            CreateIndex("Common.Capacity", "TranslationWorkingTypeId");
            CreateIndex("Common.Capacity", "ReviewsWorkingTypeId");
            CreateIndex("Common.Capacity", "ProofReadingWorkingTypeId");
            CreateIndex("System.RateItem", "CurrencyId");
            //AddForeignKey("Common.Capacity", "ProofReadingWorkingTypeId", "Common.WorkingType", "Id", cascadeDelete: true);
            //AddForeignKey("Common.Capacity", "ReviewsWorkingTypeId", "Common.WorkingType", "Id", cascadeDelete: true);
            //AddForeignKey("Common.Capacity", "TranslationWorkingTypeId", "Common.WorkingType", "Id", cascadeDelete: true);
            //AddForeignKey("System.RateItem", "CurrencyId", "Common.Currency", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("System.RateItem", "CurrencyId", "Common.Currency");
            DropForeignKey("Common.Capacity", "TranslationWorkingTypeId", "Common.WorkingType");
            DropForeignKey("Common.Capacity", "ReviewsWorkingTypeId", "Common.WorkingType");
            DropForeignKey("Common.Capacity", "ProofReadingWorkingTypeId", "Common.WorkingType");
            DropIndex("System.RateItem", new[] { "CurrencyId" });
            DropIndex("Common.Capacity", new[] { "ProofReadingWorkingTypeId" });
            DropIndex("Common.Capacity", new[] { "ReviewsWorkingTypeId" });
            DropIndex("Common.Capacity", new[] { "TranslationWorkingTypeId" });
            DropColumn("System.RateItem", "CurrencyId");
            DropColumn("Common.Capacity", "ProofReadingWorkingTypeId");
            DropColumn("Common.Capacity", "ReviewsWorkingTypeId");
            DropColumn("Common.Capacity", "TranslationWorkingTypeId");
        }
    }
}
