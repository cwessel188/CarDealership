using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership.Models.Dealership
{
    public class RollsRoyce : Car
    {
        public RollsRoyce()
        {
            Make = "RollsRoyce";
        }
        public int GasMilage { get; set; }
    }
}