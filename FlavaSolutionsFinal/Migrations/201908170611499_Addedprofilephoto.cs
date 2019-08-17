namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedprofilephoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserPhoto", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "UserPhoto");
        }
    }
}
