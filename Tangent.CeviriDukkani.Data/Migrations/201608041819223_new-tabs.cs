namespace Tangent.CeviriDukkani.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtabs : DbMigration
    {
        public override void Up()
        {
            AddColumn("Common.Message", "Subject", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Common.Message", "Subject");
        }
    }
}
