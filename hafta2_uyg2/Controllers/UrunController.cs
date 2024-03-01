using hafta2_uyg2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hafta2_uyg2.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Index()
        {
            //List<string> urunler = new List<string> { "muz", "elma", "üzüm", "portakal" };

            List<Urun> products = new List<Urun>()
            {
                new Urun{ Id=1,Name="elma",Acıklama="amasya elması",Price=15,Resim="1.jpg" },
                new Urun{ Id=2,Name="uzum",Acıklama=" nigde  elması",Price=55,Resim="2.jpg" },
                 new Urun{ Id=3,Name="ayva",Acıklama="amasya ayvası",Price=15,Resim="3.jpg" },
                new Urun{ Id=4,Name="karpuz",Acıklama=" diyarbakır karpuzu  elması",Price=55,Resim="4.jpg" },
            };


            return View(products);
        }


        public ActionResult listele()
        {
            List<Urun> products = new List<Urun>()
            {
                new Urun{ Id=1,Name="elma",Acıklama="amasya elması",Price=15,Resim="fruite-item-1.jpg" },
                new Urun{ Id=2,Name="uzum",Acıklama=" nigde  elması",Price=55,Resim="fruite-item-2.jpg" },
                 new Urun{ Id=3,Name="ayva",Acıklama="amasya ayvası",Price=15,Resim="fruite-item-1.jpg" },
                new Urun{ Id=4,Name="karpuz",Acıklama=" diyarbakır karpuzu  elması",Price=55,Resim="fruite-item-4.jpg" },
            };


            return View(products);
        }
    }
}