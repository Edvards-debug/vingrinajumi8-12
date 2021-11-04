using System;

class GFG {

	public static void Main()
	{
        int numberOne = 12932;
        int numberTwo = -2828472;
		double x = numberOne;
        double y = numberTwo;

        if (numberOne > numberTwo)
            Console.WriteLine(numberTwo);
        if (numberTwo > numberOne)
            Console.WriteLine(numberOne);

		Console.Write(Math.Sqrt(x));

	}
}
