using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using PAdGWebAppMVC.Models;

namespace PAdGWebAppMVC.Controllers
{
    public class BlogArticlesController : Controller
    {
        private PAdGWebAppMVCDBContext db = new PAdGWebAppMVCDBContext();
       
        // GET: BlogArticles
        public ActionResult Index()
        {
                var model = db.BlogArticles;
                return View(model);
        }

        // GET: BlogArticles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogArticle blogArticle = db.BlogArticles.Find(id);
            if (blogArticle == null)
            {
                return HttpNotFound();
            }
            return View(blogArticle);
        }

        // GET: BlogArticles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogArticles/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BA_Id,BA_Titolo,BA_Categoria,BA_Descrizione,BA_URL,BA_DataOra_Pubblicazione")] BlogArticle blogArticle)
        {
            if (ModelState.IsValid)
            {
                db.BlogArticles.Add(blogArticle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blogArticle);
        }

        // GET: BlogArticles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogArticle blogArticle = db.BlogArticles.Find(id);
            if (blogArticle == null)
            {
                return HttpNotFound();
            }
            return View(blogArticle);
        }

        // POST: BlogArticles/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BA_Id,BA_Titolo,BA_Categoria,BA_Descrizione,BA_URL,BA_DataOra_Pubblicazione")] BlogArticle blogArticle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blogArticle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogArticle);
        }

        // GET: BlogArticles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogArticle blogArticle = db.BlogArticles.Find(id);
            if (blogArticle == null)
            {
                return HttpNotFound();
            }
            return View(blogArticle);
        }

        // POST: BlogArticles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BlogArticle blogArticle = db.BlogArticles.Find(id);
            db.BlogArticles.Remove(blogArticle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
