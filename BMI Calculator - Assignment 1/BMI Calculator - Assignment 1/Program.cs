using System;

namespace BMI_Calculator_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delcaring all necessary variables
            string name, BMIMeaning, gender;
            int age, heightFeet, heightInches, weight, inches;
            double BMI; // BMI is double since it will have a decimal

            // Input the user is asked
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine()); // Convert is used for all variables declared as int

            Console.WriteLine("Please enter your gender: ");
            gender = Console.ReadLine();

            Console.WriteLine("Please enter your height (feet): ");
            heightFeet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your height (inches): ");
            heightInches = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your weight in pounds: ");
            weight = Convert.ToInt32(Console.ReadLine());

            // Math used to calculate the BMI
            inches = (heightFeet * 12) + heightInches;
            double temp = inches * inches; // Temporary variable to break up equation in 2 steps
            BMI = 703 * (weight / temp);

            string formattedBMI = BMI.ToString("0.00"); // Makes sure BMI only goes to two digits after decimal

            // If else statements used to determine BMI's meaning
            if (BMI < 16)
            {
                BMIMeaning = "Severe Thinness";
            }
            else if (BMI >= 16 && BMI < 17)
            {
                BMIMeaning = "Moderate Thinness";
            }
            else if (BMI >= 17 && BMI <= 18.5)
            {
                BMIMeaning = "Mild Thinness";
            }
            else if (BMI > 18.5 && BMI < 25)
            {
                BMIMeaning = "Normal";
            }
            else if (BMI >= 25 && BMI < 30)
            {
                BMIMeaning = "Overweight";
            }
            else if (BMI >= 30 && BMI < 35)
            {
                BMIMeaning = "Obese Class 1";
            }
            else if (BMI >= 35 && BMI < 40)
            {
                BMIMeaning = "Obese Class 2";
            }
            else
            {
                BMIMeaning = "Obese Class 3";
            }

            // Output the user recieves
            Console.WriteLine("\nHello " + name + ", \n");
            Console.WriteLine("You are a " + gender + ". You are " + age + " years old. You are currently " 
            + heightFeet + "'" + heightInches + " and you currently weigh " + weight + " pounds. Your BMI is " 
            + formattedBMI + ", which is " + BMIMeaning + ". Thank you for using the BMI Calculator ! \n" );
        }
    }
}
