namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modifieddatesinmodels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "Createddate", c => c.DateTime());
            AlterColumn("dbo.Plans", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Plans", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Plans", "DeletedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Plans", "DeletedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Plans", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Plans", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Activities", "Createddate", c => c.DateTime(nullable: false));
        }
    }
}
