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
      return "Our cars sounds like" + sound;
    }

    // Functions below implicitly accomplished by the auto-implement properties above

    // public string MakeModel //public property
    // {
    //     get // a property accessor used to return the property value
    //     {
    //         return _makeModel; 
    //     }
    //     set // a property accessor used to assign a new value
    //     {
    //         _makeModel = value;
    //     }
    // }

  }
}