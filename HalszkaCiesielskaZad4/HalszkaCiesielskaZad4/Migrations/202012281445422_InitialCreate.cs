namespace HalszkaCiesielskaZad4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnimalClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        CageId = c.Int(nullable: false),
                        AnimalClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AnimalClasses", t => t.AnimalClassId, cascadeDelete: true)
                .ForeignKey("dbo.Cages", t => t.CageId, cascadeDelete: true)
                .Index(t => t.CageId)
                .Index(t => t.AnimalClassId);
            
            CreateTable(
                "dbo.Cages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AmountOfPlaces = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        AnimalClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AnimalClasses", t => t.AnimalClassId, cascadeDelete: false)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .Index(t => t.AreaId)
                .Index(t => t.AnimalClassId);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 64),
                        LastName = c.String(nullable: false, maxLength: 64),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        Salary = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        Amount = c.Int(nullable: false),
                        Price = c.Single(nullable: false),
                        AnimalClassId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AnimalClasses", t => t.AnimalClassId, cascadeDelete: true)
                .Index(t => t.AnimalClassId);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nickname = c.String(nullable: false, maxLength: 64),
                        Password = c.String(nullable: false, maxLength: 64),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logins", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Foods", "AnimalClassId", "dbo.AnimalClasses");
            DropForeignKey("dbo.Employees", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Animals", "CageId", "dbo.Cages");
            DropForeignKey("dbo.Cages", "AreaId", "dbo.Areas");
            DropForeignKey("dbo.Cages", "AnimalClassId", "dbo.AnimalClasses");
            DropForeignKey("dbo.Animals", "AnimalClassId", "dbo.AnimalClasses");
            DropIndex("dbo.Logins", new[] { "EmployeeId" });
            DropIndex("dbo.Foods", new[] { "AnimalClassId" });
            DropIndex("dbo.Employees", new[] { "PositionId" });
            DropIndex("dbo.Cages", new[] { "AnimalClassId" });
            DropIndex("dbo.Cages", new[] { "AreaId" });
            DropIndex("dbo.Animals", new[] { "AnimalClassId" });
            DropIndex("dbo.Animals", new[] { "CageId" });
            DropTable("dbo.Logins");
            DropTable("dbo.Foods");
            DropTable("dbo.Positions");
            DropTable("dbo.Employees");
            DropTable("dbo.Areas");
            DropTable("dbo.Cages");
            DropTable("dbo.Animals");
            DropTable("dbo.AnimalClasses");
        }
    }
}
