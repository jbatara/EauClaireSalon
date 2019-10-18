using System;

namespace Salon.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Name {get;set;}
        public double Tier1Price { get; set; }
        public double Tier2Price { get; set; }
        public double Tier3Price { get; set; }
    }
}