using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Salon.Models
{
    public class Stylist
    {
        public int StylistID { get; set; }
        public int StylistTier {get;set;}
        public string FirstName {get;set;}
        public string LastName { get; set; }

        public string Title()
        {
            if(StylistTier == 3)
            {
                return "Master Stylist";
            }
            else if (StylistTier == 2)
            {
                return "Stylist";
            }
            else
            {
                return "Apprentice";
            }
        }

        public string ImgURL()
        {
            // return $"/img/stylist/{FirstName}_{LastName}.jpg";
            return "/img/stylist/genericstylist.png";
        }

        public SelectListItem ToDropDownItem()
        {
        SelectListItem item = new SelectListItem { Text = $"{FirstName} {LastName}", Value = $"{ StylistID }" };
        return item;
        }

        public static List<SelectListItem> ListToDropDownItems(List<Stylist> stylists)
        {
        List<SelectListItem> list = new List<SelectListItem>();
        foreach (Stylist s in stylists)
        {
            list.Add(s.ToDropDownItem());
        }
        return list;
        }
        
    }


}