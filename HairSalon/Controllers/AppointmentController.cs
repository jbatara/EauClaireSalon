using Microsoft.AspNetCore.Mvc;

namespace Salon.Controllers
{
  public class AppointmentController : Controller
  {

    public ActionResult Index()
    {
      return View();
    }
  }
}