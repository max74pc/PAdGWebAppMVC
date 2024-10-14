using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PAdGWebAppMVC.Models;

namespace PAdGWebAppMVC.ViewModel
{
    public class BlogArtCatViewModel
    {
        public List<BlogArticle> myBlogArticles { get; set; }

        public List<BlogCategory> myBlogCategories { get; set; }
    }
}