//Q1.
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Type a number: ");
		int user_num = Convert.ToInt32(Console.ReadLine());
		if (user_num >=1 && user_num <= 10)
		{
			Console.WriteLine("Valid!");
		}
		else
		{
		Console.WriteLine("Invalid :(");
		}
		
	}
}
