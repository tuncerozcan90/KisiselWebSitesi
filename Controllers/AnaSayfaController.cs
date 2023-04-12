using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KisiselWebSitesi.Models.Siniflar;

namespace KisiselWebSitesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();

            return View(deger);
        }
        public PartialViewResult ikonlar()
        {
            var deger = c.Ikonlar.ToList();
            return PartialView(deger);
        }
    }
}