using System;
using System.Globalization;
using System.Collections;
using System.Collections.Specialized;

namespace Karimova_slovar
{
  class Program
  {
    static void Main(string[] args)
    {
      ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
      list["Estados Unidos"] = "United States of America";
      list["Россия"] = "Россия";
      list["Эспаня"] = "Испания";
      Console.WriteLine(list["эспаня"]);
      Console.WriteLine(list["РОССИЯ"]);
      Console.Read();
    }
  }
}
