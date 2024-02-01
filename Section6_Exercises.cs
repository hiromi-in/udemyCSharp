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