using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Skills
    {
        private string name;
        private int porcentaje;

        public string Name { get => name; set => name = value; }
        public int Porcentaje { get => porcentaje; set => porcentaje = value; }
    }
}