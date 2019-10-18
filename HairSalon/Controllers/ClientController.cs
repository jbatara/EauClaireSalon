using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Salon.Models;

namespace Salon.Controllers
{
  public class ClientController : Controller
  {
    private readonly SalonContext _db;

    public ClientController(SalonContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult New()
    {
      List<Stylist> sList = _db.Stylists.ToList();
      List<SelectListItem> dropDownList = new List<SelectListItem>();
      foreach (Stylist s in sList)
      {
        SelectListItem item = new SelectListItem() { Text = "${s.FirstName} {s.LastName}", Value = $"{ s.StylistID }" };
        dropDownList.Add(item);
      }
      ViewBag.dropDownList = dropDownList;
      return View();
    }
  }
}