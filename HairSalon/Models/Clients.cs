using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Salon.Models
{
    public class Client
    {
        public int ClientID {get;set;}
        public string FirstName {get;set;}
        public string LastName { get; set; }
        public int StylistID {get;set;}


        public SelectListItem ToDropDownItem()
        {
            SelectListItem item = new SelectListItem { Text = $"{FirstName} {LastName}", Value = $"{ ClientID }" };
            return item;
        }

        public static List<SelectListItem> ListToDropDownItems(List<Client> clients)
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach(Client c in clients)
            {
                list.Add(c.ToDropDownItem());
            }
            return list;
        }
    }
}