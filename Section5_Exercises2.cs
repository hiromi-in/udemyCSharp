//Q1. Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

using System;
					
public class Program
{
	public static void Main()
	{
		var count = 0;
		for (int i=1; i<=100; i++)
		  {
		  if (i % 3==0)
		  {
		  count += 1;
		  }
		}
		Console.WriteLine("The number of divisible numbers by 3 is {0}", count);
	}
}

