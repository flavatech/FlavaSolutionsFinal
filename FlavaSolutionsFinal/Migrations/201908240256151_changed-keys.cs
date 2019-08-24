namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedkeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserClaim", "Balance_Id", "dbo.Balances");
            DropForeignKey("dbo.UserLogins", "Balance_Id", "dbo.Balances");
            DropForeignKey("dbo.UserRoles", "Balance_Id", "dbo.Balances");
            DropIndex("dbo.UserClaim", new[] { "Balance_Id" });
            DropIndex("dbo.UserLogins", new[] { "Balance_Id" });
            DropIndex("dbo.UserRoles", new[] { "Balance_Id" });
            RenameColumn(table: "dbo.UserClaim", name: "Balance_Id", newName: "Balance_BalanceID");
            RenameColumn(table: "dbo.UserLogins", name: "Balance_Id", newName: "Balance_BalanceID");
            RenameColumn(table: "dbo.UserRoles", name: "Balance_Id", newName: "Balance_BalanceID");
            DropPrimaryKey("dbo.Balances");
            AlterColumn("dbo.Balances", "Id", c => c.String());
            AlterColumn("dbo.Balances", "BalanceID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.UserClaim", "Balance_BalanceID", c => c.Int());
            AlterColumn("dbo.UserLogins", "Balance_BalanceID", c => c.Int());
            AlterColumn("dbo.UserRoles", "Balance_BalanceID", c => c.Int());
            AddPrimaryKey("dbo.Balances", "BalanceID");
            CreateIndex("dbo.UserClaim", "Balance_BalanceID");
            CreateIndex("dbo.UserLogins", "Balance_BalanceID");
            CreateIndex("dbo.UserRoles", "Balance_BalanceID");
            AddForeignKey("dbo.UserClaim", "Balance_BalanceID", "dbo.Balances", "BalanceID");
            AddForeignKey("dbo.UserLogins", "Balance_BalanceID", "dbo.Balances", "BalanceID");
            AddForeignKey("dbo.UserRoles", "Balance_BalanceID", "dbo.Balances", "BalanceID");
            DropColumn("dbo.MemberAccounts", "Password");
            DropColumn("dbo.MemberAccounts", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberAccounts", "ConfirmPassword", c => c.String());
            AddColumn("dbo.MemberAccounts", "Password", c => c.String(nullable: false, maxLength: 100));
            DropForeignKey("dbo.UserRoles", "Balance_BalanceID", "dbo.Balances");
            DropForeignKey("dbo.UserLogins", "Balance_BalanceID", "dbo.Balances");
            DropForeignKey("dbo.UserClaim", "Balance_BalanceID", "dbo.Balances");
            DropIndex("dbo.UserRoles", new[] { "Balance_BalanceID" });
            DropIndex("dbo.UserLogins", new[] { "Balance_BalanceID" });
            DropIndex("dbo.UserClaim", new[] { "Balance_BalanceID" });
            DropPrimaryKey("dbo.Balances");
            AlterColumn("dbo.UserRoles", "Balance_BalanceID", c => c.String(maxLength: 128));
            AlterColumn("dbo.UserLogins", "Balance_BalanceID", c => c.String(maxLength: 128));
            AlterColumn("dbo.UserClaim", "Balance_BalanceID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Balances", "BalanceID", c => c.Int(nullable: false));
            AlterColumn("dbo.Balances", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Balances", "Id");
            RenameColumn(table: "dbo.UserRoles", name: "Balance_BalanceID", newName: "Balance_Id");
            RenameColumn(table: "dbo.UserLogins", name: "Balance_BalanceID", newName: "Balance_Id");
            RenameColumn(table: "dbo.UserClaim", name: "Balance_BalanceID", newName: "Balance_Id");
            CreateIndex("dbo.UserRoles", "Balance_Id");
            CreateIndex("dbo.UserLogins", "Balance_Id");
            CreateIndex("dbo.UserClaim", "Balance_Id");
            AddForeignKey("dbo.UserRoles", "Balance_Id", "dbo.Balances", "Id");
            AddForeignKey("dbo.UserLogins", "Balance_Id", "dbo.Balances", "Id");
            AddForeignKey("dbo.UserClaim", "Balance_Id", "dbo.Balances", "Id");
        }
    }
}
