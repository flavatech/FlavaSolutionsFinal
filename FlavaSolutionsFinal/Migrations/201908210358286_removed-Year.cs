namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedYear : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Periods", "Year");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Periods", "Year", c => c.String());
        }
    }
}
