using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Salon.Models;

namespace Salon.Controllers
{
  public class StylistController : Controller
  {
    private readonly SalonContext _db;

    public StylistController(SalonContext db)
    {
      _db = db;
    }

    [HttpGet("/stylist")]
    public ActionResult Index()
    {
      ViewBag.stylists = _db.Stylists.ToList();
      return View();
    }

    [HttpGet("/stylist/{id}")]
    public ActionResult Stylist(int id)
    {
        ViewBag.stylist = _db.Stylists.FirstOrDefault(s => s.StylistID == id) as Stylist;
        return View();
    }

    [HttpGet("/stylist/new")]
    public ActionResult New()
    {
      List<SelectListItem> ddList = new List<SelectListItem>();
      SelectListItem Tier1 = new SelectListItem(){ Text = "Apprentice", Value = "1"};
      SelectListItem Tier2 = new SelectListItem() { Text = "Stylist", Value = "2" };
      SelectListItem Tier3 = new SelectListItem() { Text = "Master Stylist", Value = "3" };
      ddList.Add(Tier1);
      ddList.Add(Tier2);
      ddList.Add(Tier3);
      ViewBag.dropDownList = ddList;
      return View();
    }

    public ActionResult New(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      int stylistID = stylist.StylistID;
      return Redirect($"/stylist{stylistID}");
    }
  }
}