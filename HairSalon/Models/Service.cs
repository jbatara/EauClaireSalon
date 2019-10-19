using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Salon.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string Name {get;set;}
        public double Tier1Price { get; set; }
        public double Tier2Price { get; set; }
        public double Tier3Price { get; set; }

        public SelectListItem ToDropDownItem()
        {
        SelectListItem item = new SelectListItem { Text = $"{Name}", Value = $"{ ServiceID }" };
        return item;
        }

        public static List<SelectListItem> ListToDropDownItems(List<Service> services)
        {
        List<SelectListItem> list = new List<SelectListItem>();
        foreach (Service s in services)
        {
            list.Add(s.ToDropDownItem());
        }
        return list;
        }
    }
}