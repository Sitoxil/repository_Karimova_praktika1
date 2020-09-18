using System;
using System.Collections;

namespace Karimova_table_search
{
  class Program
  {
    static void Main(string[] args)
    {
      Hashtable lookup = new Hashtable();
      lookup["0"] = "Ноль";
      lookup["1"] = "Один";
      lookup["2"] = "Два";
      lookup["3"] = "Три";
      lookup["4"] = "Четыре";
      lookup["5"] = "Пять";
      lookup["6"] = "Шесть";
      lookup["7"] = "Семь";
      lookup["8"] = "Восемь";
      lookup["9"] = "Девять";
      string ourNumber = "89771349005";
      foreach (char c in ourNumber)
      {
        string digit = c.ToString(); if (lookup.ContainsKey(digit))
        {
          Console.WriteLine(lookup[digit]);
        }
      }
    }
  }
}
