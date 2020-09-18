using System;
using System.Collections;

namespace AK
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList myList = new ArrayList();
      myList.Add("Ангелина");
      myList.Add("Тимофей");
      myList.Add("Настя");
      myList.Add("Егор");

      foreach (string item in myList)
      {
        Console.WriteLine("Unsorted: {0}", item);
      }
      myList.Sort();
      foreach (string item in myList)
      {
        Console.WriteLine("   Sorted: {0}", item);
      }
    }
  }
}
        