namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedActivityIcollections : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Plans", "ActivityID");
            CreateIndex("dbo.Plans", "PeriodID");
            AddForeignKey("dbo.Plans", "ActivityID", "dbo.Activities", "ActivityID");
            AddForeignKey("dbo.Plans", "PeriodID", "dbo.Periods", "PeriodId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plans", "PeriodID", "dbo.Periods");
            DropForeignKey("dbo.Plans", "ActivityID", "dbo.Activities");
            DropIndex("dbo.Plans", new[] { "PeriodID" });
            DropIndex("dbo.Plans", new[] { "ActivityID" });
        }
    }
}
