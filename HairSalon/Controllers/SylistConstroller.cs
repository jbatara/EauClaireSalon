using Microsoft.AspNetCore.Mvc;

namespace Salon.Controllers
{
  public class StylistController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}