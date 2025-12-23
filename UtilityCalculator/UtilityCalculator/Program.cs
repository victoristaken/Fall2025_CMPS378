using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****** Welcome to LADWP Utility Bill Calculator ******");

        Console.Write("Enter your name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter electricity usage in kWh: ");
        double electricityUsage = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter water usage in HCF: ");
        double waterUsage = Convert.ToDouble(Console.ReadLine());

        double electricityRate;
        if (electricityUsage <= 199) {
            electricityRate = 0.13;
        }
        else if (electricityUsage <= 499) {
            electricityRate = 0.17;
        }
        else if (electricityUsage <= 999) {
            electricityRate = 0.21;
        }
        else {
            electricityRate = 0.26;
        }

        double waterRate;
        if (waterUsage <= 9) {
            waterRate = 2.30;
        }
        else if (waterUsage <= 24) {
            waterRate = 3.10;
        }
        else if (waterUsage <= 39) {
            waterRate = 4.20;
        }
        else {
            waterRate = 5.15;
        }

        double electricityCharge = electricityUsage * electricityRate;
        string formattedCharge = electricityCharge.ToString("0.00");
        double waterCharge = waterUsage * waterRate;
        double totalBill = electricityCharge + waterCharge;
        string formattedTotal = totalBill.ToString("0.00");

        Console.WriteLine("\n=========== LADWP MONTHLY BILL ===========");
        Console.WriteLine("Customer Name: " + customerName);
        Console.WriteLine("Electricity Usage: " + electricityUsage + " kWh");
        Console.WriteLine("Rate Applied: " + electricityRate + " per kWh");
        Console.WriteLine("Electricity Charge: " + formattedCharge);
        Console.WriteLine("Water Usage: " + waterUsage + "HCF");
        Console.WriteLine("Rate Applied: " + waterRate + "per HCF");
        Console.WriteLine("Water Charge: " + waterCharge);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Total Amount Due: " + formattedTotal);
        Console.WriteLine("==========================================");
        Console.WriteLine("Thank you for using LADWP!");
    }
}

