namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedtransactionsmodel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        PaymentTypeID = c.Int(nullable: false, identity: true),
                        PaymentName = c.String(nullable: false),
                        Createdby = c.String(),
                        CreatedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.PaymentTypeID);
            
            AddColumn("dbo.Transactions", "PaymentTypeID", c => c.Int());
            CreateIndex("dbo.Transactions", "PaymentTypeID");
            AddForeignKey("dbo.Transactions", "PaymentTypeID", "dbo.PaymentTypes", "PaymentTypeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "PaymentTypeID", "dbo.PaymentTypes");
            DropIndex("dbo.Transactions", new[] { "PaymentTypeID" });
            DropColumn("dbo.Transactions", "PaymentTypeID");
            DropTable("dbo.PaymentTypes");
        }
    }
}
