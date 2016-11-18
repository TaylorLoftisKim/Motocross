using Nancy;
using System.Collections.Generic;
using DirtBike.Objects;

namespace DirtBike
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      { var AllBrands = Brand.GetAllBrands();
        return View["index.cshtml", AllBrands];
      };
      Post["/add-bike"] = _ => {
        Brand newBrand = new Brand(Request.Form["new-brand"]);
        var AllBrands = Brand.GetAllBrands();
        return View["index.cshtml", AllBrands];
      };
    }
  }
}
