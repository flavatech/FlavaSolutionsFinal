namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modifieddatesinmodels1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "ActivityName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Activities", "ActivityName", c => c.String(nullable: false));
        }
    }
}
