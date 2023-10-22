
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TreatTracker.Models;

namespace TreatTracker.Controllers
{
  public class HomeController : Controller
  { 
    private readonly TreatTrackerContext _db;

    public HomeController(TreatTrackerContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      Treat[] treats = _db.Treats.ToArray();
      Flavor[] flavors = _db.Flavors.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("treats", treats);
      model.Add("flavors", flavors);
      return View(model);
    }
  }
}