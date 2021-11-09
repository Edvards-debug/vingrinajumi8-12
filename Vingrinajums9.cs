using System;

namespace AgePlanet //Vides nosaukums//
{
  class Program //Koda veids//
  {
    static void Main(string[] args) //Vienveida mainīgais ar iekšējo līniju//
    {
      Console.WriteLine("There is a saying: Two steps forward and one step back.' Check your steps:"); //Komanda, kas izsauc izvadošo daļu tekstam//
      string u_steps = Console.ReadLine(); //Rindiņas metode, kas izlasa līniju//

      int steps = Convert.ToInt32(u_steps); //Datu tips, kas mums nodrošina konvertāciju ar iekšējo metodi, un pieprasījumu//
      steps +=2; //Mainīgais + operators +=2//
      Console.WriteLine($"{steps}"); //Izvada tekstu, un izsauc mainīgo//
      steps--; // Mainīgais//
      Console.Write($"{steps}"); //Uzrakstīs mainīgo steps//
    }
  }
}