using Microsoft.AspNetCore.Mvc;

namespace Salon.Controllers
{
  public class AppointmentController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}