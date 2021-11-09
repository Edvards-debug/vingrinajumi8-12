using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int y = 12932;
      int x = -2828472;
      if (y > x)
      {
        Console.WriteLine("Mazākā vērtība - " + Math.Sqrt(y));
      }
    }
  }
}