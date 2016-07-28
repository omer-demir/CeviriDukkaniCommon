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

            AddColumn("Common.BankAccount", "PaypalEmailAddress", c => c.String());
            AddColumn("Common.BankAccount", "BeneficiaryAddress", c => c.String());
            AddColumn("Common.BankAccount", "AccountNumber", c => c.String());
            AddColumn("Common.BankAccount", "SwiftBicCode", c => c.String());
            AddColumn("Common.BankAccount", "CityCountryBank", c => c.String());
            AddColumn("Common.BankAccount", "BankAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("System.UserRole", "UserRoleTypeId", "Common.UserRoleType");
            DropIndex("System.UserRole", new[] { "UserRoleTypeId" });
            AlterColumn("System.UserRole", "UserRoleTypeId", c => c.Int());
            RenameColumn(table: "System.UserRole", name: "UserRoleTypeId", newName: "UserRoleType_Id");
            CreateIndex("System.UserRole", "UserRoleType_Id");
            AddForeignKey("System.UserRole", "UserRoleType_Id", "Common.UserRoleType", "Id");

            DropColumn("Common.BankAccount", "BankAddress");
            DropColumn("Common.BankAccount", "CityCountryBank");
            DropColumn("Common.BankAccount", "SwiftBicCode");
            DropColumn("Common.BankAccount", "AccountNumber");
            DropColumn("Common.BankAccount", "BeneficiaryAddress");
            DropColumn("Common.BankAccount", "PaypalEmailAddress");
        }
    }
}
