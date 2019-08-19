namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modifieddatesinmodels3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "ActivityName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Activities", "ActivityName", c => c.String());
        }
    }
}
