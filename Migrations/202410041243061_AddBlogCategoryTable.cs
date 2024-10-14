namespace PAdGWebAppMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogCategories",
                c => new
                    {
                        BC_Id = c.Int(nullable: false, identity: true),
                        BC_Description = c.Int(nullable: false),
                        BC_ShortDescr = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BC_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlogCategories");
        }
    }
}
