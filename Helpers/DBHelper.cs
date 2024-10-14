using PAdGWebAppMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace PAdGWebAppMVC.Helpers
{
    public class DBHelper
    {
            public static List<BlogArticle> GetArticles()
            {
                using (PAdGWebAppMVCDBContext db = new PAdGWebAppMVCDBContext())
                {
                    List<BlogArticle> articles = new List<BlogArticle>();
                    articles = db.BlogArticles.ToList();

                    if (articles.Any() == false)
                    {
                        return null;
                    }
                    else
                    {
                        return articles;
                    }
                }
            }

            public static List<BlogCategory> GetCategories()
            {
                using (PAdGWebAppMVCDBContext db = new PAdGWebAppMVCDBContext())
                {
                    List<BlogCategory> categories = new List<BlogCategory>();
                    categories = db.BlogCategories.ToList();

                    if (categories.Any() == false)
                    {
                        return null;
                    }
                    else
                    {
                        return categories;
                    }
                }
            }


        }
    }
