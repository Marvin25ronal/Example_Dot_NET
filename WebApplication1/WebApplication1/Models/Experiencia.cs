using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Experiencia
    {
        private string title;
        private string description;
        private string from;
        private string to;

        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
    }
}