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
      Get["/view_all_cars"] = _ => {
        List<cars> allCar = cars.ShowInventory();
        return View["view_all_cars.cshtml", allCar];
      };

      Get["/update_car/{id}"] = parameters => {
        cars car = cars.Find(parameters.id);
        return View["update_car.cshtml", car];
      };

      // Post["/update_car/{id}"] = parameters => {
      //   cars car = cars.Find(parameters.id);
      //   List<cars> allCar = cars.ShowInventory();
      //   cars newCar = new cars(Request.Form["model"], Request.Form["miles"], Request.Form["price"]);
      //   allCar[parameters.id] = newCar;
      //
      //   return View["update_car.cshtml/{id}", car];
      // };

      Post["/cars_added"] = _ => {
        cars newCar = new cars(Request.Form["model"], Request.Form["miles"], Request.Form["price"]);
        newCar.Save();
        return View["cars_added.cshtml", newCar];
      };

      Post["/car_cleared"] = _ => {
        cars.ClearAll();
        return View["car_cleared.cshtml"];
      };

      // Post["/update_car/{id}"] = parameters => {
      //   List<cars> allCar = cars.ShowInventory();
      //   allCar[parameters.id].GetModel = (Request.Form["model"]);
      //   allCar[parameters.id].GetMiles = (Request.Form["miles"]);
      //   allCar[parameters.id].GetPrice = (Request.Form["price"]);
      //   return View["update_car.cshtml", car];
      // };
    }
  }
}
