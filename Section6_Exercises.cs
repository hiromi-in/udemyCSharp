//Q1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
/*
If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
*/

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var friends = new List<string>();
		var keep_asking = true;
		
		while (keep_asking){
		
			Console.WriteLine("Type a name who likes your post: ");
			var friend = Console.ReadLine();
			
			if (friend != ""){
				friends.Add(friend);
			}
			else if (friend == ""){
				keep_asking = false;
			}
		}
		
		if (friends.Count == 0 ){
 			Console.WriteLine("No one hasn't liked your post yet.");
		}
		else if (friends.Count == 1){
			Console.WriteLine($"{friends[0]} likes your post.");
		}
		else if (friends.Count == 2){
			Console.WriteLine($"{friends[0]} and {friends[1]} like your post.");
		}
		else {
			Console.WriteLine($"{friends[0]}, {friends[1]} and {friends.Count- 2} others like your post.");
		}
    }
}

//Q2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Type your name: ");
	   var name = Console.ReadLine();
	   char[] nameArray = name.ToCharArray();
		
		Console.WriteLine("Reversed name: ");
		Array.Reverse(nameArray);
   		foreach (var character in nameArray)
			Console.Write(character);
		
    }
}

Q3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
      var nums = new List<int>();	
		
	  while (nums.Count <5){
		    Console.WriteLine("Type an integer: ");
	  		var new_int = Int32.Parse(Console.ReadLine());
		  
		    if (nums.Contains(new_int)){
				Console.WriteLine($"{new_int} is already in the list. Please try another one.");
			}
		    else {
				nums.Add(new_int);
			} 
	  }
	    nums.Sort();
		Console.WriteLine($"Here are the numbers. I sorted them ascendingly for you :)");
		foreach (var number in nums){
		    Console.Write(number + " ");
		}
    }
}

//Q4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
      var keep_going = true;
	  var nums = new List<int>();
	  var unique_nums = new List<int>();
		
		while (keep_going){
			Console.WriteLine("Type a number or 'Quit' to quit the loop: ");
			var new_item = Console.ReadLine();
			
			if (new_item == "Quit"){
			   keep_going =false;
			}
			else {
			   nums.Add(Int32.Parse(new_item));
			}
		}
		
		foreach (var number in nums){
			if (!unique_nums.Contains(number)){
				unique_nums.Add(number);
			}
		}
		
		unique_nums.Sort();
		Console.Write("The unique numbers you've got are: ");
		foreach (var n in unique_nums)
			Console.Write(n + " ");
		
    }
}

//Q5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
	   var validInvalid = true;
	   var num_list = new List<int>();
		
	   while (validInvalid) {
       
	   Console.WriteLine("Enter a series of numbers separated by comma: ");
       var num_input = Console.ReadLine();
       int[] numbersArray = StringToArray(num_input);
       
       if (numbersArray.Length < 5){
	       Console.WriteLine("Invalid List. Please try again with more than five numbers.");   
	   } 
	   else {
	       foreach (var n in numbersArray){
	           num_list.Add(n);
	       }
	       validInvalid = false;
	   }
	   }
	   
       num_list.Sort();
	   Console.Write("Here are the three smallest numbers :) ");
	   for (var i = 0; i < 3; i++){
	       Console.Write(num_list[i] + " ");
	   }
		
    }
    
    public static int[] StringToArray(string num_input){
        string[] nums = num_input.Split(',');
        int[] numbersArray = new int[nums.Length];
        
        for (int i = 0; i<nums.Length; i++){
            if (int.TryParse(nums[i], out int number)){
                numbersArray[i] = number;
            }
            else{
                Console.WriteLine($"Error parsing element at index {i}: {nums[i]}");
            }
        }
        
        return numbersArray;
        
    }
}
