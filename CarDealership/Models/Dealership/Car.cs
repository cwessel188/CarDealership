using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership.Models.Dealership
{
    public abstract class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string ImgSrc { get; set; }
        public string BreifDescription { get; set; }
        public string FullDescription { get; set; }

    }
}