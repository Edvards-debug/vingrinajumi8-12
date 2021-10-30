using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
    string[] empty = new string[18];
		var students = empty.Count();
		Console.WriteLine(students + " kopejais studentu skaits");
		
		string[] grupas = {"grupa1", "grupa2", "grupa3", "grupa4", "grupa5", "grupa6"};
		students = grupas.Count();
		Console.WriteLine(students + " grupu skaits");
		
		int[] groupSize = {3,3,3};
		students = groupSize.Count();
		Console.WriteLine(students + " " + "Studentu skaits grupaa");
    }
}