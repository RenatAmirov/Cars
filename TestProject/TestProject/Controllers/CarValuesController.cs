using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Data;
using TestProject.Data.Entities;

namespace TestProject.Controllers
{
  [Route("api/cars")]
  public class CarValuesController : Controller
  {
    private CarDbContext context;

    public CarValuesController(CarDbContext ctx)
    {
      context = ctx;
    }

    [HttpGet("{id}")]
    public CarEntity GetCar(long id)
    {
      return context.Cars.Find(id);
    }
  }
}
