using System;
using System.Collections;

namespace Karimova_stack
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack stack = new Stack();
      stack.Push("Первый");
      stack.Push("Второй");
      stack.Push("Третий");
      stack.Push("Четвёртый");
      while
      (stack.Count > 0)
      {
        object obj = stack.Pop();
        Console.WriteLine("From Stack: {0}", obj);
      }
    }
  }
}
