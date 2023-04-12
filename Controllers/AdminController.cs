using KisiselWebSitesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }
        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSayfas.Find(id);
            return View("AnaSayfaGetir", ag);
        }
        public ActionResult AnaSayfaGüncelle(AnaSayfa g)
        {
            var ag = c.AnaSayfas.Find(g.Id);
            ag.Isim = g.Isim;
            ag.Profil = g.Profil;
            ag.Unvan = g.Unvan;
            ag.Aciklama= g.Aciklama;
            ag.Iletisim = g.Iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult IkonListesi()
        {
            var deger = c.Ikonlar.ToList();
            return View(deger);
        }
        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIkon(ikonlar p)
        {
            c.Ikonlar.Add(p);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
        public ActionResult ikonGetir(int id)
        { 
            var ig = c.Ikonlar.Find(id);
            return View("ikonGetir",ig);
        }
        public ActionResult ikonGuncelle(ikonlar x)
        {
            var ig = c.Ikonlar.Find(x.Id);
            ig.Ikon = x.Ikon;
            ig.Link = x.Link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");
        }
        public ActionResult ikonSil(int id)
        {
            var sl = c.Ikonlar.Find(id);
            c.Ikonlar.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");


        }

    }
}