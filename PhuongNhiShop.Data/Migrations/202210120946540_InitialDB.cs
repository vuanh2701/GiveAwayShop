namespace ReuseShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        DisplayName = c.String(nullable: false, maxLength: 256),
                        Password = c.String(maxLength: 256),
                        StaffID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staff", t => t.StaffID, cascadeDelete: true)
                .Index(t => t.StaffID);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        MidName = c.String(maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FullName = c.String(nullable: false, maxLength: 256),
                        DateBirth = c.DateTime(nullable: false),
                        NumberPhone = c.Int(nullable: false),
                        BankName = c.String(maxLength: 256),
                        BankAccount = c.String(maxLength: 50),
                        Address = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        QuantityGoods = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Address = c.String(nullable: false, maxLength: 256),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        BankName = c.String(maxLength: 256),
                        BankAccount = c.String(maxLength: 50),
                        Email = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Barcodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomnerID = c.Int(nullable: false),
                        ConsignmentID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consignments", t => t.ConsignmentID, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomnerID, cascadeDelete: true)
                .Index(t => t.CustomnerID)
                .Index(t => t.ConsignmentID);
            
            CreateTable(
                "dbo.Consignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(maxLength: 256),
                        Description = c.String(maxLength: 256),
                        CustomerID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 256),
                        Image = c.String(maxLength: 256),
                        PriceInput = c.Decimal(precision: 18, scale: 2),
                        PriceOutput = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(maxLength: 50),
                        DateInput = c.DateTime(nullable: false),
                        DateOutput = c.DateTime(nullable: false),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ConsignmentCategorys", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.ConsignmentCategorys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(maxLength: 256),
                        Description = c.String(maxLength: 256),
                        ParentID = c.Int(nullable: false),
                        Image = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        CreateBy = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        Status = c.String(maxLength: 50),
                        HomeFlag = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConsignmentTags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsignmentID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.Id, t.ConsignmentID, t.TagID })
                .ForeignKey("dbo.Consignments", t => t.ConsignmentID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ConsignmentID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50, unicode: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        URL = c.String(maxLength: 100),
                        GroupID = c.Int(nullable: false),
                        DisplayOrder = c.Int(),
                        Target = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuGroups", t => t.GroupID, cascadeDelete: true)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Description = c.String(maxLength: 256),
                        URL = c.String(nullable: false, maxLength: 100),
                        CreateDate = c.DateTime(nullable: false),
                        StaffID = c.Int(nullable: false),
                        CategoryNewID = c.Int(nullable: false),
                        ViewCount = c.Int(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoriesNews", t => t.CategoryNewID, cascadeDelete: true)
                .Index(t => t.CategoryNewID);
            
            CreateTable(
                "dbo.CategoriesNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Description = c.String(maxLength: 500),
                        ParentID = c.Int(),
                        HomeFlag = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NewTags",
                c => new
                    {
                        NewsID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.NewsID, t.TagID })
                .ForeignKey("dbo.News", t => t.NewsID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.NewsID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256, unicode: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(maxLength: 256),
                        Description = c.String(maxLength: 256),
                        ParentID = c.Int(nullable: false),
                        Image = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        CreateBy = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        Status = c.String(maxLength: 50),
                        HomeFlag = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(maxLength: 256),
                        Description = c.String(maxLength: 256),
                        CategoryID = c.Int(nullable: false),
                        CreateBy = c.String(nullable: false, maxLength: 50),
                        Image = c.String(maxLength: 256),
                        PriceInput = c.Decimal(precision: 18, scale: 2),
                        PriceOutput = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(maxLength: 50),
                        DateInput = c.DateTime(nullable: false),
                        DateOutput = c.DateTime(nullable: false),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        ViewCount = c.Int(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCategories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        TagID = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.TagID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(),
                        AppointmentID = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Appointments", t => t.AppointmentID, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerID)
                .Index(t => t.AppointmentID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                        Image = c.String(maxLength: 256),
                        Url = c.String(maxLength: 256),
                        DisplayOrder = c.Int(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        ValueString = c.String(maxLength: 50),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        VisitedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Schedules", "AppointmentID", "dbo.Appointments");
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.NewTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.NewTags", "NewsID", "dbo.News");
            DropForeignKey("dbo.News", "CategoryNewID", "dbo.CategoriesNews");
            DropForeignKey("dbo.Menus", "GroupID", "dbo.MenuGroups");
            DropForeignKey("dbo.ConsignmentTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.ConsignmentTags", "ConsignmentID", "dbo.Consignments");
            DropForeignKey("dbo.Barcodes", "CustomnerID", "dbo.Customers");
            DropForeignKey("dbo.Barcodes", "ConsignmentID", "dbo.Consignments");
            DropForeignKey("dbo.Consignments", "Id", "dbo.Customers");
            DropForeignKey("dbo.Consignments", "CategoryID", "dbo.ConsignmentCategorys");
            DropForeignKey("dbo.Appointments", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Account", "StaffID", "dbo.Staff");
            DropIndex("dbo.Schedules", new[] { "AppointmentID" });
            DropIndex("dbo.Schedules", new[] { "CustomerID" });
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.NewTags", new[] { "TagID" });
            DropIndex("dbo.NewTags", new[] { "NewsID" });
            DropIndex("dbo.News", new[] { "CategoryNewID" });
            DropIndex("dbo.Menus", new[] { "GroupID" });
            DropIndex("dbo.ConsignmentTags", new[] { "TagID" });
            DropIndex("dbo.ConsignmentTags", new[] { "ConsignmentID" });
            DropIndex("dbo.Consignments", new[] { "CategoryID" });
            DropIndex("dbo.Consignments", new[] { "Id" });
            DropIndex("dbo.Barcodes", new[] { "ConsignmentID" });
            DropIndex("dbo.Barcodes", new[] { "CustomnerID" });
            DropIndex("dbo.Appointments", new[] { "CustomerID" });
            DropIndex("dbo.Account", new[] { "StaffID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.Slides");
            DropTable("dbo.Schedules");
            DropTable("dbo.ProductTags");
            DropTable("dbo.Products");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Pages");
            DropTable("dbo.NewTags");
            DropTable("dbo.CategoriesNews");
            DropTable("dbo.News");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Footers");
            DropTable("dbo.Tags");
            DropTable("dbo.ConsignmentTags");
            DropTable("dbo.ConsignmentCategorys");
            DropTable("dbo.Consignments");
            DropTable("dbo.Barcodes");
            DropTable("dbo.Customers");
            DropTable("dbo.Appointments");
            DropTable("dbo.Staff");
            DropTable("dbo.Account");
        }
    }
}
