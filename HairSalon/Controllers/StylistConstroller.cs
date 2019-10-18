using Microsoft.AspNetCore.Mvc;
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
  }
}