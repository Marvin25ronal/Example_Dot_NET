using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Hoby
    {
        private string title;
        private string name;
        private string photograpy;



        public string Name { get => name; set => name = value; }
        public string Photograpy { get => photograpy; set => photograpy = value; }
        public string Title { get => title; set => title = value; }
    }
}