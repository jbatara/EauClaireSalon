using Microsoft.AspNetCore.Mvc;
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

    [HttpGet("/")]
    public ActionResult Index()
    {

      return View();
    }
  }
}