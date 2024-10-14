namespace PAdGWebAppMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBlogCategoryTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BlogCategories", "BC_ShortDescr", c => c.String(nullable: false));
            AlterColumn("dbo.BlogCategories", "BC_Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BlogCategories", "BC_Description", c => c.Int(nullable: false));
            AlterColumn("dbo.BlogCategories", "BC_ShortDescr", c => c.Int(nullable: false));
        }
    }
}
