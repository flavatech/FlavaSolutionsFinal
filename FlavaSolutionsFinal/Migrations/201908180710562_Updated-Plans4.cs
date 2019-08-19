namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPlans4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plans", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Plans", "PlanName", c => c.String(nullable: false));
            DropColumn("dbo.Plans", "CreateBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plans", "CreateBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Plans", "PlanName", c => c.String());
            DropColumn("dbo.Plans", "CreatedBy");
        }
    }
}
