using System;
using System.Collections.Generic;

namespace Karimova_obob_nabor
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<int, String> countryLookup = new Dictionary<int, String>();
      countryLookup[44] = "Великобритания";
      countryLookup[33] = "Франция";
      countryLookup[31] = "Нидерланды";
      countryLookup[55] = "Бразилия";
      Console.WriteLine("55 индекс страны: {0}", countryLookup[55]);
      foreach (KeyValuePair<int, String> item in countryLookup)
      {
        int code = item.Key;
        string country = item.Value;
        Console.WriteLine("Индекс {0} = {1}", code, country);
      }

      Console.Read();
    }
  }
}
