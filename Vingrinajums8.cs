using System;
					
public class Program
{
	public static void Main()
	{
    Console.WriteLine("Write age in numbers to get other planets age.");
      int earthAge = Convert.ToInt32(Console.ReadLine());

		int newEarthAge = (earthAge + 9);
		int jupiterAge = (earthAge / 12);
		Console.WriteLine("Your age is " + jupiterAge + " on Jupiter!");
        
    Console.WriteLine("Your arrival age is " + newEarthAge);
		

        }
    }
