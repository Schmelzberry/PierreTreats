
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TreatTracker.Controllers
{
  public class HomeController : Controller
  { 
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}