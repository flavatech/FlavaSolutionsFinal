namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPlans3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Plans", "PlanName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Plans", "PlanName", c => c.String(nullable: false));
        }
    }
}
