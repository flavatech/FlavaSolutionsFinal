namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedtransactionsmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "PeriodID", c => c.Int());
            CreateIndex("dbo.Transactions", "PlanID");
            CreateIndex("dbo.Transactions", "ActivityID");
            CreateIndex("dbo.Transactions", "PeriodID");
            AddForeignKey("dbo.Transactions", "ActivityID", "dbo.Activities", "ActivityID");
            AddForeignKey("dbo.Transactions", "PeriodID", "dbo.Periods", "PeriodId");
            AddForeignKey("dbo.Transactions", "PlanID", "dbo.Plans", "PlanID");
            DropColumn("dbo.Plans", "RecStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plans", "RecStatus", c => c.String());
            DropForeignKey("dbo.Transactions", "PlanID", "dbo.Plans");
            DropForeignKey("dbo.Transactions", "PeriodID", "dbo.Periods");
            DropForeignKey("dbo.Transactions", "ActivityID", "dbo.Activities");
            DropIndex("dbo.Transactions", new[] { "PeriodID" });
            DropIndex("dbo.Transactions", new[] { "ActivityID" });
            DropIndex("dbo.Transactions", new[] { "PlanID" });
            DropColumn("dbo.Transactions", "PeriodID");
        }
    }
}
