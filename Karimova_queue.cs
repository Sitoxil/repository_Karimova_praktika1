using System;
using System.Collections;


namespace Karimova_queue
{
  class Program
  {
    static void Main(string[] args)
    {
      Queue queue = new Queue();
      queue.Enqueue("Ангелина");
      queue.Enqueue("8");
      queue.Enqueue("Егор");
      queue.Enqueue("Физика");
      while (queue.Count > 0)
      {
        object obj = queue.Dequeue();
        Console.WriteLine("From Queue: {0}", obj);
      }
    }
  }
}
