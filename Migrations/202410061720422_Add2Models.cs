namespace PAdGWebAppMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add2Models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogArticleModels",
                c => new
                    {
                        BA_Id = c.Int(nullable: false, identity: true),
                        BA_Titolo = c.String(nullable: false),
                        BA_Categoria = c.String(nullable: false),
                        BA_Descrizione = c.String(nullable: false),
                        BA_URL = c.String(nullable: false),
                        BA_DataOra_Pubblicazione = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BA_Id);
            
            CreateTable(
                "dbo.BlogCategoryModels",
                c => new
                    {
                        BC_Id = c.Int(nullable: false, identity: true),
                        BC_Description = c.String(nullable: false),
                        BC_ShortDescr = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BC_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlogCategoryModels");
            DropTable("dbo.BlogArticleModels");
        }
    }
}
