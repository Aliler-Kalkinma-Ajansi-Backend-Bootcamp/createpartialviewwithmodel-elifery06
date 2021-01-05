using Microsoft.AspNetCore.Mvc;
using partialview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace partialview.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            Urun urun = new Urun();
            urun.UrunAdi = "kalem";
            urun.UrunAdedi = 5;
            urun.UrunKodu = 5647;
            return View(urun);
        }
        //[HttpGet]
        //public IActionResult UrunEkle()
        //{
        //    return View();
        //}
        //[HttpPost]
        public IActionResult UrunEkle(Urun product)
        {
            Urun urun = new Urun();
            urun.UrunAdi = product.UrunAdi;
            urun.UrunAdedi = product.UrunAdedi;
            urun.UrunKodu = product.UrunKodu;
            return View(urun);
        }
    }
}
