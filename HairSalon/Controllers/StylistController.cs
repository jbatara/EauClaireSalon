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

    [HttpGet("/")]
    public ActionResult Index()
    {

      return View();
    }

    [HttpGet("/stylist/{id}")]
    public ActionResult Stylist(int id)
    {
        ViewBag.stylist = _db.Stylists.FirstOrDefault(s => s.StylistID == id) as Stylist;
        return View();
    }

    public ActionResult New()
    {
      return View();
    }

    public ActionResult New(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      int stylistID = stylist.StylistID;
      return RedirectToAction("Stylist", stylistID);
    }
  }
}