using System.Web.Mvc;
using System.Dynamic;
using PAdGWebAppMVC.Models;
using System.Collections.Generic;
using System.Linq;
using PAdGWebAppMVC.Helpers;
using PAdGWebAppMVC.ViewModel;
using System;
using PAdGWebAppMVC.Migrations;

namespace PAdGWebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
                BlogArtCatViewModel BACVM = new BlogArtCatViewModel();

                BACVM.myBlogArticles = DBHelper.GetArticles();
                BACVM.myBlogCategories = DBHelper.GetCategories();
                return View(BACVM);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
    
}