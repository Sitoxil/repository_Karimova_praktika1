using System;
using System.Text.RegularExpressions;

namespace Karimoa
{
  class Program_Karimova
  {
    static void Main(string[] args)
    {
      string[] text ={"Ангелина",
        "Настя",
        " +79263772622",
        " 79263772622",
        " (926)3772622" };
        string pattern = @"[+]{0,1}[7]{0,1}[(]{0,1}\d{3}[)]{0,1}\d{3}[-]{0,1}\d{2}[-]{0,1}\d{2}";

      foreach (string item in text)
      {
        if (Regex.IsMatch(item, pattern))
        {
          
          Console.WriteLine(item + " это телефон");
        }
        else
        {
          Console.WriteLine(
            string.Format("{0} это НЕ телефон", item)
            );
        }

      }

    }
  }
}





