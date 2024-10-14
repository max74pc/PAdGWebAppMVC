using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PAdGWebAppMVC.Models
{
    public class PAdGWebAppMVCDBContext : DbContext
    {
        public PAdGWebAppMVCDBContext() : base("PAdGWebAppMVCDBContext")
        {
            
        }
        public DbSet<BlogArticle> BlogArticles { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
