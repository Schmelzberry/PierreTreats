using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using TreatTracker.Models;

namespace TreatTracker.Controllers
{
  public class TreatsController : Controller 
  {
    private readonly TreatTrackerContext _db;

    public TreatsController(TreatTrackerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> treats = _db.Treats.ToList();
      return View(treats);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Treat treat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(treat);
    }

    public ActionResult Edit(int id)
    {
      Treat treat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(treat);
    }

    [HttpPost]
    public ActionResult Edit(Treat treat)
    {
      _db.Treats.Update(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Treat treat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      return View(treat);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirm(int id)
    {
      Treat treat = _db.Treats.FirstOrDefault(treat => treat.TreatId == id);
      _db.Treats.Remove(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddFlavor(int id)
    {
      Treat treat = _db.Treats.FirstOrDefault(model => model.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
      return View(treat);
    }

    // [HttpPost]
    // public ActionResult AddFlavor(Treat treat, int flavorId)
    // {
    //   #nullable enable 

    // }

  }
}