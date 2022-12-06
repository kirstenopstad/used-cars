using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership 
{
  public class Program
  {
    public static void Main()
    {
      List<object> carsForSale = new List<object> {};
      bool finished = false;
      do
      {
        Console.WriteLine("Enter your car name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the cars' price");
        int price = int.Parse(Console.ReadLine());
        Console.WriteLine("How many miles?");
        int miles = int.Parse(Console.ReadLine());
        // carsForSale.Add(Car name = new Car(name, price, miles));
        Console.WriteLine("Would you like to add another car? Y/N");
        string check = Console.ReadLine();
        Console.WriteLine(check);
        if (check == "N")
        {
          finished = true;
        }
      }
      while (!finished);

      // // Use constructor to instantiate models
      // Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
      // Car yugo = new Car("1980 Yugo Koral", 700, 56000);
      // Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      // Car amc = new Car("1976 AMC Pacer", 400, 198000);

      // Console.WriteLine(yugo.Price);
      // Console.WriteLine(ford.Price);
      // Console.WriteLine(amc.Price);
      // Console.WriteLine(volkswagen.Price);

      // Console.WriteLine(Car.MakeSounds("beep!!!!!!!"));
      
      // yugo.Discount(.15);
      // Console.WriteLine(yugo.Price);
      // Console.WriteLine(ford.Price);
      // Console.WriteLine(amc.Price);
      // Console.WriteLine(volkswagen.Price);

      // Console.WriteLine(yugo.MakeModel);
      // yugo.MakeModel = "Worst Car Ever";
      // Console.WriteLine(yugo.MakeModel);2
    }
  }
}
