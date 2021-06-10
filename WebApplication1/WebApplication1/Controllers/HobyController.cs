using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            
            return View();   
        }
        public ActionResult Listado()
        {
            dynamic array;
            using (StreamReader r = new StreamReader("C:/Users/marvi/OneDrive/Escritorio/Example_Dot_NET/WebApplication1/WebApplication1/JSON/Pasatiempos.json"))
            {
                string json = r.ReadToEnd();
                array = JsonConvert.DeserializeObject(json);
            }
            List<Hoby> arreglo = new List<Hoby>();
            foreach (var item in array.Pasatiempos)
            {
                Hoby nueva = new Hoby() {Title= item.title,Name=item.description,Photograpy=item.img};
                arreglo.Add(nueva);

            }
            ViewData["Datos"] = arreglo;
            return View();
        }
    }
}