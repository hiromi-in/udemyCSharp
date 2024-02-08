//Q1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		 Console.WriteLine("Type numbers separated by a hyphen (e.g.5-6-7-8-9): ");
         var answer = Console.ReadLine();
		 var nums_list = new List<int>();
		 var result = true;
		 
		 foreach (var num in answer.Split('-'))
		     nums_list.Add(Convert.ToInt32(num));
		 
		 for (var i=0; i < nums_list.Count-1; i++){
		 	 if (!(nums_list[i+1] == nums_list[i] +1 || nums_list[i+1]+1 == nums_list[i])){
				 result = false;
				 Console.WriteLine("Not Consecutive");
				 break;
			 }		
		  }
		
		if (result == true){
		 	Console.WriteLine("Consecutive");
		 }	
	}
}

