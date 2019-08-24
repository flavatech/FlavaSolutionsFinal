namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedbalancessalestax : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Balances", "TaxID", c => c.Int(nullable: false));
            CreateIndex("dbo.Balances", "TaxID");
            AddForeignKey("dbo.Balances", "TaxID", "dbo.Taxes", "TaxID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Balances", "TaxID", "dbo.Taxes");
            DropIndex("dbo.Balances", new[] { "TaxID" });
            DropColumn("dbo.Balances", "TaxID");
        }
    }
}
