using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestProject.Data;

namespace TestProject.Controllers
{
  public class HomeController : Controller
  {
    private CarDbContext context;

    public HomeController(CarDbContext ctx)
    {
      context = ctx;
    }

    public IActionResult Index()
    {
      ViewBag.Message = "Cars Project App";
      return View(context.Cars);
    }
  }
}
