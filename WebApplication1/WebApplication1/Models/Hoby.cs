using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Hoby
    {
        private int iD;
        private string name;
        private string photograpy;

       
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Photograpy { get => photograpy; set => photograpy = value; }
    }
}