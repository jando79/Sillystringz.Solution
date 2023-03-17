using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {

       [HttpGet("/")]
      public ActionResult Index()
      {
        // List<Location> locations = _db.Locations.ToList();
        // List<Machine> machines = _db.Machines.ToList();
        // List<Engineer> engineers = _db.Engineers.ToList();
        // ViewBag.locations = locations;
        // ViewBag.machines = machines;
        // ViewBag.engineers = engineers;
        return View();
      }
    }
}
