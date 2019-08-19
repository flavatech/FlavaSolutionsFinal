namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedActivityAndtransactions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "CreatedBy", c => c.String());
            AlterColumn("dbo.Transactions", "ModifiedBy", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "ModifiedBy", c => c.Int());
            AlterColumn("dbo.Transactions", "CreatedBy", c => c.Int());
        }
    }
}
