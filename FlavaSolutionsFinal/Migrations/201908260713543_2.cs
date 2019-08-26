namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "AmountDue", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "TaxID", c => c.Int());
            AddColumn("dbo.Transactions", "AmountPaid", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "Balance", c => c.Decimal(precision: 18, scale: 2));
            CreateIndex("dbo.Transactions", "TaxID");
            AddForeignKey("dbo.Transactions", "TaxID", "dbo.Taxes", "TaxID");
            DropColumn("dbo.Transactions", "PaymentAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "PaymentAmount", c => c.Decimal(precision: 18, scale: 2));
            DropForeignKey("dbo.Transactions", "TaxID", "dbo.Taxes");
            DropIndex("dbo.Transactions", new[] { "TaxID" });
            DropColumn("dbo.Transactions", "Balance");
            DropColumn("dbo.Transactions", "AmountPaid");
            DropColumn("dbo.Transactions", "TaxID");
            DropColumn("dbo.Transactions", "AmountDue");
        }
    }
}
