using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using TreatTracker.Models;

namespace TreatTracker.Controller 
{
  public class FlavorsController : Controller 
  {
    private readonly TreatTrackerContext _db;

    public FlavorsController(TreatTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> flavors = _db.Flavors.ToList();
      return View(flavors);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Flavor flavor)
    {
      _db.Flavors.Add(flavor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}