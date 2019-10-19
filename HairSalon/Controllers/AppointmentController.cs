using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Salon.Models;

namespace Salon.Controllers
{
  public class AppointmentController : Controller
  {
    private readonly SalonContext _db;

    public AppointmentController(SalonContext db)
    {
      _db = db;
    }

    [HttpGet("/appointment")]
    public ActionResult Index()
    {
      ViewBag.appointments = _db.Appointments.OrderBy(a => a.AppointmentID).ToList();
      ViewBag.clients = _db.Clients.OrderBy(a => a.ClientID).ToList();
      ViewBag.stylists = _db.Stylists.OrderBy(a => a.StylistID).ToList();
      ViewBag.services = _db.Services.OrderBy(a => a.ServiceID).ToList();
      return View();
    }

    [HttpGet("/appointment/new")]
    public ActionResult New()
    {
      List<Service> services = _db.Services.OrderBy(s => s.ServiceID).ToList();
      List<Stylist> stylists = _db.Stylists.OrderBy(s => s.StylistID).ToList();
      List<Client> clients = _db.Clients.OrderBy(s => s.ClientID).ToList();
      ViewBag.ddServices = Service.ListToDropDownItems(services);
      ViewBag.ddStylists = Stylist.ListToDropDownItems(stylists);
      ViewBag.ddClient = Client.ListToDropDownItems(clients);
      
      return View();
    }

    public ActionResult New(Appointment appointment)
    {
      _db.Appointments.Add(appointment);
      _db.SaveChanges();
      int id = appointment.AppointmentID;

      return Redirect($"/appointment/{id}");

    }
  }
}