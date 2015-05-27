using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership.Models.Dealership
{
    public class Tesla : Car
    {
        public Tesla()
        {
            Make = "Tesla";
        }
        public int Range { get; set; }
        public int ChargeTime { get; set; }
    }
}