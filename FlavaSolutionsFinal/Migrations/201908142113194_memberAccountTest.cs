namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class memberAccountTest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MemberAccounts", "ApplicationUserId", "dbo.Users");
            DropIndex("dbo.MemberAccounts", new[] { "ApplicationUserId" });
            AddColumn("dbo.MemberAccounts", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.MemberAccounts", "ApplicationUserId", c => c.String());
            CreateIndex("dbo.MemberAccounts", "UserId");
            AddForeignKey("dbo.MemberAccounts", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.MemberAccounts", "AccountNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberAccounts", "AccountNumber", c => c.String(nullable: false));
            DropForeignKey("dbo.MemberAccounts", "UserId", "dbo.Users");
            DropIndex("dbo.MemberAccounts", new[] { "UserId" });
            AlterColumn("dbo.MemberAccounts", "ApplicationUserId", c => c.String(maxLength: 128));
            DropColumn("dbo.MemberAccounts", "UserId");
            CreateIndex("dbo.MemberAccounts", "ApplicationUserId");
            AddForeignKey("dbo.MemberAccounts", "ApplicationUserId", "dbo.Users", "Id");
        }
    }
}
