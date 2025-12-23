using System;

namespace Quiz1

{
    class Program
    {
    static void Main()
        {
        Console.WriteLine("Welcome to Taco Loco!");
        Console.WriteLine("Menu: ");
        Console.WriteLine("A - 3 Tacos Combo - $7.00 / $9.00 with drink");
        Console.WriteLine("B - Burrito Meal -  $8.50 / $10.50 with drink");
        Console.WriteLine("C - Quesadilla Meal - $6.00 / $8.00 with drink");
        Console.WriteLine("D - Loaded Nachos - $5.75 / $7.75 with drink");

        string name;
        char foodChoice, drinkChoice;
        int quantity;

        Console.WriteLine("\nEnter your name: ");
        name = Console.ReadLine();

        Console.WriteLine("Enter your menu choice (A, B, C, D): ");
        foodChoice = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Would you like a drink? (Y/N): ");
        drinkChoice = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("How many combos would you like? ");
        quantity = Convert.ToInt32(Console.ReadLine());

        double tacoPrice = 7.00, burritoPrice = 8.50, quesadillaPrice = 6.00, nachosPrice = 5.75;
        double subtotal,tax, total;
        double pricePerItem = 0, taxRate = 0.095;
        string combo = " ", drink = " ";

        switch (foodChoice)
            {
                case 'A':
                    combo = "3 Tacos Combo";
                    pricePerItem = tacoPrice;
                    if (drinkChoice == 'Y' || drinkChoice == 'y')
                    {
                        pricePerItem += 2.00;
                        drink = "Yes";
                    }
                    else
                    {
                        drink = "No";
                    }
                    break;

                case 'B':
                    combo = "Burrito Meal";
                    pricePerItem = burritoPrice;
                    if (drinkChoice == 'Y' || drinkChoice == 'y')
                    {
                        pricePerItem += 2.00;
                        drink = "Yes";
                    }
                    else
                    {
                        drink = "No";
                    }
                    break;
                case 'C':
                    combo = "Quesdailla Meal";
                    pricePerItem = quesadillaPrice;
                    if (drinkChoice == 'Y' || drinkChoice == 'y')
                    {
                        pricePerItem += 2.00;
                        drink = "Yes";
                    }
                    else
                    {
                        drink = "No";
                    }
                    break;
                case 'D':
                    combo = "Loaded Nachos";
                    pricePerItem = nachosPrice;
                    if (drinkChoice == 'Y' || drinkChoice == 'y')
                    {
                        pricePerItem += 2.00;
                        drink = "Yes";
                    }
                    else
                    {
                        drink = "No";
                    }
                    break;
            }
        
        subtotal = pricePerItem * quantity;
        tax = subtotal * taxRate;
        string formattedTax = tax.ToString("0.00");
        total = subtotal + tax;

        bool desert = false;

        if (subtotal >= 20.00)
            {
                desert = true;
            }

            Console.WriteLine("\nCustomer Name: " + name);
            Console.WriteLine("Combo Ordered: " + combo);
            Console.WriteLine("Drink Included: " + drink);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("\nPrice Per Item: $" + pricePerItem);
            Console.WriteLine("Subtotal: $" + subtotal);
            Console.WriteLine("Tax (9.5%): $" + formattedTax);
            Console.WriteLine("\nTotal Cost: $" + total);

            if (desert)
            {
                Console.WriteLine("Congratulations! You get a free desert!");
            }
            Console.WriteLine("\nThank you for supporting Taco Loco! \n");
        }
    }  
} 