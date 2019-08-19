namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedPlanController : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plans", "DeletedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Plans", "DeletedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Plans", "DeletedDate");
            DropColumn("dbo.Plans", "DeletedBy");
        }
    }
}
