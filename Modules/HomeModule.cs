using Nancy;
using System.Collections.Generic;
using carDealership_2.Objects;

namespace carDealership_2
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/view_all_car"] = _ => {
        List<cars> allCar = cars.ShowInventory();
        return View["view_all_cars.cshtml", allCar];
      };
      Post["/cars_added"] = _ => {
        cars newCar = new cars(Request.Form["model"], Request.Form["miles"], Request.Form["price"]);
        newCar.Save();
        return View["cars_added.cshtml", newCar];
      };
      Post["/car_cleared"] = _ => {
        cars.ClearAll();
        return View["car_cleared.cshtml"];
      };
    }
  }
}
