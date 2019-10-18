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

    [HttpGet("/client")]
    public ActionResult Index()
    {
      ViewBag.clients = _db.Clients.OrderBy(c => c.LastName).ToList();
      ViewBag.stylists = _db.Stylists.OrderBy(s => s.StylistID).ToList();
      return View();
    }

    [HttpGet("/client/new")]
    public ActionResult New()
    {
      List<Stylist> sList = _db.Stylists.OrderBy(s => s.LastName).ToList();
      List<SelectListItem> dropDownList = new List<SelectListItem>();
      foreach (Stylist s in sList)
      {
        SelectListItem item = new SelectListItem() { Text = $"{s.FirstName} {s.LastName}", Value = $"{ s.StylistID }" };
        dropDownList.Add(item);
      }
      ViewBag.dropDownList = dropDownList;
      return View();
    }

    public ActionResult New(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      int id = client.ClientID;
      int stylistID = client.StylistID;

      return Redirect($"/stylist/{stylistID}/client/{id}");
    }

    [HttpGet("/stylist/{stylistID}/client/{id}")]
    public ActionResult Client(int stylistID, int id)
    {
      ViewBag.client = _db.Clients.FirstOrDefault(c => c.ClientID == id) as Client;
      return View();
    }
  }
}