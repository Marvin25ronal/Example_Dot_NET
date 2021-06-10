using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            dynamic array;
            using (StreamReader r=new StreamReader("C:/Users/marvi/OneDrive/Escritorio/Example_Dot_NET/WebApplication1/WebApplication1/JSON/Skills.json"))
            {
                string json = r.ReadToEnd();
                array = JsonConvert.DeserializeObject(json);
            }
            List<Skills> arreglo = new List<Skills>();
            foreach(var item in array.Skills)
            {
                Skills nueva = new Skills() { Name = item.name, Porcentaje = item.porcentaje };
                arreglo.Add(nueva);
                
            }
            dynamic array2;
            using (StreamReader r = new StreamReader("C:/Users/marvi/OneDrive/Escritorio/Example_Dot_NET/WebApplication1/WebApplication1/JSON/Experience.json"))
            {
                string json = r.ReadToEnd();
                array2 = JsonConvert.DeserializeObject(json);
            }
            List<Experiencia> arreglo2 = new List<Experiencia>();
            foreach (var item in array2.Experience)
            {
                Experiencia nueva = new Experiencia() { Description = item.description, From = item.from, Title = item.name, To = item.to };
                arreglo2.Add(nueva);

            }
            ViewData["Experience"] = arreglo2;
            ViewData["Datos"] = arreglo;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}