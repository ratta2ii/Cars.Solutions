using System;
using System.Collections.Generic;

namespace Cars.Models 
{
  public class Car 
  {
    public int Year { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Price { get; set; }
    private static List<Car> _instances = new List<Car> { };
    
    public Car (int year, string model, string color, int price)
    {
       Year = year;
       Model = model;
       Color = color;
       Price = price;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public bool CanAfford(int maxPrice)
    {
      if (this.Price < maxPrice)
      {
        return true;
      }
      return false;
    }

    public bool CheckColor(string color)
    {
      if (this.Color == color)
      {
        return true;
      }
      return false;
    }

    public string PrintCars()
    {
      string outputCarsProperties = "Year: " + this.Year + ", Model: " + this.Model + 
      ", Color: " + this.Color + ", Price: " + this.Price;
      return outputCarsProperties;
    }

  }
}

