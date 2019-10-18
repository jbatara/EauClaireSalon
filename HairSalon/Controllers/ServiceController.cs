using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Salon.Models;

namespace Salon.Controllers
{
  public class ServiceController : Controller
  {
    private readonly SalonContext _db;

    public ServiceController(SalonContext db)
    {
      _db = db;
    }

    [HttpGet("/service")]
    public ActionResult Index()
    {
      ViewBag.services = _db.Services.OrderBy(s => s.ServiceID).ToList();
      return View();
    }

    [HttpGet("/service/new")]
    public ActionResult New()
    {
      return View();
    }

    public ActionResult New(Service service)
    {
      _db.Services.Add(service);
      _db.SaveChanges();
      return Redirect("/service");
    }
  }
}