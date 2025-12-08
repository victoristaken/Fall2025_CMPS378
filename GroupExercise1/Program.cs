using System;

namespace GroupExercise1 
{
class Program
{
    static void Main(string[] args)
    {
        string gasStation;
        double pricePerGallon, gallons, taxRate, subtotal, Tax, total;

        Console.WriteLine("Enter the name of the gas station: ");
        gasStation = Console.ReadLine();

        Console.WriteLine("Enter the price per gallon: ");
        pricePerGallon = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the number of gallons purchased: ");
        gallons = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the sales tax rate (in decimal form): ");
        taxRate = Convert.ToDouble(Console.ReadLine());

        subtotal = pricePerGallon * gallons;
        Tax = subtotal * (taxRate/100);
        total = subtotal + Tax;

        string formattedSubtotal = subtotal.ToString("0.00");
        string formattedTax = Tax.ToString("0.00");
        string formattedTotal = total.ToString("0.00");

        Console.Write("--------");
        Console.Write(gasStation);
        Console.Write("--------\n");
        Console.WriteLine("Price: $" + pricePerGallon + " per gallon");
        Console.WriteLine("Number of gallons: " + gallons);
        Console.WriteLine("Tax Rate: " + taxRate + "%");
        Console.WriteLine("Subtotal: $" + formattedSubtotal);
        Console.WriteLine("Tax: $" + formattedTax);
        Console.WriteLine("Total: $" + formattedTotal + "\n");
    }    
}
}
