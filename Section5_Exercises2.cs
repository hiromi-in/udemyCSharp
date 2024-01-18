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

//Q2. Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

using System;
					
public class Program
{
	public static void Main()
	{
		var keep_asking = true;
		var count = 0;
			
		while (keep_asking){
		    Console.WriteLine("Type a number or 'ok': ");
			var answer = Console.ReadLine();
			if (answer == "ok"){
			    keep_asking = false;
			}
			else {
			count += Convert.ToInt32(answer);
			}	
		}
		
		Console.WriteLine("The sum is {0} :)", count);
	}
}

//Q3. Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Type a number: ");
		var num = Int32.Parse(Console.ReadLine());
		var count = num;
		
		for (var i = num-1; i >0; i--){
		     count *= i;
		}
		
		Console.WriteLine("{0}! = {1}", num, count);
		
	}
}
