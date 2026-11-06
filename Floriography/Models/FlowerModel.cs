using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Floriography.Models
{
    public class FlowerModel
    {
        public char Letter { get; set; }
        public string Name { get; set; }
        public string Meaning { get; set; }
        public string ImageUrl { get; set; }
    }
}