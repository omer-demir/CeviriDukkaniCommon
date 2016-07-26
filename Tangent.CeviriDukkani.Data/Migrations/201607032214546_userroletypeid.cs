using System.Data.Entity.Migrations;

namespace Tangent.CeviriDukkani.Data.Migrations
{
    public partial class userroletypeid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("System.UserRole", "UserRoleType_Id", "Common.UserRoleType");
            DropIndex("System.UserRole", new[] { "UserRoleType_Id" });
            RenameColumn(table: "System.UserRole", name: "UserRoleType_Id", newName: "UserRoleTypeId");
            AlterColumn("System.UserRole", "UserRoleTypeId", c => c.Int(nullable: false));
            CreateIndex("System.UserRole", "UserRoleTypeId");
            AddForeignKey("System.UserRole", "UserRoleTypeId", "Common.UserRoleType", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("System.UserRole", "UserRoleTypeId", "Common.UserRoleType");
            DropIndex("System.UserRole", new[] { "UserRoleTypeId" });
            AlterColumn("System.UserRole", "UserRoleTypeId", c => c.Int());
            RenameColumn(table: "System.UserRole", name: "UserRoleTypeId", newName: "UserRoleType_Id");
            CreateIndex("System.UserRole", "UserRoleType_Id");
            AddForeignKey("System.UserRole", "UserRoleType_Id", "Common.UserRoleType", "Id");
        }
    }
}
