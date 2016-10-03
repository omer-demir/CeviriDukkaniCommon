namespace Tangent.CeviriDukkani.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class careeradded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Common.CareerItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Location = c.String(),
                        PublishedTime = c.DateTime(nullable: false),
                        PersonCount = c.Int(nullable: false),
                        Detail = c.String(),
                        Active = c.Boolean(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("System.UserAbility", "FreelanceCompanyName", c => c.String());
            AddColumn("System.UserAbility", "Title", c => c.String());
            AddColumn("System.UserAbility", "Timezone", c => c.String());
            AddColumn("System.UserAbility", "WorkingDays", c => c.String());
            AddColumn("System.UserAbility", "WorkingHoursStart", c => c.String());
            AddColumn("System.UserAbility", "WorkingHoursEnd", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("System.UserAbility", "WorkingHoursEnd");
            DropColumn("System.UserAbility", "WorkingHoursStart");
            DropColumn("System.UserAbility", "WorkingDays");
            DropColumn("System.UserAbility", "Timezone");
            DropColumn("System.UserAbility", "Title");
            DropColumn("System.UserAbility", "FreelanceCompanyName");
            DropTable("Common.CareerItem");
        }
    }
}
