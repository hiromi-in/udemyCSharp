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

//Q2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		 Console.WriteLine("Type numbers separated by a hyphen (e.g.5-6-7-8-9): ");
         var answer = Console.ReadLine();
		 var nums_list = new List<int>();
		 var dup_list = new List<int>();
		
		 if (String.IsNullOrWhiteSpace(answer)){
		 	Console.WriteLine("Exiting the program. Please type numbers.");
		 }
		 else{	 
		 
		 foreach (var num in answer.Split('-'))
		     nums_list.Add(Convert.ToInt32(num));
		 
		 for (var i = 0; i < nums_list.Count; i++){
		 	     for ( var j=i+1; j < (nums_list.Count-i); j++){
				 	if (nums_list[i] == nums_list[j]){
						dup_list.Add(nums_list[i]);
						}
				     }
				 }
			}
		  if (dup_list.Count != 0 ){
			Console.Write("Duplicated values: ");
			  foreach (var num in dup_list)
				  Console.Write(num + " ");
			Console.WriteLine();
		  	Console.WriteLine("Duplicate");
		  }
			
		 }
}

//Q3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		 Console.WriteLine("Type a time value (e.g. 19:00): ");
         var answer = Console.ReadLine();
		 var h_m = new List<int>();
		 var validity = true; 
		 
		 if (String.IsNullOrWhiteSpace(answer)){
			validity = false;
		 }
		
		else{
		 foreach (var num in answer.Split(':'))
		     h_m.Add(Convert.ToInt32(num));
			
			if(!(h_m[0]<=23 && h_m[1] <=59)){
				validity = false;
			}
		}
		
		 if (validity == true){
		 	Console.WriteLine("Ok :)");
		 }
		 else {
		 	Console.WriteLine("Invalid time :(");
		 }
			
		 }
}

//Q4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Type a few words separated by a space: ");
		var words = Console.ReadLine().Split(' ');
		
        // Convert the first character of each word to uppercase and the rest to lowercase
        List<string> formattedWords = words.Select(FormatWord).ToList();

        // Print the formatted words
        foreach (string word in formattedWords)
        {
            Console.Write(word);
        }
    }

    static string FormatWord(string word)
    {
        // Create a TextInfo object for the current culture
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

        // Convert the first character of the word to uppercase and the rest to lowercase
        return textInfo.ToTitleCase(word.ToLower());
    }		
	}
