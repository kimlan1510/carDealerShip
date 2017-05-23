using System.Collections.Generic;
namespace carDealership_2.Objects
{
  public class cars
  {
    private string _model;
    private int _price;
    private int _miles;
    private int _id;
    private static List<cars> _instances = new List<cars>();
    public cars(string makeModel, int miles, int price)
    {
    SetModel(makeModel);
    SetPrice(price);
    SetMiles(miles);
    _id = _instances.Count;
    }

    public int GetId()
    {
      return _id;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }

    public string GetModel()
    {
      return _model;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetPrice()
    {
      return _price;
    }

    public static List<cars> ShowInventory()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static cars Find(int searchId)
    {
      return _instances[searchId ];
    }

    // Car porsche = new Car("2014 Porsche 911", 114991, 786);
    //
    // Car ford = new Car("2011 Ford F450", 55995, 14241);
    //
    // Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    //
    // Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);
    //
    // private static List<Car> _instances = new List<Car>()  { porsche, ford, lexus, mercedes };
    //
    // public static List<Car> ShowInventory()
    // {
    //   foreach(Car automobile in _instances)
    //   {
    //     List<string> inventory = new List<string>();
    //     inventory.Add(automobile.GetModel());
    //   }
    //   return inventory;
    // }



  }

}
