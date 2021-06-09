using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HobyController : Controller
    {
        // GET: Hoby
        public ActionResult Index()
        {
            return View();
        }
        //GET: Hoby/Random
        public ActionResult Random()
        {
            var hoby = new Hoby() { ID = 1, Name = "Ver peliculas", Photograpy = "f" };
            return View();   
        }
    }
}