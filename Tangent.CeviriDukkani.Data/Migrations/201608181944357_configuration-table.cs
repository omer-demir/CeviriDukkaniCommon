namespace Tangent.CeviriDukkani.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class configurationtable : DbMigration
    {
        public override void Up()
        {
            AddColumn("Document.TranslationDocumentPart", "CharCount", c => c.Int(nullable: false));
            AddColumn("Document.TranslationDocumentPart", "CharCountWithSpaces", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Document.TranslationDocumentPart", "CharCountWithSpaces");
            DropColumn("Document.TranslationDocumentPart", "CharCount");
        }
    }
}
