using System;
using System.Collections.Generic;

namespace Cars.Models 
{
  class Type 
  {
    public int Year;
    public string Model;
    public string Color;
    public float Price;
    public void Car (int year,string model, string color, float price)
    {
      this.Year = year;
      this.Model = model;
      this.Color = color;
      this.Price = price;
    }

    public bool canAfford(float maxPrice)
    {
      if (this.Price < maxPrice)
      {
        return true;
      }
      return false;
    }

    public bool checkColor(string color)
    {
      if (this.Color == color)
      {
        return true;
      }
      return false;
    }

    public string printCars()
    {
      string outputCarsProperties = "Year: " + this.Year + ", Model: " + this.Model + 
      ", Color: " + this.Color + ", Price: " + this.Price;
      return outputCarsProperties;
    }

  }
}



  // class InterfaceProgramm
  //   {
  //       public static void Main()
  //       {
  //           Console.WriteLine("Please enter color: ");
  //           string inputColor = Console.ReadLine();
  //           Console.WriteLine("Please enter price: ");
  //           float inputPrice = float.Parse(Console.ReadLine());

  //           Car car1 = new Car(2000, "Honda", "Black", 5500);
  //           Car car2 = new Car(2009, "Nissan", "Red", 5000);
  //           Car car3 = new Car(2015, "Toyota", "Black", 15000);
  //           Car car4 = new Car(2015, "Ford", "White", 30000);
  //           Car car5 = new Car(2010, "Chevrolet", "Blue", 5600);

  //           List<Car> cars = new List<Car>(){car1, car2, car3, car4, car5};

  //           for (int idx = 0; idx < cars.Count; idx++)
  //           {
  //               if (cars[idx].checkColor(inputColor) && cars[idx].canAfford(inputPrice))
  //               {
  //                   Console.WriteLine(cars[idx].printCars());
  //               }
  //           }
            
  //       }
  //   }