using System.Linq;
using System.Web.Mvc;
using WebBPJ.Data;
using WebBPJ.Models;

namespace WebBPJ.Controllers
{
    public class ContatoController : Controller
    {
        private WebBPJContext db = new WebBPJContext();

        public ActionResult Index()
        {
            return View(db.Contatoes.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.LstContatos = db.Contatoes.ToList();
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contato contato)
        {
            if (ModelState.IsValid)
            {
                db.Contatoes.Add(contato);
                db.SaveChanges();

                ViewBag.LstContatos = db.Contatoes.ToList();
            }

            return View(contato);
        }

        public ActionResult Delete(int? id)
        {

            Contato contato = db.Contatoes.Find(id);
            db.Contatoes.Remove(contato);
            db.SaveChanges();

            ViewBag.LstContatos = db.Contatoes.ToList();

            return RedirectToAction("Create");

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
