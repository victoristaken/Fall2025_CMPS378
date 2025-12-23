using System;
using System.Collections.Generic;

namespace Final_Project_CMPS_378
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int choice;
            List<string> usernames = new List<string>();

            Console.Writeline("Welcome to Luxride LA's Driver and Customer Management Platform!\n\n");

            do
            {
                Employee employee = new Employee();

                Console.Writeline("What would you like to do? \n");
                Console.Writeline("(1) Become a new driver \n");
                Console.Writeline("(2) Look up existing driver \n");
                Console.Writeline("(3) Leave a review \n");

                choice = Convert.ToInt32(Console.Readline());

                if (choice == 1)
                {
                    Console.Writeline("Enter your name: ");
                    employee.Name = Console.Readline();

                    Console.Writeline("Enter your email: ");
                    employee.Email = Console.Readline();

                    Console.Writeline("Enter your username: ");
                    employee.Username = Console.Readline();
                    employee.AddUsername(usernames);

                    Console.Writeline("Enter a valid license number: ");
                    employee.License = Console.Readline();

                }

                if (choice == 2)
                {
                    Console.Writeline("Enter a username: ");
                    employee.Username = Console.Readline;
                    employee.SearchUsername(usernames);
                }

                if (choice == 3)
                {
                    Employee.LeaveReview();
                }

                Console.Writeline("\n Is there anything else you want to do? (Yes/No) \n");
                answer = Console.Readline();

            } while (answer == "Yes" || answer == "YES" || answer == "yes");

            Console.Writeline("Thank you for using Luxride, have a nice day! \n\n");
        }

    }
}

