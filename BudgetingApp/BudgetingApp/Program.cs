using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****** Welcome to Monthly Expense Tracker ******");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        double totalExpenses = 0.0;
        int expenseCount = 0;

        double rentTotal = 0.0;
        double groceriesTotal = 0.0;
        double utilitiesTotal = 0.0;
        double entertainmentTotal = 0.0;

        while (true)
        {
            Console.Write("Enter expense category (Rent, Groceries, Utilities, Entertainment) or 'done' to stop: ");
            string category = Console.ReadLine().ToLower();

            if (category == "done")
                break;

            Console.Write("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount == -1)
                break;

            if (amount < 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
                continue;
            }

            if (category == "rent")
                rentTotal += amount;
            else if (category == "groceries")
                groceriesTotal += amount;
            else if (category == "utilities")
                utilitiesTotal += amount;
            else if (category == "entertainment")
                entertainmentTotal += amount;
            else
            {
                Console.WriteLine("Invalid category. Expense not recorded.");
                continue;
            }

            totalExpenses += amount;
            expenseCount++;
        }

        string highestCategory = "Rent";
        double highestAmount = rentTotal;

        if (groceriesTotal > highestAmount)
        {
            highestAmount = groceriesTotal;
            highestCategory = "Groceries";
        }
        if (utilitiesTotal > highestAmount)
        {
            highestAmount = utilitiesTotal;
            highestCategory = "Utilities";
        }
        if (entertainmentTotal > highestAmount)
        {
            highestAmount = entertainmentTotal;
            highestCategory = "Entertainment";
        }

        Console.WriteLine("\n=========== MONTHLY EXPENSE SUMMARY ===========");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Total Expenses Entered: {expenseCount}");
        Console.WriteLine($"Total Amount Spent: ${totalExpenses:F2}");
        Console.WriteLine("---------------------------------------------");

        if (expenseCount > 0)
        {
            Console.WriteLine($"Rent Total: ${rentTotal:F2}");
            Console.WriteLine($"Groceries Total: ${groceriesTotal:F2}");
            Console.WriteLine($"Utilities Total: ${utilitiesTotal:F2}");
            Console.WriteLine($"Entertainment Total: ${entertainmentTotal:F2}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Highest Spending Category: {highestCategory} (${highestAmount:F2})");
        }
        else
        {
            Console.WriteLine("No expenses were entered.");
        }

        Console.WriteLine("=============================================");
        Console.WriteLine("Thank you for using the Monthly Expense Tracker!");
    }
}
