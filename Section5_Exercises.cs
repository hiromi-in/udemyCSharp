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
//Q2
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Type two numbers: ");
		Console.Write("First number: ");
		var firstNum = Convert.ToInt32(Console.ReadLine());
		Console.Write("Second number: ");
		var secondNum = Convert.ToInt32(Console.ReadLine());
		
		if (firstNum > secondNum)
		{
		Console.WriteLine("The biggest number is {0}", firstNum);
		}
		else if (firstNum < secondNum)
		{
		Console.WriteLine("The biggest number is {0}", secondNum);
		}
		else
		{
		Console.WriteLine("You've typed the same number!");	
		}
	}
}
