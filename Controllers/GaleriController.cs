using fotogaleri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 

namespace fotogaleri.Controllers
{
    public class GaleriController : Controller
    {
        // GET: Galeri
        public ActionResult Index()
        {


            List<Resim> result = new ResimModel();
            return View(result);
        }
    }
}