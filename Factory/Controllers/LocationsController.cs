using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class LocationsController : Controller
  {
    private readonly FactoryContext _db;

    public LocationsController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Locations.ToList());
    }

    public ActionResult Details(int id)
    {
      Location thisLocation = _db.Locations
          .Include(location => location.JoinLocation)
          .ThenInclude(join => join.Machine)
          .FirstOrDefault(location => location.LocationId == id);
      return View(thisLocation);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Location location)
    {
      _db.Locations.Add(location);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddMachine(int id)
    {
      Location thisLocation = _db.Locations.FirstOrDefault(locations => locations.LocationId == id);
      ViewBag.MachineId = new SelectList(_db.Mahcines, "MachineId", "MachineName");
      return View(thisLocation);
    }

    [HttpPost]
    public ActionResult AddMachine(Location location, int machineId)
    {
      #nullable enable
      MachineLocation? joinEntity = _db.MachineLocations.FirstOrDefault(join => (join.MachineId == machineId && join.LocationId == location.LocationId));
      #nullable disable
      if (joinEntity == null && machineId != 0)
      {
        _db.MachineLocations.Add(new MachineLocation() { MachineId = machineId, LocationId = location.LocationId });
        _db.SaveChanges();
      }
      return RedirectToAction("Details", new { id = location.LocationId });
    }

    public ActionResult Edit(int id)
    {
      Location thisLocation = _db.Locations.FirstOrDefault(locations => locations.LocationId == id);
      return View(thisLocation);
    }

    [HttpPost]
    public ActionResult Edit(Location location)
    {
      _db.Locations.Update(location);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Location thisLocation = _db.Locations.FirstOrDefault(locations => locations.LocationId == id);
      return View(thisLocation);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Location thisLocation = _db.Locations.FirstOrDefault(locations => locations.LocationId == id);
      _db.Locations.Remove(thisLocation);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteJoin(int joinId)
    {
      MachineLocation joinEntry = _db.MachineLocations.FirstOrDefault(entry => entry.MachineLocationId == joinId);
      _db.MachineLocations.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}