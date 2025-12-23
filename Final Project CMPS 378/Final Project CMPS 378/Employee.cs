using System;
using System.Collections.Generic;
public class Employee
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string License { get; set; }

    public void AddUsername (List<string> usernames)
    {
        if (usernames.Contains(Username))
        {
            Console.Writeline("That username is already taken! Please enter another.");
            Username = Console.Writeline();
            AddUsername(usernames);
        }
        else
        {
            usernames.Add(Username);
        }
    }

    public void SearchUsername (List<string> usernames)
    {
    
    if (usernames.Contains(Username))
        {
            Console.Writeline(Username);
            Console.Writeline("Total number of rides: ");
            Console.Writeline("Total number of reviews: ");
            Console.Writeline("Number of 1 star reviews: ");
            Console.Writeline("Number of 2 star reviews: ");
            Console.Writeline("Number of 3 star reviews: ");
            Console.Writeline("Number of 4 star reviews: ");
            Console.Writeline("Number of 5 star reviews: ");
            Console.Writeline("Time working: ");
        }
    else
        {
            Console.Writeline("That username does not exist! Try again. ");
            Username = Console.Readline();
            SearchUsername(usernames);
        }
   }

   public void LeaveReview()
    {
        List<string> reviews = new List<string>();

        Console.Writeline("Here at Luxride, every customer is important");
        
        Console.Writeline("\n How would you rate your overall experience with Luxride? \n");
        reviews.Add(Console.Readline());

        Console.Writeline("\n What did you like about your Luxride experience? \n");
        reviews.Add(Console.Readline());

        Console.Writeline("\n What didn't you like about your Luxride experience? \n");
        reviews.Add(Console.Readline());

        Console.Writeline("\n If you could change something about your experience, what would it be? \n");
        reviews.Add(Console.Readline());

        Console.Writeline("\n Any additional comments/concerns? \n");
        reviews.Add(Console.Readline());

        Console.Writeline("\n Thank you for leaving a review. Your feedback is always appreciated! \n");

    }
}