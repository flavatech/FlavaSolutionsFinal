namespace FlavaSolutionsFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        ActivityID = c.Int(nullable: false, identity: true),
                        ActivityName = c.String(nullable: false),
                        Createdby = c.String(),
                        Createddate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ActivityID);
            
            CreateTable(
                "dbo.MemberAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountNumber = c.String(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            CreateTable(
                "dbo.Periods",
                c => new
                    {
                        PeriodId = c.Int(nullable: false, identity: true),
                        FiscalyearFromDate = c.DateTime(),
                        FiscalyearToDate = c.DateTime(),
                        Year = c.String(),
                    })
                .PrimaryKey(t => t.PeriodId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanID = c.Int(nullable: false, identity: true),
                        PlanName = c.String(nullable: false),
                        PlanAmount = c.Double(nullable: false),
                        CreateBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                        RecStatus = c.String(),
                        ActivityID = c.Int(),
                        PeriodID = c.Int(),
                        TotalAmout = c.Int(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PlanID);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        YearsOfExperience = c.String(nullable: false),
                        Speciality = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PlanID = c.Int(),
                        ActivityID = c.Int(),
                        PaymentType = c.String(),
                        PaymentFromdt = c.DateTime(),
                        PaymentTodt = c.DateTime(),
                        PaymentAmount = c.Decimal(precision: 18, scale: 2),
                        NextRenwalDate = c.DateTime(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.Int(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        UserID = c.Long(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberAccounts", "ApplicationUserId", "dbo.Users");
            DropIndex("dbo.MemberAccounts", new[] { "ApplicationUserId" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Trainers");
            DropTable("dbo.Plans");
            DropTable("dbo.Periods");
            DropTable("dbo.MemberAccounts");
            DropTable("dbo.Activities");
        }
    }
}
