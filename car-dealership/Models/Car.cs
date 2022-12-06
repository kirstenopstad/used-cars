using System;

namespace Dealership.Models {

  public class Car 
  {
    // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    // Constructor
    public Car(string makeModel, int price, int miles)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
    }

    public static string MakeSounds(string sound)
    {
      return "Our cars sounds like " + sound;
    }

    // Adding in functionality to lower the cost of the cars by a percentage amount for a sales event.
    public double Discount(double percent)
    {
      int discountedPrice = Price - (int)(Price * percent);
      return Price = discountedPrice;
    }


  }
}