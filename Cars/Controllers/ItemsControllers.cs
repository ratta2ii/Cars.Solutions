using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Cars.Models;

namespace Cars.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items/new")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Car> allItems = Car.GetAll();
      return View(allItems);
    }

    [HttpPost("/items")]
    public ActionResult Create(int year, string model, string color, int price)
    {
      Car firstCar = new Car(year, model, color, price);
      return RedirectToAction("Index");
    }
    
  }
}