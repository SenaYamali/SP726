using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WMVC_proje2.Models;

namespace WMVC_proje2.Controllers
{
    public class ElemanController : Controller
    {
        // GET: Eleman
        public ActionResult ElemanListele()

        {
            TESTEntities tst = new TESTEntities();
            List<Eleman> Elemanlar = tst.Elemen.ToList();
            ViewBag.ElemanCantasi = Elemanlar;
            return View();
        }

            [HttpPost] // Formdan gelen verileri Model aracılığı ile veritabanına kaydetmek için gerekli.(Yön: View'dan Vt'ye)
        public ActionResult ElemanEkle(string ad, string soyad, string sehir)
        {
            Eleman e1 = new Eleman();
            e1.Ad = ad;
           e1.Soyad = soyad;
            e1.Sehir = sehir;

            TESTEntities tst = new TESTEntities();
            tst.Elemen.Add(e1);
            tst.SaveChanges();
        

            return RedirectToAction("ElemanListele");
        }

        public ActionResult ElemanEkle()
        {
            return View();
        }

    }
    }
