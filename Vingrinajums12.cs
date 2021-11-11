using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      double numberOne = 6.5;
      double numberTwo = 4;
      Console.WriteLine("Parādīt rezultātu, kas palielina skaitli numberOne pakāpe numberTwo " + numberOne + " " + numberTwo + "(X)");         
      Console.WriteLine("Parādīt rezultātu, kas noapaļo numberOne uz augšu - " + "{0} = {1}", numberOne, Math.Round(numberOne,MidpointRounding.AwayFromZero));
       if (numberOne > numberTwo)
       Console.WriteLine("Parādīt lielāku skaitli no numberOne un numberTwo -  " + numberOne);
   
     }
  }
}