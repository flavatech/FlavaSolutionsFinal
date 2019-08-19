namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedActivityAndPlan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Plans", "Createdby", c => c.String());
            AlterColumn("dbo.Plans", "ModifiedBy", c => c.String());
            DropColumn("dbo.Plans", "DeletedBy");
            DropColumn("dbo.Plans", "DeletedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plans", "DeletedDate", c => c.DateTime());
            AddColumn("dbo.Plans", "DeletedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Plans", "ModifiedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Plans", "Createdby", c => c.Int(nullable: false));
        }
    }
}
