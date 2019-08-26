namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Balances",
                c => new
                    {
                        BalanceID = c.Int(nullable: false, identity: true),
                        MemberID = c.Int(),
                        CreatedDate = c.DateTime(),
                        PaymentTypeID = c.Int(),
                        PlanID = c.Int(),
                        TransactionID = c.Int(nullable: false),
                        TaxID = c.Int(nullable: false),
                        MBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        Id = c.String(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.BalanceID)
                .ForeignKey("dbo.MemberAccounts", t => t.MemberID)
                .ForeignKey("dbo.Transactions", t => t.TransactionID, cascadeDelete: true)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentTypeID)
                .ForeignKey("dbo.Plans", t => t.PlanID)
                .ForeignKey("dbo.Taxes", t => t.TaxID, cascadeDelete: true)
                .Index(t => t.MemberID)
                .Index(t => t.PaymentTypeID)
                .Index(t => t.PlanID)
                .Index(t => t.TransactionID)
                .Index(t => t.TaxID);
            
            AddColumn("dbo.UserRoles", "Balance_BalanceID", c => c.Int());
            AddColumn("dbo.Transactions", "PaymentAmount", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.UserClaim", "Balance_BalanceID", c => c.Int());
            AddColumn("dbo.UserLogins", "Balance_BalanceID", c => c.Int());
            AlterColumn("dbo.Plans", "PlanAmount", c => c.Double(nullable: false));
            AlterColumn("dbo.Plans", "TotalAmout", c => c.Int());
            AlterColumn("dbo.Taxes", "SalesTax", c => c.Double(nullable: false));
            CreateIndex("dbo.UserClaim", "Balance_BalanceID");
            CreateIndex("dbo.UserLogins", "Balance_BalanceID");
            CreateIndex("dbo.UserRoles", "Balance_BalanceID");
            AddForeignKey("dbo.UserClaim", "Balance_BalanceID", "dbo.Balances", "BalanceID");
            AddForeignKey("dbo.UserLogins", "Balance_BalanceID", "dbo.Balances", "BalanceID");
            AddForeignKey("dbo.UserRoles", "Balance_BalanceID", "dbo.Balances", "BalanceID");
            DropColumn("dbo.Periods", "PeriodName");
            DropColumn("dbo.Transactions", "PaymentDue");
            DropColumn("dbo.Transactions", "PaymentPaid");
            DropColumn("dbo.Transactions", "BalanceDue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "BalanceDue", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "PaymentPaid", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "PaymentDue", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Periods", "PeriodName", c => c.String());
            DropForeignKey("dbo.Balances", "TaxID", "dbo.Taxes");
            DropForeignKey("dbo.UserRoles", "Balance_BalanceID", "dbo.Balances");
            DropForeignKey("dbo.Balances", "PlanID", "dbo.Plans");
            DropForeignKey("dbo.Balances", "PaymentTypeID", "dbo.PaymentTypes");
            DropForeignKey("dbo.Balances", "TransactionID", "dbo.Transactions");
            DropForeignKey("dbo.Balances", "MemberID", "dbo.MemberAccounts");
            DropForeignKey("dbo.UserLogins", "Balance_BalanceID", "dbo.Balances");
            DropForeignKey("dbo.UserClaim", "Balance_BalanceID", "dbo.Balances");
            DropIndex("dbo.UserRoles", new[] { "Balance_BalanceID" });
            DropIndex("dbo.UserLogins", new[] { "Balance_BalanceID" });
            DropIndex("dbo.UserClaim", new[] { "Balance_BalanceID" });
            DropIndex("dbo.Balances", new[] { "TaxID" });
            DropIndex("dbo.Balances", new[] { "TransactionID" });
            DropIndex("dbo.Balances", new[] { "PlanID" });
            DropIndex("dbo.Balances", new[] { "PaymentTypeID" });
            DropIndex("dbo.Balances", new[] { "MemberID" });
            AlterColumn("dbo.Taxes", "SalesTax", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Plans", "TotalAmout", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Plans", "PlanAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.UserLogins", "Balance_BalanceID");
            DropColumn("dbo.UserClaim", "Balance_BalanceID");
            DropColumn("dbo.Transactions", "PaymentAmount");
            DropColumn("dbo.UserRoles", "Balance_BalanceID");
            DropTable("dbo.Balances");
        }
    }
}
