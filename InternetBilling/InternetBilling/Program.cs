using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****** Welcome to AT&T Fiber Internet Billing System ******");

        Console.Write("Enter your name: ");
        string customerName = Console.ReadLine();

        Console.Write("Select internet plan speed (300 / 500 / 1000 / 2000 / 5000 Mbps): ");
        int planSpeed = Convert.ToInt32(Console.ReadLine());

        Console.Write("Would you like to add a static IP? (Y/N): ");
        char staticIpChoice = Char.ToUpper(Console.ReadLine()[0]);

        double basePrice = 0.0;

        switch (planSpeed)
        {
            case 300:
                basePrice = 55.00;
                break;
            case 500:
                basePrice = 65.00;
                break;
            case 1000:
                basePrice = 80.00;
                break;
            case 2000:
                basePrice = 110.00;
                break;
            case 5000:
                basePrice = 180.00;
                break;
            default:
                Console.WriteLine("Invalid plan speed selected.");
                return;
        }

        double staticIpCost = (staticIpChoice == 'Y') ? 15.00 : 0.00;
        double subtotal = basePrice + staticIpCost;
        double tax = subtotal * 0.095;
        double total = subtotal + tax;

        Console.WriteLine("\n=========== AT&T FIBER BILLING SUMMARY ===========");
        Console.WriteLine($"Customer Name: {customerName}");
        Console.WriteLine($"Plan Speed: {planSpeed} Mbps");
        Console.WriteLine($"Base Price: ${basePrice:F2}");
        Console.WriteLine($"Static IP: ${staticIpCost:F2}");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Subtotal: ${subtotal:F2}");
        Console.WriteLine($"Tax (9.5%): ${tax:F2}");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine($"Total Due: ${total:F2}");
        Console.WriteLine("==================================================");
        Console.WriteLine("Thank you for choosing AT&T Fiber!");
    }
}

