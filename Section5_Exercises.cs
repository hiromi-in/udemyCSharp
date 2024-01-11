//Q1. Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

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
//Q2. Write a program which takes two numbers from the console and displays the maximum of the two.

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

//Q3. Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Type the width and height of an image: ");
		Console.Write("Width: ");
		var width = Convert.ToInt32(Console.ReadLine());
		Console.Write("Height: ");
		var height = Convert.ToInt32(Console.ReadLine());
		
		if (width > height)
		{
		Console.WriteLine("The image is landscape!");
		}
		else if (width < height)
		{
		Console.WriteLine("The image is portrait!");
		}
		else
		{
		Console.WriteLine("It is a square!");	
		}
	}
}

//Q4. Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Type speed limit in km per hour: ");
		var km = Convert.ToInt32(Console.ReadLine());
		Console.Write("Now what is the speed of a car? ");
		var speed = Convert.ToInt32(Console.ReadLine());
		
		if (km >= speed)
		{
		Console.WriteLine("Ok!");
		}
		else if (km < speed)
		{
		var demerit_point = (speed-km)/5;
		  if (demerit_point == 0)
	  	  {
			Console.WriteLine("Ok!");
		  }
		  else
		  {
		  Console.WriteLine("Demerit point: {0}", demerit_point );
			if (demerit_point > 12)
			{
			Console.WriteLine("It is above 12! License Suspended :(");
			}
		  }
		}
	}
}
