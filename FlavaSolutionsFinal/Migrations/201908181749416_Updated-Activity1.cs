namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedActivity1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Activities", "ModifiedDate", c => c.DateTime());
            DropColumn("dbo.Activities", "ModifiedDdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Activities", "ModifiedDdate", c => c.DateTime());
            DropColumn("dbo.Activities", "ModifiedDate");
        }
    }
}
