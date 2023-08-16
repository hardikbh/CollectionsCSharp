using System;
namespace Collection
{					
public class Program
{
	public static void Main()
	{
		string [] daysOfWeek = {
		"Monday","Tuesday","Wednesday","Thrusday","Friday","Saturday","Sunday"};
        int iDays = int.Parse(Console.ReadLine());
		 Console.WriteLine($"Your day is {daysOfWeek[iDays]}");
		foreach(var days in daysOfWeek)
		{
			Console.WriteLine(days);
		}
		
}
}
}