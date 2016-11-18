using System.Collections.Generic;

namespace DirtBike.Objects
{
  public class Brand
  {
    private string _name;
    private int _id;
    private static List<Brand> _instances = new List<Brand>{};

    public Brand (string name)
  {
    _name = name;
    _instances.Add(this);
    _id = _instances.Count;
  }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Brand> GetAllBrands()
    {
      return _instances;
    }
  }
}
