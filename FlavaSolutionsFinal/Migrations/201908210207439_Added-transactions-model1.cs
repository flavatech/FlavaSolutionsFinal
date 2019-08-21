namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedtransactionsmodel1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transactions", "PaymentType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "PaymentType", c => c.String());
        }
    }
}
