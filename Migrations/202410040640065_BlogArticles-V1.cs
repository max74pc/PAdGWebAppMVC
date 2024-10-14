namespace PAdGWebAppMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogArticlesV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogArticles",
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlogArticles");
        }
    }
}
