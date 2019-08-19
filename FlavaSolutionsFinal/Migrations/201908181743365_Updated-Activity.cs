namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedActivity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "ModifiedBy", c => c.String());
            AddColumn("dbo.Activities", "ModifiedDdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Activities", "ModifiedDdate");
            DropColumn("dbo.Activities", "ModifiedBy");
        }
    }
}
